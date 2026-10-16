namespace XPostProcessing;

[PostProcess(typeof(GlitchRGBSplitV5Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/RGBSplitV5", True)]
public class GlitchRGBSplitV5 : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter Amplitude; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Speed; //Field offset: 0x1C

	public GlitchRGBSplitV5() { }

}

