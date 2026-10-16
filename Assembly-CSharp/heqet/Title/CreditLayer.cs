namespace Heqet.Title;

public class CreditLayer : LayerBase
{
	private enum eContStep
	{
		WAIT_EPISODE = 0,
		MAIN = 1,
		WAIT_DLIALOG = 2,
		NONE = 3,
	}

	private enum eMainStep
	{
		INIT = 0,
		INIT_WAIT = 1,
		OPENING = 2,
		MAIN = 3,
		CLOSE = 4,
		CLOSEING = 5,
		END = 6,
		NONE = 7,
	}

	private static string creditXabName; //Field offset: 0x0
	private eMainStep m_MainStep; //Field offset: 0x58
	private eContStep m_ContStep; //Field offset: 0x5C
	private StaffCredit m_StaffCredit; //Field offset: 0x60
	private string m_bgStillTextureName; //Field offset: 0x64
	[CompilerGenerated]
	private Sprite <PreLoadBgSprite>k__BackingField; //Field offset: 0x68
	public int loadStlillBgId; //Field offset: 0x6C
	private InputActionReference m_cancel; //Field offset: 0x70
	private bool m_sKip; //Field offset: 0x74

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public bool IsEnd
	{
		 get { } //Length: 117
	}

	public bool IsLoaded
	{
		 get { } //Length: 75
	}

	public Sprite PreLoadBgSprite
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	private static CreditLayer() { }

	public CreditLayer() { }

	[CompilerGenerated]
	private void <ContMain>b__28_0(ButtonType btnId) { }

	[CompilerGenerated]
	private void <Update>b__27_0(AssetBundleLoadAssetOperation assetbundle) { }

	[CompilerGenerated]
	private void <Update>b__27_1(AssetBundleLoadAssetOperation textureAb) { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public bool get_IsEnd() { }

	public bool get_IsLoaded() { }

	[CompilerGenerated]
	public Sprite get_PreLoadBgSprite() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_PreLoadBgSprite(Sprite value) { }

	public void StartCredit() { }

	protected virtual void Update(bool is_active) { }

}

