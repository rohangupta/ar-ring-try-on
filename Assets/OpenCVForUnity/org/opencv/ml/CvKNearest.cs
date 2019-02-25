
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvKNearest
/**
 * <p>The class implements K-Nearest Neighbors model as described in the beginning
 * of this section.</p>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> (Python) An example of digit recognition using KNearest can be found
 * at opencv_source/samples/python2/digits.py
 *   <li> (Python) An example of grid search digit recognition using KNearest
 * can be found at opencv_source/samples/python2/digits_adjust.py
 *   <li> (Python) An example of video digit recognition using KNearest can be
 * found at opencv_source/samples/python2/digits_video.py
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest">org.opencv.ml.CvKNearest : public CvStatModel</a>
 */
		public class CvKNearest : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						
						try {
								
								if (disposing) {
								}
								
								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvKNearest_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
								
						} finally {
								base.Dispose (disposing);
						}
						
						#else
			return;
						#endif
				}
	
				protected CvKNearest (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvKNearest::CvKNearest()
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>See "CvKNearest.train" for additional parameters descriptions.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-cvknearest">org.opencv.ml.CvKNearest.CvKNearest</a>
 */
				public   CvKNearest ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvKNearest_CvKNearest_10() )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;

				}
	
	
				//
				// C++:   CvKNearest::CvKNearest(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int max_k = 32)
				//
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>See "CvKNearest.train" for additional parameters descriptions.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param sampleIdx a sampleIdx
 * @param isRegression a isRegression
 * @param max_k a max_k
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-cvknearest">org.opencv.ml.CvKNearest.CvKNearest</a>
 */
				public   CvKNearest (Mat trainData, Mat responses, Mat sampleIdx, bool isRegression, int max_k)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvKNearest_CvKNearest_11(trainData.nativeObj, responses.nativeObj, sampleIdx.nativeObj, isRegression, max_k) )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
				/**
 * <p>Default and training constructors.</p>
 *
 * <p>See "CvKNearest.train" for additional parameters descriptions.</p>
 *
 * @param trainData a trainData
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-cvknearest">org.opencv.ml.CvKNearest.CvKNearest</a>
 */
				public   CvKNearest (Mat trainData, Mat responses)
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
				base( ml_CvKNearest_CvKNearest_12(trainData.nativeObj, responses.nativeObj) )
				#else
				base(IntPtr.Zero)
		#endif
				{
		
						return;
				}
	
	
				//
				// C++:  float CvKNearest::find_nearest(Mat samples, int k, Mat& results, Mat& neighborResponses, Mat& dists)
				//
	
				/**
 * <p>Finds the neighbors and predicts responses for input vectors.</p>
 *
 * <p>For each input vector (a row of the matrix <code>samples</code>), the method
 * finds the <code>k</code> nearest neighbors. In case of regression, the
 * predicted result is a mean value of the particular vector's neighbor
 * responses. In case of classification, the class is determined by voting.</p>
 *
 * <p>For each input vector, the neighbors are sorted by their distances to the
 * vector.</p>
 *
 * <p>In case of C++ interface you can use output pointers to empty matrices and
 * the function will allocate memory itself.</p>
 *
 * <p>If only a single input vector is passed, all output matrices are optional and
 * the predicted value is returned by the method.</p>
 *
 * <p>The function is parallelized with the TBB library.</p>
 *
 * @param samples Input samples stored by rows. It is a single-precision
 * floating-point matrix of <em>number_of_samples x number_of_features</em>
 * size.
 * @param k Number of used nearest neighbors. It must satisfy constraint: <em>k
 * <= </em> "CvKNearest.get_max_k".
 * @param results Vector with results of prediction (regression or
 * classification) for each input sample. It is a single-precision
 * floating-point vector with <code>number_of_samples</code> elements.
 * @param neighborResponses Optional output values for corresponding
 * <code>neighbors</code>. It is a single-precision floating-point matrix of
 * <em>number_of_samples x k</em> size.
 * @param dists a dists
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-find-nearest">org.opencv.ml.CvKNearest.find_nearest</a>
 */
				public  float find_nearest (Mat samples, int k, Mat results, Mat neighborResponses, Mat dists)
				{
						if (samples != null)
								samples.ThrowIfDisposed ();
						if (results != null)
								results.ThrowIfDisposed ();
						if (neighborResponses != null)
								neighborResponses.ThrowIfDisposed ();
						if (dists != null)
								dists.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvKNearest_find_1nearest_10 (nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj, dists.nativeObj);
		
						return retVal;
						#else
			return 0;
						#endif
				}
	
	
				//
				// C++:  bool CvKNearest::train(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int maxK = 32, bool updateBase = false)
				//
	
				/**
 * <p>Trains the model.</p>
 *
 * <p>The method trains the K-Nearest model. It follows the conventions of the
 * generic "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variables can be either categorical (<code>is_regression=false</code>)
 * or ordered (<code>is_regression=true</code>).
 *   <li> Variable subsets (<code>var_idx</code>) and missing measurements are
 * not supported.
 * </ul>
 *
 * @param trainData a trainData
 * @param responses a responses
 * @param sampleIdx a sampleIdx
 * @param isRegression Type of the problem: <code>true</code> for regression and
 * <code>false</code> for classification.
 * @param maxK Number of maximum neighbors that may be passed to the method
 * "CvKNearest.find_nearest".
 * @param updateBase Specifies whether the model is trained from scratch
 * (<code>update_base=false</code>), or it is updated using the new training
 * data (<code>update_base=true</code>). In the latter case, the parameter
 * <code>maxK</code> must not be larger than the original value.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-train">org.opencv.ml.CvKNearest.train</a>
 */
				public  bool train (Mat trainData, Mat responses, Mat sampleIdx, bool isRegression, int maxK, bool updateBase)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvKNearest_train_10 (nativeObj, trainData.nativeObj, responses.nativeObj, sampleIdx.nativeObj, isRegression, maxK, updateBase);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				/**
 * <p>Trains the model.</p>
 *
 * <p>The method trains the K-Nearest model. It follows the conventions of the
 * generic "CvStatModel.train" approach with the following limitations:</p>
 * <ul>
 *   <li> Only <code>CV_ROW_SAMPLE</code> data layout is supported.
 *   <li> Input variables are all ordered.
 *   <li> Output variables can be either categorical (<code>is_regression=false</code>)
 * or ordered (<code>is_regression=true</code>).
 *   <li> Variable subsets (<code>var_idx</code>) and missing measurements are
 * not supported.
 * </ul>
 *
 * @param trainData a trainData
 * @param responses a responses
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest-train">org.opencv.ml.CvKNearest.train</a>
 */
				public  bool train (Mat trainData, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvKNearest_train_11 (nativeObj, trainData.nativeObj, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			_ml_CvKNearest_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvKNearest::CvKNearest()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvKNearest_CvKNearest_10 ();
		
		// C++:   CvKNearest::CvKNearest(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int max_k = 32)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvKNearest_CvKNearest_11 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int max_k);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvKNearest_CvKNearest_12 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// C++:  float CvKNearest::find_nearest(Mat samples, int k, Mat& results, Mat& neighborResponses, Mat& dists)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvKNearest_find_1nearest_10 (IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dists_nativeObj);
		
		// C++:  bool CvKNearest::train(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int maxK = 32, bool updateBase = false)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvKNearest_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int maxK, bool updateBase);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvKNearest_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvKNearest_delete (IntPtr nativeObj);

#else
		
				// C++:   CvKNearest::CvKNearest()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvKNearest_CvKNearest_10 ();
		
				// C++:   CvKNearest::CvKNearest(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int max_k = 32)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvKNearest_CvKNearest_11 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int max_k);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvKNearest_CvKNearest_12 (IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// C++:  float CvKNearest::find_nearest(Mat samples, int k, Mat& results, Mat& neighborResponses, Mat& dists)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvKNearest_find_1nearest_10 (IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dists_nativeObj);
		
				// C++:  bool CvKNearest::train(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int maxK = 32, bool updateBase = false)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvKNearest_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int maxK, bool updateBase);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvKNearest_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvKNearest_delete (IntPtr nativeObj);
		#endif
		}
}
