
using System;
using System.Runtime.InteropServices;

//
// This file is auto-generated. Please don't modify it!
//
namespace OpenCVForUnity
{
	
// C++: class CascadeClassifier
/**
 * <p>Cascade classifier class for object detection.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier">org.opencv.objdetect.CascadeClassifier</a>
 */
		public class CascadeClassifier : DisposableOpenCVObject
		{
	

				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												objdetect_CascadeClassifier_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
			return;
						#endif
				}

//				protected readonly IntPtr nativeObj;

				protected CascadeClassifier (IntPtr addr)
				{
						nativeObj = addr;
				}
	
	
				//
				// C++:   CascadeClassifier::CascadeClassifier()
				//
	
				/**
 * <p>Loads a classifier from a file.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-cascadeclassifier">org.opencv.objdetect.CascadeClassifier.CascadeClassifier</a>
 */
				public   CascadeClassifier ()
				{

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_CascadeClassifier_CascadeClassifier_10 ();
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:   CascadeClassifier::CascadeClassifier(string filename)
				//
	
				/**
 * <p>Loads a classifier from a file.</p>
 *
 * @param filename Name of the file from which the classifier is loaded.
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-cascadeclassifier">org.opencv.objdetect.CascadeClassifier.CascadeClassifier</a>
 */
				public   CascadeClassifier (string filename)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = objdetect_CascadeClassifier_CascadeClassifier_11 (filename);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
				//
	
				/**
 * <p>Detects objects of different sizes in the input image. The detected objects
 * are returned as a list of rectangles.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) A face detection example using cascade classifiers can be
 * found at opencv_source_code/samples/python2/facedetect.py
 * </ul>
 *
 * @param image Matrix of the type <code>CV_8U</code> containing an image where
 * objects are detected.
 * @param objects Vector of rectangles where each rectangle contains the
 * detected object.
 * @param scaleFactor Parameter specifying how much the image size is reduced at
 * each image scale.
 * @param minNeighbors Parameter specifying how many neighbors each candidate
 * rectangle should have to retain it.
 * @param flags Parameter with the same meaning for an old cascade as in the
 * function <code>cvHaarDetectObjects</code>. It is not used for a new cascade.
 * @param minSize Minimum possible object size. Objects smaller than that are
 * ignored.
 * @param maxSize Maximum possible object size. Objects larger than that are
 * ignored.
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-detectmultiscale">org.opencv.objdetect.CascadeClassifier.detectMultiScale</a>
 */
				public  void detectMultiScale (Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (objects != null)
								objects.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat objects_mat = objects;
						objdetect_CascadeClassifier_detectMultiScale_10 (nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Detects objects of different sizes in the input image. The detected objects
 * are returned as a list of rectangles.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) A face detection example using cascade classifiers can be
 * found at opencv_source_code/samples/python2/facedetect.py
 * </ul>
 *
 * @param image Matrix of the type <code>CV_8U</code> containing an image where
 * objects are detected.
 * @param objects Vector of rectangles where each rectangle contains the
 * detected object.
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-detectmultiscale">org.opencv.objdetect.CascadeClassifier.detectMultiScale</a>
 */
				public  void detectMultiScale (Mat image, MatOfRect objects)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (objects != null)
								objects.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat objects_mat = objects;
						objdetect_CascadeClassifier_detectMultiScale_11 (nativeObj, image.nativeObj, objects_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int rejectLevels, vector_double levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
				//
	
				/**
 * <p>Detects objects of different sizes in the input image. The detected objects
 * are returned as a list of rectangles.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) A face detection example using cascade classifiers can be
 * found at opencv_source_code/samples/python2/facedetect.py
 * </ul>
 *
 * @param image Matrix of the type <code>CV_8U</code> containing an image where
 * objects are detected.
 * @param objects Vector of rectangles where each rectangle contains the
 * detected object.
 * @param rejectLevels a rejectLevels
 * @param levelWeights a levelWeights
 * @param scaleFactor Parameter specifying how much the image size is reduced at
 * each image scale.
 * @param minNeighbors Parameter specifying how many neighbors each candidate
 * rectangle should have to retain it.
 * @param flags Parameter with the same meaning for an old cascade as in the
 * function <code>cvHaarDetectObjects</code>. It is not used for a new cascade.
 * @param minSize Minimum possible object size. Objects smaller than that are
 * ignored.
 * @param maxSize Maximum possible object size. Objects larger than that are
 * ignored.
 * @param outputRejectLevels a outputRejectLevels
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-detectmultiscale">org.opencv.objdetect.CascadeClassifier.detectMultiScale</a>
 */
				public  void detectMultiScale (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (objects != null)
								objects.ThrowIfDisposed ();
						if (rejectLevels != null)
								rejectLevels.ThrowIfDisposed ();
						if (levelWeights != null)
								levelWeights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat objects_mat = objects;
						Mat rejectLevels_mat = rejectLevels;
						Mat levelWeights_mat = levelWeights;
						objdetect_CascadeClassifier_detectMultiScale_12 (nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Detects objects of different sizes in the input image. The detected objects
 * are returned as a list of rectangles.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) A face detection example using cascade classifiers can be
 * found at opencv_source_code/samples/python2/facedetect.py
 * </ul>
 *
 * @param image Matrix of the type <code>CV_8U</code> containing an image where
 * objects are detected.
 * @param objects Vector of rectangles where each rectangle contains the
 * detected object.
 * @param rejectLevels a rejectLevels
 * @param levelWeights a levelWeights
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-detectmultiscale">org.opencv.objdetect.CascadeClassifier.detectMultiScale</a>
 */
				public  void detectMultiScale (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (objects != null)
								objects.ThrowIfDisposed ();
						if (rejectLevels != null)
								rejectLevels.ThrowIfDisposed ();
						if (levelWeights != null)
								levelWeights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat objects_mat = objects;
						Mat rejectLevels_mat = rejectLevels;
						Mat levelWeights_mat = levelWeights;
						objdetect_CascadeClassifier_detectMultiScale_13 (nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  bool CascadeClassifier::empty()
				//
	
				/**
 * <p>Checks whether the classifier has been loaded.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-empty">org.opencv.objdetect.CascadeClassifier.empty</a>
 */
				public  bool empty ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_CascadeClassifier_empty_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  bool CascadeClassifier::load(string filename)
				//
	
				/**
 * <p>Loads a classifier from a file.</p>
 *
 * @param filename Name of the file from which the classifier is loaded. The
 * file may contain an old HAAR classifier trained by the haartraining
 * application or a new cascade classifier trained by the traincascade
 * application.
 *
 * @see <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier-load">org.opencv.objdetect.CascadeClassifier.load</a>
 */
				public  bool load (string filename)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = objdetect_CascadeClassifier_load_10 (nativeObj, filename);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//		delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CascadeClassifier::CascadeClassifier()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10 ();
		
		// C++:   CascadeClassifier::CascadeClassifier(string filename)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11 (string filename);
		
		// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);
		
		// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int rejectLevels, vector_double levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_12 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_13 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);
		
		// C++:  bool CascadeClassifier::empty()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_CascadeClassifier_empty_10 (IntPtr nativeObj);
		
		// C++:  bool CascadeClassifier::load(string filename)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool objdetect_CascadeClassifier_load_10 (IntPtr nativeObj, string filename);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void objdetect_CascadeClassifier_delete (IntPtr nativeObj);

#else
		
				// C++:   CascadeClassifier::CascadeClassifier()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10 ();
		
				// C++:   CascadeClassifier::CascadeClassifier(string filename)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11 (string filename);
		
				// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_CascadeClassifier_detectMultiScale_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_CascadeClassifier_detectMultiScale_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);
		
				// C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int rejectLevels, vector_double levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_CascadeClassifier_detectMultiScale_12 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_CascadeClassifier_detectMultiScale_13 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);
		
				// C++:  bool CascadeClassifier::empty()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_CascadeClassifier_empty_10 (IntPtr nativeObj);
		
				// C++:  bool CascadeClassifier::load(string filename)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool objdetect_CascadeClassifier_load_10 (IntPtr nativeObj, string filename);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void objdetect_CascadeClassifier_delete (IntPtr nativeObj);
		#endif
		}
}
