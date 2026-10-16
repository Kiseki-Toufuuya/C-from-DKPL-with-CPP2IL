namespace XPostProcessing;

[PostProcess(typeof(GlitchLineBlockRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/LineBlock", True)]
public class GlitchLineBlock : PostProcessEffectSettings
{
	public DirectionParameter blockDirection; //Field offset: 0x18
	public IntervalTypeParameter intervalType; //Field offset: 0x1C
	[Range(0, 25)]
	public FloatParameter frequency; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter Amount; //Field offset: 0x24
	[Range(0.1, 10)]
	public FloatParameter LinesWidth; //Field offset: 0x28
	[Range(0, 1)]
	public FloatParameter Speed; //Field offset: 0x2C
	[Range(0, 13)]
	public FloatParameter Offset; //Field offset: 0x30
	[Range(0, 1)]
	public FloatParameter Alpha; //Field offset: 0x34

	public GlitchLineBlock() { }

}

