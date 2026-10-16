namespace D4L.DomainEvents;

public static class DomainEvents
{
	[CompilerGenerated]
	private static ICallbackContainer <CallbackContainer>k__BackingField; //Field offset: 0x0

	public static ICallbackContainer CallbackContainer
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 84
	}

	private static DomainEvents() { }

	[CompilerGenerated]
	public static ICallbackContainer get_CallbackContainer() { }

	public static void Raise(TEvent event) { }

	public static IDisposable RegisterCallback(Action<TEvent> callback) { }

	[CompilerGenerated]
	public static void set_CallbackContainer(ICallbackContainer value) { }

}

