namespace XPostProcessing;

[PostProcess(typeof(GlitchRGBSplitV3Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/RGBSplitV3", True)]
public class GlitchRGBSplitV3 : PostProcessEffectSettings
{
	public DirectionEXParameter SplitDirection; //Field offset: 0x18
	public IntervalTypeParameter intervalType; //Field offset: 0x1C
	[Range(0.1, 25)]
	public FloatParameter Frequency; //Field offset: 0x20
	[Range(0, 200)]
	public FloatParameter Amount; //Field offset: 0x24
	[Range(0, 15)]
	public FloatParameter Speed; //Field offset: 0x28

	public GlitchRGBSplitV3() { }

}

