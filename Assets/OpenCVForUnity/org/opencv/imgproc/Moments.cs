
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class Moments
		public class Moments : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												imgproc_Moments_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}

	
//	/*protected*/ internal readonly IntPtr nativeObj;//TODO:@check

				/*protected*/
				internal Moments (IntPtr addr)
				{
						nativeObj = addr;
				}//TODO:@check
	
	
				//
				// C++:   Moments::Moments()
				//
	
				public   Moments ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = imgproc_Moments_Moments_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m00
				//
	
				public  double get_m00 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m00_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m00
				//
	
				public  void set_m00 (double m00)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m00_10 (nativeObj, m00);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m10
				//
	
				public  double get_m10 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m10_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m10
				//
	
				public  void set_m10 (double m10)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m10_10 (nativeObj, m10);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m01
				//
	
				public  double get_m01 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m01_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m01
				//
	
				public  void set_m01 (double m01)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m01_10 (nativeObj, m01);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m20
				//
	
				public  double get_m20 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m20_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m20
				//
	
				public  void set_m20 (double m20)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m20_10 (nativeObj, m20);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m11
				//
	
				public  double get_m11 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m11_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m11
				//
	
				public  void set_m11 (double m11)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m11_10 (nativeObj, m11);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m02
				//
	
				public  double get_m02 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m02_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m02
				//
	
				public  void set_m02 (double m02)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m02_10 (nativeObj, m02);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m30
				//
	
				public  double get_m30 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m30_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m30
				//
	
				public  void set_m30 (double m30)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m30_10 (nativeObj, m30);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m21
				//
	
				public  double get_m21 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m21_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m21
				//
	
				public  void set_m21 (double m21)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m21_10 (nativeObj, m21);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m12
				//
	
				public  double get_m12 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m12_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m12
				//
	
				public  void set_m12 (double m12)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m12_10 (nativeObj, m12);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::m03
				//
	
				public  double get_m03 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1m03_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::m03
				//
	
				public  void set_m03 (double m03)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1m03_10 (nativeObj, m03);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu20
				//
	
				public  double get_mu20 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu20_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu20
				//
	
				public  void set_mu20 (double mu20)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu20_10 (nativeObj, mu20);
		
						return;
						#else
			return;
						#endif


				}
	
	
				//
				// C++: double Moments::mu11
				//
	
				public  double get_mu11 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu11_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu11
				//
	
				public  void set_mu11 (double mu11)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu11_10 (nativeObj, mu11);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu02
				//
	
				public  double get_mu02 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu02_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu02
				//
	
				public  void set_mu02 (double mu02)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu02_10 (nativeObj, mu02);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu30
				//
	
				public  double get_mu30 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu30_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu30
				//
	
				public  void set_mu30 (double mu30)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu30_10 (nativeObj, mu30);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu21
				//
	
				public  double get_mu21 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu21_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu21
				//
	
				public  void set_mu21 (double mu21)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu21_10 (nativeObj, mu21);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu12
				//
	
				public  double get_mu12 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu12_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu12
				//
	
				public  void set_mu12 (double mu12)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu12_10 (nativeObj, mu12);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::mu03
				//
	
				public  double get_mu03 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1mu03_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::mu03
				//
	
				public  void set_mu03 (double mu03)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1mu03_10 (nativeObj, mu03);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu20
				//
	
				public  double get_nu20 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu20_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu20
				//
	
				public  void set_nu20 (double nu20)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu20_10 (nativeObj, nu20);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu11
				//
	
				public  double get_nu11 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu11_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu11
				//
	
				public  void set_nu11 (double nu11)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu11_10 (nativeObj, nu11);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu02
				//
	
				public  double get_nu02 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu02_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu02
				//
	
				public  void set_nu02 (double nu02)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu02_10 (nativeObj, nu02);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu30
				//
	
				public  double get_nu30 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu30_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu30
				//
	
				public  void set_nu30 (double nu30)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu30_10 (nativeObj, nu30);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu21
				//
	
				public  double get_nu21 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu21_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu21
				//
	
				public  void set_nu21 (double nu21)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu21_10 (nativeObj, nu21);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu12
				//
	
				public  double get_nu12 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu12_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu12
				//
	
				public  void set_nu12 (double nu12)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu12_10 (nativeObj, nu12);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double Moments::nu03
				//
	
				public  double get_nu03 ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = imgproc_Moments_get_1nu03_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void Moments::nu03
				//
	
				public  void set_nu03 (double nu03)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Moments_set_1nu03_10 (nativeObj, nu03);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			imgproc_Moments_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   Moments::Moments()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr imgproc_Moments_Moments_10();
		
		// C++: double Moments::m00
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m00_10(IntPtr nativeObj);
		
		// C++: void Moments::m00
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m00_10(IntPtr nativeObj, double m00);
		
		// C++: double Moments::m10
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m10_10(IntPtr nativeObj);
		
		// C++: void Moments::m10
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m10_10(IntPtr nativeObj, double m10);
		
		// C++: double Moments::m01
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m01_10(IntPtr nativeObj);
		
		// C++: void Moments::m01
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m01_10(IntPtr nativeObj, double m01);
		
		// C++: double Moments::m20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m20_10(IntPtr nativeObj);
		
		// C++: void Moments::m20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m20_10(IntPtr nativeObj, double m20);
		
		// C++: double Moments::m11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m11_10(IntPtr nativeObj);
		
		// C++: void Moments::m11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m11_10(IntPtr nativeObj, double m11);
		
		// C++: double Moments::m02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m02_10(IntPtr nativeObj);
		
		// C++: void Moments::m02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m02_10(IntPtr nativeObj, double m02);
		
		// C++: double Moments::m30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m30_10(IntPtr nativeObj);
		
		// C++: void Moments::m30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m30_10(IntPtr nativeObj, double m30);
		
		// C++: double Moments::m21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m21_10(IntPtr nativeObj);
		
		// C++: void Moments::m21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m21_10(IntPtr nativeObj, double m21);
		
		// C++: double Moments::m12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m12_10(IntPtr nativeObj);
		
		// C++: void Moments::m12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m12_10(IntPtr nativeObj, double m12);
		
		// C++: double Moments::m03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1m03_10(IntPtr nativeObj);
		
		// C++: void Moments::m03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1m03_10(IntPtr nativeObj, double m03);
		
		// C++: double Moments::mu20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu20_10(IntPtr nativeObj);
		
		// C++: void Moments::mu20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu20_10(IntPtr nativeObj, double mu20);
		
		// C++: double Moments::mu11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu11_10(IntPtr nativeObj);
		
		// C++: void Moments::mu11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu11_10(IntPtr nativeObj, double mu11);
		
		// C++: double Moments::mu02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu02_10(IntPtr nativeObj);
		
		// C++: void Moments::mu02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu02_10(IntPtr nativeObj, double mu02);
		
		// C++: double Moments::mu30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu30_10(IntPtr nativeObj);
		
		// C++: void Moments::mu30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu30_10(IntPtr nativeObj, double mu30);
		
		// C++: double Moments::mu21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu21_10(IntPtr nativeObj);
		
		// C++: void Moments::mu21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu21_10(IntPtr nativeObj, double mu21);
		
		// C++: double Moments::mu12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu12_10(IntPtr nativeObj);
		
		// C++: void Moments::mu12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu12_10(IntPtr nativeObj, double mu12);
		
		// C++: double Moments::mu03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1mu03_10(IntPtr nativeObj);
		
		// C++: void Moments::mu03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1mu03_10(IntPtr nativeObj, double mu03);
		
		// C++: double Moments::nu20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu20_10(IntPtr nativeObj);
		
		// C++: void Moments::nu20
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu20_10(IntPtr nativeObj, double nu20);
		
		// C++: double Moments::nu11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu11_10(IntPtr nativeObj);
		
		// C++: void Moments::nu11
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu11_10(IntPtr nativeObj, double nu11);
		
		// C++: double Moments::nu02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu02_10(IntPtr nativeObj);
		
		// C++: void Moments::nu02
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu02_10(IntPtr nativeObj, double nu02);
		
		// C++: double Moments::nu30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu30_10(IntPtr nativeObj);
		
		// C++: void Moments::nu30
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu30_10(IntPtr nativeObj, double nu30);
		
		// C++: double Moments::nu21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu21_10(IntPtr nativeObj);
		
		// C++: void Moments::nu21
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu21_10(IntPtr nativeObj, double nu21);
		
		// C++: double Moments::nu12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu12_10(IntPtr nativeObj);
		
		// C++: void Moments::nu12
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu12_10(IntPtr nativeObj, double nu12);
		
		// C++: double Moments::nu03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double imgproc_Moments_get_1nu03_10(IntPtr nativeObj);
		
		// C++: void Moments::nu03
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_set_1nu03_10(IntPtr nativeObj, double nu03);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Moments_delete(IntPtr nativeObj);

#else
		
				// C++:   Moments::Moments()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr imgproc_Moments_Moments_10 ();
		
				// C++: double Moments::m00
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m00_10 (IntPtr nativeObj);
		
				// C++: void Moments::m00
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m00_10 (IntPtr nativeObj, double m00);
		
				// C++: double Moments::m10
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m10_10 (IntPtr nativeObj);
		
				// C++: void Moments::m10
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m10_10 (IntPtr nativeObj, double m10);
		
				// C++: double Moments::m01
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m01_10 (IntPtr nativeObj);
		
				// C++: void Moments::m01
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m01_10 (IntPtr nativeObj, double m01);
		
				// C++: double Moments::m20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m20_10 (IntPtr nativeObj);
		
				// C++: void Moments::m20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m20_10 (IntPtr nativeObj, double m20);
		
				// C++: double Moments::m11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m11_10 (IntPtr nativeObj);
		
				// C++: void Moments::m11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m11_10 (IntPtr nativeObj, double m11);
		
				// C++: double Moments::m02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m02_10 (IntPtr nativeObj);
		
				// C++: void Moments::m02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m02_10 (IntPtr nativeObj, double m02);
		
				// C++: double Moments::m30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m30_10 (IntPtr nativeObj);
		
				// C++: void Moments::m30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m30_10 (IntPtr nativeObj, double m30);
		
				// C++: double Moments::m21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m21_10 (IntPtr nativeObj);
		
				// C++: void Moments::m21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m21_10 (IntPtr nativeObj, double m21);
		
				// C++: double Moments::m12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m12_10 (IntPtr nativeObj);
		
				// C++: void Moments::m12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m12_10 (IntPtr nativeObj, double m12);
		
				// C++: double Moments::m03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1m03_10 (IntPtr nativeObj);
		
				// C++: void Moments::m03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1m03_10 (IntPtr nativeObj, double m03);
		
				// C++: double Moments::mu20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu20_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu20_10 (IntPtr nativeObj, double mu20);
		
				// C++: double Moments::mu11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu11_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu11_10 (IntPtr nativeObj, double mu11);
		
				// C++: double Moments::mu02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu02_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu02_10 (IntPtr nativeObj, double mu02);
		
				// C++: double Moments::mu30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu30_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu30_10 (IntPtr nativeObj, double mu30);
		
				// C++: double Moments::mu21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu21_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu21_10 (IntPtr nativeObj, double mu21);
		
				// C++: double Moments::mu12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu12_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu12_10 (IntPtr nativeObj, double mu12);
		
				// C++: double Moments::mu03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1mu03_10 (IntPtr nativeObj);
		
				// C++: void Moments::mu03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1mu03_10 (IntPtr nativeObj, double mu03);
		
				// C++: double Moments::nu20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu20_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu20
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu20_10 (IntPtr nativeObj, double nu20);
		
				// C++: double Moments::nu11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu11_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu11
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu11_10 (IntPtr nativeObj, double nu11);
		
				// C++: double Moments::nu02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu02_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu02
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu02_10 (IntPtr nativeObj, double nu02);
		
				// C++: double Moments::nu30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu30_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu30
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu30_10 (IntPtr nativeObj, double nu30);
		
				// C++: double Moments::nu21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu21_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu21
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu21_10 (IntPtr nativeObj, double nu21);
		
				// C++: double Moments::nu12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu12_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu12
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu12_10 (IntPtr nativeObj, double nu12);
		
				// C++: double Moments::nu03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double imgproc_Moments_get_1nu03_10 (IntPtr nativeObj);
		
				// C++: void Moments::nu03
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_set_1nu03_10 (IntPtr nativeObj, double nu03);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Moments_delete (IntPtr nativeObj);
		#endif
		}
}
