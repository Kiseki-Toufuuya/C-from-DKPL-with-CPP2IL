namespace UnityEngine.Rendering;

public struct BatchCullingOutputDrawCommands
{
	public BatchDrawCommand* drawCommands; //Field offset: 0x0
	public BatchDrawCommandIndirect* indirectDrawCommands; //Field offset: 0x4
	public BatchDrawCommandProcedural* proceduralDrawCommands; //Field offset: 0x8
	public BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands; //Field offset: 0xC
	public Int32* visibleInstances; //Field offset: 0x10
	public BatchDrawRange* drawRanges; //Field offset: 0x14
	public Single* instanceSortingPositions; //Field offset: 0x18
	public Int32* drawCommandPickingInstanceIDs; //Field offset: 0x1C
	public int drawCommandCount; //Field offset: 0x20
	public int indirectDrawCommandCount; //Field offset: 0x24
	public int proceduralDrawCommandCount; //Field offset: 0x28
	public int proceduralIndirectDrawCommandCount; //Field offset: 0x2C
	public int visibleInstanceCount; //Field offset: 0x30
	public int drawRangeCount; //Field offset: 0x34
	public int instanceSortingPositionFloatCount; //Field offset: 0x38

}

