
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;


namespace OpenCVForUnity{



// C++: class BackgroundSubtractorMOG
/**
 * <p>Gaussian Mixture-based Background/Foreground Segmentation Algorithm.</p>
 *
 * <p>The class implements the algorithm described in P. KadewTraKuPong and R.
 * Bowden, *An improved adaptive background mixture model for real-time tracking
 * with shadow detection*, Proc. 2nd European Workshop on Advanced Video-Based
 * Surveillance Systems, 2001: http://personal.ee.surrey.ac.uk/Personal/R.Bowden/publications/avbs01/avbs01.pdf</p>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractormog">org.opencv.video.BackgroundSubtractorMOG : public BackgroundSubtractor</a>
 */
public class BackgroundSubtractorMOG : BackgroundSubtractor {


		protected override void Dispose (bool disposing)
		{
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		
			try {

				if (disposing) {
				}

				if (IsEnabledDispose) {
					if (nativeObj != IntPtr.Zero)
						video_BackgroundSubtractorMOG_delete(nativeObj);
					nativeObj = IntPtr.Zero;
				}
				
			} finally {
				base.Dispose (disposing);
			}
			
			#else
			return;
			#endif
		}
	
	protected BackgroundSubtractorMOG(IntPtr addr) : base(addr){ }
	
	
	//
	// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG()
	//
	
	/**
 * <p>The constructors.</p>
 *
 * <p>Default constructor sets all parameters to default values.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractormog-backgroundsubtractormog">org.opencv.video.BackgroundSubtractorMOG.BackgroundSubtractorMOG</a>
 */
	public   BackgroundSubtractorMOG()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_10() )
				#else
				base(IntPtr.Zero)
		#endif
		{
		
		return;
	}
	
	
	//
	// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma = 0)
	//
	
	/**
 * <p>The constructors.</p>
 *
 * <p>Default constructor sets all parameters to default values.</p>
 *
 * @param history Length of the history.
 * @param nmixtures Number of Gaussian mixtures.
 * @param backgroundRatio Background ratio.
 * @param noiseSigma Noise strength.
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractormog-backgroundsubtractormog">org.opencv.video.BackgroundSubtractorMOG.BackgroundSubtractorMOG</a>
 */
	public   BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_11(history, nmixtures, backgroundRatio, noiseSigma) )
				#else
				base(IntPtr.Zero)
		#endif
		{
		
		return;
	}
	
	/**
 * <p>The constructors.</p>
 *
 * <p>Default constructor sets all parameters to default values.</p>
 *
 * @param history Length of the history.
 * @param nmixtures Number of Gaussian mixtures.
 * @param backgroundRatio Background ratio.
 *
 * @see <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractormog-backgroundsubtractormog">org.opencv.video.BackgroundSubtractorMOG.BackgroundSubtractorMOG</a>
 */
	public   BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_12(history, nmixtures, backgroundRatio) )
		
				#else
				base(IntPtr.Zero)
		#endif
		{
		
		return;
	}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			video_BackgroundSubtractorMOG_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_10();
		
		// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_11(int history, int nmixtures, double backgroundRatio, double noiseSigma);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_12(int history, int nmixtures, double backgroundRatio);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_BackgroundSubtractorMOG_delete(IntPtr nativeObj);

#else
		// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG()
		[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_10();
		
		// C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma = 0)
		[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_11(int history, int nmixtures, double backgroundRatio, double noiseSigma);
		[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_12(int history, int nmixtures, double backgroundRatio);
		
		// native support for java finalize()
		[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
		private static extern void video_BackgroundSubtractorMOG_delete(IntPtr nativeObj);
		#endif
}
}
