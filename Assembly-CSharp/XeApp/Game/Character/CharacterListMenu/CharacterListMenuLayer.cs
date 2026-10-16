namespace XeApp.Game.Character.CharacterListMenu;

public class CharacterListMenuLayer : LayerBase
{
	internal enum eCharacterListMenuType
	{
		Edit = 0,
		LvUp = 1,
		Awake = 2,
		LimitBreak = 3,
		Sell = 4,
		SellH = 5,
		List = 6,
		Book = 7,
		Nakayoshi = 8,
		Heroine = 9,
		MainMenuEnd = 10,
		HomeSetting = 10,
		ClubIconSetting = 11,
		ProfileSetting = 12,
		PosterSetting = 13,
	}


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

	public CharacterListMenuLayer() { }

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

