namespace System;

public abstract class UriParser
{
	private class BuiltInUriParser : UriParser
	{

		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

	}

	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3,
	}

	private const UriSyntaxFlags SchemeOnlyFlags = 16; //Field offset: 0x0
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796; //Field offset: 0x0
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565; //Field offset: 0x0
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405; //Field offset: 0x0
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405; //Field offset: 0x0
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536; //Field offset: 0x0
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405; //Field offset: 0x0
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697; //Field offset: 0x0
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533; //Field offset: 0x0
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590; //Field offset: 0x0
	private const int c_MaxCapacity = 512; //Field offset: 0x0
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729; //Field offset: 0x0
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737; //Field offset: 0x0
	private static readonly Dictionary<String, UriParser> m_Table; //Field offset: 0x0
	private const UriSyntaxFlags c_UpdatableFlags = 33554432; //Field offset: 0x0
	internal const int NoDefaultPort = -1; //Field offset: 0x0
	private const int c_InitialTableSize = 25; //Field offset: 0x0
	private static Dictionary<String, UriParser> m_TempTable; //Field offset: 0x4
	internal static UriParser HttpUri; //Field offset: 0x8
	internal static UriParser HttpsUri; //Field offset: 0xC
	internal static UriParser WsUri; //Field offset: 0x10
	internal static UriParser WssUri; //Field offset: 0x14
	internal static UriParser FtpUri; //Field offset: 0x18
	internal static UriParser FileUri; //Field offset: 0x1C
	internal static UriParser GopherUri; //Field offset: 0x20
	internal static UriParser NntpUri; //Field offset: 0x24
	internal static UriParser NewsUri; //Field offset: 0x28
	internal static UriParser MailToUri; //Field offset: 0x2C
	internal static UriParser UuidUri; //Field offset: 0x30
	internal static UriParser TelnetUri; //Field offset: 0x34
	internal static UriParser LdapUri; //Field offset: 0x38
	internal static UriParser NetTcpUri; //Field offset: 0x3C
	internal static UriParser NetPipeUri; //Field offset: 0x40
	internal static UriParser VsMacrosUri; //Field offset: 0x44
	private static readonly UriQuirksVersion s_QuirksVersion; //Field offset: 0x48
	private static readonly UriSyntaxFlags HttpSyntaxFlags; //Field offset: 0x4C
	private static readonly UriSyntaxFlags FileSyntaxFlags; //Field offset: 0x50
	private UriSyntaxFlags m_Flags; //Field offset: 0x8
	private UriSyntaxFlags m_UpdatableFlags; //Field offset: 0xC
	private bool m_UpdatableFlagsUsed; //Field offset: 0x10
	private int m_Port; //Field offset: 0x14
	private string m_Scheme; //Field offset: 0x18

	internal int DefaultPort
	{
		internal get { } //Length: 11
	}

	internal UriSyntaxFlags Flags
	{
		internal get { } //Length: 11
	}

	internal bool IsSimple
	{
		internal get { } //Length: 16
	}

	internal string SchemeName
	{
		internal get { } //Length: 11
	}

	internal static bool ShouldUseLegacyV2Quirks
	{
		internal get { } //Length: 65
	}

	private static UriParser() { }

	protected UriParser() { }

	internal UriParser(UriSyntaxFlags flags) { }

	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	internal int get_DefaultPort() { }

	internal UriSyntaxFlags get_Flags() { }

	internal bool get_IsSimple() { }

	internal string get_SchemeName() { }

	internal static bool get_ShouldUseLegacyV2Quirks() { }

	protected override string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	internal bool InFact(UriSyntaxFlags flags) { }

	protected override void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

	internal UriParser InternalOnNewUri() { }

	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	internal bool IsAllSet(UriSyntaxFlags flags) { }

	protected override bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	protected override bool IsWellFormedOriginalString(Uri uri) { }

	internal bool NotAny(UriSyntaxFlags flags) { }

	protected override UriParser OnNewUri() { }

	protected override string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

}

