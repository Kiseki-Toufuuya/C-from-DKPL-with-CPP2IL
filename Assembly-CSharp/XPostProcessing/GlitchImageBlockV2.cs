namespace XPostProcessing;

[PostProcess(typeof(GlitchImageBlockV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ImageBlockV2", True)]
public class GlitchImageBlockV2 : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter Fade; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Speed; //Field offset: 0x1C
	[Range(0, 10)]
	public FloatParameter Amount; //Field offset: 0x20
	[Range(0, 50)]
	public FloatParameter BlockLayer1_U; //Field offset: 0x24
	[Range(0, 50)]
	public FloatParameter BlockLayer1_V; //Field offset: 0x28
	[Range(0, 50)]
	public FloatParameter BlockLayer1_Indensity; //Field offset: 0x2C
	[Range(0, 50)]
	public FloatParameter RGBSplitIndensity; //Field offset: 0x30
	public BoolParameter BlockVisualizeDebug; //Field offset: 0x34

	public GlitchImageBlockV2() { }

}

