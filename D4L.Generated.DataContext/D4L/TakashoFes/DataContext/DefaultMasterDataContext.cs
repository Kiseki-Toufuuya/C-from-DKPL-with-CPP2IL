namespace D4L.TakashoFes.DataContext;

public sealed class DefaultMasterDataContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public DefaultMasterDataContext <>4__this; //Field offset: 0x8
		public IDataStorage rawAssetLoader; //Field offset: 0xC

		public <>c__DisplayClass86_0() { }

		internal void <LoadAsync>b__0() { }

	}

	private string variant; //Field offset: 0x8
	private readonly ICardAccessor _Card; //Field offset: 0xC
	private readonly ICardR1ExpAccessor _CardR1Exp; //Field offset: 0x10
	private readonly ICardR2ExpAccessor _CardR2Exp; //Field offset: 0x14
	private readonly ICardR3ExpAccessor _CardR3Exp; //Field offset: 0x18
	private readonly ICardR4ExpAccessor _CardR4Exp; //Field offset: 0x1C
	private readonly ICharacterCefficientAccessor _CharacterCefficient; //Field offset: 0x20
	private readonly ICharacterAccessor _Character; //Field offset: 0x24
	private readonly ICharacterExpAccessor _CharacterExp; //Field offset: 0x28
	private readonly ICharacterParameterAccessor _CharacterParameter; //Field offset: 0x2C
	private readonly IComboMaxAccessor _ComboMax; //Field offset: 0x30
	private readonly IDataVersionAccessor _DataVersion; //Field offset: 0x34
	private readonly IEpisodeAccessor _Episode; //Field offset: 0x38
	private readonly IEpisodeLivePresetAccessor _EpisodeLivePreset; //Field offset: 0x3C
	private readonly IEpisodeRewardAccessor _EpisodeReward; //Field offset: 0x40
	private readonly IHeroineAccessor _Heroine; //Field offset: 0x44
	private readonly IHeroineGrowthAccessor _HeroineGrowth; //Field offset: 0x48
	private readonly IHeroineSkillAccessor _HeroineSkill; //Field offset: 0x4C
	private readonly IImageHelpAccessor _ImageHelp; //Field offset: 0x50
	private readonly IMusicAccessor _Music; //Field offset: 0x54
	private readonly IMusicLevelScoreAccessor _MusicLevelScore; //Field offset: 0x58
	private readonly IMusicProductAccessor _MusicProduct; //Field offset: 0x5C
	private readonly IMusicScoreAccessor _MusicScore; //Field offset: 0x60
	private readonly IMusicSelectionAccessor _MusicSelection; //Field offset: 0x64
	private readonly IPKVSAccessor _PKVS; //Field offset: 0x68
	private readonly IWavAccessor _Wav; //Field offset: 0x6C
	private bool isDataStorageLoaded; //Field offset: 0x70
	private bool isRemoteStorageLoaded; //Field offset: 0x71

	public override ICharacterParameterAccessor CharacterParameter
	{
		 get { } //Length: 11
	}

	public override IDataVersionAccessor DataVersion
	{
		 get { } //Length: 11
	}

	public override IEpisodeAccessor Episode
	{
		 get { } //Length: 11
	}

	public DefaultMasterDataContext(string variant = null) { }

	public override ICharacterParameterAccessor get_CharacterParameter() { }

	public override IDataVersionAccessor get_DataVersion() { }

	public override IEpisodeAccessor get_Episode() { }

	public override void Load(IDataStorage rawAssetLoader) { }

	public override Task LoadAsync(IDataStorage rawAssetLoader) { }

}

