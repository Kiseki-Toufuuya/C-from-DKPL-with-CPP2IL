namespace XeApp.Core;

public class ForceSafeAreaDeviceList
{
	internal class Setting
	{
		public string Name; //Field offset: 0x8
		public bool IsContain; //Field offset: 0xC
		public float WidthRate; //Field offset: 0x10
		public float HeightRate; //Field offset: 0x14

		public Setting() { }

	}

	private static readonly Setting[] Settings; //Field offset: 0x0

	private static ForceSafeAreaDeviceList() { }

	public ForceSafeAreaDeviceList() { }

	public static Setting GetSetting(string modelName) { }

}

