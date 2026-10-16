namespace Coffee.UIEffects;

[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Graphic))]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	private RectTransform _rectTransform; //Field offset: 0x10
	private Graphic _graphic; //Field offset: 0x14
	private GraphicConnector _connector; //Field offset: 0x18
	internal readonly List<UISyncEffect> syncEffects; //Field offset: 0x1C

	protected GraphicConnector connector
	{
		 get { } //Length: 109
	}

	public Graphic graphic
	{
		 get { } //Length: 128
	}

	protected RectTransform rectTransform
	{
		 get { } //Length: 128
	}

	protected BaseMeshEffect() { }

	protected GraphicConnector get_connector() { }

	public Graphic get_graphic() { }

	protected RectTransform get_rectTransform() { }

	public override void ModifyMesh(Mesh mesh) { }

	public override void ModifyMesh(VertexHelper vh) { }

	public override void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected override void SetEffectParamsDirty() { }

	protected override void SetVerticesDirty() { }

}

