namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentContrastV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/ContrastV2", True)]
public class ColorAdjustmentContrastV2 : PostProcessEffectSettings
{
	[Range(-1, 5)]
	public FloatParameter Contrast; //Field offset: 0x18
	[Range(-1, 1)]
	public FloatParameter ContrastFactorR; //Field offset: 0x1C
	[Range(-1, 1)]
	public FloatParameter ContrastFactorG; //Field offset: 0x20
	[Range(-1, 1)]
	public FloatParameter ContrastFactorB; //Field offset: 0x24

	public ColorAdjustmentContrastV2() { }

}

