namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentLensFilterRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/LensFilter", True)]
public class ColorAdjustmentLensFilter : PostProcessEffectSettings
{
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter LensColor; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Indensity; //Field offset: 0x1C

	public ColorAdjustmentLensFilter() { }

}

