namespace CriWare;

[Obsolete("Use CriWare.CriAtomExOutputAnalyzer")]
public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer
{
	internal struct Config
	{
		public int num_spectrum_analyzer_bands; //Field offset: 0x0
		public int num_stored_output_data; //Field offset: 0x4

		public Config(int num_spectrum_analyzer_bands = 8, int num_stored_output_data = 4096) { }

	}

	internal enum Type
	{
		LevelMeter = 0,
		SpectrumAnalyzer = 1,
		PcmCapture = 2,
	}


	public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null) { }

}

