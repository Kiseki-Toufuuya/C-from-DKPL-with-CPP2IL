namespace XeSys;

public static class XmlUtil
{

	public static bool GetBoolAttribute(XmlReader reader, string key, bool defValue = false) { }

	public static string GetElementAttribute(XmlElement elem, string key, string noValue) { }

	public static bool GetElementFlag(XmlElement elem, string tag, string defValue = "0") { }

	public static float GetElementFloatValue(XmlElement elem, string tag, string defValue = "0") { }

	public static int GetElementIntValue(XmlElement elem, string tag, string defValue = "0") { }

	public static string GetElementString(XmlElement elem, string tag, string defValue = "0") { }

	public static float GetFloatAttribute(XmlReader reader, string key, float defValue = 0) { }

	public static int GetIntAttribute(XmlReader reader, string key, int defValue = 0) { }

	public static string GetStringAttribute(XmlReader reader, string key, string defValue = "") { }

	public static bool IsEndElement(XmlReader reader, string key) { }

}

