namespace CriWare;

[AddComponentMenu("CRIWARE/CRI Atom")]
public class CriAtom : CriMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public CriAtom <>4__this; //Field offset: 0x8
		public int i; //Field offset: 0xC
		public Predicate<CriAtomCueSheet> <>9__0; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <MargeCueSheet>b__0(CriAtomCueSheet sheet) { }

	}

	[CompilerGenerated]
	private sealed class <LoadAcbDataCoroutine>d__74 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CriAtomCueSheet cueSheet; //Field offset: 0x10
		public string awbPath; //Field offset: 0x14
		public CriFsBinder awbBinder; //Field offset: 0x18
		public CriAtom <>4__this; //Field offset: 0x1C
		public Byte[] acbData; //Field offset: 0x20
		public bool loadAwbOnMemory; //Field offset: 0x24
		private CriAtomExAcbLoader <asyncLoader>5__2; //Field offset: 0x28

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
		public <LoadAcbDataCoroutine>d__74(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private sealed class <LoadAcbFileCoroutine>d__72 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CriAtomCueSheet cueSheet; //Field offset: 0x10
		public CriFsBinder binder; //Field offset: 0x14
		public string acbPath; //Field offset: 0x18
		public string awbPath; //Field offset: 0x1C
		public CriAtom <>4__this; //Field offset: 0x20
		public bool loadAwbOnMemory; //Field offset: 0x24
		private CriAtomExAcbLoader <asyncLoader>5__2; //Field offset: 0x28

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
		public <LoadAcbFileCoroutine>d__72(int <>1__state) { }

		private void <>m__Finally1() { }

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

	internal class NativeMethods
	{

		public NativeMethods() { }

		internal static int criAtom_GetThreadPriority_ANDROID() { }

		internal static void criAtom_SetThreadPriority_ANDROID(int prio) { }

	}

	internal enum SpeakerMapping
	{
		Auto = 0,
		Monaural = 1,
		Stereo = 2,
		Ch5_1 = 3,
		Ch7_1 = 4,
		Ch5_1_2 = 5,
		Ch7_1_2 = 6,
		Ch7_1_4 = 7,
		Ch7_1_4_4 = 8,
		Ambisonics1p = 9,
		Ambisonics2p = 10,
		Ambisonics3p = 11,
		Object = 12,
		Custom = 13,
	}

	private static EventCallback eventUserCallback; //Field offset: 0x0
	private static EventCbFunc eventUserCbFunc; //Field offset: 0x4
	[CompilerGenerated]
	private static CbFunc beatsyncUserCbFunc; //Field offset: 0x8
	private static CbFunc obsoleteBeatSyncFunc; //Field offset: 0xC
	[CompilerGenerated]
	private static CueLinkCbFunc cueLinkUserCbFunc; //Field offset: 0x10
	[CompilerGenerated]
	private static CriAtom <instance>k__BackingField; //Field offset: 0x14
	public string acfFile; //Field offset: 0x20
	private bool acfIsLoading; //Field offset: 0x24
	public CriAtomCueSheet[] cueSheets; //Field offset: 0x28
	public string dspBusSetting; //Field offset: 0x2C
	public bool dontDestroyOnLoad; //Field offset: 0x30
	private GCHandle acfRegisterGCHandle; //Field offset: 0x34
	public bool dontRemoveExistsCueSheet; //Field offset: 0x38

	private static event CbFunc beatsyncUserCbFunc
	{
		[CompilerGenerated]
		private add { } //Length: 139
		[CompilerGenerated]
		private remove { } //Length: 139
	}

	private static event CueLinkCbFunc cueLinkUserCbFunc
	{
		[CompilerGenerated]
		private add { } //Length: 139
		[CompilerGenerated]
		private remove { } //Length: 139
	}

	internal static event CbFunc OnBeatSyncCallback
	{
		internal add { } //Length: 16
		internal remove { } //Length: 16
	}

	internal static event CueLinkCbFunc OnCueLinkCallback
	{
		internal add { } //Length: 16
		internal remove { } //Length: 227
	}

	internal static event EventCallback OnEventSequencerCallback
	{
		internal add { } //Length: 16
		internal remove { } //Length: 224
	}

	public static bool CueSheetsAreLoading
	{
		 get { } //Length: 216
	}

	internal static bool HasBeatSyncCallback
	{
		internal get { } //Length: 45
	}

	internal static bool HasCueLinkCallback
	{
		internal get { } //Length: 45
	}

	internal static bool HasUserCallback
	{
		internal get { } //Length: 44
	}

	private static CriAtom instance
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public CriAtom() { }

	[CompilerGenerated]
	private static void add_beatsyncUserCbFunc(CbFunc value) { }

	[CompilerGenerated]
	private static void add_cueLinkUserCbFunc(CueLinkCbFunc value) { }

	internal static void add_OnBeatSyncCallback(CbFunc value) { }

	internal static void add_OnCueLinkCallback(CueLinkCbFunc value) { }

	internal static void add_OnEventSequencerCallback(EventCallback value) { }

	public static CriAtomCueSheet AddCueSheet(string name, Byte[] acbData, string awbFile, CriFsBinder awbBinder = null) { }

	public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null) { }

	public static CriAtomCueSheet AddCueSheetAsync(string name, Byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false) { }

	public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false) { }

	public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder) { }

	public static void AttachDspBusSetting(string settingName) { }

	private void Awake() { }

	[MonoPInvokeCallback(typeof(CbFunc))]
	public static void BeatSyncCallbackFromNative(ref Info info) { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	[MonoPInvokeCallback(typeof(CueLinkCbFunc))]
	public static void CueLinkCallbackFromNative(ref CueLinkInfo info) { }

	public static void DetachDspBusSetting() { }

	public static bool get_CueSheetsAreLoading() { }

	internal static bool get_HasBeatSyncCallback() { }

	internal static bool get_HasCueLinkCallback() { }

	internal static bool get_HasUserCallback() { }

	[CompilerGenerated]
	private static CriAtom get_instance() { }

	public static CriAtomExAcb GetAcb(string cueSheetName) { }

	[Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
	public static BusAnalyzerInfo GetBusAnalyzerInfo(int busId) { }

	public static BusAnalyzerInfo GetBusAnalyzerInfo(string busName) { }

	public static float GetCategoryVolume(int id) { }

	public static float GetCategoryVolume(string name) { }

	public static CriAtomCueSheet GetCueSheet(string name) { }

	public CriAtomCueSheet GetCueSheetInternal(string name) { }

	public static int GetThreadPriorityANDROID() { }

	private CriAtomExAcb LoadAcbData(Byte[] acbData, CriFsBinder binder, string awbFile) { }

	private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, Byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory) { }

	[IteratorStateMachine(typeof(<LoadAcbDataCoroutine>d__74))]
	private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, Byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory) { }

	private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile) { }

	private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory) { }

	[IteratorStateMachine(typeof(<LoadAcbFileCoroutine>d__72))]
	private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory) { }

	private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet) { }

	private void OnDestroy() { }

	protected virtual void OnEnable() { }

	private static void RegisterBeatSyncCallbackChain(CbFunc func) { }

	private static void RegisterCueLinkCallbackChain(CueLinkCbFunc func) { }

	private static void RegisterEventCallbackChain(EventCallback func) { }

	[CompilerGenerated]
	private static void remove_beatsyncUserCbFunc(CbFunc value) { }

	[CompilerGenerated]
	private static void remove_cueLinkUserCbFunc(CueLinkCbFunc value) { }

	internal static void remove_OnBeatSyncCallback(CbFunc value) { }

	internal static void remove_OnCueLinkCallback(CueLinkCbFunc value) { }

	internal static void remove_OnEventSequencerCallback(EventCallback value) { }

	public static void RemoveCueSheet(string name) { }

	public void RemoveCueSheetInternal(string name) { }

	[MonoPInvokeCallback(typeof(EventCallback))]
	private static void SequenceCallbackFromNative(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo) { }

	[MonoPInvokeCallback(typeof(EventCbFunc))]
	public static void SequenceEventCallbackFromNative(string eventString) { }

	[CompilerGenerated]
	private static void set_instance(CriAtom value) { }

	public static void SetBeatSyncCallback(CbFunc func) { }

	public static void SetBusAnalyzer(string busName, bool sw) { }

	public static void SetBusAnalyzer(bool sw) { }

	public static void SetCategoryVolume(string name, float volume) { }

	public static void SetCategoryVolume(int id, float volume) { }

	public static void SetEventCallback(EventCbFunc func, string separator) { }

	public static void SetThreadPriorityANDROID(int prio) { }

	public void Setup() { }

	public void Shutdown() { }

	private static void UnregisterBeatSyncCallbackChain(CbFunc func) { }

	private static void UnregisterCueLinkCallbackChain(CueLinkCbFunc func) { }

	private static void UnregisterEventCallbackChain(EventCallback func) { }

}

