namespace XPostProcessing;

[PostProcess(typeof(GlitchRGBSplitV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/RGBSplitV2", True)]
public class GlitchRGBSplitV2 : PostProcessEffectSettings
{
	public GlitchRGBSplitDirectionParameter SplitDirection; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Amount; //Field offset: 0x1C
	[Range(1, 6)]
	public FloatParameter Amplitude; //Field offset: 0x20
	[Range(0, 2)]
	public FloatParameter Speed; //Field offset: 0x24

	public GlitchRGBSplitV2() { }

}

