namespace XPostProcessing;

[PostProcess(typeof(GlitchImageBlockV4Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ImageBlockV4", True)]
public class GlitchImageBlockV4 : PostProcessEffectSettings
{
	[Range(0, 50)]
	public FloatParameter Speed; //Field offset: 0x18
	[Range(0, 50)]
	public FloatParameter BlockSize; //Field offset: 0x1C
	[Range(0, 25)]
	public FloatParameter MaxRGBSplitX; //Field offset: 0x20
	[Range(0, 25)]
	public FloatParameter MaxRGBSplitY; //Field offset: 0x24

	public GlitchImageBlockV4() { }

}

