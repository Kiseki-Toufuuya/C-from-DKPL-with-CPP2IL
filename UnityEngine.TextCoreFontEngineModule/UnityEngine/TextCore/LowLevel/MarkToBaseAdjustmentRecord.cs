namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToBaseAdjustmentRecord
{
	[NativeName("baseGlyphID")]
	[SerializeField]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[NativeName("markGlyphID")]
	[SerializeField]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public uint baseGlyphID
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public uint markGlyphID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public MarkPositionAdjustment markPositionAdjustment
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	public uint get_baseGlyphID() { }

	public uint get_markGlyphID() { }

	public MarkPositionAdjustment get_markPositionAdjustment() { }

	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	public void set_baseGlyphID(uint value) { }

	public void set_markGlyphID(uint value) { }

	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

}

