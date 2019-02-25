using System;
using System.Collections.Generic;

namespace OpenCVForUnity
{

public class MatOfPoint3 : Mat {
	// 32SC3
	private const int _depth = CvType.CV_32S;
	private const int _channels = 3;
	
	public MatOfPoint3() : base() {
		
	}
	
		protected MatOfPoint3(IntPtr addr) : base(addr) {
		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat");
		//FIXME: do we need release() here?
	}
	
	public static MatOfPoint3 fromNativeAddr(IntPtr addr) {
		return new MatOfPoint3(addr);
	}
	
	public MatOfPoint3(Mat m) : base(m, Range.all()) {
if (m != null)m.ThrowIfDisposed ();

		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat");
		//FIXME: do we need release() here?
	}
	
	public MatOfPoint3(params Point3[] a) : base() {
		
		fromArray(a);
	}
	
	public void alloc(int elemNumber) {
		if(elemNumber>0)
			base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
	}
	
	public void fromArray(params Point3[] a) {
		if(a==null || a.Length==0)
			return;
		int num = a.Length;
		alloc(num);
		int[] buff = new int[num * _channels];
		for(int i=0; i<num; i++) {
			Point3 p = a[i];
			buff[_channels*i+0] = (int) p.x;
			buff[_channels*i+1] = (int) p.y;
			buff[_channels*i+2] = (int) p.z;
		}
		put(0, 0, buff); //TODO: check ret val!
	}
	
	public Point3[] toArray() {
		int num = (int) total();
		Point3[] ap = new Point3[num];
		if(num == 0)
			return ap;
		int[] buff = new int[num * _channels];
		get(0, 0, buff); //TODO: check ret val!
		for(int i=0; i<num; i++)
			ap[i] = new Point3(buff[i*_channels], buff[i*_channels+1], buff[i*_channels+2]);
		return ap;
	}
	
	public void fromList(List<Point3> lp) {
		Point3[] ap = lp.ToArray();
		fromArray(ap);
	}
	
	public List<Point3> toList() {
		Point3[] ap = toArray();
		return new List<Point3>(ap);
	}
}
}

