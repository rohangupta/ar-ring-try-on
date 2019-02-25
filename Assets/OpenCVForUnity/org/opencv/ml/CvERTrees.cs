
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
	

// C++: class CvERTrees
/**
 * <p>The class implements the Extremely randomized trees algorithm.
 * <code>CvERTrees</code> is inherited from "CvRTrees" and has the same
 * interface, so see description of "CvRTrees" class to get details. To set the
 * training parameters of Extremely randomized trees the same class "CvRTParams"
 * is used.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/ertrees.html#cvertrees">org.opencv.ml.CvERTrees : public CvRTrees</a>
 */
		public class CvERTrees : CvRTrees
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvERTrees_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}

						#else
			return;
						#endif
				}
	
				protected CvERTrees (IntPtr addr) : base(addr)
				{
				}
	
	
				//
				// C++:   CvERTrees::CvERTrees()
				//
	
				public   CvERTrees ()
	:
				#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		base( ml_CvERTrees_CvERTrees_10() )
			#else
		base(IntPtr.Zero)
			#endif
				{
		
						return;
				}
	
	
				//
				// C++:  bool CvERTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
				//
	
				public override  bool train (Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvRTParams _params)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						if (varIdx != null)
								varIdx.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (varType != null)
								varType.ThrowIfDisposed ();
						if (missingDataMask != null)
								missingDataMask.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvERTrees_train_10 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
				public override  bool train (Mat trainData, int tflag, Mat responses)
				{
						if (trainData != null)
								trainData.ThrowIfDisposed ();
						if (responses != null)
								responses.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = ml_CvERTrees_train_11 (nativeObj, trainData.nativeObj, tflag, responses.nativeObj);
		
						return retVal;
						#else
			return false;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvERTrees_delete(nativeObj);
//	}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvERTrees::CvERTrees()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvERTrees_CvERTrees_10();
		
		// C++:  bool CvERTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvERTrees_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ml_CvERTrees_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvERTrees_delete(IntPtr nativeObj);

#else
				// C++:   CvERTrees::CvERTrees()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvERTrees_CvERTrees_10 ();
		
				// C++:  bool CvERTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvERTrees_train_10 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool ml_CvERTrees_train_11 (IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvERTrees_delete (IntPtr nativeObj);
		#endif
		}
}