namespace System.Runtime.Serialization;

public class InvalidDataContractException : Exception
{

	public InvalidDataContractException() { }

	public InvalidDataContractException(string message) { }

	public InvalidDataContractException(string message, Exception innerException) { }

	protected InvalidDataContractException(SerializationInfo info, StreamingContext context) { }

}

