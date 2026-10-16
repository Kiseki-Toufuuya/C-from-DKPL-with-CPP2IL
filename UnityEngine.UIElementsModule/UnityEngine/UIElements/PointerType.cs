namespace UnityEngine.UIElements;

public static class PointerType
{
	public static readonly string mouse; //Field offset: 0x0
	public static readonly string touch; //Field offset: 0x4
	public static readonly string pen; //Field offset: 0x8
	public static readonly string unknown; //Field offset: 0xC

	private static PointerType() { }

	internal static string GetPointerType(int pointerId) { }

	internal static bool IsDirectManipulationDevice(string pointerType) { }

}

