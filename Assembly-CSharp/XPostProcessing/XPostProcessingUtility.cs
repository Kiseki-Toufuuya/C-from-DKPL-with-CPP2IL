namespace XPostProcessing;

public class XPostProcessingUtility
{
	private static XPostProcessingUtility _instance; //Field offset: 0x0
	private static int resetFrameCount; //Field offset: 0x4
	private static Color srcColor; //Field offset: 0x8
	private static Color dstColor; //Field offset: 0x18
	private static string TypePreFix; //Field offset: 0x28
	public int LastSelectedCategory; //Field offset: 0x8
	public int ThumbWidth; //Field offset: 0xC
	public int ThumbHeight; //Field offset: 0x10
	public int cache_ThumbWidth; //Field offset: 0x14
	public int cache_ThumbHeight; //Field offset: 0x18
	public bool cache_IsLinear; //Field offset: 0x1C
	public RenderTexture PreviewRT; //Field offset: 0x20

	public static XPostProcessingUtility Instance
	{
		 get { } //Length: 1928
	}

	private static XPostProcessingUtility() { }

	public XPostProcessingUtility() { }

	public static void DumpRenderTexture(RenderTexture rt, string pngOutPath) { }

	public static XPostProcessingUtility get_Instance() { }

	public static Color GetRandomLerpColor(int RandomFrameCount, float lerpSpeed) { }

	public static Type GetSettingByName(string typeFullName) { }

	public static Color RandomColor() { }

}

