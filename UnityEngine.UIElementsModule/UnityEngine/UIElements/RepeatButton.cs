namespace UnityEngine.UIElements;

public class RepeatButton : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlLongAttributeDescription m_Delay; //Field offset: 0x68
		private UxmlLongAttributeDescription m_Interval; //Field offset: 0x6C

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private Clickable m_Clickable; //Field offset: 0x408
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x40C

	internal bool acceptClicksIfDisabled
	{
		internal set { } //Length: 51
	}

	private static RepeatButton() { }

	public RepeatButton() { }

	public RepeatButton(Action clickEvent, long delay, long interval) { }

	internal void AddAction(Action clickEvent) { }

	internal void set_acceptClicksIfDisabled(bool value) { }

	public void SetAction(Action clickEvent, long delay, long interval) { }

}

