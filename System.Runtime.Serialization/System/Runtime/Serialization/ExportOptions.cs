namespace System.Runtime.Serialization;

public class ExportOptions
{
	private Collection<Type> knownTypes; //Field offset: 0x8
	private IDataContractSurrogate dataContractSurrogate; //Field offset: 0xC

	public IDataContractSurrogate DataContractSurrogate
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Collection<Type> KnownTypes
	{
		 get { } //Length: 101
	}

	public ExportOptions() { }

	public IDataContractSurrogate get_DataContractSurrogate() { }

	public Collection<Type> get_KnownTypes() { }

	internal IDataContractSurrogate GetSurrogate() { }

	public void set_DataContractSurrogate(IDataContractSurrogate value) { }

}

