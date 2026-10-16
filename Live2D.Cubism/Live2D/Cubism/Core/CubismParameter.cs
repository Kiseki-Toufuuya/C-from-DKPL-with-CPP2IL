namespace Live2D.Cubism.Core;

[CubismDontMoveOnReimport]
public sealed class CubismParameter : MonoBehaviour
{
	[CompilerGenerated]
	private CubismUnmanagedParameters <UnmanagedParameters>k__BackingField; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int _unmanagedIndex; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	public float Value; //Field offset: 0x18
	private CubismModel _model; //Field offset: 0x1C
	[SerializeField]
	private bool _isOverriddenUserParameterRepeat; //Field offset: 0x20
	[SerializeField]
	private bool _isParameterRepeated; //Field offset: 0x21

	public float DefaultValue
	{
		 get { } //Length: 41
	}

	public string Id
	{
		 get { } //Length: 43
	}

	public float MaximumValue
	{
		 get { } //Length: 41
	}

	public float MinimumValue
	{
		 get { } //Length: 41
	}

	public int Type
	{
		 get { } //Length: 41
	}

	internal int UnmanagedIndex
	{
		internal get { } //Length: 11
		private set { } //Length: 14
	}

	private CubismUnmanagedParameters UnmanagedParameters
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismParameter() { }

	internal static GameObject CreateParameters(CubismUnmanagedModel unmanagedModel) { }

	public float get_DefaultValue() { }

	public string get_Id() { }

	public float get_MaximumValue() { }

	public float get_MinimumValue() { }

	public int get_Type() { }

	internal int get_UnmanagedIndex() { }

	[CompilerGenerated]
	private CubismUnmanagedParameters get_UnmanagedParameters() { }

	public bool GetOverrideFlagForModelParameterRepeat() { }

	public bool GetOverrideFlagForParameterRepeat() { }

	public float GetParameterClampValue(float value) { }

	public bool GetParameterRepeats() { }

	public float GetParameterRepeatValue(float value) { }

	public bool GetRepeatFlagForParameterRepeat() { }

	public bool IsRepeat() { }

	private void Reset(CubismUnmanagedModel unmanagedModel, int unmanagedIndex) { }

	internal void Revive(CubismUnmanagedModel unmanagedModel) { }

	private void set_UnmanagedIndex(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedParameters(CubismUnmanagedParameters value) { }

	public void SetOverrideFlagForParameterRepeat(bool value) { }

	public void SetRepeatFlagForParameterRepeat(bool value) { }

}

