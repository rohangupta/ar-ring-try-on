using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

// C++: class TargetArchs
		public class TargetArchs : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												gpu_TargetArchs_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
						return;
						#endif
				}
	
//	protected readonly IntPtr nativeObj;
				protected TargetArchs (IntPtr addr)
				{
						nativeObj = addr;
				}
	
	
				//
				// C++: static bool TargetArchs::builtWith(int feature_set)
				//
	
				public static bool builtWith (int feature_set)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_builtWith_10 (feature_set);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::has(int major, int minor)
				//
	
				public static bool has (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_has_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasBin(int major, int minor)
				//
	
				public static bool hasBin (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasBin_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasEqualOrGreater(int major, int minor)
				//
	
				public static bool hasEqualOrGreater (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasEqualOrGreater_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasEqualOrGreaterBin(int major, int minor)
				//
	
				public static bool hasEqualOrGreaterBin (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasEqualOrGreaterBin_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasEqualOrGreaterPtx(int major, int minor)
				//
	
				public static bool hasEqualOrGreaterPtx (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasEqualOrGreaterPtx_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasEqualOrLessPtx(int major, int minor)
				//
	
				public static bool hasEqualOrLessPtx (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasEqualOrLessPtx_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: static bool TargetArchs::hasPtx(int major, int minor)
				//
	
				public static bool hasPtx (int major, int minor)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_TargetArchs_hasPtx_10 (major, minor);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			gpu_TargetArchs_delete(nativeObj);
//	}


	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++: static bool TargetArchs::builtWith(int feature_set)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_builtWith_10(int feature_set);
		
		// C++: static bool TargetArchs::has(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_has_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasBin(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasBin_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasEqualOrGreater(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasEqualOrGreater_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasEqualOrGreaterBin(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasEqualOrGreaterBin_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasEqualOrGreaterPtx(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasEqualOrGreaterPtx_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasEqualOrLessPtx(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasEqualOrLessPtx_10(int major, int minor);
		
		// C++: static bool TargetArchs::hasPtx(int major, int minor)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_TargetArchs_hasPtx_10(int major, int minor);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void gpu_TargetArchs_delete(IntPtr nativeObj);

#else
		
				// C++: static bool TargetArchs::builtWith(int feature_set)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_builtWith_10 (int feature_set);
		
				// C++: static bool TargetArchs::has(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_has_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasBin(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasBin_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasEqualOrGreater(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasEqualOrGreater_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasEqualOrGreaterBin(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasEqualOrGreaterBin_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasEqualOrGreaterPtx(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasEqualOrGreaterPtx_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasEqualOrLessPtx(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasEqualOrLessPtx_10 (int major, int minor);
		
				// C++: static bool TargetArchs::hasPtx(int major, int minor)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_TargetArchs_hasPtx_10 (int major, int minor);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void gpu_TargetArchs_delete (IntPtr nativeObj);
		#endif
		}
}

