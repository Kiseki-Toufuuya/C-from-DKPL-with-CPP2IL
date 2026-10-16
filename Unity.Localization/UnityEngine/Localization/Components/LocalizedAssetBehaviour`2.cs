namespace UnityEngine.Localization.Components;

[ExecuteAlways]
public abstract class LocalizedAssetBehaviour : LocalizedMonoBehaviour
{
	[SerializeField]
	private TReference m_LocalizedAssetReference; //Field offset: 0x0
	private ChangeHandler<TObject> m_ChangeHandler; //Field offset: 0x0

	public TReference AssetReference
	{
		 get { } //Length: 11
		 set { } //Length: 78
	}

	protected LocalizedAssetBehaviour`2() { }

	internal override void ClearChangeHandler() { }

	public TReference get_AssetReference() { }

	private void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	private void OnValidate() { }

	internal override void RegisterChangeHandler() { }

	public void set_AssetReference(TReference value) { }

	protected abstract void UpdateAsset(TObject localizedAsset) { }

}

