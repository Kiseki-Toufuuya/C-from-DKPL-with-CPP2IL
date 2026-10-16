namespace System;

internal sealed class LocalDataStoreHolder
{
	private LocalDataStore m_Store; //Field offset: 0x8

	public LocalDataStore Store
	{
		 get { } //Length: 11
	}

	public LocalDataStoreHolder(LocalDataStore store) { }

	protected virtual void Finalize() { }

	public LocalDataStore get_Store() { }

}

