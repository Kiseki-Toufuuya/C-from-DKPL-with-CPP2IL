namespace Heqet.RG;

public class CISModel
{
	internal class BPMData
	{
		public float beat; //Field offset: 0x8
		public float bpm; //Field offset: 0xC

		public BPMData(float beat_, float bpm_) { }

	}

	internal class HeaderData
	{
		public float bpm; //Field offset: 0x8
		public float offset; //Field offset: 0xC
		public List<BPMData> bpms; //Field offset: 0x10
		public List<StopData> stops; //Field offset: 0x14

		public HeaderData() { }

	}

	internal class LaneData
	{
		public int meter; //Field offset: 0x8
		private int laneId; //Field offset: 0xC
		public List<NoteData> noteList; //Field offset: 0x10

		public int LaneId
		{
			 get { } //Length: 11
		}

		private LaneData() { }

		public LaneData(int laneId_) { }

		public void CreateNote(int meter_) { }

		public int get_LaneId() { }

		public NoteData GetNote(int beatIndex) { }

	}

	internal class MeasureData
	{
		public List<LaneData> laneList; //Field offset: 0x8
		public List<LaneData> eventLaneList; //Field offset: 0xC

		public MeasureData() { }

		public LaneData AddLane() { }

		public LaneData GetLane(int laneId, bool create = false) { }

	}

	internal class NoteData
	{
		public int type; //Field offset: 0x8
		public int option; //Field offset: 0xC
		public NoteExtensionData extension; //Field offset: 0x10
		public List<NoteData> link; //Field offset: 0x14
		public float eventBeat; //Field offset: 0x18

		public NoteData() { }

	}

	internal class StopData
	{
		public float beat; //Field offset: 0x8
		public float duration; //Field offset: 0xC

		public StopData(float beat_, float duration_) { }

	}

	[SerializeField]
	public HeaderData Header; //Field offset: 0x8
	[SerializeField]
	public List<MeasureData> MeasureList; //Field offset: 0xC

	public CISModel() { }

	public int AllNotesCount() { }

	public void Clear() { }

}

