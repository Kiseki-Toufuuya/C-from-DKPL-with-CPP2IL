namespace XeSys.Gfx;

[DefaultMember("Item")]
public class AbsoluteLayout : ViewBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CallbackSetAnim <>9__81_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <StopSiblingAnim>b__81_0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public int start; //Field offset: 0x8
		public int end; //Field offset: 0xC

		public <>c__DisplayClass71_0() { }

		internal void <StartSiblingAnimGoStopFrame>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public int startLabelHash; //Field offset: 0x8
		public int endLabelHash; //Field offset: 0xC

		public <>c__DisplayClass72_0() { }

		internal void <StartSiblingAnimGoStop>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public int startLabelHash; //Field offset: 0x8

		public <>c__DisplayClass74_0() { }

		internal void <StartSiblingAnimGoStop>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public int start; //Field offset: 0x8
		public int end; //Field offset: 0xC

		public <>c__DisplayClass76_0() { }

		internal void <StartSiblingAnimLoopFrame>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public int startLabelHash; //Field offset: 0x8
		public int endLabelHash; //Field offset: 0xC

		public <>c__DisplayClass77_0() { }

		internal void <StartSiblingAnimLoop>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public int startLabelHash; //Field offset: 0x8

		public <>c__DisplayClass79_0() { }

		internal void <StartSiblingAnimLoop>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public int startLabelHash; //Field offset: 0x8

		public <>c__DisplayClass80_0() { }

		internal void <StartSiblingAnimLoop>b__0(ViewBase view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public float scale; //Field offset: 0x8

		public <>c__DisplayClass82_0() { }

		internal void <SetSiblingAnimTimeScale>b__0(ViewBase view) { }

	}

	internal sealed class CallbackFindView : MulticastDelegate
	{

		public CallbackFindView(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(List<ViewBase> listView, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(List<ViewBase> listView) { }

	}

	private sealed class CallbackSetAnim : MulticastDelegate
	{

		public CallbackSetAnim(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ViewBase view, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ViewBase view) { }

	}

	private static List<ViewBase> s_FindViewList; //Field offset: 0x0
	protected List<ViewBase> m_List; //Field offset: 0x60
	public int viewCount; //Field offset: 0x64
	private Dictionary<String, ViewBase> m_ChildViewMap; //Field offset: 0x68
	private List<AbsoluteLayout> m_AbsoluteList; //Field offset: 0x6C
	private Dictionary<String, ViewBase> m_ChildViewMapForExid; //Field offset: 0x70

	public ViewBase Item
	{
		 get { } //Length: 67
	}

	private static AbsoluteLayout() { }

	public AbsoluteLayout() { }

	public override void AddView(ViewBase child) { }

	public override void AddViewCenter(ViewBase child) { }

	public virtual void Clear() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public ViewBase FindChildViewById(string id) { }

	public ViewBase FindViewByExId(string exid) { }

	public ViewBase FindViewById(string id) { }

	public ViewBase get_Item(int index) { }

	public void InitializeEmptyAnimationAll(bool force = false) { }

	public override void InsertView(int index, ViewBase child) { }

	public bool IsPlayingAll() { }

	private bool IsPlayingAll(List<ViewBase> listView) { }

	private bool IsPlayingAllNotLoop(List<ViewBase> listView) { }

	public bool IsPlayingAllNotLoop() { }

	public bool IsPlayingSibling() { }

	public void RemoveView(ViewBase child) { }

	public void SearchView(CallbackFindView callback) { }

	private void SearchViewInner(CallbackFindView callback) { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public void SetAllAnimTimeScale(float scale) { }

	public void SetChildrenAnimFrame(float frame, bool isSelf) { }

	public void SetChildrenAnimFrame(List<ViewBase> listView, float frame, bool isSelf) { }

	public void SetChildrenAnimTime(List<ViewBase> listView, float time, bool isSelf) { }

	public void SetChildrenAnimTime(float time, bool isSelf) { }

	public void SetSiblingAnimTimeScale(float scale) { }

	public void SettingAnimation(LayoutAnimation anim) { }

	public override void SettingTexture(TexUVListManager texManager) { }

	private void StartAllAnim(List<ViewBase> listView) { }

	public void StartAllAnim() { }

	public void StartAllAnimDecoLoop() { }

	public void StartAllAnimDecoOnce() { }

	public void StartAllAnimDefault() { }

	private void StartAllAnimGoStop(List<ViewBase> listView, int startLabelHash, int endLabelHash) { }

	public void StartAllAnimGoStop(int LabelHash) { }

	public void StartAllAnimGoStop(string Label) { }

	private void StartAllAnimGoStop(List<ViewBase> listView, int LabelHash) { }

	public void StartAllAnimGoStop(int startLabelHash, int endLabelHash) { }

	public void StartAllAnimGoStop(string startLabel, string endLabel) { }

	private void StartAllAnimGoStopFrame(List<ViewBase> listView, int start, int end) { }

	public void StartAllAnimGoStopFrame(int start, int end) { }

	public void StartAllAnimIn() { }

	public void StartAllAnimIn2() { }

	public void StartAllAnimInToOut() { }

	private void StartAllAnimLoop(List<ViewBase> listView, int startLabelHash, int endLabelHash) { }

	public void StartAllAnimLoop(int LabelHash) { }

	public void StartAllAnimLoop(string Label) { }

	private void StartAllAnimLoop(List<ViewBase> listView, int LabelHash) { }

	public void StartAllAnimLoop(int startLabelHash, int endLabelHash) { }

	public void StartAllAnimLoop(string startLabel, string endLabel) { }

	public void StartAllAnimLoopFrame(int start, int end) { }

	private void StartAllAnimLoopFrame(List<ViewBase> listView, int start, int end) { }

	public void StartAllAnimOut() { }

	private void StartChildrenAnim(List<ViewBase> listView, bool isSelf) { }

	public void StartChildrenAnim(bool isSelf) { }

	private void StartChildrenAnimGoStop(List<ViewBase> listView, int LabelHash, bool isSelf) { }

	private void StartChildrenAnimGoStop(List<ViewBase> listView, int startLabelHash, int endLabelHash, bool isSelf) { }

	public void StartChildrenAnimGoStop(string startLabel, string endLabel, bool isSelf) { }

	public void StartChildrenAnimGoStop(int startLabelHash, int endLabelHash, bool isSelf) { }

	public void StartChildrenAnimGoStop(string Label, bool isSelf) { }

	public void StartChildrenAnimGoStop(int LabelHash, bool isSelf) { }

	private void StartChildrenAnimGoStopFrame(List<ViewBase> listView, int start, int end, bool isSelf) { }

	public void StartChildrenAnimGoStopFrame(int start, int end, bool isSelf) { }

	public void StartChildrenAnimLoop(string Label, bool isSelf) { }

	public void StartChildrenAnimLoop(int LabelHash, bool isSelf) { }

	private void StartChildrenAnimLoop(List<ViewBase> listView, int startLabelHash, int endLabelHash, bool isSelf) { }

	public void StartChildrenAnimLoop(string startLabel, string endLabel, bool isSelf) { }

	private void StartChildrenAnimLoop(List<ViewBase> listView, int LabelHash, bool isSelf) { }

	public void StartChildrenAnimLoop(int startLabelHash, int endLabelHash, bool isSelf) { }

	private void StartChildrenAnimLoopFrame(List<ViewBase> listView, int start, int end, bool isSelf) { }

	public void StartChildrenAnimLoopFrame(int start, int end, bool isSelf) { }

	private void StartSiblingAnim(CallbackSetAnim callback) { }

	public void StartSiblingAnimDecoLoop() { }

	public void StartSiblingAnimDecoOnce() { }

	public void StartSiblingAnimDefault() { }

	public void StartSiblingAnimGoStop(string startLabel) { }

	public void StartSiblingAnimGoStop(string startLabel, string endLabel) { }

	public void StartSiblingAnimGoStop(int startLabelHash, int endLabelHash) { }

	public void StartSiblingAnimGoStop(int startLabelHash) { }

	public void StartSiblingAnimGoStopFrame(int start, int end) { }

	public void StartSiblingAnimIn() { }

	public void StartSiblingAnimLoop(int startLabelHash, int endLabelHash) { }

	public void StartSiblingAnimLoop(string startLabel, string endLabel) { }

	public void StartSiblingAnimLoop(int startLabelHash) { }

	public void StartSiblingAnimLoop(string startLabel) { }

	public void StartSiblingAnimLoopFrame(int start, int end) { }

	public void StartSiblingAnimOut() { }

	private void StopAllAnim(List<ViewBase> listView) { }

	public void StopAllAnim() { }

	public void StopSiblingAnim() { }

	public override void UpdateAll(Color parentCol) { }

	public void UpdateAllAnimation(float dt) { }

}

