namespace UnityEngine.UIElements;

internal sealed class VisualTreeUpdater : IDisposable
{
	[DefaultMember("Item")]
	private class UpdaterArray
	{
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x8

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 36
			 set { } //Length: 95
		}

		public IVisualTreeUpdater Item
		{
			 get { } //Length: 36
		}

		public UpdaterArray() { }

		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		public IVisualTreeUpdater get_Item(int index) { }

		public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	}

	private BaseVisualElementPanel m_Panel; //Field offset: 0x8
	private UpdaterArray m_UpdaterArray; //Field offset: 0xC

	public VisualTreeUpdater(BaseVisualElementPanel panel) { }

	public override void Dispose() { }

	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private void SetDefaultUpdaters() { }

	public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}

