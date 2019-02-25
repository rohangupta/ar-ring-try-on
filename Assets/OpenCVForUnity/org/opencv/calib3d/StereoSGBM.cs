
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

// C++: class StereoSGBM
/**
 * <p>Class for computing stereo correspondence using the semi-global block
 * matching algorithm.</p>
 *
 * <p>class StereoSGBM <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>StereoSGBM();</p>
 *
 * <p>StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize,</p>
 *
 * <p>int P1=0, int P2=0, int disp12MaxDiff=0,</p>
 *
 * <p>int preFilterCap=0, int uniquenessRatio=0,</p>
 *
 * <p>int speckleWindowSize=0, int speckleRange=0,</p>
 *
 * <p>bool fullDP=false);</p>
 *
 * <p>virtual ~StereoSGBM();</p>
 *
 * <p>virtual void operator()(InputArray left, InputArray right, OutputArray disp);</p>
 *
 * <p>int minDisparity;</p>
 *
 * <p>int numberOfDisparities;</p>
 *
 * <p>int SADWindowSize;</p>
 *
 * <p>int preFilterCap;</p>
 *
 * <p>int uniquenessRatio;</p>
 *
 * <p>int P1, P2;</p>
 *
 * <p>int speckleWindowSize;</p>
 *
 * <p>int speckleRange;</p>
 *
 * <p>int disp12MaxDiff;</p>
 *
 * <p>bool fullDP;...</p>
 *
 * <p>};</p>
 *
 * <p>The class implements the modified H. Hirschmuller algorithm [HH08] that
 * differs from the original one as follows: </code></p>
 * <ul>
 *   <li> By default, the algorithm is single-pass, which means that you
 * consider only 5 directions instead of 8. Set <code>fullDP=true</code> to run
 * the full variant of the algorithm but beware that it may consume a lot of
 * memory.
 *   <li> The algorithm matches blocks, not individual pixels. Though, setting
 * <code>SADWindowSize=1</code> reduces the blocks to single pixels.
 *   <li> Mutual information cost function is not implemented. Instead, a
 * simpler Birchfield-Tomasi sub-pixel metric from [BT98] is used. Though, the
 * color images are supported as well.
 *   <li> Some pre- and post- processing steps from K. Konolige algorithm
 * :ocv:funcx:"StereoBM.operator()" are included, for example: pre-filtering
 * (<code>CV_STEREO_BM_XSOBEL</code> type) and post-filtering (uniqueness check,
 * quadratic interpolation and speckle filtering).
 * </ul>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) An example illustrating the use of the StereoSGBM matching
 * algorithm can be found at opencv_source_code/samples/python2/stereo_match.py
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereosgbm">org.opencv.calib3d.StereoSGBM</a>
 */
		public class StereoSGBM : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												calib3d_StereoSGBM_delete (nativeObj);
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
				protected StereoSGBM (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int DISP_SHIFT = 4;
				public const int	DISP_SCALE = (1 << DISP_SHIFT);
	


	
				//
				// C++:   StereoSGBM::StereoSGBM()
				//
	
				/**
 * <p>Initializes <code>StereoSGBM</code> and sets parameters to custom values.??</p>
 *
 * <p>The first constructor initializes <code>StereoSGBM</code> with all the
 * default parameters. So, you only have to set <code>StereoSGBM.numberOfDisparities</code>
 * at minimum. The second constructor enables you to set each parameter to a
 * custom value.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereosgbm-stereosgbm">org.opencv.calib3d.StereoSGBM.StereoSGBM</a>
 */
				public   StereoSGBM ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = calib3d_StereoSGBM_StereoSGBM_10 ();
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:   StereoSGBM::StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, bool fullDP = false)
				//
	
				/**
 * <p>Initializes <code>StereoSGBM</code> and sets parameters to custom values.??</p>
 *
 * <p>The first constructor initializes <code>StereoSGBM</code> with all the
 * default parameters. So, you only have to set <code>StereoSGBM.numberOfDisparities</code>
 * at minimum. The second constructor enables you to set each parameter to a
 * custom value.</p>
 *
 * @param minDisparity Minimum possible disparity value. Normally, it is zero
 * but sometimes rectification algorithms can shift images, so this parameter
 * needs to be adjusted accordingly.
 * @param numDisparities Maximum disparity minus minimum disparity. The value is
 * always greater than zero. In the current implementation, this parameter must
 * be divisible by 16.
 * @param SADWindowSize Matched block size. It must be an odd number
 * <code>>=1</code>. Normally, it should be somewhere in the <code>3..11</code>
 * range.
 * @param P1 The first parameter controlling the disparity smoothness. See
 * below.
 * @param P2 The second parameter controlling the disparity smoothness. The
 * larger the values are, the smoother the disparity is. <code>P1</code> is the
 * penalty on the disparity change by plus or minus 1 between neighbor pixels.
 * <code>P2</code> is the penalty on the disparity change by more than 1 between
 * neighbor pixels. The algorithm requires <code>P2 > P1</code>. See
 * <code>stereo_match.cpp</code> sample where some reasonably good
 * <code>P1</code> and <code>P2</code> values are shown (like <code>8*number_of_image_channels*SADWindowSize*SADWindowSize</code>
 * and <code>32*number_of_image_channels*SADWindowSize*SADWindowSize</code>,
 * respectively).
 * @param disp12MaxDiff Maximum allowed difference (in integer pixel units) in
 * the left-right disparity check. Set it to a non-positive value to disable the
 * check.
 * @param preFilterCap Truncation value for the prefiltered image pixels. The
 * algorithm first computes x-derivative at each pixel and clips its value by
 * <code>[-preFilterCap, preFilterCap]</code> interval. The result values are
 * passed to the Birchfield-Tomasi pixel cost function.
 * @param uniquenessRatio Margin in percentage by which the best (minimum)
 * computed cost function value should "win" the second best value to consider
 * the found match correct. Normally, a value within the 5-15 range is good
 * enough.
 * @param speckleWindowSize Maximum size of smooth disparity regions to consider
 * their noise speckles and invalidate. Set it to 0 to disable speckle
 * filtering. Otherwise, set it somewhere in the 50-200 range.
 * @param speckleRange Maximum disparity variation within each connected
 * component. If you do speckle filtering, set the parameter to a positive
 * value, it will be implicitly multiplied by 16. Normally, 1 or 2 is good
 * enough.
 * @param fullDP Set it to <code>true</code> to run the full-scale two-pass
 * dynamic programming algorithm. It will consume O(W*H*numDisparities) bytes,
 * which is large for 640x480 stereo and huge for HD-size pictures. By default,
 * it is set to <code>false</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereosgbm-stereosgbm">org.opencv.calib3d.StereoSGBM.StereoSGBM</a>
 */
				public   StereoSGBM (int minDisparity, int numDisparities, int SADWindowSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, bool fullDP)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = calib3d_StereoSGBM_StereoSGBM_11 (minDisparity, numDisparities, SADWindowSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, fullDP);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Initializes <code>StereoSGBM</code> and sets parameters to custom values.??</p>
 *
 * <p>The first constructor initializes <code>StereoSGBM</code> with all the
 * default parameters. So, you only have to set <code>StereoSGBM.numberOfDisparities</code>
 * at minimum. The second constructor enables you to set each parameter to a
 * custom value.</p>
 *
 * @param minDisparity Minimum possible disparity value. Normally, it is zero
 * but sometimes rectification algorithms can shift images, so this parameter
 * needs to be adjusted accordingly.
 * @param numDisparities Maximum disparity minus minimum disparity. The value is
 * always greater than zero. In the current implementation, this parameter must
 * be divisible by 16.
 * @param SADWindowSize Matched block size. It must be an odd number
 * <code>>=1</code>. Normally, it should be somewhere in the <code>3..11</code>
 * range.
 *
 * @see <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereosgbm-stereosgbm">org.opencv.calib3d.StereoSGBM.StereoSGBM</a>
 */
				public   StereoSGBM (int minDisparity, int numDisparities, int SADWindowSize)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = calib3d_StereoSGBM_StereoSGBM_12 (minDisparity, numDisparities, SADWindowSize);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void StereoSGBM::operator ()(Mat left, Mat right, Mat& disp)
				//
	
				public  void compute (Mat left, Mat right, Mat disp)
				{
						if (left != null)
								left.ThrowIfDisposed ();
						if (right != null)
								right.ThrowIfDisposed ();
						if (disp != null)
								disp.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_compute_10 (nativeObj, left.nativeObj, right.nativeObj, disp.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::minDisparity
				//
	
				public  int get_minDisparity ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1minDisparity_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::minDisparity
				//
	
				public  void set_minDisparity (int minDisparity)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1minDisparity_10 (nativeObj, minDisparity);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::numberOfDisparities
				//
	
				public  int get_numberOfDisparities ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1numberOfDisparities_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::numberOfDisparities
				//
	
				public  void set_numberOfDisparities (int numberOfDisparities)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1numberOfDisparities_10 (nativeObj, numberOfDisparities);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::SADWindowSize
				//
	
				public  int get_SADWindowSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1SADWindowSize_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::SADWindowSize
				//
	
				public  void set_SADWindowSize (int SADWindowSize)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1SADWindowSize_10 (nativeObj, SADWindowSize);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::preFilterCap
				//
	
				public  int get_preFilterCap ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1preFilterCap_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::preFilterCap
				//
	
				public  void set_preFilterCap (int preFilterCap)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1preFilterCap_10 (nativeObj, preFilterCap);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::uniquenessRatio
				//
	
				public  int get_uniquenessRatio ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1uniquenessRatio_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::uniquenessRatio
				//
	
				public  void set_uniquenessRatio (int uniquenessRatio)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1uniquenessRatio_10 (nativeObj, uniquenessRatio);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::P1
				//
	
				public  int get_P1 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1P1_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::P1
				//
	
				public  void set_P1 (int P1)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1P1_10 (nativeObj, P1);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::P2
				//
	
				public  int get_P2 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1P2_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::P2
				//
	
				public  void set_P2 (int P2)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1P2_10 (nativeObj, P2);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::speckleWindowSize
				//
	
				public  int get_speckleWindowSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1speckleWindowSize_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::speckleWindowSize
				//
	
				public  void set_speckleWindowSize (int speckleWindowSize)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1speckleWindowSize_10 (nativeObj, speckleWindowSize);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::speckleRange
				//
	
				public  int get_speckleRange ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1speckleRange_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::speckleRange
				//
	
				public  void set_speckleRange (int speckleRange)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1speckleRange_10 (nativeObj, speckleRange);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoSGBM::disp12MaxDiff
				//
	
				public  int get_disp12MaxDiff ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = calib3d_StereoSGBM_get_1disp12MaxDiff_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::disp12MaxDiff
				//
	
				public  void set_disp12MaxDiff (int disp12MaxDiff)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1disp12MaxDiff_10 (nativeObj, disp12MaxDiff);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: bool StereoSGBM::fullDP
				//
	
				public  bool get_fullDP ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = calib3d_StereoSGBM_get_1fullDP_10 (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: void StereoSGBM::fullDP
				//
	
				public  void set_fullDP (bool fullDP)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						calib3d_StereoSGBM_set_1fullDP_10 (nativeObj, fullDP);
		
						return;
						#else
						return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			calib3d_StereoSGBM_delete(nativeObj);
//	}


		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   StereoSGBM::StereoSGBM()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_10();
		
		// C++:   StereoSGBM::StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, bool fullDP = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_11(int minDisparity, int numDisparities, int SADWindowSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, bool fullDP);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_12(int minDisparity, int numDisparities, int SADWindowSize);
		
		// C++:  void StereoSGBM::operator ()(Mat left, Mat right, Mat& disp)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disp_nativeObj);
		
		// C++: int StereoSGBM::minDisparity
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1minDisparity_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::minDisparity
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1minDisparity_10(IntPtr nativeObj, int minDisparity);
		
		// C++: int StereoSGBM::numberOfDisparities
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1numberOfDisparities_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::numberOfDisparities
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1numberOfDisparities_10(IntPtr nativeObj, int numberOfDisparities);
		
		// C++: int StereoSGBM::SADWindowSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1SADWindowSize_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::SADWindowSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1SADWindowSize_10(IntPtr nativeObj, int SADWindowSize);
		
		// C++: int StereoSGBM::preFilterCap
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1preFilterCap_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::preFilterCap
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1preFilterCap_10(IntPtr nativeObj, int preFilterCap);
		
		// C++: int StereoSGBM::uniquenessRatio
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1uniquenessRatio_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::uniquenessRatio
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1uniquenessRatio_10(IntPtr nativeObj, int uniquenessRatio);
		
		// C++: int StereoSGBM::P1
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1P1_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::P1
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1P1_10(IntPtr nativeObj, int P1);
		
		// C++: int StereoSGBM::P2
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1P2_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::P2
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1P2_10(IntPtr nativeObj, int P2);
		
		// C++: int StereoSGBM::speckleWindowSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1speckleWindowSize_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::speckleWindowSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1speckleWindowSize_10(IntPtr nativeObj, int speckleWindowSize);
		
		// C++: int StereoSGBM::speckleRange
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1speckleRange_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::speckleRange
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1speckleRange_10(IntPtr nativeObj, int speckleRange);
		
		// C++: int StereoSGBM::disp12MaxDiff
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int calib3d_StereoSGBM_get_1disp12MaxDiff_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::disp12MaxDiff
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1disp12MaxDiff_10(IntPtr nativeObj, int disp12MaxDiff);
		
		// C++: bool StereoSGBM::fullDP
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool calib3d_StereoSGBM_get_1fullDP_10(IntPtr nativeObj);
		
		// C++: void StereoSGBM::fullDP
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_set_1fullDP_10(IntPtr nativeObj, bool fullDP);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void calib3d_StereoSGBM_delete(IntPtr nativeObj);

#else
		
		
		
				// C++:   StereoSGBM::StereoSGBM()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_10 ();
		
				// C++:   StereoSGBM::StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, bool fullDP = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_11 (int minDisparity, int numDisparities, int SADWindowSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, bool fullDP);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr calib3d_StereoSGBM_StereoSGBM_12 (int minDisparity, int numDisparities, int SADWindowSize);
		
				// C++:  void StereoSGBM::operator ()(Mat left, Mat right, Mat& disp)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_compute_10 (IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disp_nativeObj);
		
				// C++: int StereoSGBM::minDisparity
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1minDisparity_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::minDisparity
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1minDisparity_10 (IntPtr nativeObj, int minDisparity);
		
				// C++: int StereoSGBM::numberOfDisparities
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1numberOfDisparities_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::numberOfDisparities
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1numberOfDisparities_10 (IntPtr nativeObj, int numberOfDisparities);
		
				// C++: int StereoSGBM::SADWindowSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1SADWindowSize_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::SADWindowSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1SADWindowSize_10 (IntPtr nativeObj, int SADWindowSize);
		
				// C++: int StereoSGBM::preFilterCap
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1preFilterCap_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::preFilterCap
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1preFilterCap_10 (IntPtr nativeObj, int preFilterCap);
		
				// C++: int StereoSGBM::uniquenessRatio
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1uniquenessRatio_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::uniquenessRatio
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1uniquenessRatio_10 (IntPtr nativeObj, int uniquenessRatio);
		
				// C++: int StereoSGBM::P1
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1P1_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::P1
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1P1_10 (IntPtr nativeObj, int P1);
		
				// C++: int StereoSGBM::P2
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1P2_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::P2
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1P2_10 (IntPtr nativeObj, int P2);
		
				// C++: int StereoSGBM::speckleWindowSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1speckleWindowSize_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::speckleWindowSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1speckleWindowSize_10 (IntPtr nativeObj, int speckleWindowSize);
		
				// C++: int StereoSGBM::speckleRange
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1speckleRange_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::speckleRange
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1speckleRange_10 (IntPtr nativeObj, int speckleRange);
		
				// C++: int StereoSGBM::disp12MaxDiff
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int calib3d_StereoSGBM_get_1disp12MaxDiff_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::disp12MaxDiff
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1disp12MaxDiff_10 (IntPtr nativeObj, int disp12MaxDiff);
		
				// C++: bool StereoSGBM::fullDP
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool calib3d_StereoSGBM_get_1fullDP_10 (IntPtr nativeObj);
		
				// C++: void StereoSGBM::fullDP
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_set_1fullDP_10 (IntPtr nativeObj, bool fullDP);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void calib3d_StereoSGBM_delete (IntPtr nativeObj);
		#endif
		}
}
