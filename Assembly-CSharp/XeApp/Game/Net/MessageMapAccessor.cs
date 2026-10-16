namespace XeApp.Game.Net;

public class MessageMapAccessor
{
	public static MessageMapAccessor DefaultInstance; //Field offset: 0x0
	private StringBuilder sb; //Field offset: 0x8

	private static MessageMapAccessor() { }

	public MessageMapAccessor() { }

	public string CreateLabel(string name, string columName, int itemValue) { }

	public string GetHeqetMessage(string label) { }

	public string GetMasterMessage(string name, string columName, int itemValue) { }

	public string GetMenuMessage(string label) { }

	public string GetMessage(IMessageMapContext messageMapContext, string name, string columName, int itemValue) { }

	public string GetMessageByLabel(IMessageMapContext messageMapContext, string label) { }

	public string GetRomMessage(string label) { }

}

