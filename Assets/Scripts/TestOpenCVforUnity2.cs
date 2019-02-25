using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenCVForUnity;

public class TestOpenCVforUnity2 : MonoBehaviour
{
	WebCamTexture webCamTexture;
	WebCamDevice webCamDevice;

	Color32[] colors;

	public bool isFrontFacing = false;

	public GameObject[] ringObj;

	//Standard height and width of webcam input
	static int width = 480;
	static int height = 640;

	//Number of Skin trackers
	static int NSAMPLES = 7;

	//Opencv Mat
	public static Mat frame, frame_pot, frame_hsv, frame_thresh_final, frameclone;
	public static Mat[] frame_thresh;

	//Texture
	public static Texture2D texture;

	bool initDone = false;
	static bool cap = true, initiate = true, proc = false, play = false;

	int square_len = 15, n;
	List<My_ROI> roi;

	int[,] avgColor = new int[NSAMPLES, 3];
	int[,] c_lower = new int[NSAMPLES, 3];
	int[,] c_upper = new int[NSAMPLES, 3];

	double angle_rot;
	float posX_new;
	float posY_new;
	double scale1, scale2, scale3, scale4, scale5;
	int ring_index = 0;

	//Variable for GUI
	public float minSwipeDistY;
	public float minSwipeDistX;

	// Start is called on the frame when a scipt is enabled
	void Start()
	{
		// Used for performing an action over multiple frames
		StartCoroutine(init());
	}

	private IEnumerator init()
	{
		if (webCamTexture != null) {
			webCamTexture.Stop();
			initDone = false;
			frame.Dispose ();
		}

		// Checks how many and which cameras are available on the device
		for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++) {
				
				if (WebCamTexture.devices [cameraIndex].isFrontFacing == isFrontFacing) {
					Debug.Log (cameraIndex + " name " + WebCamTexture.devices [cameraIndex].name + " isFrontFacing " + WebCamTexture.devices [cameraIndex].isFrontFacing);
					webCamDevice = WebCamTexture.devices [cameraIndex];
					webCamTexture = new WebCamTexture (webCamDevice.name, width, height);
					break;
				}
		}
			
		if (webCamTexture == null) {
			webCamDevice = WebCamTexture.devices[0];
			webCamTexture = new WebCamTexture (webCamDevice.name, width, height);
		}
			
		Debug.Log ("width " + webCamTexture.width + " height " + webCamTexture.height + " fps " + webCamTexture.requestedFPS);
			
		// Starts the camera
		webCamTexture.Play ();

		while (true) {
			//If you want to use webcamTexture.width and webcamTexture.height on iOS, you have to wait until webcamTexture.didUpdateThisFrame == 1, otherwise these two values will be equal to 16. (http://forum.unity3d.com/threads/webcamtexture-and-error-0x0502.123922/)
			#if UNITY_IOS && !UNITY_EDITOR && (UNITY_4_6_3 || UNITY_4_6_4 || UNITY_5_0_0 || UNITY_5_0_1)
			//if (webCamTexture.width > 16 && webCamTexture.height > 16) {
			#else
			if (webCamTexture.didUpdateThisFrame) {
				#endif
				Debug.Log ("width " + webCamTexture.width + " height " + webCamTexture.height + " fps " + webCamTexture.requestedFPS);
				Debug.Log ("videoRotationAngle " + webCamTexture.videoRotationAngle + " videoVerticallyMirrored " + webCamTexture.videoVerticallyMirrored + " isFrongFacing " + webCamDevice.isFrontFacing);
					
				colors = new Color32[webCamTexture.width * webCamTexture.height];
					
				frame = new Mat (webCamTexture.height, webCamTexture.width, CvType.CV_8UC3);
				frame_pot = new Mat (webCamTexture.width, webCamTexture.height, CvType.CV_8UC3);
				frame_hsv = new Mat (webCamTexture.width, webCamTexture.height, CvType.CV_8UC3);
				//final_thresh = new Mat(webCamTexture.height, webCamTexture.width, CvType.CV_8UC1);
				frame_thresh = new Mat[NSAMPLES];
				frame_thresh[0] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[1] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[2] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[3] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[4] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[5] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				frame_thresh[6] = new Mat(webCamTexture.width, webCamTexture.height, CvType.CV_8UC1);
				//Core.setIdentity (final_thresh, new Scalar(0,0,0));

				texture = new Texture2D (webCamTexture.width, webCamTexture.height, TextureFormat.RGB24, false);

				roi = new List<My_ROI>();

				c_lower[0,0] = 12; //12
				c_upper[0,0] = 7;  //7
				c_lower[0,1] = 30; //30
				c_upper[0,1] = 40; //40
				c_lower[0,2] = 80; //80
				c_upper[0,2] = 80; //80


				ringObj[0].SetActive(true);
				ringObj[1].SetActive(false);
				ringObj[2].SetActive(false);
				ringObj[3].SetActive(false);
				ringObj[4].SetActive(false);

				ringObj[0].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[1].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[2].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[3].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[4].transform.position = new Vector3(-320, 500, 0.0f);

				gameObject.transform.eulerAngles = new Vector3 (0, 0, 0);
				#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
				gameObject.transform.eulerAngles = new Vector3 (0, 0, -90);
				#endif

//				gameObject.transform.rotation = gameObject.transform.rotation * Quaternion.AngleAxis (webCamTexture.videoRotationAngle, Vector3.back);

				gameObject.transform.localScale = new Vector3 (webCamTexture.width, webCamTexture.height, 1);

//				bool videoVerticallyMirrored = webCamTexture.videoVerticallyMirrored;
//				float scaleX = 1;
//				float scaleY = videoVerticallyMirrored ? -1.0f : 1.0f;
//				if (webCamTexture.videoRotationAngle == 270)
//					scaleY = -1.0f;
//				gameObject.transform.localScale = new Vector3 (scaleX * gameObject.transform.localScale.x, scaleY * gameObject.transform.localScale.y, 1);


				gameObject.GetComponent<Renderer> ().material.mainTexture = texture;

				#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
				Camera.main.orthographicSize = webCamTexture.width / 2;
				#else
				Camera.main.orthographicSize = webCamTexture.height / 2;
				#endif

				initDone = true;
				break;
			} else {
				yield return 0;
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!initDone)
			return;

		if (webCamTexture.didUpdateThisFrame) {
						
			if (cap) {
				TextoMat();
				if(frame!=null){
					frame_pot = frame.t();
					Core.flip(frame_pot, frame_pot, 1);

					Imgproc.cvtColor(frame_pot, frame_hsv, Imgproc.COLOR_BGR2HSV);
					WaitForPalmCover();

					Core.flip (frame_pot, frame_pot, 1);
					frame = frame_pot.t();
					MattoTex();
				}
			} else if(initiate) {
				TextoMat();
				if(frame!=null){
					initiate = false;

					frame_pot = frame.t();
					Core.flip(frame_pot, frame_pot, 1);

					WaitForPalmCover();
					proc = true;
				}
			}

			if(proc){
				Average();
				produceBinaries();
				Process();

				Core.flip (frame_pot, frame_pot, 1);
				frame = frame_pot.t();

				MattoTex();
				proc = false;
				play = true;
			} 	
		}
	}

	void TextoMat(){
		Utils.webCamTextureToMat (webCamTexture, frame);

		if (webCamTexture.videoVerticallyMirrored) {
			if (webCamDevice.isFrontFacing) {
				if (webCamTexture.videoRotationAngle == 0) {
					Core.flip (frame, frame, 1);
				} else if (webCamTexture.videoRotationAngle == 90) {
					Core.flip (frame, frame, 0);
				} else if (webCamTexture.videoRotationAngle == 270) {
					Core.flip (frame, frame, 1);
				}
			} else {
				if (webCamTexture.videoRotationAngle == 90) {
					
				} else if (webCamTexture.videoRotationAngle == 270) {
					Core.flip (frame, frame, -1);
				}
			}
		} else {
			if (webCamDevice.isFrontFacing) {
				if (webCamTexture.videoRotationAngle == 0) {
					Core.flip (frame, frame, 1);
				} else if (webCamTexture.videoRotationAngle == 90) {
					Core.flip (frame, frame, 0);
				} else if (webCamTexture.videoRotationAngle == 270) {
					Core.flip (frame, frame, 1);
				}
			} else {
				if (webCamTexture.videoRotationAngle == 90) {
					
				} else if (webCamTexture.videoRotationAngle == 270) {
					Core.flip (frame, frame, -1);
				}
			}
		}
	}

	void MattoTex(){
		Utils.matToTexture2D (frame, texture);
		gameObject.GetComponent<Renderer> ().material.mainTexture = texture;
	}

	void MattoTexThresh(){
		Utils.matToTexture2D (frame_thresh_final, texture);
		gameObject.GetComponent<Renderer> ().material.mainTexture = texture;
	}

	void WaitForPalmCover(){
		My_ROI roi1 = new My_ROI (width / 2 - 4 * square_len, height / 2 + 2 * square_len, square_len);
		My_ROI roi2 = new My_ROI (width / 2 + 4 * square_len, height / 2 + 2 * square_len, square_len);
		My_ROI roi3 = new My_ROI (width / 2 - 4 * square_len, height / 2 + 10 * square_len, square_len); 
		My_ROI roi4 = new My_ROI (width / 2 + 4 * square_len, height / 2 + 10 * square_len, square_len);
		My_ROI roi5 = new My_ROI (width / 2 + 3 * square_len, height / 3 - 2 * square_len, square_len);
		My_ROI roi6 = new My_ROI (width / 2 - 4 * square_len, height / 3 - 2 * square_len, square_len);
		My_ROI roi7 = new My_ROI (width / 2, height / 2 + 6 * square_len, square_len);
		
		roi.Add (roi1);
		roi.Add (roi2);
		roi.Add (roi3);
		roi.Add (roi4);
		roi.Add (roi5);
		roi.Add (roi6);
		roi.Add (roi7);

		if (initiate) {
			for (int i=0; i<NSAMPLES; i++) {
				roi[i].draw_rectangle();
			}
			roi.Clear();
			string imText = "Cover trackers";
			Core.putText(frame_pot, imText, new Point(100, 100), Core.FONT_HERSHEY_COMPLEX, 1.0, new Scalar(255, 0, 0));
		
			//Cv.AddWeighted(frame , 1.0, hand_img, 1.0, 0.0, frame);
		}
	}

	void Average(){
		for(int i=0; i<NSAMPLES; i++)
			GetAvgColor(i);
	}

	void GetAvgColor(int t){
		Mat r_hsv = new Mat ();
		r_hsv = roi [t].roi_ptr.clone ();
		List<int> hm = new List<int>();
		List<int> sm = new List<int>();
		List<int> lm = new List<int>();
		byte[] data = new byte[3];
		for (int i=2; i<(r_hsv.height() - 2); i++) {
			for (int j=2; j<(r_hsv.width() - 2); j++) {
				r_hsv.get(i, j, data);
				hm.Add((int)data[0]);
				sm.Add((int)data[1]);
				lm.Add((int)data[2]);
			}
		}
		avgColor[t, 0] = getMedian(hm);
		avgColor[t, 1] = getMedian(sm);
		avgColor[t, 2] = getMedian(lm);
	}

	int getMedian(List<int> val){
		int median;
		int size = val.Count;
		val.Sort ();
		if (size % 2 == 0)
			median = val[size/2];
		else
			median = val[size/2 + 1];
		return median;
	}

	void produceBinaries(){
		Scalar lowerBound, upperBound;
		normalizeColors ();
		for (int i=0; i<NSAMPLES; i++) {
			lowerBound = new Scalar (avgColor [i,0] - c_lower [i,0], avgColor [i,1] - c_lower [i,1], avgColor [i,2] - c_lower [i,2]);
			upperBound = new Scalar (avgColor [i,0] + c_upper [i,0], avgColor [i,1] + c_upper [i,1], avgColor [i,2] + c_upper [i,2]);
			Core.inRange(frame_hsv, lowerBound, upperBound, frame_thresh[i]);
			//Cv.Smooth (frame_thresh[i], frame_thresh[i], SmoothType.Median, 7);
		}

		frame_thresh_final = frame_thresh [0];
		for (int i=1; i<NSAMPLES; i++) {
			Core.add ( frame_thresh_final, frame_thresh[i], frame_thresh_final); 
		}

		Imgproc.medianBlur (frame_thresh_final, frame_thresh_final, 1);
		Imgproc.medianBlur (frame_thresh_final, frame_thresh_final, 3);
		Imgproc.medianBlur (frame_thresh_final, frame_thresh_final, 5);
		Imgproc.medianBlur (frame_thresh_final, frame_thresh_final, 7);
	}


	void normalizeColors(){
		for(int i=1;i<NSAMPLES;i++){
			for(int j=0;j<3;j++){
				c_lower[i,j]=c_lower[0,j];	
				c_upper[i,j]=c_upper[0,j];	
			}	
		}
		
		for(int i=0;i<NSAMPLES;i++){
			if((avgColor[i,0]-c_lower[i,0]) <0){
				c_lower[i,0] = avgColor[i,0] ;
			}if((avgColor[i,1]-c_lower[i,1]) <0){
				c_lower[i,1] = avgColor[i,1] ;
			}if((avgColor[i,2]-c_lower[i,2]) <0){
				c_lower[i,2] = avgColor[i,2] ;
			}if((avgColor[i,0]+c_upper[i,0]) >255){ 
				c_upper[i,0] = 255-avgColor[i,0] ;
			}if((avgColor[i,1]+c_upper[i,1]) >255){
				c_upper[i,1] = 255-avgColor[i,1] ;
			}if((avgColor[i,2]+c_upper[i,2]) >255){
				c_upper[i,2] = 255-avgColor[i,2] ;
			}
		}
	}


	void Process(){
		Mat hierarchy = new Mat ();
		List<MatOfPoint> contours = new List<MatOfPoint> ();
		MatOfPoint maxitem = new MatOfPoint ();
		MatOfInt hullInt = new MatOfInt ();
		
		frameclone = frame_thresh_final.clone ();
		
		Imgproc.findContours (frameclone, contours, hierarchy, Imgproc.RETR_LIST , Imgproc.CHAIN_APPROX_NONE);
		
		maxitem = contours[0];
		n = 0;
		for(int i=0; i<contours.Count; i++){
			
			if(contours[i].total() > maxitem.total()){
				maxitem = contours[i];
				n=i;
			}
		}
		
		OpenCVForUnity.Rect bRect = Imgproc.boundingRect (maxitem);
		int bRect_height =  bRect.height;
		int bRect_width = bRect.width;
		
		Imgproc.drawContours(frame_thresh_final, contours, n, new Scalar(255, 255, 255), -1);
		Imgproc.convexHull( maxitem, hullInt);
		
		List<Point> maxitemPointList = maxitem.toList ();
		List<int> hullIntList = hullInt.toList ();
		List<Point> hullPointList = new List<Point> ();
		
		for (int j=0; j < hullInt.toList().Count; j++) {
			hullPointList.Add (maxitemPointList [hullIntList[j]]);
		}
		
		MatOfPoint hullPointMat = new MatOfPoint ();
		
		hullPointMat.fromList (hullPointList);
		
		List<MatOfPoint> hullPoints = new List<MatOfPoint> ();
		
		hullPoints.Add (hullPointMat);
		
		//Imgproc.drawContours (frame, hullPoints, -1, new Scalar (0, 255, 0), 2);
		
		MatOfInt4 convexityDef = new MatOfInt4 ();
		Imgproc.convexityDefects (maxitem, hullInt, convexityDef);
		
		List<int> conDefIntList = convexityDef.toList ();
		List<Point> startpts = new List<Point> ();
		List<Point> farpts = new List<Point> ();
		List<Point> endpts = new List<Point> ();
		
		double defx1 = 1000, defx2 = 1000;
		int countx1 = 0, countx2 = 0;
		int tolerance = (int)(bRect_height/5.5);
		int count = 0, index = 0;
		//Debug.Log ("Tolerance: " + tolerance);
		double angleTol = 95.0;
		int[] defarray = new int[100];
		//CvFont font = new CvFont (FontFace.Vector0, 1.0, 1.0);
		for(int i=0; i < conDefIntList.Count/4 ; i++){
			startpts.Add(maxitemPointList[conDefIntList[4*i]]);
			endpts.Add(maxitemPointList[conDefIntList[4*i+1]]);
			farpts.Add(maxitemPointList[conDefIntList[4*i+2]]);
			
			Point s = startpts[i];
			Point e = endpts[i];
			Point f = farpts[i];
			
			if( GetAngle(s, f, e) < angleTol && GetDistance(s,f) > tolerance && GetDistance(e,f) > tolerance ){
				//string text = Convert.ToString(count);
				//Debug.Log("Depth1: "+GetDistance(s,f));
				//Debug.Log("Depth2: "+GetDistance(e,f));
				//Core.circle( frame_pot, f, 10, new Scalar(0, 0, 255), -1);
				//Core.circle( frame_pot, s, 10, new Scalar(0, 255, 0), -1);
				//Core.circle( frame_pot, e, 10, new Scalar(255, 0, 0), -1);
				//Core.putText(frame_pot, text, f, Core.FONT_HERSHEY_COMPLEX , 1.0, new Scalar(255, 255, 255)); 
				//frame_pot.PutText(text, f, font, CvColor.White);
				
				if(f.x < defx1){
					defx2 = defx1;
					countx2 = countx1;
					defx1 = f.x;
					countx1 = count;
				}
				else if(f.x < defx2)
				{
					defx2 = f.x;
					countx2 = count;
				}
				defarray[count] = index;
				count++;
			}
			index++;
		}
		//Debug.Log ("Count: " + count);
		//Debug.Log ("Total: " + farpts.Count);
		
		Point point1 = farpts [defarray [countx1]];
		Point point2 = farpts [defarray [countx2]];

		//Core.circle (frame_pot, point1, 15, new Scalar (255, 0, 0), 2);
		//Core.circle (frame_pot, point2, 15, new Scalar (255, 0, 0), 2);

		point1.y -= 5; 
		double posX = (point1.x + point2.x)/2.0;
		double posY = (point1.y + point2.y)/2.0;
		
		posX_new = (float)(posX - 240);
		posY_new = (float)(-posY + 320);

		double dist = Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
		scale1 = dist * 500000 / 640.0; 
		scale2 = dist * 700 / 640.0;
		scale3 = dist * 600 / 640.0;
		scale4 = dist * 15 / 640.0;
		scale5 = dist * 70 / 640.0;

		ringObj[0].transform.position = new Vector3(posX_new, posY_new, 0.0f);
		ringObj[1].transform.position = new Vector3(posX_new, posY_new, 0.0f);
		ringObj[2].transform.position = new Vector3(posX_new, posY_new, 0.0f);
		ringObj[3].transform.position = new Vector3(posX_new, posY_new, 0.0f);
		ringObj[4].transform.position = new Vector3(posX_new, posY_new, 0.0f);

		ringObj[0].transform.localScale = new Vector3((float)scale1, (float)scale1, (float)(scale1*1.5));
		ringObj[1].transform.localScale = new Vector3((float)scale2, (float)scale2, (float)(scale2));
		ringObj[2].transform.localScale = new Vector3((float)scale3, (float)scale3, (float)(scale3));
		ringObj[3].transform.localScale = new Vector3((float)scale4, (float)scale4, (float)(scale4));
		ringObj[4].transform.localScale = new Vector3((float)scale5, (float)scale5, (float)(scale5));
		
		Point point3 = new Point(point1.x, point2.y);
		angle_rot = GetAngle( point1, point2, point3);
		ringObj[0].transform.RotateAround( new Vector3(posX_new, posY_new, 0.0f), Vector3.forward, (float)angle_rot);
		ringObj[1].transform.RotateAround( new Vector3(posX_new, posY_new, 0.0f), Vector3.forward, (float)angle_rot);
		ringObj[2].transform.RotateAround( new Vector3(posX_new, posY_new, 0.0f), Vector3.forward, (float)angle_rot);
		ringObj[3].transform.RotateAround( new Vector3(posX_new, posY_new, 0.0f), Vector3.forward, (float)angle_rot);
		ringObj[4].transform.RotateAround( new Vector3(posX_new, posY_new, 0.0f), Vector3.forward, (float)angle_rot);
	}

	private double GetAngle(Point s, Point f, Point e){
		double l1 = GetDistance(f, s);
		double l2 = GetDistance(f, e);
		double dot = (s.x-f.x)*(e.x-f.x) + (s.y-f.y)*(e.y-f.y);
		double angle = Math.Acos(dot/(l1*l2));
		angle = angle * 180 / Math.PI;
		return angle;
	}
	
	private double GetDistance(Point p1, Point p2)
	{
		return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
	}
	

	void OnDisable ()
	{
		webCamTexture.Stop ();
	}
	
	void OnGUI ()
	{
		minSwipeDistX = (float)(Screen.width / 4);
		minSwipeDistY = (float)(Screen.height / 4);


			#if (UNITY_ANDROID || UNITY_IOS)
		//Android
		int touchCount = Input.touchCount;

		if (touchCount == 1)
		{
			
			Touch touch = Input.GetTouch(0);
				
			Vector3 touchPos; touchPos.x=touch.position.x; touchPos.y=touch.position.y; touchPos.z = 0.0f;
			Vector3 currentLocation; currentLocation.x = ringObj[0].transform.position.x; currentLocation.y = ringObj[0].transform.position.y; currentLocation.z = Camera.main.nearClipPlane;
			Vector3 touchPos3D = Camera.main.WorldToScreenPoint(touchPos);
			ringObj[0].transform.position = touchPos3D;
		}

		#endif


		GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
		myButtonStyle.fontSize = 80;


		if(cap){
			if( GUI.Button(new UnityEngine.Rect(0.0f,(float)(7*Screen.height/8), Screen.width, (float)(Screen.height/8)), "Capture", myButtonStyle)){
				cap = false;
			}
		}
		else{
			//GUI.Label(new UnityEngine.Rect(0.0f,(float)(5*Screen.height/8),(float)(Screen.width), (float)(Screen.height/8)), "X= "+touchx+" Y= "+touchy);


			if( GUI.Button(new UnityEngine.Rect(0.0f,(float)(6*Screen.height/8),(float)(Screen.width/2), (float)(Screen.height/8)), "Prev", myButtonStyle)){
				ring_index--;
				if(ring_index==-1)
					ring_index=4;
				else
					ring_index = ring_index%5;

				ringObj[0].SetActive(false);
				ringObj[1].SetActive(false);
				ringObj[2].SetActive(false);
				ringObj[3].SetActive(false);
				ringObj[4].SetActive(false);

				ringObj[ring_index].SetActive(true);
			}

			if( GUI.Button(new UnityEngine.Rect((float)(Screen.width/2), (float)(6*Screen.height/8), (float)(Screen.width/2), (float)(Screen.height/8)), "Next", myButtonStyle)){
				ring_index = (ring_index+1)%5;

				ringObj[0].SetActive(false);
				ringObj[1].SetActive(false);
				ringObj[2].SetActive(false);
				ringObj[3].SetActive(false);
				ringObj[4].SetActive(false);
				
				ringObj[ring_index].SetActive(true);
			}

			if( GUI.Button(new UnityEngine.Rect(0.0f,(float)(7*Screen.height/8), Screen.width, (float)(Screen.height/8)), "Reset", myButtonStyle)){
				cap = true;
				initiate = true;
				proc = false;
				play = false;
				ring_index = 0;

				ringObj[0].transform.localRotation = Quaternion.Euler(270.0f, 0.0f, 0.0f);
				ringObj[1].transform.localRotation = Quaternion.Euler(270.0f, 0.0f, 0.0f);
				ringObj[2].transform.localRotation = Quaternion.Euler(-27.5f, 0.0f, 0.0f);
				ringObj[3].transform.localRotation = Quaternion.Euler(270.0f, 0.0f, 0.0f);
				ringObj[4].transform.localRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);

				ringObj[0].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[1].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[2].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[3].transform.position = new Vector3(-320, 500, 0.0f);
				ringObj[4].transform.position = new Vector3(-320, 500, 0.0f);
			}
		}

	}

	public class My_ROI{
		public Mat roi_ptr;
		Size size;
		int cornerx, cornery, sqlen;
		
		public My_ROI(int u_corner_x, int u_corner_y, int sq_len){
			cornerx = u_corner_x;
			cornery = u_corner_y;
			sqlen = sq_len;
			roi_ptr = frame_hsv.submat(cornery, cornery + sqlen, cornerx, cornerx + sqlen);
		}
		
		public void draw_rectangle(){
			Core.rectangle (frame_pot, new Point (cornerx, cornery), new Point (cornerx + sqlen, cornery + sqlen), new Scalar(0, 255, 0), 2);
		}
	}


}
