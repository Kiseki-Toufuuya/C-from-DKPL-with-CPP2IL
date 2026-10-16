namespace UnityEngine.TextCore.Text;

internal struct MaterialReference
{
	public int index; //Field offset: 0x0
	public FontAsset fontAsset; //Field offset: 0x4
	public SpriteAsset spriteAsset; //Field offset: 0x8
	public Material material; //Field offset: 0xC
	public bool isFallbackMaterial; //Field offset: 0x10
	public Material fallbackMaterial; //Field offset: 0x14
	public float padding; //Field offset: 0x18
	public int referenceCount; //Field offset: 0x1C

	public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<Int32, Int32> materialReferenceIndexLookup) { }

}

