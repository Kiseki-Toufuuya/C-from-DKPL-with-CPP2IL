namespace UnityEngine.UI;

public class SelectableSwitchObject : SelectableEx
{
	[SerializeField]
	private GameObject _NormalObject; //Field offset: 0xC4
	[SerializeField]
	private GameObject _SelectedObject; //Field offset: 0xC8
	[SerializeField]
	private GameObject _DesabledObject; //Field offset: 0xCC

	public SelectableSwitchObject() { }

	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

}

