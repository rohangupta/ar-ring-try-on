using System;
using System.Collections.Generic;




namespace  OpenCVForUnity
{
		public class Converters
		{
	
				public static Mat vector_Point_to_Mat (List<Point> pts)
				{
						return vector_Point_to_Mat (pts, CvType.CV_32S);
				}
	
				public static Mat vector_Point2f_to_Mat (List<Point> pts)
				{
						return vector_Point_to_Mat (pts, CvType.CV_32F);
				}
	
				public static Mat vector_Point2d_to_Mat (List<Point> pts)
				{
						return vector_Point_to_Mat (pts, CvType.CV_64F);
				}
	
				public static Mat vector_Point_to_Mat (List<Point> pts, int typeDepth)
				{
						Mat res;
						int count = (pts != null) ? pts.Count : 0;
						if (count > 0) {
								switch (typeDepth) {
								case CvType.CV_32S:
										{
												res = new Mat (count, 1, CvType.CV_32SC2);
												int[] buff = new int[count * 2];
												for (int i = 0; i < count; i++) {
														Point p = pts [i];
														buff [i * 2] = (int)p.x;
														buff [i * 2 + 1] = (int)p.y;
												}
												res.put (0, 0, buff);

										}
										break;
				
								case CvType.CV_32F:
										{
												res = new Mat (count, 1, CvType.CV_32FC2);
												float[] buff = new float[count * 2];
												for (int i = 0; i < count; i++) {
														Point p = pts [i];
														buff [i * 2] = (float)p.x;
														buff [i * 2 + 1] = (float)p.y;
												}
												res.put (0, 0, buff);
										}
										break;
				
								case CvType.CV_64F:
										{
												res = new Mat (count, 1, CvType.CV_64FC2);
												double[] buff = new double[count * 2];
												for (int i = 0; i < count; i++) {
														Point p = pts [i];
														buff [i * 2] = p.x;
														buff [i * 2 + 1] = p.y;
												}
												res.put (0, 0, buff);
										}
										break;
				
								default:
										throw new CvException ("'typeDepth' can be CV_32S, CV_32F or CV_64F");
								}
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static Mat vector_Point3i_to_Mat (List<Point3> pts)
				{
						return vector_Point3_to_Mat (pts, CvType.CV_32S);
				}
	
				public static Mat vector_Point3f_to_Mat (List<Point3> pts)
				{
						return vector_Point3_to_Mat (pts, CvType.CV_32F);
				}
	
				public static Mat vector_Point3d_to_Mat (List<Point3> pts)
				{
						return vector_Point3_to_Mat (pts, CvType.CV_64F);
				}
	
				public static Mat vector_Point3_to_Mat (List<Point3> pts, int typeDepth)
				{
						Mat res;
						int count = (pts != null) ? pts.Count : 0;
						if (count > 0) {
								switch (typeDepth) {
								case CvType.CV_32S:
										{
												res = new Mat (count, 1, CvType.CV_32SC3);
												int[] buff = new int[count * 3];
												for (int i = 0; i < count; i++) {
														Point3 p = pts [i];
														buff [i * 3] = (int)p.x;
														buff [i * 3 + 1] = (int)p.y;
														buff [i * 3 + 2] = (int)p.z;
												}
												res.put (0, 0, buff);
										}
										break;
				
								case CvType.CV_32F:
										{
												res = new Mat (count, 1, CvType.CV_32FC3);
												float[] buff = new float[count * 3];
												for (int i = 0; i < count; i++) {
														Point3 p = pts [i];
														buff [i * 3] = (float)p.x;
														buff [i * 3 + 1] = (float)p.y;
														buff [i * 3 + 2] = (float)p.z;
												}
												res.put (0, 0, buff);
										}
										break;
				
								case CvType.CV_64F:
										{
												res = new Mat (count, 1, CvType.CV_64FC3);
												double[] buff = new double[count * 3];
												for (int i = 0; i < count; i++) {
														Point3 p = pts [i];
														buff [i * 3] = p.x;
														buff [i * 3 + 1] = p.y;
														buff [i * 3 + 2] = p.z;
												}
												res.put (0, 0, buff);
										}
										break;
				
								default:
										throw new CvException ("'typeDepth' can be CV_32S, CV_32F or CV_64F");
								}
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_Point2f (Mat m, List<Point> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						Mat_to_vector_Point (m, pts);
				}
	
				public static void Mat_to_vector_Point2d (Mat m, List<Point> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						Mat_to_vector_Point (m, pts);
				}
	
				public static void Mat_to_vector_Point (Mat m, List<Point> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						if (pts == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						int type = m.type ();
						if (m.cols () != 1)
								throw new CvException ("Input Mat should have one column\n" + m);
		
						pts.Clear ();
						if (type == CvType.CV_32SC2) {
								int[] buff = new int[2 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point (buff [i * 2], buff [i * 2 + 1]));
								}
						} else if (type == CvType.CV_32FC2) {
								float[] buff = new float[2 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point (buff [i * 2], buff [i * 2 + 1]));
								}
						} else if (type == CvType.CV_64FC2) {
								double[] buff = new double[2 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point (buff [i * 2], buff [i * 2 + 1]));
								}
						} else {
								throw new CvException (
				"Input Mat should be of CV_32SC2, CV_32FC2 or CV_64FC2 type\n" + m);
						}
				}
	
				public static void Mat_to_vector_Point3i (Mat m, List<Point3> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						Mat_to_vector_Point3 (m, pts);
				}
	
				public static void Mat_to_vector_Point3f (Mat m, List<Point3> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						Mat_to_vector_Point3 (m, pts);
				}
	
				public static void Mat_to_vector_Point3d (Mat m, List<Point3> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						Mat_to_vector_Point3 (m, pts);
				}
	
				public static void Mat_to_vector_Point3 (Mat m, List<Point3> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						if (pts == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						int type = m.type ();
						if (m.cols () != 1)
								throw new CvException ("Input Mat should have one column\n" + m);
		
						pts.Clear ();
						if (type == CvType.CV_32SC3) {
								int[] buff = new int[3 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point3 (buff [i * 3], buff [i * 3 + 1], buff [i * 3 + 2]));
								}
						} else if (type == CvType.CV_32FC3) {
								float[] buff = new float[3 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point3 (buff [i * 3], buff [i * 3 + 1], buff [i * 3 + 2]));
								}
						} else if (type == CvType.CV_64FC3) {
								double[] buff = new double[3 * count];
								m.get (0, 0, buff);
								for (int i = 0; i < count; i++) {
										pts.Add (new Point3 (buff [i * 3], buff [i * 3 + 1], buff [i * 3 + 2]));
								}
						} else {
								throw new CvException (
				"Input Mat should be of CV_32SC3, CV_32FC3 or CV_64FC3 type\n" + m);
						}
				}
	
				public static Mat vector_Mat_to_Mat (List<Mat> mats)
				{
						Mat res;
						int count = (mats != null) ? mats.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_32SC2);
								int[] buff = new int[count * 2];
								for (int i = 0; i < count; i++) {
										long addr = mats [i].nativeObj.ToInt64 ();//TODO:@check
										buff [i * 2] = (int)(addr >> 32);
										buff [i * 2 + 1] = (int)(addr & 0xffffffff);
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_Mat (Mat m, List<Mat> mats)
				{
if (m != null)m.ThrowIfDisposed ();

						if (mats == null)
								throw new CvException ("mats == null");
						int count = m.rows ();
						if (CvType.CV_32SC2 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);
		
						mats.Clear ();
						int[] buff = new int[count * 2];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								long addr = (((long)buff [i * 2]) << 32) | (((long)buff [i * 2 + 1]) & 0xffffffffL);
//			mats.add(new Mat(addr));
								mats.Add (new Mat (new IntPtr (addr)));//TODO:@check

						}
				}
	
				public static Mat vector_float_to_Mat (List<float> fs)
				{
						Mat res;
						int count = (fs != null) ? fs.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_32FC1);
								float[] buff = new float[count];
								for (int i = 0; i < count; i++) {
										float f = fs [i];
										buff [i] = f;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_float (Mat m, List<float> fs)
				{
if (m != null)m.ThrowIfDisposed ();

						if (fs == null)
								throw new CvException ("fs == null");
						int count = m.rows ();
						if (CvType.CV_32FC1 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_32FC1 != m.type() ||  m.cols()!=1\n" + m);
		
						fs.Clear ();
						float[] buff = new float[count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								fs.Add (buff [i]);
						}
				}
	
				public static Mat vector_uchar_to_Mat (List<byte> bs)
				{
						Mat res;
						int count = (bs != null) ? bs.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_8UC1);
								byte[] buff = new byte[count];
								for (int i = 0; i < count; i++) {
										byte b = bs [i];
										buff [i] = b;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_uchar (Mat m, List<byte> us)
				{
if (m != null)m.ThrowIfDisposed ();

						if (us == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						if (CvType.CV_8UC1 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_8UC1 != m.type() ||  m.cols()!=1\n" + m);
		
						us.Clear ();
						byte[] buff = new byte[count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								us.Add (buff [i]);
						}
				}
	
				public static Mat vector_char_to_Mat (List<byte> bs)
				{
						Mat res;
						int count = (bs != null) ? bs.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_8SC1);
								byte[] buff = new byte[count];
								for (int i = 0; i < count; i++) {
										byte b = bs [i];
										buff [i] = b;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static Mat vector_int_to_Mat (List<int> _is)
				{
						Mat res;
						int count = (_is != null) ? _is.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_32SC1);
								int[] buff = new int[count];
								for (int i = 0; i < count; i++) {
										int v = _is [i];
										buff [i] = v;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_int (Mat m, List<int> _is)
				{
if (m != null)m.ThrowIfDisposed ();

						if (_is == null)
								throw new CvException ("is == null");
						int count = m.rows ();
						if (CvType.CV_32SC1 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_32SC1 != m.type() ||  m.cols()!=1\n" + m);
		
						_is.Clear ();
						int[] buff = new int[count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								_is.Add (buff [i]);
						}
				}
	
				public static void Mat_to_vector_char (Mat m, List<byte> bs)
				{
if (m != null)m.ThrowIfDisposed ();

						if (bs == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						if (CvType.CV_8SC1 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_8SC1 != m.type() ||  m.cols()!=1\n" + m);
		
						bs.Clear ();
						byte[] buff = new byte[count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								bs.Add (buff [i]);
						}
				}
	
				public static Mat vector_Rect_to_Mat (List<Rect> rs)
				{
						Mat res;
						int count = (rs != null) ? rs.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_32SC4);
								int[] buff = new int[4 * count];
								for (int i = 0; i < count; i++) {
										Rect r = rs [i];
										buff [4 * i] = r.x;
										buff [4 * i + 1] = r.y;
										buff [4 * i + 2] = r.width;
										buff [4 * i + 3] = r.height;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_Rect (Mat m, List<Rect> rs)
				{
if (m != null)m.ThrowIfDisposed ();

						if (rs == null)
								throw new CvException ("rs == null");
						int count = m.rows ();
						if (CvType.CV_32SC4 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_32SC4 != m.type() ||  m.rows()!=1\n" + m);
		
						rs.Clear ();
						int[] buff = new int[4 * count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								rs.Add (new Rect (buff [4 * i], buff [4 * i + 1], buff [4 * i + 2], buff [4 * i + 3]));
						}
				}
	
				public static Mat vector_KeyPoint_to_Mat (List<KeyPoint> kps)
				{
						Mat res;
						int count = (kps != null) ? kps.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_64FC (7));
								double[] buff = new double[count * 7];
								for (int i = 0; i < count; i++) {
										KeyPoint kp = kps [i];
										buff [7 * i] = kp.pt.x;
										buff [7 * i + 1] = kp.pt.y;
										buff [7 * i + 2] = kp.size;
										buff [7 * i + 3] = kp.angle;
										buff [7 * i + 4] = kp.response;
										buff [7 * i + 5] = kp.octave;
										buff [7 * i + 6] = kp.class_id;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_KeyPoint (Mat m, List<KeyPoint> kps)
				{
if (m != null)m.ThrowIfDisposed ();

						if (kps == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						if (CvType.CV_64FC (7) != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_64FC(7) != m.type() ||  m.cols()!=1\n" + m);
		
						kps.Clear ();
						double[] buff = new double[7 * count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								kps.Add (new KeyPoint ((float)buff [7 * i], (float)buff [7 * i + 1], (float)buff [7 * i + 2], (float)buff [7 * i + 3],
			                     (float)buff [7 * i + 4], (int)buff [7 * i + 5], (int)buff [7 * i + 6]));
						}
				}
	
				// vector_vector_Point
				public static Mat vector_vector_Point_to_Mat (List<MatOfPoint> pts, List<Mat> mats)
				{
						Mat res;
						int lCount = (pts != null) ? pts.Count : 0;
						if (lCount > 0) {
								foreach (MatOfPoint vpt in pts)
										mats.Add (vpt);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_vector_Point (Mat m, List<MatOfPoint> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						if (pts == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						foreach (Mat mi in mats) {
								MatOfPoint pt = new MatOfPoint (mi);
								pts.Add (pt);
						}
				}
	
				// vector_vector_Point2f
				public static void Mat_to_vector_vector_Point2f (Mat m, List<MatOfPoint2f> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						if (pts == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						foreach (Mat mi in mats) {
								MatOfPoint2f pt = new MatOfPoint2f (mi);
								pts.Add (pt);
						}
				}
	
				// vector_vector_Point2f
				public static Mat vector_vector_Point2f_to_Mat (List<MatOfPoint2f> pts, List<Mat> mats)
				{
						Mat res;
						int lCount = (pts != null) ? pts.Count : 0;
						if (lCount > 0) {
								foreach (MatOfPoint2f vpt in pts)
										mats.Add (vpt);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				// vector_vector_Point3f
				public static void Mat_to_vector_vector_Point3f (Mat m, List<MatOfPoint3f> pts)
				{
if (m != null)m.ThrowIfDisposed ();

						if (pts == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						foreach (Mat mi in mats) {
								MatOfPoint3f pt = new MatOfPoint3f (mi);
								pts.Add (pt);
						}
				}
	
				// vector_vector_Point3f
				public static Mat vector_vector_Point3f_to_Mat (List<MatOfPoint3f> pts, List<Mat> mats)
				{
						Mat res;
						int lCount = (pts != null) ? pts.Count : 0;
						if (lCount > 0) {
								foreach (MatOfPoint3f vpt in pts)
										mats.Add (vpt);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				// vector_vector_KeyPoint
				public static Mat vector_vector_KeyPoint_to_Mat (List<MatOfKeyPoint> kps, List<Mat> mats)
				{
						Mat res;
						int lCount = (kps != null) ? kps.Count : 0;
						if (lCount > 0) {
								foreach (MatOfKeyPoint vkp in kps)
										mats.Add (vkp);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_vector_KeyPoint (Mat m, List<MatOfKeyPoint> kps)
				{
if (m != null)m.ThrowIfDisposed ();

						if (kps == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						foreach (Mat mi in mats) {
								MatOfKeyPoint vkp = new MatOfKeyPoint (mi);
								kps.Add (vkp);
						}
				}
	
				public static Mat vector_double_to_Mat (List<double> ds)
				{
						Mat res;
						int count = (ds != null) ? ds.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_64FC1);
								double[] buff = new double[count];
								for (int i = 0; i < count; i++) {
										double v = ds [i];
										buff [i] = v;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_double (Mat m, List<double> ds)
				{
if (m != null)m.ThrowIfDisposed ();

						if (ds == null)
								throw new CvException ("ds == null");
						int count = m.rows ();
						if (CvType.CV_64FC1 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_64FC1 != m.type() ||  m.cols()!=1\n" + m);
		
						ds.Clear ();
						double[] buff = new double[count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								ds.Add (buff [i]);
						}
				}
	
				public static Mat vector_DMatch_to_Mat (List<DMatch> matches)
				{
						Mat res;
						int count = (matches != null) ? matches.Count : 0;
						if (count > 0) {
								res = new Mat (count, 1, CvType.CV_64FC4);
								double[] buff = new double[count * 4];
								for (int i = 0; i < count; i++) {
										DMatch m = matches [i];
										buff [4 * i] = m.queryIdx;
										buff [4 * i + 1] = m.trainIdx;
										buff [4 * i + 2] = m.imgIdx;
										buff [4 * i + 3] = m.distance;
								}
								res.put (0, 0, buff);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_DMatch (Mat m, List<DMatch> matches)
				{
if (m != null)m.ThrowIfDisposed ();

						if (matches == null)
								throw new CvException ("Output List can't be null");
						int count = m.rows ();
						if (CvType.CV_64FC4 != m.type () || m.cols () != 1)
								throw new CvException (
				"CvType.CV_64FC4 != m.type() ||  m.cols()!=1\n" + m);
		
						matches.Clear ();
						double[] buff = new double[4 * count];
						m.get (0, 0, buff);
						for (int i = 0; i < count; i++) {
								matches.Add (new DMatch ((int)buff [4 * i], (int)buff [4 * i + 1], (int)buff [4 * i + 2], (float)buff [4 * i + 3]));
						}
				}
	
				// vector_vector_DMatch
				public static Mat vector_vector_DMatch_to_Mat (List<MatOfDMatch> lvdm, List<Mat> mats)
				{
						Mat res;
						int lCount = (lvdm != null) ? lvdm.Count : 0;
						if (lCount > 0) {
								foreach (MatOfDMatch vdm in lvdm)
										mats.Add (vdm);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_vector_DMatch (Mat m, List<MatOfDMatch> lvdm)
				{
if (m != null)m.ThrowIfDisposed ();

						if (lvdm == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						lvdm.Clear ();
						foreach (Mat mi in mats) {
								MatOfDMatch vdm = new MatOfDMatch (mi);
								lvdm.Add (vdm);
						}
				}
	
				// vector_vector_char
				public static Mat vector_vector_char_to_Mat (List<MatOfByte> lvb, List<Mat> mats)
				{
						Mat res;
						int lCount = (lvb != null) ? lvb.Count : 0;
						if (lCount > 0) {
								foreach (MatOfByte vb in lvb)
										mats.Add (vb);
								res = vector_Mat_to_Mat (mats);
						} else {
								res = new Mat ();
						}
						return res;
				}
	
				public static void Mat_to_vector_vector_char (Mat m, List<List<byte>> llb)
				{
if (m != null)m.ThrowIfDisposed ();

						if (llb == null)
								throw new CvException ("Output List can't be null");
		
						if (m == null)
								throw new CvException ("Input Mat can't be null");
		
						List<Mat> mats = new List<Mat> (m.rows ());
						Mat_to_vector_Mat (m, mats);
						foreach (Mat mi in mats) {
								List<byte> lb = new List<byte> ();
								Mat_to_vector_char (mi, lb);
								llb.Add (lb);
						}
				}
		}
}
