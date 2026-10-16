namespace UnityEngine.Localization.Components;

public class LocalizedAssetEvent : LocalizedAssetBehaviour<TObject, TReference>
{
	[SerializeField]
	private TEvent m_UpdateAsset; //Field offset: 0x0

	public TEvent OnUpdateAsset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedAssetEvent`3() { }

	public TEvent get_OnUpdateAsset() { }

	public void set_OnUpdateAsset(TEvent value) { }

	protected virtual void UpdateAsset(TObject localizedAsset) { }

}

