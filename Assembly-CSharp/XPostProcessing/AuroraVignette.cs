namespace XPostProcessing;

[PostProcess(typeof(AuroraVignetteRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Vignette/AuroraVignette", True)]
public class AuroraVignette : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter vignetteArea; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter vignetteSmothness; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter vignetteFading; //Field offset: 0x20
	[Range(0.1, 1)]
	public FloatParameter colorChange; //Field offset: 0x24
	[Range(0, 2)]
	public FloatParameter colorFactorR; //Field offset: 0x28
	[Range(0, 2)]
	public FloatParameter colorFactorG; //Field offset: 0x2C
	[Range(0, 2)]
	public FloatParameter colorFactorB; //Field offset: 0x30
	[Range(-2, 2)]
	public FloatParameter flowSpeed; //Field offset: 0x34

	public AuroraVignette() { }

}

