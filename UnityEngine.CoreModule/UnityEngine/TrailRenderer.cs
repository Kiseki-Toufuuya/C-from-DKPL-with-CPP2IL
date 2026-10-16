namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
public sealed class TrailRenderer : Renderer
{

	public LineAlignment alignment
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool autodestruct
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Gradient colorGradient
	{
		 get { } //Length: 118
		 set { } //Length: 163
	}

	public bool emitting
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Color endColor
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public float endWidth
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool generateLightingData
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float minVertexDistance
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public int numCapVertices
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int numCornerVertices
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
	public int numPositions
	{
		 get { } //Length: 98
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		 get { } //Length: 98
	}

	public float shadowBias
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Color startColor
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public float startWidth
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public LineTextureMode textureMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Vector2 textureScale
	{
		 get { } //Length: 121
		 set { } //Length: 102
	}

	public float time
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public AnimationCurve widthCurve
	{
		 get { } //Length: 180
		 set { } //Length: 163
	}

	public float widthMultiplier
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public TrailRenderer() { }

	[FreeFunction(Name = "TrailRendererScripting::AddPosition", HasExplicitThis = True)]
	public void AddPosition(Vector3 position) { }

	private static void AddPosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	[FreeFunction(Name = "TrailRendererScripting::AddPositions", HasExplicitThis = True)]
	public void AddPositions(Vector3[] positions) { }

	public void AddPositions(out NativeArray<Vector3> positions) { }

	public void AddPositions(out NativeSlice<Vector3> positions) { }

	private static void AddPositions_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions) { }

	[FreeFunction(Name = "TrailRendererScripting::AddPositionsWithNativeContainer", HasExplicitThis = True)]
	private void AddPositionsWithNativeContainer(IntPtr positions, int length) { }

	private static void AddPositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int length) { }

	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, bool useTransform) { }

	public void Clear() { }

	private static void Clear_Injected(IntPtr _unity_self) { }

	public LineAlignment get_alignment() { }

	private static LineAlignment get_alignment_Injected(IntPtr _unity_self) { }

	public bool get_autodestruct() { }

	private static bool get_autodestruct_Injected(IntPtr _unity_self) { }

	public Gradient get_colorGradient() { }

	public bool get_emitting() { }

	private static bool get_emitting_Injected(IntPtr _unity_self) { }

	public Color get_endColor() { }

	private static void get_endColor_Injected(IntPtr _unity_self, out Color ret) { }

	public float get_endWidth() { }

	private static float get_endWidth_Injected(IntPtr _unity_self) { }

	public bool get_generateLightingData() { }

	private static bool get_generateLightingData_Injected(IntPtr _unity_self) { }

	public SpriteMaskInteraction get_maskInteraction() { }

	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	public float get_minVertexDistance() { }

	private static float get_minVertexDistance_Injected(IntPtr _unity_self) { }

	public int get_numCapVertices() { }

	private static int get_numCapVertices_Injected(IntPtr _unity_self) { }

	public int get_numCornerVertices() { }

	private static int get_numCornerVertices_Injected(IntPtr _unity_self) { }

	public int get_numPositions() { }

	public int get_positionCount() { }

	private static int get_positionCount_Injected(IntPtr _unity_self) { }

	public float get_shadowBias() { }

	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	public Color get_startColor() { }

	private static void get_startColor_Injected(IntPtr _unity_self, out Color ret) { }

	public float get_startWidth() { }

	private static float get_startWidth_Injected(IntPtr _unity_self) { }

	public LineTextureMode get_textureMode() { }

	private static LineTextureMode get_textureMode_Injected(IntPtr _unity_self) { }

	public Vector2 get_textureScale() { }

	private static void get_textureScale_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_time() { }

	private static float get_time_Injected(IntPtr _unity_self) { }

	public AnimationCurve get_widthCurve() { }

	public float get_widthMultiplier() { }

	private static float get_widthMultiplier_Injected(IntPtr _unity_self) { }

	private Gradient GetColorGradientCopy() { }

	private static IntPtr GetColorGradientCopy_Injected(IntPtr _unity_self) { }

	public Vector3 GetPosition(int index) { }

	private static void GetPosition_Injected(IntPtr _unity_self, int index, out Vector3 ret) { }

	public int GetPositions(out NativeArray<Vector3> positions) { }

	public int GetPositions(out NativeSlice<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetPositions", HasExplicitThis = True)]
	public int GetPositions(out Vector3[] positions) { }

	private static int GetPositions_Injected(IntPtr _unity_self, out BlittableArrayWrapper positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetPositionsWithNativeContainer", HasExplicitThis = True)]
	private int GetPositionsWithNativeContainer(IntPtr positions, int length) { }

	private static int GetPositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int length) { }

	[FreeFunction(Name = "TrailRendererScripting::GetVisiblePositions", HasExplicitThis = True)]
	public int GetVisiblePositions(out Vector3[] positions) { }

	public int GetVisiblePositions(out NativeSlice<Vector3> positions) { }

	public int GetVisiblePositions(out NativeArray<Vector3> positions) { }

	private static int GetVisiblePositions_Injected(IntPtr _unity_self, out BlittableArrayWrapper positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetVisiblePositionsWithNativeContainer", HasExplicitThis = True)]
	private int GetVisiblePositionsWithNativeContainer(IntPtr positions, int length) { }

	private static int GetVisiblePositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int length) { }

	private AnimationCurve GetWidthCurveCopy() { }

	private static IntPtr GetWidthCurveCopy_Injected(IntPtr _unity_self) { }

	public void set_alignment(LineAlignment value) { }

	private static void set_alignment_Injected(IntPtr _unity_self, LineAlignment value) { }

	public void set_autodestruct(bool value) { }

	private static void set_autodestruct_Injected(IntPtr _unity_self, bool value) { }

	public void set_colorGradient(Gradient value) { }

	public void set_emitting(bool value) { }

	private static void set_emitting_Injected(IntPtr _unity_self, bool value) { }

	public void set_endColor(Color value) { }

	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_endWidth(float value) { }

	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	public void set_generateLightingData(bool value) { }

	private static void set_generateLightingData_Injected(IntPtr _unity_self, bool value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	public void set_minVertexDistance(float value) { }

	private static void set_minVertexDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_numCapVertices(int value) { }

	private static void set_numCapVertices_Injected(IntPtr _unity_self, int value) { }

	public void set_numCornerVertices(int value) { }

	private static void set_numCornerVertices_Injected(IntPtr _unity_self, int value) { }

	public void set_shadowBias(float value) { }

	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	public void set_startColor(Color value) { }

	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_startWidth(float value) { }

	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	public void set_textureMode(LineTextureMode value) { }

	private static void set_textureMode_Injected(IntPtr _unity_self, LineTextureMode value) { }

	public void set_textureScale(Vector2 value) { }

	private static void set_textureScale_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_time(float value) { }

	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	public void set_widthCurve(AnimationCurve value) { }

	public void set_widthMultiplier(float value) { }

	private static void set_widthMultiplier_Injected(IntPtr _unity_self, float value) { }

	private void SetColorGradient(Gradient curve) { }

	private static void SetColorGradient_Injected(IntPtr _unity_self, IntPtr curve) { }

	public void SetPosition(int index, Vector3 position) { }

	private static void SetPosition_Injected(IntPtr _unity_self, int index, in Vector3 position) { }

	public void SetPositions(NativeArray<Vector3> positions) { }

	public void SetPositions(NativeSlice<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::SetPositions", HasExplicitThis = True)]
	public void SetPositions(Vector3[] positions) { }

	private static void SetPositions_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions) { }

	[FreeFunction(Name = "TrailRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = True)]
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	private static void SetPositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int count) { }

	private void SetWidthCurve(AnimationCurve curve) { }

	private static void SetWidthCurve_Injected(IntPtr _unity_self, IntPtr curve) { }

}

