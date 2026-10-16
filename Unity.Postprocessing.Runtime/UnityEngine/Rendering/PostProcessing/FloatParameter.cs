namespace UnityEngine.Rendering.PostProcessing;

public sealed class FloatParameter : ParameterOverride<Single>
{

	public FloatParameter() { }

	public virtual void Interp(float from, float to, float t) { }

}

