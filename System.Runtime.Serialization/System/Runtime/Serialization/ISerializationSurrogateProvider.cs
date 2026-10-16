namespace System.Runtime.Serialization;

public interface ISerializationSurrogateProvider
{

	public object GetDeserializedObject(object obj, Type targetType) { }

	public object GetObjectToSerialize(object obj, Type targetType) { }

	public Type GetSurrogateType(Type type) { }

}

