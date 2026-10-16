namespace Heqet.Danmaku;

public class StageParams : MonoBehaviour
{
	[Header("毒 ダメージ値")]
	[SerializeField]
	public float PoisonedValue; //Field offset: 0x10
	[Header("毒 効果発動間隔(秒)")]
	[SerializeField]
	public float TimeOfPoisoned; //Field offset: 0x14
	[Header("砂愁の奇病 効果発動間隔(秒)")]
	[SerializeField]
	public float TimeOfSandstorm; //Field offset: 0x18
	[Header("赤い夜 ダメージ値")]
	[SerializeField]
	public float RedNightValue; //Field offset: 0x1C
	[Header("赤い夜 効果発動間隔(秒)")]
	[SerializeField]
	public float TimeOfRedNight; //Field offset: 0x20

	public StageParams() { }

}

