namespace XeSys.Gfx;

public class LayoutUGUIUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public T component; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		internal bool <GetParentComponent>b__0(Transform tr) { }

	}

	internal sealed class SearchParentCallback : MulticastDelegate
	{

		public SearchParentCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Transform transform, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Transform transform) { }

	}

	private static String[] delimiter; //Field offset: 0x0

	private static LayoutUGUIUtility() { }

	public LayoutUGUIUtility() { }

	public static void AddView(GameObject parentObj, AbsoluteLayout parentView, GameObject childObj) { }

	public static bool ApplyTextUGUI(TextView view) { }

	public static bool ApplyTextUGUI(LayoutUGUIRuntime runtime, string viewEXID) { }

	public static T GetParentComponent(Transform transform) { }

	public static LayoutUGUIRuntime GetParentRuntime(Transform transform) { }

	public static RectTransform GetRectTransform(ViewBase view) { }

	public static ViewBase GetViewBase(RectTransform rt) { }

	public static string GetViewIDFromUGUIName(string uguiName) { }

	public static Rect MakeUnitySpriteTextureRect(Texture tex, TexUVData uvData) { }

	public static Rect MakeUnityUVRect(TexUVData uvData) { }

	public static void RemoveView(GameObject parentObj, AbsoluteLayout parentView, GameObject childObj, bool isTransSetParent = true) { }

	public static void RemoveView(GameObject childObj, bool isTransSetParent = true) { }

	public static T SearchComponent(ViewBase view) { }

	public static T[] SearchComponentsInChildren(ViewBase view) { }

	public static bool SearchParentGameObject(Transform transform, SearchParentCallback callback) { }

	public static void SetImageRaycastTarget(GameObject obj, bool enable) { }

	public static void SetRaycastTarget(GameObject obj, bool enable) { }

	public static void SetTextRaycastTarget(GameObject obj, bool enable) { }

}

