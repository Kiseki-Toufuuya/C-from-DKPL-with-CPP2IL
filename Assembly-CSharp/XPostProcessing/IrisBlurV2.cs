namespace XPostProcessing;

[PostProcess(typeof(IrisBlurV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/IrisBlur/IrisBlurV2", True)]
public class IrisBlurV2 : PostProcessEffectSettings
{
	[Range(0, 3)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(8, 128)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(-1, 1)]
	public FloatParameter centerOffsetX; //Field offset: 0x20
	[Range(-1, 1)]
	public FloatParameter centerOffsetY; //Field offset: 0x24
	[Range(0, 50)]
	public FloatParameter AreaSize; //Field offset: 0x28
	public BoolParameter showPreview; //Field offset: 0x2C

	public IrisBlurV2() { }

}

