namespace UnityEngine.UI;

public static class StencilMaterial
{
	private class MatEntry
	{
		public Material baseMat; //Field offset: 0x8
		public Material customMat; //Field offset: 0xC
		public int count; //Field offset: 0x10
		public int stencilId; //Field offset: 0x14
		public StencilOp operation; //Field offset: 0x18
		public CompareFunction compareFunction; //Field offset: 0x1C
		public int readMask; //Field offset: 0x20
		public int writeMask; //Field offset: 0x24
		public bool useAlphaClip; //Field offset: 0x28
		public ColorWriteMask colorMask; //Field offset: 0x2C

		public MatEntry() { }

	}

	private static List<MatEntry> m_List; //Field offset: 0x0

	private static StencilMaterial() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use Material.Add instead.", True)]
	public static Material Add(Material baseMat, int stencilID) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	public static void ClearAll() { }

	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	public static void Remove(Material customMat) { }

}

