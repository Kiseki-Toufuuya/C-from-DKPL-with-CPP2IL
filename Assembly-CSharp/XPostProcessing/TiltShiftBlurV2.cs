namespace XPostProcessing;

[PostProcess(typeof(TiltShiftBlurV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/TiltShiftBlur/TiltShiftBlurV2", True)]
public class TiltShiftBlurV2 : PostProcessEffectSettings
{
	[Range(0, 3)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(8, 128)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(-1, 1)]
	public FloatParameter centerOffset; //Field offset: 0x20
	[Range(0, 20)]
	public FloatParameter AreaSize; //Field offset: 0x24
	[Range(1, 20)]
	public FloatParameter areaSmooth; //Field offset: 0x28
	public BoolParameter showPreview; //Field offset: 0x2C

	public TiltShiftBlurV2() { }

}

