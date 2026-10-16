namespace XeSys.Gfx;

public class RegistPolygonLineData
{
	public const int MaxLength = 500; //Field offset: 0x0
	public bool isMaterialExist; //Field offset: 0x8
	public Material Material; //Field offset: 0xC
	public int Length; //Field offset: 0x10
	public Vector3[] Position; //Field offset: 0x14
	public Single[] Size; //Field offset: 0x18
	public Vector3[] Normal; //Field offset: 0x1C
	public Vector2[] StartUVL; //Field offset: 0x20
	public Vector2[] StartUVR; //Field offset: 0x24
	public Vector2[] EndUVL; //Field offset: 0x28
	public Vector2[] EndUVR; //Field offset: 0x2C
	public Color32[] color; //Field offset: 0x30

	public RegistPolygonLineData() { }

}

