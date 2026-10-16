namespace Heqet;

public class StageListHooterDisp : DispBase
{
	internal enum eButtonId
	{
		Back = 0,
		ChangeSpotLeft = 1,
		ChangeSpotRight = 2,
		Favorite = 3,
		Help = 4,
		NUM = 5,
	}

	private String[] m_ButtonDataList; //Field offset: 0x114
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x118

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StageListHooterDisp() { }

	public void CallbackButton(int id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	protected virtual void UpdateDispMain() { }

}

