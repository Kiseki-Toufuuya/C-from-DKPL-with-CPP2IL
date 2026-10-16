namespace XeSys.Gfx;

public class ImageEx : Image, IAlphaTexture
{
	[SerializeField]
	private Texture m_AlphaTexture; //Field offset: 0xB4
	[SerializeField]
	private Material m_MaterialMul; //Field offset: 0xB8
	[SerializeField]
	private Material m_MaterialAdd; //Field offset: 0xBC
	[SerializeField]
	private string m_TextureName; //Field offset: 0xC0
	[SerializeField]
	private string m_SliceName; //Field offset: 0xC4

	public override Texture alphaTexture
	{
		 get { } //Length: 14
		 set { } //Length: 110
	}

	public override Material MaterialAdd
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public override Material MaterialMul
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public override string SliceName
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public override string TextureName
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public ImageEx() { }

	public override Texture get_alphaTexture() { }

	public override Material get_MaterialAdd() { }

	public override Material get_MaterialMul() { }

	public override string get_SliceName() { }

	public override string get_TextureName() { }

	public override bool IsUseAlphaTexture() { }

	protected virtual void OnDestroy() { }

	public override void set_alphaTexture(Texture value) { }

	public override void set_MaterialAdd(Material value) { }

	public override void set_MaterialMul(Material value) { }

	public override void set_SliceName(string value) { }

	public override void set_TextureName(string value) { }

	public override void SetRect(TexUVData uvData) { }

	public override void SetTexture(Texture tex) { }

	public override void UnloadAsset() { }

}

