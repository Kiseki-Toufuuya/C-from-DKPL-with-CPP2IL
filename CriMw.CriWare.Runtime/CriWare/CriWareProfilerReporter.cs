namespace CriWare;

internal class CriWareProfilerReporter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UInt32> <>9__3_0; //Field offset: 0x4
		public static Func<UInt32> <>9__3_1; //Field offset: 0x8
		public static Func<UInt32> <>9__3_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal uint <.ctor>b__3_0() { }

		internal uint <.ctor>b__3_1() { }

		internal uint <.ctor>b__3_2() { }

	}

	internal enum TargetReporterName
	{
		Atom = 0,
		Mana = 1,
		Fs = 2,
		Total = 3,
	}

	private List<CriWareMemoryReporter> memoryReporters; //Field offset: 0x8
	private CriWareMemoryReporter totalReporter; //Field offset: 0xC

	public CriWareProfilerReporter() { }

	public void UpdateMeasure() { }

}

