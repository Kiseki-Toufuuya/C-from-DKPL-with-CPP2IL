namespace UnityEngine.UIElements.UIR;

internal struct ConvertMeshJobData
{
	public IntPtr vertSrc; //Field offset: 0x0
	public IntPtr vertDst; //Field offset: 0x4
	public int vertCount; //Field offset: 0x8
	public Matrix4x4 transform; //Field offset: 0xC
	public Color32 xformClipPages; //Field offset: 0x4C
	public Color32 ids; //Field offset: 0x50
	public Color32 addFlags; //Field offset: 0x54
	public Color32 opacityPage; //Field offset: 0x58
	public Color32 textCoreSettingsPage; //Field offset: 0x5C
	public int usesTextCoreSettings; //Field offset: 0x60
	public float textureId; //Field offset: 0x64
	public int gradientSettingsIndexOffset; //Field offset: 0x68
	public IntPtr indexSrc; //Field offset: 0x6C
	public IntPtr indexDst; //Field offset: 0x70
	public int indexCount; //Field offset: 0x74
	public int indexOffset; //Field offset: 0x78
	public int flipIndices; //Field offset: 0x7C
	public int forceZ; //Field offset: 0x80
	public float positionZ; //Field offset: 0x84
	public int remapUVs; //Field offset: 0x88
	public Rect atlasRect; //Field offset: 0x8C

}

