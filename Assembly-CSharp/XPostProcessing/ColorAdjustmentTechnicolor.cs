namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentTechnicolorRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/Technicolor", True)]
public class ColorAdjustmentTechnicolor : PostProcessEffectSettings
{
	[Range(0, 8)]
	public FloatParameter exposure; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter colorBalanceR; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter colorBalanceG; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter colorBalanceB; //Field offset: 0x24
	[Range(0, 1)]
	public FloatParameter indensity; //Field offset: 0x28

	public ColorAdjustmentTechnicolor() { }

}

