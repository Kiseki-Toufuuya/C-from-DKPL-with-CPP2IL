namespace System.Runtime.Serialization;

internal class CodeTypeReference
{
	private string baseType; //Field offset: 0x8
	[OptionalField]
	private bool isInterface; //Field offset: 0xC
	private int arrayRank; //Field offset: 0x10
	private CodeTypeReference arrayElementType; //Field offset: 0x14
	[OptionalField]
	private List<CodeTypeReference> typeArguments; //Field offset: 0x18
	[OptionalField]
	private CodeTypeReferenceOptions referenceOptions; //Field offset: 0x1C
	[OptionalField]
	private bool needsFixup; //Field offset: 0x20

	public CodeTypeReference ArrayElementType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int ArrayRank
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string BaseType
	{
		 get { } //Length: 251
		 set { } //Length: 43
	}

	internal bool IsInterface
	{
		internal get { } //Length: 11
	}

	internal int NestedArrayDepth
	{
		internal get { } //Length: 32
	}

	[ComVisible(False)]
	public CodeTypeReferenceOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[ComVisible(False)]
	public List<CodeTypeReference> TypeArguments
	{
		 get { } //Length: 142
	}

	public CodeTypeReference() { }

	public CodeTypeReference(Type type) { }

	public CodeTypeReference(Type type, CodeTypeReferenceOptions codeTypeReferenceOption) { }

	public CodeTypeReference(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption) { }

	public CodeTypeReference(string typeName) { }

	public CodeTypeReference(CodeTypeReference arrayType, int rank) { }

	public CodeTypeReference(string baseType, int rank) { }

	public CodeTypeReference(string typeName, CodeTypeReference[] typeArguments) { }

	public CodeTypeReference get_ArrayElementType() { }

	public int get_ArrayRank() { }

	public string get_BaseType() { }

	internal bool get_IsInterface() { }

	internal int get_NestedArrayDepth() { }

	public CodeTypeReferenceOptions get_Options() { }

	public List<CodeTypeReference> get_TypeArguments() { }

	private void Initialize(string typeName) { }

	private void Initialize(string typeName, CodeTypeReferenceOptions options) { }

	private void InitializeFromType(Type type) { }

	private string RipOffAssemblyInformationFromTypeName(string typeName) { }

	public void set_ArrayElementType(CodeTypeReference value) { }

	public void set_ArrayRank(int value) { }

	public void set_BaseType(string value) { }

	public void set_Options(CodeTypeReferenceOptions value) { }

}

