namespace System.Runtime.CompilerServices;

[AttributeUsage(71)]
[ComVisible(True)]
public class CompilationRelaxationsAttribute : Attribute
{
	private int m_relaxations; //Field offset: 0x8

	public int CompilationRelaxations
	{
		 get { } //Length: 11
	}

	public CompilationRelaxationsAttribute(int relaxations) { }

	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) { }

	public int get_CompilationRelaxations() { }

}

