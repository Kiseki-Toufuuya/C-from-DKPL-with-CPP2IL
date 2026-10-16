namespace XPostProcessing;

[PostProcess(typeof(GlitchScanLineJitterRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ScanLineJitter", True)]
public class GlitchScanLineJitter : PostProcessEffectSettings
{
	public DirectionParameter JitterDirection; //Field offset: 0x18
	public IntervalTypeParameter intervalType; //Field offset: 0x1C
	[Range(0, 25)]
	public FloatParameter frequency; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter JitterIndensity; //Field offset: 0x24

	public GlitchScanLineJitter() { }

}

