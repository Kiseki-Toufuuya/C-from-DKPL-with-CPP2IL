namespace UnityEngine;

internal class IMGUITextHandle : TextHandle
{
	public class TextHandleTuple
	{
		public float lastTimeUsed; //Field offset: 0x8
		public int hashCode; //Field offset: 0xC

		public TextHandleTuple(float lastTimeUsed, int hashCode) { }

	}

	private static Dictionary<Int32, IMGUITextHandle> textHandles; //Field offset: 0x0
	private static LinkedList<TextHandleTuple> textHandlesTuple; //Field offset: 0x4
	private static float lastCleanupTime; //Field offset: 0x8
	private static int newHandlesSinceCleanup; //Field offset: 0xC
	internal LinkedListNode<TextHandleTuple> tuple; //Field offset: 0x88
	internal bool isCachedOnNative; //Field offset: 0x8C

	private static IMGUITextHandle() { }

	public IMGUITextHandle() { }

	private static void ClearUnusedTextHandles() { }

	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	internal static void EmptyManagedCache() { }

	internal static float GetLineHeight(GUIStyle style) { }

	internal Vector2 GetPreferredSize() { }

	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

}

