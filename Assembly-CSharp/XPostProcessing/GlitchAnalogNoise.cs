namespace XPostProcessing;

[PostProcess(typeof(GlitchAnalogNoiseRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/AnalogNoise", True)]
public class GlitchAnalogNoise : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter NoiseSpeed; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter NoiseFading; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter LuminanceJitterThreshold; //Field offset: 0x20

	public GlitchAnalogNoise() { }

}

