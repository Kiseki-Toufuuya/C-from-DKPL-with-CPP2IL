namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoCache
{
	internal string fullTypeName; //Field offset: 0x8
	internal string assemblyString; //Field offset: 0xC
	internal bool hasTypeForwardedFrom; //Field offset: 0x10
	internal MemberInfo[] memberInfos; //Field offset: 0x14
	internal String[] memberNames; //Field offset: 0x18
	internal Type[] memberTypes; //Field offset: 0x1C

	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	internal SerObjectInfoCache(Type type) { }

}

