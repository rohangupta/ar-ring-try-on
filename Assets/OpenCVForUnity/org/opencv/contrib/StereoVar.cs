
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


		// C++: class StereoVar
		/**
 * <p>Class for computing stereo correspondence using the variational matching
 * algorithm</p>
 *
 * <p>class StereoVar <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>StereoVar();</p>
 *
 * <p>StereoVar(int levels, double pyrScale,</p>
 *
 * <p>int nIt, int minDisp, int maxDisp,</p>
 *
 * <p>int poly_n, double poly_sigma, float fi,</p>
 *
 * <p>float lambda, int penalization, int cycle,</p>
 *
 * <p>int flags);</p>
 *
 * <p>virtual ~StereoVar();</p>
 *
 * <p>virtual void operator()(InputArray left, InputArray right, OutputArray disp);</p>
 *
 * <p>int levels;</p>
 *
 * <p>double pyrScale;</p>
 *
 * <p>int nIt;</p>
 *
 * <p>int minDisp;</p>
 *
 * <p>int maxDisp;</p>
 *
 * <p>int poly_n;</p>
 *
 * <p>double poly_sigma;</p>
 *
 * <p>float fi;</p>
 *
 * <p>float lambda;</p>
 *
 * <p>int penalization;</p>
 *
 * <p>int cycle;</p>
 *
 * <p>int flags;...</p>
 *
 * <p>};</p>
 *
 * <p>The class implements the modified S. G. Kosov algorithm [KTS09] that differs
 * from the original one as follows: </code></p>
 * <ul>
 *   <li> The automatic initialization of method's parameters is added.
 *   <li> The method of Smart Iteration Distribution (SID) is implemented.
 *   <li> The support of Multi-Level Adaptation Technique (MLAT) is not
 * included.
 *   <li> The method of dynamic adaptation of method's parameters is not
 * included.
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/contrib/doc/stereo.html#stereovar">org.opencv.contrib.StereoVar</a>
 */
		public class StereoVar : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												contrib_StereoVar_delete (nativeObj);
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
				protected StereoVar (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int USE_INITIAL_DISPARITY = 1;
				public const int	USE_EQUALIZE_HIST = 2;
				public const int	USE_SMART_ID = 4;
				public const int	USE_AUTO_PARAMS = 8;
				public const int	USE_MEDIAN_FILTERING = 16;
				public const int	CYCLE_O = 0;
				public const int	CYCLE_V = 1;
				public const int	PENALIZATION_TICHONOV = 0;
				public const int	PENALIZATION_CHARBONNIER = 1;
				public const int	PENALIZATION_PERONA_MALIK = 2;
	
	
				//
				// C++:   StereoVar::StereoVar()
				//
	
				/**
 * <p>The constructor</p>
 *
 * <p>The first constructor initializes <code>StereoVar</code> with all the default
 * parameters. So, you only have to set <code>StereoVar.maxDisp</code> and / or
 * <code>StereoVar.minDisp</code> at minimum. The second constructor enables
 * you to set each parameter to a custom value.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/contrib/doc/stereo.html#stereovar-stereovar">org.opencv.contrib.StereoVar.StereoVar</a>
 */
				public   StereoVar ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = contrib_StereoVar_StereoVar_10 ();
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:   StereoVar::StereoVar(int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags)
				//
	
				/**
 * <p>The constructor</p>
 *
 * <p>The first constructor initializes <code>StereoVar</code> with all the default
 * parameters. So, you only have to set <code>StereoVar.maxDisp</code> and / or
 * <code>StereoVar.minDisp</code> at minimum. The second constructor enables
 * you to set each parameter to a custom value.</p>
 *
 * @param levels The number of pyramid layers, including the initial image.
 * levels=1 means that no extra layers are created and only the original images
 * are used. This parameter is ignored if flag USE_AUTO_PARAMS is set.
 * @param pyrScale Specifies the image scale (<1) to build the pyramids for each
 * image. pyrScale=0.5 means the classical pyramid, where each next layer is
 * twice smaller than the previous. (This parameter is ignored if flag
 * USE_AUTO_PARAMS is set).
 * @param nIt The number of iterations the algorithm does at each pyramid level.
 * (If the flag USE_SMART_ID is set, the number of iterations will be
 * redistributed in such a way, that more iterations will be done on more
 * coarser levels.)
 * @param minDisp Minimum possible disparity value. Could be negative in case
 * the left and right input images change places.
 * @param maxDisp Maximum possible disparity value.
 * @param poly_n Size of the pixel neighbourhood used to find polynomial
 * expansion in each pixel. The larger values mean that the image will be
 * approximated with smoother surfaces, yielding more robust algorithm and more
 * blurred motion field. Typically, poly_n = 3, 5 or 7
 * @param poly_sigma Standard deviation of the Gaussian that is used to smooth
 * derivatives that are used as a basis for the polynomial expansion. For
 * poly_n=5 you can set poly_sigma=1.1, for poly_n=7 a good value would be
 * poly_sigma=1.5
 * @param fi The smoothness parameter, ot the weight coefficient for the
 * smoothness term.
 * @param lambda The threshold parameter for edge-preserving smoothness. (This
 * parameter is ignored if PENALIZATION_CHARBONNIER or PENALIZATION_PERONA_MALIK
 * is used.)
 * @param penalization Possible values: PENALIZATION_TICHONOV - linear
 * smoothness; PENALIZATION_CHARBONNIER - non-linear edge preserving smoothness;
 * PENALIZATION_PERONA_MALIK - non-linear edge-enhancing smoothness. (This
 * parameter is ignored if flag USE_AUTO_PARAMS is set).
 * @param cycle Type of the multigrid cycle. Possible values: CYCLE_O and
 * CYCLE_V for null- and v-cycles respectively. (This parameter is ignored if
 * flag USE_AUTO_PARAMS is set).
 * @param flags The operation flags; can be a combination of the following:
 * <ul>
 *   <li> USE_INITIAL_DISPARITY: Use the input flow as the initial flow
 * approximation.
 *   <li> USE_EQUALIZE_HIST: Use the histogram equalization in the
 * pre-processing phase.
 *   <li> USE_SMART_ID: Use the smart iteration distribution (SID).
 *   <li> USE_AUTO_PARAMS: Allow the method to initialize the main parameters.
 *   <li> USE_MEDIAN_FILTERING: Use the median filer of the solution in the post
 * processing phase.
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/contrib/doc/stereo.html#stereovar-stereovar">org.opencv.contrib.StereoVar.StereoVar</a>
 */
				public   StereoVar (int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = contrib_StereoVar_StereoVar_11 (levels, pyrScale, nIt, minDisp, maxDisp, poly_n, poly_sigma, fi, lambda, penalization, cycle, flags);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void StereoVar::operator ()(Mat left, Mat right, Mat& disp)
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
						contrib_StereoVar_compute_10 (nativeObj, left.nativeObj, right.nativeObj, disp.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::levels
				//
	
				public  int get_levels ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1levels_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::levels
				//
	
				public  void set_levels (int levels)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1levels_10 (nativeObj, levels);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: double StereoVar::pyrScale
				//
	
				public  double get_pyrScale ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = contrib_StereoVar_get_1pyrScale_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::pyrScale
				//
	
				public  void set_pyrScale (double pyrScale)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1pyrScale_10 (nativeObj, pyrScale);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::nIt
				//
	
				public  int get_nIt ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1nIt_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::nIt
				//
	
				public  void set_nIt (int nIt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1nIt_10 (nativeObj, nIt);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::minDisp
				//
	
				public  int get_minDisp ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1minDisp_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::minDisp
				//
	
				public  void set_minDisp (int minDisp)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1minDisp_10 (nativeObj, minDisp);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::maxDisp
				//
	
				public  int get_maxDisp ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1maxDisp_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::maxDisp
				//
	
				public  void set_maxDisp (int maxDisp)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1maxDisp_10 (nativeObj, maxDisp);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::poly_n
				//
	
				public  int get_poly_n ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1poly_1n_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::poly_n
				//
	
				public  void set_poly_n (int poly_n)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1poly_1n_10 (nativeObj, poly_n);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: double StereoVar::poly_sigma
				//
	
				public  double get_poly_sigma ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = contrib_StereoVar_get_1poly_1sigma_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::poly_sigma
				//
	
				public  void set_poly_sigma (double poly_sigma)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1poly_1sigma_10 (nativeObj, poly_sigma);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: float StereoVar::fi
				//
	
				public  float get_fi ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = contrib_StereoVar_get_1fi_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::fi
				//
	
				public  void set_fi (float fi)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1fi_10 (nativeObj, fi);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: float StereoVar::lambda
				//
	
				public  float get_lambda ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = contrib_StereoVar_get_1lambda_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::lambda
				//
	
				public  void set_lambda (float lambda)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1lambda_10 (nativeObj, lambda);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::penalization
				//
	
				public  int get_penalization ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1penalization_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::penalization
				//
	
				public  void set_penalization (int penalization)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1penalization_10 (nativeObj, penalization);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::cycle
				//
	
				public  int get_cycle ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1cycle_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::cycle
				//
	
				public  void set_cycle (int cycle)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1cycle_10 (nativeObj, cycle);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: int StereoVar::flags
				//
	
				public  int get_flags ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = contrib_StereoVar_get_1flags_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: void StereoVar::flags
				//
	
				public  void set_flags (int flags)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_StereoVar_set_1flags_10 (nativeObj, flags);
		
						return;
						#else
						return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			contrib_StereoVar_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   StereoVar::StereoVar()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr contrib_StereoVar_StereoVar_10();
		
		// C++:   StereoVar::StereoVar(int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr contrib_StereoVar_StereoVar_11(int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags);
		
		// C++:  void StereoVar::operator ()(Mat left, Mat right, Mat& disp)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disp_nativeObj);
		
		// C++: int StereoVar::levels
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1levels_10(IntPtr nativeObj);
		
		// C++: void StereoVar::levels
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1levels_10(IntPtr nativeObj, int levels);
		
		// C++: double StereoVar::pyrScale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double contrib_StereoVar_get_1pyrScale_10(IntPtr nativeObj);
		
		// C++: void StereoVar::pyrScale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1pyrScale_10(IntPtr nativeObj, double pyrScale);
		
		// C++: int StereoVar::nIt
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1nIt_10(IntPtr nativeObj);
		
		// C++: void StereoVar::nIt
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1nIt_10(IntPtr nativeObj, int nIt);
		
		// C++: int StereoVar::minDisp
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1minDisp_10(IntPtr nativeObj);
		
		// C++: void StereoVar::minDisp
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1minDisp_10(IntPtr nativeObj, int minDisp);
		
		// C++: int StereoVar::maxDisp
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1maxDisp_10(IntPtr nativeObj);
		
		// C++: void StereoVar::maxDisp
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1maxDisp_10(IntPtr nativeObj, int maxDisp);
		
		// C++: int StereoVar::poly_n
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1poly_1n_10(IntPtr nativeObj);
		
		// C++: void StereoVar::poly_n
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1poly_1n_10(IntPtr nativeObj, int poly_n);
		
		// C++: double StereoVar::poly_sigma
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double contrib_StereoVar_get_1poly_1sigma_10(IntPtr nativeObj);
		
		// C++: void StereoVar::poly_sigma
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1poly_1sigma_10(IntPtr nativeObj, double poly_sigma);
		
		// C++: float StereoVar::fi
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float contrib_StereoVar_get_1fi_10(IntPtr nativeObj);
		
		// C++: void StereoVar::fi
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1fi_10(IntPtr nativeObj, float fi);
		
		// C++: float StereoVar::lambda
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float contrib_StereoVar_get_1lambda_10(IntPtr nativeObj);
		
		// C++: void StereoVar::lambda
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1lambda_10(IntPtr nativeObj, float lambda);
		
		// C++: int StereoVar::penalization
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1penalization_10(IntPtr nativeObj);
		
		// C++: void StereoVar::penalization
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1penalization_10(IntPtr nativeObj, int penalization);
		
		// C++: int StereoVar::cycle
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1cycle_10(IntPtr nativeObj);
		
		// C++: void StereoVar::cycle
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1cycle_10(IntPtr nativeObj, int cycle);

		// C++: int StereoVar::flags
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_StereoVar_get_1flags_10(IntPtr nativeObj);
		
		// C++: void StereoVar::flags
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_set_1flags_10(IntPtr nativeObj, int flags);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_StereoVar_delete(IntPtr nativeObj);

#else
				// C++:   StereoVar::StereoVar()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr contrib_StereoVar_StereoVar_10 ();
		
				// C++:   StereoVar::StereoVar(int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr contrib_StereoVar_StereoVar_11 (int levels, double pyrScale, int nIt, int minDisp, int maxDisp, int poly_n, double poly_sigma, float fi, float lambda, int penalization, int cycle, int flags);
		
				// C++:  void StereoVar::operator ()(Mat left, Mat right, Mat& disp)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_compute_10 (IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disp_nativeObj);
		
				// C++: int StereoVar::levels
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1levels_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::levels
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1levels_10 (IntPtr nativeObj, int levels);
		
				// C++: double StereoVar::pyrScale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double contrib_StereoVar_get_1pyrScale_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::pyrScale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1pyrScale_10 (IntPtr nativeObj, double pyrScale);
		
				// C++: int StereoVar::nIt
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1nIt_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::nIt
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1nIt_10 (IntPtr nativeObj, int nIt);
		
				// C++: int StereoVar::minDisp
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1minDisp_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::minDisp
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1minDisp_10 (IntPtr nativeObj, int minDisp);
		
				// C++: int StereoVar::maxDisp
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1maxDisp_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::maxDisp
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1maxDisp_10 (IntPtr nativeObj, int maxDisp);
		
				// C++: int StereoVar::poly_n
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1poly_1n_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::poly_n
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1poly_1n_10 (IntPtr nativeObj, int poly_n);
		
				// C++: double StereoVar::poly_sigma
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double contrib_StereoVar_get_1poly_1sigma_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::poly_sigma
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1poly_1sigma_10 (IntPtr nativeObj, double poly_sigma);
		
				// C++: float StereoVar::fi
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float contrib_StereoVar_get_1fi_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::fi
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1fi_10 (IntPtr nativeObj, float fi);
		
				// C++: float StereoVar::lambda
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float contrib_StereoVar_get_1lambda_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::lambda
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1lambda_10 (IntPtr nativeObj, float lambda);
		
				// C++: int StereoVar::penalization
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1penalization_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::penalization
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1penalization_10 (IntPtr nativeObj, int penalization);
		
				// C++: int StereoVar::cycle
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1cycle_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::cycle
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1cycle_10 (IntPtr nativeObj, int cycle);
		
				// C++: int StereoVar::flags
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_StereoVar_get_1flags_10 (IntPtr nativeObj);
		
				// C++: void StereoVar::flags
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_set_1flags_10 (IntPtr nativeObj, int flags);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_StereoVar_delete (IntPtr nativeObj);
		#endif
		}
}

