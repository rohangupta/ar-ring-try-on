
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


// C++: class javaGenericDescriptorMatcher
/**
 * <p>Abstract interface for extracting and matching a keypoint descriptor. There
 * are also "DescriptorExtractor" and "DescriptorMatcher" for these purposes but
 * their interfaces are intended for descriptors represented as vectors in a
 * multidimensional space. <code>GenericDescriptorMatcher</code> is a more
 * generic interface for descriptors. <code>DescriptorMatcher</code> and
 * <code>GenericDescriptorMatcher</code> have two groups of match methods: for
 * matching keypoints of an image with another image or with an image set.</p>
 *
 * <p>class GenericDescriptorMatcher <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>GenericDescriptorMatcher();</p>
 *
 * <p>virtual ~GenericDescriptorMatcher();</p>
 *
 * <p>virtual void add(const vector<Mat>& images,</p>
 *
 * <p>vector<vector<KeyPoint> >& keypoints);</p>
 *
 * <p>const vector<Mat>& getTrainImages() const;</p>
 *
 * <p>const vector<vector<KeyPoint> >& getTrainKeypoints() const;</p>
 *
 * <p>virtual void clear();</p>
 *
 * <p>virtual void train() = 0;</p>
 *
 * <p>virtual bool isMaskSupported() = 0;</p>
 *
 * <p>void classify(const Mat& queryImage,</p>
 *
 * <p>vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>const Mat& trainImage,</p>
 *
 * <p>vector<KeyPoint>& trainKeypoints) const;</p>
 *
 * <p>void classify(const Mat& queryImage,</p>
 *
 * <p>vector<KeyPoint>& queryKeypoints);</p>
 *
 * <p>/ *</p>
 * <ul>
 *   <li> Group of methods to match keypoints from an image pair.
 *   <li> /
 * </ul>
 *
 * <p>void match(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
 *
 * <p>vector<DMatch>& matches, const Mat& mask=Mat()) const;</p>
 *
 * <p>void knnMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
 *
 * <p>vector<vector<DMatch> >& matches, int k,</p>
 *
 * <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
 *
 * <p>void radiusMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
 *
 * <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
 *
 * <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
 *
 * <p>/ *</p>
 * <ul>
 *   <li> Group of methods to match keypoints from one image to an image set.
 *   <li> /
 * </ul>
 *
 * <p>void match(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>vector<DMatch>& matches, const vector<Mat>& masks=vector<Mat>());</p>
 *
 * <p>void knnMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>vector<vector<DMatch> >& matches, int k,</p>
 *
 * <p>const vector<Mat>& masks=vector<Mat>(), bool compactResult=false);</p>
 *
 * <p>void radiusMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
 *
 * <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
 *
 * <p>const vector<Mat>& masks=vector<Mat>(), bool compactResult=false);</p>
 *
 * <p>virtual void read(const FileNode&);</p>
 *
 * <p>virtual void write(FileStorage&) const;</p>
 *
 * <p>virtual Ptr<GenericDescriptorMatcher> clone(bool emptyTrainData=false) const
 * = 0;</p>
 *
 * <p>protected:...</p>
 *
 * <p>};</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher">org.opencv.features2d.GenericDescriptorMatcher</a>
 */
		public class GenericDescriptorMatcher : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												features2d_GenericDescriptorMatcher_delete (nativeObj);
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
				protected GenericDescriptorMatcher (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int ONEWAY = 1;
				public const int FERN = 2;
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::add(vector_Mat images, vector_vector_KeyPoint keypoints)
				//
	
				/**
 * <p>Adds images and their keypoints to the training collection stored in the
 * class instance.</p>
 *
 * @param images Image collection.
 * @param keypoints Point collection. It is assumed that <code>keypoints[i]</code>
 * are keypoints detected in the image <code>images[i]</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-add">org.opencv.features2d.GenericDescriptorMatcher.add</a>
 */
				public  void add (List<Mat> images, List<MatOfKeyPoint> keypoints)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						List<Mat> keypoints_tmplm = new List<Mat> ((keypoints != null) ? keypoints.Count : 0);
						Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat (keypoints, keypoints_tmplm);
						features2d_GenericDescriptorMatcher_add_10 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints)
				//
	
				/**
 * <p>Classifies keypoints from a query set.</p>
 *
 * <p>The method classifies each keypoint from a query set. The first variant of
 * the method takes a train image and its keypoints as an input argument. The
 * second variant uses the internally stored training collection that can be
 * built using the <code>GenericDescriptorMatcher.add</code> method.</p>
 *
 * <p>The methods do the following:</p>
 * <ul>
 *   <li> Call the <code>GenericDescriptorMatcher.match</code> method to find
 * correspondence between the query set and the training set.
 *   <li> Set the <code>class_id</code> field of each keypoint from the query
 * set to <code>class_id</code> of the corresponding keypoint from the training
 * set.
 * </ul>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints from a query image.
 * @param trainImage Train image.
 * @param trainKeypoints Keypoints from a train image.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-classify">org.opencv.features2d.GenericDescriptorMatcher.classify</a>
 */
				public  void classify (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						features2d_GenericDescriptorMatcher_classify_10 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints)
				//
	
				/**
 * <p>Classifies keypoints from a query set.</p>
 *
 * <p>The method classifies each keypoint from a query set. The first variant of
 * the method takes a train image and its keypoints as an input argument. The
 * second variant uses the internally stored training collection that can be
 * built using the <code>GenericDescriptorMatcher.add</code> method.</p>
 *
 * <p>The methods do the following:</p>
 * <ul>
 *   <li> Call the <code>GenericDescriptorMatcher.match</code> method to find
 * correspondence between the query set and the training set.
 *   <li> Set the <code>class_id</code> field of each keypoint from the query
 * set to <code>class_id</code> of the corresponding keypoint from the training
 * set.
 * </ul>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints from a query image.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-classify">org.opencv.features2d.GenericDescriptorMatcher.classify</a>
 */
				public  void classify (Mat queryImage, MatOfKeyPoint queryKeypoints)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						features2d_GenericDescriptorMatcher_classify_11 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::clear()
				//
	
				/**
 * <p>Clears a train collection (images and keypoints).</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-clear">org.opencv.features2d.GenericDescriptorMatcher.clear</a>
 */
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_GenericDescriptorMatcher_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::jclone(bool emptyTrainData = false)
				//
	
				public  GenericDescriptorMatcher clone (bool emptyTrainData)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						GenericDescriptorMatcher retVal = new GenericDescriptorMatcher (features2d_GenericDescriptorMatcher_clone_10 (nativeObj, emptyTrainData));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
				public  GenericDescriptorMatcher clone ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						GenericDescriptorMatcher retVal = new GenericDescriptorMatcher (features2d_GenericDescriptorMatcher_clone_11 (nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++: static javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::create(int matcherType)
				//
	
				public static GenericDescriptorMatcher create (int matcherType)
				{

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						GenericDescriptorMatcher retVal = new GenericDescriptorMatcher (features2d_GenericDescriptorMatcher_create_10 (matcherType));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  bool javaGenericDescriptorMatcher::empty()
				//
	
				public  bool empty ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_GenericDescriptorMatcher_empty_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  vector_Mat javaGenericDescriptorMatcher::getTrainImages()
				//
	
				/**
 * <p>Returns a train image collection.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-gettrainimages">org.opencv.features2d.GenericDescriptorMatcher.getTrainImages</a>
 */
				public  List<Mat> getTrainImages ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						List<Mat> retVal = new List<Mat> ();
						Mat retValMat = new Mat (features2d_GenericDescriptorMatcher_getTrainImages_10 (nativeObj));
						Converters.Mat_to_vector_Mat (retValMat, retVal);
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  vector_vector_KeyPoint javaGenericDescriptorMatcher::getTrainKeypoints()
				//
	
				/**
 * <p>Returns a train keypoints collection.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-gettrainkeypoints">org.opencv.features2d.GenericDescriptorMatcher.getTrainKeypoints</a>
 */
				public  List<MatOfKeyPoint> getTrainKeypoints ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						List<MatOfKeyPoint> retVal = new List<MatOfKeyPoint> ();
						Mat retValMat = new Mat (features2d_GenericDescriptorMatcher_getTrainKeypoints_10 (nativeObj));
						Converters.Mat_to_vector_vector_KeyPoint (retValMat, retVal);
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  bool javaGenericDescriptorMatcher::isMaskSupported()
				//
	
				/**
 * <p>Returns <code>true</code> if a generic descriptor matcher supports masking
 * permissible matches.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-ismasksupported">org.opencv.features2d.GenericDescriptorMatcher.isMaskSupported</a>
 */
				public  bool isMaskSupported ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_GenericDescriptorMatcher_isMaskSupported_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				//
	
				/**
 * <p>Finds the <code>k</code> best matches for each query keypoint.</p>
 *
 * <p>The methods are extended variants of <code>GenericDescriptorMatch.match</code>.
 * The parameters are similar, and the semantics is similar to <code>DescriptorMatcher.knnMatch</code>.
 * But this class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param trainImage a trainImage
 * @param trainKeypoints a trainKeypoints
 * @param matches a matches
 * @param k a k
 * @param mask a mask
 * @param compactResult a compactResult
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-knnmatch">org.opencv.features2d.GenericDescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_knnMatch_10 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the <code>k</code> best matches for each query keypoint.</p>
 *
 * <p>The methods are extended variants of <code>GenericDescriptorMatch.match</code>.
 * The parameters are similar, and the semantics is similar to <code>DescriptorMatcher.knnMatch</code>.
 * But this class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param trainImage a trainImage
 * @param trainKeypoints a trainKeypoints
 * @param matches a matches
 * @param k a k
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-knnmatch">org.opencv.features2d.GenericDescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, int k)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_knnMatch_11 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, k);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				//
	
				/**
 * <p>Finds the <code>k</code> best matches for each query keypoint.</p>
 *
 * <p>The methods are extended variants of <code>GenericDescriptorMatch.match</code>.
 * The parameters are similar, and the semantics is similar to <code>DescriptorMatcher.knnMatch</code>.
 * But this class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param matches a matches
 * @param k a k
 * @param masks a masks
 * @param compactResult a compactResult
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-knnmatch">org.opencv.features2d.GenericDescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = new Mat ();
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_GenericDescriptorMatcher_knnMatch_12 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the <code>k</code> best matches for each query keypoint.</p>
 *
 * <p>The methods are extended variants of <code>GenericDescriptorMatch.match</code>.
 * The parameters are similar, and the semantics is similar to <code>DescriptorMatcher.knnMatch</code>.
 * But this class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param matches a matches
 * @param k a k
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-knnmatch">org.opencv.features2d.GenericDescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, int k)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_knnMatch_13 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, k);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_DMatch& matches, Mat mask = Mat())
				//
	
				/**
 * <p>Finds the best match in the training set for each keypoint from the query
 * set.</p>
 *
 * <p>The methods find the best match for each query keypoint. In the first variant
 * of the method, a train image and its keypoints are the input arguments. In
 * the second variant, query keypoints are matched to the internally stored
 * training collection that can be built using the <code>GenericDescriptorMatcher.add</code>
 * method. Optional mask (or masks) can be passed to specify which query and
 * training descriptors can be matched. Namely, <code>queryKeypoints[i]</code>
 * can be matched with <code>trainKeypoints[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints detected in <code>queryImage</code>.
 * @param trainImage Train image. It is not added to a train image collection
 * stored in the class object.
 * @param trainKeypoints Keypoints detected in <code>trainImage</code>. They are
 * not added to a train points collection stored in the class object.
 * @param matches Matches. If a query descriptor (keypoint) is masked out in
 * <code>mask</code>, match is added for this descriptor. So, <code>matches</code>
 * size may be smaller than the query keypoints count.
 * @param mask Mask specifying permissible matches between an input query and
 * train keypoints.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-match">org.opencv.features2d.GenericDescriptorMatcher.match</a>
 */
				public  void match (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, MatOfDMatch matches, Mat mask)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = matches;
						features2d_GenericDescriptorMatcher_match_10 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, mask.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the best match in the training set for each keypoint from the query
 * set.</p>
 *
 * <p>The methods find the best match for each query keypoint. In the first variant
 * of the method, a train image and its keypoints are the input arguments. In
 * the second variant, query keypoints are matched to the internally stored
 * training collection that can be built using the <code>GenericDescriptorMatcher.add</code>
 * method. Optional mask (or masks) can be passed to specify which query and
 * training descriptors can be matched. Namely, <code>queryKeypoints[i]</code>
 * can be matched with <code>trainKeypoints[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints detected in <code>queryImage</code>.
 * @param trainImage Train image. It is not added to a train image collection
 * stored in the class object.
 * @param trainKeypoints Keypoints detected in <code>trainImage</code>. They are
 * not added to a train points collection stored in the class object.
 * @param matches Matches. If a query descriptor (keypoint) is masked out in
 * <code>mask</code>, match is added for this descriptor. So, <code>matches</code>
 * size may be smaller than the query keypoints count.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-match">org.opencv.features2d.GenericDescriptorMatcher.match</a>
 */
				public  void match (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, MatOfDMatch matches)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = matches;
						features2d_GenericDescriptorMatcher_match_11 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
				//
	
				/**
 * <p>Finds the best match in the training set for each keypoint from the query
 * set.</p>
 *
 * <p>The methods find the best match for each query keypoint. In the first variant
 * of the method, a train image and its keypoints are the input arguments. In
 * the second variant, query keypoints are matched to the internally stored
 * training collection that can be built using the <code>GenericDescriptorMatcher.add</code>
 * method. Optional mask (or masks) can be passed to specify which query and
 * training descriptors can be matched. Namely, <code>queryKeypoints[i]</code>
 * can be matched with <code>trainKeypoints[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints detected in <code>queryImage</code>.
 * @param matches Matches. If a query descriptor (keypoint) is masked out in
 * <code>mask</code>, match is added for this descriptor. So, <code>matches</code>
 * size may be smaller than the query keypoints count.
 * @param masks Set of masks. Each <code>masks[i]</code> specifies permissible
 * matches between input query keypoints and stored train keypoints from the
 * i-th image.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-match">org.opencv.features2d.GenericDescriptorMatcher.match</a>
 */
				public  void match (Mat queryImage, MatOfKeyPoint queryKeypoints, MatOfDMatch matches, List<Mat> masks)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = matches;
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_GenericDescriptorMatcher_match_12 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the best match in the training set for each keypoint from the query
 * set.</p>
 *
 * <p>The methods find the best match for each query keypoint. In the first variant
 * of the method, a train image and its keypoints are the input arguments. In
 * the second variant, query keypoints are matched to the internally stored
 * training collection that can be built using the <code>GenericDescriptorMatcher.add</code>
 * method. Optional mask (or masks) can be passed to specify which query and
 * training descriptors can be matched. Namely, <code>queryKeypoints[i]</code>
 * can be matched with <code>trainKeypoints[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryImage Query image.
 * @param queryKeypoints Keypoints detected in <code>queryImage</code>.
 * @param matches Matches. If a query descriptor (keypoint) is masked out in
 * <code>mask</code>, match is added for this descriptor. So, <code>matches</code>
 * size may be smaller than the query keypoints count.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-match">org.opencv.features2d.GenericDescriptorMatcher.match</a>
 */
				public  void match (Mat queryImage, MatOfKeyPoint queryKeypoints, MatOfDMatch matches)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = matches;
						features2d_GenericDescriptorMatcher_match_13 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				//
	
				/**
 * <p>For each query keypoint, finds the training keypoints not farther than the
 * specified distance.</p>
 *
 * <p>The methods are similar to <code>DescriptorMatcher.radius</code>. But this
 * class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param trainImage a trainImage
 * @param trainKeypoints a trainKeypoints
 * @param matches a matches
 * @param maxDistance a maxDistance
 * @param mask a mask
 * @param compactResult a compactResult
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-radiusmatch">org.opencv.features2d.GenericDescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_radiusMatch_10 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>For each query keypoint, finds the training keypoints not farther than the
 * specified distance.</p>
 *
 * <p>The methods are similar to <code>DescriptorMatcher.radius</code>. But this
 * class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param trainImage a trainImage
 * @param trainKeypoints a trainKeypoints
 * @param matches a matches
 * @param maxDistance a maxDistance
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-radiusmatch">org.opencv.features2d.GenericDescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, float maxDistance)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						if (trainImage != null)
								trainImage.ThrowIfDisposed ();
						if (trainKeypoints != null)
								trainKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat trainKeypoints_mat = trainKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_radiusMatch_11 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				//
	
				/**
 * <p>For each query keypoint, finds the training keypoints not farther than the
 * specified distance.</p>
 *
 * <p>The methods are similar to <code>DescriptorMatcher.radius</code>. But this
 * class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param matches a matches
 * @param maxDistance a maxDistance
 * @param masks a masks
 * @param compactResult a compactResult
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-radiusmatch">org.opencv.features2d.GenericDescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = new Mat ();
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_GenericDescriptorMatcher_radiusMatch_12 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>For each query keypoint, finds the training keypoints not farther than the
 * specified distance.</p>
 *
 * <p>The methods are similar to <code>DescriptorMatcher.radius</code>. But this
 * class does not require explicitly computed keypoint descriptors.</p>
 *
 * @param queryImage a queryImage
 * @param queryKeypoints a queryKeypoints
 * @param matches a matches
 * @param maxDistance a maxDistance
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-radiusmatch">org.opencv.features2d.GenericDescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, float maxDistance)
				{
						if (queryImage != null)
								queryImage.ThrowIfDisposed ();
						if (queryKeypoints != null)
								queryKeypoints.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat queryKeypoints_mat = queryKeypoints;
						Mat matches_mat = new Mat ();
						features2d_GenericDescriptorMatcher_radiusMatch_13 (nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::read(string fileName)
				//
	
				/**
 * <p>Reads a matcher object from a file node.</p>
 *
 * @param fileName a fileName
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-read">org.opencv.features2d.GenericDescriptorMatcher.read</a>
 */
				public  void read (string fileName)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_GenericDescriptorMatcher_read_10 (nativeObj, fileName);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::train()
				//
	
				/**
 * <p>Trains descriptor matcher</p>
 *
 * <p>Prepares descriptor matcher, for example, creates a tree-based structure, to
 * extract descriptors or to optimize descriptors matching.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-train">org.opencv.features2d.GenericDescriptorMatcher.train</a>
 */
				public  void train ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_GenericDescriptorMatcher_train_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaGenericDescriptorMatcher::write(string fileName)
				//
	
				/**
 * <p>Writes a match object to a file storage.</p>
 *
 * @param fileName a fileName
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher-write">org.opencv.features2d.GenericDescriptorMatcher.write</a>
 */
				public  void write (string fileName)
				{
						ThrowIfDisposed ();
		
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_GenericDescriptorMatcher_write_10 (nativeObj, fileName);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			features2d_GenericDescriptorMatcher_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void javaGenericDescriptorMatcher::add(vector_Mat images, vector_vector_KeyPoint keypoints)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_add_10(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_classify_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_classify_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_clear_10(IntPtr nativeObj);
		
		// C++:  javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::jclone(bool emptyTrainData = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_GenericDescriptorMatcher_clone_10(IntPtr nativeObj, bool emptyTrainData);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_GenericDescriptorMatcher_clone_11(IntPtr nativeObj);
		
		// C++: static javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::create(int matcherType)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_GenericDescriptorMatcher_create_10(int matcherType);
		
		// C++:  bool javaGenericDescriptorMatcher::empty()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_GenericDescriptorMatcher_empty_10(IntPtr nativeObj);
		
		// C++:  vector_Mat javaGenericDescriptorMatcher::getTrainImages()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_GenericDescriptorMatcher_getTrainImages_10(IntPtr nativeObj);
		
		// C++:  vector_vector_KeyPoint javaGenericDescriptorMatcher::getTrainKeypoints()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_GenericDescriptorMatcher_getTrainKeypoints_10(IntPtr nativeObj);
		
		// C++:  bool javaGenericDescriptorMatcher::isMaskSupported()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_GenericDescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
		// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
		// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_DMatch& matches, Mat mask = Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
		// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
		// C++:  void javaGenericDescriptorMatcher::read(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_read_10(IntPtr nativeObj, string fileName);
		
		// C++:  void javaGenericDescriptorMatcher::train()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_train_10(IntPtr nativeObj);
		
		// C++:  void javaGenericDescriptorMatcher::write(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_write_10(IntPtr nativeObj, string fileName);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_GenericDescriptorMatcher_delete(IntPtr nativeObj);

#else
		
				// C++:  void javaGenericDescriptorMatcher::add(vector_Mat images, vector_vector_KeyPoint keypoints)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_add_10 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_classify_10 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_classify_11 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_clear_10 (IntPtr nativeObj);
		
				// C++:  javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::jclone(bool emptyTrainData = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_GenericDescriptorMatcher_clone_10 (IntPtr nativeObj, bool emptyTrainData);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_GenericDescriptorMatcher_clone_11 (IntPtr nativeObj);
		
				// C++: static javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::create(int matcherType)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_GenericDescriptorMatcher_create_10 (int matcherType);
		
				// C++:  bool javaGenericDescriptorMatcher::empty()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_GenericDescriptorMatcher_empty_10 (IntPtr nativeObj);
		
				// C++:  vector_Mat javaGenericDescriptorMatcher::getTrainImages()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_GenericDescriptorMatcher_getTrainImages_10 (IntPtr nativeObj);
		
				// C++:  vector_vector_KeyPoint javaGenericDescriptorMatcher::getTrainKeypoints()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_GenericDescriptorMatcher_getTrainKeypoints_10 (IntPtr nativeObj);
		
				// C++:  bool javaGenericDescriptorMatcher::isMaskSupported()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_GenericDescriptorMatcher_isMaskSupported_10 (IntPtr nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_knnMatch_10 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_knnMatch_11 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
				// C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_knnMatch_12 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_knnMatch_13 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
				// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_DMatch& matches, Mat mask = Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_match_10 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_match_11 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_match_12 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_match_13 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_radiusMatch_10 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_radiusMatch_11 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
				// C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_radiusMatch_12 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_radiusMatch_13 (IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
				// C++:  void javaGenericDescriptorMatcher::read(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_read_10 (IntPtr nativeObj, string fileName);
		
				// C++:  void javaGenericDescriptorMatcher::train()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_train_10 (IntPtr nativeObj);
		
				// C++:  void javaGenericDescriptorMatcher::write(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_write_10 (IntPtr nativeObj, string fileName);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_GenericDescriptorMatcher_delete (IntPtr nativeObj);
		#endif
		}
}