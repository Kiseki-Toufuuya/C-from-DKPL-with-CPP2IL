namespace Heqet.WorldMap;

public class SpotSector : MonoBehaviour
{
	[SerializeField]
	private SpotPoint SpotPointA; //Field offset: 0x10
	[SerializeField]
	private SpotPoint SpotPointB; //Field offset: 0x14

	public SpotSector() { }

	private bool IsRenaissance(int spotId) { }

	public void UpdateVisible() { }

}

