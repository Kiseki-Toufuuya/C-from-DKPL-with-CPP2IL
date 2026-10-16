namespace UnityEngine.Localization;

[UxmlObject]
public abstract class LocalizedAssetBase : LocalizedReference
{
	[CompilerGenerated]
	internal abstract class UxmlSerializedData : UxmlSerializedData
	{

		protected UxmlSerializedData() { }

	}


	protected LocalizedAssetBase() { }

	public abstract AsyncOperationHandle<Object> LoadAssetAsObjectAsync() { }

	public abstract AsyncOperationHandle<TObject> LoadAssetAsync() { }

}

