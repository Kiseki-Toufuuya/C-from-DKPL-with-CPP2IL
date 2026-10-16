namespace System.Xml.Schema;

internal class KSStruct
{
	public int depth; //Field offset: 0x8
	public KeySequence ks; //Field offset: 0xC
	public LocatedActiveAxis[] fields; //Field offset: 0x10

	public KSStruct(KeySequence ks, int dim) { }

}

