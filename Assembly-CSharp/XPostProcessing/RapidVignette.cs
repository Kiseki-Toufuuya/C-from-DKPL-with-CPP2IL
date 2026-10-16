namespace XPostProcessing;

[PostProcess(typeof(RapidVignetteRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Vignette/RapidVignette", True)]
public class RapidVignette : PostProcessEffectSettings
{
	public VignetteTypeParameter vignetteType; //Field offset: 0x18
	[Range(0, 5)]
	public FloatParameter vignetteIndensity; //Field offset: 0x1C
	public Vector2Parameter vignetteCenter; //Field offset: 0x20
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter vignetteColor; //Field offset: 0x24

	public RapidVignette() { }

}

