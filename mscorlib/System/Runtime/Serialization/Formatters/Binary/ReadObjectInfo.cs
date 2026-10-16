namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ReadObjectInfo
{
	internal static int readObjectInfoCounter; //Field offset: 0x0
	internal int objectInfoId; //Field offset: 0x8
	internal Type objectType; //Field offset: 0xC
	internal ObjectManager objectManager; //Field offset: 0x10
	internal int count; //Field offset: 0x14
	internal bool isSi; //Field offset: 0x18
	internal bool isNamed; //Field offset: 0x19
	internal bool isTyped; //Field offset: 0x1A
	internal bool bSimpleAssembly; //Field offset: 0x1B
	internal SerObjectInfoCache cache; //Field offset: 0x1C
	internal String[] wireMemberNames; //Field offset: 0x20
	internal Type[] wireMemberTypes; //Field offset: 0x24
	private int lastPosition; //Field offset: 0x28
	internal ISerializationSurrogate serializationSurrogate; //Field offset: 0x2C
	internal StreamingContext context; //Field offset: 0x30
	internal List<Type> memberTypesList; //Field offset: 0x38
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x3C
	internal IFormatterConverter formatterConverter; //Field offset: 0x40

	internal ReadObjectInfo() { }

	internal void AddValue(string name, object value, ref SerializationInfo si, ref Object[] memberData) { }

	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal static ReadObjectInfo Create(Type objectType, String[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal MemberInfo GetMemberInfo(string name) { }

	internal Type GetMemberType(MemberInfo objMember) { }

	internal Type[] GetMemberTypes(String[] inMemberNames, Type objectType) { }

	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	internal Type GetType(string name) { }

	internal void Init(Type objectType, String[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	internal void InitDataStore(ref SerializationInfo si, ref Object[] memberData) { }

	private void InitMemberInfo() { }

	private void InitNoMembers() { }

	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	private void InitSiRead() { }

	internal void ObjectEnd() { }

	internal void PopulateObjectMembers(object obj, Object[] memberData) { }

	private int Position(string name) { }

	internal void PrepareForReuse() { }

	internal void RecordFixup(long objectId, string name, long idRef) { }

}

