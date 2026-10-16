namespace XPostProcessing;

[PostProcess(typeof(GlitchImageBlockRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ImageBlock", True)]
public class GlitchImageBlock : PostProcessEffectSettings
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
	public FloatParameter BlockLayer2_U; //Field offset: 0x2C
	[Range(0, 50)]
	public FloatParameter BlockLayer2_V; //Field offset: 0x30
	[Range(0, 50)]
	public FloatParameter BlockLayer1_Indensity; //Field offset: 0x34
	[Range(0, 50)]
	public FloatParameter BlockLayer2_Indensity; //Field offset: 0x38
	[Range(0, 50)]
	public FloatParameter RGBSplitIndensity; //Field offset: 0x3C
	public BoolParameter BlockVisualizeDebug; //Field offset: 0x40

	public GlitchImageBlock() { }

}

