namespace System.Diagnostics;

public class TraceSource
{
	private static List<WeakReference> tracesources; //Field offset: 0x0
	private static int s_LastCollectionCount; //Field offset: 0x4
	private SourceSwitch internalSwitch; //Field offset: 0x8
	private TraceListenerCollection listeners; //Field offset: 0xC
	private StringDictionary attributes; //Field offset: 0x10
	private SourceLevels switchLevel; //Field offset: 0x14
	private string sourceName; //Field offset: 0x18
	internal bool _initCalled; //Field offset: 0x1C

	public TraceListenerCollection Listeners
	{
		 get { } //Length: 31
	}

	public SourceSwitch Switch
	{
		 get { } //Length: 31
	}

	private static void _pruneCachedTraceSources() { }

	private static TraceSource() { }

	public TraceSource(string name) { }

	public TraceSource(string name, SourceLevels defaultLevel) { }

	public void Flush() { }

	public TraceListenerCollection get_Listeners() { }

	public SourceSwitch get_Switch() { }

	private void Initialize() { }

	private void NoConfigInit() { }

}

