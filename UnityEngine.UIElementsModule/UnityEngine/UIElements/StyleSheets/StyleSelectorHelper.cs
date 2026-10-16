namespace UnityEngine.UIElements.StyleSheets;

internal static class StyleSelectorHelper
{
	private struct SelectorWorkItem
	{
		public OrderedSelectorType type; //Field offset: 0x0
		public string input; //Field offset: 0x4

		public SelectorWorkItem(OrderedSelectorType type, string input) { }

	}


	private static void FastLookup(IDictionary<String, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	private static void TestSelectorLinkedList(StyleComplexSelector currentComplexSelector, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, ref SelectorMatchRecord record) { }

}

