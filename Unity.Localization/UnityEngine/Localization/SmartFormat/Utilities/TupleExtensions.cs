namespace UnityEngine.Localization.SmartFormat.Utilities;

[Extension]
public static class TupleExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Type> <>9__4_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Type <GetValueTupleItemTypes>b__4_0(FieldInfo f) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public object tuple; //Field offset: 0x8

		public <>c__DisplayClass3_0() { }

		internal object <GetValueTupleItemObjects>b__0(FieldInfo f) { }

	}

	[CompilerGenerated]
	private sealed class <GetValueTupleItemObjectsFlattened>d__6 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private object tuple; //Field offset: 0x14
		public object <>3__tuple; //Field offset: 0x18
		private IEnumerator<Object> <>7__wrap1; //Field offset: 0x1C
		private IEnumerator<Object> <>7__wrap2; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetValueTupleItemObjectsFlattened>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly HashSet<Type> ValueTupleTypes; //Field offset: 0x0

	private static TupleExtensions() { }

	[Extension]
	public static List<FieldInfo> GetValueTupleItemFields(Type tupleType) { }

	[Extension]
	public static IEnumerable<Object> GetValueTupleItemObjects(object tuple) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetValueTupleItemObjectsFlattened>d__6))]
	public static IEnumerable<Object> GetValueTupleItemObjectsFlattened(object tuple) { }

	[Extension]
	public static IEnumerable<Type> GetValueTupleItemTypes(Type tupleType) { }

	[Extension]
	public static bool IsValueTuple(object obj) { }

	[Extension]
	public static bool IsValueTupleType(Type type) { }

}

