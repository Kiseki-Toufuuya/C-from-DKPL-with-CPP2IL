namespace System.Runtime.Serialization.Diagnostics.Application;

internal class TD
{
	private static ResourceManager resourceManager; //Field offset: 0x0
	private static CultureInfo resourceCulture; //Field offset: 0x4
	private static EventDescriptor[] eventDescriptors; //Field offset: 0x8
	private static object syncLock; //Field offset: 0xC
	private static bool eventDescriptorsCreated; //Field offset: 0x10

	internal static CultureInfo Culture
	{
		internal get { } //Length: 61
		internal set { } //Length: 89
	}

	private static ResourceManager ResourceManager
	{
		private get { } //Length: 282
	}

	private static TD() { }

	private TD() { }

	private static void CreateEventDescriptors() { }

	internal static void DCDeserializeWithSurrogateStart(string SurrogateType) { }

	internal static bool DCDeserializeWithSurrogateStartIsEnabled() { }

	internal static void DCDeserializeWithSurrogateStop() { }

	internal static bool DCDeserializeWithSurrogateStopIsEnabled() { }

	internal static void DCGenReaderStart(string Kind, string TypeName) { }

	internal static bool DCGenReaderStartIsEnabled() { }

	internal static void DCGenReaderStop() { }

	internal static bool DCGenReaderStopIsEnabled() { }

	internal static void DCGenWriterStart(string Kind, string TypeName) { }

	internal static bool DCGenWriterStartIsEnabled() { }

	internal static void DCGenWriterStop() { }

	internal static bool DCGenWriterStopIsEnabled() { }

	internal static void DCJsonGenReaderStart(string Kind, string TypeName) { }

	internal static bool DCJsonGenReaderStartIsEnabled() { }

	internal static void DCJsonGenReaderStop() { }

	internal static bool DCJsonGenReaderStopIsEnabled() { }

	internal static void DCJsonGenWriterStart(string Kind, string TypeName) { }

	internal static bool DCJsonGenWriterStartIsEnabled() { }

	internal static void DCJsonGenWriterStop() { }

	internal static bool DCJsonGenWriterStopIsEnabled() { }

	internal static void DCResolverResolve(string TypeName) { }

	internal static bool DCResolverResolveIsEnabled() { }

	internal static void DCSerializeWithSurrogateStart(string SurrogateType) { }

	internal static bool DCSerializeWithSurrogateStartIsEnabled() { }

	internal static void DCSerializeWithSurrogateStop() { }

	internal static bool DCSerializeWithSurrogateStopIsEnabled() { }

	private static void EnsureEventDescriptors() { }

	internal static void GenXmlSerializableStart(string DCType) { }

	internal static bool GenXmlSerializableStartIsEnabled() { }

	internal static void GenXmlSerializableStop() { }

	internal static bool GenXmlSerializableStopIsEnabled() { }

	internal static CultureInfo get_Culture() { }

	private static ResourceManager get_ResourceManager() { }

	internal static void ImportKnownTypesStart() { }

	internal static bool ImportKnownTypesStartIsEnabled() { }

	internal static void ImportKnownTypesStop() { }

	internal static bool ImportKnownTypesStopIsEnabled() { }

	private static bool IsEtwEventEnabled(int eventIndex) { }

	internal static void ReaderQuotaExceeded(string param0) { }

	internal static bool ReaderQuotaExceededIsEnabled() { }

	internal static void set_Culture(CultureInfo value) { }

	private static bool WriteEtwEvent(int eventIndex, EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3) { }

	private static bool WriteEtwEvent(int eventIndex, EventTraceActivity eventParam0, string eventParam1, string eventParam2) { }

	private static bool WriteEtwEvent(int eventIndex, EventTraceActivity eventParam0, string eventParam1) { }

}

