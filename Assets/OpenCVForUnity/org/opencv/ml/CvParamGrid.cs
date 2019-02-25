
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{



// C++: class CvParamGrid
/**
 * <p>The structure represents the logarithmic grid range of statmodel parameters.
 * It is used for optimizing statmodel accuracy by varying model parameters, the
 * accuracy estimate being computed by cross-validation.</p>
 *
 * <p>Minimum value of the statmodel parameter.</p>
 *
 * <p>Maximum value of the statmodel parameter.
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>Logarithmic step for iterating the statmodel parameter.</p>
 *
 * <p>The grid determines the following iteration sequence of the statmodel
 * parameter values: </code></p>
 *
 * <p><em>(min_val, min_val*step, min_val*(step)^2, dots, min_val*(step)^n),</em></p>
 *
 * <p>where <em>n</em> is the maximal index satisfying</p>
 *
 * <p><em>min_val * step ^n &lt max_val</em></p>
 *
 * <p>The grid is logarithmic, so <code>step</code> must always be greater then 1.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvparamgrid">org.opencv.ml.CvParamGrid</a>
 */
		public class CvParamGrid : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvParamGrid_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}
	
//		/*protected*/internal readonly IntPtr nativeObj;//TODO:@check
				/*protected*/
				internal CvParamGrid (IntPtr addr)
				{
						nativeObj = addr;
				}//TODO:@check
	
	
				public const int SVM_C = 0;
				public const int SVM_GAMMA = 1;
				public const int SVM_P = 2;
				public const int SVM_NU = 3;
				public const int SVM_COEF = 4;
				public const int SVM_DEGREE = 5;
	
	
				//
				// C++:   CvParamGrid::CvParamGrid()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The full constructor initializes corresponding members. The default
 * constructor creates a dummy grid:</p>
 *
 * <p><code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>CvParamGrid.CvParamGrid()</p>
 *
 *
 * <p>min_val = max_val = step = 0;</p>
 *
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvparamgrid-cvparamgrid">org.opencv.ml.CvParamGrid.CvParamGrid</a>
 */
				public   CvParamGrid ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = ml_CvParamGrid_CvParamGrid_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvParamGrid::min_val
				//
	
				public  double get_min_val ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvParamGrid_get_1min_1val_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvParamGrid::min_val
				//
	
				public  void set_min_val (double min_val)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvParamGrid_set_1min_1val_10 (nativeObj, min_val);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvParamGrid::max_val
				//
	
				public  double get_max_val ()
				{
						ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		
						double retVal = ml_CvParamGrid_get_1max_1val_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvParamGrid::max_val
				//
	
				public  void set_max_val (double max_val)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvParamGrid_set_1max_1val_10 (nativeObj, max_val);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++: double CvParamGrid::step
				//
	
				public  double get_step ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = ml_CvParamGrid_get_1step_10 (nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++: void CvParamGrid::step
				//
	
				public  void set_step (double step)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvParamGrid_set_1step_10 (nativeObj, step);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvParamGrid_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvParamGrid::CvParamGrid()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvParamGrid_CvParamGrid_10();
		
		// C++: double CvParamGrid::min_val
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvParamGrid_get_1min_1val_10(IntPtr nativeObj);
		
		// C++: void CvParamGrid::min_val
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvParamGrid_set_1min_1val_10(IntPtr nativeObj, double min_val);
		
		// C++: double CvParamGrid::max_val
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvParamGrid_get_1max_1val_10(IntPtr nativeObj);
		
		// C++: void CvParamGrid::max_val
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvParamGrid_set_1max_1val_10(IntPtr nativeObj, double max_val);
		
		// C++: double CvParamGrid::step
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double ml_CvParamGrid_get_1step_10(IntPtr nativeObj);
		
		// C++: void CvParamGrid::step
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvParamGrid_set_1step_10(IntPtr nativeObj, double step);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvParamGrid_delete(IntPtr nativeObj);

#else
				// C++:   CvParamGrid::CvParamGrid()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvParamGrid_CvParamGrid_10 ();
		
				// C++: double CvParamGrid::min_val
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvParamGrid_get_1min_1val_10 (IntPtr nativeObj);
		
				// C++: void CvParamGrid::min_val
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvParamGrid_set_1min_1val_10 (IntPtr nativeObj, double min_val);
		
				// C++: double CvParamGrid::max_val
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvParamGrid_get_1max_1val_10 (IntPtr nativeObj);
		
				// C++: void CvParamGrid::max_val
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvParamGrid_set_1max_1val_10 (IntPtr nativeObj, double max_val);
		
				// C++: double CvParamGrid::step
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double ml_CvParamGrid_get_1step_10 (IntPtr nativeObj);
		
				// C++: void CvParamGrid::step
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvParamGrid_set_1step_10 (IntPtr nativeObj, double step);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvParamGrid_delete (IntPtr nativeObj);
		#endif
		}
}
