namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState; //Field offset: 0x8

	protected ParameterOverride() { }

	public abstract int GetHash() { }

	public T GetValue() { }

	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t) { }

	protected private override void OnDisable() { }

	protected private override void OnEnable() { }

	internal abstract void SetValue(ParameterOverride parameter) { }

}

