namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display
{
	internal sealed class DisplaysUpdatedDelegate : MulticastDelegate
	{

		public DisplaysUpdatedDelegate(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	public static Display[] displays; //Field offset: 0x0
	private static Display _mainDisplay; //Field offset: 0x4
	private static int m_ActiveEditorGameViewTarget; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static DisplaysUpdatedDelegate onDisplaysUpdated; //Field offset: 0xC
	internal IntPtr nativeDisplay; //Field offset: 0x8

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 127
	}

	public static Display main
	{
		 get { } //Length: 61
	}

	public int renderingHeight
	{
		 get { } //Length: 125
	}

	public int renderingWidth
	{
		 get { } //Length: 125
	}

	public int systemHeight
	{
		 get { } //Length: 125
	}

	public int systemWidth
	{
		 get { } //Length: 125
	}

	private static Display() { }

	internal Display() { }

	internal Display(IntPtr nativeDisplay) { }

	[RequiredByNativeCode]
	internal static void FireDisplaysUpdated() { }

	public RenderBuffer get_colorBuffer() { }

	public static Display get_main() { }

	public int get_renderingHeight() { }

	public int get_renderingWidth() { }

	public int get_systemHeight() { }

	public int get_systemWidth() { }

	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[RequiredByNativeCode]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

}

