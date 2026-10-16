namespace Heqet.RG;

public class ScoreEditLoader : IScoreLoader
{
	internal class XData
	{
		public float bpm; //Field offset: 0x8
		public float beat; //Field offset: 0xC
		public float time; //Field offset: 0x10

		public XData() { }

	}

	public const int maxBeatResolution = 48; //Field offset: 0x0
	public string filePath; //Field offset: 0x8
	public ScoreEditParser parser; //Field offset: 0xC
	[CompilerGenerated]
	private string <BGMFile>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <MusicLength>k__BackingField; //Field offset: 0x14

	public private string BGMFile
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private float MusicLength
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public ScoreEditLoader() { }

	private void CreateBPMData(CISModel model) { }

	private bool CreateHeader(ScoreEditParser parser, CISModel model) { }

	[CompilerGenerated]
	public string get_BGMFile() { }

	[CompilerGenerated]
	public float get_MusicLength() { }

	public XData GetBeatAtSecX(CISModel model, float sec) { }

	public override CISModel Load(string datFilePath, string scoreFileName) { }

	private void LoadSyncData(string scorePath) { }

	[CompilerGenerated]
	private void set_BGMFile(string value) { }

	[CompilerGenerated]
	private void set_MusicLength(float value) { }

	private CISModel ToModel(ScoreEditParser parser) { }

}

