namespace XeApp.Game;

public class AdvScrBtnDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AssetBundleLoadAssetOperation> <>9__10_0; //Field offset: 0x4
		public static Action<AssetBundleLoadAssetOperation> <>9__10_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Create>b__10_0(AssetBundleLoadAssetOperation operation) { }

		internal void <Create>b__10_1(AssetBundleLoadAssetOperation operation) { }

	}

	private enum eButtonId
	{
		SCR = 0,
		NUM = 1,
	}

	private enum eLayerId
	{
		BASE_MONO = 0,
		BASE_SEPIA = 1,
		BASE_NUM = 2,
		TEXT_NUM = 3,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[2] m_ButtonDataList; //Field offset: 0x114
	private AdvScrBtnLayer m_Layer; //Field offset: 0x118
	private Action BtnCallBack; //Field offset: 0x11C
	private RawImageEx MonoImage; //Field offset: 0x120
	private Material MonoMaterial; //Field offset: 0x124
	private RawImageEx SepiaImage; //Field offset: 0x128
	private Material SepiaMaterial; //Field offset: 0x12C

	private static AdvScrBtnDisp() { }

	public AdvScrBtnDisp() { }

	public void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public void ClearMono() { }

	public void ClearSepia() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void PretendPressScrBtn() { }

	public virtual void ReleaseAll() { }

	public void SetMono(Color color) { }

	public void SetScrBtnClickAction(Action action) { }

	public void SetSepia(Color color) { }

	protected virtual void UpdateDispMain() { }

}

