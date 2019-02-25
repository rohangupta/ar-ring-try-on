using System;
using System.Collections.Generic;

namespace OpenCVForUnity{


public class MatOfFloat6 : Mat {
	// 32FC6
	private const int _depth = CvType.CV_32F;
	private const int _channels = 6;
	
	public MatOfFloat6() : base() {
		
	}
	
		protected MatOfFloat6(IntPtr addr) : base(addr) {
		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat");
		//FIXME: do we need release() here?
	}
	
	public static MatOfFloat6 fromNativeAddr(IntPtr addr) {
		return new MatOfFloat6(addr);
	}
	
	public MatOfFloat6(Mat m) : base(m, Range.all()){
if (m != null)m.ThrowIfDisposed ();

		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat");
		//FIXME: do we need release() here?
	}
	
	public MatOfFloat6(params float[] a) : base() {
		
		fromArray(a);
	}
	
	public void alloc(int elemNumber) {
		if(elemNumber>0)
			base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
	}
	
	public void fromArray(params float[] a) {
		if(a==null || a.Length==0)
			return;
		int num = a.Length / _channels;
		alloc(num);
		put(0, 0, a); //TODO: check ret val!
	}
	
	public float[] toArray() {
		int num = checkVector(_channels, _depth);
		if(num < 0)
			throw new CvException("Native Mat has unexpected type or size: " + ToString());
		float[] a = new float[num * _channels];
		if(num == 0)
			return a;
		get(0, 0, a); //TODO: check ret val!
		return a;
	}
	
	public void fromList(List<float> lb) {
		if(lb==null || lb.Count==0)
			return;
		float[] ab = lb.ToArray();
		float[] a = new float[ab.Length];
		for(int i=0; i<ab.Length; i++)
			a[i] = ab[i];
		fromArray(a);
	}
	
	public List<float> toList() {
		float[] a = toArray();
		float[] ab = new float[a.Length];
		for(int i=0; i<a.Length; i++)
			ab[i] = a[i];
		return new List<float>(ab);
	}
}
}
