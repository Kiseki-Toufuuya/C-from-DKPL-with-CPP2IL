namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
{
	private readonly VisualElement m_Element; //Field offset: 0x0

	public int count
	{
		 get { } //Length: 70
	}

	internal VisualElementStyleSheetSet(VisualElement element) { }

	public void Add(StyleSheet styleSheet) { }

	public override bool Equals(VisualElementStyleSheetSet other) { }

	public virtual bool Equals(object obj) { }

	public int get_count() { }

	public virtual int GetHashCode() { }

	public void Insert(int index, StyleSheet styleSheet) { }

	public bool Remove(StyleSheet styleSheet) { }

}

