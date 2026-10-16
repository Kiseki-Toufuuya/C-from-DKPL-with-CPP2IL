namespace System.Runtime.Serialization.Json;

internal class JsonFormatWriterGenerator
{
	private class CriticalHelper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public ClassDataContract classContract; //Field offset: 0x8

			public <>c__DisplayClass0_0() { }

			internal void <GenerateClassWriter>b__0(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, ClassDataContract dataContract, XmlDictionaryString[] memberNames) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass1_0() { }

			internal void <GenerateCollectionWriter>b__0(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, CollectionDataContract dataContract) { }

		}


		public CriticalHelper() { }

		internal JsonFormatClassWriterDelegate GenerateClassWriter(ClassDataContract classContract) { }

		internal JsonFormatCollectionWriterDelegate GenerateCollectionWriter(CollectionDataContract collectionContract) { }

	}

	private CriticalHelper helper; //Field offset: 0x8

	public JsonFormatWriterGenerator() { }

	internal JsonFormatClassWriterDelegate GenerateClassWriter(ClassDataContract classContract) { }

	internal JsonFormatCollectionWriterDelegate GenerateCollectionWriter(CollectionDataContract collectionContract) { }

}

