namespace UnityEngine.UIElements;

internal static class DragAndDropUtility
{
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; //Field offset: 0x0
	private static IDragAndDrop s_DragAndDropEditor; //Field offset: 0x4
	private static IDragAndDrop s_DragAndDropPlayMode; //Field offset: 0x8

	internal static IDragAndDrop GetDragAndDrop(IPanel panel) { }

}

