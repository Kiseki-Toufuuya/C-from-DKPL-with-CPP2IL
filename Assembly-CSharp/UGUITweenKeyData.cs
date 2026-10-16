//Type is in global namespace

public class UGUITweenKeyData
{
	internal enum KeyDataType
	{
		pos = 0,
		scale = 1,
		rot = 2,
		size = 3,
		pivot = 4,
		anchorMin = 5,
		anchorMax = 6,
		move = 7,
		color = 8,
		groupAlpha = 9,
		num = 10,
	}

	[SerializeField]
	private string m_ID; //Field offset: 0x8
	[SerializeField]
	private float m_Sec; //Field offset: 0xC
	[SerializeField]
	private Vector3 m_Pos; //Field offset: 0x10
	[SerializeField]
	private Vector3 m_Scale; //Field offset: 0x1C
	[SerializeField]
	private Vector3 m_Angle; //Field offset: 0x28
	[SerializeField]
	private Vector2 m_Size; //Field offset: 0x34
	[SerializeField]
	private Vector2 m_Pivot; //Field offset: 0x3C
	[SerializeField]
	private Vector2 m_AnchorMin; //Field offset: 0x44
	[SerializeField]
	private Vector2 m_AnchorMax; //Field offset: 0x4C
	[SerializeField]
	private Vector3 m_Move; //Field offset: 0x54
	[SerializeField]
	private Color m_Color; //Field offset: 0x60
	[SerializeField]
	private float m_GroupAlpha; //Field offset: 0x70
	[SerializeField]
	private EasingFunc[] m_EasingFuncs; //Field offset: 0x74
	[SerializeField]
	private uint m_DataBitFlg; //Field offset: 0x78

	public Vector2 AnchorMax
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public Vector2 AnchorMin
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public Vector3 Angle
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Color Color
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public EasingFunc[] Easings
	{
		 get { } //Length: 11
	}

	public float GroupAlpha
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public string ID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Vector3 Move
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Vector2 Pivot
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public Vector3 Pos
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Vector3 Scale
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public float Sec
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public Vector2 Size
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public UGUITweenKeyData() { }

	public void ClearDataFlag() { }

	public Vector2 get_AnchorMax() { }

	public Vector2 get_AnchorMin() { }

	public Vector3 get_Angle() { }

	public Color get_Color() { }

	public EasingFunc[] get_Easings() { }

	public float get_GroupAlpha() { }

	public string get_ID() { }

	public Vector3 get_Move() { }

	public Vector2 get_Pivot() { }

	public Vector3 get_Pos() { }

	public Vector3 get_Scale() { }

	public float get_Sec() { }

	public Vector2 get_Size() { }

	public uint GetDataFlg() { }

	public void Init() { }

	public bool IsDataFlg(KeyDataType dataType) { }

	public void set_AnchorMax(Vector2 value) { }

	public void set_AnchorMin(Vector2 value) { }

	public void set_Angle(Vector3 value) { }

	public void set_Color(Color value) { }

	public void set_GroupAlpha(float value) { }

	public void set_ID(string value) { }

	public void set_Move(Vector3 value) { }

	public void set_Pivot(Vector2 value) { }

	public void set_Pos(Vector3 value) { }

	public void set_Scale(Vector3 value) { }

	public void set_Sec(float value) { }

	public void set_Size(Vector2 value) { }

	public void SetDataFlg(KeyDataType dataType, bool flg) { }

}

