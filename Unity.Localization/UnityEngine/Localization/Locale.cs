namespace UnityEngine.Localization;

public class Locale : ScriptableObject, IEquatable<Locale>, IComparable<Locale>, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <GetFallbacks>d__20 : IEnumerable<Locale>, IEnumerable, IEnumerator<Locale>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private Locale <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		public Locale <>4__this; //Field offset: 0x14
		private HashSet<Locale> <processedLocales>5__2; //Field offset: 0x18
		private PooledObject<HashSet`1<Locale>> <>7__wrap2; //Field offset: 0x1C
		private IList<IMetadata> <entries>5__4; //Field offset: 0x24
		private int <i>5__5; //Field offset: 0x28

		private override Locale System.Collections.Generic.IEnumerator<UnityEngine.Localization.Locale>.Current
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
		public <GetFallbacks>d__20(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Locale> System.Collections.Generic.IEnumerable<UnityEngine.Localization.Locale>.GetEnumerator() { }

		[DebuggerHidden]
		private override Locale System.Collections.Generic.IEnumerator<UnityEngine.Localization.Locale>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private LocaleIdentifier m_Identifier; //Field offset: 0xC
	[MetadataType(MetadataType::Locale (1))]
	[SerializeField]
	private MetadataCollection m_Metadata; //Field offset: 0x14
	[SerializeField]
	private string m_LocaleName; //Field offset: 0x18
	[SerializeField]
	private string m_CustomFormatCultureCode; //Field offset: 0x1C
	[SerializeField]
	private bool m_UseCustomFormatter; //Field offset: 0x20
	[SerializeField]
	private ushort m_SortOrder; //Field offset: 0x22
	private IFormatProvider m_Formatter; //Field offset: 0x24

	public string CustomFormatterCode
	{
		 get { } //Length: 11
		 set { } //Length: 47
	}

	public override IFormatProvider Formatter
	{
		 get { } //Length: 237
		 set { } //Length: 27
	}

	public LocaleIdentifier Identifier
	{
		 get { } //Length: 14
		 set { } //Length: 34
	}

	public string LocaleName
	{
		 get { } //Length: 141
		 set { } //Length: 27
	}

	public MetadataCollection Metadata
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ushort SortOrder
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public bool UseCustomFormatter
	{
		 get { } //Length: 11
		 set { } //Length: 35
	}

	public Locale() { }

	public override int CompareTo(Locale other) { }

	public static Locale CreateLocale(CultureInfo cultureInfo) { }

	public static Locale CreateLocale(SystemLanguage language) { }

	public static Locale CreateLocale(LocaleIdentifier identifier) { }

	public static Locale CreateLocale(string code) { }

	public override bool Equals(Locale other) { }

	public string get_CustomFormatterCode() { }

	public override IFormatProvider get_Formatter() { }

	public LocaleIdentifier get_Identifier() { }

	public string get_LocaleName() { }

	public MetadataCollection get_Metadata() { }

	public ushort get_SortOrder() { }

	public bool get_UseCustomFormatter() { }

	[Obsolete("GetFallback is obsolete, please use GetFallbacks.")]
	public override Locale GetFallback() { }

	[IteratorStateMachine(typeof(<GetFallbacks>d__20))]
	public IEnumerable<Locale> GetFallbacks() { }

	internal static CultureInfo GetFormatter(bool useCustom, LocaleIdentifier localeIdentifier, string customCode) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void set_CustomFormatterCode(string value) { }

	public override void set_Formatter(IFormatProvider value) { }

	public void set_Identifier(LocaleIdentifier value) { }

	public void set_LocaleName(string value) { }

	public void set_Metadata(MetadataCollection value) { }

	public void set_SortOrder(ushort value) { }

	public void set_UseCustomFormatter(bool value) { }

	public virtual string ToString() { }

}

