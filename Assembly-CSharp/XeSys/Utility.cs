namespace XeSys;

public class Utility
{
	private static DateTime UNIX_EPOCH; //Field offset: 0x0
	private static Regex s_regex; //Field offset: 0x8

	private static Utility() { }

	public Utility() { }

	public static int CalculateSdbmHash(Byte[] bytes, int initValue) { }

	public static int CalculateSdbmHash(Byte[] bytes) { }

	public static void DeepCopyTransform(Transform src, Transform dest) { }

	public static void DeleteDirectory(string path, bool recursive = true) { }

	public static void DeleteFile(string path) { }

	[Obsolete("Use DeleteFile()")]
	public static void DeleteFromStorage(string path) { }

	public static void DestroyMaterial(GameObject go) { }

	public static int EnumCount() { }

	public static bool ExistsDirectory(string path) { }

	public static bool ExistsFile(string path) { }

	[Obsolete("Use ExistsFile()")]
	public static bool ExistStorageFile(string path) { }

	public static GameObject FindGameObject(string name) { }

	public static void ForEachComponent(GameObject gobj, bool includeInactive, Action<T> action) { }

	public static string GetAsciiString(Byte[] bytes, ref int offset, int length) { }

	public static long GetCurrentUnixTime() { }

	public static DateTime GetDateTimeJST(long unixTime) { }

	public static string GetDayStringFromUNIXTime(long unix_time) { }

	public static string GetDayTimeStringFromUNIXTime(long unixTime) { }

	public static T GetGameObjectComponent(string gameObjectName) { }

	public static DateTime GetLocalDateTime(long unixTime) { }

	public static string GetRelativeTransformPath(Transform parent, Transform child) { }

	public static T GetSafeComponent(GameObject go) { }

	public static string GetString(Byte[] bytes, int length, ref int offset) { }

	public static string GetString(Byte[] bytes, ref int offset) { }

	public static long GetTargetUnixTime(int year, int month, int day, int hour, int minute, int second) { }

	public static long GetTargetUnixTimeJST(int year, int month, int day, int hour, int minute, int second) { }

	public static int GetTextLineCount(string text) { }

	public static string GetTimeStringFromUNIXTime(long unix_time) { }

	public static byte GetValueByte(Byte[] bytes, ref int offset) { }

	public static float GetValueFloat(Byte[] bytes, ref int offset) { }

	public static short GetValueInt16(Byte[] bytes, ref int offset) { }

	public static int GetValueInt32(Byte[] bytes, ref int offset) { }

	public static ushort GetValueUInt16(Byte[] bytes, ref int offset) { }

	public static uint GetValueUInt32(Byte[] bytes, ref int offset) { }

	public static int GetVersionValue(string versionString) { }

	public static bool IsAcrossDay(long prevUnixTime, long nextUnixTime) { }

	public static bool IsAcrossHour(long prevUnixTime, long nextUnixTime) { }

	public static bool IsActiveGameObject(GameObject go) { }

	public static bool IsPointerOverGameObject() { }

	public static bool IsRanged(int val, int min, int max) { }

	public static bool IsRanged(float val, float min, float max) { }

	public static bool IsWithinPeriod(long current, long start, long end) { }

	public static Byte[] LoadFromStorage(string path) { }

	public static string MakeMMSSsssTimeByMillisec(int milliSec) { }

	public static string MakeMMSSsssTimeBySec(float sec) { }

	public static string MakeWebsafeBase64(string input) { }

	public static string RemoveRichTextTag(string text) { }

	public static void ReplaceRichTextTag(ref string text) { }

	public static void SaveToStorage(string path, Byte[] bytes, bool overwrite) { }

	public static void SaveToStorage(string path, Byte[] bytes, int length, bool overwrite) { }

	public static T SearchComponentRecursively(string gameObjectName, Transform rootTform) { }

	public static object SearchContainsObject(Object[] list, string containsName) { }

	public static Transform SearchContainsTransformRecursively(string name, Transform root) { }

	public static GameObject SearchGameObjectRecursively(string name, Transform rootTrans) { }

	public static object SearchStartWithObject(Object[] list, string startName) { }

	public static List<Int32> SepalateDigit(int number) { }

	public static List<Int32> SepalateDigit(int number, List<Int32> inputList) { }

	public static List<Int32> SepalateDigitRev(int number, List<Int32> inputList) { }

	public static void SetActiveGameObject(GameObject go, bool active) { }

	public static void SetActiveGameObjectRecursively(GameObject go, bool flag) { }

	public static void SetLayerRecursively(GameObject go, int layer) { }

	public static float SqrDistance(Vector3 a, Vector3 b) { }

	public static void Swap(ref T lhs, ref T rhs) { }

	public static void UpdateToStorage(string path, Action<FileStream> callback) { }

}

