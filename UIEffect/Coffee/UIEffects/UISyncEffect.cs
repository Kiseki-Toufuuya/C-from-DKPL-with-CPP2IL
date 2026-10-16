namespace Coffee.UIEffects;

[ExecuteInEditMode]
public class UISyncEffect : BaseMaterialEffect
{
	[SerializeField]
	[Tooltip("The target effect to synchronize.")]
	private BaseMeshEffect m_TargetEffect; //Field offset: 0x38

	public BaseMeshEffect targetEffect
	{
		 get { } //Length: 89
		 set { } //Length: 143
	}

	public UISyncEffect() { }

	public BaseMeshEffect get_targetEffect() { }

	public virtual Hash128 GetMaterialHash(Material baseMaterial) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_targetEffect(BaseMeshEffect value) { }

}

