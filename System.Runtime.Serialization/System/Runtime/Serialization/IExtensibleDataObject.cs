namespace System.Runtime.Serialization;

public interface IExtensibleDataObject
{

	public ExtensionDataObject ExtensionData
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ExtensionDataObject get_ExtensionData() { }

	public void set_ExtensionData(ExtensionDataObject value) { }

}

