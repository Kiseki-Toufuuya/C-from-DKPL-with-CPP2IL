namespace XeSys;

public abstract class ImageFontWriter
{
	internal class StringInfo
	{
		[CompilerGenerated]
		private float <x>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private float <y>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private string <text>k__BackingField; //Field offset: 0x10

		public string text
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public float x
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 18
		}

		public float y
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 18
		}

		public StringInfo(float x_, float y_, string text_) { }

		[CompilerGenerated]
		public string get_text() { }

		[CompilerGenerated]
		public float get_x() { }

		[CompilerGenerated]
		public float get_y() { }

		[CompilerGenerated]
		public void set_text(string value) { }

		[CompilerGenerated]
		public void set_x(float value) { }

		[CompilerGenerated]
		public void set_y(float value) { }

	}

	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ImageFontResource <resource>k__BackingField; //Field offset: 0xC
	protected List<StringInfo> mStringList; //Field offset: 0x10

	public private string name
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private ImageFontResource resource
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private ImageFontWriter() { }

	public ImageFontWriter(string name_) { }

	public void AddText(float x, float y, string text) { }

	[CompilerGenerated]
	public string get_name() { }

	[CompilerGenerated]
	public ImageFontResource get_resource() { }

	[CompilerGenerated]
	private void set_name(string value) { }

	[CompilerGenerated]
	private void set_resource(ImageFontResource value) { }

	public void SetResource(ImageFontResource res) { }

}

