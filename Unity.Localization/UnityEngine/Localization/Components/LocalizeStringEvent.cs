namespace UnityEngine.Localization.Components;

[AddComponentMenu("Localization/Localize String Event")]
public class LocalizeStringEvent : LocalizedMonoBehaviour
{
	[SerializeField]
	private LocalizedString m_StringReference; //Field offset: 0x10
	[SerializeField]
	private List<Object> m_FormatArguments; //Field offset: 0x14
	[SerializeField]
	private UnityEventString m_UpdateString; //Field offset: 0x18
	private ChangeHandler m_ChangeHandler; //Field offset: 0x1C

	public UnityEventString OnUpdateString
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedString StringReference
	{
		 get { } //Length: 11
		 set { } //Length: 78
	}

	public LocalizeStringEvent() { }

	internal override void ClearChangeHandler() { }

	public UnityEventString get_OnUpdateString() { }

	public LocalizedString get_StringReference() { }

	private void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	private void OnValidate() { }

	public void RefreshString() { }

	internal override void RegisterChangeHandler() { }

	public void set_OnUpdateString(UnityEventString value) { }

	public void set_StringReference(LocalizedString value) { }

	public void SetEntry(string entryName) { }

	public void SetTable(string tableReference) { }

	protected override void UpdateString(string value) { }

}

