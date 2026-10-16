namespace Live2D.Cubism.Framework.MotionFade;

public interface ICubismFadeState
{

	public float GetLayerWeight() { }

	public List<CubismFadePlayingMotion> GetPlayingMotions() { }

	public bool GetStateTransitionFinished() { }

	public bool IsDefaultState() { }

	public void SetStateTransitionFinished(bool isFinished) { }

	public void StopAnimation(int index) { }

}

