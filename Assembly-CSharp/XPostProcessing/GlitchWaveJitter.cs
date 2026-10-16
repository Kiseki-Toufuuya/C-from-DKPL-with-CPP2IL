namespace XPostProcessing;

[PostProcess(typeof(GlitchWaveJitterRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/WaveJitter", True)]
public class GlitchWaveJitter : PostProcessEffectSettings
{
	public DirectionParameter jitterDirection; //Field offset: 0x18
	public IntervalTypeParameter intervalType; //Field offset: 0x1C
	[Range(0, 50)]
	public FloatParameter frequency; //Field offset: 0x20
	[Range(0, 50)]
	public FloatParameter RGBSplit; //Field offset: 0x24
	[Range(0, 1)]
	public FloatParameter speed; //Field offset: 0x28
	[Range(0, 2)]
	public FloatParameter amount; //Field offset: 0x2C
	public BoolParameter customResolution; //Field offset: 0x30
	public Vector2Parameter resolution; //Field offset: 0x34

	public GlitchWaveJitter() { }

}

