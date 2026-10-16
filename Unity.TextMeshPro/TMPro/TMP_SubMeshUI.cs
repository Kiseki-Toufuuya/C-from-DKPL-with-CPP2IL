namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SubMeshUI : MaskableGraphic
{
	[SerializeField]
	private TMP_FontAsset m_fontAsset; //Field offset: 0x84
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0x88
	[SerializeField]
	private Material m_material; //Field offset: 0x8C
	[SerializeField]
	private Material m_sharedMaterial; //Field offset: 0x90
	private Material m_fallbackMaterial; //Field offset: 0x94
	private Material m_fallbackSourceMaterial; //Field offset: 0x98
	[SerializeField]
	private bool m_isDefaultMaterial; //Field offset: 0x9C
	[SerializeField]
	private float m_padding; //Field offset: 0xA0
	private Mesh m_mesh; //Field offset: 0xA4
	[SerializeField]
	private TextMeshProUGUI m_TextComponent; //Field offset: 0xA8
	private bool m_isRegisteredForEvents; //Field offset: 0xAC
	private bool m_materialDirty; //Field offset: 0xAD
	[SerializeField]
	private int m_materialReferenceIndex; //Field offset: 0xB0
	private Transform m_RootCanvasTransform; //Field offset: 0xB4

	public Material fallbackMaterial
	{
		 get { } //Length: 14
		 set { } //Length: 358
	}

	public Material fallbackSourceMaterial
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public TMP_FontAsset fontAsset
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public bool isDefaultMaterial
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 156
	}

	public virtual Material material
	{
		 get { } //Length: 386
		 set { } //Length: 225
	}

	public virtual Material materialForRendering
	{
		 get { } //Length: 79
	}

	public Mesh mesh
	{
		 get { } //Length: 171
		 set { } //Length: 33
	}

	public float padding
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public Material sharedMaterial
	{
		 get { } //Length: 14
		 set { } //Length: 85
	}

	public TMP_SpriteAsset spriteAsset
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public TMP_Text textComponent
	{
		 get { } //Length: 134
	}

	public TMP_SubMeshUI() { }

	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	private Material CreateMaterialInstance(Material source) { }

	public virtual void Cull(Rect clipRect, bool validRect) { }

	public Material get_fallbackMaterial() { }

	public Material get_fallbackSourceMaterial() { }

	public TMP_FontAsset get_fontAsset() { }

	public bool get_isDefaultMaterial() { }

	public virtual Texture get_mainTexture() { }

	public virtual Material get_material() { }

	public virtual Material get_materialForRendering() { }

	public Mesh get_mesh() { }

	public float get_padding() { }

	public Material get_sharedMaterial() { }

	public TMP_SpriteAsset get_spriteAsset() { }

	public TMP_Text get_textComponent() { }

	private Material GetMaterial(Material mat) { }

	private Material GetMaterial() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	public float GetPaddingForMaterial(Material mat) { }

	public float GetPaddingForMaterial() { }

	private Transform GetRootCanvasTransform() { }

	private Material GetSharedMaterial() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public virtual void RecalculateClipping() { }

	public void RefreshMaterial() { }

	public void set_fallbackMaterial(Material value) { }

	public void set_fallbackSourceMaterial(Material value) { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public void set_isDefaultMaterial(bool value) { }

	public virtual void set_material(Material value) { }

	public void set_mesh(Mesh value) { }

	public void set_padding(float value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_spriteAsset(TMP_SpriteAsset value) { }

	public virtual void SetAllDirty() { }

	public virtual void SetLayoutDirty() { }

	public virtual void SetMaterialDirty() { }

	public void SetPivotDirty() { }

	private void SetSharedMaterial(Material mat) { }

	public virtual void SetVerticesDirty() { }

	protected virtual void UpdateGeometry() { }

	protected virtual void UpdateMaterial() { }

	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

