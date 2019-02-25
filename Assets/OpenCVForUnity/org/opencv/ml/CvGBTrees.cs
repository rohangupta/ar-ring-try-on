
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{


// C++: class CvGBTrees
/**
 * <p>The class implements the Gradient boosted tree model as described in the
 * beginning of this section.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees">org.opencv.ml.CvGBTrees : public CvStatModel</a>
 */
		public class CvGBTrees : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvGBTrees_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvGBTrees (IntPtr addr) : base(addr)
				{
				}
	
				public const int SQUARED_LOSS = 0;
				public const int ABSOLUTE_LOSS = 0 + 1;
				public const int HUBER_LOSS = 3;
				public const int DEVIANCE_LOSS = 3 + 1;
	
	
				//
				// C++:   CvGBTrees::CvGBTrees()
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-cvgbtrees">org.opencv.ml.CvGBTrees.CvGBTrees</a>
 */
				public   CvGBTrees ()
	:
	 #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvGBTrees_CvGBTrees_10() )
			#else
			base(IntPtr.Zero)
			#endif
				{
		
						return;
				}
	
	
				//
				// C++:   CvGBTrees::CvGBTrees(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams())
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
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
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-cvgbtrees">org.opencv.ml.CvGBTrees.CvGBTrees</a>
 */
				public   CvGBTrees (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvGBTreesParams _params)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvGBTrees_CvGBTrees_11(trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj) )
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
 * @param tflag a tflag
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-cvgbtrees">org.opencv.ml.CvGBTrees.CvGBTrees</a>
 */
				public   CvGBTrees (Mat trainData, int tflag, Mat responses)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvGBTrees_CvGBTrees_12(trainData.nativeObj, tflag, responses.nativeObj) )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
	
				//
				// C++:  void CvGBTrees::clear()
				//
	
				/**
 * <p>Clears the model.</p>
 *
 * <p>The function deletes the data set information and all the weak models and
 * sets all internal variables to the initial state. The function is called in
 * "CvGBTrees.train" and in the destructor.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-clear">org.opencv.ml.CvGBTrees.clear</a>
 */
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvGBTrees_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  float CvGBTrees::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), int k = -1)
				//
	
				/**
 * <p>Predicts a response for an input sample.</p>
 *
 * <p>The method predicts the response corresponding to the given sample (see
 * "Predicting with GBT").
 * The result is either the class label or the estimated function value. The
 * "CvGBTrees.predict" method enables using the parallel version of the GBT
 * model prediction if the OpenCV is built with the TBB library. In this case,
 * predictions of single trees are computed in a parallel fashion.</p>
 *
 * @param sample Input feature vector that has the same format as every training
 * set element. If not all the variables were actually used during training,
 * <code>sample</code> contains forged values at the appropriate places.
 * @param missing Missing values mask, which is a dimensional matrix of the same
 * size as <code>sample</code> having the <code>CV_8U</code> type.
 * <code>1</code> corresponds to the missing value in the same position in the
 * <code>sample</code> vector. If there are no missing values in the feature
 * vector, an empty matrix can be passed instead of the missing mask.
 * @param slice Parameter defining the part of the ensemble used for prediction.
 * <p>If <code>slice = Range.all()</code>, all trees are used. Use this parameter
 * to get predictions of the GBT models with different ensemble sizes learning
 * only one model.</p>
 * @param k Number of tree ensembles built in case of the classification problem
 * (see "Training GBT"). Use this parameter to change the output to sum of the
 * trees' predictions in the <code>k</code>-th ensemble only. To get the total
 * GBT model prediction, <code>k</code> value must be -1. For regression
 * problems, <code>k</code> is also equal to -1.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-predict">org.opencv.ml.CvGBTrees.predict</a>
 */
				public  float predict (Mat sample, Mat missing, Range slice, int k)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						if (missing != null)
								missing.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvGBTrees_predict_10 (nativeObj, sample.nativeObj, missing.nativeObj, slice.start, slice.end, k);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Predicts a response for an input sample.</p>
 *
 * <p>The method predicts the response corresponding to the given sample (see
 * "Predicting with GBT").
 * The result is either the class label or the estimated function value. The
 * "CvGBTrees.predict" method enables using the parallel version of the GBT
 * model prediction if the OpenCV is built with the TBB library. In this case,
 * predictions of single trees are computed in a parallel fashion.</p>
 *
 * @param sample Input feature vector that has the same format as every training
 * set element. If not all the variables were actually used during training,
 * <code>sample</code> contains forged values at the appropriate places.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-predict">org.opencv.ml.CvGBTrees.predict</a>
 */
				public  float predict (Mat sample)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvGBTrees_predict_11 (nativeObj, sample.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  bool CvGBTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams(), bool update = false)
				//
	
				/**
 * <p>Trains a Gradient boosted tree model.</p>
 *
 * <p>The first train method follows the common template (see "CvStatModel.train").
 * Both <code>tflag</code> values (<code>CV_ROW_SAMPLE</code>, <code>CV_COL_SAMPLE</code>)
 * are supported.
 * <code>trainData</code> must be of the <code>CV_32F</code> type.
 * <code>responses</code> must be a matrix of type <code>CV_32S</code> or
 * <code>CV_32F</code>. In both cases it is converted into the <code>CV_32F</code>
 * matrix inside the training procedure. <code>varIdx</code> and
 * <code>sampleIdx</code> must be a list of indices (<code>CV_32S</code>) or a
 * mask (<code>CV_8U</code> or <code>CV_8S</code>). <code>update</code> is a
 * dummy parameter.</p>
 *
 * <p>The second form of "CvGBTrees.train" function uses "CvMLData" as a data set
 * container. <code>update</code> is still a dummy parameter.</p>
 *
 * <p>All parameters specific to the GBT model are passed into the training
 * function as a "CvGBTreesParams" structure.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param varType a varType
 * @param missingDataMask a missingDataMask
 * @param params a params
 * @param update a update
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-train">org.opencv.ml.CvGBTrees.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvGBTreesParams _params, bool update)
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
						bool retVal = ml_CvGBTrees_train_10 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj, update);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains a Gradient boosted tree model.</p>
 *
 * <p>The first train method follows the common template (see "CvStatModel.train").
 * Both <code>tflag</code> values (<code>CV_ROW_SAMPLE</code>, <code>CV_COL_SAMPLE</code>)
 * are supported.
 * <code>trainData</code> must be of the <code>CV_32F</code> type.
 * <code>responses</code> must be a matrix of type <code>CV_32S</code> or
 * <code>CV_32F</code>. In both cases it is converted into the <code>CV_32F</code>
 * matrix inside the training procedure. <code>varIdx</code> and
 * <code>sampleIdx</code> must be a list of indices (<code>CV_32S</code>) or a
 * mask (<code>CV_8U</code> or <code>CV_8S</code>). <code>update</code> is a
 * dummy parameter.</p>
 *
 * <p>The second form of "CvGBTrees.train" function uses "CvMLData" as a data set
 * container. <code>update</code> is still a dummy parameter.</p>
 *
 * <p>All parameters specific to the GBT model are passed into the training
 * function as a "CvGBTreesParams" structure.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtrees-train">org.opencv.ml.CvGBTrees.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvGBTrees_train_11 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvGBTrees_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvGBTrees::CvGBTrees()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvGBTrees_CvGBTrees_10();
		
		// C++:   CvGBTrees::CvGBTrees(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvGBTrees_CvGBTrees_11(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvGBTrees_CvGBTrees_12(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// C++:  void CvGBTrees::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTrees_clear_10(IntPtr nativeObj);
		
		// C++:  float CvGBTrees::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), int k = -1)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvGBTrees_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj, int slice_start, int slice_end, int k);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvGBTrees_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);
		
		// C++:  bool CvGBTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams(), bool update = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvGBTrees_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj, bool update);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvGBTrees_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTrees_delete(IntPtr nativeObj);

#else
				// C++:   CvGBTrees::CvGBTrees()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvGBTrees_CvGBTrees_10 ();
		
				// C++:   CvGBTrees::CvGBTrees(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvGBTrees_CvGBTrees_11 (IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvGBTrees_CvGBTrees_12 (IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// C++:  void CvGBTrees::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTrees_clear_10 (IntPtr nativeObj);
		
				// C++:  float CvGBTrees::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), int k = -1)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvGBTrees_predict_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj, int slice_start, int slice_end, int k);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvGBTrees_predict_11 (IntPtr nativeObj, IntPtr sample_nativeObj);
		
				// C++:  bool CvGBTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvGBTreesParams params = CvGBTreesParams(), bool update = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvGBTrees_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj, bool update);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvGBTrees_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTrees_delete (IntPtr nativeObj);
		#endif
		}
}
