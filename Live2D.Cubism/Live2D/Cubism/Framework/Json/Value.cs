namespace Live2D.Cubism.Framework.Json;

public class Value
{
	private object _object; //Field offset: 0x8

	public Value(object obj) { }

	public Value Get(string key) { }

	public Value Get(int index) { }

	public Dictionary<String, Value> GetMap(Dictionary<String, Value> defalutV) { }

	public List<Value> GetVector(List<Value> defalutV) { }

	public bool isArray() { }

	public bool isBoolean() { }

	public bool isDouble() { }

	public bool isMap() { }

	public bool isNull() { }

	public bool isString() { }

	public List<String> KeySet() { }

	public double ToDouble() { }

	public double ToDouble(double defaultValue) { }

	public float ToFloat(float defaultValue) { }

	public float ToFloat() { }

	public int toInt(int defaultValue) { }

	public int toInt() { }

	public Dictionary<String, Value> ToMap() { }

	public string toString(string indent) { }

	public string toString() { }

}

