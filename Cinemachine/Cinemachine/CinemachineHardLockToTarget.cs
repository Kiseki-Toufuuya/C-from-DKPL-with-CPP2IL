namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineHardLockToTarget : CinemachineComponentBase
{
	[Tooltip("How much time it takes for the position to catch up to the target's position")]
	public float m_Damping; //Field offset: 0x14
	private Vector3 m_PreviousTargetPosition; //Field offset: 0x18

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public virtual Stage Stage
	{
		 get { } //Length: 3
	}

	public CinemachineHardLockToTarget() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	public virtual float GetMaxDampTime() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

