namespace UnityEngine.UIElements.UIR;

internal struct SerializedCommand
{
	public SerializedCommandType type; //Field offset: 0x0
	public IntPtr vertexBuffer; //Field offset: 0x4
	public IntPtr indexBuffer; //Field offset: 0x8
	public int firstRange; //Field offset: 0xC
	public int rangeCount; //Field offset: 0x10
	public int textureName; //Field offset: 0x14
	public Texture texture; //Field offset: 0x18
	public int gpuDataOffset; //Field offset: 0x1C
	public Vector4 gpuData0; //Field offset: 0x20
	public Vector4 gpuData1; //Field offset: 0x30

}

