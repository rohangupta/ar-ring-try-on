
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvANN_MLP_TrainParams
/**
 * <p>Parameters of the MLP training algorithm. You can initialize the structure by
 * a constructor or the individual parameters can be adjusted after the
 * structure is created.</p>
 *
 * <p>The back-propagation algorithm parameters:</p>
 *
 * <p>Strength of the weight gradient term. The recommended value is about 0.1.</p>
 *
 * <p>Strength of the momentum term (the difference between weights on the 2
 * previous iterations). This parameter provides some inertia to smooth the
 * random fluctuations of the weights. It can vary from 0 (the feature is
 * disabled) to 1 and beyond. The value 0.1 or so is good enough <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>The RPROP algorithm parameters (see [RPROP93] for details):</p>
 *
 * <p>Initial value <em>Delta_0</em> of update-values <em>Delta_(ij)</em>.</p>
 *
 * <p>Increase factor <em>eta^+</em>. It must be >1.</p>
 *
 * <p>Decrease factor <em>eta^-</em>. It must be <1.</p>
 *
 * <p>Update-values lower limit <em>Delta_(min)</em>. It must be positive.</p>
 *
 * <p>Update-values upper limit <em>Delta_(max)</em>. It must be >1.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-trainparams">org.opencv.ml.CvANN_MLP_TrainParams</a>
 */
		public class CvANN_MLP_TrainParams : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvANN_1MLP_1TrainParams_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
//	/*protected*/internal readonly IntPtr nativeObj;//TODO:@check
				/*protected*/
				internal CvANN_MLP_TrainParams (IntPtr addr)
				{
						nativeObj = addr;
				}//TODO:@check
	
	
				public const int BACKPROP = 0;
				public const int RPROP = 1;
	
	
				//
				// C++:   CvANN_MLP_TrainParams::CvANN_MLP_TrainParams()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>By default the RPROP algorithm is used:</p>
 *
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>CvANN_MLP_TrainParams.CvANN_MLP_TrainParams()</p>
 *
 *
 * <p>term_crit = cvTermCriteria(CV_TERMCRIT_ITER + CV_TERMCRIT_EPS, 1000, 0.01);</p>
 *
 * <p>train_method = RPROP;</p>
 *
 * <p>bp_dw_scale = bp_moment_scale = 0.1;</p>
 *
 * <p>rp_dw0 = 0.1; rp_dw_plus = 1.2; rp_dw_minus = 0.5;</p>
 *
 * <p>rp_dw_min = FLT_EPSILON; rp_dw_max = 50.;</p>
 *
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-trainparams-cvann-mlp-trainparams">org.opencv.ml.CvANN_MLP_TrainParams.CvANN_MLP_TrainParams</a>
 */
				public   CvANN_MLP_TrainParams ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = ml_CvANN_1MLP_1TrainParams_CvANN_1MLP_1TrainParams_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: TermCriteria CvANN_MLP_TrainParams::term_crit
				//
	
				public  TermCriteria get_term_crit ()
				{
						ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[3];
						ml_CvANN_1MLP_1TrainParams_get_1term_1crit_10 (nativeObj, tmpArray);
						TermCriteria retVal = new TermCriteria (tmpArray);
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::term_crit
				//
	
				public  void set_term_crit (TermCriteria term_crit)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1term_1crit_10 (nativeObj, term_crit.type, term_crit.maxCount, term_crit.epsilon);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvANN_MLP_TrainParams::train_method
				//
	
				public  int get_train_method ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvANN_1MLP_1TrainParams_get_1train_1method_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::train_method
				//
	
				public  void set_train_method (int train_method)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1train_1method_10 (nativeObj, train_method);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::bp_dw_scale
				//
	
				public  double get_bp_dw_scale ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1bp_1dw_1scale_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::bp_dw_scale
				//
	
				public  void set_bp_dw_scale (double bp_dw_scale)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1bp_1dw_1scale_10 (nativeObj, bp_dw_scale);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::bp_moment_scale
				//
	
				public  double get_bp_moment_scale ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1bp_1moment_1scale_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::bp_moment_scale
				//
	
				public  void set_bp_moment_scale (double bp_moment_scale)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1bp_1moment_1scale_10 (nativeObj, bp_moment_scale);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::rp_dw0
				//
	
				public  double get_rp_dw0 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1rp_1dw0_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::rp_dw0
				//
	
				public  void set_rp_dw0 (double rp_dw0)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1rp_1dw0_10 (nativeObj, rp_dw0);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::rp_dw_plus
				//
	
				public  double get_rp_dw_plus ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1plus_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::rp_dw_plus
				//
	
				public  void set_rp_dw_plus (double rp_dw_plus)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1plus_10 (nativeObj, rp_dw_plus);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::rp_dw_minus
				//
	
				public  double get_rp_dw_minus ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1minus_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::rp_dw_minus
				//
	
				public  void set_rp_dw_minus (double rp_dw_minus)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1minus_10 (nativeObj, rp_dw_minus);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::rp_dw_min
				//
	
				public  double get_rp_dw_min ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1min_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::rp_dw_min
				//
	
				public  void set_rp_dw_min (double rp_dw_min)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1min_10 (nativeObj, rp_dw_min);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvANN_MLP_TrainParams::rp_dw_max
				//
	
				public  double get_rp_dw_max ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1max_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvANN_MLP_TrainParams::rp_dw_max
				//
	
				public  void set_rp_dw_max (double rp_dw_max)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1max_10 (nativeObj, rp_dw_max);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvANN_1MLP_1TrainParams_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvANN_MLP_TrainParams::CvANN_MLP_TrainParams()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvANN_1MLP_1TrainParams_CvANN_1MLP_1TrainParams_10();
		
		// C++: TermCriteria CvANN_MLP_TrainParams::term_crit
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_get_1term_1crit_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);
		
		// C++: void CvANN_MLP_TrainParams::term_crit
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1term_1crit_10(IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);
		
		// C++: int CvANN_MLP_TrainParams::train_method
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvANN_1MLP_1TrainParams_get_1train_1method_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::train_method
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1train_1method_10(IntPtr nativeObj, int train_method);
		
		// C++: double CvANN_MLP_TrainParams::bp_dw_scale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1bp_1dw_1scale_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::bp_dw_scale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1bp_1dw_1scale_10(IntPtr nativeObj, double bp_dw_scale);
		
		// C++: double CvANN_MLP_TrainParams::bp_moment_scale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1bp_1moment_1scale_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::bp_moment_scale
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1bp_1moment_1scale_10(IntPtr nativeObj, double bp_moment_scale);
		
		// C++: double CvANN_MLP_TrainParams::rp_dw0
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw0_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::rp_dw0
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw0_10(IntPtr nativeObj, double rp_dw0);
		
		// C++: double CvANN_MLP_TrainParams::rp_dw_plus
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1plus_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::rp_dw_plus
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1plus_10(IntPtr nativeObj, double rp_dw_plus);
		
		// C++: double CvANN_MLP_TrainParams::rp_dw_minus
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1minus_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::rp_dw_minus
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1minus_10(IntPtr nativeObj, double rp_dw_minus);
		
		// C++: double CvANN_MLP_TrainParams::rp_dw_min
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1min_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::rp_dw_min
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1min_10(IntPtr nativeObj, double rp_dw_min);
		
		// C++: double CvANN_MLP_TrainParams::rp_dw_max
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1max_10(IntPtr nativeObj);
		
		// C++: void CvANN_MLP_TrainParams::rp_dw_max
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1max_10(IntPtr nativeObj, double rp_dw_max);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_1TrainParams_delete(IntPtr nativeObj);

#else
		
				// C++:   CvANN_MLP_TrainParams::CvANN_MLP_TrainParams()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvANN_1MLP_1TrainParams_CvANN_1MLP_1TrainParams_10 ();
		
				// C++: TermCriteria CvANN_MLP_TrainParams::term_crit
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_get_1term_1crit_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);
		
				// C++: void CvANN_MLP_TrainParams::term_crit
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1term_1crit_10 (IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);
		
				// C++: int CvANN_MLP_TrainParams::train_method
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvANN_1MLP_1TrainParams_get_1train_1method_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::train_method
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1train_1method_10 (IntPtr nativeObj, int train_method);
		
				// C++: double CvANN_MLP_TrainParams::bp_dw_scale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1bp_1dw_1scale_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::bp_dw_scale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1bp_1dw_1scale_10 (IntPtr nativeObj, double bp_dw_scale);
		
				// C++: double CvANN_MLP_TrainParams::bp_moment_scale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1bp_1moment_1scale_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::bp_moment_scale
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1bp_1moment_1scale_10 (IntPtr nativeObj, double bp_moment_scale);
		
				// C++: double CvANN_MLP_TrainParams::rp_dw0
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw0_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::rp_dw0
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw0_10 (IntPtr nativeObj, double rp_dw0);
		
				// C++: double CvANN_MLP_TrainParams::rp_dw_plus
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1plus_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::rp_dw_plus
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1plus_10 (IntPtr nativeObj, double rp_dw_plus);
		
				// C++: double CvANN_MLP_TrainParams::rp_dw_minus
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1minus_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::rp_dw_minus
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1minus_10 (IntPtr nativeObj, double rp_dw_minus);
		
				// C++: double CvANN_MLP_TrainParams::rp_dw_min
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1min_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::rp_dw_min
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1min_10 (IntPtr nativeObj, double rp_dw_min);
		
				// C++: double CvANN_MLP_TrainParams::rp_dw_max
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvANN_1MLP_1TrainParams_get_1rp_1dw_1max_10 (IntPtr nativeObj);
		
				// C++: void CvANN_MLP_TrainParams::rp_dw_max
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_set_1rp_1dw_1max_10 (IntPtr nativeObj, double rp_dw_max);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_1TrainParams_delete (IntPtr nativeObj);
		#endif
		}
}
