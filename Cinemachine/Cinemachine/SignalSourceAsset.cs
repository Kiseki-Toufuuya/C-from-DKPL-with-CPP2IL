namespace Cinemachine;

[DocumentationSorting(Level::API (1))]
public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D
{

	public abstract float SignalDuration
	{
		 get { } //Length: 0
	}

	protected SignalSourceAsset() { }

	public abstract float get_SignalDuration() { }

	public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

