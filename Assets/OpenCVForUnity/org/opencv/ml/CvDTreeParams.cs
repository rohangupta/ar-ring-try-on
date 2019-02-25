
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class CvDTreeParams
/**
 * <p>The structure contains all the decision tree training parameters. You can
 * initialize it by default constructor and then override any parameters
 * directly before training, or the structure may be fully initialized using the
 * advanced variant of the constructor.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtreeparams">org.opencv.ml.CvDTreeParams</a>
 */
		public class CvDTreeParams : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvDTreeParams_delete (nativeObj);
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
				internal CvDTreeParams (IntPtr addr)
				{
						nativeObj = addr;
				}//TODO:@check
	
	
				//
				// C++:   CvDTreeParams::CvDTreeParams()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The default constructor initializes all the parameters with the default
 * values tuned for the standalone classification tree:</p>
 *
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>CvDTreeParams() : max_categories(10), max_depth(INT_MAX), min_sample_count(10),</p>
 *
 * <p>cv_folds(10), use_surrogates(true), use_1se_rule(true),</p>
 *
 * <p>truncate_pruned_tree(true), regression_accuracy(0.01f), priors(0)</p>
 *
 * <p>{}</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtreeparams-cvdtreeparams">org.opencv.ml.CvDTreeParams.CvDTreeParams</a>
 */
				public   CvDTreeParams ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = ml_CvDTreeParams_CvDTreeParams_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvDTreeParams::max_categories
				//
	
				public  int get_max_categories ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvDTreeParams_get_1max_1categories_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::max_categories
				//
	
				public  void set_max_categories (int max_categories)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1max_1categories_10 (nativeObj, max_categories);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvDTreeParams::max_depth
				//
	
				public  int get_max_depth ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvDTreeParams_get_1max_1depth_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::max_depth
				//
	
				public  void set_max_depth (int max_depth)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1max_1depth_10 (nativeObj, max_depth);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvDTreeParams::min_sample_count
				//
	
				public  int get_min_sample_count ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvDTreeParams_get_1min_1sample_1count_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::min_sample_count
				//
	
				public  void set_min_sample_count (int min_sample_count)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1min_1sample_1count_10 (nativeObj, min_sample_count);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvDTreeParams::cv_folds
				//
	
				public  int get_cv_folds ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvDTreeParams_get_1cv_1folds_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::cv_folds
				//
	
				public  void set_cv_folds (int cv_folds)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1cv_1folds_10 (nativeObj, cv_folds);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: bool CvDTreeParams::use_surrogates
				//
	
				public  bool get_use_surrogates ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvDTreeParams_get_1use_1surrogates_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::use_surrogates
				//
	
				public  void set_use_surrogates (bool use_surrogates)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1use_1surrogates_10 (nativeObj, use_surrogates);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: bool CvDTreeParams::use_1se_rule
				//
	
				public  bool get_use_1se_rule ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvDTreeParams_get_1use_11se_1rule_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::use_1se_rule
				//
	
				public  void set_use_1se_rule (bool use_1se_rule)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1use_11se_1rule_10 (nativeObj, use_1se_rule);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: bool CvDTreeParams::truncate_pruned_tree
				//
	
				public  bool get_truncate_pruned_tree ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvDTreeParams_get_1truncate_1pruned_1tree_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::truncate_pruned_tree
				//
	
				public  void set_truncate_pruned_tree (bool truncate_pruned_tree)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1truncate_1pruned_1tree_10 (nativeObj, truncate_pruned_tree);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: float CvDTreeParams::regression_accuracy
				//
	
				public  float get_regression_accuracy ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvDTreeParams_get_1regression_1accuracy_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvDTreeParams::regression_accuracy
				//
	
				public  void set_regression_accuracy (float regression_accuracy)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvDTreeParams_set_1regression_1accuracy_10 (nativeObj, regression_accuracy);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvDTreeParams_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvDTreeParams::CvDTreeParams()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvDTreeParams_CvDTreeParams_10();
		
		// C++: int CvDTreeParams::max_categories
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvDTreeParams_get_1max_1categories_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::max_categories
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1max_1categories_10(IntPtr nativeObj, int max_categories);
		
		// C++: int CvDTreeParams::max_depth
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvDTreeParams_get_1max_1depth_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::max_depth
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1max_1depth_10(IntPtr nativeObj, int max_depth);
		
		// C++: int CvDTreeParams::min_sample_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvDTreeParams_get_1min_1sample_1count_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::min_sample_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1min_1sample_1count_10(IntPtr nativeObj, int min_sample_count);
		
		// C++: int CvDTreeParams::cv_folds
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvDTreeParams_get_1cv_1folds_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::cv_folds
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1cv_1folds_10(IntPtr nativeObj, int cv_folds);
		
		// C++: bool CvDTreeParams::use_surrogates
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvDTreeParams_get_1use_1surrogates_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::use_surrogates
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1use_1surrogates_10(IntPtr nativeObj, bool use_surrogates);
		
		// C++: bool CvDTreeParams::use_1se_rule
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvDTreeParams_get_1use_11se_1rule_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::use_1se_rule
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1use_11se_1rule_10(IntPtr nativeObj, bool use_1se_rule);
		
		// C++: bool CvDTreeParams::truncate_pruned_tree
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvDTreeParams_get_1truncate_1pruned_1tree_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::truncate_pruned_tree
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1truncate_1pruned_1tree_10(IntPtr nativeObj, bool truncate_pruned_tree);
		
		// C++: float CvDTreeParams::regression_accuracy
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvDTreeParams_get_1regression_1accuracy_10(IntPtr nativeObj);
		
		// C++: void CvDTreeParams::regression_accuracy
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_set_1regression_1accuracy_10(IntPtr nativeObj, float regression_accuracy);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvDTreeParams_delete(IntPtr nativeObj);

#else
		
				// C++:   CvDTreeParams::CvDTreeParams()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvDTreeParams_CvDTreeParams_10 ();
		
				// C++: int CvDTreeParams::max_categories
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvDTreeParams_get_1max_1categories_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::max_categories
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1max_1categories_10 (IntPtr nativeObj, int max_categories);
		
				// C++: int CvDTreeParams::max_depth
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvDTreeParams_get_1max_1depth_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::max_depth
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1max_1depth_10 (IntPtr nativeObj, int max_depth);
		
				// C++: int CvDTreeParams::min_sample_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvDTreeParams_get_1min_1sample_1count_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::min_sample_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1min_1sample_1count_10 (IntPtr nativeObj, int min_sample_count);
		
				// C++: int CvDTreeParams::cv_folds
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvDTreeParams_get_1cv_1folds_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::cv_folds
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1cv_1folds_10 (IntPtr nativeObj, int cv_folds);
		
				// C++: bool CvDTreeParams::use_surrogates
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvDTreeParams_get_1use_1surrogates_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::use_surrogates
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1use_1surrogates_10 (IntPtr nativeObj, bool use_surrogates);
		
				// C++: bool CvDTreeParams::use_1se_rule
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvDTreeParams_get_1use_11se_1rule_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::use_1se_rule
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1use_11se_1rule_10 (IntPtr nativeObj, bool use_1se_rule);
		
				// C++: bool CvDTreeParams::truncate_pruned_tree
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvDTreeParams_get_1truncate_1pruned_1tree_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::truncate_pruned_tree
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1truncate_1pruned_1tree_10 (IntPtr nativeObj, bool truncate_pruned_tree);
		
				// C++: float CvDTreeParams::regression_accuracy
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvDTreeParams_get_1regression_1accuracy_10 (IntPtr nativeObj);
		
				// C++: void CvDTreeParams::regression_accuracy
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_set_1regression_1accuracy_10 (IntPtr nativeObj, float regression_accuracy);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvDTreeParams_delete (IntPtr nativeObj);
		#endif
		}

}