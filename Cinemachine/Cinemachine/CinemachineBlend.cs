namespace Cinemachine;

public class CinemachineBlend
{
	public ICinemachineCamera CamA; //Field offset: 0x8
	public ICinemachineCamera CamB; //Field offset: 0xC
	public AnimationCurve BlendCurve; //Field offset: 0x10
	public float TimeInBlend; //Field offset: 0x14
	public float Duration; //Field offset: 0x18

	public float BlendWeight
	{
		 get { } //Length: 167
	}

	public string Description
	{
		 get { } //Length: 455
	}

	public bool IsComplete
	{
		 get { } //Length: 36
	}

	public bool IsValid
	{
		 get { } //Length: 103
	}

	public CameraState State
	{
		 get { } //Length: 502
	}

	public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	public float get_BlendWeight() { }

	public string get_Description() { }

	public bool get_IsComplete() { }

	public bool get_IsValid() { }

	public CameraState get_State() { }

	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public bool Uses(ICinemachineCamera cam) { }

}

