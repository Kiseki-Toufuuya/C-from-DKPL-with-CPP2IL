namespace UnityEngine.UIElements;

public class DynamicAtlasSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_MinAtlasSize; //Field offset: 0x8
	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize; //Field offset: 0xC
	[HideInInspector]
	[SerializeField]
	private int m_MaxSubTextureSize; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x14
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x18

	public DynamicAtlasFilters activeFilters
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public DynamicAtlasCustomFilter customFilter
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public static DynamicAtlasFilters defaultFilters
	{
		 get { } //Length: 11
	}

	public static DynamicAtlasSettings defaults
	{
		 get { } //Length: 119
	}

	public int maxAtlasSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int maxSubTextureSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int minAtlasSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public DynamicAtlasSettings() { }

	public DynamicAtlasFilters get_activeFilters() { }

	public DynamicAtlasCustomFilter get_customFilter() { }

	public static DynamicAtlasFilters get_defaultFilters() { }

	public static DynamicAtlasSettings get_defaults() { }

	public int get_maxAtlasSize() { }

	public int get_maxSubTextureSize() { }

	public int get_minAtlasSize() { }

	public void set_activeFilters(DynamicAtlasFilters value) { }

	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	public void set_maxAtlasSize(int value) { }

	public void set_maxSubTextureSize(int value) { }

	public void set_minAtlasSize(int value) { }

}

