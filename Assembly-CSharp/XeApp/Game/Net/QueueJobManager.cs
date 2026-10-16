namespace XeApp.Game.Net;

public class QueueJobManager
{
	internal interface IQueueJob
	{

		public void OnFinish() { }

		public bool OnProcessing() { }

		public void OnStart() { }

	}

	internal class SemaphoJob : IQueueJob
	{
		public bool IsProcessing; //Field offset: 0x8

		public SemaphoJob() { }

		public override void OnFinish() { }

		public override bool OnProcessing() { }

		public override void OnStart() { }

	}

	public int ActiveMax; //Field offset: 0x8
	private Queue<IQueueJob> Requests; //Field offset: 0xC
	private Queue<IQueueJob> ActiveLists; //Field offset: 0x10

	public int RestCount
	{
		 get { } //Length: 52
	}

	public QueueJobManager() { }

	public void Add(IQueueJob job) { }

	public int get_RestCount() { }

	public void Update() { }

}

