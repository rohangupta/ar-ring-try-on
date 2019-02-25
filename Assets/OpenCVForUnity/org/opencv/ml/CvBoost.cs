
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

// C++: class CvBoost
/**
 * <p>Boosted tree classifier derived from "CvStatModel".</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost">org.opencv.ml.CvBoost : public CvStatModel</a>
 */
		public class CvBoost : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvBoost_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvBoost (IntPtr addr) : base(addr)
				{
				}
	
				public const int DISCRETE = 0;
				public const int REAL = 1;
				public const int LOGIT = 2;
				public const int GENTLE = 3;
				public const int DEFAULT = 0;
				public const int GINI = 1;
				public const int MISCLASS = 3;
				public const int SQERR = 4;
	
	
				//
				// C++:   CvBoost::CvBoost()
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>The constructors follow conventions of "CvStatModel.CvStatModel". See
 * "CvStatModel.train" for parameters descriptions.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-cvboost">org.opencv.ml.CvBoost.CvBoost</a>
 */
				public   CvBoost () :
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			base( ml_CvBoost_CvBoost_10() )
			#else
			base(IntPtr.Zero)
		#endif
				{
		
		
		
						return;
				}
	
	
				//
				// C++:   CvBoost::CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams())
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
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-cvboost">org.opencv.ml.CvBoost.CvBoost</a>
 */
				public   CvBoost (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvBoostParams _params)
		: 
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvBoost_CvBoost_11(trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj) )
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
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-cvboost">org.opencv.ml.CvBoost.CvBoost</a>
 */
				public   CvBoost (Mat trainData, int tflag, Mat responses)
	: 
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvBoost_CvBoost_12(trainData.nativeObj, tflag, responses.nativeObj) )
			#else
			base(IntPtr.Zero)
			#endif
				{
						return;
				}
	
	
				//
				// C++:  void CvBoost::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoost_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  float CvBoost::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), bool rawMode = false, bool returnSum = false)
				//
	
				/**
 * <p>Predicts a response for an input sample.</p>
 *
 * <p>The method runs the sample through the trees in the ensemble and returns the
 * output class label based on the weighted voting.</p>
 *
 * @param sample Input sample.
 * @param missing Optional mask of missing measurements. To handle missing
 * measurements, the weak classifiers must include surrogate splits (see
 * <code>CvDTreeParams.use_surrogates</code>).
 * @param slice Continuous subset of the sequence of weak classifiers to be used
 * for prediction. By default, all the weak classifiers are used.
 * @param rawMode Normally, it should be set to <code>false</code>.
 * @param returnSum If <code>true</code> then return sum of votes instead of the
 * class label.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-predict">org.opencv.ml.CvBoost.predict</a>
 */
				public  float predict (Mat sample, Mat missing, Range slice, bool rawMode, bool returnSum)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						if (missing != null)
								missing.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvBoost_predict_10 (nativeObj, sample.nativeObj, missing.nativeObj, slice.start, slice.end, rawMode, returnSum);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
				/**
 * <p>Predicts a response for an input sample.</p>
 *
 * <p>The method runs the sample through the trees in the ensemble and returns the
 * output class label based on the weighted voting.</p>
 *
 * @param sample Input sample.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-predict">org.opencv.ml.CvBoost.predict</a>
 */
				public  float predict (Mat sample)
				{
						if (sample != null)
								sample.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvBoost_predict_11 (nativeObj, sample.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  void CvBoost::prune(CvSlice slice)
				//
	
				/**
 * <p>Removes the specified weak classifiers.</p>
 *
 * <p>The method removes the specified weak classifiers from the sequence.</p>
 *
 * <p>Note: Do not confuse this method with the pruning of individual decision
 * trees, which is currently not supported.</p>
 *
 * @param slice Continuous subset of the sequence of weak classifiers to be
 * removed.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-prune">org.opencv.ml.CvBoost.prune</a>
 */
				public  void prune (Range slice)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoost_prune_10 (nativeObj, slice.start, slice.end);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  bool CvBoost::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams(), bool update = false)
				//
	
				/**
 * <p>Trains a boosted tree classifier.</p>
 *
 * <p>The train method follows the common template of "CvStatModel.train". The
 * responses must be categorical, which means that boosted trees cannot be built
 * for regression, and there should be two classes.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 * @param varIdx a varIdx
 * @param sampleIdx a sampleIdx
 * @param varType a varType
 * @param missingDataMask a missingDataMask
 * @param params a params
 * @param update Specifies whether the classifier needs to be updated
 * (<code>true</code>, the new weak tree classifiers added to the existing
 * ensemble) or the classifier needs to be rebuilt from scratch
 * (<code>false</code>).
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-train">org.opencv.ml.CvBoost.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvBoostParams _params, bool update)
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
						bool retVal = ml_CvBoost_train_10 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj, update);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains a boosted tree classifier.</p>
 *
 * <p>The train method follows the common template of "CvStatModel.train". The
 * responses must be categorical, which means that boosted trees cannot be built
 * for regression, and there should be two classes.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost-train">org.opencv.ml.CvBoost.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvBoost_train_11 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvBoost_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvBoost::CvBoost()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvBoost_CvBoost_10();
		
		// C++:   CvBoost::CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvBoost_CvBoost_11(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvBoost_CvBoost_12(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// C++:  void CvBoost::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoost_clear_10(IntPtr nativeObj);
		
		// C++:  float CvBoost::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), bool rawMode = false, bool returnSum = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvBoost_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj, int slice_start, int slice_end, bool rawMode, bool returnSum);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvBoost_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);
		
		// C++:  void CvBoost::prune(CvSlice slice)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoost_prune_10(IntPtr nativeObj, int slice_start, int slice_end);
		
		// C++:  bool CvBoost::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams(), bool update = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvBoost_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj, bool update);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvBoost_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoost_delete(IntPtr nativeObj);

#else
				// C++:   CvBoost::CvBoost()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvBoost_CvBoost_10 ();
		
				// C++:   CvBoost::CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvBoost_CvBoost_11 (IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvBoost_CvBoost_12 (IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// C++:  void CvBoost::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoost_clear_10 (IntPtr nativeObj);
		
				// C++:  float CvBoost::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), bool rawMode = false, bool returnSum = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvBoost_predict_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj, int slice_start, int slice_end, bool rawMode, bool returnSum);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvBoost_predict_11 (IntPtr nativeObj, IntPtr sample_nativeObj);
		
				// C++:  void CvBoost::prune(CvSlice slice)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoost_prune_10 (IntPtr nativeObj, int slice_start, int slice_end);
		
				// C++:  bool CvBoost::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams(), bool update = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvBoost_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj, bool update);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvBoost_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoost_delete (IntPtr nativeObj);
		#endif
		}
}
