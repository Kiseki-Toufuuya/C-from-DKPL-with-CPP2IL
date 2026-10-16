namespace XPostProcessing;

[PostProcess(typeof(RapidVignetteV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Vignette/RapidVignetteV2", True)]
public class RapidVignetteV2 : PostProcessEffectSettings
{
	public VignetteTypeParameter vignetteType; //Field offset: 0x18
	[Range(0, 5)]
	public FloatParameter vignetteIndensity; //Field offset: 0x1C
	[Range(-1, 1)]
	public FloatParameter vignetteSharpness; //Field offset: 0x20
	public Vector2Parameter vignetteCenter; //Field offset: 0x24
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter vignetteColor; //Field offset: 0x28
	public GradientParameter grident1; //Field offset: 0x2C

	public RapidVignetteV2() { }

}

