namespace D4L.TakashoFes.DataContext;

public sealed class CardR3ExpAccessor : FlatBuffersAccessorBase<CardR3Exp, CardR3ExpEntry, GuardInt>, ICardR3ExpAccessor, IFlatBuffersAccessor<CardR3Exp, CardR3ExpEntry, GuardInt>, IDaoAccessor<CardR3Exp, CardR3ExpEntry, GuardInt>
{

	public CardR3ExpAccessor() { }

	protected virtual CardR3Exp Parse(Byte[] source) { }

}

