namespace XPostProcessing;

[PostProcess(typeof(ColorAdjustmentContrastV3Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/ContrastV3", True)]
public class ColorAdjustmentContrastV3 : PostProcessEffectSettings
{
	[ColorWheel(Mode::Contrast (4))]
	[DisplayName("Contrast Wheel")]
	public Vector4Parameter contrast; //Field offset: 0x18

	public ColorAdjustmentContrastV3() { }

}

