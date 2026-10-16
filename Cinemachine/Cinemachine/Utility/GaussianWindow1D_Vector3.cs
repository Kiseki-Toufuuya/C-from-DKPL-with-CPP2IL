namespace Cinemachine.Utility;

internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3>
{

	public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10) { }

	protected virtual Vector3 Compute(int windowPos) { }

}

