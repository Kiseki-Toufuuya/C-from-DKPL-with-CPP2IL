namespace UnityEngine.Localization.Tables;

public class AssetTableEntry : TableEntry
{
	[CompilerGenerated]
	private AsyncOperationHandle<Object[]> <PreloadAsyncOperation>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private AsyncOperationHandle <AsyncOperation>k__BackingField; //Field offset: 0x20
	private string m_GuidCache; //Field offset: 0x2C
	private string m_SubAssetNameCache; //Field offset: 0x30

	public string Address
	{
		 get { } //Length: 23
		 set { } //Length: 77
	}

	internal AsyncOperationHandle AsyncOperation
	{
		[CompilerGenerated]
		internal get { } //Length: 26
		[CompilerGenerated]
		internal set { } //Length: 38
	}

	public string Guid
	{
		 get { } //Length: 173
		 set { } //Length: 77
	}

	public bool IsEmpty
	{
		 get { } //Length: 33
	}

	public bool IsSubAsset
	{
		 get { } //Length: 80
	}

	internal AsyncOperationHandle<Object[]> PreloadAsyncOperation
	{
		[CompilerGenerated]
		internal get { } //Length: 26
		[CompilerGenerated]
		internal set { } //Length: 38
	}

	public string SubAssetName
	{
		 get { } //Length: 183
	}

	internal AssetTableEntry() { }

	public string get_Address() { }

	[CompilerGenerated]
	internal AsyncOperationHandle get_AsyncOperation() { }

	public string get_Guid() { }

	public bool get_IsEmpty() { }

	public bool get_IsSubAsset() { }

	[CompilerGenerated]
	internal AsyncOperationHandle<Object[]> get_PreloadAsyncOperation() { }

	public string get_SubAssetName() { }

	internal Type GetExpectedType() { }

	public void RemoveFromTable() { }

	public void set_Address(string value) { }

	[CompilerGenerated]
	internal void set_AsyncOperation(AsyncOperationHandle value) { }

	public void set_Guid(string value) { }

	[CompilerGenerated]
	internal void set_PreloadAsyncOperation(AsyncOperationHandle<Object[]> value) { }

	public void SetAssetOverride(T asset) { }

}

