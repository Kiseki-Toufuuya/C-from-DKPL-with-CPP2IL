namespace XeSys.uGUI;

public class UIWrapperGage : UIWrapperBase
{
	private class GageData
	{
		private RectTransform m_GageTransform; //Field offset: 0x8
		private float m_GageMaxSize; //Field offset: 0xC
		private float m_Rate; //Field offset: 0x10

		public GageData(RectTransform gage) { }

		public void Init(RectTransform gage) { }

		public void SetGageRate(float rate) { }

	}

	private List<GageData> m_GageDataList; //Field offset: 0x14
	private float m_MaxValue; //Field offset: 0x18
	private float m_CurrentValue; //Field offset: 0x1C

	public UIWrapperGage() { }

	public void AddGageObject(string gageName) { }

	public void Clear() { }

	public static UIWrapperGage CreateGage(GameObject root) { }

	public float GetCurrentValue() { }

	public float GetMaxValue() { }

	public void InitGage(GameObject root) { }

	public void SetCurrentValue(float val) { }

	private void SetGageUI() { }

	public void SetMaxValue(float max) { }

}

