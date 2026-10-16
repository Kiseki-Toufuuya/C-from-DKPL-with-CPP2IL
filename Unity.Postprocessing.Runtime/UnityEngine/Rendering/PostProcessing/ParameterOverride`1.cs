namespace UnityEngine.Rendering.PostProcessing;

public class ParameterOverride : ParameterOverride
{
	public T value; //Field offset: 0x0

	public ParameterOverride`1() { }

	public ParameterOverride`1(T value) { }

	public ParameterOverride`1(T value, bool overrideState) { }

	public virtual int GetHash() { }

	internal virtual void Interp(ParameterOverride from, ParameterOverride to, float t) { }

	public override void Interp(T from, T to, float t) { }

	public static T op_Implicit(ParameterOverride<T> prop) { }

	public void Override(T x) { }

	internal virtual void SetValue(ParameterOverride parameter) { }

}

