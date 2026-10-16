namespace UnityEngine.EventSystems;

public class AxisEventData : BaseEventData
{
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; //Field offset: 0x18

	public MoveDirection moveDir
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Vector2 moveVector
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public AxisEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public MoveDirection get_moveDir() { }

	[CompilerGenerated]
	public Vector2 get_moveVector() { }

	[CompilerGenerated]
	public void set_moveDir(MoveDirection value) { }

	[CompilerGenerated]
	public void set_moveVector(Vector2 value) { }

}

