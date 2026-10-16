namespace Heqet;

public class SpotMapChip : MonoBehaviour
{
	public SpriteRenderer beforeSpotMode; //Field offset: 0x10
	public SpriteRenderer beforeStageMode; //Field offset: 0x14
	public SpriteRenderer afterSpotMode; //Field offset: 0x18
	public SpriteRenderer afterStageMode; //Field offset: 0x1C
	private bool isReconstruction; //Field offset: 0x20

	public SpotMapChip() { }

	public void FadeMapChipAlpha(bool isSpotMode, float alpha) { }

	public void Reconstruction(bool Reconstruction) { }

	private void Reset() { }

}

