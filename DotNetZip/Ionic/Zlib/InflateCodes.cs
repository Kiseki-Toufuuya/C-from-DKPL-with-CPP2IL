namespace Ionic.Zlib;

internal sealed class InflateCodes
{
	internal int mode; //Field offset: 0x8
	internal int len; //Field offset: 0xC
	internal Int32[] tree; //Field offset: 0x10
	internal int tree_index; //Field offset: 0x14
	internal int need; //Field offset: 0x18
	internal int lit; //Field offset: 0x1C
	internal int bitsToGet; //Field offset: 0x20
	internal int dist; //Field offset: 0x24
	internal byte lbits; //Field offset: 0x28
	internal byte dbits; //Field offset: 0x29
	internal Int32[] ltree; //Field offset: 0x2C
	internal int ltree_index; //Field offset: 0x30
	internal Int32[] dtree; //Field offset: 0x34
	internal int dtree_index; //Field offset: 0x38

	internal InflateCodes() { }

	internal int InflateFast(int bl, int bd, Int32[] tl, int tl_index, Int32[] td, int td_index, InflateBlocks s, ZlibCodec z) { }

	internal void Init(int bl, int bd, Int32[] tl, int tl_index, Int32[] td, int td_index) { }

	internal int Process(InflateBlocks blocks, int r) { }

}

