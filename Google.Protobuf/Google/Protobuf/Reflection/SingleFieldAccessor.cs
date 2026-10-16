namespace Google.Protobuf.Reflection;

internal sealed class SingleFieldAccessor : FieldAccessorBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IMessage, Boolean> <>9__3_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__3_0(IMessage message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public object defaultValue; //Field offset: 0x8
		public SingleFieldAccessor <>4__this; //Field offset: 0xC

		public <>c__DisplayClass3_0() { }

		internal void <.ctor>b__1(IMessage message) { }

	}

	private readonly Action<IMessage, Object> setValueDelegate; //Field offset: 0x10
	private readonly Action<IMessage> clearDelegate; //Field offset: 0x14
	private readonly Func<IMessage, Boolean> hasDelegate; //Field offset: 0x18

	internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) { }

	public virtual void Clear(IMessage message) { }

	public virtual bool HasValue(IMessage message) { }

	public virtual void SetValue(IMessage message, object value) { }

}

