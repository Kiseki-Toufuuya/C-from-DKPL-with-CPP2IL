namespace XPostProcessing;

[PostProcess(typeof(GlitchImageBlockV3Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ImageBlockV3", True)]
public class GlitchImageBlockV3 : PostProcessEffectSettings
{
	[Range(0, 50)]
	public FloatParameter Speed; //Field offset: 0x18
	[Range(0, 50)]
	public FloatParameter BlockSize; //Field offset: 0x1C

	public GlitchImageBlockV3() { }

}

