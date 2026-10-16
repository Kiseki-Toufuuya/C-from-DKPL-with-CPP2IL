namespace Coffee.UIEffects;

public class MaterialCache
{
	private class MaterialEntry
	{
		public Material material; //Field offset: 0x8
		public int referenceCount; //Field offset: 0xC

		public MaterialEntry() { }

		public void Release() { }

	}

	private static Dictionary<Hash128, MaterialEntry> materialMap; //Field offset: 0x0

	private static MaterialCache() { }

	public MaterialCache() { }

	public static Material Register(Material baseMaterial, Hash128 hash, Action<Material, Graphic> onModifyMaterial, Graphic graphic) { }

	public static void Unregister(Hash128 hash) { }

}

