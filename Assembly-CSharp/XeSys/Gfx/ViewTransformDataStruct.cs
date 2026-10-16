namespace XeSys.Gfx;

public struct ViewTransformDataStruct
{
	public Vector2 Pos; //Field offset: 0x0
	public Vector2 Move; //Field offset: 0x8
	public Vector2 Size; //Field offset: 0x10
	public Vector2 Scale; //Field offset: 0x18
	public float Rot; //Field offset: 0x20
	public Color Color; //Field offset: 0x24
	public Vector2 Center; //Field offset: 0x34

	public ViewTransformDataStruct(float f) { }

}

