namespace Live2D.Cubism.Rendering;

[CubismDontMoveOnReimport]
[ExecuteInEditMode]
public sealed class CubismRenderController : MonoBehaviour, ICubismUpdatable
{
	[HideInInspector]
	[SerializeField]
	public float Opacity; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private float _lastOpacity; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenModelMultiplyColors; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenModelScreenColors; //Field offset: 0x19
	[HideInInspector]
	[SerializeField]
	private Color _modelMultiplyColor; //Field offset: 0x1C
	[HideInInspector]
	[SerializeField]
	private Color _modelScreenColor; //Field offset: 0x2C
	[HideInInspector]
	[SerializeField]
	private int _sortingLayerId; //Field offset: 0x3C
	[HideInInspector]
	[SerializeField]
	private CubismSortingMode _sortingMode; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private int _sortingOrder; //Field offset: 0x44
	[SerializeField]
	public Camera CameraToFace; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	private object _drawOrderHandler; //Field offset: 0x4C
	private ICubismDrawOrderHandler _drawOrderHandlerInterface; //Field offset: 0x50
	[HideInInspector]
	[SerializeField]
	private object _opacityHandler; //Field offset: 0x54
	private ICubismOpacityHandler _opacityHandlerInterface; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private object _multiplyColorHandler; //Field offset: 0x5C
	private ICubismBlendColorHandler _multiplyColorHandlerInterface; //Field offset: 0x60
	[HideInInspector]
	[SerializeField]
	private object _screenColorHandler; //Field offset: 0x64
	private ICubismBlendColorHandler _screenColorHandlerInterface; //Field offset: 0x68
	[HideInInspector]
	[SerializeField]
	public float _depthOffset; //Field offset: 0x6C
	private Transform _drawablesRootTransform; //Field offset: 0x70
	private CubismRenderer[] _renderers; //Field offset: 0x74
	private Color[] _newMultiplyColors; //Field offset: 0x78
	private Color[] _newScreenColors; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x80
	private bool _isInitialized; //Field offset: 0x81

	public float DepthOffset
	{
		 get { } //Length: 11
		 set { } //Length: 176
	}

	private Transform DrawablesRootTransform
	{
		private get { } //Length: 178
	}

	public object DrawOrderHandler
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	private ICubismDrawOrderHandler DrawOrderHandlerInterface
	{
		private get { } //Length: 78
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 61
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	[HideInInspector]
	public private bool IsInitialized
	{
		 get { } //Length: 14
		private set { } //Length: 17
	}

	private float LastOpacity
	{
		private get { } //Length: 11
		private set { } //Length: 18
	}

	private CubismModel Model
	{
		private get { } //Length: 20
	}

	public Color ModelMultiplyColor
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public Color ModelScreenColor
	{
		 get { } //Length: 18
		 set { } //Length: 141
	}

	public object MultiplyColorHandler
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	private ICubismBlendColorHandler MultiplyColorHandlerInterface
	{
		private get { } //Length: 90
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	public object OpacityHandler
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	private ICubismOpacityHandler OpacityHandlerInterface
	{
		private get { } //Length: 78
	}

	public bool OverrideFlagForModelMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverrideFlagForModelScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverwriteFlagForModelMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverwriteFlagForModelScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public private CubismRenderer[] Renderers
	{
		 get { } //Length: 106
		private set { } //Length: 27
	}

	public object ScreenColorHandler
	{
		 get { } //Length: 11
		 set { } //Length: 67
	}

	private ICubismBlendColorHandler ScreenColorHandlerInterface
	{
		private get { } //Length: 90
	}

	public string SortingLayer
	{
		 get { } //Length: 21
		 set { } //Length: 149
	}

	public int SortingLayerId
	{
		 get { } //Length: 11
		 set { } //Length: 133
	}

	public CubismSortingMode SortingMode
	{
		 get { } //Length: 11
		 set { } //Length: 110
	}

	public int SortingOrder
	{
		 get { } //Length: 11
		 set { } //Length: 110
	}

	public CubismRenderController() { }

	public float get_DepthOffset() { }

	private Transform get_DrawablesRootTransform() { }

	public object get_DrawOrderHandler() { }

	private ICubismDrawOrderHandler get_DrawOrderHandlerInterface() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public bool get_IsInitialized() { }

	private float get_LastOpacity() { }

	private CubismModel get_Model() { }

	public Color get_ModelMultiplyColor() { }

	public Color get_ModelScreenColor() { }

	public object get_MultiplyColorHandler() { }

	private ICubismBlendColorHandler get_MultiplyColorHandlerInterface() { }

	public override bool get_NeedsUpdateOnEditing() { }

	public object get_OpacityHandler() { }

	private ICubismOpacityHandler get_OpacityHandlerInterface() { }

	public bool get_OverrideFlagForModelMultiplyColors() { }

	public bool get_OverrideFlagForModelScreenColors() { }

	public bool get_OverwriteFlagForModelMultiplyColors() { }

	public bool get_OverwriteFlagForModelScreenColors() { }

	public CubismRenderer[] get_Renderers() { }

	public object get_ScreenColorHandler() { }

	private ICubismBlendColorHandler get_ScreenColorHandlerInterface() { }

	public string get_SortingLayer() { }

	public int get_SortingLayerId() { }

	public CubismSortingMode get_SortingMode() { }

	public int get_SortingOrder() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnDynamicDrawableData(CubismModel sender, CubismDynamicDrawableData[] data) { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	public void set_DepthOffset(float value) { }

	public void set_DrawOrderHandler(object value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	private void set_IsInitialized(bool value) { }

	private void set_LastOpacity(float value) { }

	public void set_ModelMultiplyColor(Color value) { }

	public void set_ModelScreenColor(Color value) { }

	public void set_MultiplyColorHandler(object value) { }

	public void set_OpacityHandler(object value) { }

	public void set_OverrideFlagForModelMultiplyColors(bool value) { }

	public void set_OverrideFlagForModelScreenColors(bool value) { }

	public void set_OverwriteFlagForModelMultiplyColors(bool value) { }

	public void set_OverwriteFlagForModelScreenColors(bool value) { }

	private void set_Renderers(CubismRenderer[] value) { }

	public void set_ScreenColorHandler(object value) { }

	public void set_SortingLayer(string value) { }

	public void set_SortingLayerId(int value) { }

	public void set_SortingMode(CubismSortingMode value) { }

	public void set_SortingOrder(int value) { }

	private void Start() { }

	public void TryInitializeRenderers() { }

	private void UpdateBlendColors() { }

	private void UpdateOpacity() { }

}

