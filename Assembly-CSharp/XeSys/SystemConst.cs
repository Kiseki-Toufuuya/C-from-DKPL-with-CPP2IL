namespace XeSys;

public static class SystemConst
{
	internal enum Country
	{
		Unknown = 0,
		Japan = 1,
		UnitedStates = 2,
		UnitedKingdom = 3,
		France = 4,
		Germany = 5,
		Italy = 6,
		Spain = 7,
		Netherland = 8,
		China = 9,
		Taiwan = 10,
		Korea = 11,
	}

	internal static class DebugGroup
	{
		public static string System; //Field offset: 0x0
		public static string Scene; //Field offset: 0x4
		public static string Net; //Field offset: 0x8
		public static string Gfx; //Field offset: 0xC

		private static DebugGroup() { }

	}

	internal enum FileFromType
	{
		Server = 0,
		Storage = 1,
		StreamingAsset = 2,
	}

	internal enum Language
	{
		Unknown = 0,
		Japanese = 1,
		English = 2,
		English_UK = 3,
		French = 4,
		German = 5,
		Italian = 6,
		Spanish = 7,
		Netherlandic = 8,
		Chinese_zh_Hant = 9,
		Chinese_zh_Hans = 10,
		Korean = 11,
		Chinese_Traditional = 9,
		Chinese_Simplified = 10,
	}

	internal static class Layer
	{
		public const int Default = 0; //Field offset: 0x0
		public const int TransparentFx = 1; //Field offset: 0x0
		public const int IgnoreRaycast = 2; //Field offset: 0x0
		public const int Water = 4; //Field offset: 0x0
		public const int UI = 5; //Field offset: 0x0
		public const int UserDebug = 31; //Field offset: 0x0

	}

	internal static class LayerMask
	{
		public const int Default = 1; //Field offset: 0x0
		public const int TransparentFx = 2; //Field offset: 0x0
		public const int IgnoreRaycast = 4; //Field offset: 0x0
		public const int Water = 16; //Field offset: 0x0
		public const int UI = 32; //Field offset: 0x0
		public const int UserDebug = -2147483648; //Field offset: 0x0

	}

	internal static class RenderQueue
	{
		public const int Background = 1000; //Field offset: 0x0
		public const int Geometry = 2000; //Field offset: 0x0
		public const int AlphaTest = 2450; //Field offset: 0x0
		public const int Transparent = 3000; //Field offset: 0x0
		public const int Overlay = 4000; //Field offset: 0x0

	}


}

