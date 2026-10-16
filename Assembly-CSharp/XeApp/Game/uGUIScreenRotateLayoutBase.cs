namespace XeApp.Game;

public abstract class uGUIScreenRotateLayoutBase : uGUILayoutBase, IUpdateable, IInitializable
{
	internal enum LayoutOrientation
	{
		Landscape = 0,
		Portrait = 1,
		Both = 2,
	}

	protected uGUIScreenRotateLayoutsBase m_Layouts; //Field offset: 0x88
	private LayoutOrientation m_LayoutOrientation; //Field offset: 0x8C
	private bool m_IsCurrentOrientation; //Field offset: 0x90
	private float m_DispAlpah; //Field offset: 0x94
	private bool m_IsInitialized; //Field offset: 0x98
	private CanvasGroup m_canvasGroup; //Field offset: 0x9C

	public float DispAlpha
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public bool IsInitialized
	{
		 get { } //Length: 14
	}

	protected uGUIScreenRotateLayoutBase() { }

	public override void CopyToLayoutDispData(uGUIScreenRotateLayoutBase layout) { }

	public float get_DispAlpha() { }

	public bool get_IsInitialized() { }

	public void Init(LayoutOrientation layoutOrientation, GameObject rootObject, List<Font> font = null, Action postInit = null) { }

	public void Init(LayoutOrientation layoutOrientation, GameObject rootObject, List<TexUVFilePack> texUVFilePackList, List<Font> font = null, Action postInit = null) { }

	public void InitUIRotate() { }

	public void set_DispAlpha(float value) { }

	public override void SetAction(int actionType, int index, Action<T> action) { }

	public override void SetAction(int actionType, Action<T> action) { }

	public override void SetAction(int actionType, int index, Action action) { }

	public override void SetAction(int actionType, Action action) { }

	public override void SetLayouts(uGUIScreenRotateLayoutsBase layouts) { }

	public void SetOnMoveEnd(Action action) { }

	public override void SetParameter(int paramType, string key, object param) { }

	public override void SetParameter(int paramType, string key, string param) { }

	public override void SetParameter(int paramType, string key, float param) { }

	public override void SetParameter(int paramType, string key, int param) { }

	public override void SetParameter(int paramType, int index, int index2, object param) { }

	public override void SetParameter(int paramType, int index, int index2, int param) { }

	public override void SetParameter(int paramType, int index, int index2, float param) { }

	public override void SetParameter(int paramType, int index, object param) { }

	public override void SetParameter(int paramType, int index, float param) { }

	public override void SetParameter(int paramType, int index, int param) { }

	public override void SetParameter(int paramType, object param) { }

	public override void SetParameter(int paramType, string param) { }

	public override void SetParameter(int paramType, float param) { }

	public override void SetParameter(int paramType, int param) { }

	public override void SetParameter(int paramType, int index, int index2, string param) { }

	public override void SetParameter(int paramType, int index, string param) { }

	public virtual bool uGUIInitialize() { }

}

