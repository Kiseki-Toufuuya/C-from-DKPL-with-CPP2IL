namespace Heqet.RG;

public class RythmGameResultBgObiDisp : DispBase
{
	private enum eLayerId
	{
		BACKGROUND = 0,
	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private UiState WindowState; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	private Image m_BackGroundImg; //Field offset: 0x11C
	private BackGroundAssetBunleLoader m_Loader; //Field offset: 0x120
	[CompilerGenerated]
	private Action <LordedBackGroundImageCallback>k__BackingField; //Field offset: 0x124

	public private Action LordedBackGroundImageCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static RythmGameResultBgObiDisp() { }

	public RythmGameResultBgObiDisp() { }

	[CompilerGenerated]
	private void <UpdateBackGroundImage>b__20_0(AssetBundleLoadAssetOperation ope) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	private Action get_LordedBackGroundImageCallback() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_LordedBackGroundImageCallback(Action value) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation() { }

	public void UpdateBackGroundImage(int _backgroundid) { }

	protected virtual void UpdateDispMain() { }

}

