namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(BloomRenderer), "Unity/Bloom", True)]
public sealed class Bloom : PostProcessEffectSettings
{
	[Min(0)]
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	public FloatParameter intensity; //Field offset: 0x18
	[Min(0)]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public FloatParameter threshold; //Field offset: 0x1C
	[Range(0, 1)]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	public FloatParameter softKnee; //Field offset: 0x20
	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	public FloatParameter clamp; //Field offset: 0x24
	[Range(1, 10)]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	public FloatParameter diffusion; //Field offset: 0x28
	[Range(-1, 1)]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	public FloatParameter anamorphicRatio; //Field offset: 0x2C
	[ColorUsage(False, True)]
	[Tooltip("Global tint of the bloom filter.")]
	public ColorParameter color; //Field offset: 0x30
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; //Field offset: 0x34
	[DisplayName("Texture")]
	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	public TextureParameter dirtTexture; //Field offset: 0x38
	[DisplayName("Intensity")]
	[Min(0)]
	[Tooltip("The intensity of the lens dirtiness.")]
	public FloatParameter dirtIntensity; //Field offset: 0x3C

	public Bloom() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

