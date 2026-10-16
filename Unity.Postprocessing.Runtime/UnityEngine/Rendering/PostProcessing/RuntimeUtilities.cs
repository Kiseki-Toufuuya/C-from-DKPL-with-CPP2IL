namespace UnityEngine.Rendering.PostProcessing;

[Extension]
public static class RuntimeUtilities
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Assembly, IEnumerable`1<Type>> <>9__95_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Type> <GetAllAssemblyTypes>b__95_0(Assembly t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__96
	{
		public static readonly <>c__96<T> <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__96_0; //Field offset: 0x0

		private static <>c__96`1() { }

		public <>c__96`1() { }

		internal bool <GetAllTypesDerivedFrom>b__96_0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllSceneObjects>d__88 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Queue<Transform> <queue>5__2; //Field offset: 0x0
		private GameObject[] <>7__wrap2; //Field offset: 0x0
		private int <>7__wrap3; //Field offset: 0x0
		private IEnumerator <>7__wrap4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetAllSceneObjects>d__88`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static Texture2D m_WhiteTexture; //Field offset: 0x0
	private static Texture3D m_WhiteTexture3D; //Field offset: 0x4
	private static Texture2D m_BlackTexture; //Field offset: 0x8
	private static Texture3D m_BlackTexture3D; //Field offset: 0xC
	private static Texture2D m_TransparentTexture; //Field offset: 0x10
	private static Texture3D m_TransparentTexture3D; //Field offset: 0x14
	private static Dictionary<Int32, Texture2D> m_LutStrips; //Field offset: 0x18
	private static PostProcessResources s_Resources; //Field offset: 0x1C
	private static Mesh s_FullscreenTriangle; //Field offset: 0x20
	private static Material s_CopyStdMaterial; //Field offset: 0x24
	private static Material s_CopyStdFromDoubleWideMaterial; //Field offset: 0x28
	private static Material s_CopyMaterial; //Field offset: 0x2C
	private static Material s_CopyFromTexArrayMaterial; //Field offset: 0x30
	private static PropertySheet s_CopySheet; //Field offset: 0x34
	private static PropertySheet s_CopyFromTexArraySheet; //Field offset: 0x38
	private static IEnumerable<Type> m_AssemblyTypes; //Field offset: 0x3C

	public static Texture2D blackTexture
	{
		 get { } //Length: 350
	}

	public static Texture3D blackTexture3D
	{
		 get { } //Length: 383
	}

	public static Material copyFromTexArrayMaterial
	{
		 get { } //Length: 318
	}

	public static PropertySheet copyFromTexArraySheet
	{
		 get { } //Length: 501
	}

	public static Material copyMaterial
	{
		 get { } //Length: 318
	}

	public static PropertySheet copySheet
	{
		 get { } //Length: 198
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		 get { } //Length: 318
	}

	public static Material copyStdMaterial
	{
		 get { } //Length: 318
	}

	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		 get { } //Length: 6
	}

	public static Mesh fullscreenTriangle
	{
		 get { } //Length: 713
	}

	public static bool isAndroidOpenGL
	{
		 get { } //Length: 84
	}

	public static bool isLinearColorSpace
	{
		 get { } //Length: 17
	}

	public static bool isOpenGLES
	{
		 get { } //Length: 17
	}

	public static bool isSinglePassStereoEnabled
	{
		 get { } //Length: 58
	}

	public static bool isVREnabled
	{
		 get { } //Length: 11
	}

	public static bool isWebNonWebGPU
	{
		 get { } //Length: 84
	}

	public static bool scriptableRenderPipelineActive
	{
		 get { } //Length: 108
	}

	public static bool supportsDeferredShading
	{
		 get { } //Length: 114
	}

	public static bool supportsDepthNormals
	{
		 get { } //Length: 114
	}

	public static Texture2D transparentTexture
	{
		 get { } //Length: 346
	}

	public static Texture3D transparentTexture3D
	{
		 get { } //Length: 379
	}

	public static Texture2D whiteTexture
	{
		 get { } //Length: 341
	}

	public static Texture3D whiteTexture3D
	{
		 get { } //Length: 383
	}

	private static RuntimeUtilities() { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Extension]
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Nullable<Rect> viewport = null, bool preserveDepth = false) { }

	[Extension]
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[Extension]
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Extension]
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[Extension]
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1) { }

	[Extension]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	[Extension]
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static void CreateIfNull(ref T obj) { }

	public static void Destroy(object obj) { }

	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false) { }

	public static float Exp2(float x) { }

	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	public static Texture2D get_blackTexture() { }

	public static Texture3D get_blackTexture3D() { }

	public static Material get_copyFromTexArrayMaterial() { }

	public static PropertySheet get_copyFromTexArraySheet() { }

	public static Material get_copyMaterial() { }

	public static PropertySheet get_copySheet() { }

	public static Material get_copyStdFromDoubleWideMaterial() { }

	public static Material get_copyStdMaterial() { }

	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	public static Mesh get_fullscreenTriangle() { }

	public static bool get_isAndroidOpenGL() { }

	public static bool get_isLinearColorSpace() { }

	public static bool get_isOpenGLES() { }

	public static bool get_isSinglePassStereoEnabled() { }

	public static bool get_isVREnabled() { }

	public static bool get_isWebNonWebGPU() { }

	public static bool get_scriptableRenderPipelineActive() { }

	public static bool get_supportsDeferredShading() { }

	public static bool get_supportsDepthNormals() { }

	public static Texture2D get_transparentTexture() { }

	public static Texture3D get_transparentTexture3D() { }

	public static Texture2D get_whiteTexture() { }

	public static Texture3D get_whiteTexture3D() { }

	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[IteratorStateMachine(typeof(<GetAllSceneObjects>d__88`1))]
	public static IEnumerable<T> GetAllSceneObjects() { }

	public static IEnumerable<Type> GetAllTypesDerivedFrom() { }

	[Extension]
	public static T GetAttribute(Type type) { }

	public static string GetFieldPath(Expression<Func`2<TType, TValue>> expr) { }

	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Texture2D GetLutStrip(int size) { }

	public static Attribute[] GetMemberAttributes(Expression<Func`2<TType, TValue>> expr) { }

	internal static bool hasAlpha(RenderTextureFormat format) { }

	public static bool IsDynamicResolutionEnabled(Camera camera) { }

	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	public static bool IsResolvedDepthAvailable(Camera camera) { }

	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	internal static bool isValidResources() { }

	[Extension]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Extension]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	internal static void UpdateResources(PostProcessResources resources) { }

}

