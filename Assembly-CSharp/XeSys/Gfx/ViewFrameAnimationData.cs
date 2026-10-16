namespace XeSys.Gfx;

public class ViewFrameAnimationData : ISerializationCallbackReceiver
{
	internal enum AnimKind
	{
		Pos = 0,
		Move = 1,
		MoveBezierX = 2,
		MoveBezierY = 3,
		Size = 4,
		Scale = 5,
		Rot = 6,
		Color = 7,
		Alpha = 8,
		Center = 9,
		Texture = 10,
	}

	[SerializeField]
	private FrameData[] m_FrameDataList; //Field offset: 0x8
	[SerializeField]
	private LabelData[] m_LabelList; //Field offset: 0xC
	[SerializeField]
	private TimeMap m_AnimTimeMap; //Field offset: 0x10
	[SerializeField]
	private uint m_AnimFlag; //Field offset: 0x14
	[SerializeField]
	private string m_Id; //Field offset: 0x18
	[SerializeField]
	private int m_FrameNum; //Field offset: 0x1C
	private Dictionary<Int32, LabelIndexValue> m_LabelIndex; //Field offset: 0x20
	[CompilerGenerated]
	private string <TextureName>k__BackingField; //Field offset: 0x24

	public TimeMap AnimTimeMap
	{
		 get { } //Length: 11
	}

	public FrameData[] F
	{
		 get { } //Length: 11
	}

	public int FrameDataCount
	{
		 get { } //Length: 24
	}

	public private int FrameNum
	{
		 get { } //Length: 11
		private set { } //Length: 14
	}

	public string ID
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool IsAlphaAnim
	{
		 get { } //Length: 18
		 set { } //Length: 33
	}

	public bool IsCenterAnim
	{
		 get { } //Length: 18
		 set { } //Length: 33
	}

	public bool IsColorAnim
	{
		 get { } //Length: 18
		 set { } //Length: 33
	}

	public bool IsMoveAnim
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsMoveBezierX
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsMoveBezierY
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsPosAnim
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsRotAnim
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsScaleAnim
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsSizeAnim
	{
		 get { } //Length: 15
		 set { } //Length: 33
	}

	public bool IsTextureAnim
	{
		 get { } //Length: 18
		 set { } //Length: 33
	}

	public bool IsUseTimeMap
	{
		 get { } //Length: 79
	}

	public LabelData[] L
	{
		 get { } //Length: 11
	}

	public string TextureName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ViewFrameAnimationData(int frameNum) { }

	public ViewFrameAnimationData() { }

	public void AddTimeMapData(TimeMapData data) { }

	public TimeMap get_AnimTimeMap() { }

	public FrameData[] get_F() { }

	public int get_FrameDataCount() { }

	public int get_FrameNum() { }

	public string get_ID() { }

	public bool get_IsAlphaAnim() { }

	public bool get_IsCenterAnim() { }

	public bool get_IsColorAnim() { }

	public bool get_IsMoveAnim() { }

	public bool get_IsMoveBezierX() { }

	public bool get_IsMoveBezierY() { }

	public bool get_IsPosAnim() { }

	public bool get_IsRotAnim() { }

	public bool get_IsScaleAnim() { }

	public bool get_IsSizeAnim() { }

	public bool get_IsTextureAnim() { }

	public bool get_IsUseTimeMap() { }

	public LabelData[] get_L() { }

	[CompilerGenerated]
	public string get_TextureName() { }

	public bool GetAnimTransform(ViewTransformData vt, int Base, int Target, float rate, ref bool isUpdateSRT) { }

	public void InitAnimTimeMap(int count) { }

	public void Initialize(FrameData[] data, Dictionary<Int32, String> labelList, float frameSec) { }

	public bool IsAnim(AnimKind kind) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public int SearchFrameAction(float oldTime, float time) { }

	public float SearchLabelTime(string label) { }

	public float SearchLabelTimeFromHash(int labelHash) { }

	public bool SearchLabelTimeInversePair(string label, float frameSec, out float start, out float end) { }

	public bool SearchLabelTimeInversePairFromHash(int labelHash, float frameSec, out float start, out float end) { }

	public bool SearchLabelTimePair(string label, float frameSec, out float start, out float end) { }

	public bool SearchLabelTimePairFromHash(int labelHash, float frameSec, out float start, out float end) { }

	private void set_FrameNum(int value) { }

	public void set_ID(string value) { }

	public void set_IsAlphaAnim(bool value) { }

	public void set_IsCenterAnim(bool value) { }

	public void set_IsColorAnim(bool value) { }

	public void set_IsMoveAnim(bool value) { }

	public void set_IsMoveBezierX(bool value) { }

	public void set_IsMoveBezierY(bool value) { }

	public void set_IsPosAnim(bool value) { }

	public void set_IsRotAnim(bool value) { }

	public void set_IsScaleAnim(bool value) { }

	public void set_IsSizeAnim(bool value) { }

	public void set_IsTextureAnim(bool value) { }

	[CompilerGenerated]
	public void set_TextureName(string value) { }

	public void SetAnim(AnimKind kind, bool on) { }

	private void SetLabelList(Dictionary<Int32, String> labelList, float frameSec) { }

	public void SetPrevNextFrameData(float count, ref int prev, ref int next, out float rate) { }

}

