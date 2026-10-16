namespace Live2D.Cubism.Core.Unmanaged;

public static class CubismCoreDll
{
	public const string DllName = "Live2DCubismCore"; //Field offset: 0x0
	public const byte RenderOrderDidChange = 16; //Field offset: 0x0
	public const byte DrawOrderDidChange = 8; //Field offset: 0x0
	public const byte OpacityDidChange = 4; //Field offset: 0x0
	public const byte VisibilityDidChange = 2; //Field offset: 0x0
	public const byte IsVisible = 1; //Field offset: 0x0
	public const byte IsInvertedMask = 8; //Field offset: 0x0
	public const byte IsDoubleSided = 4; //Field offset: 0x0
	public const byte BlendMultiplicative = 2; //Field offset: 0x0
	public const byte BlendAdditive = 1; //Field offset: 0x0
	public const int ParameterType_BlendShape = 1; //Field offset: 0x0
	public const int ParameterType_Normal = 0; //Field offset: 0x0
	public const int MocVersion_50 = 5; //Field offset: 0x0
	public const int MocVersion_42 = 4; //Field offset: 0x0
	public const int MocVersion_40 = 3; //Field offset: 0x0
	public const int MocVersion_33 = 2; //Field offset: 0x0
	public const int MocVersion_30 = 1; //Field offset: 0x0
	public const int MocVersion_Unknown = 0; //Field offset: 0x0
	public const int AlignofModel = 16; //Field offset: 0x0
	public const int AlignofMoc = 64; //Field offset: 0x0
	public const byte VertexPositionsDidChange = 32; //Field offset: 0x0
	public const byte BlendColorDidChange = 64; //Field offset: 0x0

	public static Byte* GetDrawableConstantFlags(IntPtr model) { }

	public static int GetDrawableCount(IntPtr model) { }

	public static Int32* GetDrawableDrawOrders(IntPtr model) { }

	public static Byte* GetDrawableDynamicFlags(IntPtr model) { }

	public static Char** GetDrawableIds(IntPtr model) { }

	public static Int32* GetDrawableIndexCounts(IntPtr model) { }

	public static UInt16** GetDrawableIndices(IntPtr model) { }

	public static Int32* GetDrawableMaskCounts(IntPtr model) { }

	public static Int32** GetDrawableMasks(IntPtr model) { }

	public static Single* GetDrawableMultiplyColors(IntPtr model) { }

	public static Single* GetDrawableOpacities(IntPtr model) { }

	public static Int32* GetDrawableParentPartIndices(IntPtr model) { }

	public static Int32* GetDrawableRenderOrders(IntPtr model) { }

	public static Single* GetDrawableScreenColors(IntPtr model) { }

	public static Int32* GetDrawableTextureIndices(IntPtr model) { }

	public static Int32* GetDrawableVertexCounts(IntPtr model) { }

	public static Single** GetDrawableVertexPositions(IntPtr model) { }

	public static Single** GetDrawableVertexUvs(IntPtr model) { }

	public static uint GetLatestMocVersion() { }

	public static IntPtr GetLogFunction() { }

	public static uint GetMocVersion(IntPtr moc, uint mocSize) { }

	public static int GetParameterCount(IntPtr model) { }

	public static Single* GetParameterDefaultValues(IntPtr model) { }

	public static Char** GetParameterIds(IntPtr model) { }

	public static Int32* GetParameterKeyCounts(IntPtr model) { }

	public static Single** GetParameterKeyValues(IntPtr model) { }

	public static Single* GetParameterMaximumValues(IntPtr model) { }

	public static Single* GetParameterMinimumValues(IntPtr model) { }

	public static Int32* GetParameterRepeats(IntPtr model) { }

	public static Int32* GetParameterTypes(IntPtr model) { }

	public static Single* GetParameterValues(IntPtr model) { }

	public static int GetPartCount(IntPtr model) { }

	public static Char** GetPartIds(IntPtr model) { }

	public static Single* GetPartOpacities(IntPtr model) { }

	public static Int32* GetPartParentPartIndices(IntPtr model) { }

	public static uint GetSizeofModel(IntPtr moc) { }

	public static uint GetVersion() { }

	public static int HasMocConsistency(IntPtr memory, uint mocSize) { }

	public static IntPtr InitializeModelInPlace(IntPtr moc, IntPtr memory, uint modelSize) { }

	public static void ReadCanvasInfo(IntPtr model, IntPtr outSizeInPixels, IntPtr outOriginInPixels, IntPtr outPixelsPerUnit) { }

	public static void ResetDrawableDynamicFlags(IntPtr model) { }

	public static IntPtr ReviveMocInPlace(IntPtr memory, uint mocSize) { }

	public static void SetLogFunction(IntPtr handler) { }

	public static void UpdateModel(IntPtr model) { }

}

