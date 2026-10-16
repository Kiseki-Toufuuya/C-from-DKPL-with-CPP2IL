namespace UnityEngine.Rendering.PostProcessing;

public sealed class Vector3Parameter : ParameterOverride<Vector3>
{

	public Vector3Parameter() { }

	public virtual void Interp(Vector3 from, Vector3 to, float t) { }

	public static Vector2 op_Implicit(Vector3Parameter prop) { }

	public static Vector4 op_Implicit(Vector3Parameter prop) { }

}

