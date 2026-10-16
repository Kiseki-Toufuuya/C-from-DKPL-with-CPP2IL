namespace Heqet.Danmaku;

public class BarrageDifficultyLevelAdjustingModule : MonoBehaviour
{
	[SerializeField]
	internal enum AdjustElement
	{
		None = 0,
		FiringInterval = 1,
		WayCount = 2,
		BurstNum = 3,
		SimulationSpeed = 4,
	}

	internal class AdjustParticle
	{
		public ParticleSystem barrage; //Field offset: 0x8
		public AdjustElement adjustElement; //Field offset: 0xC

		public AdjustParticle() { }

	}

	private const float STANDARD_DIFFICULTY = 1; //Field offset: 0x0
	[Range(0, 1)]
	[SerializeField]
	private float barrageDensity; //Field offset: 0x10
	[FormerlySerializedAs("adjustBarrageList")]
	[SerializeField]
	private List<AdjustParticle> adjustBarrageDensityList; //Field offset: 0x14
	[SerializeField]
	private float barrageSpeedRatio; //Field offset: 0x18
	[SerializeField]
	private List<ParticleSystem> adjustBarrageSpeedRatioList; //Field offset: 0x1C

	public BarrageDifficultyLevelAdjustingModule() { }

	private void AdjustBurstNum(AdjustParticle adjustParticle) { }

	private void AdjustFireringInterval(AdjustParticle adjustParticle) { }

	private void AdjustSimulationSpeed(AdjustParticle adjustParticle) { }

	private void AdjustSimulationSpeed(ParticleSystem adjustParticle) { }

	private void AdjustWayCount(AdjustParticle adjustParticle) { }

	public void ApplyAdjustment(AdjustParticle adjustParticle) { }

	private void Start() { }

}

