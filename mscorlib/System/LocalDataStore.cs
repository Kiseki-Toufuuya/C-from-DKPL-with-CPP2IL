namespace System;

internal sealed class LocalDataStore
{
	private LocalDataStoreElement[] m_DataTable; //Field offset: 0x8
	private LocalDataStoreMgr m_Manager; //Field offset: 0xC

	public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) { }

	internal void Dispose() { }

	internal void FreeData(int slot, long cookie) { }

	public object GetData(LocalDataStoreSlot slot) { }

	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

	public void SetData(LocalDataStoreSlot slot, object data) { }

}

