
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{


// C++: class CvStatModel
/**
 * <p>Base class for statistical models in ML.</p>
 *
 * <p>class CvStatModel <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>/ * CvStatModel(); * /</p>
 *
 * <p>/ * CvStatModel(const Mat& train_data...); * /</p>
 *
 * <p>virtual ~CvStatModel();</p>
 *
 * <p>virtual void clear()=0;</p>
 *
 * <p>/ * virtual bool train(const Mat& train_data, [int tflag,]..., const</p>
 *
 * <p>Mat& responses,...,</p>
 *
 * <p>[const Mat& var_idx,]..., [const Mat& sample_idx,]...</p>
 *
 * <p>[const Mat& var_type,]..., [const Mat& missing_mask,]</p>
 *
 * <p><misc_training_alg_params>...)=0;</p>
 * <ul>
 *   <li> /
 * </ul>
 *
 * <p>/ * virtual float predict(const Mat& sample...) const=0; * /</p>
 *
 * <p>virtual void save(const char* filename, const char* name=0)=0;</p>
 *
 * <p>virtual void load(const char* filename, const char* name=0)=0;</p>
 *
 * <p>virtual void write(CvFileStorage* storage, const char* name)=0;</p>
 *
 * <p>virtual void read(CvFileStorage* storage, CvFileNode* node)=0;</p>
 *
 * <p>};</p>
 *
 * <p>In this declaration, some methods are commented off. These are methods for
 * which there is no unified API (with the exception of the default
 * constructor). However, there are many similarities in the syntax and
 * semantics that are briefly described below in this section, as if they are
 * part of the base class.
 * </code></p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel">org.opencv.ml.CvStatModel</a>
 */
		public class CvStatModel : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvStatModel_delete (nativeObj);
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
				protected CvStatModel (IntPtr addr)
				{
						nativeObj = addr;
				}
	
	
				//
				// C++:  void CvStatModel::load(c_string filename, c_string name = 0)
				//
	
				/**
 * <p>Loads the model from a file.</p>
 *
 * <p>The method <code>load</code> loads the complete model state with the
 * specified name (or default model-dependent name) from the specified XML or
 * YAML file. The previous model state is cleared by "CvStatModel.clear".</p>
 *
 * @param filename a filename
 * @param name a name
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel-load">org.opencv.ml.CvStatModel.load</a>
 */
				public  void load (string filename, string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvStatModel_load_10 (nativeObj, filename, name);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Loads the model from a file.</p>
 *
 * <p>The method <code>load</code> loads the complete model state with the
 * specified name (or default model-dependent name) from the specified XML or
 * YAML file. The previous model state is cleared by "CvStatModel.clear".</p>
 *
 * @param filename a filename
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel-load">org.opencv.ml.CvStatModel.load</a>
 */
				public  void load (string filename)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvStatModel_load_11 (nativeObj, filename);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void CvStatModel::save(c_string filename, c_string name = 0)
				//
	
				/**
 * <p>Saves the model to a file.</p>
 *
 * <p>The method <code>save</code> saves the complete model state to the specified
 * XML or YAML file with the specified name or default name (which depends on a
 * particular class). *Data persistence* functionality from <code>CxCore</code>
 * is used.</p>
 *
 * @param filename a filename
 * @param name a name
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel-save">org.opencv.ml.CvStatModel.save</a>
 */
				public  void save (string filename, string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvStatModel_save_10 (nativeObj, filename, name);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Saves the model to a file.</p>
 *
 * <p>The method <code>save</code> saves the complete model state to the specified
 * XML or YAML file with the specified name or default name (which depends on a
 * particular class). *Data persistence* functionality from <code>CxCore</code>
 * is used.</p>
 *
 * @param filename a filename
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel-save">org.opencv.ml.CvStatModel.save</a>
 */
				public  void save (string filename)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvStatModel_save_11 (nativeObj, filename);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvStatModel_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void CvStatModel::load(c_string filename, c_string name = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvStatModel_load_10(IntPtr nativeObj, string filename, string name);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvStatModel_load_11(IntPtr nativeObj, string filename);
		
		// C++:  void CvStatModel::save(c_string filename, c_string name = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvStatModel_save_10(IntPtr nativeObj, string filename, string name);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvStatModel_save_11(IntPtr nativeObj, string filename);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvStatModel_delete(IntPtr nativeObj);

#else
		
				// C++:  void CvStatModel::load(c_string filename, c_string name = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvStatModel_load_10 (IntPtr nativeObj, string filename, string name);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvStatModel_load_11 (IntPtr nativeObj, string filename);
		
				// C++:  void CvStatModel::save(c_string filename, c_string name = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvStatModel_save_10 (IntPtr nativeObj, string filename, string name);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvStatModel_save_11 (IntPtr nativeObj, string filename);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvStatModel_delete (IntPtr nativeObj);
		#endif
		}
}
