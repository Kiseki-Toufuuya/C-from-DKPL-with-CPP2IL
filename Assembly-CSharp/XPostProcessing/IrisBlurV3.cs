namespace XPostProcessing;

[PostProcess(typeof(IrisBlurV3Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/IrisBlur/IrisBlurV3", True)]
public class IrisBlurV3 : PostProcessEffectSettings
{
	[Range(0, 10)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(8, 128)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(-1, 1)]
	public FloatParameter centerOffsetX; //Field offset: 0x20
	[Range(-1, 1)]
	public FloatParameter centerOffsetY; //Field offset: 0x24
	[Range(0, 50)]
	public FloatParameter AreaSize; //Field offset: 0x28
	[Range(0, 5)]
	public FloatParameter vignetteIndensity; //Field offset: 0x2C
	[Range(-1, 1)]
	public FloatParameter vignetteSharpness; //Field offset: 0x30
	public BoolParameter showPreview; //Field offset: 0x34

	public IrisBlurV3() { }

}

