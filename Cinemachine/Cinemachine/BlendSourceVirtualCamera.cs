namespace Cinemachine;

internal class BlendSourceVirtualCamera : ICinemachineCamera
{
	[CompilerGenerated]
	private CinemachineBlend <Blend>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Transform <LookAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private CameraState <State>k__BackingField; //Field offset: 0x18

	public CinemachineBlend Blend
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override string Description
	{
		 get { } //Length: 63
	}

	public override Transform Follow
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override bool IsValid
	{
		 get { } //Length: 31
	}

	public override Transform LookAt
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override string Name
	{
		 get { } //Length: 35
	}

	public override ICinemachineCamera ParentCamera
	{
		 get { } //Length: 3
	}

	public override int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private override CameraState State
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 41
	}

	public override GameObject VirtualCameraGameObject
	{
		 get { } //Length: 3
	}

	public BlendSourceVirtualCamera(CinemachineBlend blend) { }

	public CameraState CalculateNewState(float deltaTime) { }

	[CompilerGenerated]
	public CinemachineBlend get_Blend() { }

	public override string get_Description() { }

	[CompilerGenerated]
	public override Transform get_Follow() { }

	public override bool get_IsValid() { }

	[CompilerGenerated]
	public override Transform get_LookAt() { }

	public override string get_Name() { }

	public override ICinemachineCamera get_ParentCamera() { }

	[CompilerGenerated]
	public override int get_Priority() { }

	[CompilerGenerated]
	public override CameraState get_State() { }

	public override GameObject get_VirtualCameraGameObject() { }

	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGenerated]
	public void set_Blend(CinemachineBlend value) { }

	[CompilerGenerated]
	public override void set_Follow(Transform value) { }

	[CompilerGenerated]
	public override void set_LookAt(Transform value) { }

	[CompilerGenerated]
	public override void set_Priority(int value) { }

	[CompilerGenerated]
	private void set_State(CameraState value) { }

	public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

}

