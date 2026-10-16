namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
public sealed class Cubemap : Texture
{

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

	internal bool isPreProcessed
	{
		internal get { } //Length: 98
	}

	public virtual bool isReadable
	{
		 get { } //Length: 98
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

	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = True)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	public void ClearRequestedMipmapLevel() { }

	private static void ClearRequestedMipmapLevel_Injected(IntPtr _unity_self) { }

	public void CopyPixels(Texture src, int srcElement, int srcMip, CubemapFace dstFace, int dstMip) { }

	public void CopyPixels(Texture src) { }

	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, CubemapFace dstFace, int dstMip, int dstX, int dstY) { }

	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Full(Texture src) { }

	private static void CopyPixels_Full_Injected(IntPtr _unity_self, IntPtr src) { }

	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY) { }

	private static void CopyPixels_Region_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY) { }

	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	private void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstFace, int dstMip) { }

	private static void CopyPixels_Slice_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int dstFace, int dstMip) { }

	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	public int get_desiredMipmapLevel() { }

	private static int get_desiredMipmapLevel_Injected(IntPtr _unity_self) { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	internal bool get_isPreProcessed() { }

	private static bool get_isPreProcessed_Injected(IntPtr _unity_self) { }

	public virtual bool get_isReadable() { }

	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	internal bool get_loadAllMips() { }

	private static bool get_loadAllMips_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	public int get_loadedMipmapLevel() { }

	private static int get_loadedMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	public int get_loadingMipmapLevel() { }

	private static int get_loadingMipmapLevel_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	public int get_requestedMipmapLevel() { }

	private static int get_requestedMipmapLevel_Injected(IntPtr _unity_self) { }

	public bool get_streamingMipmaps() { }

	private static bool get_streamingMipmaps_Injected(IntPtr _unity_self) { }

	public int get_streamingMipmapsPriority() { }

	private static int get_streamingMipmapsPriority_Injected(IntPtr _unity_self) { }

	public Color GetPixel(CubemapFace face, int x, int y, int mip) { }

	[ExcludeFromDocs]
	public Color GetPixel(CubemapFace face, int x, int y) { }

	public NativeArray<T> GetPixelData(int mipLevel, CubemapFace face) { }

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	private static void GetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, out Color ret) { }

	public Color[] GetPixels(CubemapFace face) { }

	[FreeFunction(Name = "CubemapScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	private static Color[] GetPixels_Injected(IntPtr _unity_self, CubemapFace face, int miplevel) { }

	private IntPtr GetWritableImageData(int frame) { }

	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("CubemapScripting::Create")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	public bool IsRequestedMipmapLevelLoaded() { }

	private static bool IsRequestedMipmapLevelLoaded_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	internal void set_loadAllMips(bool value) { }

	private static void set_loadAllMips_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	public void set_requestedMipmapLevel(int value) { }

	private static void set_requestedMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	public void SetPixel(CubemapFace face, int x, int y, Color color, int mip) { }

	[ExcludeFromDocs]
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	public void SetPixelData(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "CubemapScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	private static bool SetPixelDataImpl_Injected(IntPtr _unity_self, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[FreeFunction(Name = "CubemapScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	private static bool SetPixelDataImplArray_Injected(IntPtr _unity_self, Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	public void SetPixels(Color[] colors, CubemapFace face) { }

	[FreeFunction(Name = "CubemapScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int miplevel) { }

	[NativeName("FixupEdges")]
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	public void SmoothEdges() { }

	private static void SmoothEdges_Injected(IntPtr _unity_self, int smoothRegionWidthInPixels) { }

	[FreeFunction("CubemapScripting::UpdateExternalTexture", HasExplicitThis = True)]
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

	private static void UpdateExternalTexture_Injected(IntPtr _unity_self, IntPtr nativeTexture) { }

	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	internal bool ValidateFormat(TextureFormat format, int width) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

