namespace Cinemachine.Utility;

internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<Vector2>
{

	public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10) { }

	protected virtual Vector2 Compute(int windowPos) { }

}

