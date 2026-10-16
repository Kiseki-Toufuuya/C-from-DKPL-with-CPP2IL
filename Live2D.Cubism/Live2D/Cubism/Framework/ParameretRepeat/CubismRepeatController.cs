namespace Live2D.Cubism.Framework.ParameretRepeat;

public class CubismRepeatController : MonoBehaviour, ICubismUpdatable
{
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CubismParameter[] <Destinations>k__BackingField; //Field offset: 0x14

	private CubismParameter[] Destinations
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 60
	}

	[HideInInspector]
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

	public CubismRepeatController() { }

	[CompilerGenerated]
	private CubismParameter[] get_Destinations() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_Destinations(CubismParameter[] value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

}

