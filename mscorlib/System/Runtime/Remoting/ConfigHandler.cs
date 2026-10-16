namespace System.Runtime.Remoting;

internal class ConfigHandler : IContentHandler
{
	private ArrayList typeEntries; //Field offset: 0x8
	private ArrayList channelInstances; //Field offset: 0xC
	private ChannelData currentChannel; //Field offset: 0x10
	private Stack currentProviderData; //Field offset: 0x14
	private string currentClientUrl; //Field offset: 0x18
	private string appName; //Field offset: 0x1C
	private string currentXmlPath; //Field offset: 0x20
	private bool onlyDelayedChannels; //Field offset: 0x24

	public ConfigHandler(bool onlyDelayedChannels) { }

	private bool CheckPath(string path) { }

	private string ExtractAssembly(ref string type) { }

	private string GetNotNull(IAttrList attrs, string name) { }

	public override void OnChars(string ch) { }

	public override void OnEndElement(string name) { }

	public override void OnEndParsing(SmallXmlParser parser) { }

	public override void OnIgnorableWhitespace(string s) { }

	public override void OnProcessingInstruction(string name, string text) { }

	public override void OnStartElement(string name, IAttrList attrs) { }

	public override void OnStartParsing(SmallXmlParser parser) { }

	public void ParseElement(string name, IAttrList attrs) { }

	private TimeSpan ParseTime(string s) { }

	private void ReadChannel(IAttrList attrs, bool isTemplate) { }

	private void ReadClientActivated(IAttrList attrs) { }

	private void ReadClientWellKnown(IAttrList attrs) { }

	private void ReadCustomProviderData(string name, IAttrList attrs) { }

	private void ReadInteropXml(IAttrList attrs, bool isElement) { }

	private void ReadLifetine(IAttrList attrs) { }

	private void ReadPreload(IAttrList attrs) { }

	private ProviderData ReadProvider(string name, IAttrList attrs, bool isTemplate) { }

	private void ReadServiceActivated(IAttrList attrs) { }

	private void ReadServiceWellKnown(IAttrList attrs) { }

	private void ValidatePath(string element, String[] paths) { }

}

