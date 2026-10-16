namespace Unity.Profiling;

[IsReadOnly]
public struct ProfilerCounterValue
{

	public T Value
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public ProfilerCounterValue`1(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) { }

	public ProfilerCounterValue`1(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit, ProfilerCounterOptions counterOptions) { }

	public T get_Value() { }

	public void set_Value(T value) { }

}

