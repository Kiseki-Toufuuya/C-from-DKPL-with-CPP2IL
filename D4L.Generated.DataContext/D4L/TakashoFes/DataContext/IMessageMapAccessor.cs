namespace D4L.TakashoFes.DataContext;

public interface IMessageMapAccessor : IFlatBuffersAccessor<MessageMap, MessageMapEntry, Int64>, IDaoAccessor<MessageMap, MessageMapEntry, Int64>
{

	public void BuildAllIndex() { }

	public MessageMapEntry TryGetByLabel(string key) { }

}

