namespace System.Net;

internal class WebRequestPrefixElement
{
	public string Prefix; //Field offset: 0x8
	internal IWebRequestCreate creator; //Field offset: 0xC
	internal Type creatorType; //Field offset: 0x10

	public IWebRequestCreate Creator
	{
		 get { } //Length: 459
		 set { } //Length: 27
	}

	public WebRequestPrefixElement(string P, IWebRequestCreate C) { }

	public IWebRequestCreate get_Creator() { }

	public void set_Creator(IWebRequestCreate value) { }

}

