namespace UnityEngine.Localization.Pseudo;

public class Encapsulator : IPseudoLocalizationMethod
{
	[SerializeField]
	private string m_Start; //Field offset: 0x8
	[SerializeField]
	private string m_End; //Field offset: 0xC

	public string End
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string Start
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Encapsulator() { }

	public string get_End() { }

	public string get_Start() { }

	public void set_End(string value) { }

	public void set_Start(string value) { }

	public override void Transform(Message message) { }

}

