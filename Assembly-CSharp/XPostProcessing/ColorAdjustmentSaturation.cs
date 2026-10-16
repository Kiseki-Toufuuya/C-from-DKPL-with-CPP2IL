namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentSaturationRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Saturation", True)]
public class ColorAdjustmentSaturation : PostProcessEffectSettings
{
	[Range(0, 2)]
	public FloatParameter saturation; //Field offset: 0x18

	public ColorAdjustmentSaturation() { }

}

