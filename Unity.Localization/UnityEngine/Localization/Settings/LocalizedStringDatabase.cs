namespace UnityEngine.Localization.Settings;

public class LocalizedStringDatabase : LocalizedDatabase<StringTable, StringTableEntry>
{
	internal sealed class MissingTranslation : MulticastDelegate
	{

		public MissingTranslation(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string key, long keyId, TableReference tableReference, StringTable table, Locale locale, string noTranslationFoundMessage, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string key, long keyId, TableReference tableReference, StringTable table, Locale locale, string noTranslationFoundMessage) { }

	}

	private const string k_DefaultNoTranslationMessage = "No translation found for '{key}' in {table.TableCollectionName}"; //Field offset: 0x0
	[SerializeField]
	private MissingTranslationBehavior m_MissingTranslationState; //Field offset: 0x58
	[CompilerGenerated]
	private MissingTranslation TranslationNotFound; //Field offset: 0x5C
	[SerializeField]
	[Tooltip("The string that will be used when a localized value is missing. This is a Smart String which has access to the following placeholders:\n\t{key}: The name of the key\n\t{keyId}: The numeric Id of the key\n\t{table}: The table object, this can be further queried, for example {table.TableCollectionName}\n\t{locale}: The locale asset, this can be further queried, for example {locale.name}")]
	private string m_NoTranslationFoundMessage; //Field offset: 0x60
	[SerializeReference]
	private SmartFormatter m_SmartFormat; //Field offset: 0x64
	private StringTable m_MissingTranslationTable; //Field offset: 0x68

	public event MissingTranslation TranslationNotFound
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public MissingTranslationBehavior MissingTranslationState
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string NoTranslationFoundMessage
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SmartFormatter SmartFormatter
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LocalizedStringDatabase() { }

	[CompilerGenerated]
	public void add_TranslationNotFound(MissingTranslation value) { }

	protected private override string GenerateLocalizedString(StringTable table, StringTableEntry entry, TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, IList<Object> arguments) { }

	public MissingTranslationBehavior get_MissingTranslationState() { }

	public string get_NoTranslationFoundMessage() { }

	public SmartFormatter get_SmartFormatter() { }

	public override string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	public override string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0, Object[] arguments) { }

	public string GetLocalizedString(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0, Object[] arguments) { }

	public string GetLocalizedString(TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	public override AsyncOperationHandle<String> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0, Object[] arguments) { }

	public override AsyncOperationHandle<String> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = 0, IVariableGroup localVariables = null) { }

	public AsyncOperationHandle<String> GetLocalizedStringAsync(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0, Object[] arguments) { }

	public AsyncOperationHandle<String> GetLocalizedStringAsync(TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	internal override AsyncOperationHandle<String> GetLocalizedStringAsyncInternal(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = 0, IVariableGroup localVariables = null, bool autoRelease = true) { }

	private StringTable GetUntranslatedTextTempTable(TableReference tableReference) { }

	internal string ProcessUntranslatedText(string key, long keyId, TableReference tableReference, StringTable table, Locale locale) { }

	[CompilerGenerated]
	public void remove_TranslationNotFound(MissingTranslation value) { }

	public void set_MissingTranslationState(MissingTranslationBehavior value) { }

	public void set_NoTranslationFoundMessage(string value) { }

	public void set_SmartFormatter(SmartFormatter value) { }

}

