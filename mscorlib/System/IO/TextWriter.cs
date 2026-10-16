namespace System.IO;

public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__59_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <WriteAsync>b__59_0(object state) { }

	}

	private sealed class NullTextWriter : TextWriter
	{

		public virtual Encoding Encoding
		{
			 get { } //Length: 11
		}

		internal NullTextWriter() { }

		public virtual Encoding get_Encoding() { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(string value) { }

		public virtual void Write(char value) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(string value) { }

	}

	public sealed class SyncTextWriter : TextWriter, IDisposable
	{
		private readonly TextWriter _out; //Field offset: 0x18

		public virtual Encoding Encoding
		{
			 get { } //Length: 40
		}

		public virtual IFormatProvider FormatProvider
		{
			 get { } //Length: 40
		}

		public virtual string NewLine
		{
			 get { } //Length: 40
		}

		internal SyncTextWriter(TextWriter t) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual void Flush() { }

		public virtual Encoding get_Encoding() { }

		public virtual IFormatProvider get_FormatProvider() { }

		public virtual string get_NewLine() { }

		public virtual void Write(string value) { }

		public virtual void Write(Char[] buffer, int index, int count) { }

		public virtual void Write(Char[] buffer) { }

		public virtual void Write(char value) { }

		public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

		public virtual void WriteLine() { }

		public virtual void WriteLine(string value) { }

		public virtual void WriteLine(string format, object arg0) { }

		public virtual void WriteLine(string format, object arg0, object arg1) { }

		public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }

		public virtual void WriteLine(string format, Object[] arg) { }

	}

	public static readonly TextWriter Null; //Field offset: 0x0
	private static readonly Char[] s_coreNewLine; //Field offset: 0x4
	protected Char[] CoreNewLine; //Field offset: 0xC
	private string CoreNewLineStr; //Field offset: 0x10
	private IFormatProvider _internalFormatProvider; //Field offset: 0x14

	public abstract Encoding Encoding
	{
		 get { } //Length: 0
	}

	public override IFormatProvider FormatProvider
	{
		 get { } //Length: 78
	}

	public override string NewLine
	{
		 get { } //Length: 11
	}

	private static TextWriter() { }

	protected TextWriter() { }

	protected TextWriter(IFormatProvider formatProvider) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public override void Flush() { }

	public abstract Encoding get_Encoding() { }

	public override IFormatProvider get_FormatProvider() { }

	public override string get_NewLine() { }

	public static TextWriter Synchronized(TextWriter writer) { }

	public override void Write(string value) { }

	public override void Write(Char[] buffer, int index, int count) { }

	public override void Write(char value) { }

	public override void Write(Char[] buffer) { }

	public override Task WriteAsync(Char[] buffer, int index, int count) { }

	public override void WriteLine() { }

	public override void WriteLine(string value) { }

	public override void WriteLine(string format, object arg0) { }

	public override void WriteLine(string format, object arg0, object arg1) { }

	public override void WriteLine(string format, object arg0, object arg1, object arg2) { }

	public override void WriteLine(string format, Object[] arg) { }

}

