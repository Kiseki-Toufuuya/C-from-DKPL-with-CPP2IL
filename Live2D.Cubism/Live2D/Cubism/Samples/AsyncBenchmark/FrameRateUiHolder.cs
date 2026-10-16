namespace Live2D.Cubism.Samples.AsyncBenchmark;

public class FrameRateUiHolder : MonoBehaviour
{
	[SerializeField]
	public bool HasShownFrameRate; //Field offset: 0x10
	[SerializeField]
	public bool HasShownElapsedTime; //Field offset: 0x11
	[SerializeField]
	public Text HighestFrameRateUi; //Field offset: 0x14
	[SerializeField]
	public Text LowestFrameRateUi; //Field offset: 0x18
	[SerializeField]
	public Text ElapsedTimeUi; //Field offset: 0x1C

	public FrameRateUiHolder() { }

}

