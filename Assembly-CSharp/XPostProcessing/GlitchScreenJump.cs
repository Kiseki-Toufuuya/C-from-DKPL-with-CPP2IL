namespace XPostProcessing;

[PostProcess(typeof(GlitchScreenJumpRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/ScreenJump", False)]
public class GlitchScreenJump : PostProcessEffectSettings
{
	public GlitchScreenJumpDirectionParameter ScreenJumpDirection; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter ScreenJumpIndensity; //Field offset: 0x1C

	public GlitchScreenJump() { }

}

