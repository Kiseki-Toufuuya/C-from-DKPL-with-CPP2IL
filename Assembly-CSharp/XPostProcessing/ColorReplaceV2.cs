namespace XPostProcessing;

[PostProcess(typeof(ColorReplaceV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/ColorReplaceV2", True)]
public class ColorReplaceV2 : PostProcessEffectSettings
{
	public GradientParameter FromGradientColor; //Field offset: 0x18
	public GradientParameter ToGradientColor; //Field offset: 0x1C
	[Range(0, 100)]
	public FloatParameter gridentSpeed; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter Range; //Field offset: 0x24
	[Range(0, 1)]
	public FloatParameter Fuzziness; //Field offset: 0x28

	public ColorReplaceV2() { }

}

