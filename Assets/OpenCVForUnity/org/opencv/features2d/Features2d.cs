
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Features2d
		{
	
				public const int DRAW_OVER_OUTIMG = 1;
				public const int NOT_DRAW_SINGLE_POINTS = 2;
				public const int DRAW_RICH_KEYPOINTS = 4;
	
	
				//
				// C++:  void drawKeypoints(Mat image, vector_KeyPoint keypoints, Mat outImage, Scalar color = Scalar::all(-1), int flags = 0)
				//
	
				/**
 * <p>Draws keypoints.</p>
 *
 * @param image Source image.
 * @param keypoints Keypoints from the source image.
 * @param outImage Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 * @param color Color of keypoints.
 * @param flags Flags setting drawing features. Possible <code>flags</code> bit
 * values are defined by <code>DrawMatchesFlags</code>. See details above in
 * "drawMatches".
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawkeypoints">org.opencv.features2d.Features2d.drawKeypoints</a>
 */
				public static void drawKeypoints (Mat image, MatOfKeyPoint keypoints, Mat outImage, Scalar color, int flags)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (keypoints != null)
								keypoints.ThrowIfDisposed ();
						if (outImage != null)
								outImage.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints_mat = keypoints;
						features2d_Features2d_drawKeypoints_10 (image.nativeObj, keypoints_mat.nativeObj, outImage.nativeObj, color.val [0], color.val [1], color.val [2], color.val [3], flags);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Draws keypoints.</p>
 *
 * @param image Source image.
 * @param keypoints Keypoints from the source image.
 * @param outImage Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawkeypoints">org.opencv.features2d.Features2d.drawKeypoints</a>
 */
				public static void drawKeypoints (Mat image, MatOfKeyPoint keypoints, Mat outImage)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (keypoints != null)
								keypoints.ThrowIfDisposed ();
						if (outImage != null)
								outImage.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints_mat = keypoints;
						features2d_Features2d_drawKeypoints_11 (image.nativeObj, keypoints_mat.nativeObj, outImage.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_char matchesMask = vector<char>(), int flags = 0)
				//
	
				/**
 * <p>Draws the found matches of keypoints from two images.</p>
 *
 * <p>This function draws matches of keypoints from two images in the output image.
 * Match is a line connecting two keypoints (circles). The structure
 * <code>DrawMatchesFlags</code> is defined as follows: struct DrawMatchesFlags
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>enum</p>
 *
 *
 * <p>DEFAULT = 0, // Output image matrix will be created (Mat.create),</p>
 *
 * <p>// i.e. existing memory of output image may be reused.</p>
 *
 * <p>// Two source images, matches, and single keypoints</p>
 *
 * <p>// will be drawn.</p>
 *
 * <p>// For each keypoint, only the center point will be</p>
 *
 * <p>// drawn (without a circle around the keypoint with the</p>
 *
 * <p>// keypoint size and orientation).</p>
 *
 * <p>DRAW_OVER_OUTIMG = 1, // Output image matrix will not be</p>
 *
 * <p>// created (using Mat.create). Matches will be drawn</p>
 *
 * <p>// on existing content of output image.</p>
 *
 * <p>NOT_DRAW_SINGLE_POINTS = 2, // Single keypoints will not be drawn.</p>
 *
 * <p>DRAW_RICH_KEYPOINTS = 4 // For each keypoint, the circle around</p>
 *
 * <p>// keypoint with keypoint size and orientation will</p>
 *
 * <p>// be drawn.</p>
 *
 * <p>};</p>
 *
 * <p>};</p>
 *
 * <p></code></p>
 *
 * @param img1 First source image.
 * @param keypoints1 Keypoints from the first source image.
 * @param img2 Second source image.
 * @param keypoints2 Keypoints from the second source image.
 * @param matches1to2 Matches from the first image to the second one, which
 * means that <code>keypoints1[i]</code> has a corresponding point in
 * <code>keypoints2[matches[i]]</code>.
 * @param outImg Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 * @param matchColor Color of matches (lines and connected keypoints). If
 * <code>matchColor==Scalar.all(-1)</code>, the color is generated randomly.
 * @param singlePointColor Color of single keypoints (circles), which means that
 * keypoints do not have the matches. If <code>singlePointColor==Scalar.all(-1)</code>,
 * the color is generated randomly.
 * @param matchesMask Mask determining which matches are drawn. If the mask is
 * empty, all matches are drawn.
 * @param flags Flags setting drawing features. Possible <code>flags</code> bit
 * values are defined by <code>DrawMatchesFlags</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawmatches">org.opencv.features2d.Features2d.drawMatches</a>
 */
				public static void drawMatches (Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, MatOfByte matchesMask, int flags)
				{
						if (img1 != null)
								img1.ThrowIfDisposed ();
						if (keypoints1 != null)
								keypoints1.ThrowIfDisposed ();
						if (img2 != null)
								img2.ThrowIfDisposed ();
						if (keypoints2 != null)
								keypoints2.ThrowIfDisposed ();
						if (matches1to2 != null)
								matches1to2.ThrowIfDisposed ();
						if (outImg != null)
								outImg.ThrowIfDisposed ();
						if (matchesMask != null)
								matchesMask.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints1_mat = keypoints1;
						Mat keypoints2_mat = keypoints2;
						Mat matches1to2_mat = matches1to2;
						Mat matchesMask_mat = matchesMask;
						features2d_Features2d_drawMatches_10 (img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val [0], matchColor.val [1], matchColor.val [2], matchColor.val [3], singlePointColor.val [0], singlePointColor.val [1], singlePointColor.val [2], singlePointColor.val [3], matchesMask_mat.nativeObj, flags);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Draws the found matches of keypoints from two images.</p>
 *
 * <p>This function draws matches of keypoints from two images in the output image.
 * Match is a line connecting two keypoints (circles). The structure
 * <code>DrawMatchesFlags</code> is defined as follows: struct DrawMatchesFlags
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>enum</p>
 *
 *
 * <p>DEFAULT = 0, // Output image matrix will be created (Mat.create),</p>
 *
 * <p>// i.e. existing memory of output image may be reused.</p>
 *
 * <p>// Two source images, matches, and single keypoints</p>
 *
 * <p>// will be drawn.</p>
 *
 * <p>// For each keypoint, only the center point will be</p>
 *
 * <p>// drawn (without a circle around the keypoint with the</p>
 *
 * <p>// keypoint size and orientation).</p>
 *
 * <p>DRAW_OVER_OUTIMG = 1, // Output image matrix will not be</p>
 *
 * <p>// created (using Mat.create). Matches will be drawn</p>
 *
 * <p>// on existing content of output image.</p>
 *
 * <p>NOT_DRAW_SINGLE_POINTS = 2, // Single keypoints will not be drawn.</p>
 *
 * <p>DRAW_RICH_KEYPOINTS = 4 // For each keypoint, the circle around</p>
 *
 * <p>// keypoint with keypoint size and orientation will</p>
 *
 * <p>// be drawn.</p>
 *
 * <p>};</p>
 *
 * <p>};</p>
 *
 * <p></code></p>
 *
 * @param img1 First source image.
 * @param keypoints1 Keypoints from the first source image.
 * @param img2 Second source image.
 * @param keypoints2 Keypoints from the second source image.
 * @param matches1to2 Matches from the first image to the second one, which
 * means that <code>keypoints1[i]</code> has a corresponding point in
 * <code>keypoints2[matches[i]]</code>.
 * @param outImg Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawmatches">org.opencv.features2d.Features2d.drawMatches</a>
 */
				public static void drawMatches (Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, Mat outImg)
				{
						if (img1 != null)
								img1.ThrowIfDisposed ();
						if (keypoints1 != null)
								keypoints1.ThrowIfDisposed ();
						if (img2 != null)
								img2.ThrowIfDisposed ();
						if (keypoints2 != null)
								keypoints2.ThrowIfDisposed ();
						if (matches1to2 != null)
								matches1to2.ThrowIfDisposed ();
						if (outImg != null)
								outImg.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints1_mat = keypoints1;
						Mat keypoints2_mat = keypoints2;
						Mat matches1to2_mat = matches1to2;
						features2d_Features2d_drawMatches_11 (img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_vector_char matchesMask = vector<vector<char> >(), int flags = 0)
				//
	
				/**
 * <p>Draws the found matches of keypoints from two images.</p>
 *
 * <p>This function draws matches of keypoints from two images in the output image.
 * Match is a line connecting two keypoints (circles). The structure
 * <code>DrawMatchesFlags</code> is defined as follows: struct DrawMatchesFlags
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>enum</p>
 *
 *
 * <p>DEFAULT = 0, // Output image matrix will be created (Mat.create),</p>
 *
 * <p>// i.e. existing memory of output image may be reused.</p>
 *
 * <p>// Two source images, matches, and single keypoints</p>
 *
 * <p>// will be drawn.</p>
 *
 * <p>// For each keypoint, only the center point will be</p>
 *
 * <p>// drawn (without a circle around the keypoint with the</p>
 *
 * <p>// keypoint size and orientation).</p>
 *
 * <p>DRAW_OVER_OUTIMG = 1, // Output image matrix will not be</p>
 *
 * <p>// created (using Mat.create). Matches will be drawn</p>
 *
 * <p>// on existing content of output image.</p>
 *
 * <p>NOT_DRAW_SINGLE_POINTS = 2, // Single keypoints will not be drawn.</p>
 *
 * <p>DRAW_RICH_KEYPOINTS = 4 // For each keypoint, the circle around</p>
 *
 * <p>// keypoint with keypoint size and orientation will</p>
 *
 * <p>// be drawn.</p>
 *
 * <p>};</p>
 *
 * <p>};</p>
 *
 * <p></code></p>
 *
 * @param img1 First source image.
 * @param keypoints1 Keypoints from the first source image.
 * @param img2 Second source image.
 * @param keypoints2 Keypoints from the second source image.
 * @param matches1to2 Matches from the first image to the second one, which
 * means that <code>keypoints1[i]</code> has a corresponding point in
 * <code>keypoints2[matches[i]]</code>.
 * @param outImg Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 * @param matchColor Color of matches (lines and connected keypoints). If
 * <code>matchColor==Scalar.all(-1)</code>, the color is generated randomly.
 * @param singlePointColor Color of single keypoints (circles), which means that
 * keypoints do not have the matches. If <code>singlePointColor==Scalar.all(-1)</code>,
 * the color is generated randomly.
 * @param matchesMask Mask determining which matches are drawn. If the mask is
 * empty, all matches are drawn.
 * @param flags Flags setting drawing features. Possible <code>flags</code> bit
 * values are defined by <code>DrawMatchesFlags</code>.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawmatches">org.opencv.features2d.Features2d.drawMatches</a>
 */
				public static void drawMatches2 (Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, List<MatOfByte> matchesMask, int flags)
				{
						if (img1 != null)
								img1.ThrowIfDisposed ();
						if (keypoints1 != null)
								keypoints1.ThrowIfDisposed ();
						if (img2 != null)
								img2.ThrowIfDisposed ();
						if (keypoints2 != null)
								keypoints2.ThrowIfDisposed ();
						if (outImg != null)
								outImg.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints1_mat = keypoints1;
						Mat keypoints2_mat = keypoints2;
						List<Mat> matches1to2_tmplm = new List<Mat> ((matches1to2 != null) ? matches1to2.Count : 0);
						Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat (matches1to2, matches1to2_tmplm);
						List<Mat> matchesMask_tmplm = new List<Mat> ((matchesMask != null) ? matchesMask.Count : 0);
						Mat matchesMask_mat = Converters.vector_vector_char_to_Mat (matchesMask, matchesMask_tmplm);
						features2d_Features2d_drawMatches2_10 (img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj, matchColor.val [0], matchColor.val [1], matchColor.val [2], matchColor.val [3], singlePointColor.val [0], singlePointColor.val [1], singlePointColor.val [2], singlePointColor.val [3], matchesMask_mat.nativeObj, flags);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Draws the found matches of keypoints from two images.</p>
 *
 * <p>This function draws matches of keypoints from two images in the output image.
 * Match is a line connecting two keypoints (circles). The structure
 * <code>DrawMatchesFlags</code> is defined as follows: struct DrawMatchesFlags
 * <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>enum</p>
 *
 *
 * <p>DEFAULT = 0, // Output image matrix will be created (Mat.create),</p>
 *
 * <p>// i.e. existing memory of output image may be reused.</p>
 *
 * <p>// Two source images, matches, and single keypoints</p>
 *
 * <p>// will be drawn.</p>
 *
 * <p>// For each keypoint, only the center point will be</p>
 *
 * <p>// drawn (without a circle around the keypoint with the</p>
 *
 * <p>// keypoint size and orientation).</p>
 *
 * <p>DRAW_OVER_OUTIMG = 1, // Output image matrix will not be</p>
 *
 * <p>// created (using Mat.create). Matches will be drawn</p>
 *
 * <p>// on existing content of output image.</p>
 *
 * <p>NOT_DRAW_SINGLE_POINTS = 2, // Single keypoints will not be drawn.</p>
 *
 * <p>DRAW_RICH_KEYPOINTS = 4 // For each keypoint, the circle around</p>
 *
 * <p>// keypoint with keypoint size and orientation will</p>
 *
 * <p>// be drawn.</p>
 *
 * <p>};</p>
 *
 * <p>};</p>
 *
 * <p></code></p>
 *
 * @param img1 First source image.
 * @param keypoints1 Keypoints from the first source image.
 * @param img2 Second source image.
 * @param keypoints2 Keypoints from the second source image.
 * @param matches1to2 Matches from the first image to the second one, which
 * means that <code>keypoints1[i]</code> has a corresponding point in
 * <code>keypoints2[matches[i]]</code>.
 * @param outImg Output image. Its content depends on the <code>flags</code>
 * value defining what is drawn in the output image. See possible
 * <code>flags</code> bit values below.
 *
 * @see <a href="http://docs.opencv.org/modules/features2d/doc/drawing_function_of_keypoints_and_matches.html#drawmatches">org.opencv.features2d.Features2d.drawMatches</a>
 */
				public static void drawMatches2 (Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg)
				{
						if (img1 != null)
								img1.ThrowIfDisposed ();
						if (keypoints1 != null)
								keypoints1.ThrowIfDisposed ();
						if (img2 != null)
								img2.ThrowIfDisposed ();
						if (keypoints2 != null)
								keypoints2.ThrowIfDisposed ();
						if (outImg != null)
								outImg.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat keypoints1_mat = keypoints1;
						Mat keypoints2_mat = keypoints2;
						List<Mat> matches1to2_tmplm = new List<Mat> ((matches1to2 != null) ? matches1to2.Count : 0);
						Mat matches1to2_mat = Converters.vector_vector_DMatch_to_Mat (matches1to2, matches1to2_tmplm);
						features2d_Features2d_drawMatches2_11 (img1.nativeObj, keypoints1_mat.nativeObj, img2.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, outImg.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
		#if UNITY_IOS && !UNITY_EDITOR
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawKeypoints_10 (IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int flags);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawKeypoints_11 (IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj);
		
		// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_char matchesMask = vector<char>(), int flags = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawMatches_10 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawMatches_11 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);
		
		// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_vector_char matchesMask = vector<vector<char> >(), int flags = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawMatches2_10 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void features2d_Features2d_drawMatches2_11 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);

#else
		
				// C++:  void drawKeypoints(Mat image, vector_KeyPoint keypoints, Mat outImage, Scalar color = Scalar::all(-1), int flags = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawKeypoints_10 (IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int flags);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawKeypoints_11 (IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr outImage_nativeObj);
		
				// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_char matchesMask = vector<char>(), int flags = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawMatches_10 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawMatches_11 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);
		
				// C++:  void drawMatches(Mat img1, vector_KeyPoint keypoints1, Mat img2, vector_KeyPoint keypoints2, vector_vector_DMatch matches1to2, Mat outImg, Scalar matchColor = Scalar::all(-1), Scalar singlePointColor = Scalar::all(-1), vector_vector_char matchesMask = vector<vector<char> >(), int flags = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawMatches2_10 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj, double matchColor_val0, double matchColor_val1, double matchColor_val2, double matchColor_val3, double singlePointColor_val0, double singlePointColor_val1, double singlePointColor_val2, double singlePointColor_val3, IntPtr matchesMask_mat_nativeObj, int flags);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void features2d_Features2d_drawMatches2_11 (IntPtr img1_nativeObj, IntPtr keypoints1_mat_nativeObj, IntPtr img2_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr outImg_nativeObj);

		#endif
		}

}