namespace UnityEngine.Rendering.PostProcessing;

public sealed class TextureParameter : ParameterOverride<Texture>
{
	public TextureParameterDefault defaultState; //Field offset: 0x10

	public TextureParameter() { }

	public virtual void Interp(Texture from, Texture to, float t) { }

}

