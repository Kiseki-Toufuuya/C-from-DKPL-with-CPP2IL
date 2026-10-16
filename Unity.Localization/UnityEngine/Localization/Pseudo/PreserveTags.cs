namespace UnityEngine.Localization.Pseudo;

public class PreserveTags : IPseudoLocalizationMethod
{
	[SerializeField]
	private char m_Opening; //Field offset: 0x8
	[SerializeField]
	private char m_Closing; //Field offset: 0xA

	public char Closing
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public char Opening
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public PreserveTags() { }

	public char get_Closing() { }

	public char get_Opening() { }

	public void set_Closing(char value) { }

	public void set_Opening(char value) { }

	public override void Transform(Message message) { }

}

