namespace XeApp.Core;

public class TaskObjectPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static OrderHandle<T, T> <>9__56_0; //Field offset: 0x0
		public static OrderHandle<T, T> <>9__56_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveAll>b__56_0(T t) { }

		internal bool <RemoveAll>b__56_1(T t) { }

	}

	public sealed class FTask
	{
		public T Item; //Field offset: 0x0
		public FTask<T, T> Next; //Field offset: 0x0
		public FTask<T, T> Prev; //Field offset: 0x0
		public int Status; //Field offset: 0x0

		public FTask`1() { }

		public void LinkBefore(FTask<T, T> tail, int status) { }

		public void Unlink() { }

	}

	public sealed class FTaskList
	{
		public FTask<T, T> Head; //Field offset: 0x0
		public FTask<T, T> Tail; //Field offset: 0x0
		[CompilerGenerated]
		private int <Count>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private int <MaxCount>k__BackingField; //Field offset: 0x0
		public int Status; //Field offset: 0x0

		public private int Count
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public bool IsEmpty
		{
			 get { } //Length: 41
		}

		public private int MaxCount
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public FTaskList(int st) { }

		public FTask<T, T> Find(T item) { }

		[CompilerGenerated]
		public int get_Count() { }

		public bool get_IsEmpty() { }

		[CompilerGenerated]
		public int get_MaxCount() { }

		public FTask<T, T> PopFront() { }

		public void PushBack(FTask<T, T> t) { }

		[CompilerGenerated]
		private void set_Count(int value) { }

		[CompilerGenerated]
		private void set_MaxCount(int value) { }

		public void Unlink(FTask<T, T> t) { }

	}

	internal sealed class OnCreateNewItem : MulticastDelegate
	{

		public OnCreateNewItem(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke() { }

	}

	internal sealed class OnNotifyStatus : MulticastDelegate
	{

		public OnNotifyStatus(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T item, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T item) { }

	}

	internal sealed class OrderHandle : MulticastDelegate
	{

		public OrderHandle`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T item, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(T item) { }

	}

	internal const int TASK_NONE = 0; //Field offset: 0x0
	internal const int TASK_DEACTIVE = 1; //Field offset: 0x0
	internal const int TASK_STANBY = 2; //Field offset: 0x0
	internal const int TASK_ACTIVE = 3; //Field offset: 0x0
	public string DebugName; //Field offset: 0x0
	public bool IsUseTaskItemMap; //Field offset: 0x0
	public int MaxCreateWarningCount; //Field offset: 0x0
	public int MaxCreateCount; //Field offset: 0x0
	private int DeactiveStartFrame; //Field offset: 0x0
	private int DelayStanbyCounter; //Field offset: 0x0
	public int AutoDelayDeactiveDurationFrame; //Field offset: 0x0
	public int AutoDelayDeactiveStartFrame; //Field offset: 0x0
	public int AutoDelayStanbyLimitCount; //Field offset: 0x0
	public OnNotifyStatus<T> onChangeRemove; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsCreateWarnig>k__BackingField; //Field offset: 0x0
	public OnNotifyStatus<T> onChangeDeactive; //Field offset: 0x0
	public OnNotifyStatus<T> onChangeStanby; //Field offset: 0x0
	public OnNotifyStatus<T> onChangeActive; //Field offset: 0x0
	public OnCreateNewItem<T> onCreateNewItem; //Field offset: 0x0
	private FTaskList<T> DeactiveList; //Field offset: 0x0
	private FTaskList<T> StanbyList; //Field offset: 0x0
	private FTaskList<T> ActiveList; //Field offset: 0x0
	private Dictionary<T, FTask`1<T, T>> TaskItemMap; //Field offset: 0x0
	public bool IsEnableDelayDeactive; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsCreateWarnigWithReport>k__BackingField; //Field offset: 0x0

	public int ActiveCount
	{
		 get { } //Length: 51
	}

	public int ActiveMaxCount
	{
		 get { } //Length: 51
	}

	public int Capacity
	{
		 get { } //Length: 100
	}

	public int DeactiveCount
	{
		 get { } //Length: 51
	}

	public bool IsCreateWarnig
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsCreateWarnigWithReport
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int StanbyCount
	{
		 get { } //Length: 51
	}

	public TaskObjectPool`1() { }

	[CompilerGenerated]
	private bool <RemoveAll>b__56_2(T t) { }

	public void AutoDelayDeactive() { }

	private void ChageToDeactive(FTask<T, T> t) { }

	private void ChageToStanby(FTask<T, T> t) { }

	public void ExecuteActiveList(OrderHandle<T, T> order) { }

	public void ExecuteDeactiveList(OrderHandle<T, T> order) { }

	public void ExecuteStanbyList(OrderHandle<T, T> order) { }

	public int get_ActiveCount() { }

	public int get_ActiveMaxCount() { }

	public int get_Capacity() { }

	public int get_DeactiveCount() { }

	[CompilerGenerated]
	public bool get_IsCreateWarnig() { }

	[CompilerGenerated]
	public bool get_IsCreateWarnigWithReport() { }

	public int get_StanbyCount() { }

	public void RemoveAll() { }

	public void RemoveFromActiveList(T item) { }

	public T RequestToActiveList() { }

	public void ReserveToStanbyList(int n) { }

	[CompilerGenerated]
	public void set_IsCreateWarnig(bool value) { }

	[CompilerGenerated]
	public void set_IsCreateWarnigWithReport(bool value) { }

	private void Unlink(FTask<T, T> t) { }

}

