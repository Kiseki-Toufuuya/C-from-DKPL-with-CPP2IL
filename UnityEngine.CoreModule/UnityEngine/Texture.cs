namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[UsedByNativeCode]
public class Texture : object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	internal ColorSpace activeTextureColorSpace
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
		internal get { } //Length: 133
	}

	public int anisoLevel
	{
		 set { } //Length: 131
	}

	public override TextureDimension dimension
	{
		 get { } //Length: 128
		 set { } //Length: 47
	}

	public FilterMode filterMode
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	public override int height
	{
		 get { } //Length: 128
		 set { } //Length: 47
	}

	public override bool isReadable
	{
		 get { } //Length: 128
	}

	public int mipmapCount
	{
		[NativeName("GetMipmapCount")]
		 get { } //Length: 128
	}

	public Vector2 texelSize
	{
		[NativeName("GetTexelSize")]
		 get { } //Length: 151
	}

	public override int width
	{
		 get { } //Length: 128
		 set { } //Length: 47
	}

	public TextureWrapMode wrapMode
	{
		[NativeName("GetWrapModeU")]
		 get { } //Length: 128
		 set { } //Length: 2603
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNativeArrayLengthOverflowException() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
	internal ColorSpace get_activeTextureColorSpace() { }

	public override TextureDimension get_dimension() { }

	public FilterMode get_filterMode() { }

	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	public override int get_height() { }

	public override bool get_isReadable() { }

	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[NativeName("GetMipmapCount")]
	public int get_mipmapCount() { }

	private static int get_mipmapCount_Injected(IntPtr _unity_self) { }

	[NativeName("GetTexelSize")]
	public Vector2 get_texelSize() { }

	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public override int get_width() { }

	[NativeName("GetWrapModeU")]
	public TextureWrapMode get_wrapMode() { }

	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[ThreadSafe]
	private int GetDataHeight() { }

	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	[ThreadSafe]
	private int GetDataWidth() { }

	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	[ThreadSafe]
	private TextureDimension GetDimension() { }

	private static TextureDimension GetDimension_Injected(IntPtr _unity_self) { }

	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	private static ulong GetPixelDataOffset_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	private static ulong GetPixelDataSize_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	internal UnityException IgnoreMipmapLimitCannotBeToggledException(Texture t) { }

	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace() { }

	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }

	public void set_anisoLevel(int value) { }

	private static void set_anisoLevel_Injected(IntPtr _unity_self, int value) { }

	public override void set_dimension(TextureDimension value) { }

	public void set_filterMode(FilterMode value) { }

	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	public override void set_height(int value) { }

	public override void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

}

