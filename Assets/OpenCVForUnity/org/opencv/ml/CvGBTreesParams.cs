
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class CvGBTreesParams
/**
 * <p>GBT training parameters.</p>
 *
 * <p>The structure contains parameters for each single decision tree in the
 * ensemble, as well as the whole model characteristics. The structure is
 * derived from "CvDTreeParams" but not all of the decision tree parameters are
 * supported: cross-validation, pruning, and class priorities are not used.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtreesparams">org.opencv.ml.CvGBTreesParams : public CvDTreeParams</a>
 */
		public class CvGBTreesParams : CvDTreeParams
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvGBTreesParams_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
				protected CvGBTreesParams (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvGBTreesParams::CvGBTreesParams()
				//
	
				/**
 * <p>By default the following constructor is used: CvGBTreesParams(CvGBTrees.SQUARED_LOSS,
 * 200, 0.8f, 0.01f, 3, false) <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>: CvDTreeParams(3, 10, 0, false, 10, 0, false, false, 0)</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/gradient_boosted_trees.html#cvgbtreesparams-cvgbtreesparams">org.opencv.ml.CvGBTreesParams.CvGBTreesParams</a>
 */
				public   CvGBTreesParams ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvGBTreesParams_CvGBTreesParams_10() )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;

				}
	
	
				//
				// C++: int CvGBTreesParams::weak_count
				//
	
				public  int get_weak_count ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvGBTreesParams_get_1weak_1count_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvGBTreesParams::weak_count
				//
	
				public  void set_weak_count (int weak_count)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvGBTreesParams_set_1weak_1count_10 (nativeObj, weak_count);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: int CvGBTreesParams::loss_function_type
				//
	
				public  int get_loss_function_type ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvGBTreesParams_get_1loss_1function_1type_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvGBTreesParams::loss_function_type
				//
	
				public  void set_loss_function_type (int loss_function_type)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvGBTreesParams_set_1loss_1function_1type_10 (nativeObj, loss_function_type);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: float CvGBTreesParams::subsample_portion
				//
	
				public  float get_subsample_portion ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvGBTreesParams_get_1subsample_1portion_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvGBTreesParams::subsample_portion
				//
	
				public  void set_subsample_portion (float subsample_portion)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvGBTreesParams_set_1subsample_1portion_10 (nativeObj, subsample_portion);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: float CvGBTreesParams::shrinkage
				//
	
				public  float get_shrinkage ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvGBTreesParams_get_1shrinkage_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvGBTreesParams::shrinkage
				//
	
				public  void set_shrinkage (float shrinkage)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvGBTreesParams_set_1shrinkage_10 (nativeObj, shrinkage);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvGBTreesParams_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvGBTreesParams::CvGBTreesParams()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvGBTreesParams_CvGBTreesParams_10();
		
		// C++: int CvGBTreesParams::weak_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvGBTreesParams_get_1weak_1count_10(IntPtr nativeObj);
		
		// C++: void CvGBTreesParams::weak_count
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTreesParams_set_1weak_1count_10(IntPtr nativeObj, int weak_count);
		
		// C++: int CvGBTreesParams::loss_function_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvGBTreesParams_get_1loss_1function_1type_10(IntPtr nativeObj);
		
		// C++: void CvGBTreesParams::loss_function_type
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTreesParams_set_1loss_1function_1type_10(IntPtr nativeObj, int loss_function_type);
		
		// C++: float CvGBTreesParams::subsample_portion
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvGBTreesParams_get_1subsample_1portion_10(IntPtr nativeObj);
		
		// C++: void CvGBTreesParams::subsample_portion
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTreesParams_set_1subsample_1portion_10(IntPtr nativeObj, float subsample_portion);
		
		// C++: float CvGBTreesParams::shrinkage
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvGBTreesParams_get_1shrinkage_10(IntPtr nativeObj);
		
		// C++: void CvGBTreesParams::shrinkage
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTreesParams_set_1shrinkage_10(IntPtr nativeObj, float shrinkage);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvGBTreesParams_delete(IntPtr nativeObj);

#else
				// C++:   CvGBTreesParams::CvGBTreesParams()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvGBTreesParams_CvGBTreesParams_10 ();
		
				// C++: int CvGBTreesParams::weak_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvGBTreesParams_get_1weak_1count_10 (IntPtr nativeObj);
		
				// C++: void CvGBTreesParams::weak_count
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTreesParams_set_1weak_1count_10 (IntPtr nativeObj, int weak_count);
		
				// C++: int CvGBTreesParams::loss_function_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvGBTreesParams_get_1loss_1function_1type_10 (IntPtr nativeObj);
		
				// C++: void CvGBTreesParams::loss_function_type
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTreesParams_set_1loss_1function_1type_10 (IntPtr nativeObj, int loss_function_type);
		
				// C++: float CvGBTreesParams::subsample_portion
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvGBTreesParams_get_1subsample_1portion_10 (IntPtr nativeObj);
		
				// C++: void CvGBTreesParams::subsample_portion
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTreesParams_set_1subsample_1portion_10 (IntPtr nativeObj, float subsample_portion);
		
				// C++: float CvGBTreesParams::shrinkage
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvGBTreesParams_get_1shrinkage_10 (IntPtr nativeObj);
		
				// C++: void CvGBTreesParams::shrinkage
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTreesParams_set_1shrinkage_10 (IntPtr nativeObj, float shrinkage);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvGBTreesParams_delete (IntPtr nativeObj);
		#endif
		}
}