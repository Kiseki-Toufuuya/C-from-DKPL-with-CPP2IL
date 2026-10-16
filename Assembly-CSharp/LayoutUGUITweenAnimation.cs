//Type is in global namespace

public class LayoutUGUITweenAnimation
{
	private class ChainTweenAnimation
	{
		private int m_CurrentDataIdx; //Field offset: 0x8
		private List<UGUITweenKeyData> m_TweenKeyDataList; //Field offset: 0xC
		private float m_CurrentSec; //Field offset: 0x10
		private bool m_IsLoop; //Field offset: 0x14
		private bool m_IsRound; //Field offset: 0x15
		private bool m_IsReverse; //Field offset: 0x16
		private bool m_IsEnd; //Field offset: 0x17

		public int CurrentDataIdx
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public float CurrentSec
		{
			 get { } //Length: 11
			 set { } //Length: 18
		}

		public bool IsEnd
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsLoop
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsReverse
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsRound
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public List<UGUITweenKeyData> TweenKeyDataList
		{
			 get { } //Length: 11
		}

		public ChainTweenAnimation() { }

		public void Clear() { }

		public int get_CurrentDataIdx() { }

		public float get_CurrentSec() { }

		public bool get_IsEnd() { }

		public bool get_IsLoop() { }

		public bool get_IsReverse() { }

		public bool get_IsRound() { }

		public List<UGUITweenKeyData> get_TweenKeyDataList() { }

		public void set_CurrentDataIdx(int value) { }

		public void set_CurrentSec(float value) { }

		public void set_IsEnd(bool value) { }

		public void set_IsLoop(bool value) { }

		public void set_IsReverse(bool value) { }

		public void set_IsRound(bool value) { }

	}

	[SerializeField]
	private UGUITweenData m_AnimationData; //Field offset: 0x8
	[SerializeField]
	private GameObject m_AnimationObject; //Field offset: 0xC
	private RectTransform m_AnimationTransform; //Field offset: 0x10
	private Graphic m_AnimationGraphic; //Field offset: 0x14
	private CanvasGroup m_AnimationCanvasGroup; //Field offset: 0x18
	private Vector3 m_AnimationMove; //Field offset: 0x1C
	private Vector3 m_LastMove; //Field offset: 0x28
	private UGUITweenKeyData m_ResetData; //Field offset: 0x34
	private UGUITweenKeyData m_KeyBaseData; //Field offset: 0x38
	private List<ChainTweenAnimation> m_KeyTargetDataList; //Field offset: 0x3C
	private List<UGUITweenKeyData> m_WorkKeyDataList; //Field offset: 0x40
	private Vector3 m_AngleLerpWork; //Field offset: 0x44
	private float m_Speed; //Field offset: 0x50
	private bool m_IsAnim; //Field offset: 0x54
	private bool m_IsAnimNotLoop; //Field offset: 0x55

	public bool IsAnim
	{
		 get { } //Length: 11
	}

	public bool IsAnimNotLoop
	{
		 get { } //Length: 11
	}

	public UGUITweenKeyData ResetData
	{
		 get { } //Length: 11
	}

	public float Speed
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public LayoutUGUITweenAnimation() { }

	public void AddKeyData() { }

	public void ClearAnimation() { }

	public bool get_IsAnim() { }

	public bool get_IsAnimNotLoop() { }

	public UGUITweenKeyData get_ResetData() { }

	public float get_Speed() { }

	private Vector3 GetAngleDelta(UGUITweenKeyData baseData, UGUITweenKeyData targetData) { }

	public UGUITweenKeyData GetKeyData(string label) { }

	public void Init(GameObject gameObject, UGUITweenData data) { }

	public void InitAnimationStart(uint nextDataBitFlg) { }

	public bool IsExistAnimationData() { }

	public void RemoveKeyDataAt(int idx) { }

	public void ResetObject() { }

	public void set_Speed(float value) { }

	public void SetAnimation(string animLabel, float rate) { }

	public void SetAnimation(int animIdx, float rate) { }

	public void SetAnimationKeyData(int idx) { }

	private void SetChainAnimation(List<UGUITweenKeyData> list, bool isloop, bool isRound) { }

	public void SetKeyData(UGUITweenKeyData data) { }

	private void SetKeyData(UGUITweenKeyData src, UGUITweenKeyData dest) { }

	public void SetObjectData(bool isAllData, UGUITweenKeyData data) { }

	public void SetObjectDataByAnimationData(int idx, bool isAllData) { }

	private void SetOneAnimation(UGUITweenKeyData baseData, UGUITweenKeyData KeyTargetData, bool isLoop, bool isRound) { }

	public void StartAnimation(int targetIdx, bool isloop = false, bool isRound = false) { }

	public void StartAnimation(string targetLabel, bool isloop = false, bool isRound = false) { }

	public void StartAnimation(string baseLabel, string targetLabel, bool isloop = false, bool isRound = false) { }

	public void StartAnimation(List<Int32> dataIdxList, bool isloop = false, bool isRound = false) { }

	public void StartAnimation(List<String> dataLabelList, bool isloop = false, bool isRound = false) { }

	public void StartAnimation(int baseIdx, int targetIdx, bool isloop = false, bool isRound = false) { }

	public void Update(float dt) { }

	public void UpdateObject(UGUITweenKeyData target, float rate) { }

	public void UpdateResetData() { }

}

