namespace UnityEngine;

public interface IExposedPropertyTable
{

	public object GetReferenceValue(PropertyName id, out bool idValid) { }

}

