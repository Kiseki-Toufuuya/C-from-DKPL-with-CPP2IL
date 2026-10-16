namespace XPostProcessing;

[PostProcess(typeof(RapidOldTVVignetteV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Vignette/RapidOldTVVignetteV2", True)]
public class RapidOldTVVignetteV2 : PostProcessEffectSettings
{
	public VignetteTypeParameter vignetteType; //Field offset: 0x18
	[Range(1, 5000)]
	public FloatParameter vignetteSize; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter sizeOffset; //Field offset: 0x20
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter vignetteColor; //Field offset: 0x24

	public RapidOldTVVignetteV2() { }

}

