namespace Heqet;

public class SystemData : ISaveDataContainer, ISerializationCallbackReceiver
{
	internal class AdventureData
	{
		public float adv_text_speed; //Field offset: 0x8
		public float novel_text_speed; //Field offset: 0xC
		public bool enable_display_page; //Field offset: 0x10

		public AdventureData() { }

		public void Clear() { }

		public float GetAdvTextSpeedRatio() { }

		public float GetNovelTextSpeedRatio() { }

	}

	internal class DisplayData
	{
		[Obsolete("このフィールドは廃止されました", False)]
		public int display_resolution; //Field offset: 0x8
		public int display_resolution_width; //Field offset: 0xC
		public int display_resolution_height; //Field offset: 0x10
		public int display_mode; //Field offset: 0x14
		public int display_framerate; //Field offset: 0x18

		public DisplayData() { }

		public void Clear() { }

	}

	internal class EpisodeData
	{
		internal class EpisodeStatus
		{
			public int id; //Field offset: 0x8
			public int unlock_state; //Field offset: 0xC
			public int read_count; //Field offset: 0x10
			public int new_flag; //Field offset: 0x14

			public bool IsRead
			{
				 get { } //Length: 15
			}

			public bool IsUnlock
			{
				 get { } //Length: 15
			}

			public EpisodeStatus(int id, int readCount, int _new, byte unlockState) { }

			public void CommitNew() { }

			public bool get_IsRead() { }

			public bool get_IsUnlock() { }

			public EpisodeModel GetEpisode() { }

			public bool IsNew() { }

			public bool IsReadLock() { }

		}

		[SerializeField]
		private SerializableDictionary<Int32, EpisodeStatus> EpisodeStatatusDictonary; //Field offset: 0x8
		[SerializeField]
		public int AutoEnable; //Field offset: 0xC

		public EpisodeData() { }

		public EpisodeStatus CreateStatusModel(int episodeId, int New) { }

		public EpisodeStatus GetEpisodeStatus(int episode_id) { }

		public void Init() { }

		public EpisodeStatus UnlockEpisode(int episode_id, int _new = 1) { }

	}

	internal class GalleryData
	{
		internal class GalleryItem
		{
			public bool isVisibled; //Field offset: 0x8

			public GalleryItem() { }

		}

		[SerializeField]
		private SerializableDictionary<Int32, GalleryItem> heroine; //Field offset: 0x8
		[SerializeField]
		private SerializableDictionary<Int32, GalleryItem> mitamaCard; //Field offset: 0xC
		[SerializeField]
		private SerializableDictionary<Int32, GalleryItem> jacket; //Field offset: 0x10
		[SerializeField]
		private SerializableDictionary<Int32, GalleryItem> emblem; //Field offset: 0x14
		[SerializeField]
		private SerializableDictionary<Int32, GalleryItem> story; //Field offset: 0x18
		public int favorite_heroine_id; //Field offset: 0x1C
		public int favorite_mitama_card_id; //Field offset: 0x20
		public int favorite_view_mode; //Field offset: 0x24
		public int skin_id; //Field offset: 0x28
		public int lane_disp_index; //Field offset: 0x2C
		public bool enable_lawson_skin; //Field offset: 0x30

		public SerializableDictionary<Int32, GalleryItem> Emblem
		{
			 get { } //Length: 11
		}

		public SerializableDictionary<Int32, GalleryItem> Heroine
		{
			 get { } //Length: 11
		}

		public SerializableDictionary<Int32, GalleryItem> Jacket
		{
			 get { } //Length: 11
		}

		public SerializableDictionary<Int32, GalleryItem> MitamaCard
		{
			 get { } //Length: 11
		}

		public SerializableDictionary<Int32, GalleryItem> Story
		{
			 get { } //Length: 11
		}

		public GalleryData() { }

		public void AddCard(int id) { }

		public void AddEmblem(int id) { }

		public void AddHeroine(int id) { }

		public void AddJacket(int id) { }

		public void AddStory(int id) { }

		public void Clear() { }

		public SerializableDictionary<Int32, GalleryItem> get_Emblem() { }

		public SerializableDictionary<Int32, GalleryItem> get_Heroine() { }

		public SerializableDictionary<Int32, GalleryItem> get_Jacket() { }

		public SerializableDictionary<Int32, GalleryItem> get_MitamaCard() { }

		public SerializableDictionary<Int32, GalleryItem> get_Story() { }

		public void RegisterPlayRecordToHeroine(SerializableDictionary<Int32, MusicPlayRecord> playRecordDic) { }

	}

	internal class KeyAssignData
	{
		public int input_preset_type; //Field offset: 0x8
		public string input_action_json; //Field offset: 0xC

		public KeyAssignData() { }

		public void Clear() { }

	}

	internal class MusicPlayRecord
	{
		internal class RecordData
		{
			public int play_count; //Field offset: 0x8
			public int clear_count; //Field offset: 0xC
			public int high_score_rank; //Field offset: 0x10
			public int high_score; //Field offset: 0x14
			public int high_combo; //Field offset: 0x18
			public float perfect_rate; //Field offset: 0x1C
			public bool stage_clear; //Field offset: 0x20
			public bool result_frame_perfect; //Field offset: 0x21
			public bool result_all_brilliant; //Field offset: 0x22
			public bool result_full_combo; //Field offset: 0x23
			public bool result_no_bomb; //Field offset: 0x24
			public bool result_no_item; //Field offset: 0x25
			public bool result_boss_break; //Field offset: 0x26
			public bool result_no_damage; //Field offset: 0x27
			public bool mode_expert; //Field offset: 0x28
			public bool mode_lane_random; //Field offset: 0x29
			public bool mode_outer_random; //Field offset: 0x2A
			public Single[] result_groove_graph_best; //Field offset: 0x2C
			public Single[] result_accuracy_graph_best; //Field offset: 0x30

			public RecordData() { }

			public bool UpdateHighCombo(int combo) { }

			public bool UpdateHighScore(int score) { }

			public bool UpdateHighScoreRank(int rank) { }

		}

		internal class StageRecordData
		{
			public int stage_id; //Field offset: 0x8
			public SerializableDictionary<Int32, RecordData> difficulties; //Field offset: 0xC
			public SerializableDictionary<Int32, RecordData> difficulties_add4score; //Field offset: 0x10

			public StageRecordData(int stageId) { }

			public List<RecordData> GetAllDifficultyRecordDataList() { }

		}

		private const int RESULT_GRAPH_POINT_COUNT = 120; //Field offset: 0x0
		[SerializeField]
		private RecordData[] free_mode; //Field offset: 0x8
		[SerializeField]
		private RecordData[] free_mode_add4score; //Field offset: 0xC
		[SerializeField]
		private SerializableDictionary<Int32, StageRecordData> story_mode; //Field offset: 0x10
		public int free_mode_purchase; //Field offset: 0x14
		public int play_count; //Field offset: 0x18

		public MusicPlayRecord() { }

		public bool CheckClear() { }

		private List<RecordData> GetAllFreeModeList() { }

		public List<StageRecordData> GetAllStageRecordList() { }

		public RecordData GetFreeMode(int difficulty, LaneMode laneMode) { }

		public int GetFullComboClearCount() { }

		public RecordData GetKaguraFreeMode(MusicDifficulty difficult, LaneMode laneMode) { }

		private RecordData GetRecordDataFromStageId(int stageId, int difficultX, LaneMode laneMode) { }

		public int GetSSRankClearCount() { }

		private StageRecordData GetStageRecordData(int stageId) { }

		public RecordData GetStoryOrFree(int stageId, int difficultX, LaneMode laneMode) { }

		public void Reset() { }

	}

	internal class MusicSettingData
	{
		internal class Difficulties
		{
			public SettingData story_mode; //Field offset: 0x8
			public SettingData free_mode; //Field offset: 0xC

			public Difficulties() { }

		}

		internal class SettingData
		{
			public float note_speed; //Field offset: 0x8
			public float sudden; //Field offset: 0xC
			public float hidden; //Field offset: 0x10
			public bool enable_tap_se; //Field offset: 0x14
			public int note_skin_id; //Field offset: 0x18
			public bool auto_play; //Field offset: 0x1C
			[Obsolete("このフィールドは廃止されました", False)]
			public bool unique_setting; //Field offset: 0x1D
			public int speed_type; //Field offset: 0x20
			public int speed_level; //Field offset: 0x24
			public uint notes_random_flag; //Field offset: 0x28
			public int speed_auto; //Field offset: 0x2C
			public bool enable_sudden; //Field offset: 0x30
			public bool enable_hidden; //Field offset: 0x31
			public int lane_brightness; //Field offset: 0x34
			public int music_timing; //Field offset: 0x38
			public int notes_tap_timing; //Field offset: 0x3C
			public bool enable_notes_connection; //Field offset: 0x40
			public bool enable_music_sync; //Field offset: 0x41
			public bool enable_background_movie; //Field offset: 0x42
			[SerializeField]
			private SerializableHashSet<String> m_CusatomParamHashSet; //Field offset: 0x44

			public SettingData() { }

			public void CheckEditParam(SettingData baseSetting) { }

			public bool IsCustomParam(string key) { }

			public bool isUnique() { }

			public void Reset() { }

		}

		public const uint NOTES_RANDOM_FLAG_OUTER = 1; //Field offset: 0x0
		public const uint NOTES_RANDOM_FLAG_MIRROR = 2; //Field offset: 0x0
		public const uint NOTES_RANDOM_FLAG_LANE = 4; //Field offset: 0x0
		public bool favorite; //Field offset: 0x8
		[SerializeField]
		private Difficulties[] difficulties; //Field offset: 0xC
		[SerializeField]
		private Difficulties[] difficulties_add4score; //Field offset: 0x10
		public SettingData danmaku_stage; //Field offset: 0x14

		public MusicSettingData() { }

		public List<Difficulties> GetAllDifficultyList() { }

		public Difficulties GetDifficulty(int difficulty, LaneMode laneMode) { }

		public void Reset() { }

		public Difficulties[] Ver1_GetDifficulties() { }

	}

	internal class SettingsData
	{
		internal class DanmakuStageSettingData
		{
			public float lane_brightness; //Field offset: 0x8
			public float player_bnullet_opacity; //Field offset: 0xC
			public float enemy_bnullet_opacity; //Field offset: 0x10
			public bool enable_hit_effect; //Field offset: 0x14
			public int note_tapse_id; //Field offset: 0x18
			public bool display_player_collision; //Field offset: 0x1C
			public bool enable_rhythm_guide; //Field offset: 0x1D
			public bool enable_guide; //Field offset: 0x1E
			public SettingData music_setting_data; //Field offset: 0x20
			public bool enable_rhythmbeat; //Field offset: 0x24
			public bool enable_highaccuracy; //Field offset: 0x25
			public bool enable_tapaccuracy; //Field offset: 0x26
			public bool enable_expert; //Field offset: 0x27
			public int notes_skin_id; //Field offset: 0x28

			public DanmakuStageSettingData() { }

			public void Reset() { }

		}

		internal enum FreemodeMusicType
		{
			Default = 0,
			Preview = 1,
		}

		internal class KaguraStageSettingData
		{
			public bool enable_hit_effect; //Field offset: 0x8
			public int emblem_id; //Field offset: 0xC
			public int note_tapse_id; //Field offset: 0x10
			public bool enable_live2d_animation; //Field offset: 0x14
			public bool enable_rhythm_guide; //Field offset: 0x15
			public bool enable_guide; //Field offset: 0x16
			public SettingData music_setting_data; //Field offset: 0x18
			public bool enable_center_line; //Field offset: 0x1C
			public bool enable_normal_layout; //Field offset: 0x1D
			public bool enable_rhythmbeat; //Field offset: 0x1E
			public bool enable_notes_connection; //Field offset: 0x1F
			public bool enable_highaccuracy; //Field offset: 0x20
			public bool enable_tapaccuracy; //Field offset: 0x21
			public bool enable_expert; //Field offset: 0x22
			public int notes_skin_id; //Field offset: 0x24
			public UICustomizeData ui_customize; //Field offset: 0x28

			public KaguraStageSettingData() { }

			public void Reset() { }

		}

		internal enum NoteTapSeType
		{
			None = 0,
			TypeA = 1,
		}

		internal class UICustomizeData
		{
			internal enum eComboDisplayType
			{
				Default = 0,
				Upper = 1,
				Center = 2,
				Lower = 3,
				Hide = 4,
				SpecifiedPosition = 5,
				Max = 6,
			}

			internal enum eFastSlowDisplayType
			{
				JudgeLeft = 0,
				JudgeRight = 1,
				JudgeUp = 2,
				JudgeDown = 3,
				ComboUp = 4,
				ComboDown = 5,
				Hide = 6,
				Max = 7,
			}

			internal enum eJudgeMessageDisplayType
			{
				Default = 0,
				UpperBlind = 1,
				LowerBlind = 2,
				Upper = 3,
				Center = 4,
				Lower = 5,
				SpecifiedPosition = 6,
				Hide = 7,
				Max = 8,
			}

			public const float SPECIFIED_POSITION_MIM_X = -7; //Field offset: 0x0
			public const float SPECIFIED_POSITION_MAX_X = 7; //Field offset: 0x0
			public const float SPECIFIED_POSITION_MIM_Y = -5; //Field offset: 0x0
			public const float SPECIFIED_POSITION_MAX_Y = 5; //Field offset: 0x0
			public int judge_message_display_type; //Field offset: 0x8
			public Vector2 judge_message_position; //Field offset: 0xC
			public float judge_message_scale; //Field offset: 0x14
			public int fast_slow_message_display_type; //Field offset: 0x18
			public float fast_slow_message_scale; //Field offset: 0x1C
			public int combo_message_display_type; //Field offset: 0x20
			public Vector2 combo_message_position; //Field offset: 0x24
			public float combo_message_scale; //Field offset: 0x2C

			public UICustomizeData() { }

			public void Reset() { }

		}

		public const int NOTES_TAP_TIMING_MIN = -1000; //Field offset: 0x0
		public const int NOTES_TAP_TIMING_MAX = 1000; //Field offset: 0x0
		public const int MUSIC_TIMING_MIN = -1000; //Field offset: 0x0
		public const int MUSIC_TIMING_MAX = 1000; //Field offset: 0x0
		public int free_mode_music_type; //Field offset: 0x8
		public int free_mode_select_id; //Field offset: 0xC
		public int free_mode_select_difficulty; //Field offset: 0x10
		public LaneMode free_mode_select_lane_mode; //Field offset: 0x14
		public int free_mode_folder_id; //Field offset: 0x18
		public Int32[] free_mode_type_folder_id; //Field offset: 0x1C
		public int free_mode_folder_view_id; //Field offset: 0x20
		public int free_mode_display_score_mode; //Field offset: 0x24
		public int free_mode_select_type; //Field offset: 0x28
		public int result_keep_view_kagura_graph; //Field offset: 0x2C
		public KaguraStageSettingData kagura; //Field offset: 0x30
		public DanmakuStageSettingData danmaku; //Field offset: 0x34

		public SettingsData() { }

		public void Reset() { }

	}

	internal class UnlockMusicData
	{
		public bool freePlayUnlock; //Field offset: 0x8
		public int purchasePrice; //Field offset: 0xC

		public UnlockMusicData() { }

	}

	internal class VolumeData
	{
		public float system_bgm_volume; //Field offset: 0x8
		public float system_se_volume; //Field offset: 0xC
		public float music_volume; //Field offset: 0x10
		public float tap_se_volume; //Field offset: 0x14
		public float danmaku_se_volume; //Field offset: 0x18

		public VolumeData() { }

		public void Clear() { }

	}

	[SerializeField]
	private KeyAssignData m_KeyAssign; //Field offset: 0x8
	[SerializeField]
	private VolumeData m_Volume; //Field offset: 0xC
	[SerializeField]
	private DisplayData m_Displaye; //Field offset: 0x10
	[SerializeField]
	private AdventureData m_Adventure; //Field offset: 0x14
	[SerializeField]
	private GalleryData m_Gallery; //Field offset: 0x18
	[SerializeField]
	private SettingsData m_SettingsData; //Field offset: 0x1C
	[SerializeField]
	private SerializableDictionary<Int32, MusicSettingData> m_MusicSettingData; //Field offset: 0x20
	[SerializeField]
	private SerializableDictionary<Int32, MusicPlayRecord> m_MusicPlayRecord; //Field offset: 0x24
	[SerializeField]
	private SerializableDictionary<Int32, UnlockMusicData> m_UnlockMusicData; //Field offset: 0x28
	[SerializeField]
	private SerializableHashSet<Int32> m_VieweNewMusicHashSet; //Field offset: 0x2C
	[SerializeField]
	private bool is_first_play_kagura; //Field offset: 0x30
	[SerializeField]
	private bool is_first_play_danmaku; //Field offset: 0x31
	[SerializeField]
	private int seen_max_new_release_dlcId; //Field offset: 0x34
	[SerializeField]
	private SerializableHashSet<Int32> m_ResentlyMusicHashSet; //Field offset: 0x38
	[SerializeField]
	private EpisodeData m_Episode; //Field offset: 0x3C

	public AdventureData Adventure
	{
		 get { } //Length: 11
	}

	public DisplayData Display
	{
		 get { } //Length: 11
	}

	public EpisodeData Episode
	{
		 get { } //Length: 11
	}

	public override short FormatVersion
	{
		 get { } //Length: 6
	}

	public GalleryData Gallery
	{
		 get { } //Length: 11
	}

	public bool IsFirstPlayDanmaku
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsFirstPlayKagura
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public KeyAssignData KeyAssign
	{
		 get { } //Length: 11
	}

	public SerializableDictionary<Int32, MusicPlayRecord> MusicPlayRecordData
	{
		 get { } //Length: 11
	}

	public SerializableDictionary<Int32, MusicSettingData> MusicSetting
	{
		 get { } //Length: 11
	}

	public SerializableHashSet<Int32> ResentlyMusicHashSet
	{
		 get { } //Length: 11
	}

	public int SeenMaxNewReleaseDlcId
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public SettingsData Settings
	{
		 get { } //Length: 11
	}

	public override uint Signature
	{
		 get { } //Length: 6
	}

	public SerializableDictionary<Int32, UnlockMusicData> UnlockMusic
	{
		 get { } //Length: 11
	}

	public SerializableHashSet<Int32> ViewedNewMusicHashSet
	{
		 get { } //Length: 11
	}

	public VolumeData Volume
	{
		 get { } //Length: 11
	}

	public SystemData() { }

	public void AddUnlockMusic(int musicId, int purchasePrice = 0, bool freePlayUnlock = false) { }

	public override void CopyTo(object dest) { }

	public override bool DeserializeFromBytes(int verson, Byte[] bytes) { }

	public AdventureData get_Adventure() { }

	public DisplayData get_Display() { }

	public EpisodeData get_Episode() { }

	public override short get_FormatVersion() { }

	public GalleryData get_Gallery() { }

	public bool get_IsFirstPlayDanmaku() { }

	public bool get_IsFirstPlayKagura() { }

	public KeyAssignData get_KeyAssign() { }

	public SerializableDictionary<Int32, MusicPlayRecord> get_MusicPlayRecordData() { }

	public SerializableDictionary<Int32, MusicSettingData> get_MusicSetting() { }

	public SerializableHashSet<Int32> get_ResentlyMusicHashSet() { }

	public int get_SeenMaxNewReleaseDlcId() { }

	public SettingsData get_Settings() { }

	public override uint get_Signature() { }

	public SerializableDictionary<Int32, UnlockMusicData> get_UnlockMusic() { }

	public SerializableHashSet<Int32> get_ViewedNewMusicHashSet() { }

	public VolumeData get_Volume() { }

	public int GetAllFullComboClearSongCount() { }

	public int GetAllSSRankClearSongCount() { }

	public MusicPlayRecord GetMusicPlayRecord(int musicID) { }

	public MusicSettingData GetMusicSettingData(int musicID) { }

	public SettingData GetMusicSettingData(int musicID, int difficulty, HeqetGameMode gameMode, LaneMode laneMode) { }

	public Difficulties GetMusicSettingData(int musicID, int difficulty, LaneMode laneMode) { }

	public int GetOverHardClearCountWithKagura() { }

	public override bool Match(object dest) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override void ResetToDefault() { }

	public override Byte[] SerializeToBytes() { }

	public void set_IsFirstPlayDanmaku(bool value) { }

	public void set_IsFirstPlayKagura(bool value) { }

	public void set_SeenMaxNewReleaseDlcId(int value) { }

	private void VersionValidate(int version) { }

	private void VersionValidate_Ver1To2() { }

}

