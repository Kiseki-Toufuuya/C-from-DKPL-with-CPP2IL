namespace UnityEngine;

[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable
{
	private int m_XMin; //Field offset: 0x0
	private int m_YMin; //Field offset: 0x4
	private int m_Width; //Field offset: 0x8
	private int m_Height; //Field offset: 0xC

	public int height
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int width
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int x
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public int xMax
	{
		 get { } //Length: 85
	}

	public int xMin
	{
		 get { } //Length: 85
	}

	public int y
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int yMax
	{
		 get { } //Length: 86
	}

	public int yMin
	{
		 get { } //Length: 86
	}

	public RectInt(int xMin, int yMin, int width, int height) { }

	public override bool Equals(RectInt other) { }

	public virtual bool Equals(object other) { }

	public int get_height() { }

	public int get_width() { }

	public int get_x() { }

	public int get_xMax() { }

	public int get_xMin() { }

	public int get_y() { }

	public int get_yMax() { }

	public int get_yMin() { }

	public virtual int GetHashCode() { }

	public bool Overlaps(RectInt other) { }

	public void set_height(int value) { }

	public void set_width(int value) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

