namespace CriWare;

[Obsolete("This feature is obsoleted. Estimation will not occur if SonicSYNC is enabled.")]
public static class CriAtomExLatencyEstimator
{
	internal struct EstimatorInfo
	{
		public Status status; //Field offset: 0x0
		public uint estimated_latency; //Field offset: 0x4

	}

	internal enum Status
	{
		Stop = 0,
		Processing = 1,
		Done = 2,
		Error = 3,
	}


	public static void FinalizeModule() { }

	public static EstimatorInfo GetCurrentInfo() { }

	public static void InitializeModule() { }

}

