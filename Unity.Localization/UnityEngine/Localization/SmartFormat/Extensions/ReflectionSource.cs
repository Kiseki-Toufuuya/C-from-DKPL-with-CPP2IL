namespace UnityEngine.Localization.SmartFormat.Extensions;

public class ReflectionSource : ISource
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string selector; //Field offset: 0x8
		public ISelectorInfo selectorInfo; //Field offset: 0xC

		public <>c__DisplayClass5_0() { }

		internal bool <TryEvaluateSelector>b__0(MemberInfo m) { }

	}

	private static readonly Object[] k_Empty; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, "field", "method"})]
	private Dictionary<ValueTuple`2<Type, String>, ValueTuple`2<FieldInfo, MethodInfo>> m_TypeCache; //Field offset: 0x8

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, null, "field", "method"})]
	private Dictionary<ValueTuple`2<Type, String>, ValueTuple`2<FieldInfo, MethodInfo>> TypeCache
	{
		private get { } //Length: 101
	}

	private static ReflectionSource() { }

	public ReflectionSource(SmartFormatter formatter) { }

	private Dictionary<ValueTuple`2<Type, String>, ValueTuple`2<FieldInfo, MethodInfo>> get_TypeCache() { }

	public override bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

}

