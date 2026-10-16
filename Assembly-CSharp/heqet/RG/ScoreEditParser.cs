namespace Heqet.RG;

public class ScoreEditParser : IScoreParser
{
	public string FilePath; //Field offset: 0x8
	[CompilerGenerated]
	private string <BGMFile>k__BackingField; //Field offset: 0xC
	public ScoreEditProjectData seproj; //Field offset: 0x10

	public private string BGMFile
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public ScoreEditParser() { }

	[CompilerGenerated]
	public string get_BGMFile() { }

	private string GetBGMFileName() { }

	public bool Load(string datFilePath, string scoreFileName) { }

	private Byte[] ReadBytesFromDatFile(string datFilePath) { }

	[CompilerGenerated]
	private void set_BGMFile(string value) { }

}

