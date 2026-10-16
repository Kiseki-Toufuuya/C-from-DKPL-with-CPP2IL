namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

public interface IVariableGroup
{

	public bool TryGetValue(string key, out IVariable value) { }

}

