namespace System.Runtime.Remoting;

internal class ProviderData
{
	internal string Ref; //Field offset: 0x8
	internal string Type; //Field offset: 0xC
	internal string Id; //Field offset: 0x10
	internal Hashtable CustomProperties; //Field offset: 0x14
	internal IList CustomData; //Field offset: 0x18

	public ProviderData() { }

	public void CopyFrom(ProviderData other) { }

}

