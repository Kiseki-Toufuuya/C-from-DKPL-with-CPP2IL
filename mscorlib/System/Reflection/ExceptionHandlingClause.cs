namespace System.Reflection;

[ComVisible(True)]
public class ExceptionHandlingClause
{
	internal Type catch_type; //Field offset: 0x8
	internal int filter_offset; //Field offset: 0xC
	internal ExceptionHandlingClauseOptions flags; //Field offset: 0x10
	internal int try_offset; //Field offset: 0x14
	internal int try_length; //Field offset: 0x18
	internal int handler_offset; //Field offset: 0x1C
	internal int handler_length; //Field offset: 0x20

	protected ExceptionHandlingClause() { }

	public virtual string ToString() { }

}

