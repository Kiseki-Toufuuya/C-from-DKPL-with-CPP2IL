namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
	public static Byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[Extension]
	public static Byte[] EncodeToJPG(Texture2D tex) { }

	private static void EncodeToJPG_Injected(IntPtr tex, int quality, out BlittableArrayWrapper ret) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	public static Byte[] EncodeToPNG(Texture2D tex) { }

	private static void EncodeToPNG_Injected(IntPtr tex, out BlittableArrayWrapper ret) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = True, ThrowsException = True)]
	public static Byte[] EncodeToTGA(Texture2D tex) { }

	private static void EncodeToTGA_Injected(IntPtr tex, out BlittableArrayWrapper ret) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	public static bool LoadImage(Texture2D tex, ReadOnlySpan<Byte> data, bool markNonReadable) { }

	[Extension]
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

	[Extension]
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

	private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable) { }

}

