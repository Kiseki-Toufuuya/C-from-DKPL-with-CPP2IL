namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
public sealed class GUIStyleState
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(GUIStyleState guiStyleState) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x8
	private readonly GUIStyle m_SourceStyle; //Field offset: 0xC

	[NativeProperty("textColor", False, TargetType::Field (1))]
	public Color textColor
	{
		 set { } //Length: 73
	}

	public GUIStyleState() { }

	private GUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	private static void Cleanup_Injected(IntPtr _unity_self) { }

	protected virtual void Finalize() { }

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	public void set_textColor(Color value) { }

	private static void set_textColor_Injected(IntPtr _unity_self, in Color value) { }

}

