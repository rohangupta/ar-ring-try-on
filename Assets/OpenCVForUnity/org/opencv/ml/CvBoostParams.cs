
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class CvBoostParams
/**
 * <p>Boosting training parameters.</p>
 *
 * <p>There is one structure member that you can set directly:</p>
 *
 * <p>Splitting criteria used to choose optimal splits during a weak tree
 * construction. Possible values are:</p>
 *
 * <ul>
 *   <li> CvBoost.DEFAULT Use the default for the particular boosting method,
 * see below.
 * </ul>
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 * <ul>
 *   <li> CvBoost.GINI Use Gini index. This is default option for Real
 * AdaBoost; may be also used for Discrete AdaBoost.
 *   <li> CvBoost.MISCLASS Use misclassification rate. This is default option
 * for Discrete AdaBoost; may be also used for Real AdaBoost.
 *   <li> CvBoost.SQERR Use least squares criteria. This is default and the
 * only option for LogitBoost and Gentle AdaBoost.
 * </ul>
 *
 * <p>The structure is derived from "CvDTreeParams" but not all of the decision
 * tree parameters are supported. In particular, cross-validation is not
 * supported.
 * </code></p>
 *
 * <p>All parameters are public. You can initialize them by a constructor and then
 * override some of them directly if you want.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboostparams">org.opencv.ml.CvBoostParams : public CvDTreeParams</a>
 */
		public class CvBoostParams : CvDTreeParams
		{

	
				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvBoostParams_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvBoostParams (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvBoostParams::CvBoostParams()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>See "CvDTreeParams.CvDTreeParams" for description of other parameters.</p>
 *
 * <p>Default parameters are:</p>
 *
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>CvBoostParams.CvBoostParams()</p>
 *
 *
 * <p>boost_type = CvBoost.REAL;</p>
 *
 * <p>weak_count = 100;</p>
 *
 * <p>weight_trim_rate = 0.95;</p>
 *
 * <p>cv_folds = 0;</p>
 *
 * <p>max_depth = 1;</p>
 *
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboostparams-cvboostparams">org.opencv.ml.CvBoostParams.CvBoostParams</a>
 */
				public   CvBoostParams ()
	: 
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvBoostParams_CvBoostParams_10() )
			#else
			base(IntPtr.Zero)
			#endif
				{
		
						return;

				}
	
	
				//
				// C++: int CvBoostParams::boost_type
				//
	
				public  int get_boost_type ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvBoostParams_get_1boost_1type_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvBoostParams::boost_type
				//
	
				public  void set_boost_type (int boost_type)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoostParams_set_1boost_1type_10 (nativeObj, boost_type);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvBoostParams::weak_count
				//
	
				public  int get_weak_count ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvBoostParams_get_1weak_1count_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvBoostParams::weak_count
				//
	
				public  void set_weak_count (int weak_count)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoostParams_set_1weak_1count_10 (nativeObj, weak_count);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvBoostParams::split_criteria
				//
	
				public  int get_split_criteria ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvBoostParams_get_1split_1criteria_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvBoostParams::split_criteria
				//
	
				public  void set_split_criteria (int split_criteria)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoostParams_set_1split_1criteria_10 (nativeObj, split_criteria);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvBoostParams::weight_trim_rate
				//
	
				public  double get_weight_trim_rate ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvBoostParams_get_1weight_1trim_1rate_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvBoostParams::weight_trim_rate
				//
	
				public  void set_weight_trim_rate (double weight_trim_rate)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvBoostParams_set_1weight_1trim_1rate_10 (nativeObj, weight_trim_rate);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvBoostParams_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvBoostParams::CvBoostParams()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvBoostParams_CvBoostParams_10();
		
		// C++: int CvBoostParams::boost_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvBoostParams_get_1boost_1type_10(IntPtr nativeObj);
		
		// C++: void CvBoostParams::boost_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoostParams_set_1boost_1type_10(IntPtr nativeObj, int boost_type);
		
		// C++: int CvBoostParams::weak_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvBoostParams_get_1weak_1count_10(IntPtr nativeObj);
		
		// C++: void CvBoostParams::weak_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoostParams_set_1weak_1count_10(IntPtr nativeObj, int weak_count);
		
		// C++: int CvBoostParams::split_criteria
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvBoostParams_get_1split_1criteria_10(IntPtr nativeObj);
		
		// C++: void CvBoostParams::split_criteria
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoostParams_set_1split_1criteria_10(IntPtr nativeObj, int split_criteria);
		
		// C++: double CvBoostParams::weight_trim_rate
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvBoostParams_get_1weight_1trim_1rate_10(IntPtr nativeObj);
		
		// C++: void CvBoostParams::weight_trim_rate
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoostParams_set_1weight_1trim_1rate_10(IntPtr nativeObj, double weight_trim_rate);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvBoostParams_delete(IntPtr nativeObj);

#else
				// C++:   CvBoostParams::CvBoostParams()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvBoostParams_CvBoostParams_10 ();
		
				// C++: int CvBoostParams::boost_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvBoostParams_get_1boost_1type_10 (IntPtr nativeObj);
		
				// C++: void CvBoostParams::boost_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoostParams_set_1boost_1type_10 (IntPtr nativeObj, int boost_type);
		
				// C++: int CvBoostParams::weak_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvBoostParams_get_1weak_1count_10 (IntPtr nativeObj);
		
				// C++: void CvBoostParams::weak_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoostParams_set_1weak_1count_10 (IntPtr nativeObj, int weak_count);
		
				// C++: int CvBoostParams::split_criteria
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvBoostParams_get_1split_1criteria_10 (IntPtr nativeObj);
		
				// C++: void CvBoostParams::split_criteria
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoostParams_set_1split_1criteria_10 (IntPtr nativeObj, int split_criteria);
		
				// C++: double CvBoostParams::weight_trim_rate
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvBoostParams_get_1weight_1trim_1rate_10 (IntPtr nativeObj);
		
				// C++: void CvBoostParams::weight_trim_rate
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoostParams_set_1weight_1trim_1rate_10 (IntPtr nativeObj, double weight_trim_rate);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvBoostParams_delete (IntPtr nativeObj);
		#endif
		}
}

