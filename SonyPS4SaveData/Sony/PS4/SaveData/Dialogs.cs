namespace Sony.PS4.SaveData;

public class Dialogs
{
	internal class NewItem
	{
		internal string iconPath; //Field offset: 0x8
		internal string title; //Field offset: 0xC
		internal Byte[] rawPNG; //Field offset: 0x10
		internal ulong pngDataSize; //Field offset: 0x18

		public string IconPath
		{
			 get { } //Length: 11
		}

		public Byte[] RawPNG
		{
			 get { } //Length: 11
		}

		public string get_IconPath() { }

		public Byte[] get_RawPNG() { }

	}


}

