namespace TMPro;

public struct MaterialReference
{
	public int index; //Field offset: 0x0
	public TMP_FontAsset fontAsset; //Field offset: 0x4
	public TMP_SpriteAsset spriteAsset; //Field offset: 0x8
	public Material material; //Field offset: 0xC
	public bool isDefaultMaterial; //Field offset: 0x10
	public bool isFallbackMaterial; //Field offset: 0x11
	public Material fallbackMaterial; //Field offset: 0x14
	public float padding; //Field offset: 0x18
	public int referenceCount; //Field offset: 0x1C

	public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

}

