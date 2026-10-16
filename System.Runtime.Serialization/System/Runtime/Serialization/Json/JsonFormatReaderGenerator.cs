namespace System.Runtime.Serialization.Json;

internal sealed class JsonFormatReaderGenerator
{
	private class CriticalHelper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public ClassDataContract classContract; //Field offset: 0x8

			public <>c__DisplayClass0_0() { }

			internal object <GenerateClassReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContextComplexJson ctx, XmlDictionaryString emptyDictionaryString, XmlDictionaryString[] memberNames) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass1_0() { }

			internal object <GenerateCollectionReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContextComplexJson ctx, XmlDictionaryString emptyDS, XmlDictionaryString inm, CollectionDataContract cc) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass2_0() { }

			internal void <GenerateGetOnlyCollectionReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContextComplexJson ctx, XmlDictionaryString emptyDS, XmlDictionaryString inm, CollectionDataContract cc) { }

		}


		public CriticalHelper() { }

		internal JsonFormatClassReaderDelegate GenerateClassReader(ClassDataContract classContract) { }

		internal JsonFormatCollectionReaderDelegate GenerateCollectionReader(CollectionDataContract collectionContract) { }

		internal JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(CollectionDataContract collectionContract) { }

	}

	private CriticalHelper helper; //Field offset: 0x8

	public JsonFormatReaderGenerator() { }

	public JsonFormatClassReaderDelegate GenerateClassReader(ClassDataContract classContract) { }

	public JsonFormatCollectionReaderDelegate GenerateCollectionReader(CollectionDataContract collectionContract) { }

	public JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(CollectionDataContract collectionContract) { }

}

