namespace Live2D.Cubism.Framework.Json;

public class CubismJsonParser
{
	private Char[] buffer; //Field offset: 0x8
	private int length; //Field offset: 0xC
	private int line_count; //Field offset: 0x10
	private Value root; //Field offset: 0x14

	public CubismJsonParser(Char[] jsonBytes) { }

	public Value Parse() { }

	private Value ParseArray(Char[] buffer, int length, int pos, Int32[] endPos) { }

	public static Value ParseFromBytes(Char[] jsonBytes) { }

	public static Value ParseFromString(string jsonString) { }

	private Value ParseObject(Char[] buffer, int length, int pos, Int32[] endPos) { }

	private static string ParseString(Char[] str, int length, int pos, Int32[] endPos) { }

	private Value ParseValue(Char[] buffer, int length, int pos, Int32[] endPos) { }

	public static double strToDouble(Char[] str, int length, int pos, Int32[] endPos) { }

}

