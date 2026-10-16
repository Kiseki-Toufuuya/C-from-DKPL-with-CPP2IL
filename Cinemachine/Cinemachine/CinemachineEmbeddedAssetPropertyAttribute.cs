namespace Cinemachine;

public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
{
	public bool WarnIfNull; //Field offset: 0xC

	public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false) { }

}

