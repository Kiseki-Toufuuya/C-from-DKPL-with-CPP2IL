namespace XPostProcessing;

[PostProcess(typeof(GlitchDigitalStripeRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Glitch/DigitalStripe", True)]
public class GlitchDigitalStripe : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter intensity; //Field offset: 0x18
	[Range(1, 10)]
	public IntParameter frequncy; //Field offset: 0x1C
	[Range(0, 0.99)]
	public FloatParameter stripeLength; //Field offset: 0x20
	[Range(8, 256)]
	public IntParameter noiseTextureWidth; //Field offset: 0x24
	[Range(8, 256)]
	public IntParameter noiseTextureHeight; //Field offset: 0x28
	public BoolParameter needStripColorAdjust; //Field offset: 0x2C
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter StripColorAdjustColor; //Field offset: 0x30
	[Range(0, 10)]
	public FloatParameter StripColorAdjustIndensity; //Field offset: 0x34

	public GlitchDigitalStripe() { }

}

