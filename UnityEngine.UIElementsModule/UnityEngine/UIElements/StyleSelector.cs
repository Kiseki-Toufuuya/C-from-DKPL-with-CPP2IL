namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleSelector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StyleSelectorPart, String> <>9__10_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__10_0(StyleSelectorPart p) { }

	}

	[SerializeField]
	private StyleSelectorPart[] m_Parts; //Field offset: 0x8
	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship; //Field offset: 0xC
	internal int pseudoStateMask; //Field offset: 0x10
	internal int negatedPseudoStateMask; //Field offset: 0x14

	public internal StyleSelectorPart[] parts
	{
		 get { } //Length: 11
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 27
	}

	public internal StyleSelectorRelationship previousRelationship
	{
		 get { } //Length: 11
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 14
	}

	public StyleSelector() { }

	public StyleSelectorPart[] get_parts() { }

	public StyleSelectorRelationship get_previousRelationship() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_parts(StyleSelectorPart[] value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	public virtual string ToString() { }

}

