namespace XeSys.Gfx;

public class ViewFrameAnimation
{
	private enum AnimAction
	{
		stop = 0,
		loop = 1,
	}

	[SerializeField]
	private ViewFrameAnimationData data; //Field offset: 0x8
	private AnimAction m_Action; //Field offset: 0xC
	private float m_startTime; //Field offset: 0x10
	private float m_endTime; //Field offset: 0x14
	private float m_AnimCount; //Field offset: 0x18
	private bool m_IsAnimEnd; //Field offset: 0x1C
	private float m_timeScale; //Field offset: 0x20
	private int m_PrevFrameData; //Field offset: 0x24
	private int m_NextFrameData; //Field offset: 0x28
	private float m_FrameDataRate; //Field offset: 0x2C
	private bool m_isInterpolateStop; //Field offset: 0x30
	[SerializeField]
	private float m_FrameSec; //Field offset: 0x34
	public string ParentId; //Field offset: 0x38

	public private float AnimCount
	{
		 get { } //Length: 11
		private set { } //Length: 18
	}

	public TimeMap AnimTimeMap
	{
		 get { } //Length: 23
	}

	public int FrameNum
	{
		 get { } //Length: 23
	}

	public float FrameSec
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public string ID
	{
		 get { } //Length: 23
		 set { } //Length: 39
	}

	public bool IsAlphaAnim
	{
		 get { } //Length: 30
		 set { } //Length: 45
	}

	public bool IsAnimEnd
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsCenterAnim
	{
		 get { } //Length: 30
		 set { } //Length: 45
	}

	public bool IsColAnim
	{
		 get { } //Length: 30
		 set { } //Length: 45
	}

	public bool IsInterpolateStop
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsMoveAnim
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsMoveBezierX
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsMoveBezierY
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsPosAnim
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsRotAnim
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsScaleAnim
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsSizeAnim
	{
		 get { } //Length: 27
		 set { } //Length: 45
	}

	public bool IsTextureAnim
	{
		 get { } //Length: 30
		 set { } //Length: 45
	}

	public int LabelCount
	{
		 get { } //Length: 36
	}

	public LabelData[] LabelList
	{
		 get { } //Length: 23
	}

	public string TextureName
	{
		 get { } //Length: 23
	}

	public float TimeScale
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public ViewFrameAnimation(int frameNum) { }

	public ViewFrameAnimation() { }

	public void AddTimeMapData(TimeMapData tmData) { }

	private bool ApplyFrameAction(float oldTime, float time) { }

	public void CopyTo(ViewFrameAnimation anim) { }

	public float get_AnimCount() { }

	public TimeMap get_AnimTimeMap() { }

	public int get_FrameNum() { }

	public float get_FrameSec() { }

	public string get_ID() { }

	public bool get_IsAlphaAnim() { }

	public bool get_IsAnimEnd() { }

	public bool get_IsCenterAnim() { }

	public bool get_IsColAnim() { }

	public bool get_IsInterpolateStop() { }

	public bool get_IsMoveAnim() { }

	public bool get_IsMoveBezierX() { }

	public bool get_IsMoveBezierY() { }

	public bool get_IsPosAnim() { }

	public bool get_IsRotAnim() { }

	public bool get_IsScaleAnim() { }

	public bool get_IsSizeAnim() { }

	public bool get_IsTextureAnim() { }

	public int get_LabelCount() { }

	public LabelData[] get_LabelList() { }

	public string get_TextureName() { }

	public float get_TimeScale() { }

	public bool GetAnimTransform(ViewTransformData vt, ref bool isUpdateSRT) { }

	public ViewFrameAnimationData GetData() { }

	public void InitAnimTimeMap(int count) { }

	public void Initialize(FrameData[] frameDatas, Dictionary<Int32, String> labelList) { }

	public void InitializeEmptyAnimation(bool force = false) { }

	public bool IsLoop() { }

	private void set_AnimCount(float value) { }

	public void set_FrameSec(float value) { }

	public void set_ID(string value) { }

	public void set_IsAlphaAnim(bool value) { }

	public void set_IsAnimEnd(bool value) { }

	public void set_IsCenterAnim(bool value) { }

	public void set_IsColAnim(bool value) { }

	public void set_IsInterpolateStop(bool value) { }

	public void set_IsMoveAnim(bool value) { }

	public void set_IsMoveBezierX(bool value) { }

	public void set_IsMoveBezierY(bool value) { }

	public void set_IsPosAnim(bool value) { }

	public void set_IsRotAnim(bool value) { }

	public void set_IsScaleAnim(bool value) { }

	public void set_IsSizeAnim(bool value) { }

	public void set_IsTextureAnim(bool value) { }

	public void set_TimeScale(float value) { }

	public void SetAnimFrame(float frame) { }

	public void SetAnimTime(float time) { }

	public void StartAnim() { }

	public void StartAnimGoStop(string startLabel, string endLabel) { }

	public void StartAnimGoStop(string startLabel) { }

	public void StartAnimGoStopFrame(int start, int end) { }

	public void StartAnimGoStopFromHash(int startLabelHash) { }

	public void StartAnimGoStopFromHash(int startLabelHash, int endLabelHash) { }

	public void StartAnimGoStopTime(float start, float end) { }

	public void StartAnimInverseGoStop(string startLabel) { }

	public void StartAnimLoop(string startLabel, string endLabel) { }

	public void StartAnimLoop(string startLabel) { }

	public void StartAnimLoopFrame(int start, int end) { }

	public void StartAnimLoopFromHash(int startLabelHash, int endLabelHash) { }

	public void StartAnimLoopFromHash(int startLabelHash) { }

	public void Update(float dt) { }

}

