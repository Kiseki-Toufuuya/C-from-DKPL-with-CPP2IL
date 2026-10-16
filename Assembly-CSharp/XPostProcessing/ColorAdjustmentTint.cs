namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentTintRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Tint", True)]
public class ColorAdjustmentTint : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter indensity; //Field offset: 0x18
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter colorTint; //Field offset: 0x1C

	public ColorAdjustmentTint() { }

}

