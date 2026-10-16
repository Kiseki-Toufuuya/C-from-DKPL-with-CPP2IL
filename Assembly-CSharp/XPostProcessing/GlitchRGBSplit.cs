namespace XPostProcessing;

[PostProcess(typeof(GlitchRGBSplitRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/RGBSplit", True)]
public class GlitchRGBSplit : PostProcessEffectSettings
{
	public GlitchRGBSplitDirectionParameter SplitDirection; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Fading; //Field offset: 0x1C
	[Range(0, 5)]
	public FloatParameter Amount; //Field offset: 0x20
	[Range(0, 10)]
	public FloatParameter Speed; //Field offset: 0x24
	[Range(0, 1)]
	public FloatParameter CenterFading; //Field offset: 0x28
	[Range(0, 5)]
	public FloatParameter AmountR; //Field offset: 0x2C
	[Range(0, 5)]
	public FloatParameter AmountB; //Field offset: 0x30

	public GlitchRGBSplit() { }

}

