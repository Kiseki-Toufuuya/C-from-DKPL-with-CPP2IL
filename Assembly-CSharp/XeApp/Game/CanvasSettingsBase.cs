namespace XeApp.Game;

public static class CanvasSettingsBase
{
	internal class CanvasSetting
	{
		public eCanvas m_Index; //Field offset: 0x8
		public string m_CanvasName; //Field offset: 0xC
		public bool m_IsSafeAreaScaling; //Field offset: 0x10

		public CanvasSetting(eCanvas index, string name, bool isSafeAreaScaling) { }

	}

	internal enum eCanvas
	{
		SYSTEM2 = 0,
		DEBUG = 1,
		SYSTEM = 2,
		OVER = 3,
		TOP = 4,
		NO_SAFEAREA = 5,
		MIDDLE = 6,
		BOTTOM = 7,
		Background = 8,
		NUM = 9,
		NONE = 10,
	}

	internal enum eLayerIndex
	{
		ROOT = 0,
		SUB1 = 1,
		SUB2 = 2,
		NUM = 3,
	}

	public static CanvasSetting[] m_CanvasSettingData; //Field offset: 0x0

	private static CanvasSettingsBase() { }

	public static void SetUICamera(Camera uiCam) { }

}

