using System;


namespace OpenCVForUnity{

public class RotatedRect {
	
	public Point center;
	public Size size;
	public double angle;
	
	public RotatedRect() {
		this.center = new Point();
		this.size = new Size();
		this.angle = 0;
	}
	
	public RotatedRect(Point c, Size s, double a) {
		this.center = c.clone();
		this.size = s.clone();
		this.angle = a;
	}
	
	public RotatedRect(double[] vals) : this() {
		
		set(vals);
	}
	
	public void set(double[] vals) {
		if (vals != null) {
			center.x = vals.Length > 0 ? (double) vals[0] : 0;
			center.y = vals.Length > 1 ? (double) vals[1] : 0;
			size.width = vals.Length > 2 ? (double) vals[2] : 0;
			size.height = vals.Length > 3 ? (double) vals[3] : 0;
			angle = vals.Length > 4 ? (double) vals[4] : 0;
		} else {
			center.x = 0;
			center.x = 0;
			size.width = 0;
			size.height = 0;
			angle = 0;
		}
	}
	
	public void points(Point[] pt)
	{
		double _angle = angle * Math.PI / 180.0;
		double b = (double) Math.Cos(_angle) * 0.5f;
		double a = (double) Math.Sin(_angle) * 0.5f;
		
		pt[0] = new Point(
			center.x - a * size.height - b * size.width,
			center.y + b * size.height - a * size.width);
		
		pt[1] = new Point(
			center.x + a * size.height - b * size.width,
			center.y - b * size.height - a * size.width);
		
		pt[2] = new Point(
			2 * center.x - pt[0].x,
			2 * center.y - pt[0].y);
		
		pt[3] = new Point(
			2 * center.x - pt[1].x,
			2 * center.y - pt[1].y);
	}
	
	public Rect boundingRect()
	{
		Point[] pt = new Point[4];
		points(pt);
		Rect r = new Rect((int) Math.Floor(Math.Min(Math.Min(Math.Min(pt[0].x, pt[1].x), pt[2].x), pt[3].x)),//TODO:@check
		                  (int) Math.Floor(Math.Min(Math.Min(Math.Min(pt[0].y, pt[1].y), pt[2].y), pt[3].y)),
		                  (int) Math.Ceiling(Math.Max(Math.Max(Math.Max(pt[0].x, pt[1].x), pt[2].x), pt[3].x)),
		                  (int) Math.Ceiling(Math.Max(Math.Max(Math.Max(pt[0].y, pt[1].y), pt[2].y), pt[3].y)));
		r.width -= r.x - 1;
		r.height -= r.y - 1;
		return r;
	}
	
	public RotatedRect clone() {
		return new RotatedRect(center, size, angle);
	}
	
	//@Override
	public override int GetHashCode() {
		const int prime = 31;
		int result = 1;
		long temp;
			temp = BitConverter.DoubleToInt64Bits(center.x);
			result = prime * result + (int) (temp ^ (Utils.URShift (temp, 32)));
			temp = BitConverter.DoubleToInt64Bits(center.y);
			result = prime * result + (int) (temp ^ (Utils.URShift (temp, 32)));
			temp = BitConverter.DoubleToInt64Bits(size.width);
			result = prime * result + (int) (temp ^ (Utils.URShift (temp, 32)));
			temp = BitConverter.DoubleToInt64Bits(size.height);
			result = prime * result + (int) (temp ^ (Utils.URShift (temp, 32)));
			temp = BitConverter.DoubleToInt64Bits(angle);
			result = prime * result + (int) (temp ^ (Utils.URShift (temp, 32)));
		return result;
	}
	
	//@Override
	public override bool Equals(Object obj) {
		if (this == obj) return true;
		if (!(obj is RotatedRect)) return false;
		RotatedRect it = (RotatedRect) obj;
		return center.Equals(it.center) && size.Equals(it.size) && angle == it.angle;
	}
	
	//@Override
	public override string ToString() {
		return "{ " + center + " " + size + " * " + angle + " }";
	}
}
}
