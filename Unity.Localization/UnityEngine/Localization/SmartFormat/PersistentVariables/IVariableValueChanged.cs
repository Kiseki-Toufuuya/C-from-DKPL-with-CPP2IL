namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

public interface IVariableValueChanged : IVariable
{

	public event Action<IVariable> ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ValueChanged(Action<IVariable> value) { }

	[CompilerGenerated]
	public void remove_ValueChanged(Action<IVariable> value) { }

}

