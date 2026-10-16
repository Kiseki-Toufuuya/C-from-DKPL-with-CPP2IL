namespace XeApp.Game.Hakoniwa.Spot;

public struct AABBData
{
	public Vector2 m_center; //Field offset: 0x0
	public Vector2 m_halfSize; //Field offset: 0x8
	private bool m_isFlip; //Field offset: 0x10
	private bool m_isUpsideDown; //Field offset: 0x11

	public Vector2 Center
	{
		 get { } //Length: 65
		 set { } //Length: 19
	}

	public Vector2 HalfSize
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public bool IsFlip
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsUpsideDown
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Vector2 Max
	{
		 get { } //Length: 48
		 set { } //Length: 102
	}

	public Vector2 Min
	{
		 get { } //Length: 48
		 set { } //Length: 98
	}

	public static bool CheckContain(AABBData a, AABBData b) { }

	public static bool CheckContain(Vector2 aMin, Vector2 aMax, Vector2 bMin, Vector2 bMax) { }

	public static bool CheckContain(AABBData a, Vector2 posA, AABBData b, Vector2 posB) { }

	public static bool CheckHit(AABBData a, Vector2 posA, AABBData b, Vector2 posB) { }

	public static bool CheckHit(AABBData a, AABBData b) { }

	public static bool CheckHit(Vector2 aMin, Vector2 aMax, Vector2 bMin, Vector2 bMax) { }

	public static float Distance(AABBData a, Vector2 posA, Vector2 p) { }

	public Vector2 get_Center() { }

	public Vector2 get_HalfSize() { }

	public bool get_IsFlip() { }

	public bool get_IsUpsideDown() { }

	public Vector2 get_Max() { }

	public Vector2 get_Min() { }

	public void Marge(AABBData b) { }

	public void set_Center(Vector2 value) { }

	public void set_HalfSize(Vector2 value) { }

	public void set_IsFlip(bool value) { }

	public void set_IsUpsideDown(bool value) { }

	public void set_Max(Vector2 value) { }

	public void set_Min(Vector2 value) { }

}

