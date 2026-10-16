namespace Heqet.RG;

public class IngameSEManager
{
	private class SEInfo
	{
		public CriAtomExPlayback handle; //Field offset: 0x8
		public bool loop; //Field offset: 0xC
		public int playCount; //Field offset: 0x10

		public SEInfo() { }

	}

	private Dictionary<Int32, SEInfo>[] seInfoTables; //Field offset: 0x8
	private int currentIndex; //Field offset: 0xC
	private CriSeSource seSource; //Field offset: 0x10
	private Stack<SEInfo> seInfoPool; //Field offset: 0x14

	private Dictionary<Int32, SEInfo> CurrentTable
	{
		private get { } //Length: 36
	}

	private Dictionary<Int32, SEInfo> NextTable
	{
		private get { } //Length: 39
	}

	public IngameSEManager() { }

	public void DoLateUpdate() { }

	private Dictionary<Int32, SEInfo> get_CurrentTable() { }

	private Dictionary<Int32, SEInfo> get_NextTable() { }

	public void Initialize() { }

	private void InnerPlay(int id, bool tapSe, bool loop) { }

	public void Pause(bool enable) { }

	public void Play(ALL_SE allSeID) { }

	public void PlayTapSE(int id, bool loop = false) { }

	private SEInfo RentSEInfo() { }

	public void Stop(int id) { }

	public void StopTapSE(int id) { }

	private void SwapTable() { }

	public void Terminate() { }

}

