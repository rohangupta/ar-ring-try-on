
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class BackgroundSubtractor
/**
 * <p>Base class for background/foreground segmentation.</p>
 *
 * <p>class BackgroundSubtractor : public Algorithm <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>virtual ~BackgroundSubtractor();</p>
 *
 * <p>virtual void operator()(InputArray image, OutputArray fgmask, double
 * learningRate=0);</p>
 *
 * <p>virtual void getBackgroundImage(OutputArray backgroundImage) const;</p>
 *
 * <p>};</p>
 *
 * <p>The class is only used to define the common interface for the whole family of
 * background/foreground segmentation algorithms.
 * </code></p>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractor">org.opencv.video.BackgroundSubtractor : public Algorithm</a>
 */
		public class BackgroundSubtractor : Algorithm
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												video_BackgroundSubtractor_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
		
						#else
			return;
						#endif
				}
	
				protected BackgroundSubtractor (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:  void BackgroundSubtractor::operator ()(Mat image, Mat& fgmask, double learningRate = 0)
				//
	
				/**
 * <p>Computes a foreground mask.</p>
 *
 * @param image Next video frame.
 * @param fgmask The output foreground mask as an 8-bit binary image.
 * @param learningRate a learningRate
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractor-operator">org.opencv.video.BackgroundSubtractor.operator()</a>
 */
				public  void apply (Mat image, Mat fgmask, double learningRate)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (fgmask != null)
								fgmask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						video_BackgroundSubtractor_apply_10 (nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Computes a foreground mask.</p>
 *
 * @param image Next video frame.
 * @param fgmask The output foreground mask as an 8-bit binary image.
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractor-operator">org.opencv.video.BackgroundSubtractor.operator()</a>
 */
				public  void apply (Mat image, Mat fgmask)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (fgmask != null)
								fgmask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						video_BackgroundSubtractor_apply_11 (nativeObj, image.nativeObj, fgmask.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			video_BackgroundSubtractor_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void BackgroundSubtractor::operator ()(Mat image, Mat& fgmask, double learningRate = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_BackgroundSubtractor_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_BackgroundSubtractor_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_BackgroundSubtractor_delete(IntPtr nativeObj);

#else
		
				// C++:  void BackgroundSubtractor::operator ()(Mat image, Mat& fgmask, double learningRate = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void video_BackgroundSubtractor_apply_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void video_BackgroundSubtractor_apply_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void video_BackgroundSubtractor_delete (IntPtr nativeObj);
		#endif
		}
}
