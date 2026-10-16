namespace Live2D.Cubism.Rendering.Masking;

public struct CubismMaskTile
{
	public float Channel; //Field offset: 0x0
	public float Column; //Field offset: 0x4
	public float Row; //Field offset: 0x8
	public float Size; //Field offset: 0xC
	public int RenderTextureIndex; //Field offset: 0x10
	public int HeadOfChannelsIndex; //Field offset: 0x14
	public int Index; //Field offset: 0x18

	public static Vector4 op_Implicit(CubismMaskTile value) { }

}

