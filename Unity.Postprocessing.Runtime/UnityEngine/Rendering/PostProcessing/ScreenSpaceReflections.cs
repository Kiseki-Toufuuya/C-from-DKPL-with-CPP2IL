namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", True)]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings
{
	[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPresetParameter preset; //Field offset: 0x18
	[Range(0, 256)]
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	public IntParameter maximumIterationCount; //Field offset: 0x1C
	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolutionParameter resolution; //Field offset: 0x20
	[Range(1, 64)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public FloatParameter thickness; //Field offset: 0x24
	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public FloatParameter maximumMarchDistance; //Field offset: 0x28
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the near planes.")]
	public FloatParameter distanceFade; //Field offset: 0x2C
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the screen edges.")]
	public FloatParameter vignette; //Field offset: 0x30

	public ScreenSpaceReflections() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

