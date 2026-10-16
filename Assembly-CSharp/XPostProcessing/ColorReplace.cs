namespace XPostProcessing;

[PostProcess(typeof(ColorReplaceRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ColorAdjustment/ColorReplace", True)]
public class ColorReplace : PostProcessEffectSettings
{
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter FromColor; //Field offset: 0x18
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter ToColor; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter Range; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter Fuzziness; //Field offset: 0x24

	public ColorReplace() { }

}

