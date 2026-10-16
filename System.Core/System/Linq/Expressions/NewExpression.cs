namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
public class NewExpression : Expression
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0xC

	public ConstructorInfo Constructor
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[CompilerGenerated]
	public ConstructorInfo get_Constructor() { }

	public override Expression GetArgument(int index) { }

}

