namespace System;

internal class UnitySerializationHolder : ISerializable, IObjectReference
{
	private Type[] m_instantiation; //Field offset: 0x8
	private Int32[] m_elementTypes; //Field offset: 0xC
	private int m_genericParameterPosition; //Field offset: 0x10
	private Type m_declaringType; //Field offset: 0x14
	private MethodBase m_declaringMethod; //Field offset: 0x18
	private string m_data; //Field offset: 0x1C
	private string m_assemblyName; //Field offset: 0x20
	private int m_unityType; //Field offset: 0x24

	internal UnitySerializationHolder(SerializationInfo info, StreamingContext context) { }

	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override object GetRealObject(StreamingContext context) { }

	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) { }

	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	internal Type MakeElementTypes(Type type) { }

	private void ThrowInsufficientInformation(string field) { }

}

