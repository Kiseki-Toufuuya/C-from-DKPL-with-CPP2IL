namespace UnityEngine.UIElements;

internal class DefaultGroupManager : IGroupManager
{
	private List<IGroupBoxOption> m_GroupOptions; //Field offset: 0x8
	private IGroupBoxOption m_SelectedOption; //Field offset: 0xC
	private IGroupBox m_GroupBox; //Field offset: 0x10

	public DefaultGroupManager() { }

	public override void Init(IGroupBox groupBox) { }

	public override void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	public override void RegisterOption(IGroupBoxOption option) { }

	public override void UnregisterOption(IGroupBoxOption option) { }

}

