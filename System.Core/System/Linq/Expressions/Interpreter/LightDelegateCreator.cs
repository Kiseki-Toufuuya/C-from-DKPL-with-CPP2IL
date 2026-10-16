namespace System.Linq.Expressions.Interpreter;

internal sealed class LightDelegateCreator
{
	private readonly LambdaExpression _lambda; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; //Field offset: 0xC

	internal Interpreter Interpreter
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) { }

	public Delegate CreateDelegate() { }

	internal Delegate CreateDelegate(IStrongBox[] closure) { }

	[CompilerGenerated]
	internal Interpreter get_Interpreter() { }

}

