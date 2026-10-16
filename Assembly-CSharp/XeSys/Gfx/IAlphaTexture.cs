namespace XeSys.Gfx;

public interface IAlphaTexture
{

	public Texture alphaTexture
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Color color
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Material material
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Material MaterialAdd
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Material MaterialMul
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool raycastTarget
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string SliceName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string TextureName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Texture get_alphaTexture() { }

	public Color get_color() { }

	public Material get_material() { }

	public Material get_MaterialAdd() { }

	public Material get_MaterialMul() { }

	public bool get_raycastTarget() { }

	public string get_SliceName() { }

	public string get_TextureName() { }

	public bool IsUseAlphaTexture() { }

	public void set_alphaTexture(Texture value) { }

	public void set_color(Color value) { }

	public void set_material(Material value) { }

	public void set_MaterialAdd(Material value) { }

	public void set_MaterialMul(Material value) { }

	public void set_raycastTarget(bool value) { }

	public void set_SliceName(string value) { }

	public void set_TextureName(string value) { }

	public void SetRect(TexUVData uvData) { }

	public void SetTexture(Texture tex) { }

	public void UnloadAsset() { }

}

