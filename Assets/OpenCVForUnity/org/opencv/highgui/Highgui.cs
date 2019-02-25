using System;
using System.Runtime.InteropServices;

//
// This file is auto-generated. Please don't modify it!
//
namespace OpenCVForUnity
{
		public class Highgui
		{
	
				public const int CV_FONT_LIGHT = 25;
				public const int CV_FONT_NORMAL = 50;
				public const int CV_FONT_DEMIBOLD = 63;
				public const int CV_FONT_BOLD = 75;
				public const int CV_FONT_BLACK = 87;
				public const int CV_STYLE_NORMAL = 0;
				public const int CV_STYLE_ITALIC = 1;
				public const int CV_STYLE_OBLIQUE = 2;
				public const int CV_LOAD_IMAGE_UNCHANGED = -1;
				public const int CV_LOAD_IMAGE_GRAYSCALE = 0;
				public const int CV_LOAD_IMAGE_COLOR = 1;
				public const int CV_LOAD_IMAGE_ANYDEPTH = 2;
				public const int CV_LOAD_IMAGE_ANYCOLOR = 4;
				public const int CV_IMWRITE_JPEG_QUALITY = 1;
				public const int CV_IMWRITE_PNG_COMPRESSION = 16;
				public const int CV_IMWRITE_PNG_STRATEGY = 17;
				public const int CV_IMWRITE_PNG_BILEVEL = 18;
				public const int CV_IMWRITE_PNG_STRATEGY_DEFAULT = 0;
				public const int CV_IMWRITE_PNG_STRATEGY_FILTERED = 1;
				public const int CV_IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2;
				public const int CV_IMWRITE_PNG_STRATEGY_RLE = 3;
				public const int CV_IMWRITE_PNG_STRATEGY_FIXED = 4;
				public const int CV_IMWRITE_PXM_BINARY = 32;
				public const int CV_CVTIMG_FLIP = 1;
				public const int CV_CVTIMG_SWAP_RB = 2;
				public const int CV_CAP_MSMF = 1400;
				public const int CV_CAP_ANDROID = 1000;
				public const int CV_CAP_ANDROID_BACK = CV_CAP_ANDROID + 99;
				public const int CV_CAP_ANDROID_FRONT = CV_CAP_ANDROID + 98;
				public const int CV_CAP_XIAPI = 1100;
				public const int CV_CAP_AVFOUNDATION = 1200;
				public const int CV_CAP_GIGANETIX = 1300;
				public const int CV_CAP_PROP_FRAME_WIDTH = 3;
				public const int CV_CAP_PROP_FRAME_HEIGHT = 4;
				public const int CV_CAP_PROP_ZOOM = 27;
				public const int CV_CAP_PROP_FOCUS = 28;
				public const int CV_CAP_PROP_GUID = 29;
				public const int CV_CAP_PROP_ISO_SPEED = 30;
				public const int CV_CAP_PROP_BACKLIGHT = 32;
				public const int CV_CAP_PROP_PAN = 33;
				public const int CV_CAP_PROP_TILT = 34;
				public const int CV_CAP_PROP_ROLL = 35;
				public const int CV_CAP_PROP_IRIS = 36;
				public const int CV_CAP_PROP_SETTINGS = 37;
				public const int CV_CAP_PROP_AUTOGRAB = 1024;
				public const int CV_CAP_PROP_PREVIEW_FORMAT = 1026;
				public const int CV_CAP_PROP_XI_DOWNSAMPLING = 400;
				public const int CV_CAP_PROP_XI_DATA_FORMAT = 401;
				public const int CV_CAP_PROP_XI_OFFSET_X = 402;
				public const int CV_CAP_PROP_XI_OFFSET_Y = 403;
				public const int CV_CAP_PROP_XI_TRG_SOURCE = 404;
				public const int CV_CAP_PROP_XI_TRG_SOFTWARE = 405;
				public const int CV_CAP_PROP_XI_GPI_SELECTOR = 406;
				public const int CV_CAP_PROP_XI_GPI_MODE = 407;
				public const int CV_CAP_PROP_XI_GPI_LEVEL = 408;
				public const int CV_CAP_PROP_XI_GPO_SELECTOR = 409;
				public const int CV_CAP_PROP_XI_GPO_MODE = 410;
				public const int CV_CAP_PROP_XI_LED_SELECTOR = 411;
				public const int CV_CAP_PROP_XI_LED_MODE = 412;
				public const int CV_CAP_PROP_XI_MANUAL_WB = 413;
				public const int CV_CAP_PROP_XI_AUTO_WB = 414;
				public const int CV_CAP_PROP_XI_AEAG = 415;
				public const int CV_CAP_PROP_XI_EXP_PRIORITY = 416;
				public const int CV_CAP_PROP_XI_AE_MAX_LIMIT = 417;
				public const int CV_CAP_PROP_XI_AG_MAX_LIMIT = 418;
				public const int CV_CAP_PROP_XI_AEAG_LEVEL = 419;
				public const int CV_CAP_PROP_XI_TIMEOUT = 420;
				public const int CV_CAP_PROP_ANDROID_FLASH_MODE = 8001;
				public const int CV_CAP_PROP_ANDROID_FOCUS_MODE = 8002;
				public const int CV_CAP_PROP_ANDROID_WHITE_BALANCE = 8003;
				public const int CV_CAP_PROP_ANDROID_ANTIBANDING = 8004;
				public const int CV_CAP_PROP_ANDROID_FOCAL_LENGTH = 8005;
				public const int CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_NEAR = 8006;
				public const int CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_OPTIMAL = 8007;
				public const int CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_FAR = 8008;
				public const int CV_CAP_PROP_ANDROID_EXPOSE_LOCK = 8009;
				public const int CV_CAP_PROP_ANDROID_WHITEBALANCE_LOCK = 8010;
				public const int CV_CAP_PROP_IOS_DEVICE_FOCUS = 9001;
				public const int CV_CAP_PROP_IOS_DEVICE_EXPOSURE = 9002;
				public const int CV_CAP_PROP_IOS_DEVICE_FLASH = 9003;
				public const int CV_CAP_PROP_IOS_DEVICE_WHITEBALANCE = 9004;
				public const int CV_CAP_PROP_IOS_DEVICE_TORCH = 9005;
				public const int CV_CAP_PROP_GIGA_FRAME_OFFSET_X = 10001;
				public const int CV_CAP_PROP_GIGA_FRAME_OFFSET_Y = 10002;
				public const int CV_CAP_PROP_GIGA_FRAME_WIDTH_MAX = 10003;
				public const int CV_CAP_PROP_GIGA_FRAME_HEIGH_MAX = 10004;
				public const int CV_CAP_PROP_GIGA_FRAME_SENS_WIDTH = 10005;
				public const int CV_CAP_PROP_GIGA_FRAME_SENS_HEIGH = 10006;
				public const int CV_CAP_PROP_INTELPERC_PROFILE_COUNT = 11001;
				public const int CV_CAP_PROP_INTELPERC_PROFILE_IDX = 11002;
				public const int CV_CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE = 11003;
				public const int CV_CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE = 11004;
				public const int CV_CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD = 11005;
				public const int CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ = 11006;
				public const int CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT = 11007;
				public const int CV_CAP_ANDROID_COLOR_FRAME_BGR = 0;
				public const int CV_CAP_ANDROID_COLOR_FRAME = CV_CAP_ANDROID_COLOR_FRAME_BGR;
				public const int CV_CAP_ANDROID_GREY_FRAME = 1;
				public const int CV_CAP_ANDROID_COLOR_FRAME_RGB = 2;
				public const int CV_CAP_ANDROID_COLOR_FRAME_BGRA = 3;
				public const int CV_CAP_ANDROID_COLOR_FRAME_RGBA = 4;
				public const int CV_CAP_ANDROID_FLASH_MODE_AUTO = 0;
				public const int CV_CAP_ANDROID_FLASH_MODE_OFF = 0 + 1;
				public const int CV_CAP_ANDROID_FLASH_MODE_ON = 0 + 2;
				public const int CV_CAP_ANDROID_FLASH_MODE_RED_EYE = 0 + 3;
				public const int CV_CAP_ANDROID_FLASH_MODE_TORCH = 0 + 4;
				public const int CV_CAP_ANDROID_FOCUS_MODE_AUTO = 0;
				public const int CV_CAP_ANDROID_FOCUS_MODE_CONTINUOUS_VIDEO = 0 + 1;
				public const int CV_CAP_ANDROID_FOCUS_MODE_EDOF = 0 + 2;
				public const int CV_CAP_ANDROID_FOCUS_MODE_FIXED = 0 + 3;
				public const int CV_CAP_ANDROID_FOCUS_MODE_INFINITY = 0 + 4;
				public const int CV_CAP_ANDROID_FOCUS_MODE_MACRO = 0 + 5;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_AUTO = 0;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_CLOUDY_DAYLIGHT = 0 + 1;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_DAYLIGHT = 0 + 2;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_FLUORESCENT = 0 + 3;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_INCANDESCENT = 0 + 4;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_SHADE = 0 + 5;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_TWILIGHT = 0 + 6;
				public const int CV_CAP_ANDROID_WHITE_BALANCE_WARM_FLUORESCENT = 0 + 7;
				public const int CV_CAP_ANDROID_ANTIBANDING_50HZ = 0;
				public const int CV_CAP_ANDROID_ANTIBANDING_60HZ = 0 + 1;
				public const int CV_CAP_ANDROID_ANTIBANDING_AUTO = 0 + 2;
				public const int CV_CAP_ANDROID_ANTIBANDING_OFF = 0 + 3;
				public const int IMREAD_UNCHANGED = -1;
				public const int IMREAD_GRAYSCALE = 0;
				public const int IMREAD_COLOR = 1;
				public const int IMREAD_ANYDEPTH = 2;
				public const int IMREAD_ANYCOLOR = 4;
				public const int IMWRITE_JPEG_QUALITY = 1;
				public const int IMWRITE_PNG_COMPRESSION = 16;
				public const int IMWRITE_PNG_STRATEGY = 17;
				public const int IMWRITE_PNG_BILEVEL = 18;
				public const int IMWRITE_PNG_STRATEGY_DEFAULT = 0;
				public const int IMWRITE_PNG_STRATEGY_FILTERED = 1;
				public const int IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2;
				public const int IMWRITE_PNG_STRATEGY_RLE = 3;
				public const int IMWRITE_PNG_STRATEGY_FIXED = 4;
				public const int IMWRITE_PXM_BINARY = 32;
	
	
				//
				// C++:  Mat imdecode(Mat buf, int flags)
				//
	
				/**
 * <p>Reads an image from a buffer in memory.</p>
 *
 * <p>The function reads an image from the specified buffer in the memory.
 * If the buffer is too short or contains invalid data, the empty matrix/image
 * is returned.</p>
 *
 * <p>See "imread" for the list of supported formats and flags description.</p>
 *
 * <p>Note: In the case of color images, the decoded images will have the channels
 * stored in <code>B G R</code> order.</p>
 *
 * @param buf Input array or vector of bytes.
 * @param flags The same flags as in "imread".
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imdecode">org.opencv.highgui.Highgui.imdecode</a>
 */
				public static Mat imdecode (Mat buf, int flags)
				{
						if (buf != null)
								buf.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (highgui_Highgui_imdecode_10 (buf.nativeObj, flags));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  bool imencode(string ext, Mat img, vector_uchar& buf, vector_int params = vector<int>())
				//
	
				/**
 * <p>Encodes an image into a memory buffer.</p>
 *
 * <p>The function compresses the image and stores it in the memory buffer that is
 * resized to fit the result.
 * See "imwrite" for the list of supported formats and flags description.</p>
 *
 * <p>Note: <code>cvEncodeImage</code> returns single-row matrix of type
 * <code>CV_8UC1</code> that contains encoded image as array of bytes.</p>
 *
 * @param ext File extension that defines the output format.
 * @param img Image to be written.
 * @param buf Output buffer resized to fit the compressed image.
 * @param params Format-specific parameters. See "imwrite".
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imencode">org.opencv.highgui.Highgui.imencode</a>
 */
				public static bool imencode (string ext, Mat img, MatOfByte buf, MatOfInt _params)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (buf != null)
								buf.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat buf_mat = buf;
						Mat params_mat = _params;
						bool retVal = highgui_Highgui_imencode_10 (ext, img.nativeObj, buf_mat.nativeObj, params_mat.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				/**
 * <p>Encodes an image into a memory buffer.</p>
 *
 * <p>The function compresses the image and stores it in the memory buffer that is
 * resized to fit the result.
 * See "imwrite" for the list of supported formats and flags description.</p>
 *
 * <p>Note: <code>cvEncodeImage</code> returns single-row matrix of type
 * <code>CV_8UC1</code> that contains encoded image as array of bytes.</p>
 *
 * @param ext File extension that defines the output format.
 * @param img Image to be written.
 * @param buf Output buffer resized to fit the compressed image.
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imencode">org.opencv.highgui.Highgui.imencode</a>
 */
				public static bool imencode (string ext, Mat img, MatOfByte buf)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (buf != null)
								buf.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat buf_mat = buf;
						bool retVal = highgui_Highgui_imencode_11 (ext, img.nativeObj, buf_mat.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	
				//
				// C++:  Mat imread(string filename, int flags = 1)
				//
	
				/**
 * <p>Loads an image from a file.</p>
 *
 * <p>The function <code>imread</code> loads an image from the specified file and
 * returns it. If the image cannot be read (because of missing file, improper
 * permissions, unsupported or invalid format), the function returns an empty
 * matrix (<code>Mat.data==NULL</code>). Currently, the following file formats
 * are supported:</p>
 * <ul>
 *   <li> Windows bitmaps - <code>*.bmp, *.dib</code> (always supported)
 *   <li> JPEG files - <code>*.jpeg, *.jpg, *.jpe</code> (see the *Notes*
 * section)
 *   <li> JPEG 2000 files - <code>*.jp2</code> (see the *Notes* section)
 *   <li> Portable Network Graphics - <code>*.png</code> (see the *Notes*
 * section)
 *   <li> Portable image format - <code>*.pbm, *.pgm, *.ppm</code> (always
 * supported)
 *   <li> Sun rasters - <code>*.sr, *.ras</code> (always supported)
 *   <li> TIFF files - <code>*.tiff, *.tif</code> (see the *Notes* section)
 * </ul>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> The function determines the type of an image by the content, not by
 * the file extension.
 *   <li> On Microsoft Windows* OS and MacOSX*, the codecs shipped with an
 * OpenCV image (libjpeg, libpng, libtiff, and libjasper) are used by default.
 * So, OpenCV can always read JPEGs, PNGs, and TIFFs. On MacOSX, there is also
 * an option to use native MacOSX image readers. But beware that currently these
 * native image loaders give images with different pixel values because of the
 * color management embedded into MacOSX.
 *   <li> On Linux*, BSD flavors and other Unix-like open-source operating
 * systems, OpenCV looks for codecs supplied with an OS image. Install the
 * relevant packages (do not forget the development files, for example,
 * "libjpeg-dev", in Debian* and Ubuntu*) to get the codec support or turn on
 * the <code>OPENCV_BUILD_3RDPARTY_LIBS</code> flag in CMake.
 * </ul>
 *
 * <p>Note: In the case of color images, the decoded images will have the channels
 * stored in <code>B G R</code> order.</p>
 *
 * @param filename Name of file to be loaded.
 * @param flags Flags specifying the color type of a loaded image:
 * <ul>
 *   <li> CV_LOAD_IMAGE_ANYDEPTH - If set, return 16-bit/32-bit image when the
 * input has the corresponding depth, otherwise convert it to 8-bit.
 *   <li> CV_LOAD_IMAGE_COLOR - If set, always convert image to the color one
 *   <li> CV_LOAD_IMAGE_GRAYSCALE - If set, always convert image to the
 * grayscale one
 *   <li> >0 Return a 3-channel color image.
 * </ul>
 * <p>Note: In the current implementation the alpha channel, if any, is stripped
 * from the output image. Use negative value if you need the alpha channel.</p>
 * <ul>
 *   <li> =0 Return a grayscale image.
 *   <li> <0 Return the loaded image as is (with alpha channel).
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imread">org.opencv.highgui.Highgui.imread</a>
 */
				public static Mat imread (string filename, int flags)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
		
						Mat retVal = new Mat (highgui_Highgui_imread_10 (filename, flags));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
				/**
 * <p>Loads an image from a file.</p>
 *
 * <p>The function <code>imread</code> loads an image from the specified file and
 * returns it. If the image cannot be read (because of missing file, improper
 * permissions, unsupported or invalid format), the function returns an empty
 * matrix (<code>Mat.data==NULL</code>). Currently, the following file formats
 * are supported:</p>
 * <ul>
 *   <li> Windows bitmaps - <code>*.bmp, *.dib</code> (always supported)
 *   <li> JPEG files - <code>*.jpeg, *.jpg, *.jpe</code> (see the *Notes*
 * section)
 *   <li> JPEG 2000 files - <code>*.jp2</code> (see the *Notes* section)
 *   <li> Portable Network Graphics - <code>*.png</code> (see the *Notes*
 * section)
 *   <li> Portable image format - <code>*.pbm, *.pgm, *.ppm</code> (always
 * supported)
 *   <li> Sun rasters - <code>*.sr, *.ras</code> (always supported)
 *   <li> TIFF files - <code>*.tiff, *.tif</code> (see the *Notes* section)
 * </ul>
 *
 * <p>Note:</p>
 * <ul>
 *   <li> The function determines the type of an image by the content, not by
 * the file extension.
 *   <li> On Microsoft Windows* OS and MacOSX*, the codecs shipped with an
 * OpenCV image (libjpeg, libpng, libtiff, and libjasper) are used by default.
 * So, OpenCV can always read JPEGs, PNGs, and TIFFs. On MacOSX, there is also
 * an option to use native MacOSX image readers. But beware that currently these
 * native image loaders give images with different pixel values because of the
 * color management embedded into MacOSX.
 *   <li> On Linux*, BSD flavors and other Unix-like open-source operating
 * systems, OpenCV looks for codecs supplied with an OS image. Install the
 * relevant packages (do not forget the development files, for example,
 * "libjpeg-dev", in Debian* and Ubuntu*) to get the codec support or turn on
 * the <code>OPENCV_BUILD_3RDPARTY_LIBS</code> flag in CMake.
 * </ul>
 *
 * <p>Note: In the case of color images, the decoded images will have the channels
 * stored in <code>B G R</code> order.</p>
 *
 * @param filename Name of file to be loaded.
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imread">org.opencv.highgui.Highgui.imread</a>
 */
				public static Mat imread (string filename)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat retVal = new Mat (highgui_Highgui_imread_11 (filename));
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  bool imwrite(string filename, Mat img, vector_int params = vector<int>())
				//
		
				/**
 * <p>Saves an image to a specified file.</p>
 *
 * <p>The function <code>imwrite</code> saves the image to the specified file. The
 * image format is chosen based on the <code>filename</code> extension (see
 * "imread" for the list of extensions). Only 8-bit (or 16-bit unsigned
 * (<code>CV_16U</code>) in case of PNG, JPEG 2000, and TIFF) single-channel or
 * 3-channel (with 'BGR' channel order) images can be saved using this function.
 * If the format, depth or channel order is different, use "Mat.convertTo", and
 * "cvtColor" to convert it before saving. Or, use the universal "FileStorage"
 * I/O functions to save the image to XML or YAML format.
 * It is possible to store PNG images with an alpha channel using this function.
 * To do this, create 8-bit (or 16-bit) 4-channel image BGRA, where the alpha
 * channel goes last. Fully transparent pixels should have alpha set to 0, fully
 * opaque pixels should have alpha set to 255/65535. The sample below shows how
 * to create such a BGRA image and store to PNG file. It also demonstrates how
 * to set custom compression parameters <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>#include <vector></p>
 *
 * <p>#include <stdio.h></p>
 *
 * <p>#include <opencv2/opencv.hpp></p>
 *
 * <p>using namespace cv;</p>
 *
 * <p>using namespace std;</p>
 *
 * <p>void createAlphaMat(Mat &mat)</p>
 *
 *
 * <p>for (int i = 0; i < mat.rows; ++i) {</p>
 *
 * <p>for (int j = 0; j < mat.cols; ++j) {</p>
 *
 * <p>Vec4b& rgba = mat.at<Vec4b>(i, j);</p>
 *
 * <p>rgba[0] = UCHAR_MAX;</p>
 *
 * <p>rgba[1] = saturate_cast<uchar>((float (mat.cols - j)) / ((float)mat.cols) *
 * UCHAR_MAX);</p>
 *
 * <p>rgba[2] = saturate_cast<uchar>((float (mat.rows - i)) / ((float)mat.rows) *
 * UCHAR_MAX);</p>
 *
 * <p>rgba[3] = saturate_cast<uchar>(0.5 * (rgba[1] + rgba[2]));</p>
 *
 *
 *
 *
 * <p>int main(int argv, char argc)</p>
 *
 *
 * <p>// Create mat with alpha channel</p>
 *
 * <p>Mat mat(480, 640, CV_8UC4);</p>
 *
 * <p>createAlphaMat(mat);</p>
 *
 * <p>vector<int> compression_params;</p>
 *
 * <p>compression_params.push_back(CV_IMWRITE_PNG_COMPRESSION);</p>
 *
 * <p>compression_params.push_back(9);</p>
 *
 * <p>try {</p>
 *
 * <p>imwrite("alpha.png", mat, compression_params);</p>
 *
 *
 * <p>catch (runtime_error& ex) {</p>
 *
 * <p>fprintf(stderr, "Exception converting image to PNG format: %sn", ex.what());</p>
 *
 * <p>return 1;</p>
 *
 *
 * <p>fprintf(stdout, "Saved PNG file with alpha data.n");</p>
 *
 * <p>return 0;</p>
 *
 *
 * @param filename Name of the file.
 * @param img a img
 * @param params Format-specific save parameters encoded as pairs
 * <code>paramId_1, paramValue_1, paramId_2, paramValue_2,...</code>. The
 * following parameters are currently supported:
 * <ul>
 *   <li> For JPEG, it can be a quality (<code>CV_IMWRITE_JPEG_QUALITY</code>)
 * from 0 to 100 (the higher is the better). Default value is 95.
 *   <li> For PNG, it can be the compression level (<code>CV_IMWRITE_PNG_COMPRESSION</code>)
 * from 0 to 9. A higher value means a smaller size and longer compression time.
 * Default value is 3.
 *   <li> For PPM, PGM, or PBM, it can be a binary format flag (<code>CV_IMWRITE_PXM_BINARY</code>),
 * 0 or 1. Default value is 1.
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imwrite">org.opencv.highgui.Highgui.imwrite</a>
 */
				public static bool imwrite (string filename, Mat img, MatOfInt _params)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat params_mat = _params;
						bool retVal = highgui_Highgui_imwrite_10 (filename, img.nativeObj, params_mat.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
				/**
 * <p>Saves an image to a specified file.</p>
 *
 * <p>The function <code>imwrite</code> saves the image to the specified file. The
 * image format is chosen based on the <code>filename</code> extension (see
 * "imread" for the list of extensions). Only 8-bit (or 16-bit unsigned
 * (<code>CV_16U</code>) in case of PNG, JPEG 2000, and TIFF) single-channel or
 * 3-channel (with 'BGR' channel order) images can be saved using this function.
 * If the format, depth or channel order is different, use "Mat.convertTo", and
 * "cvtColor" to convert it before saving. Or, use the universal "FileStorage"
 * I/O functions to save the image to XML or YAML format.
 * It is possible to store PNG images with an alpha channel using this function.
 * To do this, create 8-bit (or 16-bit) 4-channel image BGRA, where the alpha
 * channel goes last. Fully transparent pixels should have alpha set to 0, fully
 * opaque pixels should have alpha set to 255/65535. The sample below shows how
 * to create such a BGRA image and store to PNG file. It also demonstrates how
 * to set custom compression parameters <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>#include <vector></p>
 *
 * <p>#include <stdio.h></p>
 *
 * <p>#include <opencv2/opencv.hpp></p>
 *
 * <p>using namespace cv;</p>
 *
 * <p>using namespace std;</p>
 *
 * <p>void createAlphaMat(Mat &mat)</p>
 *
 *
 * <p>for (int i = 0; i < mat.rows; ++i) {</p>
 *
 * <p>for (int j = 0; j < mat.cols; ++j) {</p>
 *
 * <p>Vec4b& rgba = mat.at<Vec4b>(i, j);</p>
 *
 * <p>rgba[0] = UCHAR_MAX;</p>
 *
 * <p>rgba[1] = saturate_cast<uchar>((float (mat.cols - j)) / ((float)mat.cols) *
 * UCHAR_MAX);</p>
 *
 * <p>rgba[2] = saturate_cast<uchar>((float (mat.rows - i)) / ((float)mat.rows) *
 * UCHAR_MAX);</p>
 *
 * <p>rgba[3] = saturate_cast<uchar>(0.5 * (rgba[1] + rgba[2]));</p>
 *
 *
 *
 *
 * <p>int main(int argv, char argc)</p>
 *
 *
 * <p>// Create mat with alpha channel</p>
 *
 * <p>Mat mat(480, 640, CV_8UC4);</p>
 *
 * <p>createAlphaMat(mat);</p>
 *
 * <p>vector<int> compression_params;</p>
 *
 * <p>compression_params.push_back(CV_IMWRITE_PNG_COMPRESSION);</p>
 *
 * <p>compression_params.push_back(9);</p>
 *
 * <p>try {</p>
 *
 * <p>imwrite("alpha.png", mat, compression_params);</p>
 *
 *
 * <p>catch (runtime_error& ex) {</p>
 *
 * <p>fprintf(stderr, "Exception converting image to PNG format: %sn", ex.what());</p>
 *
 * <p>return 1;</p>
 *
 *
 * <p>fprintf(stdout, "Saved PNG file with alpha data.n");</p>
 *
 * <p>return 0;</p>
 *
 *
 * @param filename Name of the file.
 * @param img a img
 *
 * @see <a href="http://docs.opencv.org/modules/highgui/doc/reading_and_writing_images_and_video.html#imwrite">org.opencv.highgui.Highgui.imwrite</a>
 */
				public static bool imwrite (string filename, Mat img)
				{
						if (img != null)
								img.ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						bool retVal = highgui_Highgui_imwrite_11 (filename, img.nativeObj);
		
						return retVal;
						#else
						return false;
						#endif
				}
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  Mat imdecode(Mat buf, int flags)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_Highgui_imdecode_10(IntPtr buf_nativeObj, int flags);
		
		// C++:  bool imencode(string ext, Mat img, vector_uchar& buf, vector_int params = vector<int>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_Highgui_imencode_10(string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj, IntPtr params_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_Highgui_imencode_11(string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj);
		
		// C++:  Mat imread(string filename, int flags = 1)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_Highgui_imread_10(string filename, int flags);
		
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr highgui_Highgui_imread_11(string filename);
		
		// C++:  bool imwrite(string filename, Mat img, vector_int params = vector<int>())
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_Highgui_imwrite_10(string filename, IntPtr img_nativeObj, IntPtr params_mat_nativeObj);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool highgui_Highgui_imwrite_11(string filename, IntPtr img_nativeObj);

#else
		
				// C++:  Mat imdecode(Mat buf, int flags)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_Highgui_imdecode_10 (IntPtr buf_nativeObj, int flags);
		
				// C++:  bool imencode(string ext, Mat img, vector_uchar& buf, vector_int params = vector<int>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_Highgui_imencode_10 (string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj, IntPtr params_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_Highgui_imencode_11 (string ext, IntPtr img_nativeObj, IntPtr buf_mat_nativeObj);
		
				// C++:  Mat imread(string filename, int flags = 1)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_Highgui_imread_10 (string filename, int flags);
		
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr highgui_Highgui_imread_11 (string filename);
		
				// C++:  bool imwrite(string filename, Mat img, vector_int params = vector<int>())
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_Highgui_imwrite_10 (string filename, IntPtr img_nativeObj, IntPtr params_mat_nativeObj);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern bool highgui_Highgui_imwrite_11 (string filename, IntPtr img_nativeObj);
		#endif
		}
}

