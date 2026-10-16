namespace System.Data;

public class DataViewManager : MarshalByValueComponent
{
	private static NotSupportedException s_notSupported; //Field offset: 0x0
	private DataViewSettingCollection _dataViewSettingsCollection; //Field offset: 0x10
	internal int _nViews; //Field offset: 0x14

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataViewSettingCollection DataViewSettings
	{
		 get { } //Length: 11
	}

	private static DataViewManager() { }

	public DataViewSettingCollection get_DataViewSettings() { }

}

