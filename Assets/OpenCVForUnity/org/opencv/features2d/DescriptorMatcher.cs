
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


// C++: class javaDescriptorMatcher
/**
 * <p>Abstract base class for matching keypoint descriptors. It has two groups of
 * match methods: for matching descriptors of an image with another image or
 * with an image set.</p>
 *
 * <p>class DescriptorMatcher <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>virtual ~DescriptorMatcher();</p>
 *
 * <p>virtual void add(const vector<Mat>& descriptors);</p>
 *
 * <p>const vector<Mat>& getTrainDescriptors() const;</p>
 *
 * <p>virtual void clear();</p>
 *
 * <p>bool empty() const;</p>
 *
 * <p>virtual bool isMaskSupported() const = 0;</p>
 *
 * <p>virtual void train();</p>
 *
 * <p>/ *</p>
 * <ul>
 *   <li> Group of methods to match descriptors from an image pair.
 *   <li> /
 * </ul>
 *
 * <p>void match(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
 *
 * <p>vector<DMatch>& matches, const Mat& mask=Mat()) const;</p>
 *
 * <p>void knnMatch(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
 *
 * <p>vector<vector<DMatch> >& matches, int k,</p>
 *
 * <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
 *
 * <p>void radiusMatch(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
 *
 * <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
 *
 * <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
 *
 * <p>/ *</p>
 * <ul>
 *   <li> Group of methods to match descriptors from one image to an image set.
 *   <li> /
 * </ul>
 *
 * <p>void match(const Mat& queryDescriptors, vector<DMatch>& matches,</p>
 *
 * <p>const vector<Mat>& masks=vector<Mat>());</p>
 *
 * <p>void knnMatch(const Mat& queryDescriptors, vector<vector<DMatch> >& matches,</p>
 *
 * <p>int k, const vector<Mat>& masks=vector<Mat>(),</p>
 *
 * <p>bool compactResult=false);</p>
 *
 * <p>void radiusMatch(const Mat& queryDescriptors, vector<vector<DMatch> >&
 * matches,</p>
 *
 * <p>float maxDistance, const vector<Mat>& masks=vector<Mat>(),</p>
 *
 * <p>bool compactResult=false);</p>
 *
 * <p>virtual void read(const FileNode&);</p>
 *
 * <p>virtual void write(FileStorage&) const;</p>
 *
 * <p>virtual Ptr<DescriptorMatcher> clone(bool emptyTrainData=false) const = 0;</p>
 *
 * <p>static Ptr<DescriptorMatcher> create(const string& descriptorMatcherType);</p>
 *
 * <p>protected:</p>
 *
 * <p>vector<Mat> trainDescCollection;...</p>
 *
 * <p>};</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher">org.opencv.features2d.DescriptorMatcher : public Algorithm</a>
 */
		public class DescriptorMatcher : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												features2d_DescriptorMatcher_delete (nativeObj);
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
				protected DescriptorMatcher (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int FLANNBASED = 1;
				public const int BRUTEFORCE = 2;
				public const int BRUTEFORCE_L1 = 3;
				public const int BRUTEFORCE_HAMMING = 4;
				public const int BRUTEFORCE_HAMMINGLUT = 5;
				public const int BRUTEFORCE_SL2 = 6;
	
	
				//
				// C++:  void javaDescriptorMatcher::add(vector_Mat descriptors)
				//
	
				/**
 * <p>Adds descriptors to train a descriptor collection. If the collection
 * <code>trainDescCollectionis</code> is not empty, the new descriptors are
 * added to existing train descriptors.</p>
 *
 * @param descriptors Descriptors to add. Each <code>descriptors[i]</code> is a
 * set of descriptors from the same train image.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-add">org.opencv.features2d.DescriptorMatcher.add</a>
 */
				public  void add (List<Mat> descriptors)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat descriptors_mat = Converters.vector_Mat_to_Mat (descriptors);
						features2d_DescriptorMatcher_add_10 (nativeObj, descriptors_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::clear()
				//
	
				/**
 * <p>Clears the train descriptor collection.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-clear">org.opencv.features2d.DescriptorMatcher.clear</a>
 */
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorMatcher_clear_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  javaDescriptorMatcher* javaDescriptorMatcher::jclone(bool emptyTrainData = false)
				//
	
				public  DescriptorMatcher clone (bool emptyTrainData)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						DescriptorMatcher retVal = new DescriptorMatcher (features2d_DescriptorMatcher_clone_10 (nativeObj, emptyTrainData));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
				public  DescriptorMatcher clone ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						DescriptorMatcher retVal = new DescriptorMatcher (features2d_DescriptorMatcher_clone_11 (nativeObj));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++: static javaDescriptorMatcher* javaDescriptorMatcher::create(int matcherType)
				//
	
				/**
 * <p>Creates a descriptor matcher of a given type with the default parameters
 * (using default constructor).</p>
 *
 * @param matcherType a matcherType
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-create">org.opencv.features2d.DescriptorMatcher.create</a>
 */
				public static DescriptorMatcher create (int matcherType)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						DescriptorMatcher retVal = new DescriptorMatcher (features2d_DescriptorMatcher_create_10 (matcherType));
		
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  bool javaDescriptorMatcher::empty()
				//
	
				/**
 * <p>Returns true if there are no train descriptors in the collection.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-empty">org.opencv.features2d.DescriptorMatcher.empty</a>
 */
				public  bool empty ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_DescriptorMatcher_empty_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  vector_Mat javaDescriptorMatcher::getTrainDescriptors()
				//
	
				/**
 * <p>Returns a constant link to the train descriptor collection <code>trainDescCollection</code>.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-gettraindescriptors">org.opencv.features2d.DescriptorMatcher.getTrainDescriptors</a>
 */
				public  List<Mat> getTrainDescriptors ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						List<Mat> retVal = new List<Mat> ();
						Mat retValMat = new Mat (features2d_DescriptorMatcher_getTrainDescriptors_10 (nativeObj));
						Converters.Mat_to_vector_Mat (retValMat, retVal);
						return retVal;
						#else
			return null;
						#endif
				}
	
	
				//
				// C++:  bool javaDescriptorMatcher::isMaskSupported()
				//
	
				/**
 * <p>Returns true if the descriptor matcher supports masking permissible matches.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-ismasksupported">org.opencv.features2d.DescriptorMatcher.isMaskSupported</a>
 */
				public  bool isMaskSupported ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = features2d_DescriptorMatcher_isMaskSupported_10 (nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				//
	
				/**
 * <p>Finds the k best matches for each descriptor from a query set.</p>
 *
 * <p>These extended variants of "DescriptorMatcher.match" methods find several
 * best matches for each query descriptor. The matches are returned in the
 * distance increasing order. See "DescriptorMatcher.match" for the details
 * about query and train descriptors.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Matches. Each <code>matches[i]</code> is k or less matches for
 * the same query descriptor.
 * @param k Count of best matches found per each query descriptor or less if a
 * query descriptor has less than k possible matches in total.
 * @param mask Mask specifying permissible matches between an input query and
 * train matrices of descriptors.
 * @param compactResult Parameter used when the mask (or masks) is not empty. If
 * <code>compactResult</code> is false, the <code>matches</code> vector has the
 * same size as <code>queryDescriptors</code> rows. If <code>compactResult</code>
 * is true, the <code>matches</code> vector does not contain matches for fully
 * masked-out query descriptors.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-knnmatch">org.opencv.features2d.DescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_knnMatch_10 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the k best matches for each descriptor from a query set.</p>
 *
 * <p>These extended variants of "DescriptorMatcher.match" methods find several
 * best matches for each query descriptor. The matches are returned in the
 * distance increasing order. See "DescriptorMatcher.match" for the details
 * about query and train descriptors.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Matches. Each <code>matches[i]</code> is k or less matches for
 * the same query descriptor.
 * @param k Count of best matches found per each query descriptor or less if a
 * query descriptor has less than k possible matches in total.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-knnmatch">org.opencv.features2d.DescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_knnMatch_11 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				//
	
				/**
 * <p>Finds the k best matches for each descriptor from a query set.</p>
 *
 * <p>These extended variants of "DescriptorMatcher.match" methods find several
 * best matches for each query descriptor. The matches are returned in the
 * distance increasing order. See "DescriptorMatcher.match" for the details
 * about query and train descriptors.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Matches. Each <code>matches[i]</code> is k or less matches for
 * the same query descriptor.
 * @param k Count of best matches found per each query descriptor or less if a
 * query descriptor has less than k possible matches in total.
 * @param masks Set of masks. Each <code>masks[i]</code> specifies permissible
 * matches between the input query descriptors and stored train descriptors from
 * the i-th image <code>trainDescCollection[i]</code>.
 * @param compactResult Parameter used when the mask (or masks) is not empty. If
 * <code>compactResult</code> is false, the <code>matches</code> vector has the
 * same size as <code>queryDescriptors</code> rows. If <code>compactResult</code>
 * is true, the <code>matches</code> vector does not contain matches for fully
 * masked-out query descriptors.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-knnmatch">org.opencv.features2d.DescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_DescriptorMatcher_knnMatch_12 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the k best matches for each descriptor from a query set.</p>
 *
 * <p>These extended variants of "DescriptorMatcher.match" methods find several
 * best matches for each query descriptor. The matches are returned in the
 * distance increasing order. See "DescriptorMatcher.match" for the details
 * about query and train descriptors.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Matches. Each <code>matches[i]</code> is k or less matches for
 * the same query descriptor.
 * @param k Count of best matches found per each query descriptor or less if a
 * query descriptor has less than k possible matches in total.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-knnmatch">org.opencv.features2d.DescriptorMatcher.knnMatch</a>
 */
				public  void knnMatch (Mat queryDescriptors, List<MatOfDMatch> matches, int k)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_knnMatch_13 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
				//
	
				/**
 * <p>Finds the best match for each descriptor from a query set.</p>
 *
 * <p>In the first variant of this method, the train descriptors are passed as an
 * input argument. In the second variant of the method, train descriptors
 * collection that was set by <code>DescriptorMatcher.add</code> is used.
 * Optional mask (or masks) can be passed to specify which query and training
 * descriptors can be matched. Namely, <code>queryDescriptors[i]</code> can be
 * matched with <code>trainDescriptors[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Matches. If a query descriptor is masked out in
 * <code>mask</code>, no match is added for this descriptor. So,
 * <code>matches</code> size may be smaller than the query descriptors count.
 * @param mask Mask specifying permissible matches between an input query and
 * train matrices of descriptors.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-match">org.opencv.features2d.DescriptorMatcher.match</a>
 */
				public  void match (Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches, Mat mask)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = matches;
						features2d_DescriptorMatcher_match_10 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, mask.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the best match for each descriptor from a query set.</p>
 *
 * <p>In the first variant of this method, the train descriptors are passed as an
 * input argument. In the second variant of the method, train descriptors
 * collection that was set by <code>DescriptorMatcher.add</code> is used.
 * Optional mask (or masks) can be passed to specify which query and training
 * descriptors can be matched. Namely, <code>queryDescriptors[i]</code> can be
 * matched with <code>trainDescriptors[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Matches. If a query descriptor is masked out in
 * <code>mask</code>, no match is added for this descriptor. So,
 * <code>matches</code> size may be smaller than the query descriptors count.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-match">org.opencv.features2d.DescriptorMatcher.match</a>
 */
				public  void match (Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = matches;
						features2d_DescriptorMatcher_match_11 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
				//
	
				/**
 * <p>Finds the best match for each descriptor from a query set.</p>
 *
 * <p>In the first variant of this method, the train descriptors are passed as an
 * input argument. In the second variant of the method, train descriptors
 * collection that was set by <code>DescriptorMatcher.add</code> is used.
 * Optional mask (or masks) can be passed to specify which query and training
 * descriptors can be matched. Namely, <code>queryDescriptors[i]</code> can be
 * matched with <code>trainDescriptors[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Matches. If a query descriptor is masked out in
 * <code>mask</code>, no match is added for this descriptor. So,
 * <code>matches</code> size may be smaller than the query descriptors count.
 * @param masks Set of masks. Each <code>masks[i]</code> specifies permissible
 * matches between the input query descriptors and stored train descriptors from
 * the i-th image <code>trainDescCollection[i]</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-match">org.opencv.features2d.DescriptorMatcher.match</a>
 */
				public  void match (Mat queryDescriptors, MatOfDMatch matches, List<Mat> masks)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = matches;
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_DescriptorMatcher_match_12 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>Finds the best match for each descriptor from a query set.</p>
 *
 * <p>In the first variant of this method, the train descriptors are passed as an
 * input argument. In the second variant of the method, train descriptors
 * collection that was set by <code>DescriptorMatcher.add</code> is used.
 * Optional mask (or masks) can be passed to specify which query and training
 * descriptors can be matched. Namely, <code>queryDescriptors[i]</code> can be
 * matched with <code>trainDescriptors[j]</code> only if <code>mask.at<uchar>(i,j)</code>
 * is non-zero.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Matches. If a query descriptor is masked out in
 * <code>mask</code>, no match is added for this descriptor. So,
 * <code>matches</code> size may be smaller than the query descriptors count.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-match">org.opencv.features2d.DescriptorMatcher.match</a>
 */
				public  void match (Mat queryDescriptors, MatOfDMatch matches)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (matches != null)
								matches.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = matches;
						features2d_DescriptorMatcher_match_13 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				//
	
				/**
 * <p>For each query descriptor, finds the training descriptors not farther than
 * the specified distance.</p>
 *
 * <p>For each query descriptor, the methods find such training descriptors that
 * the distance between the query descriptor and the training descriptor is
 * equal or smaller than <code>maxDistance</code>. Found matches are returned in
 * the distance increasing order.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Found matches.
 * @param maxDistance Threshold for the distance between matched descriptors.
 * Distance means here metric distance (e.g. Hamming distance), not the distance
 * between coordinates (which is measured in Pixels)!
 * @param mask Mask specifying permissible matches between an input query and
 * train matrices of descriptors.
 * @param compactResult Parameter used when the mask (or masks) is not empty. If
 * <code>compactResult</code> is false, the <code>matches</code> vector has the
 * same size as <code>queryDescriptors</code> rows. If <code>compactResult</code>
 * is true, the <code>matches</code> vector does not contain matches for fully
 * masked-out query descriptors.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-radiusmatch">org.opencv.features2d.DescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_radiusMatch_10 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>For each query descriptor, finds the training descriptors not farther than
 * the specified distance.</p>
 *
 * <p>For each query descriptor, the methods find such training descriptors that
 * the distance between the query descriptor and the training descriptor is
 * equal or smaller than <code>maxDistance</code>. Found matches are returned in
 * the distance increasing order.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param trainDescriptors Train set of descriptors. This set is not added to
 * the train descriptors collection stored in the class object.
 * @param matches Found matches.
 * @param maxDistance Threshold for the distance between matched descriptors.
 * Distance means here metric distance (e.g. Hamming distance), not the distance
 * between coordinates (which is measured in Pixels)!
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-radiusmatch">org.opencv.features2d.DescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						if (trainDescriptors != null)
								trainDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_radiusMatch_11 (nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				//
	
				/**
 * <p>For each query descriptor, finds the training descriptors not farther than
 * the specified distance.</p>
 *
 * <p>For each query descriptor, the methods find such training descriptors that
 * the distance between the query descriptor and the training descriptor is
 * equal or smaller than <code>maxDistance</code>. Found matches are returned in
 * the distance increasing order.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Found matches.
 * @param maxDistance Threshold for the distance between matched descriptors.
 * Distance means here metric distance (e.g. Hamming distance), not the distance
 * between coordinates (which is measured in Pixels)!
 * @param masks Set of masks. Each <code>masks[i]</code> specifies permissible
 * matches between the input query descriptors and stored train descriptors from
 * the i-th image <code>trainDescCollection[i]</code>.
 * @param compactResult Parameter used when the mask (or masks) is not empty. If
 * <code>compactResult</code> is false, the <code>matches</code> vector has the
 * same size as <code>queryDescriptors</code> rows. If <code>compactResult</code>
 * is true, the <code>matches</code> vector does not contain matches for fully
 * masked-out query descriptors.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-radiusmatch">org.opencv.features2d.DescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
						features2d_DescriptorMatcher_radiusMatch_12 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
				/**
 * <p>For each query descriptor, finds the training descriptors not farther than
 * the specified distance.</p>
 *
 * <p>For each query descriptor, the methods find such training descriptors that
 * the distance between the query descriptor and the training descriptor is
 * equal or smaller than <code>maxDistance</code>. Found matches are returned in
 * the distance increasing order.</p>
 *
 * @param queryDescriptors Query set of descriptors.
 * @param matches Found matches.
 * @param maxDistance Threshold for the distance between matched descriptors.
 * Distance means here metric distance (e.g. Hamming distance), not the distance
 * between coordinates (which is measured in Pixels)!
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-radiusmatch">org.opencv.features2d.DescriptorMatcher.radiusMatch</a>
 */
				public  void radiusMatch (Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance)
				{
						if (queryDescriptors != null)
								queryDescriptors.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat matches_mat = new Mat ();
						features2d_DescriptorMatcher_radiusMatch_13 (nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
						Converters.Mat_to_vector_vector_DMatch (matches_mat, matches);
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::read(string fileName)
				//
	
				public  void read (string fileName)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorMatcher_read_10 (nativeObj, fileName);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::train()
				//
	
				/**
 * <p>Trains a descriptor matcher</p>
 *
 * <p>Trains a descriptor matcher (for example, the flann index). In all methods to
 * match, the method <code>train()</code> is run every time before matching.
 * Some descriptor matchers (for example, <code>BruteForceMatcher</code>) have
 * an empty implementation of this method. Other matchers really train their
 * inner structures (for example, <code>FlannBasedMatcher</code> trains
 * <code>flann.Index</code>).</p>
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-train">org.opencv.features2d.DescriptorMatcher.train</a>
 */
				public  void train ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorMatcher_train_10 (nativeObj);
		
						return;
						#else
			return;
						#endif
				}
	
	
				//
				// C++:  void javaDescriptorMatcher::write(string fileName)
				//
	
				public  void write (string fileName)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						features2d_DescriptorMatcher_write_10 (nativeObj, fileName);
		
						return;
						#else
			return;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			features2d_DescriptorMatcher_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void javaDescriptorMatcher::add(vector_Mat descriptors)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_add_10(IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);
		
		// C++:  void javaDescriptorMatcher::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_clear_10(IntPtr nativeObj);
		
		// C++:  javaDescriptorMatcher* javaDescriptorMatcher::jclone(bool emptyTrainData = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_DescriptorMatcher_clone_10(IntPtr nativeObj, bool emptyTrainData);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_DescriptorMatcher_clone_11(IntPtr nativeObj);
		
		// C++: static javaDescriptorMatcher* javaDescriptorMatcher::create(int matcherType)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_DescriptorMatcher_create_10(int matcherType);
		
		// C++:  bool javaDescriptorMatcher::empty()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_DescriptorMatcher_empty_10(IntPtr nativeObj);
		
		// C++:  vector_Mat javaDescriptorMatcher::getTrainDescriptors()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr features2d_DescriptorMatcher_getTrainDescriptors_10(IntPtr nativeObj);
		
		// C++:  bool javaDescriptorMatcher::isMaskSupported()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool features2d_DescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);
		
		// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
		// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
		// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);
		
		// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);
		
		// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
		// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
		// C++:  void javaDescriptorMatcher::read(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_read_10(IntPtr nativeObj, string fileName);
		
		// C++:  void javaDescriptorMatcher::train()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_train_10(IntPtr nativeObj);
		
		// C++:  void javaDescriptorMatcher::write(string fileName)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_write_10(IntPtr nativeObj, string fileName);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_DescriptorMatcher_delete(IntPtr nativeObj);

#else
				// C++:  void javaDescriptorMatcher::add(vector_Mat descriptors)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_add_10 (IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);
		
				// C++:  void javaDescriptorMatcher::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_clear_10 (IntPtr nativeObj);
		
				// C++:  javaDescriptorMatcher* javaDescriptorMatcher::jclone(bool emptyTrainData = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_DescriptorMatcher_clone_10 (IntPtr nativeObj, bool emptyTrainData);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_DescriptorMatcher_clone_11 (IntPtr nativeObj);
		
				// C++: static javaDescriptorMatcher* javaDescriptorMatcher::create(int matcherType)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_DescriptorMatcher_create_10 (int matcherType);
		
				// C++:  bool javaDescriptorMatcher::empty()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_DescriptorMatcher_empty_10 (IntPtr nativeObj);
		
				// C++:  vector_Mat javaDescriptorMatcher::getTrainDescriptors()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr features2d_DescriptorMatcher_getTrainDescriptors_10 (IntPtr nativeObj);
		
				// C++:  bool javaDescriptorMatcher::isMaskSupported()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool features2d_DescriptorMatcher_isMaskSupported_10 (IntPtr nativeObj);
		
				// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_knnMatch_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_knnMatch_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
				// C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_knnMatch_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_knnMatch_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);
		
				// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_match_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_match_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);
		
				// C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_match_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_match_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);
		
				// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_10 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_11 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
				// C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_12 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_radiusMatch_13 (IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);
		
				// C++:  void javaDescriptorMatcher::read(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_read_10 (IntPtr nativeObj, string fileName);
		
				// C++:  void javaDescriptorMatcher::train()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_train_10 (IntPtr nativeObj);
		
				// C++:  void javaDescriptorMatcher::write(string fileName)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_write_10 (IntPtr nativeObj, string fileName);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_DescriptorMatcher_delete (IntPtr nativeObj);
		#endif
		}
}
