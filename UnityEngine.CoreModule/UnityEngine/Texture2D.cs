namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	public int activeMipmapLimit
	{
		[NativeName("GetMipmapLimit")]
		 get { } //Length: 98
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D blackTexture
	{
		 get { } //Length: 74
	}

	public int calculatedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int desiredMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		 get { } //Length: 98
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D grayTexture
	{
		 get { } //Length: 74
	}

	public bool ignoreMipmapLimit
	{
		 get { } //Length: 98
		 set { } //Length: 149
	}

	internal bool isPreProcessed
	{
		internal get { } //Length: 98
	}

	public virtual bool isReadable
	{
		 get { } //Length: 98
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D linearGrayTexture
	{
		 get { } //Length: 74
	}

	internal bool loadAllMips
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
		internal get { } //Length: 98
		[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
		internal set { } //Length: 101
	}

	public int loadedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int loadingMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int minimumMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
		[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 101
	}

	public string mipmapLimitGroup
	{
		[NativeName("GetMipmapLimitGroupName")]
		 get { } //Length: 279
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D normalTexture
	{
		 get { } //Length: 74
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D redTexture
	{
		 get { } //Length: 74
	}

	public int requestedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 98
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 101
	}

	public bool streamingMipmaps
	{
		 get { } //Length: 98
	}

	public int streamingMipmapsPriority
	{
		 get { } //Length: 98
	}

	[NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
	[NativeName("VTOnly")]
	public bool vtOnly
	{
		 get { } //Length: 98
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D whiteTexture
	{
		 get { } //Length: 74
	}

	public Texture2D(int width, int height) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[ExcludeFromDocs]
	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	[ExcludeFromDocs]
	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
	public void ClearMinimumMipmapLevel() { }

	private static void ClearMinimumMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	public void ClearRequestedMipmapLevel() { }

	private static void ClearRequestedMipmapLevel_Injected(IntPtr _unity_self) { }

	public void Compress(bool highQuality) { }

	private static void Compress_Injected(IntPtr _unity_self, bool highQuality) { }

	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	public void CopyPixels(Texture src) { }

	public void CopyPixels(Texture src, int srcElement, int srcMip, int dstMip) { }

	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Full(Texture src) { }

	private static void CopyPixels_Full_Injected(IntPtr _unity_self, IntPtr src) { }

	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	private static void CopyPixels_Region_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstMip) { }

	private static void CopyPixels_Slice_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int dstMip) { }

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	[FreeFunction("Texture2DScripting::GenerateAtlas")]
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, out Rect[] rect) { }

	private static void GenerateAtlasImpl_Injected(ref ManagedSpanWrapper sizes, int padding, int atlasSize, out BlittableArrayWrapper rect) { }

	[NativeName("GetMipmapLimit")]
	public int get_activeMipmapLimit() { }

	private static int get_activeMipmapLimit_Injected(IntPtr _unity_self) { }

	public static Texture2D get_blackTexture() { }

	private static IntPtr get_blackTexture_Injected() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
	public int get_calculatedMipmapLevel() { }

	private static int get_calculatedMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	public int get_desiredMipmapLevel() { }

	private static int get_desiredMipmapLevel_Injected(IntPtr _unity_self) { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	public static Texture2D get_grayTexture() { }

	private static IntPtr get_grayTexture_Injected() { }

	public bool get_ignoreMipmapLimit() { }

	internal bool get_isPreProcessed() { }

	private static bool get_isPreProcessed_Injected(IntPtr _unity_self) { }

	public virtual bool get_isReadable() { }

	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	public static Texture2D get_linearGrayTexture() { }

	private static IntPtr get_linearGrayTexture_Injected() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	internal bool get_loadAllMips() { }

	private static bool get_loadAllMips_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	public int get_loadedMipmapLevel() { }

	private static int get_loadedMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	public int get_loadingMipmapLevel() { }

	private static int get_loadingMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
	public int get_minimumMipmapLevel() { }

	private static int get_minimumMipmapLevel_Injected(IntPtr _unity_self) { }

	[NativeName("GetMipmapLimitGroupName")]
	public string get_mipmapLimitGroup() { }

	private static void get_mipmapLimitGroup_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public static Texture2D get_normalTexture() { }

	private static IntPtr get_normalTexture_Injected() { }

	public static Texture2D get_redTexture() { }

	private static IntPtr get_redTexture_Injected() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	public int get_requestedMipmapLevel() { }

	private static int get_requestedMipmapLevel_Injected(IntPtr _unity_self) { }

	public bool get_streamingMipmaps() { }

	private static bool get_streamingMipmaps_Injected(IntPtr _unity_self) { }

	public int get_streamingMipmapsPriority() { }

	private static int get_streamingMipmapsPriority_Injected(IntPtr _unity_self) { }

	public bool get_vtOnly() { }

	private static bool get_vtOnly_Injected(IntPtr _unity_self) { }

	public static Texture2D get_whiteTexture() { }

	private static IntPtr get_whiteTexture_Injected() { }

	private ulong GetImageDataSize() { }

	private static ulong GetImageDataSize_Injected(IntPtr _unity_self) { }

	[ExcludeFromDocs]
	public Color GetPixel(int x, int y) { }

	public Color GetPixel(int x, int y, int mipLevel) { }

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v) { }

	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret) { }

	public NativeArray<T> GetPixelData(int mipLevel) { }

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	private static void GetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, out Color ret) { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[ExcludeFromDocs]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[ExcludeFromDocs]
	public Color[] GetPixels() { }

	public Color[] GetPixels(int miplevel) { }

	private static Color[] GetPixels_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	public Color32[] GetPixels32() { }

	private static Color32[] GetPixels32_Injected(IntPtr _unity_self, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	public Byte[] GetRawTextureData() { }

	public NativeArray<T> GetRawTextureData() { }

	private static Byte[] GetRawTextureData_Injected(IntPtr _unity_self) { }

	private IntPtr GetWritableImageData(int frame) { }

	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	private bool IgnoreMipmapLimit() { }

	private static bool IgnoreMipmapLimit_Injected(IntPtr _unity_self) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[FreeFunction("Texture2DScripting::CreateEmpty")]
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	public bool IsRequestedMipmapLevelLoaded() { }

	private static bool IsRequestedMipmapLevelLoaded_Injected(IntPtr _unity_self) { }

	public void LoadRawTextureData(NativeArray<T> data) { }

	public void LoadRawTextureData(Byte[] data) { }

	public void LoadRawTextureData(IntPtr data, int size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	private static bool LoadRawTextureDataImpl_Injected(IntPtr _unity_self, IntPtr data, ulong size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	private bool LoadRawTextureDataImplArray(Byte[] data) { }

	private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data) { }

	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	private static Rect[] PackTextures_Injected(IntPtr _unity_self, Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private static void ReadPixelsImpl_Injected(IntPtr _unity_self, in Rect source, int destX, int destY, bool recalculateMipMaps) { }

	public bool Reinitialize(int width, int height) { }

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height) { }

	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = True)]
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	private static bool ReinitializeWithFormatImpl_Injected(IntPtr _unity_self, int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
	public bool Resize(int width, int height) { }

	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", False)]
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	public void set_ignoreMipmapLimit(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	internal void set_loadAllMips(bool value) { }

	private static void set_loadAllMips_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
	public void set_minimumMipmapLevel(int value) { }

	private static void set_minimumMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	public void set_requestedMipmapLevel(int value) { }

	private static void set_requestedMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	private static void SetBlockOfPixels32_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, ref ManagedSpanWrapper colors, int miplevel) { }

	private void SetIgnoreMipmapLimitAndReload(bool value) { }

	private static void SetIgnoreMipmapLimitAndReload_Injected(IntPtr _unity_self, bool value) { }

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color) { }

	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	public void SetPixelData(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	private static bool SetPixelDataImpl_Injected(IntPtr _unity_self, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	private static bool SetPixelDataImplArray_Injected(IntPtr _unity_self, Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame) { }

	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	private static void UpdateExternalTexture_Injected(IntPtr _unity_self, IntPtr nativeTex) { }

	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

