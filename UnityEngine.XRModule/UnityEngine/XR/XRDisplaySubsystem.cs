namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRBlitParams
	{
		public RenderTexture srcTex; //Field offset: 0x0
		public int srcTexArraySlice; //Field offset: 0x4
		public Rect srcRect; //Field offset: 0x8
		public Rect destRect; //Field offset: 0x18
		public IntPtr foveatedRenderingInfo; //Field offset: 0x28
		public bool srcHdrEncoded; //Field offset: 0x2C
		public ColorGamut srcHdrColorGamut; //Field offset: 0x30
		public int srcHdrMaxLuminance; //Field offset: 0x34

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public bool nativeBlitAvailable; //Field offset: 0x4
		public bool nativeBlitInvalidStates; //Field offset: 0x5
		public int blitParamsCount; //Field offset: 0x8

	}

	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	internal struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public int renderPassIndex; //Field offset: 0x4
		public RenderTargetIdentifier renderTarget; //Field offset: 0x8
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x24
		public bool hasMotionVectorPass; //Field offset: 0x58
		public RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x5C
		public RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0x78
		public bool shouldFillOutDepth; //Field offset: 0xAC
		public bool spaceWarpRightHandedNDC; //Field offset: 0xAD
		public int cullingPassIndex; //Field offset: 0xB0
		public IntPtr foveatedRenderingInfo; //Field offset: 0xB4

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> displayFocusChanged; //Field offset: 0x10

	public XRDisplaySubsystem() { }

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus) { }

}

