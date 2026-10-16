namespace System.Xml.Schema;

internal class LocatedActiveAxis : ActiveAxis
{
	private int column; //Field offset: 0x18
	internal bool isMatched; //Field offset: 0x1C
	internal KeySequence Ks; //Field offset: 0x20

	internal int Column
	{
		internal get { } //Length: 11
	}

	internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column) { }

	internal int get_Column() { }

	internal void Reactivate(KeySequence ks) { }

}

