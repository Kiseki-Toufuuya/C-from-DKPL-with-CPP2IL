namespace Live2D.Cubism.Framework;

public class CubismParameterStore : MonoBehaviour, ICubismUpdatable
{
	[CompilerGenerated]
	private CubismParameter[] <DestinationParameters>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CubismPart[] <DestinationParts>k__BackingField; //Field offset: 0x14
	private Single[] _parameterValues; //Field offset: 0x18
	private Single[] _partOpacities; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x20

	private CubismParameter[] DestinationParameters
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismPart[] DestinationParts
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 61
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

	public CubismParameterStore() { }

	[CompilerGenerated]
	private CubismParameter[] get_DestinationParameters() { }

	[CompilerGenerated]
	private CubismPart[] get_DestinationParts() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	public void RestoreParameters() { }

	public void SaveParameters() { }

	[CompilerGenerated]
	private void set_DestinationParameters(CubismParameter[] value) { }

	[CompilerGenerated]
	private void set_DestinationParts(CubismPart[] value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

}

