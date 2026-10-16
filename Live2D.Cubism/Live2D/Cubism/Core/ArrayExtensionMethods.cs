namespace Live2D.Cubism.Core;

[Extension]
public static class ArrayExtensionMethods
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<CubismParameter> <>9__1_0; //Field offset: 0x4
		public static Comparison<CubismPart> <>9__5_0; //Field offset: 0x8
		public static Comparison<CubismDrawable> <>9__8_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal int <Revive>b__1_0(CubismParameter a, CubismParameter b) { }

		internal int <Revive>b__5_0(CubismPart a, CubismPart b) { }

		internal int <Revive>b__8_0(CubismDrawable a, CubismDrawable b) { }

	}


	[Extension]
	public static CubismParameter FindById(CubismParameter[] self, string id) { }

	[Extension]
	public static CubismPart FindById(CubismPart[] self, string id) { }

	[Extension]
	public static CubismDrawable FindById(CubismDrawable[] self, string id) { }

	[Extension]
	internal static void ReadFrom(CubismParameter[] self, CubismUnmanagedModel unmanagedModel) { }

	[Extension]
	internal static void ReadFrom(CubismDynamicDrawableData[] self, CubismUnmanagedModel unmanagedModel) { }

	[Extension]
	internal static void Revive(CubismParameter[] self, CubismUnmanagedModel model) { }

	[Extension]
	internal static void Revive(CubismPart[] self, CubismUnmanagedModel model) { }

	[Extension]
	internal static void Revive(CubismDrawable[] self, CubismUnmanagedModel model) { }

	[Extension]
	internal static void WriteTo(CubismParameter[] self, CubismUnmanagedModel unmanagedModel) { }

	[Extension]
	internal static void WriteTo(CubismPart[] self, CubismUnmanagedModel unmanagedModel) { }

}

