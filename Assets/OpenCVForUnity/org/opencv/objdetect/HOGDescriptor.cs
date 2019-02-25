
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

//
// This file is auto-generated. Please don't modify it!
//
namespace OpenCVForUnity
{

// C++: class HOGDescriptor
		public class HOGDescriptor : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												objdetect_HOGDescriptor_delete (nativeObj);
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
				protected HOGDescriptor (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int L2Hys = 0;
				public const int DEFAULT_NLEVELS = 64;
	
	
				//
				// C++:   HOGDescriptor::HOGDescriptor()
				//
	
				public   HOGDescriptor ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_HOGDescriptor_HOGDescriptor_10 ();
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:   HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS)
				//
	
				public   HOGDescriptor (Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_HOGDescriptor_HOGDescriptor_11 (_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels);
		
						return;
						#else
						return;
						#endif
				}
	
				public   HOGDescriptor (Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_HOGDescriptor_HOGDescriptor_12 (_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:   HOGDescriptor::HOGDescriptor(String filename)
				//
	
				public   HOGDescriptor (string filename)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_HOGDescriptor_HOGDescriptor_13 (filename);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  bool HOGDescriptor::checkDetectorSize()
				//
	
				public  bool checkDetectorSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_HOGDescriptor_checkDetectorSize_10 (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = vector<Point>())
				//
	
				public  void compute (Mat img, MatOfFloat descriptors, Size winStride, Size padding, MatOfPoint locations)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (descriptors != null)
								descriptors.ThrowIfDisposed ();
						if (locations != null)
								locations.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat descriptors_mat = descriptors;
						Mat locations_mat = locations;
						objdetect_HOGDescriptor_compute_10 (nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height, padding.width, padding.height, locations_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
				public  void compute (Mat img, MatOfFloat descriptors)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (descriptors != null)
								descriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat descriptors_mat = descriptors;
						objdetect_HOGDescriptor_compute_11 (nativeObj, img.nativeObj, descriptors_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
				//
	
				public  void computeGradient (Mat img, Mat grad, Mat angleOfs, Size paddingTL, Size paddingBR)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (grad != null)
								grad.ThrowIfDisposed ();
						if (angleOfs != null)
								angleOfs.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						objdetect_HOGDescriptor_computeGradient_10 (nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj, paddingTL.width, paddingTL.height, paddingBR.width, paddingBR.height);
		
						return;
						#else
						return;
						#endif
				}
	
				public  void computeGradient (Mat img, Mat grad, Mat angleOfs)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (grad != null)
								grad.ThrowIfDisposed ();
						if (angleOfs != null)
								angleOfs.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						objdetect_HOGDescriptor_computeGradient_11 (nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = vector<Point>())
				//
	
				public  void detect (Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride, Size padding, MatOfPoint searchLocations)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (foundLocations != null)
								foundLocations.ThrowIfDisposed ();
						if (weights != null)
								weights.ThrowIfDisposed ();
						if (searchLocations != null)
								searchLocations.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat foundLocations_mat = foundLocations;
						Mat weights_mat = weights;
						Mat searchLocations_mat = searchLocations;
						objdetect_HOGDescriptor_detect_10 (nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, searchLocations_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
				public  void detect (Mat img, MatOfPoint foundLocations, MatOfDouble weights)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (foundLocations != null)
								foundLocations.ThrowIfDisposed ();
						if (weights != null)
								weights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat foundLocations_mat = foundLocations;
						Mat weights_mat = weights;
						objdetect_HOGDescriptor_detect_11 (nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
				//
	
				public  void detectMultiScale (Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale, double finalThreshold, bool useMeanshiftGrouping)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (foundLocations != null)
								foundLocations.ThrowIfDisposed ();
						if (foundWeights != null)
								foundWeights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat foundLocations_mat = foundLocations;
						Mat foundWeights_mat = foundWeights;
						objdetect_HOGDescriptor_detectMultiScale_10 (nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale, finalThreshold, useMeanshiftGrouping);
		
						return;
						#else
						return;
						#endif
				}
	
				public  void detectMultiScale (Mat img, MatOfRect foundLocations, MatOfDouble foundWeights)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (foundLocations != null)
								foundLocations.ThrowIfDisposed ();
						if (foundWeights != null)
								foundWeights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat foundLocations_mat = foundLocations;
						Mat foundWeights_mat = foundWeights;
						objdetect_HOGDescriptor_detectMultiScale_11 (nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: static vector_float HOGDescriptor::getDaimlerPeopleDetector()
				//
	
				public static MatOfFloat getDaimlerPeopleDetector ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						MatOfFloat retVal = MatOfFloat.fromNativeAddr (objdetect_HOGDescriptor_getDaimlerPeopleDetector_10 ());
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: static vector_float HOGDescriptor::getDefaultPeopleDetector()
				//
	
				public static MatOfFloat getDefaultPeopleDetector ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						MatOfFloat retVal = MatOfFloat.fromNativeAddr (objdetect_HOGDescriptor_getDefaultPeopleDetector_10 ());
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  size_t HOGDescriptor::getDescriptorSize()
				//
	
				public  long getDescriptorSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						long retVal = objdetect_HOGDescriptor_getDescriptorSize_10 (nativeObj);//TODO: @size_t long->double
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  double HOGDescriptor::getWinSigma()
				//
	
				public  double getWinSigma ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = objdetect_HOGDescriptor_getWinSigma_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  bool HOGDescriptor::load(String filename, String objname = String())
				//
	
				public  bool load (string filename, string objname)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_HOGDescriptor_load_10 (nativeObj, filename, objname);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				public  bool load (string filename)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_HOGDescriptor_load_11 (nativeObj, filename);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::save(String filename, String objname = String())
				//
	
				public  void save (string filename, string objname)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						objdetect_HOGDescriptor_save_10 (nativeObj, filename, objname);
		
						return;
						#else
						return;
						#endif
				}
	
				public  void save (string filename)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						objdetect_HOGDescriptor_save_11 (nativeObj, filename);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void HOGDescriptor::setSVMDetector(Mat _svmdetector)
				//
	
				public  void setSVMDetector (Mat _svmdetector)
				{
						if (_svmdetector != null)
								_svmdetector.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						objdetect_HOGDescriptor_setSVMDetector_10 (nativeObj, _svmdetector.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: Size HOGDescriptor::winSize
				//
	
				public  Size get_winSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[2];
						objdetect_HOGDescriptor_get_1winSize_10 (nativeObj, tmpArray);
		
						Size retVal = new Size (tmpArray);
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: Size HOGDescriptor::blockSize
				//
	
				public  Size get_blockSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[2];
						objdetect_HOGDescriptor_get_1blockSize_10 (nativeObj, tmpArray);
						Size retVal = new Size (tmpArray);
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: Size HOGDescriptor::blockStride
				//
	
				public  Size get_blockStride ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[2];
						objdetect_HOGDescriptor_get_1blockStride_10 (nativeObj, tmpArray);
						Size retVal = new Size (tmpArray);
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: Size HOGDescriptor::cellSize
				//
	
				public  Size get_cellSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[2];
						objdetect_HOGDescriptor_get_1cellSize_10 (nativeObj, tmpArray);
						Size retVal = new Size (tmpArray);
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: int HOGDescriptor::nbins
				//
	
				public  int get_nbins ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = objdetect_HOGDescriptor_get_1nbins_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: int HOGDescriptor::derivAperture
				//
	
				public  int get_derivAperture ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = objdetect_HOGDescriptor_get_1derivAperture_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: double HOGDescriptor::winSigma
				//
	
				public  double get_winSigma ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = objdetect_HOGDescriptor_get_1winSigma_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: int HOGDescriptor::histogramNormType
				//
	
				public  int get_histogramNormType ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = objdetect_HOGDescriptor_get_1histogramNormType_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: double HOGDescriptor::L2HysThreshold
				//
	
				public  double get_L2HysThreshold ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double retVal = objdetect_HOGDescriptor_get_1L2HysThreshold_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++: bool HOGDescriptor::gammaCorrection
				//
	
				public  bool get_gammaCorrection ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_HOGDescriptor_get_1gammaCorrection_10 (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++: vector_float HOGDescriptor::svmDetector
				//
	
				public  MatOfFloat get_svmDetector ()
				{
						ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		
						MatOfFloat retVal = MatOfFloat.fromNativeAddr (objdetect_HOGDescriptor_get_1svmDetector_10 (nativeObj));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++: int HOGDescriptor::nlevels
				//
	
				public  int get_nlevels ()
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = objdetect_HOGDescriptor_get_1nlevels_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			objdetect_HOGDescriptor_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   HOGDescriptor::HOGDescriptor()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_10();
		
		// C++:   HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_11(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_12(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins);
		
		// C++:   HOGDescriptor::HOGDescriptor(String filename)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_13(string filename);
		
		// C++:  bool HOGDescriptor::checkDetectorSize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_HOGDescriptor_checkDetectorSize_10(IntPtr nativeObj);
		
		// C++:  void HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = vector<Point>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_compute_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr locations_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_compute_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj);
		
		// C++:  void HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_computeGradient_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height, double paddingBR_width, double paddingBR_height);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_computeGradient_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj);
		
		// C++:  void HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = vector<Point>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_detect_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr searchLocations_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_detect_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj);
		
		// C++:  void HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_detectMultiScale_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double finalThreshold, bool useMeanshiftGrouping);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_detectMultiScale_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj);
		
		// C++: static vector_float HOGDescriptor::getDaimlerPeopleDetector()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_getDaimlerPeopleDetector_10();
		
		// C++: static vector_float HOGDescriptor::getDefaultPeopleDetector()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_getDefaultPeopleDetector_10();
		
		// C++:  size_t HOGDescriptor::getDescriptorSize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern long objdetect_HOGDescriptor_getDescriptorSize_10(IntPtr nativeObj);//TODO:@check
		
		// C++:  double HOGDescriptor::getWinSigma()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double objdetect_HOGDescriptor_getWinSigma_10(IntPtr nativeObj);
		
		// C++:  bool HOGDescriptor::load(String filename, String objname = String())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_HOGDescriptor_load_10(IntPtr nativeObj, string filename, string objname);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_HOGDescriptor_load_11(IntPtr nativeObj, string filename);
		
		// C++:  void HOGDescriptor::save(String filename, String objname = String())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_save_10(IntPtr nativeObj, string filename, string objname);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_save_11(IntPtr nativeObj, string filename);
		
		// C++:  void HOGDescriptor::setSVMDetector(Mat _svmdetector)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_setSVMDetector_10(IntPtr nativeObj, IntPtr _svmdetector_nativeObj);
		
		// C++: Size HOGDescriptor::winSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_get_1winSize_10(IntPtr nativeObj,[In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
		// C++: Size HOGDescriptor::blockSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_get_1blockSize_10(IntPtr nativeObj,[In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
		// C++: Size HOGDescriptor::blockStride
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_get_1blockStride_10(IntPtr nativeObj,[In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
		// C++: Size HOGDescriptor::cellSize
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_get_1cellSize_10(IntPtr nativeObj,[In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
		// C++: int HOGDescriptor::nbins
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int objdetect_HOGDescriptor_get_1nbins_10(IntPtr nativeObj);
		
		// C++: int HOGDescriptor::derivAperture
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int objdetect_HOGDescriptor_get_1derivAperture_10(IntPtr nativeObj);
		
		// C++: double HOGDescriptor::winSigma
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double objdetect_HOGDescriptor_get_1winSigma_10(IntPtr nativeObj);
		
		// C++: int HOGDescriptor::histogramNormType
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int objdetect_HOGDescriptor_get_1histogramNormType_10(IntPtr nativeObj);
		
		// C++: double HOGDescriptor::L2HysThreshold
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern double objdetect_HOGDescriptor_get_1L2HysThreshold_10(IntPtr nativeObj);
		
		// C++: bool HOGDescriptor::gammaCorrection
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_HOGDescriptor_get_1gammaCorrection_10(IntPtr nativeObj);
		
		// C++: vector_float HOGDescriptor::svmDetector
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_HOGDescriptor_get_1svmDetector_10(IntPtr nativeObj);
		
		// C++: int HOGDescriptor::nlevels
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int objdetect_HOGDescriptor_get_1nlevels_10(IntPtr nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_HOGDescriptor_delete(IntPtr nativeObj);

#else
		
				// C++:   HOGDescriptor::HOGDescriptor()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_10 ();
		
				// C++:   HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_11 (double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_12 (double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins);
		
				// C++:   HOGDescriptor::HOGDescriptor(String filename)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_13 (string filename);
		
				// C++:  bool HOGDescriptor::checkDetectorSize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_HOGDescriptor_checkDetectorSize_10 (IntPtr nativeObj);
		
				// C++:  void HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = vector<Point>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_compute_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr locations_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_compute_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj);
		
				// C++:  void HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_computeGradient_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height, double paddingBR_width, double paddingBR_height);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_computeGradient_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj);
		
				// C++:  void HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = vector<Point>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_detect_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr searchLocations_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_detect_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj);
		
				// C++:  void HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_detectMultiScale_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double finalThreshold, bool useMeanshiftGrouping);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_detectMultiScale_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj);
		
				// C++: static vector_float HOGDescriptor::getDaimlerPeopleDetector()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_getDaimlerPeopleDetector_10 ();
		
				// C++: static vector_float HOGDescriptor::getDefaultPeopleDetector()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_getDefaultPeopleDetector_10 ();
		
				// C++:  size_t HOGDescriptor::getDescriptorSize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern long objdetect_HOGDescriptor_getDescriptorSize_10 (IntPtr nativeObj);//TODO:@check
		
				// C++:  double HOGDescriptor::getWinSigma()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double objdetect_HOGDescriptor_getWinSigma_10 (IntPtr nativeObj);
		
				// C++:  bool HOGDescriptor::load(String filename, String objname = String())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_HOGDescriptor_load_10 (IntPtr nativeObj, string filename, string objname);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_HOGDescriptor_load_11 (IntPtr nativeObj, string filename);
		
				// C++:  void HOGDescriptor::save(String filename, String objname = String())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_save_10 (IntPtr nativeObj, string filename, string objname);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_save_11 (IntPtr nativeObj, string filename);
		
				// C++:  void HOGDescriptor::setSVMDetector(Mat _svmdetector)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_setSVMDetector_10 (IntPtr nativeObj, IntPtr _svmdetector_nativeObj);
		
				// C++: Size HOGDescriptor::winSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_get_1winSize_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
				// C++: Size HOGDescriptor::blockSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_get_1blockSize_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
				// C++: Size HOGDescriptor::blockStride
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_get_1blockStride_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
				// C++: Size HOGDescriptor::cellSize
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_get_1cellSize_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
				// C++: int HOGDescriptor::nbins
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int objdetect_HOGDescriptor_get_1nbins_10 (IntPtr nativeObj);
		
				// C++: int HOGDescriptor::derivAperture
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int objdetect_HOGDescriptor_get_1derivAperture_10 (IntPtr nativeObj);
		
				// C++: double HOGDescriptor::winSigma
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double objdetect_HOGDescriptor_get_1winSigma_10 (IntPtr nativeObj);
		
				// C++: int HOGDescriptor::histogramNormType
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int objdetect_HOGDescriptor_get_1histogramNormType_10 (IntPtr nativeObj);
		
				// C++: double HOGDescriptor::L2HysThreshold
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern double objdetect_HOGDescriptor_get_1L2HysThreshold_10 (IntPtr nativeObj);
		
				// C++: bool HOGDescriptor::gammaCorrection
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_HOGDescriptor_get_1gammaCorrection_10 (IntPtr nativeObj);
		
				// C++: vector_float HOGDescriptor::svmDetector
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_HOGDescriptor_get_1svmDetector_10 (IntPtr nativeObj);
		
				// C++: int HOGDescriptor::nlevels
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int objdetect_HOGDescriptor_get_1nlevels_10 (IntPtr nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_HOGDescriptor_delete (IntPtr nativeObj);
		#endif
		}
}
