namespace UnityEngine.Rendering.PostProcessing;

public sealed class ColorParameter : ParameterOverride<Color>
{

	public ColorParameter() { }

	public virtual void Interp(Color from, Color to, float t) { }

	public static Vector4 op_Implicit(ColorParameter prop) { }

}

