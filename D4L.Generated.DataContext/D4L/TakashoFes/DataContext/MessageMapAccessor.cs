namespace D4L.TakashoFes.DataContext;

public sealed class MessageMapAccessor : FlatBuffersAccessorBase<MessageMap, MessageMapEntry, Int64>, IMessageMapAccessor, IFlatBuffersAccessor<MessageMap, MessageMapEntry, Int64>, IDaoAccessor<MessageMap, MessageMapEntry, Int64>
{
	private Dictionary<String, Int64> _LabelIndex; //Field offset: 0x14

	public MessageMapAccessor() { }

	public override void BuildAllIndex() { }

	private void BuildLabelIndex() { }

	protected virtual MessageMap Parse(Byte[] source) { }

	public override MessageMapEntry TryGetByLabel(string key) { }

}

