namespace System.Xml.Linq;

public class XObjectChangeEventArgs : EventArgs
{
	public static readonly XObjectChangeEventArgs Add; //Field offset: 0x0
	public static readonly XObjectChangeEventArgs Remove; //Field offset: 0x4
	public static readonly XObjectChangeEventArgs Name; //Field offset: 0x8
	public static readonly XObjectChangeEventArgs Value; //Field offset: 0xC
	private XObjectChange _objectChange; //Field offset: 0x8

	private static XObjectChangeEventArgs() { }

	public XObjectChangeEventArgs(XObjectChange objectChange) { }

}

