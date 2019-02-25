using UnityEngine;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class VideoCapture
/**
 * <p>Class for video capturing from video files or cameras.
 * The class provides C++ API for capturing video from cameras or for reading
 * video files. Here is how the class can be used:</p>
 *
 * <p>#include "opencv2/opencv.hpp" <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>using namespace cv;</p>
 *
 * <p>int main(int, char)</p>
 *
 *
 * <p>VideoCapture cap(0); // open the default camera</p>
 *
 * <p>if(!cap.isOpened()) // check if we succeeded</p>
 *
 * <p>return -1;</p>
 *
 * <p>Mat edges;</p>
 *
 * <p>namedWindow("edges",1);</p>
 *
 * <p>for(;;)</p>
 *
 *
 * <p>Mat frame;</p>
 *
 * <p>cap >> frame; // get a new frame from camera</p>
 *
 * <p>cvtColor(frame, edges, CV_BGR2GRAY);</p>
 *
 * <p>GaussianBlur(edges, edges, Size(7,7), 1.5, 1.5);</p>
 *
 * <p>Canny(edges, edges, 0, 30, 3);</p>
 *
 * <p>imshow("edges", edges);</p>
 *
 * <p>if(waitKey(30) >= 0) break;</p>
 *
 *
 * <p>// the camera will be deinitialized automatically in VideoCapture destructor</p>
 *
 * <p>return 0;</p>
 *
 *
 * <p>Note: In C API the black-box structure <code>CvCapture</code> is used instead
 * of <code>VideoCapture</code>.
 * </code></p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> A basic sample on using the VideoCapture interface can be found at
 * opencv_source_code/samples/cpp/starter_video.cpp
 *   <li> Another basic video processing sample can be found at
 * opencv_source_code/samples/cpp/video_dmtx.cpp
 *   <li> (Python) A basic sample on using the VideoCapture interface can be
 * found at opencv_source_code/samples/python2/video.py
 *   <li> (Python) Another basic video processing sample can be found at
 * opencv_source_code/samples/python2/video_dmtx.py
 *   <li> (Python) A multi threaded video processing sample can be found at
 * opencv_source_code/samples/python2/video_threaded.py
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture">org.opencv.highgui.VideoCapture</a>
 */
		public class VideoCapture : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												highgui_VideoCapture_n_1delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
						return;
						#endif
				}
	
//	protected readonly IntPtr nativeObj;
	
				protected VideoCapture (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				//
				// C++: VideoCapture::VideoCapture()
				//
	
				/**
 * <p>VideoCapture constructors.</p>
 *
 * <p>Note: In C API, when you finished working with video, release
 * <code>CvCapture</code> structure with <code>cvReleaseCapture()</code>, or use
 * <code>Ptr<CvCapture></code> that calls <code>cvReleaseCapture()</code>
 * automatically in the destructor.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-videocapture">org.opencv.highgui.VideoCapture.VideoCapture</a>
 */
				public VideoCapture ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
//			//AndroidManifest.xml Camera flag on
//			WebCamTexture tex = new WebCamTexture();//TODO: @check
		
						nativeObj = highgui_VideoCapture_n_1VideoCapture__ ();
		
						return;
						#else
						return;
						#endif
				}


				//
				// C++: VideoCapture::VideoCapture(const string& filename)
				//
		
				/**
				 * (Support for Win,Mac,iOS)
				 * Win Setup
				 * 1)Download "OpenCV for Windows Version 2.4.9"(http://opencv.org/downloads.html).
				 * 2)Set Path to "opencv_ffmpeg249.dll"
				 *   if 32bit, "C:\opencv\build\x86\vc10\bin\".
				 *   if 64bit, "C:\opencv\build\x64\vc10\bin\".
 * <p>VideoCapture constructors.</p>
 *
 * <p>Note: In C API, when you finished working with video, release
 * <code>CvCapture</code> structure with <code>cvReleaseCapture()</code>, or use
 * <code>Ptr<CvCapture></code> that calls <code>cvReleaseCapture()</code>
 * automatically in the destructor.</p>
 *
 * @param filename name of the opened video file (eg. video.avi) or image
 * sequence (eg. img_%02d.jpg, which will read samples like img_00.jpg,
 * img_01.jpg, img_02.jpg,...)
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-videocapture">org.opencv.highgui.VideoCapture.VideoCapture</a>
 */
				public VideoCapture (string filename)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_IOS) && !UNITY_EDITOR)
			nativeObj = highgui_VideoCapture_n_VideoCapture(filename);
			
			return;
						#else
						return;
						#endif
				}
	
				//
				// C++: VideoCapture::VideoCapture(int device)
				//
	
				/**
 * <p>VideoCapture constructors.</p>
 *
 * <p>Note: In C API, when you finished working with video, release
 * <code>CvCapture</code> structure with <code>cvReleaseCapture()</code>, or use
 * <code>Ptr<CvCapture></code> that calls <code>cvReleaseCapture()</code>
 * automatically in the destructor.</p>
 *
 * @param device id of the opened video capturing device (i.e. a camera index).
 * If there is a single camera connected, just pass 0.
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-videocapture">org.opencv.highgui.VideoCapture.VideoCapture</a>
 */
				public VideoCapture (int device)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = highgui_VideoCapture_n_1VideoCapture__I (device);
		
						return;
						#else
						return;
						#endif
				}
	
				//
				// C++: double VideoCapture::get(int propId)
				//
	
				/**
 * <p>Returns the specified <code>VideoCapture</code> property</p>
 *
 * <p>Note: When querying a property that is not supported by the backend used by
 * the <code>VideoCapture</code> class, value 0 is returned.</p>
 *
 * @param propId Property identifier. It can be one of the following:
 * <ul>
 *   <li> CV_CAP_PROP_POS_MSEC Current position of the video file in
 * milliseconds or video capture timestamp.
 *   <li> CV_CAP_PROP_POS_FRAMES 0-based index of the frame to be
 * decoded/captured next.
 *   <li> CV_CAP_PROP_POS_AVI_RATIO Relative position of the video file: 0 -
 * start of the film, 1 - end of the film.
 *   <li> CV_CAP_PROP_FRAME_WIDTH Width of the frames in the video stream.
 *   <li> CV_CAP_PROP_FRAME_HEIGHT Height of the frames in the video stream.
 *   <li> CV_CAP_PROP_FPS Frame rate.
 *   <li> CV_CAP_PROP_FOURCC 4-character code of codec.
 *   <li> CV_CAP_PROP_FRAME_COUNT Number of frames in the video file.
 *   <li> CV_CAP_PROP_FORMAT Format of the Mat objects returned by
 * <code>retrieve()</code>.
 *   <li> CV_CAP_PROP_MODE Backend-specific value indicating the current capture
 * mode.
 *   <li> CV_CAP_PROP_BRIGHTNESS Brightness of the image (only for cameras).
 *   <li> CV_CAP_PROP_CONTRAST Contrast of the image (only for cameras).
 *   <li> CV_CAP_PROP_SATURATION Saturation of the image (only for cameras).
 *   <li> CV_CAP_PROP_HUE Hue of the image (only for cameras).
 *   <li> CV_CAP_PROP_GAIN Gain of the image (only for cameras).
 *   <li> CV_CAP_PROP_EXPOSURE Exposure (only for cameras).
 *   <li> CV_CAP_PROP_CONVERT_RGB Boolean flags indicating whether images should
 * be converted to RGB.
 *   <li> CV_CAP_PROP_WHITE_BALANCE Currently not supported
 *   <li> CV_CAP_PROP_RECTIFICATION Rectification flag for stereo cameras (note:
 * only supported by DC1394 v 2.x backend currently)
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-get">org.opencv.highgui.VideoCapture.get</a>
 */
				public double get (int propId)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = highgui_VideoCapture_n_1get (nativeObj, propId);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
				public List<Size> getSupportedPreviewSizes ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						string[] sizes_str = Marshal.PtrToStringAnsi (highgui_VideoCapture_n_1getSupportedPreviewSizes (nativeObj)).Split (',');//TODO:@check
//		List<Size> sizes = new LinkedList<Size>();
						List<Size> sizes = new List<Size> ();//TODO:@check
		
						foreach (string str in sizes_str) {
								string[] wh = str.Split ('x');
								sizes.Add (new Size (double.Parse (wh [0]), double.Parse (wh [1])));
						}
		
						return sizes;
						#else
						return null;
						#endif
				}
	
				//
				// C++: bool VideoCapture::grab()
				//
	
				/**
 * <p>Grabs the next frame from video file or capturing device.</p>
 *
 * <p>The methods/functions grab the next frame from video file or camera and
 * return true (non-zero) in the case of success.</p>
 *
 * <p>The primary use of the function is in multi-camera environments, especially
 * when the cameras do not have hardware synchronization. That is, you call
 * <code>VideoCapture.grab()</code> for each camera and after that call the
 * slower method <code>VideoCapture.retrieve()</code> to decode and get frame
 * from each camera. This way the overhead on demosaicing or motion jpeg
 * decompression etc. is eliminated and the retrieved frames from different
 * cameras will be closer in time.</p>
 *
 * <p>Also, when a connected camera is multi-head (for example, a stereo camera or
 * a Kinect device), the correct way of retrieving data from it is to call
 * "VideoCapture.grab" first and then call "VideoCapture.retrieve" one or more
 * times with different values of the <code>channel</code> parameter. See
 * https://github.com/Itseez/opencv/tree/master/samples/cpp/openni_capture.cpp</p>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-grab">org.opencv.highgui.VideoCapture.grab</a>
 */
				public bool grab ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1grab (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				//
				// C++: bool VideoCapture::isOpened()
				//
	
				/**
 * <p>Returns true if video capturing has been initialized already.</p>
 *
 * <p>If the previous call to <code>VideoCapture</code> constructor or
 * <code>VideoCapture.open</code> succeeded, the method returns true.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-isopened">org.opencv.highgui.VideoCapture.isOpened</a>
 */
				public bool isOpened ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1isOpened (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}

				//
				// C++: bool VideoCapture::open(string filename)
				//
		
				/**
* (Support for Win,Mac,iOS)
				 * Win Setup
				 * 1)Download "OpenCV for Windows Version 2.4.9"(http://opencv.org/downloads.html).
				 * 2)Set Path to "opencv_ffmpeg249.dll"
				 *   if 32bit, "C:\opencv\build\x86\vc10\bin\".
				 *   if 64bit, "C:\opencv\build\x64\vc10\bin\".
 * <p>Open video file or a capturing device for video capturing</p>
 *
 * <p>The methods first call "VideoCapture.release" to close the already opened
 * file or camera.</p>
 *
 * @param filename name of the opened video file (eg. video.avi) or image
 * sequence (eg. img_%02d.jpg, which will read samples like img_00.jpg,
 * img_01.jpg, img_02.jpg,...)
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-open">org.opencv.highgui.VideoCapture.open</a>
 */
				public bool open (string filename)
				{
						ThrowIfDisposed ();
			
						#if UNITY_PRO_LICENSE || ((UNITY_IOS) && !UNITY_EDITOR)
			bool retVal = highgui_VideoCapture_n_open(nativeObj, filename);
			
			return retVal;
						#else
						return false;
						#endif
				}
	
				//
				// C++: bool VideoCapture::open(int device)
				//
	
				/**
 * <p>Open video file or a capturing device for video capturing</p>
 *
 * <p>The methods first call "VideoCapture.release" to close the already opened
 * file or camera.</p>
 *
 * @param device id of the opened video capturing device (i.e. a camera index).
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-open">org.opencv.highgui.VideoCapture.open</a>
 */
				public bool open (int device)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1open__JI (nativeObj, device);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				//
				// C++: bool VideoCapture::read(Mat image)
				//
	
				/**
 * <p>Grabs, decodes and returns the next video frame.</p>
 *
 * <p>The methods/functions combine "VideoCapture.grab" and "VideoCapture.retrieve"
 * in one call. This is the most convenient method for reading video files or
 * capturing data from decode and return the just grabbed frame. If no frames
 * has been grabbed (camera has been disconnected, or there are no more frames
 * in video file), the methods return false and the functions return NULL
 * pointer.</p>
 *
 * <p>Note: OpenCV 1.x functions <code>cvRetrieveFrame</code> and <code>cv.RetrieveFrame</code>
 * return image stored inside the video capturing structure. It is not allowed
 * to modify or release the image! You can copy the frame using "cvCloneImage"
 * and then do whatever you want with the copy.</p>
 *
 * @param image a image
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-read">org.opencv.highgui.VideoCapture.read</a>
 */
				public bool read (Mat image)
				{
						ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		
						bool retVal = highgui_VideoCapture_n_1read (nativeObj, image.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				//
				// C++: void VideoCapture::release()
				//
	
				/**
 * <p>Closes video file or capturing device.</p>
 *
 * <p>The methods are automatically called by subsequent "VideoCapture.open" and
 * by <code>VideoCapture</code> destructor.</p>
 *
 * <p>The C function also deallocates memory and clears <code>*capture</code>
 * pointer.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-release">org.opencv.highgui.VideoCapture.release</a>
 */
				public void release ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						highgui_VideoCapture_n_1release (nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
				//
				// C++: bool VideoCapture::retrieve(Mat image, int channel = 0)
				//
	
				/**
 * <p>Decodes and returns the grabbed video frame.</p>
 *
 * <p>The methods/functions decode and return the just grabbed frame. If no frames
 * has been grabbed (camera has been disconnected, or there are no more frames
 * in video file), the methods return false and the functions return NULL
 * pointer.</p>
 *
 * <p>Note: OpenCV 1.x functions <code>cvRetrieveFrame</code> and <code>cv.RetrieveFrame</code>
 * return image stored inside the video capturing structure. It is not allowed
 * to modify or release the image! You can copy the frame using "cvCloneImage"
 * and then do whatever you want with the copy.</p>
 *
 * @param image a image
 * @param channel a channel
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-retrieve">org.opencv.highgui.VideoCapture.retrieve</a>
 */
				public bool retrieve (Mat image, int channel)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1retrieve__JJI (nativeObj, image.nativeObj, channel);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				/**
 * <p>Decodes and returns the grabbed video frame.</p>
 *
 * <p>The methods/functions decode and return the just grabbed frame. If no frames
 * has been grabbed (camera has been disconnected, or there are no more frames
 * in video file), the methods return false and the functions return NULL
 * pointer.</p>
 *
 * <p>Note: OpenCV 1.x functions <code>cvRetrieveFrame</code> and <code>cv.RetrieveFrame</code>
 * return image stored inside the video capturing structure. It is not allowed
 * to modify or release the image! You can copy the frame using "cvCloneImage"
 * and then do whatever you want with the copy.</p>
 *
 * @param image a image
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-retrieve">org.opencv.highgui.VideoCapture.retrieve</a>
 */
				public bool retrieve (Mat image)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1retrieve__JJ (nativeObj, image.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				//
				// C++: bool VideoCapture::set(int propId, double value)
				//
	
				/**
 * <p>Sets a property in the <code>VideoCapture</code>.</p>
 *
 * @param propId Property identifier. It can be one of the following:
 * <ul>
 *   <li> CV_CAP_PROP_POS_MSEC Current position of the video file in
 * milliseconds.
 *   <li> CV_CAP_PROP_POS_FRAMES 0-based index of the frame to be
 * decoded/captured next.
 *   <li> CV_CAP_PROP_POS_AVI_RATIO Relative position of the video file: 0 -
 * start of the film, 1 - end of the film.
 *   <li> CV_CAP_PROP_FRAME_WIDTH Width of the frames in the video stream.
 *   <li> CV_CAP_PROP_FRAME_HEIGHT Height of the frames in the video stream.
 *   <li> CV_CAP_PROP_FPS Frame rate.
 *   <li> CV_CAP_PROP_FOURCC 4-character code of codec.
 *   <li> CV_CAP_PROP_FRAME_COUNT Number of frames in the video file.
 *   <li> CV_CAP_PROP_FORMAT Format of the Mat objects returned by
 * <code>retrieve()</code>.
 *   <li> CV_CAP_PROP_MODE Backend-specific value indicating the current capture
 * mode.
 *   <li> CV_CAP_PROP_BRIGHTNESS Brightness of the image (only for cameras).
 *   <li> CV_CAP_PROP_CONTRAST Contrast of the image (only for cameras).
 *   <li> CV_CAP_PROP_SATURATION Saturation of the image (only for cameras).
 *   <li> CV_CAP_PROP_HUE Hue of the image (only for cameras).
 *   <li> CV_CAP_PROP_GAIN Gain of the image (only for cameras).
 *   <li> CV_CAP_PROP_EXPOSURE Exposure (only for cameras).
 *   <li> CV_CAP_PROP_CONVERT_RGB Boolean flags indicating whether images should
 * be converted to RGB.
 *   <li> CV_CAP_PROP_WHITE_BALANCE Currently unsupported
 *   <li> CV_CAP_PROP_RECTIFICATION Rectification flag for stereo cameras (note:
 * only supported by DC1394 v 2.x backend currently)
 * </ul>
 * @param value Value of the property.
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#videocapture-set">org.opencv.highgui.VideoCapture.set</a>
 */
				public bool set (int propId, double value)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_VideoCapture_n_1set (nativeObj, propId, value);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
//	@Override
//	protected void finalize() throws Throwable {
//			highgui_VideoCapture_n_1delete(nativeObj);
//		super.finalize();
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++: VideoCapture::VideoCapture()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_VideoCapture_n_1VideoCapture__();
		
		// C++: VideoCapture::VideoCapture(string filename)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_VideoCapture_n_VideoCapture (string filename);
		
		// C++: VideoCapture::VideoCapture(int device)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_VideoCapture_n_1VideoCapture__I(int device);
		
		// C++: double VideoCapture::get(int propId)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double highgui_VideoCapture_n_1get(IntPtr nativeObj, int propId);
		
		// C++: bool VideoCapture::grab()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1grab(IntPtr nativeObj);
		
		// C++: bool VideoCapture::isOpened()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1isOpened(IntPtr nativeObj);
		
		// C++: bool VideoCapture::open(string filename)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_open (IntPtr nativeObj, string filename);
		
		// C++: bool VideoCapture::open(int device)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1open__JI(IntPtr nativeObj, int device);
		
		// C++: bool VideoCapture::read(Mat image)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1read(IntPtr nativeObj, IntPtr image_nativeObj);
		
		// C++: void VideoCapture::release()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void highgui_VideoCapture_n_1release(IntPtr nativeObj);
		
		// C++: bool VideoCapture::retrieve(Mat image, int channel = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1retrieve__JJI(IntPtr nativeObj, IntPtr image_nativeObj, int channel);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1retrieve__JJ(IntPtr nativeObj, IntPtr image_nativeObj);
		
		// C++: bool VideoCapture::set(int propId, double value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_VideoCapture_n_1set(IntPtr nativeObj, int propId, double value);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_VideoCapture_n_1getSupportedPreviewSizes(IntPtr nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void highgui_VideoCapture_n_1delete(IntPtr nativeObj);

#else
				// C++: VideoCapture::VideoCapture()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_VideoCapture_n_1VideoCapture__ ();
		
				// C++: VideoCapture::VideoCapture(string filename)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_VideoCapture_n_VideoCapture (string filename);
		
				// C++: VideoCapture::VideoCapture(int device)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_VideoCapture_n_1VideoCapture__I (int device);
		
				// C++: double VideoCapture::get(int propId)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double highgui_VideoCapture_n_1get (IntPtr nativeObj, int propId);
		
				// C++: bool VideoCapture::grab()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1grab (IntPtr nativeObj);
		
				// C++: bool VideoCapture::isOpened()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1isOpened (IntPtr nativeObj);
		
				// C++: bool VideoCapture::open(string filename)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_open (IntPtr nativeObj, string filename);
		
				// C++: bool VideoCapture::open(int device)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1open__JI (IntPtr nativeObj, int device);
		
				// C++: bool VideoCapture::read(Mat image)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1read (IntPtr nativeObj, IntPtr image_nativeObj);
		
				// C++: void VideoCapture::release()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void highgui_VideoCapture_n_1release (IntPtr nativeObj);
		
				// C++: bool VideoCapture::retrieve(Mat image, int channel = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1retrieve__JJI (IntPtr nativeObj, IntPtr image_nativeObj, int channel);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1retrieve__JJ (IntPtr nativeObj, IntPtr image_nativeObj);
		
				// C++: bool VideoCapture::set(int propId, double value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_VideoCapture_n_1set (IntPtr nativeObj, int propId, double value);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_VideoCapture_n_1getSupportedPreviewSizes (IntPtr nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void highgui_VideoCapture_n_1delete (IntPtr nativeObj);
		#endif
		}
}
