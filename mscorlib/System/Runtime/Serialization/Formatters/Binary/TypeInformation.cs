namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class TypeInformation
{
	private string fullTypeName; //Field offset: 0x8
	private string assemblyString; //Field offset: 0xC
	private bool hasTypeForwardedFrom; //Field offset: 0x10

	internal string AssemblyString
	{
		internal get { } //Length: 11
	}

	internal string FullTypeName
	{
		internal get { } //Length: 11
	}

	internal bool HasTypeForwardedFrom
	{
		internal get { } //Length: 11
	}

	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	internal string get_AssemblyString() { }

	internal string get_FullTypeName() { }

	internal bool get_HasTypeForwardedFrom() { }

}

