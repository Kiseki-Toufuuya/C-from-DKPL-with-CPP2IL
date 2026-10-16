namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentHueRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Hue", True)]
public class ColorAdjustmentHue : PostProcessEffectSettings
{
	[Range(-180, 180)]
	public FloatParameter HueDegree; //Field offset: 0x18

	public ColorAdjustmentHue() { }

}

