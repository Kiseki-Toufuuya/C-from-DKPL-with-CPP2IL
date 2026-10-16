namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
public sealed class Sprite : object
{

	public Texture2D associatedAlphaSplitTexture
	{
		[NativeMethod("GetAlphaTexture")]
		 get { } //Length: 120
	}

	public Vector4 border
	{
		 get { } //Length: 112
	}

	public Bounds bounds
	{
		 get { } //Length: 117
	}

	internal uint extrude
	{
		internal get { } //Length: 98
	}

	public bool packed
	{
		 get { } //Length: 104
	}

	public SpritePackingMode packingMode
	{
		 get { } //Length: 98
	}

	public SpritePackingRotation packingRotation
	{
		 get { } //Length: 98
	}

	public Vector2 pivot
	{
		[NativeMethod("GetPivotInPixels")]
		 get { } //Length: 121
	}

	public float pixelsPerUnit
	{
		[NativeMethod("GetPixelsToUnits")]
		 get { } //Length: 102
	}

	public Rect rect
	{
		 get { } //Length: 112
	}

	public float spriteAtlasTextureScale
	{
		[NativeMethod("GetSpriteAtlasTextureScale")]
		 get { } //Length: 102
	}

	public Texture2D texture
	{
		 get { } //Length: 120
	}

	public Rect textureRect
	{
		 get { } //Length: 134
	}

	public Vector2 textureRectOffset
	{
		 get { } //Length: 121
	}

	public UInt16[] triangles
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Vector2[] uv
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Vector2[] vertices
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	[RequiredByNativeCode]
	private Sprite() { }

	public bool AddScriptableObject(ScriptableObject obj) { }

	private static bool AddScriptableObject_Injected(IntPtr _unity_self, IntPtr obj) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	private static IntPtr CreateSprite_Injected(IntPtr texture, in Rect rect, in Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, in Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[FreeFunction("SpritesBindings::CreateSpriteWithoutTextureScripting")]
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	private static IntPtr CreateSpriteWithoutTextureScripting_Injected(in Rect rect, in Vector2 pivot, float pixelsToUnits, IntPtr texture) { }

	[NativeMethod("GetAlphaTexture")]
	public Texture2D get_associatedAlphaSplitTexture() { }

	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	public Vector4 get_border() { }

	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	public Bounds get_bounds() { }

	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	internal uint get_extrude() { }

	private static uint get_extrude_Injected(IntPtr _unity_self) { }

	public bool get_packed() { }

	public SpritePackingMode get_packingMode() { }

	public SpritePackingRotation get_packingRotation() { }

	[NativeMethod("GetPivotInPixels")]
	public Vector2 get_pivot() { }

	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[NativeMethod("GetPixelsToUnits")]
	public float get_pixelsPerUnit() { }

	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	public Rect get_rect() { }

	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[NativeMethod("GetSpriteAtlasTextureScale")]
	public float get_spriteAtlasTextureScale() { }

	private static float get_spriteAtlasTextureScale_Injected(IntPtr _unity_self) { }

	public Texture2D get_texture() { }

	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	public Rect get_textureRect() { }

	public Vector2 get_textureRectOffset() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	public UInt16[] get_triangles() { }

	private static UInt16[] get_triangles_Injected(IntPtr _unity_self) { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	public Vector2[] get_uv() { }

	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	public Vector2[] get_vertices() { }

	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	internal Vector4 GetInnerUVs() { }

	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	internal Vector4 GetOuterUVs() { }

	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	internal int GetPacked() { }

	private static int GetPacked_Injected(IntPtr _unity_self) { }

	internal int GetPackingMode() { }

	private static int GetPackingMode_Injected(IntPtr _unity_self) { }

	internal int GetPackingRotation() { }

	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	internal Vector4 GetPadding() { }

	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	public int GetPhysicsShapeCount() { }

	private static int GetPhysicsShapeCount_Injected(IntPtr _unity_self) { }

	[FreeFunction("SpritesBindings::GetPhysicsShape", ThrowsException = True)]
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	private static void GetPhysicsShapeImpl_Injected(IntPtr sprite, int shapeIdx, ref BlittableListWrapper physicsShape) { }

	public int GetPhysicsShapePointCount(int shapeIdx) { }

	[FreeFunction("SpritesBindings::GetScriptableObjects", ThrowsException = True, HasExplicitThis = True)]
	public uint GetScriptableObjects(ScriptableObject[] scriptableObjects) { }

	private static uint GetScriptableObjects_Injected(IntPtr _unity_self, ScriptableObject[] scriptableObjects) { }

	public uint GetScriptableObjectsCount() { }

	private static uint GetScriptableObjectsCount_Injected(IntPtr _unity_self) { }

	internal Texture2D GetSecondaryTexture(int index) { }

	private static IntPtr GetSecondaryTexture_Injected(IntPtr _unity_self, int index) { }

	public int GetSecondaryTextureCount() { }

	private static int GetSecondaryTextureCount_Injected(IntPtr _unity_self) { }

	[FreeFunction("SpritesBindings::GetSecondaryTextures", ThrowsException = True, HasExplicitThis = True)]
	public int GetSecondaryTextures(SecondarySpriteTexture[] secondaryTexture) { }

	private static int GetSecondaryTextures_Injected(IntPtr _unity_self, SecondarySpriteTexture[] secondaryTexture) { }

	internal Rect GetTextureRect() { }

	private static void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret) { }

	internal Vector2 GetTextureRectOffset() { }

	private static void GetTextureRectOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[NativeMethod("GetPhysicsShapePointCount")]
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	private static int Internal_GetPhysicsShapePointCount_Injected(IntPtr _unity_self, int shapeIdx) { }

	[FreeFunction("SpritesBindings::OverrideGeometry", HasExplicitThis = True)]
	public void OverrideGeometry(Vector2[] vertices, UInt16[] triangles) { }

	private static void OverrideGeometry_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vertices, ref ManagedSpanWrapper triangles) { }

	[FreeFunction("SpritesBindings::OverridePhysicsShape", ThrowsException = True)]
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	private static void OverridePhysicsShape_Injected(IntPtr sprite, ref ManagedSpanWrapper physicsShape, int idx) { }

	[FreeFunction("SpritesBindings::OverridePhysicsShapeCount")]
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

	private static void OverridePhysicsShapeCount_Injected(IntPtr sprite, int physicsShapeCount) { }

	public bool RemoveScriptableObjectAt(uint i) { }

	private static bool RemoveScriptableObjectAt_Injected(IntPtr _unity_self, uint i) { }

	public bool SetScriptableObjectAt(ScriptableObject obj, uint i) { }

	private static bool SetScriptableObjectAt_Injected(IntPtr _unity_self, IntPtr obj, uint i) { }

}

