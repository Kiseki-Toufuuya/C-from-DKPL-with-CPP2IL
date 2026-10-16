namespace Cinemachine;

public interface ISignalSource6D
{

	public float SignalDuration
	{
		 get { } //Length: 0
	}

	public float get_SignalDuration() { }

	public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

