
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvNormalBayesClassifier
/**
 * <p>Bayes classifier for normally distributed data.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier">org.opencv.ml.CvNormalBayesClassifier : public CvStatModel</a>
 */
		public class CvNormalBayesClassifier : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvNormalBayesClassifier_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvNormalBayesClassifier (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier()
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-cvnormalbayesclassifier">org.opencv.ml.CvNormalBayesClassifier.CvNormalBayesClassifier</a>
 */
				public   CvNormalBayesClassifier ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvNormalBayesClassifier_CvNormalBayesClassifier_10() )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
	
				//
				// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat())
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
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-cvnormalbayesclassifier">org.opencv.ml.CvNormalBayesClassifier.CvNormalBayesClassifier</a>
 */
				public   CvNormalBayesClassifier (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvNormalBayesClassifier_CvNormalBayesClassifier_11(trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj) )
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
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-cvnormalbayesclassifier">org.opencv.ml.CvNormalBayesClassifier.CvNormalBayesClassifier</a>
 */
				public   CvNormalBayesClassifier (Mat trainData, Mat responses)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvNormalBayesClassifier_CvNormalBayesClassifier_12(trainData.nativeObj, responses.nativeObj) )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
	
				//
				// C++:  void CvNormalBayesClassifier::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvNormalBayesClassifier_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  float CvNormalBayesClassifier::predict(Mat samples, Mat* results = 0)
				//
	
				/**
 * <p>Predicts the response for sample(s).</p>
 *
 * <p>The method estimates the most probable classes for input vectors. Input
 * vectors (one or more) are stored as rows of the matrix <code>samples</code>.
 * In case of multiple input vectors, there should be one output vector
 * <code>results</code>. The predicted class for a single input vector is
 * returned by the method.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param samples a samples
 * @param results a results
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-predict">org.opencv.ml.CvNormalBayesClassifier.predict</a>
 */
				public  float predict (Mat samples, Mat results)
				{
						if (samples != null)
								samples.ThrowIfDisposed ();
						if (results != null)
								results.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvNormalBayesClassifier_predict_10 (nativeObj, samples.nativeObj, results.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Predicts the response for sample(s).</p>
 *
 * <p>The method estimates the most probable classes for input vectors. Input
 * vectors (one or more) are stored as rows of the matrix <code>samples</code>.
 * In case of multiple input vectors, there should be one output vector
 * <code>results</code>. The predicted class for a single input vector is
 * returned by the method.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param samples a samples
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-predict">org.opencv.ml.CvNormalBayesClassifier.predict</a>
 */
				public  float predict (Mat samples)
				{
						if (samples != null)
								samples.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvNormalBayesClassifier_predict_11 (nativeObj, samples.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  bool CvNormalBayesClassifier::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), bool update = false)
				//
	
				/**
 * <p>Trains the model.</p>
 *
 * <p>The method trains the Normal Bayes classifier. It follows the conventions of
 * the generic "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variable is categorical, which means that elements of
 * <code>responses</code> must be integer numbers, though the vector may have
 * the <code>CV_32FC1</code> type.
 *   <li> Missing measurements are not supported.
 * </ul>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param update Identifies whether the model should be trained from scratch
 * (<code>update=false</code>) or should be updated using the new training data
 * (<code>update=true</code>).
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-train">org.opencv.ml.CvNormalBayesClassifier.train</a>
 */
				public  bool train (Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, bool update)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvNormalBayesClassifier_train_10 (nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, update);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains the model.</p>
 *
 * <p>The method trains the Normal Bayes classifier. It follows the conventions of
 * the generic "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variable is categorical, which means that elements of
 * <code>responses</code> must be integer numbers, though the vector may have
 * the <code>CV_32FC1</code> type.
 *   <li> Missing measurements are not supported.
 * </ul>
 *
 * @param trainData a trainData
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier-train">org.opencv.ml.CvNormalBayesClassifier.train</a>
 */
				public  bool train (Mat trainData, Mat responses)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvNormalBayesClassifier_train_11 (nativeObj, trainData.nativeObj, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvNormalBayesClassifier_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_10();
		
		// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_11(IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_12(IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// C++:  void CvNormalBayesClassifier::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvNormalBayesClassifier_clear_10(IntPtr nativeObj);
		
		// C++:  float CvNormalBayesClassifier::predict(Mat samples, Mat* results = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvNormalBayesClassifier_predict_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvNormalBayesClassifier_predict_11(IntPtr nativeObj, IntPtr samples_nativeObj);
		
		// C++:  bool CvNormalBayesClassifier::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), bool update = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvNormalBayesClassifier_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, bool update);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvNormalBayesClassifier_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvNormalBayesClassifier_delete(IntPtr nativeObj);

#else
				// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_10 ();
		
				// C++:   CvNormalBayesClassifier::CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_11 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvNormalBayesClassifier_CvNormalBayesClassifier_12 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// C++:  void CvNormalBayesClassifier::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvNormalBayesClassifier_clear_10 (IntPtr nativeObj);
		
				// C++:  float CvNormalBayesClassifier::predict(Mat samples, Mat* results = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvNormalBayesClassifier_predict_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvNormalBayesClassifier_predict_11 (IntPtr nativeObj, IntPtr samples_nativeObj);
		
				// C++:  bool CvNormalBayesClassifier::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), bool update = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvNormalBayesClassifier_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, bool update);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvNormalBayesClassifier_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvNormalBayesClassifier_delete (IntPtr nativeObj);
		#endif
		}
}