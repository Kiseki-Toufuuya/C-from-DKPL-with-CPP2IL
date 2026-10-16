namespace D4L.TakashoFes.DataContext;

public sealed class ComboMaxAccessor : FlatBuffersAccessorBase<ComboMax, ComboMaxEntry, Int32>, IComboMaxAccessor, IFlatBuffersAccessor<ComboMax, ComboMaxEntry, Int32>, IDaoAccessor<ComboMax, ComboMaxEntry, Int32>
{

	public ComboMaxAccessor() { }

	protected virtual ComboMax Parse(Byte[] source) { }

}

