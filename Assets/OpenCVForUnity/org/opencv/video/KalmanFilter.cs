
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class KalmanFilter
/**
 * <p>Kalman filter class.</p>
 *
 * <p>The class implements a standard Kalman filter http://en.wikipedia.org/wiki/Kalman_filter,
 * [Welch95]. However, you can modify <code>transitionMatrix</code>,
 * <code>controlMatrix</code>, and <code>measurementMatrix</code> to get an
 * extended Kalman filter functionality. See the OpenCV sample <code>kalman.cpp</code>.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> An example using the standard Kalman filter can be found at
 * opencv_source_code/samples/cpp/kalman.cpp
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter">org.opencv.video.KalmanFilter</a>
 */
		public class KalmanFilter : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												video_KalmanFilter_delete (nativeObj);
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
				protected KalmanFilter (IntPtr addr)
				{
						nativeObj = addr;
				}
	
	
				//
				// C++:   KalmanFilter::KalmanFilter()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The full constructor.</p>
 *
 * <p>Note: In C API when <code>CvKalman* kalmanFilter</code> structure is not
 * needed anymore, it should be released with <code>cvReleaseKalman(&kalmanFilter)</code></p>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-kalmanfilter">org.opencv.video.KalmanFilter.KalmanFilter</a>
 */
				public   KalmanFilter ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = video_KalmanFilter_KalmanFilter_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:   KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The full constructor.</p>
 *
 * <p>Note: In C API when <code>CvKalman* kalmanFilter</code> structure is not
 * needed anymore, it should be released with <code>cvReleaseKalman(&kalmanFilter)</code></p>
 *
 * @param dynamParams Dimensionality of the state.
 * @param measureParams Dimensionality of the measurement.
 * @param controlParams Dimensionality of the control vector.
 * @param type Type of the created matrices that should be <code>CV_32F</code>
 * or <code>CV_64F</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-kalmanfilter">org.opencv.video.KalmanFilter.KalmanFilter</a>
 */
				public   KalmanFilter (int dynamParams, int measureParams, int controlParams, int type)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = video_KalmanFilter_KalmanFilter_11 (dynamParams, measureParams, controlParams, type);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The full constructor.</p>
 *
 * <p>Note: In C API when <code>CvKalman* kalmanFilter</code> structure is not
 * needed anymore, it should be released with <code>cvReleaseKalman(&kalmanFilter)</code></p>
 *
 * @param dynamParams Dimensionality of the state.
 * @param measureParams Dimensionality of the measurement.
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-kalmanfilter">org.opencv.video.KalmanFilter.KalmanFilter</a>
 */
				public   KalmanFilter (int dynamParams, int measureParams)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = video_KalmanFilter_KalmanFilter_12 (dynamParams, measureParams);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  Mat KalmanFilter::correct(Mat measurement)
				//
	
				/**
 * <p>Updates the predicted state from the measurement.</p>
 *
 * @param measurement The measured system parameters
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-correct">org.opencv.video.KalmanFilter.correct</a>
 */
				public  Mat correct (Mat measurement)
				{
						if (measurement != null)
								measurement.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (video_KalmanFilter_correct_10 (nativeObj, measurement.nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  Mat KalmanFilter::predict(Mat control = Mat())
				//
	
				/**
 * <p>Computes a predicted state.</p>
 *
 * @param control The optional input control
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-predict">org.opencv.video.KalmanFilter.predict</a>
 */
				public  Mat predict (Mat control)
				{
						if (control != null)
								control.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (video_KalmanFilter_predict_10 (nativeObj, control.nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
				/**
 * <p>Computes a predicted state.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter-predict">org.opencv.video.KalmanFilter.predict</a>
 */
				public  Mat predict ()
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (video_KalmanFilter_predict_11 (nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			video_KalmanFilter_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   KalmanFilter::KalmanFilter()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_KalmanFilter_10();
		
		// C++:   KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_KalmanFilter_11(int dynamParams, int measureParams, int controlParams, int type);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_KalmanFilter_12(int dynamParams, int measureParams);
		
		// C++:  Mat KalmanFilter::correct(Mat measurement)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_correct_10(IntPtr nativeObj, IntPtr measurement_nativeObj);
		
		// C++:  Mat KalmanFilter::predict(Mat control = Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_predict_10(IntPtr nativeObj, IntPtr control_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_KalmanFilter_predict_11(IntPtr nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_KalmanFilter_delete(IntPtr nativeObj);

#else
		
				// C++:   KalmanFilter::KalmanFilter()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_KalmanFilter_10 ();
		
				// C++:   KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_KalmanFilter_11 (int dynamParams, int measureParams, int controlParams, int type);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_KalmanFilter_12 (int dynamParams, int measureParams);
		
				// C++:  Mat KalmanFilter::correct(Mat measurement)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_correct_10 (IntPtr nativeObj, IntPtr measurement_nativeObj);
		
				// C++:  Mat KalmanFilter::predict(Mat control = Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_predict_10 (IntPtr nativeObj, IntPtr control_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr video_KalmanFilter_predict_11 (IntPtr nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void video_KalmanFilter_delete (IntPtr nativeObj);
		#endif
		}
}
