
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{



// C++: class Algorithm
/**
 * <p>class CV_EXPORTS_W Algorithm <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>Algorithm();</p>
 *
 * <p>virtual ~Algorithm();</p>
 *
 * <p>string name() const;</p>
 *
 * <p>template<typename _Tp> typename ParamType<_Tp>.member_type get(const string&
 * name) const;</p>
 *
 * <p>template<typename _Tp> typename ParamType<_Tp>.member_type get(const char*
 * name) const;</p>
 *
 * <p>CV_WRAP int getInt(const string& name) const;</p>
 *
 * <p>CV_WRAP double getDouble(const string& name) const;</p>
 *
 * <p>CV_WRAP bool getBool(const string& name) const;</p>
 *
 * <p>CV_WRAP string getString(const string& name) const;</p>
 *
 * <p>CV_WRAP Mat getMat(const string& name) const;</p>
 *
 * <p>CV_WRAP vector<Mat> getMatVector(const string& name) const;</p>
 *
 * <p>CV_WRAP Ptr<Algorithm> getAlgorithm(const string& name) const;</p>
 *
 * <p>void set(const string& name, int value);</p>
 *
 * <p>void set(const string& name, double value);</p>
 *
 * <p>void set(const string& name, bool value);</p>
 *
 * <p>void set(const string& name, const string& value);</p>
 *
 * <p>void set(const string& name, const Mat& value);</p>
 *
 * <p>void set(const string& name, const vector<Mat>& value);</p>
 *
 * <p>void set(const string& name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void set(const string& name, const Ptr<_Tp>& value);</p>
 *
 * <p>CV_WRAP void setInt(const string& name, int value);</p>
 *
 * <p>CV_WRAP void setDouble(const string& name, double value);</p>
 *
 * <p>CV_WRAP void setBool(const string& name, bool value);</p>
 *
 * <p>CV_WRAP void setString(const string& name, const string& value);</p>
 *
 * <p>CV_WRAP void setMat(const string& name, const Mat& value);</p>
 *
 * <p>CV_WRAP void setMatVector(const string& name, const vector<Mat>& value);</p>
 *
 * <p>CV_WRAP void setAlgorithm(const string& name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void setAlgorithm(const string& name, const Ptr<_Tp>&
 * value);</p>
 *
 * <p>void set(const char* name, int value);</p>
 *
 * <p>void set(const char* name, double value);</p>
 *
 * <p>void set(const char* name, bool value);</p>
 *
 * <p>void set(const char* name, const string& value);</p>
 *
 * <p>void set(const char* name, const Mat& value);</p>
 *
 * <p>void set(const char* name, const vector<Mat>& value);</p>
 *
 * <p>void set(const char* name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void set(const char* name, const Ptr<_Tp>& value);</p>
 *
 * <p>void setInt(const char* name, int value);</p>
 *
 * <p>void setDouble(const char* name, double value);</p>
 *
 * <p>void setBool(const char* name, bool value);</p>
 *
 * <p>void setString(const char* name, const string& value);</p>
 *
 * <p>void setMat(const char* name, const Mat& value);</p>
 *
 * <p>void setMatVector(const char* name, const vector<Mat>& value);</p>
 *
 * <p>void setAlgorithm(const char* name, const Ptr<Algorithm>& value);</p>
 *
 * <p>template<typename _Tp> void setAlgorithm(const char* name, const Ptr<_Tp>&
 * value);</p>
 *
 * <p>CV_WRAP string paramHelp(const string& name) const;</p>
 *
 * <p>int paramType(const char* name) const;</p>
 *
 * <p>CV_WRAP int paramType(const string& name) const;</p>
 *
 * <p>CV_WRAP void getParams(CV_OUT vector<string>& names) const;</p>
 *
 * <p>virtual void write(FileStorage& fs) const;</p>
 *
 * <p>virtual void read(const FileNode& fn);</p>
 *
 * <p>typedef Algorithm* (*Constructor)(void);</p>
 *
 * <p>typedef int (Algorithm.*Getter)() const;</p>
 *
 * <p>typedef void (Algorithm.*Setter)(int);</p>
 *
 * <p>CV_WRAP static void getList(CV_OUT vector<string>& algorithms);</p>
 *
 * <p>CV_WRAP static Ptr<Algorithm> _create(const string& name);</p>
 *
 * <p>template<typename _Tp> static Ptr<_Tp> create(const string& name);</p>
 *
 * <p>virtual AlgorithmInfo* info() const / * TODO: make it = 0;* / { return 0; }</p>
 *
 * <p>};</p>
 *
 * <p>This is a base class for all more or less complex algorithms in OpenCV,
 * especially for classes of algorithms, for which there can be multiple
 * implementations. The examples are stereo correspondence (for which there are
 * algorithms like block matching, semi-global block matching, graph-cut etc.),
 * background subtraction (which can be done using mixture-of-gaussians models,
 * codebook-based algorithm etc.), optical flow (block matching, Lucas-Kanade,
 * Horn-Schunck etc.).
 * </code></p>
 *
 * <p>The class provides the following features for all derived classes:</p>
 * <ul>
 *   <li> so called "virtual constructor". That is, each Algorithm derivative is
 * registered at program start and you can get the list of registered algorithms
 * and create instance of a particular algorithm by its name (see
 * <code>Algorithm.create</code>). If you plan to add your own algorithms, it
 * is good practice to add a unique prefix to your algorithms to distinguish
 * them from other algorithms.
 *   <li> setting/retrieving algorithm parameters by name. If you used video
 * capturing functionality from OpenCV highgui module, you are probably familar
 * with <code>cvSetCaptureProperty()</code>, <code>cvGetCaptureProperty()</code>,
 * <code>VideoCapture.set()</code> and <code>VideoCapture.get()</code>.
 * <code>Algorithm</code> provides similar method where instead of integer id's
 * you specify the parameter names as text strings. See <code>Algorithm.set</code>
 * and <code>Algorithm.get</code> for details.
 *   <li> reading and writing parameters from/to XML or YAML files. Every
 * Algorithm derivative can store all its parameters and then read them back.
 * There is no need to re-implement it each time.
 * </ul>
 * <p>Here is example of SIFT use in your application via Algorithm interface:
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>#include "opencv2/opencv.hpp"</p>
 *
 * <p>#include "opencv2/nonfree/nonfree.hpp"...</p>
 *
 * <p>initModule_nonfree(); // to load SURF/SIFT etc.</p>
 *
 * <p>Ptr<Feature2D> sift = Algorithm.create<Feature2D>("Feature2D.SIFT");</p>
 *
 * <p>FileStorage fs("sift_params.xml", FileStorage.READ);</p>
 *
 * <p>if(fs.isOpened()) // if we have file with parameters, read them</p>
 *
 *
 * <p>sift->read(fs["sift_params"]);</p>
 *
 * <p>fs.release();</p>
 *
 *
 * <p>else // else modify the parameters and store them; user can later edit the
 * file to use different parameters</p>
 *
 *
 * <p>sift->set("contrastThreshold", 0.01f); // lower the contrast threshold,
 * compared to the default value</p>
 *
 *
 * <p>WriteStructContext ws(fs, "sift_params", CV_NODE_MAP);</p>
 *
 * <p>sift->write(fs);</p>
 *
 *
 *
 * <p>Mat image = imread("myimage.png", 0), descriptors;</p>
 *
 * <p>vector<KeyPoint> keypoints;</p>
 *
 * <p>(*sift)(image, noArray(), keypoints, descriptors);</p>
 *
 * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#algorithm">org.opencv.core.Algorithm</a>
 */
		public class Algorithm : DisposableOpenCVObject
		{



				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												core_Algorithm_delete (nativeObj);
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
				protected Algorithm (IntPtr addr)
				{
						nativeObj = addr;
				}


	
	
				//
				// C++: static Ptr_Algorithm Algorithm::_create(string name)
				//
	
				// Return type 'Ptr_Algorithm' is not supported, skipping the function
	
	
				//
				// C++:  Ptr_Algorithm Algorithm::getAlgorithm(string name)
				//
	
				// Return type 'Ptr_Algorithm' is not supported, skipping the function
	
	
				//
				// C++:  bool Algorithm::getBool(string name)
				//
	
				public  bool getBool (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = core_Algorithm_getBool_10 (nativeObj, name);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  double Algorithm::getDouble(string name)
				//
	
				public  double getDouble (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = core_Algorithm_getDouble_10 (nativeObj, name);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Algorithm::getInt(string name)
				//
	
				public  int getInt (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = core_Algorithm_getInt_10 (nativeObj, name);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: static void Algorithm::getList(vector_string& algorithms)
				//
	
				// Unknown type 'vector_string' (O), skipping the function
	
	
				//
				// C++:  Mat Algorithm::getMat(string name)
				//
	
				public  Mat getMat (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (core_Algorithm_getMat_10 (nativeObj, name));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  vector_Mat Algorithm::getMatVector(string name)
				//
	
				public  List<Mat> getMatVector (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						List<Mat> retVal = new List<Mat> ();
						Mat retValMat = new Mat (core_Algorithm_getMatVector_10 (nativeObj, name));
						Converters.Mat_to_vector_Mat (retValMat, retVal);
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::getParams(vector_string& names)
				//
	
				// Unknown type 'vector_string' (O), skipping the function
	
	
				//
				// C++:  string Algorithm::getString(string name)
				//
	
				public  string getString (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						string retVal = Marshal.PtrToStringAnsi (core_Algorithm_getString_10 (nativeObj, name));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  string Algorithm::paramHelp(string name)
				//
	
				public  string paramHelp (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)

						string retVal = Marshal.PtrToStringAnsi (core_Algorithm_paramHelp_10 (nativeObj, name));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  int Algorithm::paramType(string name)
				//
	
				public  int paramType (string name)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = core_Algorithm_paramType_10 (nativeObj, name);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setAlgorithm(string name, Ptr_Algorithm value)
				//
	
				// Unknown type 'Ptr_Algorithm' (I), skipping the function
	
	
				//
				// C++:  void Algorithm::setBool(string name, bool value)
				//
	
				public  void setBool (string name, bool value)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						core_Algorithm_setBool_10 (nativeObj, name, value);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setDouble(string name, double value)
				//
	
				public  void setDouble (string name, double value)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						core_Algorithm_setDouble_10 (nativeObj, name, value);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setInt(string name, int value)
				//
	
				public  void setInt (string name, int value)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						core_Algorithm_setInt_10 (nativeObj, name, value);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setMat(string name, Mat value)
				//
	
				public  void setMat (string name, Mat value)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						core_Algorithm_setMat_10 (nativeObj, name, value.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setMatVector(string name, vector_Mat value)
				//
	
				public  void setMatVector (string name, List<Mat> value)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat value_mat = Converters.vector_Mat_to_Mat (value);
						core_Algorithm_setMatVector_10 (nativeObj, name, value_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Algorithm::setString(string name, string value)
				//
	
				public  void setString (string name, string value)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						core_Algorithm_setString_10 (nativeObj, name, value);
		
						return;
						#else
						return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			core_Algorithm_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  bool Algorithm::getBool(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool core_Algorithm_getBool_10(IntPtr nativeObj, string name);
		
		// C++:  double Algorithm::getDouble(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double core_Algorithm_getDouble_10(IntPtr nativeObj, string name);
		
		// C++:  int Algorithm::getInt(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int core_Algorithm_getInt_10(IntPtr nativeObj, string name);
		
		// C++:  Mat Algorithm::getMat(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr core_Algorithm_getMat_10(IntPtr nativeObj, string name);
		
		// C++:  vector_Mat Algorithm::getMatVector(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr core_Algorithm_getMatVector_10(IntPtr nativeObj, string name);
		
		// C++:  string Algorithm::getString(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr core_Algorithm_getString_10(IntPtr nativeObj, string name);
		
		// C++:  string Algorithm::paramHelp(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr core_Algorithm_paramHelp_10(IntPtr nativeObj, string name);
		
		// C++:  int Algorithm::paramType(string name)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int core_Algorithm_paramType_10(IntPtr nativeObj, string name);
		
		// C++:  void Algorithm::setBool(string name, bool value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setBool_10(IntPtr nativeObj, string name, bool value);
		
		// C++:  void Algorithm::setDouble(string name, double value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setDouble_10(IntPtr nativeObj, string name, double value);
		
		// C++:  void Algorithm::setInt(string name, int value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setInt_10(IntPtr nativeObj, string name, int value);
		
		// C++:  void Algorithm::setMat(string name, Mat value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setMat_10(IntPtr nativeObj, string name, IntPtr value_nativeObj);
		
		// C++:  void Algorithm::setMatVector(string name, vector_Mat value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setMatVector_10(IntPtr nativeObj, string name, IntPtr value_mat_nativeObj);
		
		// C++:  void Algorithm::setString(string name, string value)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_setString_10(IntPtr nativeObj, string name, string value);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void core_Algorithm_delete(IntPtr nativeObj);

#else
		
				// C++:  bool Algorithm::getBool(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool core_Algorithm_getBool_10 (IntPtr nativeObj, string name);
		
				// C++:  double Algorithm::getDouble(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double core_Algorithm_getDouble_10 (IntPtr nativeObj, string name);
		
				// C++:  int Algorithm::getInt(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int core_Algorithm_getInt_10 (IntPtr nativeObj, string name);
		
				// C++:  Mat Algorithm::getMat(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr core_Algorithm_getMat_10 (IntPtr nativeObj, string name);
		
				// C++:  vector_Mat Algorithm::getMatVector(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr core_Algorithm_getMatVector_10 (IntPtr nativeObj, string name);
		
				// C++:  string Algorithm::getString(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr core_Algorithm_getString_10 (IntPtr nativeObj, string name);
		
				// C++:  string Algorithm::paramHelp(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr core_Algorithm_paramHelp_10 (IntPtr nativeObj, string name);
		
				// C++:  int Algorithm::paramType(string name)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int core_Algorithm_paramType_10 (IntPtr nativeObj, string name);
		
				// C++:  void Algorithm::setBool(string name, bool value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setBool_10 (IntPtr nativeObj, string name, bool value);
		
				// C++:  void Algorithm::setDouble(string name, double value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setDouble_10 (IntPtr nativeObj, string name, double value);
		
				// C++:  void Algorithm::setInt(string name, int value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setInt_10 (IntPtr nativeObj, string name, int value);
		
				// C++:  void Algorithm::setMat(string name, Mat value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setMat_10 (IntPtr nativeObj, string name, IntPtr value_nativeObj);
		
				// C++:  void Algorithm::setMatVector(string name, vector_Mat value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setMatVector_10 (IntPtr nativeObj, string name, IntPtr value_mat_nativeObj);
		
				// C++:  void Algorithm::setString(string name, string value)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_setString_10 (IntPtr nativeObj, string name, string value);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void core_Algorithm_delete (IntPtr nativeObj);
		#endif
	
		}
}
