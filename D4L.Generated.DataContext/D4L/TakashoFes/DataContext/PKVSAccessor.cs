namespace D4L.TakashoFes.DataContext;

public sealed class PKVSAccessor : FlatBuffersAccessorBase<PKVS, PKVSEntry, Int32>, IPKVSAccessor, IFlatBuffersAccessor<PKVS, PKVSEntry, Int32>, IDaoAccessor<PKVS, PKVSEntry, Int32>
{
	private Dictionary<Int32, Int32[]> _DataVersionIndex; //Field offset: 0x14
	private Dictionary<Int32, Int32[]> _EnableIndex; //Field offset: 0x18
	private Dictionary<String, Int32[]> _LabelIndex; //Field offset: 0x1C
	private Dictionary<Int32, Int32[]> _ImageIdIndex; //Field offset: 0x20

	public PKVSAccessor() { }

	protected virtual PKVS Parse(Byte[] source) { }

}

