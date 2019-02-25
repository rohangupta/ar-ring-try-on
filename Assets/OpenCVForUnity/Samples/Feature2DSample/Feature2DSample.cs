﻿using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnitySample
{
		/// <summary>
		/// Feature2D sample.
		/// </summary>
		public class Feature2DSample : MonoBehaviour
		{

				// Use this for initialization
				void Start ()
				{


						Texture2D imgTexture = Resources.Load ("lena") as Texture2D;
			
						Mat img1Mat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC3);
						Utils.texture2DToMat (imgTexture, img1Mat);
						Debug.Log ("img1Mat dst ToString " + img1Mat.ToString ());

						Mat img2Mat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC3);
						Utils.texture2DToMat (imgTexture, img2Mat);
						Debug.Log ("img2Mat dst ToString " + img2Mat.ToString ());



						float angle = UnityEngine.Random.Range (0, 360), scale = 1.0f;

						Point center = new Point (img2Mat.cols () * 0.5f, img2Mat.rows () * 0.5f);

						Mat affine_matrix = Imgproc.getRotationMatrix2D (center, angle, scale);

						Imgproc.warpAffine (img1Mat, img2Mat, affine_matrix, img2Mat.size ());


						FeatureDetector detector = FeatureDetector.create (FeatureDetector.ORB);
						DescriptorExtractor extractor = DescriptorExtractor.create (DescriptorExtractor.ORB);

						MatOfKeyPoint keypoints1 = new MatOfKeyPoint ();
						Mat descriptors1 = new Mat ();

						detector.detect (img1Mat, keypoints1);
						extractor.compute (img1Mat, keypoints1, descriptors1);

						MatOfKeyPoint keypoints2 = new MatOfKeyPoint ();
						Mat descriptors2 = new Mat ();
		
						detector.detect (img2Mat, keypoints2);
						extractor.compute (img2Mat, keypoints2, descriptors2);


						DescriptorMatcher matcher = DescriptorMatcher.create (DescriptorMatcher.BRUTEFORCE_HAMMINGLUT);
						MatOfDMatch matches = new MatOfDMatch ();

						matcher.match (descriptors1, descriptors2, matches);


						Mat resultImg = new Mat ();

						Features2d.drawMatches (img1Mat, keypoints1, img2Mat, keypoints2, matches, resultImg);



						Texture2D texture = new Texture2D (resultImg.cols (), resultImg.rows (), TextureFormat.RGBA32, false);
		
						Utils.matToTexture2D (resultImg, texture);

						gameObject.GetComponent<Renderer> ().material.mainTexture = texture;

				}
	
				// Update is called once per frame
				void Update ()
				{
	
				}

				void OnGUI ()
				{
						float screenScale = Screen.width / 240.0f;
						Matrix4x4 scaledMatrix = Matrix4x4.Scale (new Vector3 (screenScale, screenScale, screenScale));
						GUI.matrix = scaledMatrix;
		
		
						GUILayout.BeginVertical ();
						if (GUILayout.Button ("back")) {
								Application.LoadLevel ("OpenCVForUnitySample");
						}
		
		
						GUILayout.EndVertical ();
				}
		}
}
