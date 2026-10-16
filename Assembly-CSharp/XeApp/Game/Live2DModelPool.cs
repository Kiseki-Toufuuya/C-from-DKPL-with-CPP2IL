namespace XeApp.Game;

public class Live2DModelPool
{
	private const int poolInitialSize = 10; //Field offset: 0x0
	private const int poolReserveFactor = 2; //Field offset: 0x0
	private List<Live2DModel> pool; //Field offset: 0x8
	private List<Live2DModel> freeList; //Field offset: 0xC
	public List<Live2DModel> activeList; //Field offset: 0x10

	public int ActiveObjectCount
	{
		 get { } //Length: 52
		 set { } //Length: 3
	}

	public int FreeObjectCount
	{
		 get { } //Length: 52
		 set { } //Length: 3
	}

	public int PoolSize
	{
		 get { } //Length: 52
		 set { } //Length: 3
	}

	public Live2DModelPool() { }

	public void EnableActiveMode(bool inEnable) { }

	public int get_ActiveObjectCount() { }

	public int get_FreeObjectCount() { }

	public int get_PoolSize() { }

	public void Initialize() { }

	public void RefreshFreeModel() { }

	public void ReleaseActiveModel(Live2DModel model) { }

	public Live2DModel RequestFreeModel(string modelPath, string animePath) { }

	public void Reserve(int size) { }

	public void set_ActiveObjectCount(int value) { }

	public void set_FreeObjectCount(int value) { }

	public void set_PoolSize(int value) { }

}

