namespace UnityEngine.UI;

[AddComponentMenu("UI/Raw Image", 12)]
[RequireComponent(typeof(CanvasRenderer))]
public class RawImage : MaskableGraphic
{
	[FormerlySerializedAs("m_Tex")]
	[SerializeField]
	private Texture m_Texture; //Field offset: 0x84
	[SerializeField]
	private Rect m_UVRect; //Field offset: 0x88

	public virtual Texture mainTexture
	{
		 get { } //Length: 401
	}

	public Texture texture
	{
		 get { } //Length: 14
		 set { } //Length: 144
	}

	public Rect uvRect
	{
		 get { } //Length: 21
		 set { } //Length: 110
	}

	protected RawImage() { }

	public virtual Texture get_mainTexture() { }

	public Texture get_texture() { }

	public Rect get_uvRect() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public void set_texture(Texture value) { }

	public void set_uvRect(Rect value) { }

	public virtual void SetNativeSize() { }

}

