namespace UnityEngine.Rendering.PostProcessing;

internal class TextureLerper
{
	private static TextureLerper m_Instance; //Field offset: 0x0
	private CommandBuffer m_Command; //Field offset: 0x8
	private PropertySheetFactory m_PropertySheets; //Field offset: 0xC
	private PostProcessResources m_Resources; //Field offset: 0x10
	private List<RenderTexture> m_Recycled; //Field offset: 0x14
	private List<RenderTexture> m_Actives; //Field offset: 0x18

	internal static TextureLerper instance
	{
		internal get { } //Length: 223
	}

	private TextureLerper() { }

	internal void BeginFrame(PostProcessRenderContext context) { }

	internal void Clear() { }

	internal void EndFrame() { }

	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false) { }

	internal static TextureLerper get_instance() { }

	internal Texture Lerp(Texture from, Texture to, float t) { }

	internal Texture Lerp(Texture from, Color to, float t) { }

}

