namespace UnityEngine.Rendering.PostProcessing;

public sealed class Vector4Parameter : ParameterOverride<Vector4>
{

	public Vector4Parameter() { }

	public virtual void Interp(Vector4 from, Vector4 to, float t) { }

	public static Vector2 op_Implicit(Vector4Parameter prop) { }

	public static Vector3 op_Implicit(Vector4Parameter prop) { }

}

