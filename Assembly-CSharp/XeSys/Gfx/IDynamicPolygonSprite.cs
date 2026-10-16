namespace XeSys.Gfx;

public interface IDynamicPolygonSprite
{

	public void GetColor(ref Color32 col) { }

	public Material GetMaterial() { }

	public void GetMatrix(ref Matrix4x4 matrix) { }

	public void GetPos(ref Vector3 pos) { }

	public Sprite GetSprite() { }

}

