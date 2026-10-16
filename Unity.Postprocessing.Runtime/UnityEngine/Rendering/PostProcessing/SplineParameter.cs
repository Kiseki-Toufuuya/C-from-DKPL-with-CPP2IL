namespace UnityEngine.Rendering.PostProcessing;

public sealed class SplineParameter : ParameterOverride<Spline>
{

	public SplineParameter() { }

	public virtual void Interp(Spline from, Spline to, float t) { }

	protected private virtual void OnEnable() { }

	internal virtual void SetValue(ParameterOverride parameter) { }

}

