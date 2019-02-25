
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{


// C++: class Subdiv2D
		public class Subdiv2D : DisposableOpenCVObject
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												imgproc_Subdiv2D_delete (nativeObj);
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
				protected Subdiv2D (IntPtr addr)
				{
						nativeObj = addr;
				}
	
				public const int PTLOC_ERROR = -2;
				public const int PTLOC_OUTSIDE_RECT = -1;
				public const int PTLOC_INSIDE = 0;
				public const int PTLOC_VERTEX = 1;
				public const int PTLOC_ON_EDGE = 2;
				public const int NEXT_AROUND_ORG = 0x00;
				public const int NEXT_AROUND_DST = 0x22;
				public const int PREV_AROUND_ORG = 0x11;
				public const int PREV_AROUND_DST = 0x33;
				public const int NEXT_AROUND_LEFT = 0x13;
				public const int NEXT_AROUND_RIGHT = 0x31;
				public const int PREV_AROUND_LEFT = 0x20;
				public const int PREV_AROUND_RIGHT = 0x02;
	
	
				//
				// C++:   Subdiv2D::Subdiv2D()
				//
	
				public   Subdiv2D ()
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = imgproc_Subdiv2D_Subdiv2D_10 ();
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:   Subdiv2D::Subdiv2D(Rect rect)
				//
	
				public   Subdiv2D (Rect rect)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						nativeObj = imgproc_Subdiv2D_Subdiv2D_11 (rect.x, rect.y, rect.width, rect.height);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
				//
	
				public  int edgeDst (int edge, Point dstpt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] dstpt_out = new double[2];
						int retVal = imgproc_Subdiv2D_edgeDst_10 (nativeObj, edge, dstpt_out);
						if (dstpt != null) {
								dstpt.x = dstpt_out [0];
								dstpt.y = dstpt_out [1];
						}
						return retVal;
						#else
						return 0;
						#endif
				}
	
				public  int edgeDst (int edge)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_edgeDst_11 (nativeObj, edge);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
				//
	
				public  int edgeOrg (int edge, Point orgpt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] orgpt_out = new double[2];
						int retVal = imgproc_Subdiv2D_edgeOrg_10 (nativeObj, edge, orgpt_out);
						if (orgpt != null) {
								orgpt.x = orgpt_out [0];
								orgpt.y = orgpt_out [1];
						}
						return retVal;
						#else
						return 0;
						#endif
				}
	
				public  int edgeOrg (int edge)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_edgeOrg_11 (nativeObj, edge);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
				//
	
				public  int findNearest (Point pt, Point nearestPt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] nearestPt_out = new double[2];
						int retVal = imgproc_Subdiv2D_findNearest_10 (nativeObj, pt.x, pt.y, nearestPt_out);
						if (nearestPt != null) {
								nearestPt.x = nearestPt_out [0];
								nearestPt.y = nearestPt_out [1];
						}
						return retVal;
						#else
						return 0;
						#endif
				}
	
				public  int findNearest (Point pt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_findNearest_11 (nativeObj, pt.x, pt.y);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::getEdge(int edge, int nextEdgeType)
				//
	
				public  int getEdge (int edge, int nextEdgeType)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_getEdge_10 (nativeObj, edge, nextEdgeType);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  void Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
				//
	
				public  void getEdgeList (MatOfFloat4 edgeList)
				{
						if (edgeList != null)
								edgeList.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat edgeList_mat = edgeList;
						imgproc_Subdiv2D_getEdgeList_10 (nativeObj, edgeList_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
				//
	
				public  void getTriangleList (MatOfFloat6 triangleList)
				{
						if (triangleList != null)
								triangleList.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat triangleList_mat = triangleList;
						imgproc_Subdiv2D_getTriangleList_10 (nativeObj, triangleList_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  Point2f Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
				//
	
				public  Point getVertex (int vertex, int[] firstEdge)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] firstEdge_out = new double[1];
						double[] tmpArray = new double[2];

						imgproc_Subdiv2D_getVertex_10 (nativeObj, vertex, firstEdge_out, tmpArray);

						Point retVal = new Point (tmpArray);
						if (firstEdge != null)
								firstEdge [0] = (int)firstEdge_out [0];
						return retVal;
						#else
						return null;
						#endif
				}
	
				public  Point getVertex (int vertex)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] tmpArray = new double[2];

						imgproc_Subdiv2D_getVertex_11 (nativeObj, vertex, tmpArray);
		
						Point retVal = new Point (tmpArray);
		
						return retVal;
						#else
						return null;
						#endif
				}
	
	
				//
				// C++:  void Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
				//
	
				public  void getVoronoiFacetList (MatOfInt idx, List<MatOfPoint2f> facetList, MatOfPoint2f facetCenters)
				{
						if (idx != null)
								idx.ThrowIfDisposed ();
						if (facetCenters != null)
								facetCenters.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat idx_mat = idx;
						Mat facetList_mat = new Mat ();
						Mat facetCenters_mat = facetCenters;
						imgproc_Subdiv2D_getVoronoiFacetList_10 (nativeObj, idx_mat.nativeObj, facetList_mat.nativeObj, facetCenters_mat.nativeObj);
						Converters.Mat_to_vector_vector_Point2f (facetList_mat, facetList);
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void Subdiv2D::initDelaunay(Rect rect)
				//
	
				public  void initDelaunay (Rect rect)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						imgproc_Subdiv2D_initDelaunay_10 (nativeObj, rect.x, rect.y, rect.width, rect.height);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::insert(Point2f pt)
				//
	
				public  int insert (Point pt)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_insert_10 (nativeObj, pt.x, pt.y);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  void Subdiv2D::insert(vector_Point2f ptvec)
				//
	
				public  void insert (MatOfPoint2f ptvec)
				{
						if (ptvec != null)
								ptvec.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						Mat ptvec_mat = ptvec;
						imgproc_Subdiv2D_insert_11 (nativeObj, ptvec_mat.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
				//
	
				public  int locate (Point pt, int[] edge, int[] vertex)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						double[] edge_out = new double[1];
						double[] vertex_out = new double[1];
						int retVal = imgproc_Subdiv2D_locate_10 (nativeObj, pt.x, pt.y, edge_out, vertex_out);
						if (edge != null)
								edge [0] = (int)edge_out [0];
						if (vertex != null)
								vertex [0] = (int)vertex_out [0];
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::nextEdge(int edge)
				//
	
				public  int nextEdge (int edge)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_nextEdge_10 (nativeObj, edge);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::rotateEdge(int edge, int rotate)
				//
	
				public  int rotateEdge (int edge, int rotate)
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_rotateEdge_10 (nativeObj, edge, rotate);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int Subdiv2D::symEdge(int edge)
				//
	
				public  int symEdge (int edge)
				{
						ThrowIfDisposed ();
					
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = imgproc_Subdiv2D_symEdge_10 (nativeObj, edge);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			imgproc_Subdiv2D_delete(nativeObj);
//	}
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   Subdiv2D::Subdiv2D()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_10();
		
		// C++:   Subdiv2D::Subdiv2D(Rect rect)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_11(int rect_x, int rect_y, int rect_width, int rect_height);
		
		// C++:  int Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_edgeDst_10(IntPtr nativeObj, int edge, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] dstpt_out);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_edgeDst_11(IntPtr nativeObj, int edge);
		
		// C++:  int Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_edgeOrg_10(IntPtr nativeObj, int edge, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] orgpt_out);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_edgeOrg_11(IntPtr nativeObj, int edge);
		
		// C++:  int Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_findNearest_10(IntPtr nativeObj, double pt_x, double pt_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] nearestPt_out);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_findNearest_11(IntPtr nativeObj, double pt_x, double pt_y);
		
		// C++:  int Subdiv2D::getEdge(int edge, int nextEdgeType)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_getEdge_10(IntPtr nativeObj, int edge, int nextEdgeType);
		
		// C++:  void Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_getEdgeList_10(IntPtr nativeObj, IntPtr edgeList_mat_nativeObj);
		
		// C++:  void Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_getTriangleList_10(IntPtr nativeObj, IntPtr triangleList_mat_nativeObj);
		
		// C++:  Point2f Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_getVertex_10(IntPtr nativeObj, int vertex, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] firstEdge_out,[In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_getVertex_11(IntPtr nativeObj, int vertex, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
		// C++:  void Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_getVoronoiFacetList_10(IntPtr nativeObj, IntPtr idx_mat_nativeObj, IntPtr facetList_mat_nativeObj, IntPtr facetCenters_mat_nativeObj);
		
		// C++:  void Subdiv2D::initDelaunay(Rect rect)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_initDelaunay_10(IntPtr nativeObj, int rect_x, int rect_y, int rect_width, int rect_height);
		
		// C++:  int Subdiv2D::insert(Point2f pt)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_insert_10(IntPtr nativeObj, double pt_x, double pt_y);
		
		// C++:  void Subdiv2D::insert(vector_Point2f ptvec)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_insert_11(IntPtr nativeObj, IntPtr ptvec_mat_nativeObj);
		
		// C++:  int Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_locate_10(IntPtr nativeObj, double pt_x, double pt_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] edge_out, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] vertex_out);
		
		// C++:  int Subdiv2D::nextEdge(int edge)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_nextEdge_10(IntPtr nativeObj, int edge);
		
		// C++:  int Subdiv2D::rotateEdge(int edge, int rotate)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_rotateEdge_10(IntPtr nativeObj, int edge, int rotate);
		
		// C++:  int Subdiv2D::symEdge(int edge)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int imgproc_Subdiv2D_symEdge_10(IntPtr nativeObj, int edge);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void imgproc_Subdiv2D_delete(IntPtr nativeObj);

#else
		
				// C++:   Subdiv2D::Subdiv2D()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_10 ();
		
				// C++:   Subdiv2D::Subdiv2D(Rect rect)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr imgproc_Subdiv2D_Subdiv2D_11 (int rect_x, int rect_y, int rect_width, int rect_height);
		
				// C++:  int Subdiv2D::edgeDst(int edge, Point2f* dstpt = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_edgeDst_10 (IntPtr nativeObj, int edge, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] dstpt_out);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_edgeDst_11 (IntPtr nativeObj, int edge);
		
				// C++:  int Subdiv2D::edgeOrg(int edge, Point2f* orgpt = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_edgeOrg_10 (IntPtr nativeObj, int edge, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] orgpt_out);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_edgeOrg_11 (IntPtr nativeObj, int edge);
		
				// C++:  int Subdiv2D::findNearest(Point2f pt, Point2f* nearestPt = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_findNearest_10 (IntPtr nativeObj, double pt_x, double pt_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] nearestPt_out);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_findNearest_11 (IntPtr nativeObj, double pt_x, double pt_y);
		
				// C++:  int Subdiv2D::getEdge(int edge, int nextEdgeType)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_getEdge_10 (IntPtr nativeObj, int edge, int nextEdgeType);
		
				// C++:  void Subdiv2D::getEdgeList(vector_Vec4f& edgeList)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_getEdgeList_10 (IntPtr nativeObj, IntPtr edgeList_mat_nativeObj);
		
				// C++:  void Subdiv2D::getTriangleList(vector_Vec6f& triangleList)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_getTriangleList_10 (IntPtr nativeObj, IntPtr triangleList_mat_nativeObj);
		
				// C++:  Point2f Subdiv2D::getVertex(int vertex, int* firstEdge = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_getVertex_10 (IntPtr nativeObj, int vertex, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] firstEdge_out, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_getVertex_11 (IntPtr nativeObj, int vertex, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
		
				// C++:  void Subdiv2D::getVoronoiFacetList(vector_int idx, vector_vector_Point2f& facetList, vector_Point2f& facetCenters)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_getVoronoiFacetList_10 (IntPtr nativeObj, IntPtr idx_mat_nativeObj, IntPtr facetList_mat_nativeObj, IntPtr facetCenters_mat_nativeObj);
		
				// C++:  void Subdiv2D::initDelaunay(Rect rect)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_initDelaunay_10 (IntPtr nativeObj, int rect_x, int rect_y, int rect_width, int rect_height);
		
				// C++:  int Subdiv2D::insert(Point2f pt)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_insert_10 (IntPtr nativeObj, double pt_x, double pt_y);
		
				// C++:  void Subdiv2D::insert(vector_Point2f ptvec)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_insert_11 (IntPtr nativeObj, IntPtr ptvec_mat_nativeObj);
		
				// C++:  int Subdiv2D::locate(Point2f pt, int& edge, int& vertex)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_locate_10 (IntPtr nativeObj, double pt_x, double pt_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] edge_out, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] vertex_out);
		
				// C++:  int Subdiv2D::nextEdge(int edge)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_nextEdge_10 (IntPtr nativeObj, int edge);
		
				// C++:  int Subdiv2D::rotateEdge(int edge, int rotate)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_rotateEdge_10 (IntPtr nativeObj, int edge, int rotate);
		
				// C++:  int Subdiv2D::symEdge(int edge)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int imgproc_Subdiv2D_symEdge_10 (IntPtr nativeObj, int edge);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void imgproc_Subdiv2D_delete (IntPtr nativeObj);
		#endif
		}
}

