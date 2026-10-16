namespace D4L.Dao.MiniJSON;

public static class Json
{
	private sealed class Serializer
	{
		private StringBuilder builder; //Field offset: 0x8

		private Serializer() { }

		public static string Serialize(object obj) { }

		private void SerializeArray(IList anArray) { }

		private void SerializeObject(IDictionary obj) { }

		private void SerializeOther(object value) { }

		private void SerializeString(string str) { }

		private void SerializeValue(object value) { }

	}


	public static string Serialize(object obj) { }

}

