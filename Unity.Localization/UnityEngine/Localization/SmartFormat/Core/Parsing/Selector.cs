namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public class Selector : FormatItem
{
	private string m_Operator; //Field offset: 0x20
	internal int operatorStart; //Field offset: 0x24
	[CompilerGenerated]
	private int <SelectorIndex>k__BackingField; //Field offset: 0x28

	public string Operator
	{
		 get { } //Length: 65
	}

	public internal int SelectorIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public Selector() { }

	public virtual void Clear() { }

	public string get_Operator() { }

	[CompilerGenerated]
	public int get_SelectorIndex() { }

	[CompilerGenerated]
	internal void set_SelectorIndex(int value) { }

}

