namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentContrastRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Contrast", True)]
public class ColorAdjustmentContrast : PostProcessEffectSettings
{
	[Range(-1, 2)]
	public FloatParameter contrast; //Field offset: 0x18

	public ColorAdjustmentContrast() { }

}

