
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvSVM
/**
 * <p>Support Vector Machines.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) An example of digit recognition using SVM can be found at
 * opencv_source/samples/python2/digits.py
 *   <li> (Python) An example of grid search digit recognition using SVM can be
 * found at opencv_source/samples/python2/digits_adjust.py
 *   <li> (Python) An example of video digit recognition using SVM can be found
 * at opencv_source/samples/python2/digits_video.py
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm">org.opencv.ml.CvSVM : public CvStatModel</a>
 */
		public class CvSVM : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvSVM_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvSVM (IntPtr addr) : base(addr)
				{
				}
	
				public const int C_SVC = 100;
				public const int NU_SVC = 101;
				public const int ONE_CLASS = 102;
				public const int EPS_SVR = 103;
				public const int NU_SVR = 104;
				public const int LINEAR = 0;
				public const int POLY = 1;
				public const int RBF = 2;
				public const int SIGMOID = 3;
				public const int C = 0;
				public const int GAMMA = 1;
				public const int P = 2;
				public const int NU = 3;
				public const int COEF = 4;
				public const int DEGREE = 5;
	
	
				//
				// C++:   CvSVM::CvSVM()
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-cvsvm">org.opencv.ml.CvSVM.CvSVM</a>
 */
				public   CvSVM ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvSVM_CvSVM_10() )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;

				}
	
	
				//
				// C++:   CvSVM::CvSVM(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param params a params
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-cvsvm">org.opencv.ml.CvSVM.CvSVM</a>
 */
				public   CvSVM (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvSVM_CvSVM_11(trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj) )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-cvsvm">org.opencv.ml.CvSVM.CvSVM</a>
 */
				public   CvSVM (Mat trainData, Mat responses)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvSVM_CvSVM_12(trainData.nativeObj, responses.nativeObj) )
			#else
			base(IntPtr.Zero)
			#endif
				{
						return;
				}
	
	
				//
				// C++:  void CvSVM::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVM_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  int CvSVM::get_support_vector_count()
				//
	
				public  int get_support_vector_count ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvSVM_get_1support_1vector_1count_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  int CvSVM::get_var_count()
				//
	
				/**
 * <p>Returns the number of used features (variables count).</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-get-var-count">org.opencv.ml.CvSVM.get_var_count</a>
 */
				public  int get_var_count ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvSVM_get_1var_1count_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  float CvSVM::predict(Mat sample, bool returnDFVal = false)
				//
	
				/**
 * <p>Predicts the response for input sample(s).</p>
 *
 * <p>If you pass one sample then prediction result is returned. If you want to get
 * responses for several samples then you should pass the <code>results</code>
 * matrix where prediction results will be stored.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param sample Input sample for prediction.
 * @param returnDFVal Specifies a type of the return value. If <code>true</code>
 * and the problem is 2-class classification then the method returns the
 * decision function value that is signed distance to the margin, else the
 * function returns a class label (classification) or estimated function value
 * (regression).
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-predict">org.opencv.ml.CvSVM.predict</a>
 */
				public  float predict (Mat sample, bool returnDFVal)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvSVM_predict_10 (nativeObj, sample.nativeObj, returnDFVal);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Predicts the response for input sample(s).</p>
 *
 * <p>If you pass one sample then prediction result is returned. If you want to get
 * responses for several samples then you should pass the <code>results</code>
 * matrix where prediction results will be stored.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param sample Input sample for prediction.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-predict">org.opencv.ml.CvSVM.predict</a>
 */
				public  float predict (Mat sample)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvSVM_predict_11 (nativeObj, sample.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  void CvSVM::predict(Mat samples, Mat& results)
				//
	
				/**
 * <p>Predicts the response for input sample(s).</p>
 *
 * <p>If you pass one sample then prediction result is returned. If you want to get
 * responses for several samples then you should pass the <code>results</code>
 * matrix where prediction results will be stored.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param samples Input samples for prediction.
 * @param results Output prediction responses for corresponding samples.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-predict">org.opencv.ml.CvSVM.predict</a>
 */
				public  void predict_all (Mat samples, Mat results)
				{
						if (samples != null)
								samples.ThrowIfDisposed ();
						if (results != null)
								results.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvSVM_predict_1all_10 (nativeObj, samples.nativeObj, results.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  bool CvSVM::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
				//
	
				/**
 * <p>Trains an SVM.</p>
 *
 * <p>The method trains the SVM model. It follows the conventions of the generic
 * "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only the <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variables can be either categorical (<code>params.svm_type=CvSVM.C_SVC</code>
 * or <code>params.svm_type=CvSVM.NU_SVC</code>), or ordered (<code>params.svm_type=CvSVM.EPS_SVR</code>
 * or <code>params.svm_type=CvSVM.NU_SVR</code>), or not required at all
 * (<code>params.svm_type=CvSVM.ONE_CLASS</code>).
 *   <li> Missing measurements are not supported.
 * </ul>
 *
 * <p>All the other parameters are gathered in the "CvSVMParams" structure.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param params a params
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-train">org.opencv.ml.CvSVM.train</a>
 */
				public  bool train (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvSVM_train_10 (nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains an SVM.</p>
 *
 * <p>The method trains the SVM model. It follows the conventions of the generic
 * "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only the <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variables can be either categorical (<code>params.svm_type=CvSVM.C_SVC</code>
 * or <code>params.svm_type=CvSVM.NU_SVC</code>), or ordered (<code>params.svm_type=CvSVM.EPS_SVR</code>
 * or <code>params.svm_type=CvSVM.NU_SVR</code>), or not required at all
 * (<code>params.svm_type=CvSVM.ONE_CLASS</code>).
 *   <li> Missing measurements are not supported.
 * </ul>
 *
 * <p>All the other parameters are gathered in the "CvSVMParams" structure.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-train">org.opencv.ml.CvSVM.train</a>
 */
				public  bool train (Mat trainData, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvSVM_train_11 (nativeObj, trainData.nativeObj, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  bool CvSVM::train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams params, int k_fold = 10, CvParamGrid Cgrid = CvSVM::get_default_grid(CvSVM::C), CvParamGrid gammaGrid = CvSVM::get_default_grid(CvSVM::GAMMA), CvParamGrid pGrid = CvSVM::get_default_grid(CvSVM::P), CvParamGrid nuGrid = CvSVM::get_default_grid(CvSVM::NU), CvParamGrid coeffGrid = CvSVM::get_default_grid(CvSVM::COEF), CvParamGrid degreeGrid = CvSVM::get_default_grid(CvSVM::DEGREE), bool balanced = false)
				//
	
				/**
 * <p>Trains an SVM with optimal parameters.</p>
 *
 * <p>The method trains the SVM model automatically by choosing the optimal
 * parameters <code>C</code>, <code>gamma</code>, <code>p</code>,
 * <code>nu</code>, <code>coef0</code>, <code>degree</code> from "CvSVMParams".
 * Parameters are considered optimal when the cross-validation estimate of the
 * test set error is minimal.</p>
 *
 * <p>If there is no need to optimize a parameter, the corresponding grid step
 * should be set to any value less than or equal to 1. For example, to avoid
 * optimization in <code>gamma</code>, set <code>gamma_grid.step = 0</code>,
 * <code>gamma_grid.min_val</code>, <code>gamma_grid.max_val</code> as arbitrary
 * numbers. In this case, the value <code>params.gamma</code> is taken for
 * <code>gamma</code>.</p>
 *
 * <p>And, finally, if the optimization in a parameter is required but the
 * corresponding grid is unknown, you may call the function "CvSVM.get_default_grid".
 * To generate a grid, for example, for <code>gamma</code>, call
 * <code>CvSVM.get_default_grid(CvSVM.GAMMA)</code>.</p>
 *
 * <p>This function works for the classification (<code>params.svm_type=CvSVM.C_SVC</code>
 * or <code>params.svm_type=CvSVM.NU_SVC</code>) as well as for the regression
 * (<code>params.svm_type=CvSVM.EPS_SVR</code> or <code>params.svm_type=CvSVM.NU_SVR</code>).
 * If <code>params.svm_type=CvSVM.ONE_CLASS</code>, no optimization is made and
 * the usual SVM with parameters specified in <code>params</code> is executed.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param params a params
 * @param k_fold Cross-validation parameter. The training set is divided into
 * <code>k_fold</code> subsets. One subset is used to test the model, the others
 * form the train set. So, the SVM algorithm is executed <code>k_fold</code>
 * times.
 * @param Cgrid a Cgrid
 * @param gammaGrid Iteration grid for the corresponding SVM parameter.
 * @param pGrid Iteration grid for the corresponding SVM parameter.
 * @param nuGrid Iteration grid for the corresponding SVM parameter.
 * @param coeffGrid Iteration grid for the corresponding SVM parameter.
 * @param degreeGrid Iteration grid for the corresponding SVM parameter.
 * @param balanced If <code>true</code> and the problem is 2-class
 * classification then the method creates more balanced cross-validation subsets
 * that is proportions between classes in subsets are close to such proportion
 * in the whole train dataset.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-train-auto">org.opencv.ml.CvSVM.train_auto</a>
 */
				public  bool train_auto (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params, int k_fold, CvParamGrid Cgrid, CvParamGrid gammaGrid, CvParamGrid pGrid, CvParamGrid nuGrid, CvParamGrid coeffGrid, CvParamGrid degreeGrid, bool balanced)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						if (Cgrid != null)
								Cgrid.ThrowIfDisposed ();
						if (gammaGrid != null)
								gammaGrid.ThrowIfDisposed ();
						if (pGrid != null)
								pGrid.ThrowIfDisposed ();
						if (nuGrid != null)
								nuGrid.ThrowIfDisposed ();
						if (coeffGrid != null)
								coeffGrid.ThrowIfDisposed ();
						if (degreeGrid != null)
								degreeGrid.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvSVM_train_1auto_10 (nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj, k_fold, Cgrid.nativeObj, gammaGrid.nativeObj, pGrid.nativeObj, nuGrid.nativeObj, coeffGrid.nativeObj, degreeGrid.nativeObj, balanced);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains an SVM with optimal parameters.</p>
 *
 * <p>The method trains the SVM model automatically by choosing the optimal
 * parameters <code>C</code>, <code>gamma</code>, <code>p</code>,
 * <code>nu</code>, <code>coef0</code>, <code>degree</code> from "CvSVMParams".
 * Parameters are considered optimal when the cross-validation estimate of the
 * test set error is minimal.</p>
 *
 * <p>If there is no need to optimize a parameter, the corresponding grid step
 * should be set to any value less than or equal to 1. For example, to avoid
 * optimization in <code>gamma</code>, set <code>gamma_grid.step = 0</code>,
 * <code>gamma_grid.min_val</code>, <code>gamma_grid.max_val</code> as arbitrary
 * numbers. In this case, the value <code>params.gamma</code> is taken for
 * <code>gamma</code>.</p>
 *
 * <p>And, finally, if the optimization in a parameter is required but the
 * corresponding grid is unknown, you may call the function "CvSVM.get_default_grid".
 * To generate a grid, for example, for <code>gamma</code>, call
 * <code>CvSVM.get_default_grid(CvSVM.GAMMA)</code>.</p>
 *
 * <p>This function works for the classification (<code>params.svm_type=CvSVM.C_SVC</code>
 * or <code>params.svm_type=CvSVM.NU_SVC</code>) as well as for the regression
 * (<code>params.svm_type=CvSVM.EPS_SVR</code> or <code>params.svm_type=CvSVM.NU_SVR</code>).
 * If <code>params.svm_type=CvSVM.ONE_CLASS</code>, no optimization is made and
 * the usual SVM with parameters specified in <code>params</code> is executed.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param params a params
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm-train-auto">org.opencv.ml.CvSVM.train_auto</a>
 */
				public  bool train_auto (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvSVM_train_1auto_11 (nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvSVM_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvSVM::CvSVM()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvSVM_CvSVM_10();
		
		// C++:   CvSVM::CvSVM(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvSVM_CvSVM_11(IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvSVM_CvSVM_12(IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// C++:  void CvSVM::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVM_clear_10(IntPtr nativeObj);
		
		// C++:  int CvSVM::get_support_vector_count()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvSVM_get_1support_1vector_1count_10(IntPtr nativeObj);
		
		// C++:  int CvSVM::get_var_count()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvSVM_get_1var_1count_10(IntPtr nativeObj);
		
		// C++:  float CvSVM::predict(Mat sample, bool returnDFVal = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvSVM_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, bool returnDFVal);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvSVM_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);
		
		// C++:  void CvSVM::predict(Mat samples, Mat& results)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVM_predict_1all_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
		
		// C++:  bool CvSVM::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvSVM_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvSVM_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// C++:  bool CvSVM::train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams params, int k_fold = 10, CvParamGrid Cgrid = CvSVM::get_default_grid(CvSVM::C), CvParamGrid gammaGrid = CvSVM::get_default_grid(CvSVM::GAMMA), CvParamGrid pGrid = CvSVM::get_default_grid(CvSVM::P), CvParamGrid nuGrid = CvSVM::get_default_grid(CvSVM::NU), CvParamGrid coeffGrid = CvSVM::get_default_grid(CvSVM::COEF), CvParamGrid degreeGrid = CvSVM::get_default_grid(CvSVM::DEGREE), bool balanced = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvSVM_train_1auto_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int k_fold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj, IntPtr degreeGrid_nativeObj, bool balanced);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvSVM_train_1auto_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvSVM_delete(IntPtr nativeObj);

#else
		
				// C++:   CvSVM::CvSVM()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvSVM_CvSVM_10 ();
		
				// C++:   CvSVM::CvSVM(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvSVM_CvSVM_11 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvSVM_CvSVM_12 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// C++:  void CvSVM::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVM_clear_10 (IntPtr nativeObj);
		
				// C++:  int CvSVM::get_support_vector_count()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvSVM_get_1support_1vector_1count_10 (IntPtr nativeObj);
		
				// C++:  int CvSVM::get_var_count()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvSVM_get_1var_1count_10 (IntPtr nativeObj);
		
				// C++:  float CvSVM::predict(Mat sample, bool returnDFVal = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvSVM_predict_10 (IntPtr nativeObj, IntPtr sample_nativeObj, bool returnDFVal);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvSVM_predict_11 (IntPtr nativeObj, IntPtr sample_nativeObj);
		
				// C++:  void CvSVM::predict(Mat samples, Mat& results)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVM_predict_1all_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
		
				// C++:  bool CvSVM::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvSVM_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvSVM_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// C++:  bool CvSVM::train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams params, int k_fold = 10, CvParamGrid Cgrid = CvSVM::get_default_grid(CvSVM::C), CvParamGrid gammaGrid = CvSVM::get_default_grid(CvSVM::GAMMA), CvParamGrid pGrid = CvSVM::get_default_grid(CvSVM::P), CvParamGrid nuGrid = CvSVM::get_default_grid(CvSVM::NU), CvParamGrid coeffGrid = CvSVM::get_default_grid(CvSVM::COEF), CvParamGrid degreeGrid = CvSVM::get_default_grid(CvSVM::DEGREE), bool balanced = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvSVM_train_1auto_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int k_fold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj, IntPtr degreeGrid_nativeObj, bool balanced);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvSVM_train_1auto_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvSVM_delete (IntPtr nativeObj);
		#endif
		}
}