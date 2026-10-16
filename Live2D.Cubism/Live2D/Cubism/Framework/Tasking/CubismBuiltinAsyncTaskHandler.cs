namespace Live2D.Cubism.Framework.Tasking;

public static class CubismBuiltinAsyncTaskHandler
{
	[CompilerGenerated]
	private static Queue<ICubismTask> <Tasks>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static Thread <Worker>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static object <Lock>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static ManualResetEvent <Signal>k__BackingField; //Field offset: 0xC
	private static bool _callItADay; //Field offset: 0x10

	private static bool CallItADay
	{
		private get { } //Length: 280
		private set { } //Length: 252
	}

	private static object Lock
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	private static ManualResetEvent Signal
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	private static Queue<ICubismTask> Tasks
	{
		[CompilerGenerated]
		private get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	private static Thread Worker
	{
		[CompilerGenerated]
		private get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public static void Activate() { }

	public static void Deactivate() { }

	private static ICubismTask DequeueTask() { }

	private static void EnqueueTask(ICubismTask task) { }

	private static bool get_CallItADay() { }

	[CompilerGenerated]
	private static object get_Lock() { }

	[CompilerGenerated]
	private static ManualResetEvent get_Signal() { }

	[CompilerGenerated]
	private static Queue<ICubismTask> get_Tasks() { }

	[CompilerGenerated]
	private static Thread get_Worker() { }

	private static void set_CallItADay(bool value) { }

	[CompilerGenerated]
	private static void set_Lock(object value) { }

	[CompilerGenerated]
	private static void set_Signal(ManualResetEvent value) { }

	[CompilerGenerated]
	private static void set_Tasks(Queue<ICubismTask> value) { }

	[CompilerGenerated]
	private static void set_Worker(Thread value) { }

	private static void Work() { }

}

