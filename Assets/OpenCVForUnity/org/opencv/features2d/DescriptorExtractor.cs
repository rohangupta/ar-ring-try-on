
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


// C++: class javaDescriptorExtractor
/**
 * <p>Abstract base class for computing descriptors for image keypoints.</p>
 *
 * <p>class CV_EXPORTS DescriptorExtractor <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>virtual ~DescriptorExtractor();</p>
 *
 * <p>void compute(const Mat& image, vector<KeyPoint>& keypoints,</p>
 *
 * <p>Mat& descriptors) const;</p>
 *
 * <p>void compute(const vector<Mat>& images, vector<vector<KeyPoint> >& keypoints,</p>
 *
 * <p>vector<Mat>& descriptors) const;</p>
 *
 * <p>virtual void read(const FileNode&);</p>
 *
 * <p>virtual void write(FileStorage&) const;</p>
 *
 * <p>virtual int descriptorSize() const = 0;</p>
 *
 * <p>virtual int descriptorType() const = 0;</p>
 *
 * <p>static Ptr<DescriptorExtractor> create(const string& descriptorExtractorType);</p>
 *
 * <p>protected:...</p>
 *
 * <p>};</p>
 *
 * <p>In this interface, a keypoint descriptor can be represented as a </code></p>
 *
 * <p>dense, fixed-dimension vector of a basic type. Most descriptors follow this
 * pattern as it simplifies computing distances between descriptors. Therefore,
 * a collection of descriptors is represented as "Mat", where each row is a
 * keypoint descriptor.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor">org.opencv.features2d.DescriptorExtractor : public Algorithm</a>
 */
		public class DescriptorExtractor : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												features2d_DescriptorExtractor_delete (nativeObj);
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
				protected DescriptorExtractor (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				private const int
						OPPONENTEXTRACTOR = 1000;
				//public const int
//						SIFT = 1,//TODO: @check nonfree
				//			SURF = 2,//TODO: @check nonfree
				public const int ORB = 3;
				public const int BRIEF = 4;
				public const int BRISK = 5;
				public const int FREAK = 6;
				//			OPPONENT_SIFT = OPPONENTEXTRACTOR + SIFT,//TODO: @check nonfree
				//			OPPONENT_SURF = OPPONENTEXTRACTOR + SURF,//TODO: @check nonfree
				public const int OPPONENT_ORB = OPPONENTEXTRACTOR + ORB;
				public const int OPPONENT_BRIEF = OPPONENTEXTRACTOR + BRIEF;
				public const int OPPONENT_BRISK = OPPONENTEXTRACTOR + BRISK;
				public const int OPPONENT_FREAK = OPPONENTEXTRACTOR + FREAK;
	
	
				//
				// C++:  void javaDescriptorExtractor::compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
				//
		
				/**
 * <p>Computes the descriptors for a set of keypoints detected in an image (first
 * variant) or image set (second variant).</p>
 *
 * @param image Image.
 * @param keypoints Input collection of keypoints. Keypoints for which a
 * descriptor cannot be computed are removed and the remaining ones may be
 * reordered. Sometimes new keypoints can be added, for example:
 * <code>SIFT</code> duplicates a keypoint with several dominant orientations
 * (for each orientation).
 * @param descriptors Computed descriptors. In the second variant of the method
 * <code>descriptors[i]</code> are descriptors computed for a <code>keypoints[i]</code>.
 * Row <code>j</code> is the <code>keypoints</code> (or <code>keypoints[i]</code>)
 * is the descriptor for keypoint <code>j</code>-th keypoint.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor-compute">org.opencv.features2d.DescriptorExtractor.compute</a>
 */
				public  void compute (Mat image, MatOfKeyPoint keypoints, Mat descriptors)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (keypoints != null)
								keypoints.ThrowIfDisposed ();
						if (descriptors != null)
								descriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints_mat = keypoints;
						features2d_DescriptorExtractor_compute_10 (nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorExtractor::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
				//
		
				/**
 * <p>Computes the descriptors for a set of keypoints detected in an image (first
 * variant) or image set (second variant).</p>
 *
 * @param images Image set.
 * @param keypoints Input collection of keypoints. Keypoints for which a
 * descriptor cannot be computed are removed and the remaining ones may be
 * reordered. Sometimes new keypoints can be added, for example:
 * <code>SIFT</code> duplicates a keypoint with several dominant orientations
 * (for each orientation).
 * @param descriptors Computed descriptors. In the second variant of the method
 * <code>descriptors[i]</code> are descriptors computed for a <code>keypoints[i]</code>.
 * Row <code>j</code> is the <code>keypoints</code> (or <code>keypoints[i]</code>)
 * is the descriptor for keypoint <code>j</code>-th keypoint.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor-compute">org.opencv.features2d.DescriptorExtractor.compute</a>
 */
				public  void compute (List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> descriptors)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						List<Mat> keypoints_tmplm = new List<Mat> ((keypoints != null) ? keypoints.Count : 0);
						Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat (keypoints, keypoints_tmplm);
						Mat descriptors_mat = new Mat ();
						features2d_DescriptorExtractor_compute_11 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, descriptors_mat.nativeObj);
						Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
						Converters.Mat_to_vector_Mat (descriptors_mat, descriptors);
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++: static javaDescriptorExtractor* javaDescriptorExtractor::create(int extractorType)
				//
	
				/**
 * <p>Creates a descriptor extractor by name.</p>
 *
 * <p>The current implementation supports the following types of a descriptor
 * extractor:</p>
 * <ul>
 *   <li> <code>"SIFT"</code> -- "SIFT"
 *   <li> <code>"SURF"</code> -- "SURF"
 *   <li> <code>"BRIEF"</code> -- "BriefDescriptorExtractor"
 *   <li> <code>"BRISK"</code> -- "BRISK"
 *   <li> <code>"ORB"</code> -- "ORB"
 *   <li> <code>"FREAK"</code> -- "FREAK"
 * </ul>
 *
 * <p>A combined format is also supported: descriptor extractor adapter name
 * (<code>"Opponent"</code> -- "OpponentColorDescriptorExtractor") + descriptor
 * extractor name (see above), for example: <code>"OpponentSIFT"</code>.</p>
 *
 * @param extractorType a extractorType
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor-create">org.opencv.features2d.DescriptorExtractor.create</a>
 */
				public static DescriptorExtractor create (int extractorType)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						DescriptorExtractor retVal = new DescriptorExtractor (features2d_DescriptorExtractor_create_10 (extractorType));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  int javaDescriptorExtractor::descriptorSize()
				//
	
				public  int descriptorSize ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = features2d_DescriptorExtractor_descriptorSize_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int javaDescriptorExtractor::descriptorType()
				//
	
				public  int descriptorType ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = features2d_DescriptorExtractor_descriptorType_10 (nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  bool javaDescriptorExtractor::empty()
				//
	
				public  bool empty ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_DescriptorExtractor_empty_10 (nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorExtractor::read(string fileName)
				//
	
				public  void read (string fileName)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorExtractor_read_10 (nativeObj, fileName);

						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorExtractor::write(string fileName)
				//
	
				public  void write (string fileName)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorExtractor_write_10 (nativeObj, fileName);
		
						return;
						#else
						return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			features2d_DescriptorExtractor_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void javaDescriptorExtractor::compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorExtractor_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);
		
		// C++:  void javaDescriptorExtractor::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorExtractor_compute_11(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);
		
		// C++: static javaDescriptorExtractor* javaDescriptorExtractor::create(int extractorType)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_DescriptorExtractor_create_10(int extractorType);
		
		// C++:  int javaDescriptorExtractor::descriptorSize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int features2d_DescriptorExtractor_descriptorSize_10(IntPtr nativeObj);
		
		// C++:  int javaDescriptorExtractor::descriptorType()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int features2d_DescriptorExtractor_descriptorType_10(IntPtr nativeObj);
		
		// C++:  bool javaDescriptorExtractor::empty()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_DescriptorExtractor_empty_10(IntPtr nativeObj);
		
		// C++:  void javaDescriptorExtractor::read(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorExtractor_read_10(IntPtr nativeObj, string fileName);
		
		// C++:  void javaDescriptorExtractor::write(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorExtractor_write_10(IntPtr nativeObj, string fileName);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorExtractor_delete(IntPtr nativeObj);

#else
		
				// C++:  void javaDescriptorExtractor::compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorExtractor_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);
		
				// C++:  void javaDescriptorExtractor::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorExtractor_compute_11 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);
		
				// C++: static javaDescriptorExtractor* javaDescriptorExtractor::create(int extractorType)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_DescriptorExtractor_create_10 (int extractorType);
		
				// C++:  int javaDescriptorExtractor::descriptorSize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int features2d_DescriptorExtractor_descriptorSize_10 (IntPtr nativeObj);
		
				// C++:  int javaDescriptorExtractor::descriptorType()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int features2d_DescriptorExtractor_descriptorType_10 (IntPtr nativeObj);
		
				// C++:  bool javaDescriptorExtractor::empty()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_DescriptorExtractor_empty_10 (IntPtr nativeObj);
		
				// C++:  void javaDescriptorExtractor::read(string fileName)
				//		[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorExtractor_read_10 (IntPtr nativeObj, string fileName);
		
				// C++:  void javaDescriptorExtractor::write(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorExtractor_write_10 (IntPtr nativeObj, string fileName);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorExtractor_delete (IntPtr nativeObj);
		#endif
		}
}
