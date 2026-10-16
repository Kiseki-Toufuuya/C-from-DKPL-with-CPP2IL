namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StyleSelector, String> <>9__24_0; //Field offset: 0x4
		public static Predicate<StyleSelectorPart> <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

		internal string <ToString>b__24_0(StyleSelector x) { }

	}

	private struct PseudoStateData
	{
		public readonly PseudoStates state; //Field offset: 0x0
		public readonly bool negate; //Field offset: 0x4

		public PseudoStateData(PseudoStates state, bool negate) { }

	}

	private static Dictionary<String, PseudoStateData> s_PseudoStates; //Field offset: 0x0
	private static List<StyleSelectorPart> m_HashList; //Field offset: 0x4
	public Hashes ancestorHashes; //Field offset: 0x8
	[SerializeField]
	private int m_Specificity; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleRule <rule>k__BackingField; //Field offset: 0x1C
	private bool m_isSimple; //Field offset: 0x20
	[SerializeField]
	private StyleSelector[] m_Selectors; //Field offset: 0x24
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int ruleIndex; //Field offset: 0x28
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleComplexSelector nextInTable; //Field offset: 0x2C
	internal int orderInStyleSheet; //Field offset: 0x30

	public bool isSimple
	{
		 get { } //Length: 11
	}

	public internal StyleRule rule
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 27
	}

	public internal StyleSelector[] selectors
	{
		 get { } //Length: 11
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 51
	}

	public int specificity
	{
		 get { } //Length: 11
	}

	private static StyleComplexSelector() { }

	public StyleComplexSelector() { }

	internal void CachePseudoStateMasks() { }

	internal void CalculateHashes() { }

	public bool get_isSimple() { }

	[CompilerGenerated]
	public StyleRule get_rule() { }

	public StyleSelector[] get_selectors() { }

	public int get_specificity() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_rule(StyleRule value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_selectors(StyleSelector[] value) { }

	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	public virtual string ToString() { }

}

