namespace Unity.Services.Core.Internal;

internal class UnityServicesInternal : IUnityServices
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		private struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
			public <>c__DisplayClass33_0 <>4__this; //Field offset: 0x10
			private TaskAwaiter<List`1<PackageInitializationInfo>> <>u__1; //Field offset: 0x14

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public DependencyTree dependencyTree; //Field offset: 0x8
		public List<Int32> sortedPackageTypeHashes; //Field offset: 0xC
		public UnityServicesInternal <>4__this; //Field offset: 0x10
		public Stopwatch initStopwatch; //Field offset: 0x14

		public <>c__DisplayClass33_0() { }

		internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

		[AsyncStateMachine(typeof(<<InitializeServicesAsync>g__InitializePackagesAsync|1>d))]
		internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

		internal void <InitializeServicesAsync>g__SortPackages|0() { }

		internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }

	}

	[CompilerGenerated]
	private struct <EnableInitializationAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public UnityServicesInternal <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeServicesAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public UnityServicesInternal <>4__this; //Field offset: 0x10
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; //Field offset: 0x8
	internal bool CanInitialize; //Field offset: 0xC
	private TaskCompletionSource<Object> m_Initialization; //Field offset: 0x10
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; //Field offset: 0x1C

	[NotNull]
	internal CoreRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	private ServicesInitializationState State
	{
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public UnityServicesInternal(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	internal void EnableInitialization() { }

	[AsyncStateMachine(typeof(<EnableInitializationAsync>d__36))]
	internal Task EnableInitializationAsync() { }

	[CompilerGenerated]
	internal CoreRegistry get_Registry() { }

	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(<InitializeServicesAsync>d__33))]
	private Task InitializeServicesAsync() { }

	[CompilerGenerated]
	private void set_State(ServicesInitializationState value) { }

}

