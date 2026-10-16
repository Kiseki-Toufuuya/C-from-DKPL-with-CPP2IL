namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineHardLookAt : CinemachineComponentBase
{

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public virtual Stage Stage
	{
		 get { } //Length: 6
	}

	public CinemachineHardLookAt() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

