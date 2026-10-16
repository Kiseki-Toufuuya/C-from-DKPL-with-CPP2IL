namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput
{
	public JobHandle cullingJobsFence; //Field offset: 0x0
	public Matrix4x4 localToWorldMatrix; //Field offset: 0x10
	public Plane* cullingPlanes; //Field offset: 0x50
	public int cullingPlaneCount; //Field offset: 0x54
	public int receiverPlaneOffset; //Field offset: 0x58
	public int receiverPlaneCount; //Field offset: 0x5C
	public CullingSplit* cullingSplits; //Field offset: 0x60
	public int cullingSplitCount; //Field offset: 0x64
	public BatchCullingViewType viewType; //Field offset: 0x68
	public BatchCullingProjectionType projectionType; //Field offset: 0x6C
	public BatchCullingFlags cullingFlags; //Field offset: 0x70
	public ulong viewID; //Field offset: 0x78
	public uint cullingLayerMask; //Field offset: 0x80
	public byte splitExclusionMask; //Field offset: 0x84
	public ulong sceneCullingMask; //Field offset: 0x88
	public BatchCullingOutputDrawCommands* drawCommands; //Field offset: 0x90
	public uint brgId; //Field offset: 0x94
	public IntPtr occlusionBuffer; //Field offset: 0x98
	public IntPtr customCullingResult; //Field offset: 0x9C

}

