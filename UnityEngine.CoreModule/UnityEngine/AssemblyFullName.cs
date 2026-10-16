namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyFullName
{
	[NativeName("name")]
	public string Name; //Field offset: 0x0
	[NativeName("version")]
	public AssemblyVersion Version; //Field offset: 0x4
	[NativeName("publicKeyToken")]
	public string PublicKeyToken; //Field offset: 0xC
	[NativeName("culture")]
	public string Culture; //Field offset: 0x10

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

