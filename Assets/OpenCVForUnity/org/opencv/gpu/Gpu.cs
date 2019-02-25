using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
		public class Gpu
		{
	
				public const int FEATURE_SET_COMPUTE_10 = 10;
				public const int FEATURE_SET_COMPUTE_11 = 11;
				public const int FEATURE_SET_COMPUTE_12 = 12;
				public const int FEATURE_SET_COMPUTE_13 = 13;
				public const int FEATURE_SET_COMPUTE_20 = 20;
				public const int FEATURE_SET_COMPUTE_21 = 21;
				public const int FEATURE_SET_COMPUTE_30 = 30;
				public const int FEATURE_SET_COMPUTE_35 = 35;
				public const int GLOBAL_ATOMICS = FEATURE_SET_COMPUTE_11;
				public const int SHARED_ATOMICS = FEATURE_SET_COMPUTE_12;
				public const int NATIVE_DOUBLE = FEATURE_SET_COMPUTE_13;
				public const int WARP_SHUFFLE_FUNCTIONS = FEATURE_SET_COMPUTE_30;
				public const int DYNAMIC_PARALLELISM = FEATURE_SET_COMPUTE_35;
	
	
				//
				// C++:  bool deviceSupports(int feature_set)
				//
	
				public static bool deviceSupports (int feature_set)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = gpu_Gpu_deviceSupports_10 (feature_set);
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  int getCudaEnabledDeviceCount()
				//
	
				public static int getCudaEnabledDeviceCount ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = gpu_Gpu_getCudaEnabledDeviceCount_10 ();
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int getDevice()
				//
	
				public static int getDevice ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = gpu_Gpu_getDevice_10 ();
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  void printCudaDeviceInfo(int device)
				//
	
				public static void printCudaDeviceInfo (int device)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						gpu_Gpu_printCudaDeviceInfo_10 (device);
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void printShortCudaDeviceInfo(int device)
				//
	
				public static void printShortCudaDeviceInfo (int device)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						gpu_Gpu_printShortCudaDeviceInfo_10 (device);
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void resetDevice()
				//
	
				public static void resetDevice ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						gpu_Gpu_resetDevice_10 ();
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void setDevice(int device)
				//
	
				public static void setDevice (int device)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						gpu_Gpu_setDevice_10 (device);
						return;
						#else
						return;
						#endif
				}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  bool deviceSupports(int feature_set)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gpu_Gpu_deviceSupports_10(int feature_set);
		
		// C++:  int getCudaEnabledDeviceCount()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int gpu_Gpu_getCudaEnabledDeviceCount_10();
		
		// C++:  int getDevice()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int gpu_Gpu_getDevice_10();
		
		// C++:  void printCudaDeviceInfo(int device)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void gpu_Gpu_printCudaDeviceInfo_10(int device);
		
		// C++:  void printShortCudaDeviceInfo(int device)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void gpu_Gpu_printShortCudaDeviceInfo_10(int device);
		
		// C++:  void resetDevice()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void gpu_Gpu_resetDevice_10();
		
		// C++:  void setDevice(int device)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void gpu_Gpu_setDevice_10(int device);

#else
		
				// C++:  bool deviceSupports(int feature_set)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool gpu_Gpu_deviceSupports_10 (int feature_set);
		
				// C++:  int getCudaEnabledDeviceCount()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int gpu_Gpu_getCudaEnabledDeviceCount_10 ();
		
				// C++:  int getDevice()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int gpu_Gpu_getDevice_10 ();
		
				// C++:  void printCudaDeviceInfo(int device)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void gpu_Gpu_printCudaDeviceInfo_10 (int device);
		
				// C++:  void printShortCudaDeviceInfo(int device)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void gpu_Gpu_printShortCudaDeviceInfo_10 (int device);
		
				// C++:  void resetDevice()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void gpu_Gpu_resetDevice_10 ();
		
				// C++:  void setDevice(int device)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void gpu_Gpu_setDevice_10 (int device);
		#endif
		}
}
