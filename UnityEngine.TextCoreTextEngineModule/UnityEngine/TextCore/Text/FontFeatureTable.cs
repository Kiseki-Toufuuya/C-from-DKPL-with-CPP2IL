namespace UnityEngine.TextCore.Text;

public class FontFeatureTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_0; //Field offset: 0x4
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_1; //Field offset: 0x8
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0xC
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x10
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x14
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal uint <SortGlyphPairAdjustmentRecords>b__24_0(GlyphPairAdjustmentRecord s) { }

		internal uint <SortGlyphPairAdjustmentRecords>b__24_1(GlyphPairAdjustmentRecord s) { }

		internal uint <SortMarkToBaseAdjustmentRecords>b__25_0(MarkToBaseAdjustmentRecord s) { }

		internal uint <SortMarkToBaseAdjustmentRecords>b__25_1(MarkToBaseAdjustmentRecord s) { }

		internal uint <SortMarkToMarkAdjustmentRecords>b__26_0(MarkToMarkAdjustmentRecord s) { }

		internal uint <SortMarkToMarkAdjustmentRecords>b__26_1(MarkToMarkAdjustmentRecord s) { }

	}

	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x8
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0xC
	[SerializeField]
	private List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x10
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x14
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x18
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x1C
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x20
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x24
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x28

	internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		internal get { } //Length: 11
	}

	internal List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		internal get { } //Length: 11
	}

	internal List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		internal get { } //Length: 11
	}

	internal FontFeatureTable() { }

	internal List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	internal List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	internal List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	public void SortGlyphPairAdjustmentRecords() { }

	public void SortMarkToBaseAdjustmentRecords() { }

	public void SortMarkToMarkAdjustmentRecords() { }

}

