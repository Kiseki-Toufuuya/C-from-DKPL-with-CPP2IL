namespace CriWare;

internal class CriWareMemoryReporter
{
	private ProfilerCounterValue<UInt32> profilerCounter; //Field offset: 0x8
	private Func<UInt32> updateFunc; //Field offset: 0xC

	public CriWareMemoryReporter(string profilerLabel, Func<UInt32> profileUpdateFunc) { }

	public uint UpdateValue() { }

	public void UpdateValue(uint value) { }

}

