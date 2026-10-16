namespace Unity.Services.Analytics;

internal interface IConsentManager
{

	public event Action ConsentGranted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action ConsentRevoked
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool DataFrameworkConsentGranted
	{
		 get { } //Length: 0
	}

	public bool UsingDataFrameworkFlow
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ConsentGranted(Action value) { }

	[CompilerGenerated]
	public void add_ConsentRevoked(Action value) { }

	public bool get_DataFrameworkConsentGranted() { }

	public bool get_UsingDataFrameworkFlow() { }

	[CompilerGenerated]
	public void remove_ConsentGranted(Action value) { }

	[CompilerGenerated]
	public void remove_ConsentRevoked(Action value) { }

}

