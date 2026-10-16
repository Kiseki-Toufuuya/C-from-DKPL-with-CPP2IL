namespace Unity.Services.Analytics.Internal;

internal class BufferX : IBuffer, IBufferDebug
{
	private readonly Byte[] k_WorkingBuffer; //Field offset: 0x8
	private readonly Char[] k_WorkingCharacterBuffer; //Field offset: 0xC
	private readonly Byte[] k_PayloadHeader; //Field offset: 0x10
	private readonly Byte[] k_HeaderEventName; //Field offset: 0x14
	private readonly Byte[] k_HeaderUserName; //Field offset: 0x18
	private readonly Byte[] k_HeaderSessionID; //Field offset: 0x1C
	private readonly Byte[] k_HeaderEventUUID; //Field offset: 0x20
	private readonly Byte[] k_HeaderTimestamp; //Field offset: 0x24
	private readonly Byte[] k_HeaderEventVersion; //Field offset: 0x28
	private readonly Byte[] k_HeaderInstallationID; //Field offset: 0x2C
	private readonly Byte[] k_HeaderPlayerID; //Field offset: 0x30
	private readonly Byte[] k_HeaderOpenEventParams; //Field offset: 0x34
	private readonly Byte[] k_CloseEvent; //Field offset: 0x38
	private readonly byte k_Quote; //Field offset: 0x3C
	private readonly Byte[] k_QuoteColon; //Field offset: 0x40
	private readonly Byte[] k_QuoteComma; //Field offset: 0x44
	private readonly Byte[] k_Comma; //Field offset: 0x48
	private readonly Byte[] k_OpenBrace; //Field offset: 0x4C
	private readonly Byte[] k_CloseBraceComma; //Field offset: 0x50
	private readonly Byte[] k_OpenBracket; //Field offset: 0x54
	private readonly Byte[] k_CloseBracketComma; //Field offset: 0x58
	private readonly byte k_Colon; //Field offset: 0x5C
	private readonly byte k_Dash; //Field offset: 0x5D
	private readonly byte k_Space; //Field offset: 0x5E
	private readonly byte k_Point; //Field offset: 0x5F
	private readonly byte k_Positive; //Field offset: 0x60
	private readonly byte k_Negative; //Field offset: 0x61
	private readonly byte k_DateTimeSeparator; //Field offset: 0x62
	private readonly byte k_UtcTimezone; //Field offset: 0x63
	private readonly Byte[] k_True; //Field offset: 0x64
	private readonly Byte[] k_False; //Field offset: 0x68
	private readonly Byte[] k_Int2CharacterByte; //Field offset: 0x6C
	private readonly Int64[] k_Order; //Field offset: 0x70
	private readonly IBufferSystemCalls m_SystemCalls; //Field offset: 0x74
	private readonly IDiskCache m_DiskCache; //Field offset: 0x78
	private readonly IIdentityManager m_UserIdentity; //Field offset: 0x7C
	private readonly ISessionManager m_Session; //Field offset: 0x80
	private readonly List<EventSummary> m_EventSummaries; //Field offset: 0x84
	private string m_CurrentEventId; //Field offset: 0x88
	private string m_CurrentEventName; //Field offset: 0x8C
	private DateTime m_CurrentEventTimestamp; //Field offset: 0x90
	private MemoryStream m_SpareBuffer; //Field offset: 0x98
	private MemoryStream m_Buffer; //Field offset: 0x9C
	[CompilerGenerated]
	private Action<String, String, DateTime, Byte[]> EventRecorded; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<HashSet`1<String>> EventsClearing; //Field offset: 0xA4
	[CompilerGenerated]
	private Action<HashSet`1<String>> EventsCleared; //Field offset: 0xA8

	public override event Action<String, String, DateTime, Byte[]> EventRecorded
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public override event Action<HashSet`1<String>> EventsClearing
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public override int Length
	{
		 get { } //Length: 43
	}

	public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session) { }

	[CompilerGenerated]
	public override void add_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public override void add_EventsClearing(Action<HashSet`1<String>> value) { }

	public override void ClearBuffer(long upTo) { }

	public override void ClearBuffer() { }

	public override void ClearDiskCache() { }

	public override void FlushToDisk() { }

	public override int get_Length() { }

	public override void LoadFromDisk() { }

	private int ProcessCharacterOntoWorkingBuffer(int index, char character) { }

	public override void PushBool(string name, bool value) { }

	private void PushCommonEventStart(string name) { }

	public override void PushDouble(string name, double value) { }

	public override void PushEndEvent() { }

	public override void PushInt64(string name, long value) { }

	public override void PushStandardEventStart(string name, int version) { }

	public override void PushString(string name, string value) { }

	[CompilerGenerated]
	public override void remove_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public override void remove_EventsClearing(Action<HashSet`1<String>> value) { }

	public override Byte[] Serialize() { }

	internal static string SerializeDateTime(DateTime dateTime) { }

	private int SerializeLong(in long number, in Byte[] buffer, in int startIndex, in int minimumLength) { }

	private void StripTrailingCommaIfNecessary() { }

	private void WriteByte(in byte value) { }

	private void WriteBytes(in Byte[] bytes) { }

	private void WriteDateTime(DateTime dateTime) { }

	private void WriteLong(in long value) { }

	private void WriteName(string name) { }

	private void WriteString(in string value) { }

}

