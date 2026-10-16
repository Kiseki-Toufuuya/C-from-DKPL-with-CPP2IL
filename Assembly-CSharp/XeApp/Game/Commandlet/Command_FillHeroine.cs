namespace XeApp.Game.Commandlet;

public class Command_FillHeroine : ICommand
{
	[CompilerGenerated]
	private struct <Command>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public override string Name
	{
		 get { } //Length: 35
	}

	public Command_FillHeroine() { }

	[AsyncStateMachine(typeof(<Command>d__2))]
	public override Task<Int32> Command(String[] args) { }

	public override string get_Name() { }

}

