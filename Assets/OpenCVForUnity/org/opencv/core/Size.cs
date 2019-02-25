using System;


namespace OpenCVForUnity
{

/**
 * <p>template<typename _Tp> class CV_EXPORTS Size_ <code></p>
 *
 * <p>// C++ code:</p>
 *
 *
 * <p>public:</p>
 *
 * <p>typedef _Tp value_type;</p>
 *
 * <p>//! various constructors</p>
 *
 * <p>Size_();</p>
 *
 * <p>Size_(_Tp _width, _Tp _height);</p>
 *
 * <p>Size_(const Size_& sz);</p>
 *
 * <p>Size_(const CvSize& sz);</p>
 *
 * <p>Size_(const CvSize2D32f& sz);</p>
 *
 * <p>Size_(const Point_<_Tp>& pt);</p>
 *
 * <p>Size_& operator = (const Size_& sz);</p>
 *
 * <p>//! the area (width*height)</p>
 *
 * <p>_Tp area() const;</p>
 *
 * <p>//! conversion of another data type.</p>
 *
 * <p>template<typename _Tp2> operator Size_<_Tp2>() const;</p>
 *
 * <p>//! conversion to the old-style OpenCV types</p>
 *
 * <p>operator CvSize() const;</p>
 *
 * <p>operator CvSize2D32f() const;</p>
 *
 * <p>_Tp width, height; // the width and the height</p>
 *
 * <p>};</p>
 *
 * <p>Template class for specifying the size of an image or rectangle. The class
 * includes two members called <code>width</code> and <code>height</code>. The
 * structure can be converted to and from the old OpenCV structures </code></p>
 *
 * <p><code>CvSize</code> and <code>CvSize2D32f</code>. The same set of arithmetic
 * and comparison operations as for <code>Point_</code> is available.
 * OpenCV defines the following <code>Size_<></code> aliases: <code></p>
 *
 * <p>// C++ code:</p>
 *
 * <p>typedef Size_<int> Size2i;</p>
 *
 * <p>typedef Size2i Size;</p>
 *
 * <p>typedef Size_<float> Size2f;</p>
 *
 * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#size">org.opencv.core.Size_</a>
 */
		public class Size
		{
	
				public double width, height;
	
				public Size (double width, double height)
				{
						this.width = width;
						this.height = height;
				}
	
		        public Size () : this (0, 0)
				{
						
				}
	
				public Size (Point p)
				{
						width = p.x;
						height = p.y;
				}
	
				public Size (double[] vals)
				{
						set (vals);
				}
	
				public void set (double[] vals)
				{
						if (vals != null) {
								width = vals.Length > 0 ? vals [0] : 0;
								height = vals.Length > 1 ? vals [1] : 0;
						} else {
								width = 0;
								height = 0;
						}
				}
	
				public double area ()
				{
						return width * height;
				}
	
				public Size clone ()
				{
						return new Size (width, height);
				}
	
				//@Override
				public override int GetHashCode ()
				{
						const int prime = 31;
						int result = 1;
						long temp;
			temp = BitConverter.DoubleToInt64Bits(height);
						result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
			temp = BitConverter.DoubleToInt64Bits (width);
						result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
						return result;
				}
	
				//@Override
				public override bool Equals (Object obj)
				{
						if (this == obj)
								return true;
						if (!(obj is Size))
								return false;
						Size it = (Size)obj;
						return width == it.width && height == it.height;
				}
	
				//@Override
				public override string ToString ()
				{
						return (int)width + "x" + (int)height;
				}

//				private static int URShift (int number, int bits)
//				{
//						if (number >= 0)
//								return number >> bits;
//						else
//								return (number >> bits) + (2 << ~bits);
//				}
	
		}
}

