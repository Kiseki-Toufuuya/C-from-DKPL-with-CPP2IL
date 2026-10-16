namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", True)]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	[Tooltip("The ambient occlusion method to use. \"Multi Scale Volumetric Obscurance\" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode; //Field offset: 0x18
	[Range(0, 4)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity; //Field offset: 0x1C
	[ColorUsage(False)]
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	public ColorParameter color; //Field offset: 0x20
	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly; //Field offset: 0x24
	[Range(-8, 0)]
	public FloatParameter noiseFilterTolerance; //Field offset: 0x28
	[Range(-8, -1)]
	public FloatParameter blurTolerance; //Field offset: 0x2C
	[Range(-12, -1)]
	public FloatParameter upsampleTolerance; //Field offset: 0x30
	[Range(1, 10)]
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	public FloatParameter thicknessModifier; //Field offset: 0x34
	[Range(0, 0.001)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias; //Field offset: 0x38
	[Range(0, 1)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength; //Field offset: 0x3C
	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius; //Field offset: 0x40
	[Tooltip("The number of sample points. This affects both quality and performance. For \"Lowest\", \"Low\", and \"Medium\", passes are downsampled. For \"High\" and \"Ultra\", they are not and therefore you should only \"High\" and \"Ultra\" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality; //Field offset: 0x44

	public AmbientOcclusion() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

