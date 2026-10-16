namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentBrightnessRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Brightness", True)]
public class ColorAdjustmentBrightness : PostProcessEffectSettings
{
	[Range(-0.9, 1)]
	public FloatParameter brightness; //Field offset: 0x18

	public ColorAdjustmentBrightness() { }

}

