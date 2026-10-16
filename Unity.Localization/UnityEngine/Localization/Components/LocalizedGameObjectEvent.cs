namespace UnityEngine.Localization.Components;

[AddComponentMenu("Localization/Asset/Localize Prefab Event")]
public class LocalizedGameObjectEvent : LocalizedAssetEvent<GameObject, LocalizedGameObject, UnityEventGameObject>
{
	private GameObject m_Current; //Field offset: 0x1C

	public LocalizedGameObjectEvent() { }

	protected virtual void UpdateAsset(GameObject localizedAsset) { }

}

