namespace Live2D.Cubism.Framework;

public abstract class CubismInspectorAbstract : MonoBehaviour, ICubismUpdatable
{
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x10

	public abstract int ExecutionOrder
	{
		 get { } //Length: 0
	}

	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	protected CubismInspectorAbstract() { }

	public abstract int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	public abstract void OnLateUpdate() { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

}

