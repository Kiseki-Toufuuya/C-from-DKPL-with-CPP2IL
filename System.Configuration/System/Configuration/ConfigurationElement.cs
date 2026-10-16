namespace System.Configuration;

[DefaultMember("Item")]
public abstract class ConfigurationElement
{

	protected private override ConfigurationPropertyCollection Properties
	{
		private get { } //Length: 40
	}

	protected private override ConfigurationPropertyCollection get_Properties() { }

	protected private override bool IsModified() { }

	protected override void PostDeserialize() { }

	protected override void PreSerialize(XmlWriter writer) { }

	protected private override void Reset(ConfigurationElement parentElement) { }

	protected private override void ResetModified() { }

}

