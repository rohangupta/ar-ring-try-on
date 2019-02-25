
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Contrib
		{
	
				public const int ROTATION = 1;
				public const int	TRANSLATION = 2;
				public const int	RIGID_BODY_MOTION = 4;
				public const int	COLORMAP_AUTUMN = 0;
				public const int	COLORMAP_BONE = 1;
				public const int	COLORMAP_JET = 2;
				public const int	COLORMAP_WINTER = 3;
				public const int	COLORMAP_RAINBOW = 4;
				public const int	COLORMAP_OCEAN = 5;
				public const int	COLORMAP_SUMMER = 6;
				public const int	COLORMAP_SPRING = 7;
				public const int	COLORMAP_COOL = 8;
				public const int	COLORMAP_HSV = 9;
				public const int	COLORMAP_PINK = 10;
				public const int	COLORMAP_HOT = 11;
				public const int	RETINA_COLOR_RANDOM = 0;
				public const int	RETINA_COLOR_DIAGONAL = 1;
				public const int	RETINA_COLOR_BAYER = 2;
	
	
				//
				// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
				//
	
				/**
 * <p>Applies a GNU Octave/MATLAB equivalent colormap on a given image.</p>
 *
 * <p>Currently the following GNU Octave/MATLAB equivalent colormaps are
 * implemented: enum <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>COLORMAP_AUTUMN = 0,</p>
 *
 * <p>COLORMAP_BONE = 1,</p>
 *
 * <p>COLORMAP_JET = 2,</p>
 *
 * <p>COLORMAP_WINTER = 3,</p>
 *
 * <p>COLORMAP_RAINBOW = 4,</p>
 *
 * <p>COLORMAP_OCEAN = 5,</p>
 *
 * <p>COLORMAP_SUMMER = 6,</p>
 *
 * <p>COLORMAP_SPRING = 7,</p>
 *
 * <p>COLORMAP_COOL = 8,</p>
 *
 * <p>COLORMAP_HSV = 9,</p>
 *
 * <p>COLORMAP_PINK = 10,</p>
 *
 * <p>COLORMAP_HOT = 11</p>
 *
 *
 * @param src The source image, grayscale or colored does not matter.
 * @param dst The result is the colormapped source image. Note: "Mat.create" is
 * called on dst.
 * @param colormap The colormap to apply, see the list of available colormaps
 * below.
 *
 * @see <a href="http://docs.opencv.org/modules/contrib/doc/colormaps.html#applycolormap">org.opencv.contrib.Contrib.applyColorMap</a>
 */
				public static void applyColorMap (Mat src, Mat dst, int colormap)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						contrib_Contrib_applyColorMap_10 (src.nativeObj, dst.nativeObj, colormap);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  int chamerMatching(Mat img, Mat templ, vector_vector_Point& results, vector_float& cost, double templScale = 1, int maxMatches = 20, double minMatchDistance = 1.0, int padX = 3, int padY = 3, int scales = 5, double minScale = 0.6, double maxScale = 1.6, double orientationWeight = 0.5, double truncate = 20)
				//
	
				public static int chamerMatching (Mat img, Mat templ, List<MatOfPoint> results, MatOfFloat cost, double templScale, int maxMatches, double minMatchDistance, int padX, int padY, int scales, double minScale, double maxScale, double orientationWeight, double truncate)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (templ != null)
								templ.ThrowIfDisposed ();
						if (cost != null)
								cost.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat results_mat = new Mat ();
						Mat cost_mat = cost;
						int retVal = contrib_Contrib_chamerMatching_10 (img.nativeObj, templ.nativeObj, results_mat.nativeObj, cost_mat.nativeObj, templScale, maxMatches, minMatchDistance, padX, padY, scales, minScale, maxScale, orientationWeight, truncate);
						Converters.Mat_to_vector_vector_Point (results_mat, results);
						return retVal;
						#else
						return 0;
						#endif
				}
	
				public static int chamerMatching (Mat img, Mat templ, List<MatOfPoint> results, MatOfFloat cost)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (templ != null)
								templ.ThrowIfDisposed ();
						if (cost != null)
								cost.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat results_mat = new Mat ();
						Mat cost_mat = cost;
						int retVal = contrib_Contrib_chamerMatching_11 (img.nativeObj, templ.nativeObj, results_mat.nativeObj, cost_mat.nativeObj);
						Converters.Mat_to_vector_vector_Point (results_mat, results);
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  Ptr_FaceRecognizer createEigenFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				//
	
				// Return type 'Ptr_FaceRecognizer' is not supported, skipping the function
	
	
				//
				// C++:  Ptr_FaceRecognizer createFisherFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
				//
	
				// Return type 'Ptr_FaceRecognizer' is not supported, skipping the function
	
	
				//
				// C++:  Ptr_FaceRecognizer createLBPHFaceRecognizer(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
				//
	
				// Return type 'Ptr_FaceRecognizer' is not supported, skipping the function
	
	
		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void contrib_Contrib_applyColorMap_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int colormap);
		
		// C++:  int chamerMatching(Mat img, Mat templ, vector_vector_Point& results, vector_float& cost, double templScale = 1, int maxMatches = 20, double minMatchDistance = 1.0, int padX = 3, int padY = 3, int scales = 5, double minScale = 0.6, double maxScale = 1.6, double orientationWeight = 0.5, double truncate = 20)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_Contrib_chamerMatching_10(IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr results_mat_nativeObj, IntPtr cost_mat_nativeObj, double templScale, int maxMatches, double minMatchDistance, int padX, int padY, int scales, double minScale, double maxScale, double orientationWeight, double truncate);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int contrib_Contrib_chamerMatching_11(IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr results_mat_nativeObj, IntPtr cost_mat_nativeObj);

#else
		
				// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void contrib_Contrib_applyColorMap_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int colormap);
		
				// C++:  int chamerMatching(Mat img, Mat templ, vector_vector_Point& results, vector_float& cost, double templScale = 1, int maxMatches = 20, double minMatchDistance = 1.0, int padX = 3, int padY = 3, int scales = 5, double minScale = 0.6, double maxScale = 1.6, double orientationWeight = 0.5, double truncate = 20)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_Contrib_chamerMatching_10 (IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr results_mat_nativeObj, IntPtr cost_mat_nativeObj, double templScale, int maxMatches, double minMatchDistance, int padX, int padY, int scales, double minScale, double maxScale, double orientationWeight, double truncate);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int contrib_Contrib_chamerMatching_11 (IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr results_mat_nativeObj, IntPtr cost_mat_nativeObj);

		#endif
		}
}

