namespace XPostProcessing;

[PostProcess(typeof(GlitchTileJitterRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/TileJitter", True)]
public class GlitchTileJitter : PostProcessEffectSettings
{
	public DirectionParameter jitterDirection; //Field offset: 0x18
	public IntervalTypeParameter intervalType; //Field offset: 0x1C
	[Range(0, 25)]
	public FloatParameter frequency; //Field offset: 0x20
	public DirectionParameter splittingDirection; //Field offset: 0x24
	[Range(0, 50)]
	public FloatParameter splittingNumber; //Field offset: 0x28
	[Range(0, 100)]
	public FloatParameter amount; //Field offset: 0x2C
	[Range(0, 1)]
	public FloatParameter speed; //Field offset: 0x30

	public GlitchTileJitter() { }

}

