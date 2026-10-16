namespace XeSys.Gfx;

[RequireComponent(typeof(DebugRaycastTargetMarker))]
public class LayoutUGUIViewer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<ViewBase> <>9__35_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <CreateViewList>b__35_1(ViewBase v0, ViewBase v1) { }

	}

	[CompilerGenerated]
	private sealed class <Co_Initialize>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LayoutUGUIViewer <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <Co_Initialize>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private enum AnimAction
	{
		GoStop = 0,
		Loop = 1,
		Stop = 2,
	}

	private enum AnimParam
	{
		Label = 0,
		Frame = 1,
	}

	private enum AnimRange
	{
		Unit = 0,
		Sibling = 1,
		All = 2,
	}

	private enum ColorTarget
	{
		SelectView = 0,
		RaycastTarget = 1,
	}

	private enum Mode
	{
		Tree = 0,
		Search = 1,
		Anime = 2,
		ContCommon = 3,
		ContCustom = 4,
	}

	private const float WINDOW_HEIGHT = 600; //Field offset: 0x0
	private const float WINDOW_WIDTH = 500; //Field offset: 0x0
	private static StringBuilder s_str; //Field offset: 0x0
	private static int MODE_COUNT; //Field offset: 0x4
	[SerializeField]
	private Canvas m_canvas; //Field offset: 0x10
	private DebugRaycastTargetMarker m_raycastMarker; //Field offset: 0x14
	private GameObject m_prefab; //Field offset: 0x18
	private TexUVFilePack[] m_texUVFilePackList; //Field offset: 0x1C
	private LayoutUGUIRuntime m_runtime; //Field offset: 0x20
	private TexUVListManager[] m_uvManagerList; //Field offset: 0x24
	private Action m_onGUI; //Field offset: 0x28
	private Rect m_windowPos; //Field offset: 0x2C
	private String[] m_modeName; //Field offset: 0x3C
	private Mode m_mode; //Field offset: 0x40
	private Action[] m_modeAction; //Field offset: 0x44
	private ViewBase m_currentView; //Field offset: 0x48
	private string m_searchText; //Field offset: 0x4C
	private List<ViewBase> m_viewList; //Field offset: 0x50
	private List<ViewBase> m_resultList; //Field offset: 0x54
	private AnimRange m_animRange; //Field offset: 0x58
	private AnimAction m_animAction; //Field offset: 0x5C
	private AnimParam m_animParam; //Field offset: 0x60
	private int m_animStartFrame; //Field offset: 0x64
	private int m_animEndFrame; //Field offset: 0x68
	private string m_animStartLabel; //Field offset: 0x6C
	private string m_animEndLabel; //Field offset: 0x70
	private bool m_isUseEndLabel; //Field offset: 0x74
	private bool m_isSelectStartLabel; //Field offset: 0x75
	private Vector2 m_offset; //Field offset: 0x78
	private Color m_currentColor; //Field offset: 0x80
	private ColorTarget m_colorTarget; //Field offset: 0x90
	private bool m_isEnableColor; //Field offset: 0x94
	private bool m_isEnableFlash; //Field offset: 0x95
	private float m_flashCounter; //Field offset: 0x98
	private float m_flashSecond; //Field offset: 0x9C
	private Dictionary<String, TexUVFilePack> m_dicTexture; //Field offset: 0xA0
	private List<String> m_texNameList; //Field offset: 0xA4
	private Vector2 m_scrollPos; //Field offset: 0xA8
	private float m_backupHS; //Field offset: 0xB0
	private float m_backupHST; //Field offset: 0xB4
	private float m_backupVS; //Field offset: 0xB8
	private float m_backupVST; //Field offset: 0xBC

	public bool IsBusy
	{
		 get { } //Length: 96
	}

	private static LayoutUGUIViewer() { }

	public LayoutUGUIViewer() { }

	[CompilerGenerated]
	private bool <CreateViewList>b__35_0(List<ViewBase> listView) { }

	private void Awake() { }

	private void BeginScrollBar() { }

	[IteratorStateMachine(typeof(<Co_Initialize>d__14))]
	private IEnumerator Co_Initialize() { }

	private void ContCustom_ImageView() { }

	private void ContCustom_TextView() { }

	private void CreateTextureList() { }

	private void CreateViewList(Layout layout) { }

	private void EndScrollBar() { }

	private void ExecuteAnim(Object[] param, string addition = "") { }

	private void ExecuteAnimFrame(Object[] param) { }

	public bool get_IsBusy() { }

	private TextAnchor GetTextAlignment(int horizontal, int vertical) { }

	private int GetTextAlignmentH(TextAnchor align) { }

	private int GetTextAlignmentV(TextAnchor align) { }

	private static string GetViewExplain(ViewBase view) { }

	public void Initialize(GameObject prefab, TexUVFilePack[] texUVFilePackList) { }

	private void InitWindow() { }

	private void LateUpdate() { }

	private void Mode_Anime() { }

	private void Mode_ContCommon() { }

	private void Mode_ContCustom() { }

	private void Mode_Search() { }

	private void Mode_Tree() { }

	private void OnGUI() { }

	private void OnGUI_Idle() { }

	private void OnGUI_Viewer() { }

	private void OnGUI_Wait() { }

	private void OnWindow(int windowID) { }

	private void Release() { }

	private void SearchView(string str) { }

	private float SelectColor(string label, float color) { }

	private void SetTexture(RawImageEx image, string name) { }

	private static bool TextFieldFloat(ref float value, GUILayoutOption[] option) { }

	private static bool TextFieldInt(ref int value, GUILayoutOption[] option) { }

	private Enum ToggleEnum(Enum value) { }

	private int ToggleSelect(String[] label, int value) { }

}

