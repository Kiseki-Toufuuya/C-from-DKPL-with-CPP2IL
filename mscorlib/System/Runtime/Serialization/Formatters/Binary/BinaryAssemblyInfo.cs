namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryAssemblyInfo
{
	internal string assemblyString; //Field offset: 0x8
	private Assembly assembly; //Field offset: 0xC

	internal BinaryAssemblyInfo(string assemblyString) { }

	internal BinaryAssemblyInfo(string assemblyString, Assembly assembly) { }

	internal Assembly GetAssembly() { }

}

