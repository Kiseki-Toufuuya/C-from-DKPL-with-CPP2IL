namespace Heqet.RG;

public class ScoreEditProjectData : IScoreParser
{
	internal class AllNotesData
	{
		public bool enable; //Field offset: 0x8
		public int flick; //Field offset: 0xC
		public int index; //Field offset: 0x10
		public List<Int32> link; //Field offset: 0x14
		public int time; //Field offset: 0x18
		public int trackID; //Field offset: 0x1C
		public int value; //Field offset: 0x20

		public AllNotesData() { }

	}

	internal class APTBassDrumTrackData
	{

		public APTBassDrumTrackData() { }

	}

	internal class BaseNoteTrackData
	{
		public int time; //Field offset: 0x8

		public BaseNoteTrackData() { }

	}

	internal class BeatInfoTrackData
	{

		public BeatInfoTrackData() { }

	}

	internal class ExportSettingData
	{
		public string output; //Field offset: 0x8
		public string outputPNG; //Field offset: 0xC

		public ExportSettingData() { }

	}

	internal class ImportSettingData
	{
		public string bassdrum; //Field offset: 0x8
		public string beat; //Field offset: 0xC
		public string midi; //Field offset: 0x10
		public string snare; //Field offset: 0x14
		public string sync; //Field offset: 0x18
		public string vocal; //Field offset: 0x1C
		public string wav; //Field offset: 0x20

		public ImportSettingData() { }

	}

	internal class SubNoteTrackData
	{
		public int time; //Field offset: 0x8

		public SubNoteTrackData() { }

	}

	internal class TenpoTrackData
	{
		public float bpm; //Field offset: 0x8
		public int length; //Field offset: 0xC
		public int meter; //Field offset: 0x10
		public float offset; //Field offset: 0x14
		public int tacet; //Field offset: 0x18
		public int time; //Field offset: 0x1C

		public TenpoTrackData() { }

	}

	internal class TracksData
	{
		public int groupID; //Field offset: 0x8
		public List<Int32> index; //Field offset: 0xC
		public List<Int32> linkTrackID; //Field offset: 0x10
		public bool mute; //Field offset: 0x14
		public string name; //Field offset: 0x18
		public int trackID; //Field offset: 0x1C
		public int type; //Field offset: 0x20

		public TracksData() { }

	}

	internal class UserNoteTrackSetData
	{
		public List<AllNotesData> AllNotes; //Field offset: 0x8
		public List<TracksData> Tracks; //Field offset: 0xC

		public UserNoteTrackSetData() { }

	}

	public APTBassDrumTrackData APTBassDrumTrack; //Field offset: 0x8
	public List<BaseNoteTrackData> BaseNoteTrack; //Field offset: 0xC
	public List<BeatInfoTrackData> BeatInfoTrack; //Field offset: 0x10
	public List<ExportSettingData> ExportSetting; //Field offset: 0x14
	public List<ImportSettingData> ImportSetting; //Field offset: 0x18
	public List<SubNoteTrackData> SubNoteTrack; //Field offset: 0x1C
	public List<TenpoTrackData> TenpoTrack; //Field offset: 0x20
	public UserNoteTrackSetData UserNoteTrackSet; //Field offset: 0x24
	public bool autoScroll; //Field offset: 0x28
	public float cursorTime; //Field offset: 0x2C
	public int lastQuantizeID; //Field offset: 0x30
	public int lastViewScaleID; //Field offset: 0x34
	public bool muteBaseNoteTrack; //Field offset: 0x38
	public bool muteBassDrum; //Field offset: 0x39
	public bool muteBeatTrack; //Field offset: 0x3A
	public bool muteSnare; //Field offset: 0x3B
	public bool muteSubNoteTrack; //Field offset: 0x3C
	public float viewCenterTime; //Field offset: 0x40
	public float volBeat; //Field offset: 0x44
	public float volMarker; //Field offset: 0x48
	public float volWav; //Field offset: 0x4C

	public ScoreEditProjectData() { }

}

