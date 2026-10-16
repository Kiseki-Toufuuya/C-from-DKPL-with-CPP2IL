namespace Coffee.UIEffects;

public class GraphicConnector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<GraphicConnector> <>9__4_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <AddConnector>b__4_0(GraphicConnector x, GraphicConnector y) { }

	}

	private static readonly List<GraphicConnector> s_Connectors; //Field offset: 0x0
	private static readonly Dictionary<Type, GraphicConnector> s_ConnectorMap; //Field offset: 0x4
	private static readonly GraphicConnector s_EmptyConnector; //Field offset: 0x8

	public override AdditionalCanvasShaderChannels extraChannel
	{
		 get { } //Length: 6
	}

	protected override int priority
	{
		 get { } //Length: 4
	}

	private static GraphicConnector() { }

	public GraphicConnector() { }

	protected static void AddConnector(GraphicConnector connector) { }

	public static GraphicConnector FindConnector(Graphic graphic) { }

	public override Shader FindShader(string shaderName) { }

	public override AdditionalCanvasShaderChannels get_extraChannel() { }

	protected override int get_priority() { }

	public override void GetNormalizedFactor(EffectArea area, int index, Matrix2x3 matrix, Vector2 position, out Vector2 normalizedPos) { }

	public override void GetPositionFactor(EffectArea area, int index, Rect rect, Vector2 position, out float x, out float y) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Init() { }

	public override bool IsText(Graphic graphic) { }

	protected override bool IsValid(Graphic graphic) { }

	public override void OnDisable(Graphic graphic) { }

	public override void OnEnable(Graphic graphic) { }

	public override void SetExtraChannel(ref UIVertex vertex, Vector2 value) { }

	public override void SetMaterialDirty(Graphic graphic) { }

	public override void SetVerticesDirty(Graphic graphic) { }

}

