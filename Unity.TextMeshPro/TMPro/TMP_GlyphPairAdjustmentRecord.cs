namespace TMPro;

public class TMP_GlyphPairAdjustmentRecord
{
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x8
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x1C
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x30

	public FontFeatureLookupFlags featureLookupFlags
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
	{
		 get { } //Length: 24
		 set { } //Length: 22
	}

	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
	{
		 get { } //Length: 24
		 set { } //Length: 22
	}

	public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

	public FontFeatureLookupFlags get_featureLookupFlags() { }

	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

}

