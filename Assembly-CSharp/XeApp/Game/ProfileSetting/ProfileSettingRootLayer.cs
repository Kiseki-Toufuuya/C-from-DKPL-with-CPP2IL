namespace XeApp.Game.ProfileSetting;

public class ProfileSettingRootLayer : LayerBase
{
	internal enum eProfileViewType
	{
		MyProfile = 0,
		OtherProfile = 1,
		None = 2,
	}

	public eProfileViewType m_ProfileViewType; //Field offset: 0x58

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 47
	}

	public ProfileSettingRootLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

