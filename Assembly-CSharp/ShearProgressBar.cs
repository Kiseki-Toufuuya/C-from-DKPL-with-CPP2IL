//Type is in global namespace

public class ShearProgressBar : Graphic
{
	public Color TopColor; //Field offset: 0x64
	public Color BottomColor; //Field offset: 0x74
	public float Offset; //Field offset: 0x84
	[SerializeField]
	private float _amount; //Field offset: 0x88

	public float Amount
	{
		 get { } //Length: 14
		 set { } //Length: 41
	}

	public ShearProgressBar() { }

	public float get_Amount() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public void set_Amount(float value) { }

}

