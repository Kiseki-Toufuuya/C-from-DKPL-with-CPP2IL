//Type is in global namespace

public class ShearProgressBarSprite : Graphic
{
	[SerializeField]
	private Sprite sprite; //Field offset: 0x64
	public float Offset; //Field offset: 0x68
	[SerializeField]
	private float _amount; //Field offset: 0x6C

	public float Amount
	{
		 get { } //Length: 11
		 set { } //Length: 38
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 337
	}

	public Sprite Sprite
	{
		 get { } //Length: 11
		 set { } //Length: 46
	}

	public ShearProgressBarSprite() { }

	public float get_Amount() { }

	public virtual Texture get_mainTexture() { }

	public Sprite get_Sprite() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public void set_Amount(float value) { }

	public void set_Sprite(Sprite value) { }

}

