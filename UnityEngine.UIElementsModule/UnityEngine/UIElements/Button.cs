namespace UnityEngine.UIElements;

public class Button : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlImageAttributeDescription m_IconImage; //Field offset: 0x68

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId iconImageProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x4C
	public static readonly string iconUssClassName; //Field offset: 0x50
	public static readonly string iconOnlyUssClassName; //Field offset: 0x54
	public static readonly string imageUSSClassName; //Field offset: 0x58
	private static readonly string NonEmptyString; //Field offset: 0x5C
	private Clickable m_Clickable; //Field offset: 0x408
	private TextElement m_TextElement; //Field offset: 0x40C
	private Image m_ImageElement; //Field offset: 0x410
	private Background m_IconImage; //Field offset: 0x414
	private string m_Text; //Field offset: 0x424

	public Clickable clickable
	{
		 get { } //Length: 14
		 set { } //Length: 107
	}

	[CreateProperty]
	public Background iconImage
	{
		 get { } //Length: 21
		 set { } //Length: 880
	}

	public virtual string text
	{
		 get { } //Length: 28
		 set { } //Length: 336
	}

	private static Button() { }

	public Button() { }

	public Button(Background iconImage, Action clickEvent = null) { }

	public Button(Action clickEvent) { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	public Clickable get_clickable() { }

	public Background get_iconImage() { }

	public virtual string get_text() { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	private void ResetButtonHierarchy() { }

	public void set_clickable(Clickable value) { }

	public void set_iconImage(Background value) { }

	public virtual void set_text(string value) { }

	private void UpdateButtonHierarchy() { }

}

