namespace Unity.Services.Analytics;

internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls
{

	public override DateTime UtcNow
	{
		 get { } //Length: 60
	}

	public AnalyticsServiceSystemCalls() { }

	public override DateTime get_UtcNow() { }

}

