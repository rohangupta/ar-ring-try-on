using System;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class MatOfDouble : Mat
		{
				// 64FC(x)
				private const int _depth = CvType.CV_64F;
				private const int _channels = 1;
	
				public MatOfDouble () : base()
				{
		
				}
	
				protected MatOfDouble (IntPtr addr) : base(addr)
				{
		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public static MatOfDouble fromNativeAddr (IntPtr addr)
				{
						return new MatOfDouble (addr);
				}
	
				public MatOfDouble (Mat m) : base(m, Range.all())
				{
if (m != null)m.ThrowIfDisposed ();

		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public MatOfDouble (params double[] a) : base()
				{
		
						fromArray (a);
				}
	
				public void alloc (int elemNumber)
				{
						if (elemNumber > 0)
								base.create (elemNumber, 1, CvType.makeType (_depth, _channels));
				}
	
				public void fromArray (params double[] a)
				{
						if (a == null || a.Length == 0)
								return;
						int num = a.Length / _channels;
						alloc (num);
						put (0, 0, a); //TODO: check ret val!
				}
	
				public double[] toArray ()
				{
						int num = checkVector (_channels, _depth);
						if (num < 0)
								throw new CvException ("Native Mat has unexpected type or size: " + ToString ());
						double[] a = new double[num * _channels];
						if (num == 0)
								return a;
						get (0, 0, a); //TODO: check ret val!
						return a;
				}
	
				public void fromList (List<double> lb)
				{
						if (lb == null || lb.Count == 0)
								return;
		
						fromArray (lb.ToArray ());
				}
	
				public List<double> toList ()
				{
						double[] a = toArray ();
		
						return new List<double> (a);
				}
		}
}
