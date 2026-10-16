namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(GrainRenderer), "Unity/Grain", True)]
public sealed class Grain : PostProcessEffectSettings
{
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored; //Field offset: 0x18
	[Range(0, 1)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity; //Field offset: 0x1C
	[Range(0.3, 3)]
	[Tooltip("Grain particle size.")]
	public FloatParameter size; //Field offset: 0x20
	[DisplayName("Luminance Contribution")]
	[Range(0, 1)]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib; //Field offset: 0x24

	public Grain() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

