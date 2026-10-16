namespace UnityEngine.Localization.SmartFormat.Core.Extensions;

public abstract class FormatterBase : IFormatter, ISerializationCallbackReceiver
{
	[SerializeField]
	private String[] m_Names; //Field offset: 0x8

	public abstract String[] DefaultNames
	{
		 get { } //Length: 0
	}

	public override String[] Names
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected FormatterBase() { }

	public abstract String[] get_DefaultNames() { }

	public override String[] get_Names() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override void set_Names(String[] value) { }

	public abstract bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

}

