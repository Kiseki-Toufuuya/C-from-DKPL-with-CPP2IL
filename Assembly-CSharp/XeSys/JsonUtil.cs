namespace XeSys;

public class JsonUtil
{

	public JsonUtil() { }

	public static JsonData GetArray(JsonData jdata, string key) { }

	public static JsonData GetArrayObject(JsonData jdata, string key, int index) { }

	public static bool GetFlag(JsonData jdata, string key) { }

	public static bool GetFlag(JsonData jdata, string key, bool notExistValue) { }

	public static float GetFloat(JsonData jdata, string key, float notExistValue) { }

	public static float GetFloat(JsonData jdata, string key) { }

	public static int GetInt(JsonData jdata) { }

	public static int GetInt(JsonData jdata, string key, int notExistValue) { }

	public static int GetInt(JsonData jdata, string key) { }

	public static long GetLong(JsonData jdata) { }

	public static long GetLong(JsonData jdata, string key, long notExistValue) { }

	public static long GetLong(JsonData jdata, string key) { }

	public static JsonData GetObject(JsonData jdata, string key) { }

	public static string GetString(JsonData jdata, string key) { }

	public static string GetString(JsonData jdata, string key, string notExistValue) { }

	public static bool IsExist(JsonData from, string key) { }

	public static void WriteArray(JsonWriter writer, string arrayName, List<Object> objects) { }

	public static void WriteObject(JsonWriter writer, string objectName, Dictionary<String, Object> properties) { }

	public static void WriteValue(JsonWriter writer, string propertyName, object value) { }

}

