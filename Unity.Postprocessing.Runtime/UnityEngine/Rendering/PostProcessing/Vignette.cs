namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", True)]
public sealed class Vignette : PostProcessEffectSettings
{
	[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
	public VignetteModeParameter mode; //Field offset: 0x18
	[Tooltip("Vignette color.")]
	public ColorParameter color; //Field offset: 0x1C
	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center; //Field offset: 0x20
	[Range(0, 1)]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity; //Field offset: 0x24
	[Range(0.01, 1)]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness; //Field offset: 0x28
	[Range(0, 1)]
	[Tooltip("Lower values will make a square-ish vignette.")]
	public FloatParameter roundness; //Field offset: 0x2C
	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded; //Field offset: 0x30
	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask; //Field offset: 0x34
	[Range(0, 1)]
	[Tooltip("Mask opacity.")]
	public FloatParameter opacity; //Field offset: 0x38

	public Vignette() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

