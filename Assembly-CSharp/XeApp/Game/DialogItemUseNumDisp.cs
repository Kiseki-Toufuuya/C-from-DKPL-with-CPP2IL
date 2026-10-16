namespace XeApp.Game;

public class DialogItemUseNumDisp : DispBase
{
	private Transform m_parent; //Field offset: 0x114
	private GameObject m_frame; //Field offset: 0x118
	private TextMeshProUGUI m_text; //Field offset: 0x11C

	public DialogItemUseNumDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void InitializeText(string text) { }

	protected virtual void LateUpdate() { }

	public void SetParent(GameObject root, string parent) { }

	protected virtual void UpdateDispMain() { }

}

