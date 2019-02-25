
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvSVMParams
/**
 * <p>SVM training parameters.</p>
 *
 * <p>The structure must be initialized and passed to the training method of
 * "CvSVM".</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvmparams">org.opencv.ml.CvSVMParams</a>
 */
		public class CvSVMParams : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvSVMParams_delete (nativeObj);
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
				internal CvSVMParams (IntPtr addr)
				{
						nativeObj = addr;
				}//TODO:@check
	
	
				//
				// C++:   CvSVMParams::CvSVMParams()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The default constructor initialize the structure with following values:</p>
 *
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>CvSVMParams.CvSVMParams() :</p>
 *
 * <p>svm_type(CvSVM.C_SVC), kernel_type(CvSVM.RBF), degree(0),</p>
 *
 * <p>gamma(1), coef0(0), C(1), nu(0), p(0), class_weights(0)</p>
 *
 *
 * <p>term_crit = cvTermCriteria(CV_TERMCRIT_ITER+CV_TERMCRIT_EPS, 1000,
 * FLT_EPSILON);</p>
 *
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvmparams-cvsvmparams">org.opencv.ml.CvSVMParams.CvSVMParams</a>
 */
				public   CvSVMParams ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = ml_CvSVMParams_CvSVMParams_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvSVMParams::svm_type
				//
	
				public  int get_svm_type ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvSVMParams_get_1svm_1type_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::svm_type
				//
	
				public  void set_svm_type (int svm_type)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1svm_1type_10 (nativeObj, svm_type);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvSVMParams::kernel_type
				//
	
				public  int get_kernel_type ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvSVMParams_get_1kernel_1type_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::kernel_type
				//
	
				public  void set_kernel_type (int kernel_type)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1kernel_1type_10 (nativeObj, kernel_type);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::degree
				//
	
				public  double get_degree ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1degree_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::degree
				//
	
				public  void set_degree (double degree)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1degree_10 (nativeObj, degree);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::gamma
				//
	
				public  double get_gamma ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1gamma_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::gamma
				//
	
				public  void set_gamma (double gamma)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1gamma_10 (nativeObj, gamma);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::coef0
				//
	
				public  double get_coef0 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1coef0_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::coef0
				//
	
				public  void set_coef0 (double coef0)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1coef0_10 (nativeObj, coef0);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::C
				//
	
				public  double get_C ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1C_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::C
				//
	
				public  void set_C (double C)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1C_10 (nativeObj, C);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::nu
				//
	
				public  double get_nu ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1nu_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::nu
				//
	
				public  void set_nu (double nu)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1nu_10 (nativeObj, nu);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvSVMParams::p
				//
	
				public  double get_p ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvSVMParams_get_1p_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::p
				//
	
				public  void set_p (double p)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1p_10 (nativeObj, p);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: TermCriteria CvSVMParams::term_crit
				//
	
				public  TermCriteria get_term_crit ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[3];
						ml_CvSVMParams_get_1term_1crit_10 (nativeObj, tmpArray);
						TermCriteria retVal = new TermCriteria (tmpArray);
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++: void CvSVMParams::term_crit
				//
	
				public  void set_term_crit (TermCriteria term_crit)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVMParams_set_1term_1crit_10 (nativeObj, term_crit.type, term_crit.maxCount, term_crit.epsilon);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvSVMParams_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvSVMParams::CvSVMParams()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvSVMParams_CvSVMParams_10();
		
		// C++: int CvSVMParams::svm_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvSVMParams_get_1svm_1type_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::svm_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1svm_1type_10(IntPtr nativeObj, int svm_type);
		
		// C++: int CvSVMParams::kernel_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvSVMParams_get_1kernel_1type_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::kernel_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1kernel_1type_10(IntPtr nativeObj, int kernel_type);
		
		// C++: double CvSVMParams::degree
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1degree_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::degree
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1degree_10(IntPtr nativeObj, double degree);
		
		// C++: double CvSVMParams::gamma
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1gamma_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::gamma
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1gamma_10(IntPtr nativeObj, double gamma);
		
		// C++: double CvSVMParams::coef0
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1coef0_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::coef0
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1coef0_10(IntPtr nativeObj, double coef0);
		
		// C++: double CvSVMParams::C
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1C_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::C
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1C_10(IntPtr nativeObj, double C);
		
		// C++: double CvSVMParams::nu
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1nu_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::nu
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1nu_10(IntPtr nativeObj, double nu);
		
		// C++: double CvSVMParams::p
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvSVMParams_get_1p_10(IntPtr nativeObj);
		
		// C++: void CvSVMParams::p
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1p_10(IntPtr nativeObj, double p);
		
		// C++: TermCriteria CvSVMParams::term_crit
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_get_1term_1crit_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);
		
		// C++: void CvSVMParams::term_crit
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_set_1term_1crit_10(IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVMParams_delete(IntPtr nativeObj);

#else
		
				// C++:   CvSVMParams::CvSVMParams()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvSVMParams_CvSVMParams_10 ();
		
				// C++: int CvSVMParams::svm_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvSVMParams_get_1svm_1type_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::svm_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1svm_1type_10 (IntPtr nativeObj, int svm_type);
		
				// C++: int CvSVMParams::kernel_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvSVMParams_get_1kernel_1type_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::kernel_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1kernel_1type_10 (IntPtr nativeObj, int kernel_type);
		
				// C++: double CvSVMParams::degree
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1degree_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::degree
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1degree_10 (IntPtr nativeObj, double degree);
		
				// C++: double CvSVMParams::gamma
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1gamma_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::gamma
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1gamma_10 (IntPtr nativeObj, double gamma);
		
				// C++: double CvSVMParams::coef0
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1coef0_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::coef0
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1coef0_10 (IntPtr nativeObj, double coef0);
		
				// C++: double CvSVMParams::C
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1C_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::C
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1C_10 (IntPtr nativeObj, double C);
		
				// C++: double CvSVMParams::nu
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1nu_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::nu
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1nu_10 (IntPtr nativeObj, double nu);
		
				// C++: double CvSVMParams::p
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvSVMParams_get_1p_10 (IntPtr nativeObj);
		
				// C++: void CvSVMParams::p
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1p_10 (IntPtr nativeObj, double p);
		
				// C++: TermCriteria CvSVMParams::term_crit
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_get_1term_1crit_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);
		
				// C++: void CvSVMParams::term_crit
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_set_1term_1crit_10 (IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVMParams_delete (IntPtr nativeObj);
		#endif
		}
}
