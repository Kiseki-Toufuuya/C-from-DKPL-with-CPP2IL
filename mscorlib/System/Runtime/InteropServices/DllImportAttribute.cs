namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
public sealed class DllImportAttribute : Attribute
{
	internal string _val; //Field offset: 0x8
	public string EntryPoint; //Field offset: 0xC
	public CharSet CharSet; //Field offset: 0x10
	public bool SetLastError; //Field offset: 0x14
	public bool ExactSpelling; //Field offset: 0x15
	public bool PreserveSig; //Field offset: 0x16
	public CallingConvention CallingConvention; //Field offset: 0x18
	public bool BestFitMapping; //Field offset: 0x1C
	public bool ThrowOnUnmappableChar; //Field offset: 0x1D

	public string Value
	{
		 get { } //Length: 11
	}

	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	public DllImportAttribute(string dllName) { }

	public string get_Value() { }

	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	internal static bool IsDefined(RuntimeMethodInfo method) { }

}

