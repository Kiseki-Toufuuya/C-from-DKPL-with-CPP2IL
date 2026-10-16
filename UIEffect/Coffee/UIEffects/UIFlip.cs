namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIFlip", 102)]
[DisallowMultipleComponent]
public class UIFlip : BaseMeshEffect
{
	[SerializeField]
	[Tooltip("Flip horizontally.")]
	private bool m_Horizontal; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Flip vertically.")]
	private bool m_Veritical; //Field offset: 0x21

	public bool horizontal
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public bool vertical
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public UIFlip() { }

	public bool get_horizontal() { }

	public bool get_vertical() { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	public void set_horizontal(bool value) { }

	public void set_vertical(bool value) { }

}

