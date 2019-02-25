
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace  OpenCVForUnity
{


// C++: class CvRTrees
/**
 * <p>The class implements the random forest predictor as described in the
 * beginning of this section.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees">org.opencv.ml.CvRTrees : public CvStatModel</a>
 */
		public class CvRTrees : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvRTrees_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvRTrees (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvRTrees::CvRTrees()
				//
	
				public   CvRTrees ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			base( ml_CvRTrees_CvRTrees_10() )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
	
				//
				// C++:  void CvRTrees::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvRTrees_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  Mat CvRTrees::getVarImportance()
				//
	
				/**
 * <p>Returns the variable importance array.</p>
 *
 * <p>The method returns the variable importance vector, computed at the training
 * stage when <code>CvRTParams.calc_var_importance</code> is set to true. If
 * this flag was set to false, the <code>NULL</code> pointer is returned. This
 * differs from the decision trees where variable importance can be computed
 * anytime after the training.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-getvarimportance">org.opencv.ml.CvRTrees.getVarImportance</a>
 */
				public  Mat getVarImportance ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (ml_CvRTrees_getVarImportance_10 (nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  float CvRTrees::predict(Mat sample, Mat missing = cv::Mat())
				//
	
				/**
 * <p>Predicts the output for an input sample.</p>
 *
 * <p>The input parameters of the prediction method are the same as in
 * "CvDTree.predict" but the return value type is different. This method
 * returns the cumulative result from all the trees in the forest (the class
 * that receives the majority of voices, or the mean of the regression function
 * estimates).</p>
 *
 * @param sample Sample for classification.
 * @param missing Optional missing measurement mask of the sample.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-predict">org.opencv.ml.CvRTrees.predict</a>
 */
				public  float predict (Mat sample, Mat missing)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						if (missing != null)
								missing.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvRTrees_predict_10 (nativeObj, sample.nativeObj, missing.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Predicts the output for an input sample.</p>
 *
 * <p>The input parameters of the prediction method are the same as in
 * "CvDTree.predict" but the return value type is different. This method
 * returns the cumulative result from all the trees in the forest (the class
 * that receives the majority of voices, or the mean of the regression function
 * estimates).</p>
 *
 * @param sample Sample for classification.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-predict">org.opencv.ml.CvRTrees.predict</a>
 */
				public  float predict (Mat sample)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvRTrees_predict_11 (nativeObj, sample.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  float CvRTrees::predict_prob(Mat sample, Mat missing = cv::Mat())
				//
	
				/**
 * <p>Returns a fuzzy-predicted class label.</p>
 *
 * <p>The function works for binary classification problems only. It returns the
 * number between 0 and 1. This number represents probability or confidence of
 * the sample belonging to the second class. It is calculated as the proportion
 * of decision trees that classified the sample to the second class.</p>
 *
 * @param sample Sample for classification.
 * @param missing Optional missing measurement mask of the sample.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-predict-prob">org.opencv.ml.CvRTrees.predict_prob</a>
 */
				public  float predict_prob (Mat sample, Mat missing)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						if (missing != null)
								missing.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvRTrees_predict_1prob_10 (nativeObj, sample.nativeObj, missing.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Returns a fuzzy-predicted class label.</p>
 *
 * <p>The function works for binary classification problems only. It returns the
 * number between 0 and 1. This number represents probability or confidence of
 * the sample belonging to the second class. It is calculated as the proportion
 * of decision trees that classified the sample to the second class.</p>
 *
 * @param sample Sample for classification.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-predict-prob">org.opencv.ml.CvRTrees.predict_prob</a>
 */
				public  float predict_prob (Mat sample)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvRTrees_predict_1prob_11 (nativeObj, sample.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  bool CvRTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
				//
	
				/**
 * <p>Trains the Random Trees model.</p>
 *
 * <p>The method "CvRTrees.train" is very similar to the method "CvDTree.train"
 * and follows the generic method "CvStatModel.train" conventions. All the
 * parameters specific to the algorithm training are passed as a "CvRTParams"
 * instance. The estimate of the training error (<code>oob-error</code>) is
 * stored in the protected class member <code>oob_error</code>.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param varType a varType
 * @param missingDataMask a missingDataMask
 * @param params a params
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-train">org.opencv.ml.CvRTrees.train</a>
 */
				public virtual  bool train (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvRTParams _params)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (varType != null)
								varType.ThrowIfDisposed ();
						if (missingDataMask != null)
								missingDataMask.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvRTrees_train_10 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains the Random Trees model.</p>
 *
 * <p>The method "CvRTrees.train" is very similar to the method "CvDTree.train"
 * and follows the generic method "CvStatModel.train" conventions. All the
 * parameters specific to the algorithm training are passed as a "CvRTParams"
 * instance. The estimate of the training error (<code>oob-error</code>) is
 * stored in the protected class member <code>oob_error</code>.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees-train">org.opencv.ml.CvRTrees.train</a>
 */
				public virtual  bool train (Mat trainData, int tflag, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvRTrees_train_11 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvRTrees_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvRTrees::CvRTrees()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvRTrees_CvRTrees_10();
		
		// C++:  void CvRTrees::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvRTrees_clear_10(IntPtr nativeObj);
		
		// C++:  Mat CvRTrees::getVarImportance()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvRTrees_getVarImportance_10(IntPtr nativeObj);
		
		// C++:  float CvRTrees::predict(Mat sample, Mat missing = cv::Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvRTrees_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvRTrees_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);
		
		// C++:  float CvRTrees::predict_prob(Mat sample, Mat missing = cv::Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvRTrees_predict_1prob_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvRTrees_predict_1prob_11(IntPtr nativeObj, IntPtr sample_nativeObj);
		
		// C++:  bool CvRTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvRTrees_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvRTrees_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvRTrees_delete(IntPtr nativeObj);

#else
				// C++:   CvRTrees::CvRTrees()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvRTrees_CvRTrees_10 ();
		
				// C++:  void CvRTrees::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvRTrees_clear_10 (IntPtr nativeObj);
		
				// C++:  Mat CvRTrees::getVarImportance()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvRTrees_getVarImportance_10 (IntPtr nativeObj);
		
				// C++:  float CvRTrees::predict(Mat sample, Mat missing = cv::Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvRTrees_predict_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvRTrees_predict_11 (IntPtr nativeObj, IntPtr sample_nativeObj);
		
				// C++:  float CvRTrees::predict_prob(Mat sample, Mat missing = cv::Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvRTrees_predict_1prob_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvRTrees_predict_1prob_11 (IntPtr nativeObj, IntPtr sample_nativeObj);
		
				// C++:  bool CvRTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvRTrees_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvRTrees_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvRTrees_delete (IntPtr nativeObj);
		#endif
		}
}
