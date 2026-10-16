namespace XPostProcessing;

[PostProcess(typeof(GlitchScreenShakeRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ScreenShake", True)]
public class GlitchScreenShake : PostProcessEffectSettings
{
	public GlitchScreenShakeDirectionParameter ScreenShakeDirection; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter ScreenShakeIndensity; //Field offset: 0x1C

	public GlitchScreenShake() { }

}

