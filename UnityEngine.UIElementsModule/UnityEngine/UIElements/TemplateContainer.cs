namespace UnityEngine.UIElements;

[HideInInspector]
[UxmlElement("Instance")]
public class TemplateContainer : BindableElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{

		public virtual string uxmlName
		{
			 get { } //Length: 35
		}

		public virtual string uxmlQualifiedName
		{
			 get { } //Length: 95
		}

		public UxmlFactory() { }

		public virtual string get_uxmlName() { }

		public virtual string get_uxmlQualifiedName() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Template; //Field offset: 0x48

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId templateIdProperty; //Field offset: 0x0
	internal static readonly BindingId templateSourceProperty; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <templateId>k__BackingField; //Field offset: 0x370
	private VisualElement m_ContentContainer; //Field offset: 0x374
	private VisualTreeAsset m_TemplateSource; //Field offset: 0x378

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	[CreateProperty(ReadOnly = True)]
	public private string templateId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	[CreateProperty(ReadOnly = True)]
	public internal VisualTreeAsset templateSource
	{
		 get { } //Length: 14
		internal set { } //Length: 33
	}

	private static TemplateContainer() { }

	public TemplateContainer() { }

	public TemplateContainer(string templateId) { }

	internal TemplateContainer(string templateId, VisualTreeAsset templateSource) { }

	public virtual VisualElement get_contentContainer() { }

	[CompilerGenerated]
	public string get_templateId() { }

	public VisualTreeAsset get_templateSource() { }

	[CompilerGenerated]
	private void set_templateId(string value) { }

	internal void set_templateSource(VisualTreeAsset value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetContentContainer(VisualElement content) { }

}

