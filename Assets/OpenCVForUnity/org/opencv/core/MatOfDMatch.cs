using System;
using System.Collections.Generic;



namespace OpenCVForUnity{
	

public class MatOfDMatch : Mat {
	// 32FC4
	private const int _depth = CvType.CV_32F;
	private const int _channels = 4;
	
	public MatOfDMatch() : base() {
		
	}
	
		protected MatOfDMatch(IntPtr addr) : base(addr) {
		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat: " + ToString());
		//FIXME: do we need release() here?
	}
	
	public static MatOfDMatch fromNativeAddr(IntPtr addr) {
		return new MatOfDMatch(addr);
	}
	
	public MatOfDMatch(Mat m) : base(m, Range.all()){
if (m != null)m.ThrowIfDisposed ();

		
		if( !empty() && checkVector(_channels, _depth) < 0 )
			throw new CvException("Incompatible Mat: " + ToString());
		//FIXME: do we need release() here?
	}
	
	public MatOfDMatch(params DMatch[] ap) : base(){
		
		fromArray(ap);
	}
	
	public void alloc(int elemNumber) {
		if(elemNumber>0)
			base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
	}
	
	
	public void fromArray(params DMatch[] a) {
		if(a==null || a.Length==0)
			return;
		int num = a.Length;
		alloc(num);
		float[] buff = new float[num * _channels];
		for(int i=0; i<num; i++) {
			DMatch m = a[i];
			buff[_channels*i+0] = m.queryIdx;
			buff[_channels*i+1] = m.trainIdx;
			buff[_channels*i+2] = m.imgIdx;
			buff[_channels*i+3] = m.distance;
		}
		put(0, 0, buff); //TODO: check ret val!
	}
	
	public DMatch[] toArray() {
		int num = (int) total();
		DMatch[] a = new DMatch[num];
		if(num == 0)
			return a;
		float[] buff = new float[num * _channels];
		get(0, 0, buff); //TODO: check ret val!
		for(int i=0; i<num; i++)
			a[i] = new DMatch((int) buff[_channels*i+0], (int) buff[_channels*i+1], (int) buff[_channels*i+2], buff[_channels*i+3]);
		return a;
	}
	
	public void fromList(List<DMatch> ldm) {
		DMatch[] adm = ldm.ToArray();
		fromArray(adm);
	}
	
	public List<DMatch> toList() {
		DMatch[] adm = toArray();
		return new List<DMatch>(adm);
	}
}
}
