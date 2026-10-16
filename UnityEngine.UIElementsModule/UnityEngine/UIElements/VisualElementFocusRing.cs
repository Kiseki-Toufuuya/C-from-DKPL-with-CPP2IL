namespace UnityEngine.UIElements;

public class VisualElementFocusRing : IFocusRing
{
	internal enum DefaultFocusOrder
	{
		ChildOrder = 0,
		PositionXY = 1,
		PositionYX = 2,
	}

	private class FocusRingRecord
	{
		public int m_AutoIndex; //Field offset: 0x8
		public Focusable m_Focusable; //Field offset: 0xC
		public bool m_IsSlot; //Field offset: 0x10
		public List<FocusRingRecord> m_ScopeNavigationOrder; //Field offset: 0x14

		public FocusRingRecord() { }

	}

	private readonly VisualElement root; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; //Field offset: 0xC
	private List<FocusRingRecord> m_FocusRing; //Field offset: 0x10

	public DefaultFocusOrder defaultFocusOrder
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private FocusController focusController
	{
		private get { } //Length: 40
	}

	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = 0) { }

	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) { }

	private void DoUpdate() { }

	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	[CompilerGenerated]
	public DefaultFocusOrder get_defaultFocusOrder() { }

	private FocusController get_focusController() { }

	private int GetFocusableInternalIndex(Focusable f) { }

	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }

	[CompilerGenerated]
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) { }

}

