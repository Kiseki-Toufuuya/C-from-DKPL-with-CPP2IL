namespace TMPro;

public struct MarkToMarkAdjustmentRecord
{
	[SerializeField]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[SerializeField]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public uint baseMarkGlyphID
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public uint combiningMarkGlyphID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	public uint get_baseMarkGlyphID() { }

	public uint get_combiningMarkGlyphID() { }

	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	public void set_baseMarkGlyphID(uint value) { }

	public void set_combiningMarkGlyphID(uint value) { }

	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}

