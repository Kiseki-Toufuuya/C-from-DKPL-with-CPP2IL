namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

internal class VariableNameValuePair
{
	public string name; //Field offset: 0x8
	[SerializeReference]
	public IVariable variable; //Field offset: 0xC

	public VariableNameValuePair() { }

	public virtual string ToString() { }

}

