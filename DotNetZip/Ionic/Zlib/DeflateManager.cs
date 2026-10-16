namespace Ionic.Zlib;

internal sealed class DeflateManager
{
	public sealed class CompressFunc : MulticastDelegate
	{

		public CompressFunc(object object, IntPtr method) { }

		public override BlockState Invoke(FlushType flush) { }

	}

	public class Config
	{
		private static readonly Config[] Table; //Field offset: 0x0
		internal int GoodLength; //Field offset: 0x8
		internal int MaxLazy; //Field offset: 0xC
		internal int NiceLength; //Field offset: 0x10
		internal int MaxChainLength; //Field offset: 0x14
		internal DeflateFlavor Flavor; //Field offset: 0x18

		private static Config() { }

		private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

		public static Config Lookup(CompressionLevel level) { }

	}

	private static readonly int MEM_LEVEL_MAX; //Field offset: 0x0
	private static readonly int MEM_LEVEL_DEFAULT; //Field offset: 0x4
	private static readonly String[] _ErrorMessage; //Field offset: 0x8
	private static readonly int PRESET_DICT; //Field offset: 0xC
	private static readonly int INIT_STATE; //Field offset: 0x10
	private static readonly int BUSY_STATE; //Field offset: 0x14
	private static readonly int FINISH_STATE; //Field offset: 0x18
	private static readonly int Z_DEFLATED; //Field offset: 0x1C
	private static readonly int STORED_BLOCK; //Field offset: 0x20
	private static readonly int STATIC_TREES; //Field offset: 0x24
	private static readonly int DYN_TREES; //Field offset: 0x28
	private static readonly int Z_BINARY; //Field offset: 0x2C
	private static readonly int Z_ASCII; //Field offset: 0x30
	private static readonly int Z_UNKNOWN; //Field offset: 0x34
	private static readonly int Buf_size; //Field offset: 0x38
	private static readonly int MIN_MATCH; //Field offset: 0x3C
	private static readonly int MAX_MATCH; //Field offset: 0x40
	private static readonly int MIN_LOOKAHEAD; //Field offset: 0x44
	private static readonly int HEAP_SIZE; //Field offset: 0x48
	private static readonly int END_BLOCK; //Field offset: 0x4C
	private CompressFunc DeflateFunction; //Field offset: 0x8
	internal ZlibCodec _codec; //Field offset: 0xC
	internal int status; //Field offset: 0x10
	internal Byte[] pending; //Field offset: 0x14
	internal int nextPending; //Field offset: 0x18
	internal int pendingCount; //Field offset: 0x1C
	internal sbyte data_type; //Field offset: 0x20
	internal int last_flush; //Field offset: 0x24
	internal int w_size; //Field offset: 0x28
	internal int w_bits; //Field offset: 0x2C
	internal int w_mask; //Field offset: 0x30
	internal Byte[] window; //Field offset: 0x34
	internal int window_size; //Field offset: 0x38
	internal Int16[] prev; //Field offset: 0x3C
	internal Int16[] head; //Field offset: 0x40
	internal int ins_h; //Field offset: 0x44
	internal int hash_size; //Field offset: 0x48
	internal int hash_bits; //Field offset: 0x4C
	internal int hash_mask; //Field offset: 0x50
	internal int hash_shift; //Field offset: 0x54
	internal int block_start; //Field offset: 0x58
	private Config config; //Field offset: 0x5C
	internal int match_length; //Field offset: 0x60
	internal int prev_match; //Field offset: 0x64
	internal int match_available; //Field offset: 0x68
	internal int strstart; //Field offset: 0x6C
	internal int match_start; //Field offset: 0x70
	internal int lookahead; //Field offset: 0x74
	internal int prev_length; //Field offset: 0x78
	internal CompressionLevel compressionLevel; //Field offset: 0x7C
	internal CompressionStrategy compressionStrategy; //Field offset: 0x80
	internal Int16[] dyn_ltree; //Field offset: 0x84
	internal Int16[] dyn_dtree; //Field offset: 0x88
	internal Int16[] bl_tree; //Field offset: 0x8C
	internal Tree treeLiterals; //Field offset: 0x90
	internal Tree treeDistances; //Field offset: 0x94
	internal Tree treeBitLengths; //Field offset: 0x98
	internal Int16[] bl_count; //Field offset: 0x9C
	internal Int32[] heap; //Field offset: 0xA0
	internal int heap_len; //Field offset: 0xA4
	internal int heap_max; //Field offset: 0xA8
	internal SByte[] depth; //Field offset: 0xAC
	internal int _lengthOffset; //Field offset: 0xB0
	internal int lit_bufsize; //Field offset: 0xB4
	internal int last_lit; //Field offset: 0xB8
	internal int _distanceOffset; //Field offset: 0xBC
	internal int opt_len; //Field offset: 0xC0
	internal int static_len; //Field offset: 0xC4
	internal int matches; //Field offset: 0xC8
	internal int last_eob_len; //Field offset: 0xCC
	internal short bi_buf; //Field offset: 0xD0
	internal int bi_valid; //Field offset: 0xD4
	private bool Rfc1950BytesEmitted; //Field offset: 0xD8
	private bool _WantRfc1950HeaderBytes; //Field offset: 0xD9

	internal bool WantRfc1950HeaderBytes
	{
		internal get { } //Length: 14
		internal set { } //Length: 17
	}

	private void _fillWindow() { }

	internal void _InitializeBlocks() { }

	private void _InitializeLazyMatch() { }

	private void _InitializeTreeData() { }

	internal static bool _IsSmaller(Int16[] tree, int n, int m, SByte[] depth) { }

	internal void _tr_align() { }

	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	internal bool _tr_tally(int dist, int lc) { }

	private static DeflateManager() { }

	internal DeflateManager() { }

	internal void bi_flush() { }

	internal void bi_windup() { }

	internal int build_bl_tree() { }

	internal void copy_block(int buf, int len, bool header) { }

	internal int Deflate(FlushType flush) { }

	internal BlockState DeflateFast(FlushType flush) { }

	internal BlockState DeflateNone(FlushType flush) { }

	internal BlockState DeflateSlow(FlushType flush) { }

	internal void flush_block_only(bool eof) { }

	internal bool get_WantRfc1950HeaderBytes() { }

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	internal int longest_match(int cur_match) { }

	internal void pqdownheap(Int16[] tree, int k) { }

	private void put_bytes(Byte[] p, int start, int len) { }

	internal void Reset() { }

	internal void scan_tree(Int16[] tree, int max_code) { }

	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	internal void send_bits(int value, int length) { }

	internal void send_code(int c, Int16[] tree) { }

	internal void send_compressed_block(Int16[] ltree, Int16[] dtree) { }

	internal void send_tree(Int16[] tree, int max_code) { }

	internal void set_data_type() { }

	internal void set_WantRfc1950HeaderBytes(bool value) { }

	private void SetDeflater() { }

}

