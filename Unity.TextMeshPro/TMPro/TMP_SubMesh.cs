namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(MeshRenderer))]
public class TMP_SubMesh : MonoBehaviour
{
	[SerializeField]
	private TMP_FontAsset m_fontAsset; //Field offset: 0x10
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0x14
	[SerializeField]
	private Material m_material; //Field offset: 0x18
	[SerializeField]
	private Material m_sharedMaterial; //Field offset: 0x1C
	private Material m_fallbackMaterial; //Field offset: 0x20
	private Material m_fallbackSourceMaterial; //Field offset: 0x24
	[SerializeField]
	private bool m_isDefaultMaterial; //Field offset: 0x28
	[SerializeField]
	private float m_padding; //Field offset: 0x2C
	[SerializeField]
	private Renderer m_renderer; //Field offset: 0x30
	private MeshFilter m_meshFilter; //Field offset: 0x34
	private Mesh m_mesh; //Field offset: 0x38
	[SerializeField]
	private TextMeshPro m_TextComponent; //Field offset: 0x3C
	private bool m_isRegisteredForEvents; //Field offset: 0x40

	public Material fallbackMaterial
	{
		 get { } //Length: 11
		 set { } //Length: 297
	}

	public Material fallbackSourceMaterial
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TMP_FontAsset fontAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool isDefaultMaterial
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Material material
	{
		 get { } //Length: 22
		 set { } //Length: 109
	}

	public Mesh mesh
	{
		 get { } //Length: 156
		 set { } //Length: 27
	}

	public MeshFilter meshFilter
	{
		 get { } //Length: 244
	}

	public float padding
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public Renderer renderer
	{
		 get { } //Length: 122
	}

	public Material sharedMaterial
	{
		 get { } //Length: 11
		 set { } //Length: 48
	}

	public TMP_SpriteAsset spriteAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TMP_Text textComponent
	{
		 get { } //Length: 122
	}

	public TMP_SubMesh() { }

	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	private Material CreateMaterialInstance(Material source) { }

	public void DestroySelf() { }

	public Material get_fallbackMaterial() { }

	public Material get_fallbackSourceMaterial() { }

	public TMP_FontAsset get_fontAsset() { }

	public bool get_isDefaultMaterial() { }

	public Material get_material() { }

	public Mesh get_mesh() { }

	public MeshFilter get_meshFilter() { }

	public float get_padding() { }

	public Renderer get_renderer() { }

	public Material get_sharedMaterial() { }

	public TMP_SpriteAsset get_spriteAsset() { }

	public TMP_Text get_textComponent() { }

	private Material GetMaterial(Material mat) { }

	public float GetPaddingForMaterial() { }

	private Material GetSharedMaterial() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void set_fallbackMaterial(Material value) { }

	public void set_fallbackSourceMaterial(Material value) { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public void set_isDefaultMaterial(bool value) { }

	public void set_material(Material value) { }

	public void set_mesh(Mesh value) { }

	public void set_padding(float value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_spriteAsset(TMP_SpriteAsset value) { }

	public void SetMaterialDirty() { }

	private void SetSharedMaterial(Material mat) { }

	public void SetVerticesDirty() { }

	protected void UpdateMaterial() { }

	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

