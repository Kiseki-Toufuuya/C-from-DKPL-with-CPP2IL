namespace Sony.PS4.SaveData;

public class SaveDataException : Exception
{
	internal APIResultTypes resultType; //Field offset: 0x48

	public SaveDataException(string message) { }

}

