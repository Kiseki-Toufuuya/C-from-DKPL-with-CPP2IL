namespace System.Resources;

[ComVisible(True)]
public class ResourceManager
{
	public class CultureNameResourceSetPair
	{
		public string lastCultureName; //Field offset: 0x8
		public ResourceSet lastResourceSet; //Field offset: 0xC

		public CultureNameResourceSetPair() { }

	}

	public class ResourceManagerMediator
	{
		private ResourceManager _rm; //Field offset: 0x8

		internal string BaseName
		{
			internal get { } //Length: 40
		}

		internal string BaseNameField
		{
			internal get { } //Length: 23
		}

		internal RuntimeAssembly CallingAssembly
		{
			internal get { } //Length: 23
		}

		internal UltimateResourceFallbackLocation FallbackLoc
		{
			internal get { } //Length: 23
		}

		internal Type LocationInfo
		{
			internal get { } //Length: 23
		}

		internal bool LookedForSatelliteContractVersion
		{
			internal get { } //Length: 23
			internal set { } //Length: 26
		}

		internal RuntimeAssembly MainAssembly
		{
			internal get { } //Length: 113
		}

		internal string ModuleDir
		{
			internal get { } //Length: 23
		}

		internal CultureInfo NeutralResourcesCulture
		{
			internal get { } //Length: 23
		}

		internal Version SatelliteContractVersion
		{
			internal get { } //Length: 23
			internal set { } //Length: 39
		}

		internal Type UserResourceSet
		{
			internal get { } //Length: 23
		}

		internal ResourceManagerMediator(ResourceManager rm) { }

		internal string get_BaseName() { }

		internal string get_BaseNameField() { }

		internal RuntimeAssembly get_CallingAssembly() { }

		internal UltimateResourceFallbackLocation get_FallbackLoc() { }

		internal Type get_LocationInfo() { }

		internal bool get_LookedForSatelliteContractVersion() { }

		internal RuntimeAssembly get_MainAssembly() { }

		internal string get_ModuleDir() { }

		internal CultureInfo get_NeutralResourcesCulture() { }

		internal Version get_SatelliteContractVersion() { }

		internal Type get_UserResourceSet() { }

		internal string GetResourceFileName(CultureInfo culture) { }

		internal Version ObtainSatelliteContractVersion(Assembly a) { }

		internal void set_LookedForSatelliteContractVersion(bool value) { }

		internal void set_SatelliteContractVersion(Version value) { }

	}

	public static readonly int MagicNumber; //Field offset: 0x0
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	private static readonly Type _minResourceSet; //Field offset: 0x8
	internal static readonly string ResReaderTypeName; //Field offset: 0xC
	internal static readonly string ResSetTypeName; //Field offset: 0x10
	internal static readonly string MscorlibName; //Field offset: 0x14
	internal static readonly int DEBUG; //Field offset: 0x18
	protected string BaseNameField; //Field offset: 0x8
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; //Field offset: 0xC
	private Dictionary<String, ResourceSet> _resourceSets; //Field offset: 0x10
	private string moduleDir; //Field offset: 0x14
	protected Assembly MainAssembly; //Field offset: 0x18
	private Type _locationInfo; //Field offset: 0x1C
	private Type _userResourceSet; //Field offset: 0x20
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x24
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x28
	private bool _ignoreCase; //Field offset: 0x2C
	private bool UseManifest; //Field offset: 0x2D
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; //Field offset: 0x2E
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x30
	[OptionalField]
	private Version _satelliteContractVersion; //Field offset: 0x34
	[OptionalField]
	private bool _lookedForSatelliteContractVersion; //Field offset: 0x38
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; //Field offset: 0x3C
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x40
	private IResourceGroveler resourceGroveler; //Field offset: 0x44

	public override string BaseName
	{
		 get { } //Length: 11
	}

	protected UltimateResourceFallbackLocation FallbackLocation
	{
		 get { } //Length: 11
	}

	private static ResourceManager() { }

	protected ResourceManager() { }

	public ResourceManager(string baseName, Assembly assembly) { }

	private static void AddResourceSet(Dictionary<String, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	private void CommonAssemblyInit() { }

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	public override string get_BaseName() { }

	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	protected override string GetResourceFileName(CultureInfo culture) { }

	protected static Version GetSatelliteContractVersion(Assembly a) { }

	public override string GetString(string name, CultureInfo culture) { }

	private void Init() { }

	protected override ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	private void SetAppXConfiguration() { }

}

