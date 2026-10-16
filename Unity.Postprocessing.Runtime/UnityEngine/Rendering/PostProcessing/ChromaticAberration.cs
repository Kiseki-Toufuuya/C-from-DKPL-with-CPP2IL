namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", True)]
public sealed class ChromaticAberration : PostProcessEffectSettings
{
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	public TextureParameter spectralLut; //Field offset: 0x18
	[Range(0, 1)]
	[Tooltip("Amount of tangential distortion.")]
	public FloatParameter intensity; //Field offset: 0x1C
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; //Field offset: 0x20

	public ChromaticAberration() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

