namespace Google.Protobuf.Reflection;

internal sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GeneratedCodeInfo <.cctor>b__26_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0

				private static <>c() { }

				public <>c() { }

				internal Annotation <.cctor>b__53_0() { }

			}

			private static readonly MessageParser<Annotation> _parser; //Field offset: 0x0
			public const int PathFieldNumber = 1; //Field offset: 0x0
			public const int SourceFileFieldNumber = 2; //Field offset: 0x0
			public const int BeginFieldNumber = 3; //Field offset: 0x0
			public const int EndFieldNumber = 4; //Field offset: 0x0
			private static readonly FieldCodec<Int32> _repeated_path_codec; //Field offset: 0x4
			private static readonly string SourceFileDefaultValue; //Field offset: 0x8
			private static readonly int BeginDefaultValue; //Field offset: 0xC
			private static readonly int EndDefaultValue; //Field offset: 0x10
			private UnknownFieldSet _unknownFields; //Field offset: 0x8
			private int _hasBits0; //Field offset: 0xC
			private readonly RepeatedField<Int32> path_; //Field offset: 0x10
			private string sourceFile_; //Field offset: 0x14
			private int begin_; //Field offset: 0x18
			private int end_; //Field offset: 0x1C

			[DebuggerNonUserCode]
			public int Begin
			{
				 get { } //Length: 79
				 set { } //Length: 18
			}

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 105
			}

			[DebuggerNonUserCode]
			public int End
			{
				 get { } //Length: 79
				 set { } //Length: 18
			}

			[DebuggerNonUserCode]
			public bool HasBegin
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool HasEnd
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public bool HasSourceFile
			{
				 get { } //Length: 15
			}

			[DebuggerNonUserCode]
			public static MessageParser<Annotation> Parser
			{
				 get { } //Length: 60
			}

			[DebuggerNonUserCode]
			public RepeatedField<Int32> Path
			{
				 get { } //Length: 11
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 154
			}

			[DebuggerNonUserCode]
			public string SourceFile
			{
				 get { } //Length: 75
				 set { } //Length: 83
			}

			private static Annotation() { }

			[DebuggerNonUserCode]
			public Annotation() { }

			[DebuggerNonUserCode]
			public Annotation(Annotation other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public void ClearBegin() { }

			[DebuggerNonUserCode]
			public void ClearEnd() { }

			[DebuggerNonUserCode]
			public void ClearSourceFile() { }

			[DebuggerNonUserCode]
			public override Annotation Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(Annotation other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public int get_Begin() { }

			public static MessageDescriptor get_Descriptor() { }

			public int get_End() { }

			public bool get_HasBegin() { }

			public bool get_HasEnd() { }

			public bool get_HasSourceFile() { }

			public static MessageParser<Annotation> get_Parser() { }

			public RepeatedField<Int32> get_Path() { }

			public string get_SourceFile() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(Annotation other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_Begin(int value) { }

			public void set_End(int value) { }

			public void set_SourceFile(string value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<GeneratedCodeInfo> _parser; //Field offset: 0x0
	public const int AnnotationFieldNumber = 1; //Field offset: 0x0
	private static readonly FieldCodec<Annotation> _repeated_annotation_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private readonly RepeatedField<Annotation> annotation_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public RepeatedField<Annotation> Annotation
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<GeneratedCodeInfo> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 60
	}

	private static GeneratedCodeInfo() { }

	[DebuggerNonUserCode]
	public GeneratedCodeInfo() { }

	[DebuggerNonUserCode]
	public GeneratedCodeInfo(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GeneratedCodeInfo Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(GeneratedCodeInfo other) { }

	public RepeatedField<Annotation> get_Annotation() { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<GeneratedCodeInfo> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

