using System;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class MatOfByte : Mat
		{
				// 8UC(x)
				private const int _depth = CvType.CV_8U;
				private const int _channels = 1;
	
				public MatOfByte () : base()
				{
		
				}
	
				protected MatOfByte (IntPtr addr) : base(addr)
				{
		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public static MatOfByte fromNativeAddr (IntPtr addr)
				{
						return new MatOfByte (addr);
				}
	
				public MatOfByte (Mat m) : base(m, Range.all())
				{
if (m != null)m.ThrowIfDisposed ();

						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public MatOfByte (params byte[] a) : base()
				{

						fromArray (a);
				}
	
				public void alloc (int elemNumber)
				{
						if (elemNumber > 0)
								base.create (elemNumber, 1, CvType.makeType (_depth, _channels));

				}
	
				public void fromArray (params byte[] a)
				{
						if (a == null || a.Length == 0)
								return;
						int num = a.Length / _channels;
						alloc (num);
						put (0, 0, a); //TODO: check ret val!
				}
	
				public byte[] toArray ()
				{
						int num = checkVector (_channels, _depth);
						if (num < 0)
								throw new CvException ("Native Mat has unexpected type or size: " + ToString ());
						byte[] a = new byte[num * _channels];
						if (num == 0)
								return a;
						get (0, 0, a); //TODO: check ret val!
						return a;
				}
	
				public void fromList (List<byte> lb)
				{
						if (lb == null || lb.Count == 0)
								return;

						byte[] a = lb.ToArray ();
						fromArray (a);

				}
	
				public List<byte> toList ()
				{
						byte[] a = toArray ();
						return new List<byte> (a);
				}
		}
}
