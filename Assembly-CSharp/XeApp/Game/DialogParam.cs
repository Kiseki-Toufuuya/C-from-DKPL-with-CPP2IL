namespace XeApp.Game;

public class DialogParam
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LoadContext> <>9__3_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Initialize>b__3_1(LoadContext context) { }

	}

	internal class DialogChildParameter
	{
		public int id; //Field offset: 0x8
		public string name; //Field offset: 0xC
		public string parentName; //Field offset: 0x10
		public string connectName; //Field offset: 0x14
		public String[] text; //Field offset: 0x18
		public String[] image; //Field offset: 0x1C
		public String[] objects; //Field offset: 0x20

		public DialogChildParameter() { }

	}

	internal class DialogParamData
	{
		public List<DialogChildParameter> childParameter; //Field offset: 0x8

		public DialogParamData() { }

	}

	public DialogParamData dialogData; //Field offset: 0x8

	public DialogParam() { }

	[CompilerGenerated]
	private void <Initialize>b__3_0(LoadContext context) { }

	public DialogChildParameter GetChildParameter(int id) { }

	public void Initialize() { }

}

