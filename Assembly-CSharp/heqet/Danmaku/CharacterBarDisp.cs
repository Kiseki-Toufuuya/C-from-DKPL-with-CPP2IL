namespace Heqet.Danmaku;

public class CharacterBarDisp : DispBase
{
	private const string BOSS_SPRITE = "boss_sprite"; //Field offset: 0x0
	private const float ANIMATION_OUT_DELAY = 0.6; //Field offset: 0x0
	private const float ANIMATION_IN_DELAY = 0.4; //Field offset: 0x0
	private const float ANIMATION_DURATION = 1; //Field offset: 0x0
	private const float PLAYER_NAME_POSX = -260; //Field offset: 0x0
	private const float PLAYER_SPRITE_POSX = -93.5; //Field offset: 0x0
	private const float BOSS_NAME_POSX = 260; //Field offset: 0x0
	private const float BOSS_SPRITE_POSX = 93.5; //Field offset: 0x0
	private const float CHARACTER_DURATION = 0.5; //Field offset: 0x0
	private const string PLAYER_NAME = "player_name"; //Field offset: 0x0
	private const string PLAYER_NAME_ROOT = "player_name_bg"; //Field offset: 0x0
	private const string PLAYER_SPRITE = "player_sprite"; //Field offset: 0x0
	private const string PLAYER_SECOND_NAME = "player_second_name"; //Field offset: 0x0
	private const string BOSS_SECOND_NAME = "boss_second_name"; //Field offset: 0x0
	private const string BOSS_NAME = "boss_name"; //Field offset: 0x0
	private const string BOSS_NAME_ROOT = "boss_name_bg"; //Field offset: 0x0
	private readonly Vector3 ORIGINAL_SCALE; //Field offset: 0x114
	private Image m_BossSprite; //Field offset: 0x120
	private Image m_PlayerSprite; //Field offset: 0x124
	private Transform m_BossNameRoot; //Field offset: 0x128
	private Transform m_PlayerNameRoot; //Field offset: 0x12C
	private GameObject m_NameBarObj; //Field offset: 0x130
	private int m_BossID; //Field offset: 0x134
	private int m_PlayerID; //Field offset: 0x138
	private bool enableBossNameAnimation; //Field offset: 0x13C
	private bool enablePlayerNameAnimation; //Field offset: 0x13D

	public CharacterBarDisp() { }

	[CompilerGenerated]
	private void <BossNameUIAnimeInit>b__33_0() { }

	[CompilerGenerated]
	private void <InitLayout>b__27_0(AssetBundleLoadAssetOperation asset) { }

	[CompilerGenerated]
	private void <InitLayout>b__27_1(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <InitLayout>b__27_2(AssetBundleLoadAssetOperation asset) { }

	[CompilerGenerated]
	private void <PlayerNameUIAnimeInit>b__35_0() { }

	private void BossNameUIAnimeInit() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitCharacterName(Transform root, string textObjName, string secondTextObjName, string name, string secondName) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	private void PlayBossSpriteAnime() { }

	private void PlayerNameUIAnimeInit() { }

	public void PlayFadeInAnimation() { }

	private void PlayPlayerSpriteAnime() { }

	public virtual void ReleaseAll() { }

	public void SetFirstSibling() { }

	private void SetNameCanvas(GameObject obj) { }

	public void Shake() { }

	protected virtual void UpdateDispMain() { }

}

