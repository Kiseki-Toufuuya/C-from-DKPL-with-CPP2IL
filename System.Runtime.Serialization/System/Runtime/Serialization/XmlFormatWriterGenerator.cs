namespace System.Runtime.Serialization;

internal sealed class XmlFormatWriterGenerator
{
	private class CriticalHelper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public ClassDataContract classContract; //Field offset: 0x8

			public <>c__DisplayClass0_0() { }

			internal void <GenerateClassWriter>b__0(XmlWriterDelegator xw, object obj, XmlObjectSerializerWriteContext ctx, ClassDataContract ctr) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public CollectionDataContract collectionContract; //Field offset: 0x8

			public <>c__DisplayClass1_0() { }

			internal void <GenerateCollectionWriter>b__0(XmlWriterDelegator xw, object obj, XmlObjectSerializerWriteContext ctx, CollectionDataContract ctr) { }

		}


		public CriticalHelper() { }

		internal XmlFormatClassWriterDelegate GenerateClassWriter(ClassDataContract classContract) { }

		internal XmlFormatCollectionWriterDelegate GenerateCollectionWriter(CollectionDataContract collectionContract) { }

	}

	private CriticalHelper helper; //Field offset: 0x8

	public XmlFormatWriterGenerator() { }

	internal XmlFormatClassWriterDelegate GenerateClassWriter(ClassDataContract classContract) { }

	internal XmlFormatCollectionWriterDelegate GenerateCollectionWriter(CollectionDataContract collectionContract) { }

}

