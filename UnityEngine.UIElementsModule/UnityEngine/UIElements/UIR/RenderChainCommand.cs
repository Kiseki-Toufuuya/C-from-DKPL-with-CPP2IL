namespace UnityEngine.UIElements.UIR;

internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	private static readonly int k_ID_MainTex; //Field offset: 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; //Field offset: 0x4
	internal VisualElement owner; //Field offset: 0xC
	internal RenderChainCommand prev; //Field offset: 0x10
	internal RenderChainCommand next; //Field offset: 0x14
	internal bool isTail; //Field offset: 0x18
	internal CommandType type; //Field offset: 0x1C
	internal State state; //Field offset: 0x20
	internal MeshHandle mesh; //Field offset: 0x34
	internal int indexOffset; //Field offset: 0x38
	internal int indexCount; //Field offset: 0x3C
	internal Action callback; //Field offset: 0x40

	private static RenderChainCommand() { }

	public RenderChainCommand() { }

	private void Blit(Texture source, RenderTexture destination, float depth) { }

	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	public static void PopScissor(DrawParams drawParams, float pixelsPerPoint) { }

	public static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint) { }

	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	internal void Reset() { }

}

