namespace Ionic.Zlib;

internal sealed class InfTree
{
	internal static readonly Int32[] fixed_tl; //Field offset: 0x0
	internal static readonly Int32[] fixed_td; //Field offset: 0x4
	internal static readonly Int32[] cplens; //Field offset: 0x8
	internal static readonly Int32[] cplext; //Field offset: 0xC
	internal static readonly Int32[] cpdist; //Field offset: 0x10
	internal static readonly Int32[] cpdext; //Field offset: 0x14
	internal Int32[] hn; //Field offset: 0x8
	internal Int32[] v; //Field offset: 0xC
	internal Int32[] c; //Field offset: 0x10
	internal Int32[] r; //Field offset: 0x14
	internal Int32[] u; //Field offset: 0x18
	internal Int32[] x; //Field offset: 0x1C

	private static InfTree() { }

	public InfTree() { }

	private int huft_build(Int32[] b, int bindex, int n, int s, Int32[] d, Int32[] e, Int32[] t, Int32[] m, Int32[] hp, Int32[] hn, Int32[] v) { }

	internal int inflate_trees_bits(Int32[] c, Int32[] bb, Int32[] tb, Int32[] hp, ZlibCodec z) { }

	internal int inflate_trees_dynamic(int nl, int nd, Int32[] c, Int32[] bl, Int32[] bd, Int32[] tl, Int32[] td, Int32[] hp, ZlibCodec z) { }

	internal static int inflate_trees_fixed(Int32[] bl, Int32[] bd, Int32[][] tl, Int32[][] td, ZlibCodec z) { }

	private void initWorkArea(int vsize) { }

}

