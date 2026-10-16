namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class WriteObjectInfo
{
	internal int objectInfoId; //Field offset: 0x8
	internal object obj; //Field offset: 0xC
	internal Type objectType; //Field offset: 0x10
	internal bool isSi; //Field offset: 0x14
	internal bool isNamed; //Field offset: 0x15
	internal bool isTyped; //Field offset: 0x16
	internal bool isArray; //Field offset: 0x17
	internal SerializationInfo si; //Field offset: 0x18
	internal SerObjectInfoCache cache; //Field offset: 0x1C
	internal Object[] memberData; //Field offset: 0x20
	internal ISerializationSurrogate serializationSurrogate; //Field offset: 0x24
	internal StreamingContext context; //Field offset: 0x28
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x30
	internal long objectId; //Field offset: 0x38
	internal long assemId; //Field offset: 0x40
	private string binderTypeName; //Field offset: 0x48
	private string binderAssemblyString; //Field offset: 0x4C

	internal WriteObjectInfo() { }

	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	internal string GetAssemblyString() { }

	internal void GetMemberInfo(out String[] outMemberNames, out Type[] outMemberTypes, out Object[] outMemberData) { }

	internal Type GetMemberType(MemberInfo objMember) { }

	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	internal string GetTypeFullName() { }

	private void InitMemberInfo() { }

	private void InitNoMembers() { }

	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	private void InitSiWrite() { }

	private void InternalInit() { }

	private void InvokeSerializationBinder(SerializationBinder binder) { }

	internal void ObjectEnd() { }

	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

}

