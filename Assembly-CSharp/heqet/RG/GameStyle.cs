namespace Heqet.RG;

public class GameStyle : MonoBehaviour
{
	[SerializeField]
	public string Name; //Field offset: 0x10
	[SerializeField]
	private GameCamera gameCamera; //Field offset: 0x14
	[SerializeField]
	private LaneController laneController; //Field offset: 0x18
	private RhythmGame rhythmGame; //Field offset: 0x1C
	[SerializeField]
	private LineRenderer judgeLine; //Field offset: 0x20
	[SerializeField]
	private float measureLengthOnView; //Field offset: 0x24
	[SerializeField]
	private float notesSpeedAdjust; //Field offset: 0x28
	public UnityEvent OnInitialize; //Field offset: 0x2C

	public GameCamera GameCamera
	{
		 get { } //Length: 11
	}

	public LineRenderer JudgeLine
	{
		 get { } //Length: 11
	}

	public LaneController LaneController
	{
		 get { } //Length: 11
	}

	public float MeasureLengthOnView
	{
		 get { } //Length: 11
	}

	public float NotesSpeedAdjust
	{
		 get { } //Length: 11
	}

	public RhythmGame RhythmGame
	{
		 get { } //Length: 11
	}

	public GameStyle() { }

	private void Awake() { }

	public GameCamera get_GameCamera() { }

	public LineRenderer get_JudgeLine() { }

	public LaneController get_LaneController() { }

	public float get_MeasureLengthOnView() { }

	public float get_NotesSpeedAdjust() { }

	public RhythmGame get_RhythmGame() { }

	public void Initialize(RhythmGame rhythmGame_) { }

}

