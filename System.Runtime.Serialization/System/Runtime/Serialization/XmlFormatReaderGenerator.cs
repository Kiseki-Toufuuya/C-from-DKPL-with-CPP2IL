namespace System.Runtime.Serialization;

internal sealed class XmlFormatReaderGenerator
{
	private class CriticalHelper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public ClassDataContract classContract; //Field offset: 0x8

			public <>c__DisplayClass0_0() { }

			internal object <GenerateClassReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContext ctx, XmlDictionaryString[] memberNames, XmlDictionaryString[] memberNamespaces) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass1_0() { }

			internal object <GenerateCollectionReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContext ctx, XmlDictionaryString inm, XmlDictionaryString ins, CollectionDataContract cc) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass2_0() { }

			internal void <GenerateGetOnlyCollectionReader>b__0(XmlReaderDelegator xr, XmlObjectSerializerReadContext ctx, XmlDictionaryString inm, XmlDictionaryString ins, CollectionDataContract cc) { }

		}


		public CriticalHelper() { }

		internal XmlFormatClassReaderDelegate GenerateClassReader(ClassDataContract classContract) { }

		internal XmlFormatCollectionReaderDelegate GenerateCollectionReader(CollectionDataContract collectionContract) { }

		internal XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(CollectionDataContract collectionContract) { }

	}

	private CriticalHelper helper; //Field offset: 0x8

	public XmlFormatReaderGenerator() { }

	public XmlFormatClassReaderDelegate GenerateClassReader(ClassDataContract classContract) { }

	public XmlFormatCollectionReaderDelegate GenerateCollectionReader(CollectionDataContract collectionContract) { }

	public XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(CollectionDataContract collectionContract) { }

	internal static object UnsafeGetUninitializedObject(int id) { }

}

