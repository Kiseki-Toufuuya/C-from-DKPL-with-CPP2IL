namespace Cinemachine;

public interface ICameraOverrideStack
{

	public Vector3 DefaultWorldUp
	{
		 get { } //Length: 0
	}

	public Vector3 get_DefaultWorldUp() { }

	public void ReleaseCameraOverride(int overrideId) { }

	public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

}

