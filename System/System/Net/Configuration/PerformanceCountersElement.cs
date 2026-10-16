namespace System.Net.Configuration;

public sealed class PerformanceCountersElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public PerformanceCountersElement() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

