namespace XeApp.Game.Common;

public class SoundManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__53_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <LoadBootVoice>b__53_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public int noMin; //Field offset: 0x8
		public int noMax; //Field offset: 0xC
		public string prefix; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal void <LoadAndPlaySingleVoiceByCharaID>b__0(SystemVoicePlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public int noMin; //Field offset: 0x8
		public int noMax; //Field offset: 0xC

		public <>c__DisplayClass58_0() { }

		internal void <LoadAndPlaySingleVoiceByCardID>b__0(SystemVoicePlayer x) { }

	}

	[CompilerGenerated]
	private static SoundManager <Instance>k__BackingField; //Field offset: 0x0
	private const int MAX_VOICE = 16; //Field offset: 0x0
	[CompilerGenerated]
	private BgmPlayer <Bgm>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EpisodeVoicePlayer <EpisodeVoice>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private SystemVoicePlayer <BootVoice>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private SystemVoicePlayer <HomveVoice>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private SystemVoicePlayer <SingleVoice>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<SystemVoicePlayer> <MultiVoices>k__BackingField; //Field offset: 0x24

	public private BgmPlayer Bgm
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SystemVoicePlayer BootVoice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private EpisodeVoicePlayer EpisodeVoice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SystemVoicePlayer HomveVoice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private static SoundManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private List<SystemVoicePlayer> MultiVoices
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private SystemVoicePlayer SingleVoice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public SoundManager() { }

	private void Awake() { }

	public void ContinuePlay_CharacterBGM() { }

	public void ContinuePlay_ClubSpaceBGM() { }

	public void ContinuePlay_CustomBgm(int no) { }

	public void ContinuePlay_CustomPreviewBGM(int no) { }

	public void ContinuePlay_GachaBGM() { }

	public void ContinuePlay_HomeBGM() { }

	public void ContinuePlay_PartyBGM() { }

	public void ContinuePlay_PreviewBGM(int no) { }

	public void ContinuePlay_SpotBGM(int spotId) { }

	public void ContinuePlay_StoryModeBGM() { }

	public void ContinuePlay_SysBgm(int no) { }

	[CompilerGenerated]
	public BgmPlayer get_Bgm() { }

	[CompilerGenerated]
	public SystemVoicePlayer get_BootVoice() { }

	[CompilerGenerated]
	public EpisodeVoicePlayer get_EpisodeVoice() { }

	[CompilerGenerated]
	public SystemVoicePlayer get_HomveVoice() { }

	[CompilerGenerated]
	public static SoundManager get_Instance() { }

	[CompilerGenerated]
	public List<SystemVoicePlayer> get_MultiVoices() { }

	[CompilerGenerated]
	public SystemVoicePlayer get_SingleVoice() { }

	public FormatInfo GetPlayInfo_PreviewBGM() { }

	public long GetPlayTime_PreviewBGM() { }

	public bool IsBgmPlaying() { }

	public void LoadAndPlaySingleVoiceByCardID(int cardId, string category, int noMin, int noMax) { }

	public void LoadAndPlaySingleVoiceByCharaID(int charaId, string category, string prefix, int noMin, int noMax) { }

	public void LoadBootVoice() { }

	public void LoadMultiVoiceByCharaID(int slotId, string category, int charaId) { }

	public void LoadSingleVoiceByCardID(int cardId, string category = "voice", Action<SystemVoicePlayer> onFinish = null) { }

	public void LoadSingleVoiceByCharaID(int charaId, string category = "menu", Action<SystemVoicePlayer> onFinish = null) { }

	public void OnTitle() { }

	public void Pause_BGM() { }

	public void Play_CustomBGM(int no) { }

	public void Play_CustomPreviewBGM(int no) { }

	public void Play_PreviewBGM(int no) { }

	public void Play_SysBGM(int no) { }

	public void Resume_BGM() { }

	[CompilerGenerated]
	private void set_Bgm(BgmPlayer value) { }

	[CompilerGenerated]
	private void set_BootVoice(SystemVoicePlayer value) { }

	[CompilerGenerated]
	private void set_EpisodeVoice(EpisodeVoicePlayer value) { }

	[CompilerGenerated]
	private void set_HomveVoice(SystemVoicePlayer value) { }

	[CompilerGenerated]
	private static void set_Instance(SoundManager value) { }

	[CompilerGenerated]
	private void set_MultiVoices(List<SystemVoicePlayer> value) { }

	[CompilerGenerated]
	private void set_SingleVoice(SystemVoicePlayer value) { }

	public void SetBgmVolume(float v) { }

	public void StopBgm(float fadeTime = 0.5) { }

	public void UnloadBootVoice() { }

	public void UnloadMultiVoice(int slotId) { }

	public void UnloadMultiVoiceAll() { }

	public void UnloadSingleVoice() { }

}

