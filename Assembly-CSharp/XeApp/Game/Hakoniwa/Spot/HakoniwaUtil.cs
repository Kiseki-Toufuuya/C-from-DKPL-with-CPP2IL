namespace XeApp.Game.Hakoniwa.Spot;

public class HakoniwaUtil
{
	private static Texture2D m_ditherTexture; //Field offset: 0x0

	public HakoniwaUtil() { }

	[CompilerGenerated]
	internal static void <CreateOrderedDitherTexture>g__CreateDissolveTextureSub|13_0(ref Byte[2] retArray, int offsetX, int offsetY, int texSize, int baseIndex, int indexStep) { }

	public static ValueTuple<Single, Single> CalcFalloffParameter(float st, float ed) { }

	public static Single[] CreateGaussianKernel(int numSample, float variance) { }

	public static Texture2D CreateOrderedDitherTexture(int textureSize) { }

	public static Texture2D CreateParlinNoiseTexture(int textureWidth, int textureHeight, float scale) { }

	public static void GetCommonInteractBundleName(out string xabName, int objectId) { }

	public static Texture2D GetDitherTexture() { }

	public static void GetInteractBundleName(out string xabName, out string assetName, int objectId, int charaId, int skinId) { }

	public static string GetItemIconResourceId(long itemId) { }

	public static bool GetItemIconResourceName(out string resourceName, long itemId) { }

	public static void GetStageBundleName(out string xabName, out string assetName, int spotId) { }

	public static void GetStageResourceName(out string resourcePath, out string resourceName, string resourceBasePath, int spotId) { }

	public static void GizmosDrawAllow(Vector3 posA, Vector3 posB) { }

	public static void ReleaseOrderedDitherTexture() { }

	public static void SaveRenderTexture(RenderTexture renderTarget, string fileName) { }

	public static void SaveTexture(Texture2D texture, string fileName) { }

	public static void SetLayerRecursively(GameObject obj, int layer) { }

	public static void SetMaterialDissolve(Material material, float dissolve) { }

	public static void SetSpriteAsTexture(Material material, int shaderPropertyId, Sprite srcSprite) { }

	public static void SetSpriteAsTexture(Material material, string paramName, Sprite srcSprite) { }

	public static int SortingOrder(float depth) { }

}

