namespace Heqet.RG;

public class ScorePreview : MonoBehaviour
{
	private const float SEEK_TIME = 5; //Field offset: 0x0
	public RhythmGame rg; //Field offset: 0x10
	public GameObject gameCamera; //Field offset: 0x14
	private bool initialized; //Field offset: 0x18

	public ScorePreview() { }

}

