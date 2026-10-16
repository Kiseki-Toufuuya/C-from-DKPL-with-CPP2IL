namespace System.Globalization;

internal class CalendarData
{
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	internal static CalendarData Invariant; //Field offset: 0x0
	private static String[] HEBREW_MONTH_NAMES; //Field offset: 0x4
	private static String[] HEBREW_LEAP_MONTH_NAMES; //Field offset: 0x8
	internal string sNativeName; //Field offset: 0x8
	internal String[] saShortDates; //Field offset: 0xC
	internal String[] saYearMonths; //Field offset: 0x10
	internal String[] saLongDates; //Field offset: 0x14
	internal string sMonthDay; //Field offset: 0x18
	internal String[] saEraNames; //Field offset: 0x1C
	internal String[] saAbbrevEraNames; //Field offset: 0x20
	internal String[] saAbbrevEnglishEraNames; //Field offset: 0x24
	internal String[] saDayNames; //Field offset: 0x28
	internal String[] saAbbrevDayNames; //Field offset: 0x2C
	internal String[] saSuperShortDayNames; //Field offset: 0x30
	internal String[] saMonthNames; //Field offset: 0x34
	internal String[] saAbbrevMonthNames; //Field offset: 0x38
	internal String[] saMonthGenitiveNames; //Field offset: 0x3C
	internal String[] saAbbrevMonthGenitiveNames; //Field offset: 0x40
	internal String[] saLeapYearMonthNames; //Field offset: 0x44
	internal int iTwoDigitYearMax; //Field offset: 0x48
	internal int iCurrentEra; //Field offset: 0x4C
	internal bool bUseUserOverrides; //Field offset: 0x50

	private static CalendarData() { }

	private CalendarData() { }

	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	private static string CalendarIdToCultureName(int calendarId) { }

	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	internal static CalendarData GetCalendarData(int calendarId) { }

	private static String[] GetJapaneseEnglishEraNames() { }

	private static String[] GetJapaneseEraNames() { }

	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	private void InitializeEraNames(string localeName, int calendarId) { }

	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	public static int nativeGetTwoDigitYearMax(int calID) { }

}

