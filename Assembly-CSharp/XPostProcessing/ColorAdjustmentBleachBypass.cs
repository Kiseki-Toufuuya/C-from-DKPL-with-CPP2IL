namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentBleachBypassRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/BleachBypass", True)]
public class ColorAdjustmentBleachBypass : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter Indensity; //Field offset: 0x18

	public ColorAdjustmentBleachBypass() { }

}

