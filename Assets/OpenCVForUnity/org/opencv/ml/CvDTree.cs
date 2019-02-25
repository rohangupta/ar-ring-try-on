
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{


// C++: class CvDTree
/**
 * <p>The class implements a decision tree as described in the beginning of this
 * section.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtree">org.opencv.ml.CvDTree : public CvStatModel</a>
 */
		public class CvDTree : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvDTree_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvDTree (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvDTree::CvDTree()
				//
	
				public CvDTree () :
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvDTree_CvDTree_10() )
			#else
			base(IntPtr.Zero)
			#endif
				{
						return;

				}
	
	
				//
				// C++:  void CvDTree::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTree_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  Mat CvDTree::getVarImportance()
				//
	
				/**
 * <p>Returns the variable importance array.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtree-getvarimportance">org.opencv.ml.CvDTree.getVarImportance</a>
 */
				public  Mat getVarImportance ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (ml_CvDTree_getVarImportance_10 (nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  CvDTreeNode* CvDTree::predict(Mat sample, Mat missingDataMask = cv::Mat(), bool preprocessedInput = false)
				//
	
				// Return type 'CvDTreeNode*' is not supported, skipping the function
	
	
				//
				// C++:  bool CvDTree::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvDTreeParams params = CvDTreeParams())
				//
	
				/**
 * <p>Trains a decision tree.</p>
 *
 * <p>There are four <code>train</code> methods in "CvDTree":</p>
 * <ul>
 *   <li> The first two methods follow the generic "CvStatModel.train"
 * conventions. It is the most complete form. Both data layouts
 * (<code>tflag=CV_ROW_SAMPLE</code> and <code>tflag=CV_COL_SAMPLE</code>) are
 * supported, as well as sample and variable subsets, missing measurements,
 * arbitrary combinations of input and output variable types, and so on. The
 * last parameter contains all of the necessary training parameters (see the
 * "CvDTreeParams" description).
 *   <li> The third method uses "CvMLData" to pass training data to a decision
 * tree.
 *   <li> The last method <code>train</code> is mostly used for building tree
 * ensembles. It takes the pre-constructed "CvDTreeTrainData" instance and an
 * optional subset of the training set. The indices in <code>subsampleIdx</code>
 * are counted relatively to the <code>_sample_idx</code>, passed to the
 * <code>CvDTreeTrainData</code> constructor. For example, if <code>_sample_idx=[1,
 * 5, 7, 100]</code>, then <code>subsampleIdx=[0,3]</code> means that the
 * samples <code>[1, 100]</code> of the original training set are used.
 * </ul>
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
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtree-train">org.opencv.ml.CvDTree.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvDTreeParams _params)
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
						bool retVal = ml_CvDTree_train_10 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains a decision tree.</p>
 *
 * <p>There are four <code>train</code> methods in "CvDTree":</p>
 * <ul>
 *   <li> The first two methods follow the generic "CvStatModel.train"
 * conventions. It is the most complete form. Both data layouts
 * (<code>tflag=CV_ROW_SAMPLE</code> and <code>tflag=CV_COL_SAMPLE</code>) are
 * supported, as well as sample and variable subsets, missing measurements,
 * arbitrary combinations of input and output variable types, and so on. The
 * last parameter contains all of the necessary training parameters (see the
 * "CvDTreeParams" description).
 *   <li> The third method uses "CvMLData" to pass training data to a decision
 * tree.
 *   <li> The last method <code>train</code> is mostly used for building tree
 * ensembles. It takes the pre-constructed "CvDTreeTrainData" instance and an
 * optional subset of the training set. The indices in <code>subsampleIdx</code>
 * are counted relatively to the <code>_sample_idx</code>, passed to the
 * <code>CvDTreeTrainData</code> constructor. For example, if <code>_sample_idx=[1,
 * 5, 7, 100]</code>, then <code>subsampleIdx=[0,3]</code> means that the
 * samples <code>[1, 100]</code> of the original training set are used.
 * </ul>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param trainData a trainData
 * @param tflag a tflag
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtree-train">org.opencv.ml.CvDTree.train</a>
 */
				public  bool train (Mat trainData, int tflag, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvDTree_train_11 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//		ml_CvDTree_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvDTree::CvDTree()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvDTree_CvDTree_10();
		
		// C++:  void CvDTree::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTree_clear_10(IntPtr nativeObj);
		
		// C++:  Mat CvDTree::getVarImportance()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvDTree_getVarImportance_10(IntPtr nativeObj);
		
		// C++:  bool CvDTree::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvDTreeParams params = CvDTreeParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvDTree_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvDTree_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTree_delete(IntPtr nativeObj);

#else
				// C++:   CvDTree::CvDTree()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvDTree_CvDTree_10 ();
		
				// C++:  void CvDTree::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTree_clear_10 (IntPtr nativeObj);
		
				// C++:  Mat CvDTree::getVarImportance()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvDTree_getVarImportance_10 (IntPtr nativeObj);
		
				// C++:  bool CvDTree::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvDTreeParams params = CvDTreeParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvDTree_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvDTree_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTree_delete (IntPtr nativeObj);
		#endif
		}
}
