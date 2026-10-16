namespace UnityEngine.Rendering.PostProcessing;

public sealed class IntParameter : ParameterOverride<Int32>
{

	public IntParameter() { }

	public virtual void Interp(int from, int to, float t) { }

}

