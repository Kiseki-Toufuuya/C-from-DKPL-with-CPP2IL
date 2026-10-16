namespace UnityEngine;

[UsedByNativeCode(Name = "ExposedReference")]
public struct ExposedReference
{
	[SerializeField]
	public PropertyName exposedName; //Field offset: 0x0
	[SerializeField]
	public object defaultValue; //Field offset: 0x0

	public T Resolve(IExposedPropertyTable resolver) { }

}

