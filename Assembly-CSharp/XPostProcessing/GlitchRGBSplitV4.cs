namespace XPostProcessing;

[PostProcess(typeof(GlitchRGBSplitV4Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/RGBSplitV4", True)]
public class GlitchRGBSplitV4 : PostProcessEffectSettings
{
	public GlitchRGBSplitDirectionParameter splitDirection; //Field offset: 0x18
	[Range(-1, 1)]
	public FloatParameter indensity; //Field offset: 0x1C
	[Range(0, 100)]
	public FloatParameter speed; //Field offset: 0x20

	public GlitchRGBSplitV4() { }

}

