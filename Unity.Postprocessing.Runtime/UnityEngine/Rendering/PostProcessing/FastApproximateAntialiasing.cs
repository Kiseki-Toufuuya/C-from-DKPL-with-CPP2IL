namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
public sealed class FastApproximateAntialiasing
{
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public bool fastMode; //Field offset: 0x8
	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.\nThis setting has no effect if the camera render target has no alpha channel.")]
	public bool keepAlpha; //Field offset: 0x9

	public FastApproximateAntialiasing() { }

}

