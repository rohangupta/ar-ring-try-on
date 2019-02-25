using System;
using System.Collections.Generic;



namespace OpenCVForUnity
{
		public class MatOfKeyPoint : Mat
		{
				// 32FC7
				private const int _depth = CvType.CV_32F;
				private const int _channels = 7;
	
				public MatOfKeyPoint () : base()
				{
		
				}
	
				protected MatOfKeyPoint (IntPtr addr) : base(addr)
				{
		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public static MatOfKeyPoint fromNativeAddr (IntPtr addr)
				{
						return new MatOfKeyPoint (addr);
				}
	
				public MatOfKeyPoint (Mat m) : base(m, Range.all())
				{
if (m != null)m.ThrowIfDisposed ();

		
						if (!empty () && checkVector (_channels, _depth) < 0)
								throw new CvException ("Incompatible Mat");
						//FIXME: do we need release() here?
				}
	
				public MatOfKeyPoint (params KeyPoint[] a) : base()
				{
		
						fromArray (a);
				}
	
				public void alloc (int elemNumber)
				{
						if (elemNumber > 0)
								base.create (elemNumber, 1, CvType.makeType (_depth, _channels));
				}
	
				public void fromArray (params KeyPoint[] a)
				{
						if (a == null || a.Length == 0)
								return;
						int num = a.Length;
						alloc (num);
						float[] buff = new float[num * _channels];
						for (int i=0; i<num; i++) {
								KeyPoint kp = a [i];
								buff [_channels * i + 0] = (float)kp.pt.x;
								buff [_channels * i + 1] = (float)kp.pt.y;
								buff [_channels * i + 2] = kp.size;
								buff [_channels * i + 3] = kp.angle;
								buff [_channels * i + 4] = kp.response;
								buff [_channels * i + 5] = kp.octave;
								buff [_channels * i + 6] = kp.class_id;
						}
						put (0, 0, buff); //TODO: check ret val!
				}
	
				public KeyPoint[] toArray ()
				{
						int num = (int)total ();
						KeyPoint[] a = new KeyPoint[num];
						if (num == 0)
								return a;
						float[] buff = new float[num * _channels];
						get (0, 0, buff); //TODO: check ret val!
						for (int i=0; i<num; i++)
								a [i] = new KeyPoint (buff [_channels * i + 0], buff [_channels * i + 1], buff [_channels * i + 2], buff [_channels * i + 3],
			                    buff [_channels * i + 4], (int)buff [_channels * i + 5], (int)buff [_channels * i + 6]);
						return a;
				}
	
				public void fromList (List<KeyPoint> lkp)
				{
						KeyPoint[] akp = lkp.ToArray ();
						fromArray (akp);
				}
	
				public List<KeyPoint> toList ()
				{
						KeyPoint[] akp = toArray ();
						return new List<KeyPoint> (akp);
				}
		}
}
