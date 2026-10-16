namespace Google.Protobuf;

public sealed class InvalidProtocolBufferException : IOException
{

	internal InvalidProtocolBufferException(string message) { }

	internal InvalidProtocolBufferException(string message, Exception innerException) { }

	internal static InvalidProtocolBufferException InvalidBase64(Exception innerException) { }

	internal static InvalidProtocolBufferException InvalidEndTag() { }

	internal static InvalidProtocolBufferException InvalidMessageStreamTag() { }

	internal static InvalidProtocolBufferException InvalidTag() { }

	internal static InvalidProtocolBufferException InvalidWireType() { }

	internal static InvalidProtocolBufferException JsonRecursionLimitExceeded() { }

	internal static InvalidProtocolBufferException MalformedVarint() { }

	internal static InvalidProtocolBufferException MissingFields() { }

	internal static InvalidProtocolBufferException MoreDataAvailable() { }

	internal static InvalidProtocolBufferException NegativeSize() { }

	internal static InvalidProtocolBufferException RecursionLimitExceeded() { }

	internal static InvalidProtocolBufferException SizeLimitExceeded() { }

	internal static InvalidProtocolBufferException TruncatedMessage() { }

}

