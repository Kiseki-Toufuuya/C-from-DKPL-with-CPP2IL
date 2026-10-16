namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMap
{
	internal string objectName; //Field offset: 0x8
	internal Type objectType; //Field offset: 0xC
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x10
	internal Object[] typeInformationA; //Field offset: 0x14
	internal Type[] memberTypes; //Field offset: 0x18
	internal String[] memberNames; //Field offset: 0x1C
	internal ReadObjectInfo objectInfo; //Field offset: 0x20
	internal bool isInitObjectInfo; //Field offset: 0x24
	internal ObjectReader objectReader; //Field offset: 0x28
	internal int objectId; //Field offset: 0x2C
	internal BinaryAssemblyInfo assemblyInfo; //Field offset: 0x30

	internal ObjectMap(string objectName, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	internal ObjectMap(string objectName, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	internal static ObjectMap Create(string name, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	internal static ObjectMap Create(string name, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Object[] memberData) { }

}

