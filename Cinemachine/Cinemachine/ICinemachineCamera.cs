namespace Cinemachine;

public interface ICinemachineCamera
{

	public string Description
	{
		 get { } //Length: 0
	}

	public Transform Follow
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsValid
	{
		 get { } //Length: 0
	}

	public Transform LookAt
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public ICinemachineCamera ParentCamera
	{
		 get { } //Length: 0
	}

	public int Priority
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public CameraState State
	{
		 get { } //Length: 0
	}

	public GameObject VirtualCameraGameObject
	{
		 get { } //Length: 0
	}

	public string get_Description() { }

	public Transform get_Follow() { }

	public bool get_IsValid() { }

	public Transform get_LookAt() { }

	public string get_Name() { }

	public ICinemachineCamera get_ParentCamera() { }

	public int get_Priority() { }

	public CameraState get_State() { }

	public GameObject get_VirtualCameraGameObject() { }

	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	public void set_Follow(Transform value) { }

	public void set_LookAt(Transform value) { }

	public void set_Priority(int value) { }

	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

}

