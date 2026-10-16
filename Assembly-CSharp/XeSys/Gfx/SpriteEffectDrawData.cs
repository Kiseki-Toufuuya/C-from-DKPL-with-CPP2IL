namespace XeSys.Gfx;

public class SpriteEffectDrawData : IDynammicPolygonSpriteDataMatrix, IDynammicPolygonSpriteDataMatrixIndividual
{
	private ImageView m_ImageView; //Field offset: 0x8
	private Matrix4x4 m_Mtx; //Field offset: 0xC
	private bool m_IsChgMatrerial; //Field offset: 0x4C
	private Material m_Material; //Field offset: 0x50

	public ImageView ImageView
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool IsChgMatrerial
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Material Material
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Matrix4x4 Mtx
	{
		 get { } //Length: 42
		 set { } //Length: 40
	}

	public SpriteEffectDrawData() { }

	public ImageView get_ImageView() { }

	public bool get_IsChgMatrerial() { }

	public Material get_Material() { }

	public Matrix4x4 get_Mtx() { }

	public override void GetRegistData(ref bool IsDraw, ref bool isMaterialExist, ref Material material, ref Matrix4x4 matrix, ref float Sizex, ref float Sizey, ref float UVx, ref float UVy, ref float UVSizex, ref float UVSizey, ref byte colora, ref byte colorr, ref byte colorg, ref byte colorb) { }

	public override void GetRegistData(ref bool IsDraw, ref bool isMaterialExist, ref Material material, ref float m00, ref float m01, ref float m02, ref float m03, ref float m10, ref float m11, ref float m12, ref float m13, ref float m20, ref float m21, ref float m22, ref float m23, ref float Sizex, ref float Sizey, ref float UVx, ref float UVy, ref float UVSizex, ref float UVSizey, ref byte colora, ref byte colorr, ref byte colorg, ref byte colorb) { }

	public void set_ImageView(ImageView value) { }

	public void set_IsChgMatrerial(bool value) { }

	public void set_Material(Material value) { }

	public void set_Mtx(Matrix4x4 value) { }

}

