namespace Ionic.Zip;

[ClassInterface(ClassInterfaceType::AutoDispatch (1))]
[ComVisible(True)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
public class ZipEntry
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass266_0
	{
		public int remainingData; //Field offset: 0x8
		public long posn; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x18
		public int j; //Field offset: 0x1C

		public <>c__DisplayClass266_0() { }

		internal long <ProcessExtraFieldZip64>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass268_0
	{
		public Byte[] buffer; //Field offset: 0x8
		public int j; //Field offset: 0xC
		public int remainingData; //Field offset: 0x10

		public <>c__DisplayClass268_0() { }

		internal DateTime <ProcessExtraFieldUnixTimes>b__0() { }

	}

	private class CopyHelper
	{
		private static Regex re; //Field offset: 0x0
		private static int callCount; //Field offset: 0x4

		private static CopyHelper() { }

		internal static string AppendCopyToFileName(string f) { }

		internal static void Reset() { }

	}

	private sealed class Func : MulticastDelegate
	{

		public Func`1(object object, IntPtr method) { }

		public override T Invoke() { }

	}

	private static Encoding ibm437; //Field offset: 0x0
	private static DateTime _unixEpoch; //Field offset: 0x8
	private static DateTime _win32Epoch; //Field offset: 0x10
	private static DateTime _zeroHour; //Field offset: 0x18
	private short _VersionMadeBy; //Field offset: 0x8
	private short _InternalFileAttrs; //Field offset: 0xA
	private int _ExternalFileAttrs; //Field offset: 0xC
	private short _filenameLength; //Field offset: 0x10
	private short _extraFieldLength; //Field offset: 0x12
	private short _commentLength; //Field offset: 0x14
	[CompilerGenerated]
	private ExtractExistingFileAction <ExtractExistingFile>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ZipErrorAction <ZipErrorAction>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private SetCompressionCallback <SetCompression>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Encoding <AlternateEncoding>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private ZipOption <AlternateEncodingUsage>k__BackingField; //Field offset: 0x28
	private ZipCrypto _zipCrypto_forExtract; //Field offset: 0x2C
	private ZipCrypto _zipCrypto_forWrite; //Field offset: 0x30
	private WinZipAesCrypto _aesCrypto_forExtract; //Field offset: 0x34
	private WinZipAesCrypto _aesCrypto_forWrite; //Field offset: 0x38
	private short _WinZipAesMethod; //Field offset: 0x3C
	internal DateTime _LastModified; //Field offset: 0x40
	private bool _dontEmitLastModified; //Field offset: 0x48
	private DateTime _Mtime; //Field offset: 0x50
	private DateTime _Atime; //Field offset: 0x58
	private DateTime _Ctime; //Field offset: 0x60
	private bool _ntfsTimesAreSet; //Field offset: 0x68
	private bool _emitNtfsTimes; //Field offset: 0x69
	private bool _emitUnixTimes; //Field offset: 0x6A
	private bool _TrimVolumeFromFullyQualifiedPaths; //Field offset: 0x6B
	internal string _LocalFileName; //Field offset: 0x6C
	private string _FileNameInArchive; //Field offset: 0x70
	internal short _VersionNeeded; //Field offset: 0x74
	internal short _BitField; //Field offset: 0x76
	internal short _CompressionMethod; //Field offset: 0x78
	private short _CompressionMethod_FromZipFile; //Field offset: 0x7A
	private CompressionLevel _CompressionLevel; //Field offset: 0x7C
	internal string _Comment; //Field offset: 0x80
	private bool _IsDirectory; //Field offset: 0x84
	private Byte[] _CommentBytes; //Field offset: 0x88
	internal long _CompressedSize; //Field offset: 0x90
	internal long _CompressedFileDataSize; //Field offset: 0x98
	internal long _UncompressedSize; //Field offset: 0xA0
	internal int _TimeBlob; //Field offset: 0xA8
	private bool _crcCalculated; //Field offset: 0xAC
	internal int _Crc32; //Field offset: 0xB0
	internal Byte[] _Extra; //Field offset: 0xB4
	private bool _metadataChanged; //Field offset: 0xB8
	private bool _restreamRequiredOnSave; //Field offset: 0xB9
	private bool _sourceIsEncrypted; //Field offset: 0xBA
	private bool _skippedDuringSave; //Field offset: 0xBB
	private uint _diskNumber; //Field offset: 0xBC
	private Encoding _actualEncoding; //Field offset: 0xC0
	internal ZipContainer _container; //Field offset: 0xC4
	private long __FileDataPosition; //Field offset: 0xC8
	private Byte[] _EntryHeader; //Field offset: 0xD0
	internal long _RelativeOffsetOfLocalHeader; //Field offset: 0xD8
	private long _future_ROLH; //Field offset: 0xE0
	private long _TotalEntrySize; //Field offset: 0xE8
	private int _LengthOfHeader; //Field offset: 0xF0
	private int _LengthOfTrailer; //Field offset: 0xF4
	internal bool _InputUsesZip64; //Field offset: 0xF8
	private uint _UnsupportedAlgorithmId; //Field offset: 0xFC
	internal string _Password; //Field offset: 0x100
	internal ZipEntrySource _Source; //Field offset: 0x104
	internal EncryptionAlgorithm _Encryption; //Field offset: 0x108
	internal EncryptionAlgorithm _Encryption_FromZipFile; //Field offset: 0x10C
	internal Byte[] _WeakEncryptionHeader; //Field offset: 0x110
	internal Stream _archiveStream; //Field offset: 0x114
	private Stream _sourceStream; //Field offset: 0x118
	private Nullable<Int64> _sourceStreamOriginalPosition; //Field offset: 0x120
	private bool _ioOperationCanceled; //Field offset: 0x130
	private bool _presumeZip64; //Field offset: 0x131
	private Nullable<Boolean> _entryRequiresZip64; //Field offset: 0x132
	private Nullable<Boolean> _OutputUsesZip64; //Field offset: 0x134
	private bool _IsText; //Field offset: 0x136
	private ZipEntryTimestamp _timestamp; //Field offset: 0x138
	private WriteDelegate _WriteDelegate; //Field offset: 0x13C
	private OpenDelegate _OpenDelegate; //Field offset: 0x140
	private CloseDelegate _CloseDelegate; //Field offset: 0x144
	private Stream _inputDecryptorStream; //Field offset: 0x148
	private int _readExtraDepth; //Field offset: 0x14C
	private object _outputLock; //Field offset: 0x150

	public DateTime AccessedTime
	{
		 get { } //Length: 14
	}

	public Encoding AlternateEncoding
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ZipOption AlternateEncodingUsage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	internal Stream ArchiveStream
	{
		internal get { } //Length: 241
	}

	public FileAttributes Attributes
	{
		 get { } //Length: 11
	}

	internal bool AttributesIndicateDirectory
	{
		internal get { } //Length: 27
	}

	private int BufferSize
	{
		private get { } //Length: 37
	}

	public string Comment
	{
		 get { } //Length: 14
	}

	public long CompressedSize
	{
		 get { } //Length: 20
	}

	public CompressionLevel CompressionLevel
	{
		 get { } //Length: 11
		 set { } //Length: 96
	}

	public CompressionMethod CompressionMethod
	{
		 get { } //Length: 12
		 set { } //Length: 167
	}

	public DateTime CreationTime
	{
		 get { } //Length: 14
	}

	public bool EmitTimesInUnixFormatWhenSaving
	{
		 set { } //Length: 21
	}

	public bool EmitTimesInWindowsFormatWhenSaving
	{
		 set { } //Length: 21
	}

	public EncryptionAlgorithm Encryption
	{
		 get { } //Length: 14
		 set { } //Length: 130
	}

	public ExtractExistingFileAction ExtractExistingFile
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	internal long FileDataPosition
	{
		internal get { } //Length: 50
	}

	public string FileName
	{
		 get { } //Length: 11
	}

	public bool IncludedInMostRecentSave
	{
		 get { } //Length: 18
	}

	internal bool IsChanged
	{
		internal get { } //Length: 23
	}

	public bool IsDirectory
	{
		 get { } //Length: 14
	}

	public bool IsText
	{
		 set { } //Length: 17
	}

	public DateTime LastModified
	{
		 get { } //Length: 73
	}

	private int LengthOfHeader
	{
		private get { } //Length: 36
	}

	internal string LocalFileName
	{
		internal get { } //Length: 11
	}

	public DateTime ModifiedTime
	{
		 get { } //Length: 14
	}

	public Nullable<Boolean> OutputUsedZip64
	{
		 get { } //Length: 15
	}

	public string Password
	{
		 set { } //Length: 101
	}

	public SetCompressionCallback SetCompression
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long UncompressedSize
	{
		 get { } //Length: 20
	}

	public short VersionNeeded
	{
		 get { } //Length: 12
	}

	public ZipErrorAction ZipErrorAction
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private void _CheckRead(int nbytes) { }

	private void _WriteEntryData(Stream s) { }

	private static ZipEntry() { }

	public ZipEntry() { }

	private Byte[] ConstructExtraField(bool forCentralDirectory) { }

	internal void CopyMetaData(ZipEntry source) { }

	private void CopyThroughOneEntry(Stream outStream) { }

	private void CopyThroughWithNoChange(Stream outstream) { }

	private void CopyThroughWithRecompute(Stream outstream) { }

	private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2) { }

	internal static ZipEntry CreateFromFile(string filename, string nameInArchive) { }

	private int FigureCrc32() { }

	internal static int FindExtraFieldSegment(Byte[] extra, int offx, ushort targetHeaderId) { }

	internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output) { }

	public DateTime get_AccessedTime() { }

	[CompilerGenerated]
	public Encoding get_AlternateEncoding() { }

	[CompilerGenerated]
	public ZipOption get_AlternateEncodingUsage() { }

	internal Stream get_ArchiveStream() { }

	public FileAttributes get_Attributes() { }

	internal bool get_AttributesIndicateDirectory() { }

	private int get_BufferSize() { }

	public string get_Comment() { }

	public long get_CompressedSize() { }

	public CompressionLevel get_CompressionLevel() { }

	public CompressionMethod get_CompressionMethod() { }

	public DateTime get_CreationTime() { }

	public EncryptionAlgorithm get_Encryption() { }

	internal long get_FileDataPosition() { }

	public string get_FileName() { }

	public bool get_IncludedInMostRecentSave() { }

	internal bool get_IsChanged() { }

	public bool get_IsDirectory() { }

	public DateTime get_LastModified() { }

	private int get_LengthOfHeader() { }

	internal string get_LocalFileName() { }

	public DateTime get_ModifiedTime() { }

	public Nullable<Boolean> get_OutputUsedZip64() { }

	[CompilerGenerated]
	public SetCompressionCallback get_SetCompression() { }

	public long get_UncompressedSize() { }

	public short get_VersionNeeded() { }

	[CompilerGenerated]
	public ZipErrorAction get_ZipErrorAction() { }

	private Byte[] GetEncodedFileNameBytes() { }

	private Stream GetExtractDecompressor(Stream input2) { }

	private Stream GetExtractDecryptor(Stream input) { }

	private static int GetKeyStrengthInBits(EncryptionAlgorithm a) { }

	internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a) { }

	private static string GetUnsupportedAlgorithm(uint unsupportedAlgorithmId) { }

	private static string GetUnsupportedCompressionMethod(short compressionMethod) { }

	internal static void HandlePK00Prefix(Stream s) { }

	private static void HandleUnexpectedDataDescriptor(ZipEntry entry) { }

	internal CrcCalculatorStream InternalOpenReader(string password) { }

	private static bool IsNotValidSig(int signature) { }

	internal static bool IsNotValidZipDirEntrySig(int signature) { }

	internal void MarkAsDirectory() { }

	private Stream MaybeApplyCompression(Stream s, long streamLength) { }

	private Stream MaybeApplyEncryption(Stream s) { }

	private void MaybeUnsetCompressionMethodForWriting(int cycle) { }

	internal static string NameInArchive(string filename, string directoryPathInArchive) { }

	private string NormalizeFileName() { }

	internal void NotifySaveComplete() { }

	private void OnWriteBlock(long bytesXferred, long totalBytesToXfer) { }

	private void OnZipErrorWhileSaving(Exception e) { }

	internal void PostProcessOutput(Stream s) { }

	internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output) { }

	private void PrepSourceStream() { }

	internal int ProcessExtraField(Stream s, short extraFieldLength) { }

	private int ProcessExtraFieldInfoZipTimes(Byte[] buffer, int j, ushort dataSize, long posn) { }

	private int ProcessExtraFieldPkwareStrongEncryption(Byte[] Buffer, int j) { }

	private int ProcessExtraFieldUnixTimes(Byte[] buffer, int j, ushort dataSize, long posn) { }

	private int ProcessExtraFieldWindowsTimes(Byte[] buffer, int j, ushort dataSize, long posn) { }

	private int ProcessExtraFieldWinZipAes(Byte[] buffer, int j, ushort dataSize, long posn) { }

	private int ProcessExtraFieldZip64(Byte[] buffer, int j, ushort dataSize, long posn) { }

	internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<String, Object> previouslySeen) { }

	internal static ZipEntry ReadEntry(ZipContainer zc, bool first) { }

	private void ReadExtraField() { }

	private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding) { }

	internal static int ReadWeakEncryptionHeader(Stream s, Byte[] buffer) { }

	internal void ResetDirEntry() { }

	[CompilerGenerated]
	public void set_AlternateEncoding(Encoding value) { }

	[CompilerGenerated]
	public void set_AlternateEncodingUsage(ZipOption value) { }

	public void set_CompressionLevel(CompressionLevel value) { }

	public void set_CompressionMethod(CompressionMethod value) { }

	public void set_EmitTimesInUnixFormatWhenSaving(bool value) { }

	public void set_EmitTimesInWindowsFormatWhenSaving(bool value) { }

	public void set_Encryption(EncryptionAlgorithm value) { }

	[CompilerGenerated]
	public void set_ExtractExistingFile(ExtractExistingFileAction value) { }

	public void set_IsText(bool value) { }

	public void set_Password(string value) { }

	[CompilerGenerated]
	public void set_SetCompression(SetCompressionCallback value) { }

	[CompilerGenerated]
	public void set_ZipErrorAction(ZipErrorAction value) { }

	private void SetFdpLoh() { }

	private long SetInputAndFigureFileLength(ref Stream input) { }

	private void SetupCryptoForExtract(string password) { }

	private void SetZip64Flags() { }

	internal void StoreRelativeOffset() { }

	public virtual string ToString() { }

	private static void ValidateCompression(short compressionMethod, string fileName, string compressionMethodName) { }

	private static void ValidateEncryption(EncryptionAlgorithm encryptionAlgorithm, string fileName, uint unsupportedAlgorithmId) { }

	internal void VerifyCrcAfterExtract(int calculatedCrc32, EncryptionAlgorithm encryptionAlgorithm, int expectedCrc32, Stream archiveStream, long uncompressedSize) { }

	private bool WantReadAgain() { }

	internal void Write(Stream s) { }

	internal void WriteCentralDirectoryEntry(Stream s) { }

	internal void WriteHeader(Stream s, int cycle) { }

	internal void WriteSecurityMetadata(Stream outstream) { }

	private void WriteStatus(string format, Object[] args) { }

}

