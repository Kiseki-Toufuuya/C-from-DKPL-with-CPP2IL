namespace UnityEngine.Localization.SmartFormat.Extensions;

public class TemplateFormatter : FormatterBase
{
	private class Template
	{
		public string name; //Field offset: 0x8
		public string text; //Field offset: 0xC
		[CompilerGenerated]
		private Format <Format>k__BackingField; //Field offset: 0x10

		public Format Format
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public Template() { }

		[CompilerGenerated]
		public Format get_Format() { }

		[CompilerGenerated]
		public void set_Format(Format value) { }

	}

	[SerializeField]
	private List<Template> m_Templates; //Field offset: 0xC
	private IDictionary<String, Format> m_TemplatesDict; //Field offset: 0x10
	private SmartFormatter m_Formatter; //Field offset: 0x14

	public virtual String[] DefaultNames
	{
		 get { } //Length: 140
	}

	public SmartFormatter Formatter
	{
		 get { } //Length: 36
		 set { } //Length: 27
	}

	private IDictionary<String, Format> Templates
	{
		private get { } //Length: 1090
	}

	public TemplateFormatter() { }

	public void Clear() { }

	public virtual String[] get_DefaultNames() { }

	public SmartFormatter get_Formatter() { }

	private IDictionary<String, Format> get_Templates() { }

	public virtual void OnAfterDeserialize() { }

	public void Register(string templateName, string template) { }

	public bool Remove(string templateName) { }

	public void set_Formatter(SmartFormatter value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

}

