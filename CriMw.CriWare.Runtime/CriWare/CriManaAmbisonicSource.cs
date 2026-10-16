namespace CriWare;

public class CriManaAmbisonicSource : CriMonoBehaviour
{
	private CriAtomEx3dSource atomEx3DsourceForAmbisonics; //Field offset: 0x20
	private Vector3 ambisonicSourceOrientationFront; //Field offset: 0x24
	private Vector3 ambisonicSourceOrientationTop; //Field offset: 0x30
	private Vector3 lastEulerOfAmbisonicSource; //Field offset: 0x3C

	public CriManaAmbisonicSource() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	private void ForceUpdateAmbisonicSourceOrientation() { }

	protected virtual void OnEnable() { }

	private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler) { }

	private void UpdateAmbisonicSourceOrientation() { }

}

