namespace XeApp.Game.Common;

public class SystemVoicePlayer : VoicePlayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__25_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Co_Install>b__25_0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_Install>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SystemVoicePlayer <>4__this; //Field offset: 0x10
		public Action<SystemVoicePlayer> onFinish; //Field offset: 0x14

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
		public <Co_Install>d__25(int <>1__state) { }

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

	internal class VoiceResource
	{
		public string cueSheetName; //Field offset: 0x8
		public CriAtomCueSheet CriAtomCueSheet; //Field offset: 0xC
		public int refCount; //Field offset: 0x10

		public VoiceResource() { }

	}

	private static Dictionary<String, VoiceResource> m_resourceMap; //Field offset: 0x0
	[CompilerGenerated]
	private string <Category>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <No1>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <No2>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <csName>k__BackingField; //Field offset: 0x2C

	public string Category
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string csName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int No1
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int No2
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private static SystemVoicePlayer() { }

	public SystemVoicePlayer() { }

	private void Add(string name) { }

	public static string BuildCuesheetName(string category, int no1, int no2) { }

	public static long CalcDownloadSize(string category, int no1, int no2) { }

	[IteratorStateMachine(typeof(<Co_Install>d__25))]
	private IEnumerator Co_Install(Action<SystemVoicePlayer> onFinish) { }

	[CompilerGenerated]
	public string get_Category() { }

	[CompilerGenerated]
	public string get_csName() { }

	[CompilerGenerated]
	public int get_No1() { }

	[CompilerGenerated]
	public int get_No2() { }

	public void Load(string path, Action<SystemVoicePlayer> onFinish = null) { }

	public void Load(string category, int no1, int no2 = 1, Action<SystemVoicePlayer> onFinish = null) { }

	public void PlayCueID(int cueid, float vol = 1) { }

	public void PlayVoice(string cueName) { }

	public void PlayVoice(string prefix, int no1, int no2 = 0, float vol = 1) { }

	public void PlayVoiceRandom(string prefix, int no1Min = 1, int no1Max = 10, int no2 = 0, float vol = 1) { }

	private void Remove(string name) { }

	[CompilerGenerated]
	public void set_Category(string value) { }

	[CompilerGenerated]
	public void set_csName(string value) { }

	[CompilerGenerated]
	public void set_No1(int value) { }

	[CompilerGenerated]
	public void set_No2(int value) { }

	public void StopVoice() { }

	public static void TryInstall(string category, int no1, int no2) { }

	public void Unload() { }

}

