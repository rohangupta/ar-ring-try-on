using System;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class MatOfInt : Mat
		{
				// 32SC1
				private const int _depth = CvType.CV_32S;
				private const int _channels = 1;
	
				public MatOfInt () : base()
				{
		
				}
	
				protected MatOfInt (IntPtr addr) : base(addr)
				{
		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public static MatOfInt fromNativeAddr (IntPtr addr)
				{
						return new MatOfInt (addr);
				}
	
				public MatOfInt (Mat m) : base(m, Range.all())
				{
if (m != null)m.ThrowIfDisposed ();

		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public MatOfInt (params int[] a) : base()
				{
						
						fromArray (a);
				}
	
				public void alloc (int elemNumber)
				{
						if (elemNumber > 0)
								base.create (elemNumber, 1, CvType.makeType (_depth, _channels));
				}
	
				public void fromArray (params int[] a)
				{
						if (a == null || a.Length == 0)
								return;
						int num = a.Length / _channels;
						alloc (num);
						put (0, 0, a); //TODO: check ret val!
				}
	
				public int[] toArray ()
				{
						int num = checkVector (_channels, _depth);
						if (num < 0)
								throw new CvException ("Native Mat has unexpected type or size: " + ToString ());
						int[] a = new int[num * _channels];
						if (num == 0)
								return a;
						get (0, 0, a); //TODO: check ret val!
						return a;
				}
	
				public void fromList (List<int> lb)
				{
						if (lb == null || lb.Count == 0)
								return;
		
						fromArray (lb.ToArray ());
				}
	
				public List<int> toList ()
				{
						int[] a = toArray ();
		
						return new List<int> (a);
				}
		}
}
