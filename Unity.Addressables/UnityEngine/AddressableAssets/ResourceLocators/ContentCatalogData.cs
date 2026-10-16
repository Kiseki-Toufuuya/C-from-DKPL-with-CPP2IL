namespace UnityEngine.AddressableAssets.ResourceLocators;

public class ContentCatalogData
{
	public class AssetBundleRequestOptionsSerializationAdapter : ISerializationAdapter<AssetBundleRequestOptions>, ISerializationAdapter
	{
		private struct SerializedData
		{
			internal struct Common
			{
				public short timeout; //Field offset: 0x0
				public byte redirectLimit; //Field offset: 0x2
				public byte retryCount; //Field offset: 0x3
				public int flags; //Field offset: 0x4

				public AssetLoadMode assetLoadMode
				{
					 get { } //Length: 14
					 set { } //Length: 20
				}

				public bool chunkedTransfer
				{
					 get { } //Length: 15
					 set { } //Length: 25
				}

				public bool clearOtherCachedVersionsWhenLoaded
				{
					 get { } //Length: 16
					 set { } //Length: 26
				}

				public bool useCrcForCachedBundle
				{
					 get { } //Length: 16
					 set { } //Length: 26
				}

				public bool useUnityWebRequestForLocalBundles
				{
					 get { } //Length: 16
					 set { } //Length: 26
				}

				public AssetLoadMode get_assetLoadMode() { }

				public bool get_chunkedTransfer() { }

				public bool get_clearOtherCachedVersionsWhenLoaded() { }

				public bool get_useCrcForCachedBundle() { }

				public bool get_useUnityWebRequestForLocalBundles() { }

				public void set_assetLoadMode(AssetLoadMode value) { }

				public void set_chunkedTransfer(bool value) { }

				public void set_clearOtherCachedVersionsWhenLoaded(bool value) { }

				public void set_useCrcForCachedBundle(bool value) { }

				public void set_useUnityWebRequestForLocalBundles(bool value) { }

			}

			public uint hashId; //Field offset: 0x0
			public uint bundleNameId; //Field offset: 0x4
			public uint crc; //Field offset: 0x8
			public uint bundleSize; //Field offset: 0xC
			public uint commonId; //Field offset: 0x10

		}


		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			 get { } //Length: 3
		}

		public AssetBundleRequestOptionsSerializationAdapter() { }

		public override object Deserialize(Reader reader, Type type, uint offset) { }

		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		public override uint Serialize(Writer writer, object obj) { }

	}

	public class ResourceLocator : IResourceLocator
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<ResourceLocation, LocateProcContext> <>9__21_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			internal void <Locate>b__21_0(ResourceLocation loc, LocateProcContext context) { }

		}

		private struct CacheKey : IEquatable<CacheKey>
		{
			public object key; //Field offset: 0x0
			public Type type; //Field offset: 0x4
			private int hashCode; //Field offset: 0x8

			public CacheKey(object o, Type t) { }

			public override bool Equals(CacheKey other) { }

			public virtual int GetHashCode() { }

		}

		public class ContentCatalogDataEntrySerializationContext
		{
			public ContentCatalogDataEntry entry; //Field offset: 0x8
			public Dictionary<Object, List`1<Int32>> keyToEntryIndices; //Field offset: 0xC
			public IList<ContentCatalogDataEntry> allEntries; //Field offset: 0x10

			public ContentCatalogDataEntrySerializationContext() { }

		}

		internal struct Header
		{
			public int magic; //Field offset: 0x0
			public int version; //Field offset: 0x4
			public uint keysOffset; //Field offset: 0x8
			public uint idOffset; //Field offset: 0xC
			public uint instanceProvider; //Field offset: 0x10
			public uint sceneProvider; //Field offset: 0x14
			public uint initObjectsArray; //Field offset: 0x18
			public uint buildResultHash; //Field offset: 0x1C

		}

		internal struct KeyData
		{
			public uint keyNameOffset; //Field offset: 0x0
			public uint locationSetOffset; //Field offset: 0x4

		}

		private class LocateProcContext
		{
			public IList<IResourceLocation> locations; //Field offset: 0x8
			public Type type; //Field offset: 0xC

			public LocateProcContext() { }

		}

		public class ResourceLocation : IResourceLocation
		{
			internal class Serializer : ISerializationAdapter<ResourceLocation>, ISerializationAdapter, ISerializationAdapter<ContentCatalogDataEntrySerializationContext>
			{
				internal struct Data
				{
					public uint primaryKeyOffset; //Field offset: 0x0
					public uint internalIdOffset; //Field offset: 0x4
					public uint providerOffset; //Field offset: 0x8
					public uint dependencySetOffset; //Field offset: 0xC
					public int dependencyHashValue; //Field offset: 0x10
					public uint extraDataOffset; //Field offset: 0x14
					public uint typeId; //Field offset: 0x18

				}


				public override IEnumerable<ISerializationAdapter> Dependencies
				{
					 get { } //Length: 3
				}

				public Serializer() { }

				public override object Deserialize(Reader reader, Type t, uint offset) { }

				public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

				public override uint Serialize(Writer writer, object val) { }

			}

			[CompilerGenerated]
			private string <InternalId>k__BackingField; //Field offset: 0x8
			[CompilerGenerated]
			private string <ProviderId>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			private IList<IResourceLocation> <Dependencies>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private int <DependencyHashCode>k__BackingField; //Field offset: 0x14
			[CompilerGenerated]
			private object <Data>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			private string <PrimaryKey>k__BackingField; //Field offset: 0x1C
			[CompilerGenerated]
			private Type <ResourceType>k__BackingField; //Field offset: 0x20

			public internal override object Data
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public internal override IList<IResourceLocation> Dependencies
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public internal override int DependencyHashCode
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 14
			}

			public override bool HasDependencies
			{
				 get { } //Length: 15
			}

			public internal override string InternalId
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public internal override string PrimaryKey
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public internal override string ProviderId
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public internal override Type ResourceType
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 27
			}

			public ResourceLocation(Reader reader, uint id) { }

			[CompilerGenerated]
			public override object get_Data() { }

			[CompilerGenerated]
			public override IList<IResourceLocation> get_Dependencies() { }

			[CompilerGenerated]
			public override int get_DependencyHashCode() { }

			public override bool get_HasDependencies() { }

			[CompilerGenerated]
			public override string get_InternalId() { }

			[CompilerGenerated]
			public override string get_PrimaryKey() { }

			[CompilerGenerated]
			public override string get_ProviderId() { }

			[CompilerGenerated]
			public override Type get_ResourceType() { }

			public override int Hash(Type resultType) { }

			[CompilerGenerated]
			internal void set_Data(object value) { }

			[CompilerGenerated]
			internal void set_Dependencies(IList<IResourceLocation> value) { }

			[CompilerGenerated]
			internal void set_DependencyHashCode(int value) { }

			[CompilerGenerated]
			internal void set_InternalId(string value) { }

			[CompilerGenerated]
			internal void set_PrimaryKey(string value) { }

			[CompilerGenerated]
			internal void set_ProviderId(string value) { }

			[CompilerGenerated]
			internal void set_ResourceType(Type value) { }

			public virtual string ToString() { }

		}

		private LRUCache<CacheKey, IList`1<IResourceLocation>> m_Cache; //Field offset: 0x8
		private Dictionary<Object, UInt32> keyData; //Field offset: 0x20
		private Reader reader; //Field offset: 0x24
		[CompilerGenerated]
		private string <LocatorId>k__BackingField; //Field offset: 0x28
		private string providerSuffix; //Field offset: 0x2C
		private LocateProcContext sharedContext; //Field offset: 0x30

		public override IEnumerable<IResourceLocation> AllLocations
		{
			 get { } //Length: 712
		}

		public override IEnumerable<Object> Keys
		{
			 get { } //Length: 64
		}

		public private override string LocatorId
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 27
		}

		internal ResourceLocator(string id, Reader reader, int cacheLimit, string providerSuffix) { }

		public override IEnumerable<IResourceLocation> get_AllLocations() { }

		public override IEnumerable<Object> get_Keys() { }

		[CompilerGenerated]
		public override string get_LocatorId() { }

		public void GetCacheStats(out int locReqCount, out int locReqHits, out int readerReqCount, out int readerReqHits) { }

		public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

		[CompilerGenerated]
		private void set_LocatorId(string value) { }

	}

	public class Serializer : ISerializationAdapter<ContentCatalogData>, ISerializationAdapter
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public UInt32[] locationIds; //Field offset: 0x8
			public Func<Int32, UInt32> <>9__0; //Field offset: 0xC

			public <>c__DisplayClass3_0() { }

			internal uint <Serialize>b__0(int i) { }

		}


		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			 get { } //Length: 348
		}

		public Serializer() { }

		public override object Deserialize(Reader reader, Type t, uint offset) { }

		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		public override uint Serialize(Writer writer, object val) { }

	}

	private static int kMagic; //Field offset: 0x0
	private const int kVersion = 2; //Field offset: 0x0
	public string LocalHash; //Field offset: 0x8
	internal IResourceLocation location; //Field offset: 0xC
	[SerializeField]
	internal string m_LocatorId; //Field offset: 0x10
	[SerializeField]
	internal string m_BuildResultHash; //Field offset: 0x14
	[SerializeField]
	private ObjectInitializationData m_InstanceProviderData; //Field offset: 0x18
	[SerializeField]
	private ObjectInitializationData m_SceneProviderData; //Field offset: 0x30
	[SerializeField]
	internal List<ObjectInitializationData> m_ResourceProviderData; //Field offset: 0x48
	private IList<ContentCatalogDataEntry> m_Entries; //Field offset: 0x4C
	private Reader m_Reader; //Field offset: 0x50

	public string BuildResultHash
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ObjectInitializationData InstanceProviderData
	{
		 get { } //Length: 28
		 set { } //Length: 40
	}

	public internal string ProviderId
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public List<ObjectInitializationData> ResourceProviderData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ObjectInitializationData SceneProviderData
	{
		 get { } //Length: 28
		 set { } //Length: 40
	}

	private static ContentCatalogData() { }

	internal ContentCatalogData(Reader reader) { }

	public ContentCatalogData() { }

	public ContentCatalogData(string id) { }

	internal void CleanData() { }

	internal void CopyToFile(string path) { }

	internal IResourceLocator CreateCustomLocator(string overrideId = "", string providerSuffix = null, int locatorCacheSize = 32) { }

	public string get_BuildResultHash() { }

	public ObjectInitializationData get_InstanceProviderData() { }

	public string get_ProviderId() { }

	public List<ObjectInitializationData> get_ResourceProviderData() { }

	public ObjectInitializationData get_SceneProviderData() { }

	internal Byte[] GetBytes() { }

	internal static ContentCatalogData LoadFromFile(string path) { }

	public void set_BuildResultHash(string value) { }

	public void set_InstanceProviderData(ObjectInitializationData value) { }

	internal void set_ProviderId(string value) { }

	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	public void set_SceneProviderData(ObjectInitializationData value) { }

}

