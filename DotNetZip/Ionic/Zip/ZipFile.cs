namespace Ionic.Zip;

[ClassInterface(ClassInterfaceType::AutoDispatch (1))]
[ComVisible(True)]
[DefaultMember("Item")]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
public class ZipFile : IEnumerable, IEnumerable<ZipEntry>, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public StringComparison sc; //Field offset: 0x8

		public <>c__DisplayClass189_0() { }

		internal int <get_EntriesSorted>b__0(ZipEntry x, ZipEntry y) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__341 : IEnumerator<ZipEntry>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x8
		private ZipEntry <>2__current; //Field offset: 0xC
		public ZipFile <>4__this; //Field offset: 0x10
		private Enumerator<String, ZipEntry> <>7__wrap1; //Field offset: 0x14

		private override ZipEntry System.Collections.Generic.IEnumerator<Ionic.Zip.ZipEntry>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetEnumerator>d__341(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override ZipEntry System.Collections.Generic.IEnumerator<Ionic.Zip.ZipEntry>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class ExtractorSettings
	{
		public SelfExtractorFlavor Flavor; //Field offset: 0x8
		public List<String> ReferencedAssemblies; //Field offset: 0xC
		public List<String> CopyThroughResources; //Field offset: 0x10
		public List<String> ResourcesToCompile; //Field offset: 0x14

		public ExtractorSettings() { }

	}

	private static ExtractorSettings[] SettingsList; //Field offset: 0x0
	public static readonly int BufferSizeDefault; //Field offset: 0x4
	private static Encoding _defaultEncoding; //Field offset: 0x8
	private static bool _defaultEncodingInitialized; //Field offset: 0xC
	[CompilerGenerated]
	private bool <FullScan>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <SortEntriesBeforeSaving>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	private bool <AddDirectoryWillTraverseReparsePoints>k__BackingField; //Field offset: 0xA
	[CompilerGenerated]
	private int <CodecBufferSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private CompressionLevel <CompressionLevel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ExtractExistingFileAction <ExtractExistingFile>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private SetCompressionCallback <SetCompression>k__BackingField; //Field offset: 0x18
	private TextWriter _StatusMessageTextWriter; //Field offset: 0x1C
	private bool _CaseSensitiveRetrieval; //Field offset: 0x20
	private bool _IgnoreDuplicateFiles; //Field offset: 0x21
	private Stream _readstream; //Field offset: 0x24
	private Stream _writestream; //Field offset: 0x28
	private ushort _versionMadeBy; //Field offset: 0x2C
	private ushort _versionNeededToExtract; //Field offset: 0x2E
	private uint _diskNumberWithCd; //Field offset: 0x30
	private long _maxOutputSegmentSize; //Field offset: 0x38
	private uint _numberOfSegmentsForMostRecentSave; //Field offset: 0x40
	private ZipErrorAction _zipErrorAction; //Field offset: 0x44
	private bool _disposed; //Field offset: 0x48
	private Dictionary<String, ZipEntry> _entries; //Field offset: 0x4C
	private Dictionary<String, ZipEntry> _entriesInsensitive; //Field offset: 0x50
	private List<ZipEntry> _zipEntriesAsList; //Field offset: 0x54
	private string _name; //Field offset: 0x58
	private string _readName; //Field offset: 0x5C
	private string _Comment; //Field offset: 0x60
	internal string _Password; //Field offset: 0x64
	private bool _emitNtfsTimes; //Field offset: 0x68
	private bool _emitUnixTimes; //Field offset: 0x69
	private CompressionStrategy _Strategy; //Field offset: 0x6C
	private CompressionMethod _compressionMethod; //Field offset: 0x70
	private bool _fileAlreadyExists; //Field offset: 0x74
	private string _temporaryFileName; //Field offset: 0x78
	private bool _contentsChanged; //Field offset: 0x7C
	private bool _hasBeenSaved; //Field offset: 0x7D
	private string _TempFileFolder; //Field offset: 0x80
	private bool _ReadStreamIsOurs; //Field offset: 0x84
	private object LOCK; //Field offset: 0x88
	private bool _saveOperationCanceled; //Field offset: 0x8C
	private bool _addOperationCanceled; //Field offset: 0x8D
	private EncryptionAlgorithm _Encryption; //Field offset: 0x90
	private bool _JustSaved; //Field offset: 0x94
	private long _locEndOfCDS; //Field offset: 0x98
	private uint _OffsetOfCentralDirectory; //Field offset: 0xA0
	private long _OffsetOfCentralDirectory64; //Field offset: 0xA8
	private Nullable<Boolean> _OutputUsesZip64; //Field offset: 0xB0
	private Encoding _alternateEncoding; //Field offset: 0xB4
	private ZipOption _alternateEncodingUsage; //Field offset: 0xB8
	private int _BufferSize; //Field offset: 0xBC
	internal ParallelDeflateOutputStream ParallelDeflater; //Field offset: 0xC0
	private long _ParallelDeflateThreshold; //Field offset: 0xC8
	private int _maxBufferPairs; //Field offset: 0xD0
	internal Zip64Option _zip64; //Field offset: 0xD4
	private bool _SavingSfx; //Field offset: 0xD8
	[CompilerGenerated]
	private EventHandler<SaveProgressEventArgs> SaveProgress; //Field offset: 0xDC
	[CompilerGenerated]
	private EventHandler<ReadProgressEventArgs> ReadProgress; //Field offset: 0xE0
	private long _lengthOfReadStream; //Field offset: 0xE8
	[CompilerGenerated]
	private EventHandler<AddProgressEventArgs> AddProgress; //Field offset: 0xF0
	[CompilerGenerated]
	private EventHandler<ZipErrorEventArgs> ZipError; //Field offset: 0xF4

	public bool AddDirectoryWillTraverseReparsePoints
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Encoding AlternateEncoding
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public ZipOption AlternateEncodingUsage
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	private string ArchiveNameForEvent
	{
		private get { } //Length: 53
	}

	public int BufferSize
	{
		 get { } //Length: 14
	}

	public bool CaseSensitiveRetrieval
	{
		 get { } //Length: 11
	}

	public int CodecBufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Comment
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public CompressionLevel CompressionLevel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CompressionMethod CompressionMethod
	{
		 get { } //Length: 11
	}

	public static Encoding DefaultEncoding
	{
		 get { } //Length: 61
	}

	public EncryptionAlgorithm Encryption
	{
		 get { } //Length: 14
	}

	public ICollection<ZipEntry> Entries
	{
		 get { } //Length: 64
	}

	public ICollection<ZipEntry> EntriesSorted
	{
		 get { } //Length: 731
	}

	public ExtractExistingFileAction ExtractExistingFile
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool FullScan
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool IgnoreDuplicateFiles
	{
		 get { } //Length: 11
	}

	public ZipEntry Item
	{
		 get { } //Length: 227
	}

	private long LengthOfReadStream
	{
		private get { } //Length: 149
	}

	public long MaxOutputSegmentSize64
	{
		 get { } //Length: 14
	}

	public string Name
	{
		 get { } //Length: 11
	}

	public int ParallelDeflateMaxBufferPairs
	{
		 get { } //Length: 14
	}

	public long ParallelDeflateThreshold
	{
		 get { } //Length: 20
		 set { } //Length: 120
	}

	internal Stream ReadStream
	{
		internal get { } //Length: 78
	}

	private Dictionary<String, ZipEntry> RetrievalEntries
	{
		private get { } //Length: 22
	}

	public SetCompressionCallback SetCompression
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool SortEntriesBeforeSaving
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public TextWriter StatusMessageTextWriter
	{
		 get { } //Length: 11
	}

	public CompressionStrategy Strategy
	{
		 get { } //Length: 11
	}

	public string TempFileFolder
	{
		 get { } //Length: 14
	}

	public Zip64Option UseZip64WhenSaving
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	internal bool Verbose
	{
		internal get { } //Length: 15
	}

	private Stream WriteStream
	{
		private get { } //Length: 207
	}

	public ZipErrorAction ZipErrorAction
	{
		 get { } //Length: 27
		 set { } //Length: 55
	}

	private void _InitInstance(string zipFileName, TextWriter statusMessageWriter) { }

	private ZipEntry _InternalAddEntry(ZipEntry ze) { }

	private static ZipFile() { }

	public ZipFile() { }

	public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive) { }

	public ZipEntry AddFile(string fileName, string directoryPathInArchive) { }

	private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action) { }

	private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level) { }

	internal void AfterAddEntry(ZipEntry entry) { }

	private bool AnyCaseInsensitiveMatches(string path) { }

	private void CleanupAfterSaveOperation() { }

	private void DeleteFileWithRetry(string filename) { }

	protected override void Dispose(bool disposeManagedResources) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_AddDirectoryWillTraverseReparsePoints() { }

	public Encoding get_AlternateEncoding() { }

	public ZipOption get_AlternateEncodingUsage() { }

	private string get_ArchiveNameForEvent() { }

	public int get_BufferSize() { }

	public bool get_CaseSensitiveRetrieval() { }

	[CompilerGenerated]
	public int get_CodecBufferSize() { }

	public string get_Comment() { }

	[CompilerGenerated]
	public CompressionLevel get_CompressionLevel() { }

	public CompressionMethod get_CompressionMethod() { }

	public static Encoding get_DefaultEncoding() { }

	public EncryptionAlgorithm get_Encryption() { }

	public ICollection<ZipEntry> get_Entries() { }

	public ICollection<ZipEntry> get_EntriesSorted() { }

	[CompilerGenerated]
	public ExtractExistingFileAction get_ExtractExistingFile() { }

	[CompilerGenerated]
	public bool get_FullScan() { }

	public bool get_IgnoreDuplicateFiles() { }

	public ZipEntry get_Item(string fileName) { }

	private long get_LengthOfReadStream() { }

	public long get_MaxOutputSegmentSize64() { }

	public string get_Name() { }

	public int get_ParallelDeflateMaxBufferPairs() { }

	public long get_ParallelDeflateThreshold() { }

	internal Stream get_ReadStream() { }

	private Dictionary<String, ZipEntry> get_RetrievalEntries() { }

	[CompilerGenerated]
	public SetCompressionCallback get_SetCompression() { }

	[CompilerGenerated]
	public bool get_SortEntriesBeforeSaving() { }

	public TextWriter get_StatusMessageTextWriter() { }

	public CompressionStrategy get_Strategy() { }

	public string get_TempFileFolder() { }

	public Zip64Option get_UseZip64WhenSaving() { }

	internal bool get_Verbose() { }

	private Stream get_WriteStream() { }

	public ZipErrorAction get_ZipErrorAction() { }

	public override IEnumerator<ZipEntry> GetEnumerator() { }

	internal void InternalAddEntry(string name, ZipEntry entry) { }

	private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c) { }

	internal void NotifyEntryChanged() { }

	private void OnAddCompleted() { }

	private void OnAddStarted() { }

	internal void OnReadBytes(ZipEntry entry) { }

	private void OnReadCompleted() { }

	internal void OnReadEntry(bool before, ZipEntry entry) { }

	private void OnReadStarted() { }

	internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer) { }

	private void OnSaveCompleted() { }

	private void OnSaveEntry(int current, ZipEntry entry, bool before) { }

	private void OnSaveEvent(ZipProgressEventType eventFlavor) { }

	private void OnSaveStarted() { }

	internal bool OnZipErrorSaving(ZipEntry entry, Exception exc) { }

	private static void ReadCentralDirectory(ZipFile zf) { }

	private static void ReadCentralDirectoryFooter(ZipFile zf) { }

	private static uint ReadFirstFourBytes(Stream s) { }

	private static void ReadIntoInstance(ZipFile zf) { }

	private static void ReadIntoInstance_Orig(ZipFile zf) { }

	private static void ReadZipFileComment(ZipFile zf) { }

	public void RemoveEntry(string fileName) { }

	public void RemoveEntry(ZipEntry entry) { }

	private void RemoveTempFile() { }

	internal void Reset(bool whileSaving) { }

	public void Save() { }

	public void Save(string fileName) { }

	[CompilerGenerated]
	public void set_AddDirectoryWillTraverseReparsePoints(bool value) { }

	public void set_AlternateEncoding(Encoding value) { }

	public void set_AlternateEncodingUsage(ZipOption value) { }

	public void set_Comment(string value) { }

	[CompilerGenerated]
	public void set_CompressionLevel(CompressionLevel value) { }

	public void set_ParallelDeflateThreshold(long value) { }

	public void set_UseZip64WhenSaving(Zip64Option value) { }

	public void set_ZipErrorAction(ZipErrorAction value) { }

	internal Stream StreamForDiskNumber(uint diskNumber) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public ZipEntry UpdateFile(string fileName, string directoryPathInArchive) { }

	private static void Zip64SeekToCentralDirectory(ZipFile zf) { }

}

