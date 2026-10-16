namespace Unity.Services.Analytics;

internal class ConsentManager : IConsentManager
{
	[CompilerGenerated]
	private bool <UsingOriginalFlow>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <UsingDataFrameworkFlow>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	private bool <DataFrameworkConsentGranted>k__BackingField; //Field offset: 0xA
	[CompilerGenerated]
	private Action ConsentGranted; //Field offset: 0xC
	[CompilerGenerated]
	private Action ConsentRevoked; //Field offset: 0x10

	public override event Action ConsentGranted
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public override event Action ConsentRevoked
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public override bool DataFrameworkConsentGranted
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override bool UsingDataFrameworkFlow
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private bool UsingOriginalFlow
	{
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ConsentManager() { }

	[CompilerGenerated]
	public override void add_ConsentGranted(Action value) { }

	[CompilerGenerated]
	public override void add_ConsentRevoked(Action value) { }

	[CompilerGenerated]
	public override bool get_DataFrameworkConsentGranted() { }

	[CompilerGenerated]
	public override bool get_UsingDataFrameworkFlow() { }

	internal void Initialize() { }

	public override void LockInOriginalFlow() { }

	[CompilerGenerated]
	public override void remove_ConsentGranted(Action value) { }

	[CompilerGenerated]
	public override void remove_ConsentRevoked(Action value) { }

	[CompilerGenerated]
	private void set_UsingOriginalFlow(bool value) { }

}

