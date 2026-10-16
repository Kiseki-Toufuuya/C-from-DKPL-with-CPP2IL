namespace UnityEngine.Localization.Settings;

public class LocalizationSettings : ScriptableObject, IReset, IDisposable
{
	[CompilerGenerated]
	private sealed class <InitializeAndCallSelectedLocaleChangedCoroutine>d__82 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LocalizationSettings <>4__this; //Field offset: 0x10
		public Locale locale; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <InitializeAndCallSelectedLocaleChangedCoroutine>d__82(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal const string ConfigName = "com.unity.localization.settings"; //Field offset: 0x0
	internal const string PreloadLabel = "Preload"; //Field offset: 0x0
	internal const string LocaleLabel = "Locale"; //Field offset: 0x0
	internal static LocalizationSettings s_Instance; //Field offset: 0x0
	internal const string ConfigEditorLocale = "com.unity.localization-edit-locale"; //Field offset: 0x0
	internal const string IgnoreSettings = "IgnoreSettings"; //Field offset: 0x0
	[SerializeReference]
	private List<IStartupLocaleSelector> m_StartupSelectors; //Field offset: 0xC
	[SerializeReference]
	private ILocalesProvider m_AvailableLocales; //Field offset: 0x10
	[SerializeReference]
	private LocalizedAssetDatabase m_AssetDatabase; //Field offset: 0x14
	[SerializeReference]
	private LocalizedStringDatabase m_StringDatabase; //Field offset: 0x18
	[MetadataType(MetadataType::LocalizationSettings (256))]
	[SerializeField]
	private MetadataCollection m_Metadata; //Field offset: 0x1C
	[SerializeField]
	internal LocaleIdentifier m_ProjectLocaleIdentifier; //Field offset: 0x20
	[SerializeField]
	private PreloadBehavior m_PreloadBehavior; //Field offset: 0x28
	[SerializeField]
	private bool m_InitializeSynchronously; //Field offset: 0x2C
	internal AsyncOperationHandle<LocalizationSettings> m_InitializingOperationHandle; //Field offset: 0x30
	private AsyncOperationHandle<Locale> m_SelectedLocaleAsync; //Field offset: 0x3C
	private Locale m_ProjectLocale; //Field offset: 0x48
	private CallbackArray<Action`1<Locale>> m_SelectedLocaleChanged; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <IsChangingSelectedLocale>k__BackingField; //Field offset: 0x64

	public event Action<Locale> OnSelectedLocaleChanged
	{
		 add { } //Length: 60
		 remove { } //Length: 58
	}

	public static event Action<Locale> SelectedLocaleChanged
	{
		 add { } //Length: 80
		 remove { } //Length: 78
	}

	public static LocalizedAssetDatabase AssetDatabase
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	public static ILocalesProvider AvailableLocales
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	internal bool HasSelectedLocaleChangedSubscribers
	{
		internal get { } //Length: 44
	}

	public static bool HasSettings
	{
		 get { } //Length: 94
	}

	public static AsyncOperationHandle<LocalizationSettings> InitializationOperation
	{
		 get { } //Length: 72
	}

	public static bool InitializeSynchronously
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public static LocalizationSettings Instance
	{
		 get { } //Length: 237
		 set { } //Length: 64
	}

	internal bool IsChangingSelectedLocale
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal bool IsPlaying
	{
		internal get { } //Length: 60
	}

	internal bool IsPlayingOrWillChangePlaymode
	{
		internal get { } //Length: 3
	}

	public static MetadataCollection Metadata
	{
		 get { } //Length: 23
	}

	internal override RuntimePlatform Platform
	{
		internal get { } //Length: 60
	}

	public static PreloadBehavior PreloadBehavior
	{
		 get { } //Length: 23
		 set { } //Length: 30
	}

	public static Locale ProjectLocale
	{
		 get { } //Length: 348
		 set { } //Length: 177
	}

	public static Locale SelectedLocale
	{
		 get { } //Length: 40
		 set { } //Length: 38
	}

	public static AsyncOperationHandle<Locale> SelectedLocaleAsync
	{
		 get { } //Length: 72
	}

	public static List<IStartupLocaleSelector> StartupLocaleSelectors
	{
		 get { } //Length: 23
	}

	public static LocalizedStringDatabase StringDatabase
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	public LocalizationSettings() { }

	[CompilerGenerated]
	private AsyncOperationHandle<Locale> <GetSelectedLocaleAsync>b__87_0(AsyncOperationHandle op) { }

	public void add_OnSelectedLocaleChanged(Action<Locale> value) { }

	public static void add_SelectedLocaleChanged(Action<Locale> value) { }

	public static LocalizedAssetDatabase get_AssetDatabase() { }

	public static ILocalesProvider get_AvailableLocales() { }

	internal bool get_HasSelectedLocaleChangedSubscribers() { }

	public static bool get_HasSettings() { }

	public static AsyncOperationHandle<LocalizationSettings> get_InitializationOperation() { }

	public static bool get_InitializeSynchronously() { }

	public static LocalizationSettings get_Instance() { }

	[CompilerGenerated]
	internal bool get_IsChangingSelectedLocale() { }

	internal bool get_IsPlaying() { }

	internal bool get_IsPlayingOrWillChangePlaymode() { }

	public static MetadataCollection get_Metadata() { }

	internal override RuntimePlatform get_Platform() { }

	public static PreloadBehavior get_PreloadBehavior() { }

	public static Locale get_ProjectLocale() { }

	public static Locale get_SelectedLocale() { }

	public static AsyncOperationHandle<Locale> get_SelectedLocaleAsync() { }

	public static List<IStartupLocaleSelector> get_StartupLocaleSelectors() { }

	public static LocalizedStringDatabase get_StringDatabase() { }

	public override LocalizedAssetDatabase GetAssetDatabase() { }

	public override ILocalesProvider GetAvailableLocales() { }

	public override AsyncOperationHandle<LocalizationSettings> GetInitializationOperation() { }

	public static LocalizationSettings GetInstanceDontCreateDefault() { }

	public MetadataCollection GetMetadata() { }

	private static LocalizationSettings GetOrCreateSettings() { }

	public override Locale GetSelectedLocale() { }

	public override AsyncOperationHandle<Locale> GetSelectedLocaleAsync() { }

	public List<IStartupLocaleSelector> GetStartupLocaleSelectors() { }

	public override LocalizedStringDatabase GetStringDatabase() { }

	[IteratorStateMachine(typeof(<InitializeAndCallSelectedLocaleChangedCoroutine>d__82))]
	private IEnumerator InitializeAndCallSelectedLocaleChangedCoroutine(Locale locale) { }

	private void InvokeSelectedLocaleChanged(Locale locale) { }

	internal override void OnEnable() { }

	public override void OnLocaleRemoved(Locale locale) { }

	public void remove_OnSelectedLocaleChanged(Action<Locale> value) { }

	public static void remove_SelectedLocaleChanged(Action<Locale> value) { }

	public override void ResetState() { }

	private Locale SelectActiveLocale() { }

	protected private override Locale SelectLocaleUsingStartupSelectors() { }

	internal void SendLocaleChangedEvents(Locale locale) { }

	public static void set_AssetDatabase(LocalizedAssetDatabase value) { }

	public static void set_AvailableLocales(ILocalesProvider value) { }

	public static void set_InitializeSynchronously(bool value) { }

	public static void set_Instance(LocalizationSettings value) { }

	[CompilerGenerated]
	private void set_IsChangingSelectedLocale(bool value) { }

	public static void set_PreloadBehavior(PreloadBehavior value) { }

	public static void set_ProjectLocale(Locale value) { }

	public static void set_SelectedLocale(Locale value) { }

	public static void set_StringDatabase(LocalizedStringDatabase value) { }

	public void SetAssetDatabase(LocalizedAssetDatabase database) { }

	public void SetAvailableLocales(ILocalesProvider available) { }

	public void SetSelectedLocale(Locale locale) { }

	public void SetStringDatabase(LocalizedStringDatabase database) { }

	private override void System.IDisposable.Dispose() { }

	internal static void ValidateSettingsExist(string error = "") { }

}

