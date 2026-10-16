namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineSameAsFollowTarget : CinemachineComponentBase
{
	[FormerlySerializedAs("m_AngularDamping")]
	[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
	public float m_Damping; //Field offset: 0x14
	private Quaternion m_PreviousReferenceOrientation; //Field offset: 0x18

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public virtual Stage Stage
	{
		 get { } //Length: 6
	}

	public CinemachineSameAsFollowTarget() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	public virtual float GetMaxDampTime() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

