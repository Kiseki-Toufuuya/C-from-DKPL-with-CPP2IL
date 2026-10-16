namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : object
{
	public enum CreateOptions
	{
		None = 0,
		CreateNativeObject = 1,
	}

	private static class EncodingUtility
	{
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		internal static readonly Encoding targetEncoding; //Field offset: 0x4

		private static EncodingUtility() { }

	}


	public Byte[] bytes
	{
		 get { } //Length: 98
	}

	public long dataSize
	{
		 get { } //Length: 98
	}

	public string text
	{
		 get { } //Length: 134
	}

	public TextAsset(ReadOnlySpan<Byte> bytes) { }

	internal TextAsset(CreateOptions options, ReadOnlySpan<Byte> bytes) { }

	internal TextAsset(CreateOptions options, string text) { }

	public TextAsset(string text) { }

	public TextAsset() { }

	internal static string DecodeString(Byte[] bytes) { }

	public Byte[] get_bytes() { }

	private static Byte[] get_bytes_Injected(IntPtr _unity_self) { }

	public long get_dataSize() { }

	public string get_text() { }

	public NativeArray<T> GetData() { }

	private IntPtr GetDataPtr() { }

	private static IntPtr GetDataPtr_Injected(IntPtr _unity_self) { }

	private long GetDataSize() { }

	private static long GetDataSize_Injected(IntPtr _unity_self) { }

	internal string GetPreview(int maxChars) { }

	private Byte[] GetPreviewBytes(int maxByteCount) { }

	private static Byte[] GetPreviewBytes_Injected(IntPtr _unity_self, int maxByteCount) { }

	private static void Internal_CreateInstance(TextAsset self, string text) { }

	private static void Internal_CreateInstance_Injected(TextAsset self, ref ManagedSpanWrapper text) { }

	private static void Internal_CreateInstanceFromBytes(TextAsset self, ReadOnlySpan<Byte> bytes) { }

	private static void Internal_CreateInstanceFromBytes_Injected(TextAsset self, ref ManagedSpanWrapper bytes) { }

	public virtual string ToString() { }

}

