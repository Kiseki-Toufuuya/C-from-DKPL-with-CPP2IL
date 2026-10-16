namespace XeSys.Gfx;

public class ViewBase
{
	internal enum EAlignH
	{
		left = 0,
		center = 1,
		right = 2,
		fit = 3,
	}

	internal enum EAlignV
	{
		top = 0,
		center = 1,
		bottom = 2,
		fit = 3,
	}

	internal enum EBlendType
	{
		normal = 0,
		add = 1,
		mul = 2,
		dec = 3,
	}

	protected static readonly int ANIMLABEL_DEFAULT; //Field offset: 0x0
	protected static readonly int ANIMLABEL_LOOP; //Field offset: 0x4
	protected static readonly int ANIMLABEL_ONCE; //Field offset: 0x8
	protected static readonly int ANIMLABEL_IN_START; //Field offset: 0xC
	protected static readonly int ANIMLABEL_IN_END; //Field offset: 0x10
	protected static readonly int ANIMLABEL_OUT_START; //Field offset: 0x14
	protected static readonly int ANIMLABEL_OUT_END; //Field offset: 0x18
	private ViewFrameAnimation m_FrameAnimation; //Field offset: 0x8
	private ViewBase m_Parent; //Field offset: 0xC
	private string m_ID; //Field offset: 0x10
	private int m_IDHash; //Field offset: 0x14
	private string m_EXID; //Field offset: 0x18
	private string m_AnimID; //Field offset: 0x1C
	protected ViewTransformData m_transformData; //Field offset: 0x20
	private EAlignH m_AlignH; //Field offset: 0x24
	private EAlignV m_AlignV; //Field offset: 0x28
	private EBlendType m_BlendType; //Field offset: 0x2C
	private string m_Label; //Field offset: 0x30
	private int m_tag; //Field offset: 0x34
	protected Color m_Color; //Field offset: 0x38
	protected Color m_CurrentColor; //Field offset: 0x48
	private bool m_enabled; //Field offset: 0x58
	private bool m_isUpdateSRT; //Field offset: 0x59
	[CompilerGenerated]
	private UguiInfoComponent <UguiInfo>k__BackingField; //Field offset: 0x5C

	public EAlignH AlignH
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public EAlignV AlignV
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string AnimID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public EBlendType BlendType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float CenterX
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public float CenterY
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public Color col
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public Color Col
	{
		 get { } //Length: 30
		 set { } //Length: 28
	}

	public Color currentCol
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public override bool enabled
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string EXID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ViewFrameAnimation FrameAnimation
	{
		 get { } //Length: 11
	}

	public float Height
	{
		 get { } //Length: 119
		 set { } //Length: 30
	}

	public string ID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int IDHash
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool IsTransparentFull
	{
		 get { } //Length: 18
	}

	public bool IsUpdateSRT
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool IsVisible
	{
		 get { } //Length: 11
	}

	public string Label
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float MoveX
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public float MoveY
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public ViewBase Parent
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float Rot
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public float ScaleX
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public float ScaleY
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public int Tag
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float TimeScale
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public ViewTransformData TransformData
	{
		 get { } //Length: 11
	}

	public UguiInfoComponent UguiInfo
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Vector2 ViewPos
	{
		 get { } //Length: 90
	}

	public Quaternion ViewRot
	{
		 get { } //Length: 141
	}

	public Vector3 ViewScale
	{
		 get { } //Length: 43
	}

	public float Width
	{
		 get { } //Length: 119
		 set { } //Length: 30
	}

	public float X
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public float Y
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	private static ViewBase() { }

	public ViewBase() { }

	public override void Clear() { }

	public override void CopyTo(ViewBase view) { }

	public override ViewBase DeepClone() { }

	public EAlignH get_AlignH() { }

	public EAlignV get_AlignV() { }

	public string get_AnimID() { }

	public EBlendType get_BlendType() { }

	public float get_CenterX() { }

	public float get_CenterY() { }

	public Color get_col() { }

	public Color get_Col() { }

	public Color get_currentCol() { }

	public override bool get_enabled() { }

	public string get_EXID() { }

	public ViewFrameAnimation get_FrameAnimation() { }

	public float get_Height() { }

	public string get_ID() { }

	public int get_IDHash() { }

	public override bool get_IsTransparentFull() { }

	public bool get_IsUpdateSRT() { }

	public override bool get_IsVisible() { }

	public string get_Label() { }

	public float get_MoveX() { }

	public float get_MoveY() { }

	public ViewBase get_Parent() { }

	public float get_Rot() { }

	public float get_ScaleX() { }

	public float get_ScaleY() { }

	public int get_Tag() { }

	public float get_TimeScale() { }

	public ViewTransformData get_TransformData() { }

	[CompilerGenerated]
	public UguiInfoComponent get_UguiInfo() { }

	public Vector2 get_ViewPos() { }

	public Quaternion get_ViewRot() { }

	public Vector3 get_ViewScale() { }

	public float get_Width() { }

	public float get_X() { }

	public float get_Y() { }

	public void InitializeEmptyAnimation(bool force = false) { }

	public bool isNoSize() { }

	public bool IsPlaying() { }

	public bool IsPlayingNotLoop() { }

	public override void Serialize(List<SerializableView> list, int parent) { }

	public void set_AlignH(EAlignH value) { }

	public void set_AlignV(EAlignV value) { }

	public void set_AnimID(string value) { }

	public void set_BlendType(EBlendType value) { }

	public void set_CenterX(float value) { }

	public void set_CenterY(float value) { }

	public void set_col(Color value) { }

	public void set_Col(Color value) { }

	public void set_currentCol(Color value) { }

	public override void set_enabled(bool value) { }

	public void set_EXID(string value) { }

	public void set_Height(float value) { }

	public void set_ID(string value) { }

	public void set_IDHash(int value) { }

	public void set_IsUpdateSRT(bool value) { }

	public void set_Label(string value) { }

	public void set_MoveX(float value) { }

	public void set_MoveY(float value) { }

	public void set_Parent(ViewBase value) { }

	public void set_Rot(float value) { }

	public void set_ScaleX(float value) { }

	public void set_ScaleY(float value) { }

	public void set_Tag(int value) { }

	public void set_TimeScale(float value) { }

	[CompilerGenerated]
	public void set_UguiInfo(UguiInfoComponent value) { }

	public void set_Width(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void SetAnimFrame(float frame) { }

	public void SetAnimTime(float time) { }

	public void SetColor(float r, float g, float b, float a) { }

	public void SetColorFromString(string colStr) { }

	public void SetFrameAnimation(LayoutAnimation anim) { }

	public void StartAnim() { }

	public void StartAnimDecoLoop() { }

	public void StartAnimDecoOnce() { }

	public void StartAnimDefault() { }

	public void StartAnimGoStop(int labelHash) { }

	public void StartAnimGoStop(int startLabelHash, int endLabelHash) { }

	public void StartAnimGoStop(string startLabel, string endLabel) { }

	public void StartAnimGoStop(string label) { }

	public void StartAnimGoStopFrame(int start, int end) { }

	public void StartAnimIn() { }

	public void StartAnimLoop(int startLabelHash, int endLabelHash) { }

	public void StartAnimLoop(string startLabel, string endLabel) { }

	public void StartAnimLoop(int labelHash) { }

	public void StartAnimLoop(string label) { }

	public void StartAnimLoopFrame(int start, int end) { }

	public void StartAnimOut() { }

	public void StopAnim() { }

	public override void Update(Color parentCol) { }

	public override bool UpdateAnim(float dt) { }

}

