namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression
{
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; //Field offset: 0xC

	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public NewExpression NewExpression
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[CompilerGenerated]
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	[CompilerGenerated]
	public NewExpression get_NewExpression() { }

}

