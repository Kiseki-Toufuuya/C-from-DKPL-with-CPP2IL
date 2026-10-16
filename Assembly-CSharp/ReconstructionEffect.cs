//Type is in global namespace

public class ReconstructionEffect : MonoBehaviour
{
	public float screenHeight; //Field offset: 0x10
	public Action OnStart; //Field offset: 0x14
	public Action OnFlash; //Field offset: 0x18

	public ReconstructionEffect() { }

	public void AnimEventFlash() { }

	public void AnimEventStart() { }

	public void FitOrthographicCamera(Camera target) { }

	private void OnDrawGizmos() { }

	private void Start() { }

}

