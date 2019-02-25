
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


// C++: class javaFeatureDetector
/**
 * <p>Abstract base class for 2D image feature detectors.</p>
 *
 * <p>class CV_EXPORTS FeatureDetector <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>virtual ~FeatureDetector();</p>
 *
 * <p>void detect(const Mat& image, vector<KeyPoint>& keypoints,</p>
 *
 * <p>const Mat& mask=Mat()) const;</p>
 *
 * <p>void detect(const vector<Mat>& images,</p>
 *
 * <p>vector<vector<KeyPoint> >& keypoints,</p>
 *
 * <p>const vector<Mat>& masks=vector<Mat>()) const;</p>
 *
 * <p>virtual void read(const FileNode&);</p>
 *
 * <p>virtual void write(FileStorage&) const;</p>
 *
 * <p>static Ptr<FeatureDetector> create(const string& detectorType);</p>
 *
 * <p>protected:...</p>
 *
 * <p>};</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector">org.opencv.features2d.FeatureDetector : public Algorithm</a>
 */
		public class FeatureDetector : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												features2d_FeatureDetector_delete (nativeObj);
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
				protected FeatureDetector (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				private const int GRIDDETECTOR = 1000;
				private const int PYRAMIDDETECTOR = 2000;
				private const int DYNAMICDETECTOR = 3000;
				public const int FAST = 1;
				public const int STAR = 2;
				//						SIFT = 3;//TODO: @check nonfree
				//						SURF = 4;//TODO: @check nonfree
				public const int ORB = 5;
				public const int MSER = 6;
				public const int GFTT = 7;
				public const int HARRIS = 8;
				public const int SIMPLEBLOB = 9;
				public const int DENSE = 10;
				public const int BRISK = 11;
				public const int GRIDRETECTOR = 1000;
				public const int GRID_FAST = GRIDDETECTOR + FAST;
				public const int GRID_STAR = GRIDDETECTOR + STAR;
				//						GRID_SIFT = GRIDDETECTOR + SIFT;//TODO: @check nonfree
				//						GRID_SURF = GRIDDETECTOR + SURF;//TODO: @check nonfree
				public const int GRID_ORB = GRIDDETECTOR + ORB;
				public const int GRID_MSER = GRIDDETECTOR + MSER;
				public const int GRID_GFTT = GRIDDETECTOR + GFTT;
				public const int GRID_HARRIS = GRIDDETECTOR + HARRIS;
				public const int GRID_SIMPLEBLOB = GRIDDETECTOR + SIMPLEBLOB;
				public const int GRID_DENSE = GRIDDETECTOR + DENSE;
				public const int GRID_BRISK = GRIDDETECTOR + BRISK;
				public const int PYRAMID_FAST = PYRAMIDDETECTOR + FAST;
				public const int PYRAMID_STAR = PYRAMIDDETECTOR + STAR;
				//						PYRAMID_SIFT = PYRAMIDDETECTOR + SIFT;//TODO: @check nonfree
				//						PYRAMID_SURF = PYRAMIDDETECTOR + SURF;//TODO: @check nonfree
				public const int PYRAMID_ORB = PYRAMIDDETECTOR + ORB;
				public const int PYRAMID_MSER = PYRAMIDDETECTOR + MSER;
				public const int PYRAMID_GFTT = PYRAMIDDETECTOR + GFTT;
				public const int PYRAMID_HARRIS = PYRAMIDDETECTOR + HARRIS;
				public const int PYRAMID_SIMPLEBLOB = PYRAMIDDETECTOR + SIMPLEBLOB;
				public const int PYRAMID_DENSE = PYRAMIDDETECTOR + DENSE;
				public const int PYRAMID_BRISK = PYRAMIDDETECTOR + BRISK;
				public const int DYNAMIC_FAST = DYNAMICDETECTOR + FAST;
				public const int DYNAMIC_STAR = DYNAMICDETECTOR + STAR;
				//						DYNAMIC_SIFT = DYNAMICDETECTOR + SIFT;//TODO: @check nonfree
				//						DYNAMIC_SURF = DYNAMICDETECTOR + SURF;//TODO: @check nonfree
				public const int DYNAMIC_ORB = DYNAMICDETECTOR + ORB;
				public const int DYNAMIC_MSER = DYNAMICDETECTOR + MSER;
				public const int DYNAMIC_GFTT = DYNAMICDETECTOR + GFTT;
				public const int DYNAMIC_HARRIS = DYNAMICDETECTOR + HARRIS;
				public const int DYNAMIC_SIMPLEBLOB = DYNAMICDETECTOR + SIMPLEBLOB;
				public const int DYNAMIC_DENSE = DYNAMICDETECTOR + DENSE;
				public const int DYNAMIC_BRISK = DYNAMICDETECTOR + BRISK;
	
	
				//
				// C++: static javaFeatureDetector* javaFeatureDetector::create(int detectorType)
				//
	
				/**
 * <p>Creates a feature detector by its name.</p>
 *
 * <p>The following detector types are supported:</p>
 * <ul>
 *   <li> <code>"FAST"</code> -- "FastFeatureDetector"
 *   <li> <code>"STAR"</code> -- "StarFeatureDetector"
 *   <li> <code>"SIFT"</code> -- "SIFT" (nonfree module)
 *   <li> <code>"SURF"</code> -- "SURF" (nonfree module)
 *   <li> <code>"ORB"</code> -- "ORB"
 *   <li> <code>"BRISK"</code> -- "BRISK"
 *   <li> <code>"MSER"</code> -- "MSER"
 *   <li> <code>"GFTT"</code> -- "GoodFeaturesToTrackDetector"
 *   <li> <code>"HARRIS"</code> -- "GoodFeaturesToTrackDetector" with Harris
 * detector enabled
 *   <li> <code>"Dense"</code> -- "DenseFeatureDetector"
 *   <li> <code>"SimpleBlob"</code> -- "SimpleBlobDetector"
 * </ul>
 *
 * <p>Also a combined format is supported: feature detector adapter name
 * (<code>"Grid"</code> -- "GridAdaptedFeatureDetector", <code>"Pyramid"</code>
 * -- "PyramidAdaptedFeatureDetector") + feature detector name (see above), for
 * example: <code>"GridFAST"</code>, <code>"PyramidSTAR"</code>.</p>
 *
 * @param detectorType Feature detector type.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector-create">org.opencv.features2d.FeatureDetector.create</a>
 */
				public static FeatureDetector create (int detectorType)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						FeatureDetector retVal = new FeatureDetector (features2d_FeatureDetector_create_10 (detectorType));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  void javaFeatureDetector::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
				//
	
				/**
 * <p>Detects keypoints in an image (first variant) or image set (second variant).</p>
 *
 * @param image Image.
 * @param keypoints The detected keypoints. In the second variant of the method
 * <code>keypoints[i]</code> is a set of keypoints detected in <code>images[i]</code>.
 * @param mask Mask specifying where to look for keypoints (optional). It must
 * be a 8-bit integer matrix with non-zero values in the region of interest.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector-detect">org.opencv.features2d.FeatureDetector.detect</a>
 */
				public  void detect (Mat image, MatOfKeyPoint keypoints, Mat mask)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (keypoints != null)
								keypoints.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints_mat = keypoints;
						features2d_FeatureDetector_detect_10 (nativeObj, image.nativeObj, keypoints_mat.nativeObj, mask.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Detects keypoints in an image (first variant) or image set (second variant).</p>
 *
 * @param image Image.
 * @param keypoints The detected keypoints. In the second variant of the method
 * <code>keypoints[i]</code> is a set of keypoints detected in <code>images[i]</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector-detect">org.opencv.features2d.FeatureDetector.detect</a>
 */
				public  void detect (Mat image, MatOfKeyPoint keypoints)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (keypoints != null)
								keypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints_mat = keypoints;
						features2d_FeatureDetector_detect_11 (nativeObj, image.nativeObj, keypoints_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void javaFeatureDetector::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector<Mat>())
				//
	
				/**
 * <p>Detects keypoints in an image (first variant) or image set (second variant).</p>
 *
 * @param images Image set.
 * @param keypoints The detected keypoints. In the second variant of the method
 * <code>keypoints[i]</code> is a set of keypoints detected in <code>images[i]</code>.
 * @param masks Masks for each input image specifying where to look for
 * keypoints (optional). <code>masks[i]</code> is a mask for <code>images[i]</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector-detect">org.opencv.features2d.FeatureDetector.detect</a>
 */
				public  void detect (List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> masks)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						Mat keypoints_mat = new Mat ();
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_FeatureDetector_detect_12 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, masks_mat.nativeObj);
						Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Detects keypoints in an image (first variant) or image set (second variant).</p>
 *
 * @param images Image set.
 * @param keypoints The detected keypoints. In the second variant of the method
 * <code>keypoints[i]</code> is a set of keypoints detected in <code>images[i]</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_feature_detectors.html#featuredetector-detect">org.opencv.features2d.FeatureDetector.detect</a>
 */
				public  void detect (List<Mat> images, List<MatOfKeyPoint> keypoints)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						Mat keypoints_mat = new Mat ();
						features2d_FeatureDetector_detect_13 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);
						Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  bool javaFeatureDetector::empty()
				//
	
				public  bool empty ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_FeatureDetector_empty_10 (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  void javaFeatureDetector::read(string fileName)
				//
	
				public  void read (string fileName)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_FeatureDetector_read_10 (nativeObj, fileName);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void javaFeatureDetector::write(string fileName)
				//
	
				public  void write (string fileName)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_FeatureDetector_write_10 (nativeObj, fileName);
		
						return;
						#else
						return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			features2d_FeatureDetector_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++: static javaFeatureDetector* javaFeatureDetector::create(int detectorType)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_FeatureDetector_create_10(int detectorType);
		
		// C++:  void javaFeatureDetector::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_detect_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);
		
		// C++:  void javaFeatureDetector::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector<Mat>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_detect_12(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr masks_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_detect_13(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);
		
		// C++:  bool javaFeatureDetector::empty()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_FeatureDetector_empty_10(IntPtr nativeObj);
		
		// C++:  void javaFeatureDetector::read(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_read_10(IntPtr nativeObj, string fileName);
		
		// C++:  void javaFeatureDetector::write(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_write_10(IntPtr nativeObj, string fileName);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_FeatureDetector_delete(IntPtr nativeObj);

#else
				// C++: static javaFeatureDetector* javaFeatureDetector::create(int detectorType)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_FeatureDetector_create_10 (int detectorType);
		
				// C++:  void javaFeatureDetector::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_detect_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_detect_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);
		
				// C++:  void javaFeatureDetector::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector<Mat>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_detect_12 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr masks_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_detect_13 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);
		
				// C++:  bool javaFeatureDetector::empty()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_FeatureDetector_empty_10 (IntPtr nativeObj);
		
				// C++:  void javaFeatureDetector::read(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_read_10 (IntPtr nativeObj, string fileName);
		
				// C++:  void javaFeatureDetector::write(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_write_10 (IntPtr nativeObj, string fileName);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_FeatureDetector_delete (IntPtr nativeObj);
		#endif
		}
}
