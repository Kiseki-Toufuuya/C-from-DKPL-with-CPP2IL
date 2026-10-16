namespace System.Runtime.CompilerServices;

public static class FormattableStringFactory
{
	private sealed class ConcreteFormattableString : FormattableString
	{
		private readonly string _format; //Field offset: 0x8
		private readonly Object[] _arguments; //Field offset: 0xC

		public virtual int ArgumentCount
		{
			 get { } //Length: 23
		}

		public virtual string Format
		{
			 get { } //Length: 11
		}

		internal ConcreteFormattableString(string format, Object[] arguments) { }

		public virtual int get_ArgumentCount() { }

		public virtual string get_Format() { }

		public virtual object GetArgument(int index) { }

		public virtual Object[] GetArguments() { }

		public virtual string ToString(IFormatProvider formatProvider) { }

	}


	public static FormattableString Create(string format, Object[] arguments) { }

}

