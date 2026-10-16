namespace Google.Protobuf.Reflection;

internal sealed class FileOptions : IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FileOptions <.cctor>b__211_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum OptimizeMode
		{
			Speed = 1,
			CodeSize = 2,
			LiteRuntime = 3,
		}


	}

	private static readonly MessageParser<FileOptions> _parser; //Field offset: 0x0
	public const int PhpClassPrefixFieldNumber = 40; //Field offset: 0x0
	public const int SwiftPrefixFieldNumber = 39; //Field offset: 0x0
	public const int PhpMetadataNamespaceFieldNumber = 44; //Field offset: 0x0
	public const int CsharpNamespaceFieldNumber = 37; //Field offset: 0x0
	public const int ObjcClassPrefixFieldNumber = 36; //Field offset: 0x0
	public const int RubyPackageFieldNumber = 45; //Field offset: 0x0
	public const int CcEnableArenasFieldNumber = 31; //Field offset: 0x0
	public const int DeprecatedFieldNumber = 23; //Field offset: 0x0
	public const int UninterpretedOptionFieldNumber = 999; //Field offset: 0x0
	public const int PhpGenericServicesFieldNumber = 42; //Field offset: 0x0
	public const int PyGenericServicesFieldNumber = 18; //Field offset: 0x0
	public const int JavaGenericServicesFieldNumber = 17; //Field offset: 0x0
	public const int CcGenericServicesFieldNumber = 16; //Field offset: 0x0
	public const int GoPackageFieldNumber = 11; //Field offset: 0x0
	public const int OptimizeForFieldNumber = 9; //Field offset: 0x0
	public const int PhpNamespaceFieldNumber = 41; //Field offset: 0x0
	public const int JavaPackageFieldNumber = 1; //Field offset: 0x0
	public const int JavaOuterClassnameFieldNumber = 8; //Field offset: 0x0
	public const int JavaGenerateEqualsAndHashFieldNumber = 20; //Field offset: 0x0
	public const int JavaStringCheckUtf8FieldNumber = 27; //Field offset: 0x0
	public const int JavaMultipleFilesFieldNumber = 10; //Field offset: 0x0
	private static readonly string JavaPackageDefaultValue; //Field offset: 0x4
	private static readonly string JavaOuterClassnameDefaultValue; //Field offset: 0x8
	private static readonly bool JavaMultipleFilesDefaultValue; //Field offset: 0xC
	private static readonly bool JavaGenerateEqualsAndHashDefaultValue; //Field offset: 0xD
	private static readonly bool JavaStringCheckUtf8DefaultValue; //Field offset: 0xE
	private static readonly OptimizeMode OptimizeForDefaultValue; //Field offset: 0x10
	private static readonly string GoPackageDefaultValue; //Field offset: 0x14
	private static readonly bool CcGenericServicesDefaultValue; //Field offset: 0x18
	private static readonly bool JavaGenericServicesDefaultValue; //Field offset: 0x19
	private static readonly bool PyGenericServicesDefaultValue; //Field offset: 0x1A
	private static readonly bool PhpGenericServicesDefaultValue; //Field offset: 0x1B
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x1C
	private static readonly bool CcEnableArenasDefaultValue; //Field offset: 0x1D
	private static readonly string ObjcClassPrefixDefaultValue; //Field offset: 0x20
	private static readonly string CsharpNamespaceDefaultValue; //Field offset: 0x24
	private static readonly string SwiftPrefixDefaultValue; //Field offset: 0x28
	private static readonly string PhpClassPrefixDefaultValue; //Field offset: 0x2C
	private static readonly string PhpNamespaceDefaultValue; //Field offset: 0x30
	private static readonly string PhpMetadataNamespaceDefaultValue; //Field offset: 0x34
	private static readonly string RubyPackageDefaultValue; //Field offset: 0x38
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x3C
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	[CompilerGenerated]
	private CustomOptions <CustomOptions>k__BackingField; //Field offset: 0x10
	private string javaPackage_; //Field offset: 0x14
	private string javaOuterClassname_; //Field offset: 0x18
	private bool javaMultipleFiles_; //Field offset: 0x1C
	private bool javaGenerateEqualsAndHash_; //Field offset: 0x1D
	private bool javaStringCheckUtf8_; //Field offset: 0x1E
	private OptimizeMode optimizeFor_; //Field offset: 0x20
	private string goPackage_; //Field offset: 0x24
	private bool ccGenericServices_; //Field offset: 0x28
	private bool javaGenericServices_; //Field offset: 0x29
	private bool pyGenericServices_; //Field offset: 0x2A
	private bool phpGenericServices_; //Field offset: 0x2B
	private bool deprecated_; //Field offset: 0x2C
	private bool ccEnableArenas_; //Field offset: 0x2D
	private string objcClassPrefix_; //Field offset: 0x30
	private string csharpNamespace_; //Field offset: 0x34
	private string swiftPrefix_; //Field offset: 0x38
	private string phpClassPrefix_; //Field offset: 0x3C
	private string phpNamespace_; //Field offset: 0x40
	private string phpMetadataNamespace_; //Field offset: 0x44
	private string rubyPackage_; //Field offset: 0x48
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x4C

	[DebuggerNonUserCode]
	public bool CcEnableArenas
	{
		 get { } //Length: 82
		 set { } //Length: 21
	}

	[DebuggerNonUserCode]
	public bool CcGenericServices
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public string CsharpNamespace
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	internal CustomOptions CustomOptions
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public string GoPackage
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool HasCcEnableArenas
	{
		 get { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool HasCcGenericServices
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasCsharpNamespace
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasGoPackage
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	[Obsolete]
	public bool HasJavaGenerateEqualsAndHash
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJavaGenericServices
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJavaMultipleFiles
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJavaOuterClassname
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJavaPackage
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasJavaStringCheckUtf8
	{
		 get { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool HasObjcClassPrefix
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasOptimizeFor
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPhpClassPrefix
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPhpGenericServices
	{
		 get { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool HasPhpMetadataNamespace
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPhpNamespace
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasPyGenericServices
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasRubyPackage
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasSwiftPrefix
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	[Obsolete]
	public bool JavaGenerateEqualsAndHash
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool JavaGenericServices
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public bool JavaMultipleFiles
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public string JavaOuterClassname
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string JavaPackage
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool JavaStringCheckUtf8
	{
		 get { } //Length: 79
		 set { } //Length: 21
	}

	[DebuggerNonUserCode]
	public string ObjcClassPrefix
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public OptimizeMode OptimizeFor
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageParser<FileOptions> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PhpClassPrefix
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool PhpGenericServices
	{
		 get { } //Length: 82
		 set { } //Length: 21
	}

	[DebuggerNonUserCode]
	public string PhpMetadataNamespace
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string PhpNamespace
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool PyGenericServices
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public string RubyPackage
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string SwiftPrefix
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption
	{
		 get { } //Length: 11
	}

	private static FileOptions() { }

	[DebuggerNonUserCode]
	public FileOptions() { }

	[DebuggerNonUserCode]
	public FileOptions(FileOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearCcEnableArenas() { }

	[DebuggerNonUserCode]
	public void ClearCcGenericServices() { }

	[DebuggerNonUserCode]
	public void ClearCsharpNamespace() { }

	[DebuggerNonUserCode]
	public void ClearDeprecated() { }

	[DebuggerNonUserCode]
	public void ClearGoPackage() { }

	[DebuggerNonUserCode]
	[Obsolete]
	public void ClearJavaGenerateEqualsAndHash() { }

	[DebuggerNonUserCode]
	public void ClearJavaGenericServices() { }

	[DebuggerNonUserCode]
	public void ClearJavaMultipleFiles() { }

	[DebuggerNonUserCode]
	public void ClearJavaOuterClassname() { }

	[DebuggerNonUserCode]
	public void ClearJavaPackage() { }

	[DebuggerNonUserCode]
	public void ClearJavaStringCheckUtf8() { }

	[DebuggerNonUserCode]
	public void ClearObjcClassPrefix() { }

	[DebuggerNonUserCode]
	public void ClearOptimizeFor() { }

	[DebuggerNonUserCode]
	public void ClearPhpClassPrefix() { }

	[DebuggerNonUserCode]
	public void ClearPhpGenericServices() { }

	[DebuggerNonUserCode]
	public void ClearPhpMetadataNamespace() { }

	[DebuggerNonUserCode]
	public void ClearPhpNamespace() { }

	[DebuggerNonUserCode]
	public void ClearPyGenericServices() { }

	[DebuggerNonUserCode]
	public void ClearRubyPackage() { }

	[DebuggerNonUserCode]
	public void ClearSwiftPrefix() { }

	[DebuggerNonUserCode]
	public override FileOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FileOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_CcEnableArenas() { }

	public bool get_CcGenericServices() { }

	public string get_CsharpNamespace() { }

	[CompilerGenerated]
	internal CustomOptions get_CustomOptions() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_GoPackage() { }

	public bool get_HasCcEnableArenas() { }

	public bool get_HasCcGenericServices() { }

	public bool get_HasCsharpNamespace() { }

	public bool get_HasDeprecated() { }

	public bool get_HasGoPackage() { }

	public bool get_HasJavaGenerateEqualsAndHash() { }

	public bool get_HasJavaGenericServices() { }

	public bool get_HasJavaMultipleFiles() { }

	public bool get_HasJavaOuterClassname() { }

	public bool get_HasJavaPackage() { }

	public bool get_HasJavaStringCheckUtf8() { }

	public bool get_HasObjcClassPrefix() { }

	public bool get_HasOptimizeFor() { }

	public bool get_HasPhpClassPrefix() { }

	public bool get_HasPhpGenericServices() { }

	public bool get_HasPhpMetadataNamespace() { }

	public bool get_HasPhpNamespace() { }

	public bool get_HasPyGenericServices() { }

	public bool get_HasRubyPackage() { }

	public bool get_HasSwiftPrefix() { }

	public bool get_JavaGenerateEqualsAndHash() { }

	public bool get_JavaGenericServices() { }

	public bool get_JavaMultipleFiles() { }

	public string get_JavaOuterClassname() { }

	public string get_JavaPackage() { }

	public bool get_JavaStringCheckUtf8() { }

	public string get_ObjcClassPrefix() { }

	public OptimizeMode get_OptimizeFor() { }

	public static MessageParser<FileOptions> get_Parser() { }

	public string get_PhpClassPrefix() { }

	public bool get_PhpGenericServices() { }

	public string get_PhpMetadataNamespace() { }

	public string get_PhpNamespace() { }

	public bool get_PyGenericServices() { }

	public string get_RubyPackage() { }

	public string get_SwiftPrefix() { }

	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FileOptions other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CcEnableArenas(bool value) { }

	public void set_CcGenericServices(bool value) { }

	public void set_CsharpNamespace(string value) { }

	[CompilerGenerated]
	private void set_CustomOptions(CustomOptions value) { }

	public void set_Deprecated(bool value) { }

	public void set_GoPackage(string value) { }

	public void set_JavaGenerateEqualsAndHash(bool value) { }

	public void set_JavaGenericServices(bool value) { }

	public void set_JavaMultipleFiles(bool value) { }

	public void set_JavaOuterClassname(string value) { }

	public void set_JavaPackage(string value) { }

	public void set_JavaStringCheckUtf8(bool value) { }

	public void set_ObjcClassPrefix(string value) { }

	public void set_OptimizeFor(OptimizeMode value) { }

	public void set_PhpClassPrefix(string value) { }

	public void set_PhpGenericServices(bool value) { }

	public void set_PhpMetadataNamespace(string value) { }

	public void set_PhpNamespace(string value) { }

	public void set_PyGenericServices(bool value) { }

	public void set_RubyPackage(string value) { }

	public void set_SwiftPrefix(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

