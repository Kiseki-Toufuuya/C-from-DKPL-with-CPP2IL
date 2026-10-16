namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextLib.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextLib
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(TextLib textLib) { }

	}

	public static Func<TextAsset> GetICUAssetEditorDelegate; //Field offset: 0x0
	private readonly IntPtr m_Ptr; //Field offset: 0x8

	public TextLib(Byte[] icuData) { }

	[NativeMethod(Name = "TextLib::FindIntersectingLink")]
	public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo) { }

	private static int FindIntersectingLink_Injected(in Vector2 point, IntPtr textGenerationInfo) { }

	public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[NativeMethod(Name = "TextLib::GenerateTextMesh", IsThreadSafe = True)]
	private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	private static void GenerateTextInternal_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out NativeTextInfo ret) { }

	private static IntPtr GetInstance(Byte[] icuData) { }

	private static IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData) { }

	[NativeMethod(Name = "TextLib::MeasureText")]
	public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	private static void MeasureText_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out Vector2 ret) { }

	public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings) { }

}

