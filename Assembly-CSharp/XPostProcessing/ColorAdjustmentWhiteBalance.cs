namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentWhiteBalanceRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/WhiteBalance", True)]
public class ColorAdjustmentWhiteBalance : PostProcessEffectSettings
{
	[Range(-1, 1)]
	public FloatParameter temperature; //Field offset: 0x18
	[Range(-1, 1)]
	public FloatParameter tint; //Field offset: 0x1C

	public ColorAdjustmentWhiteBalance() { }

}

