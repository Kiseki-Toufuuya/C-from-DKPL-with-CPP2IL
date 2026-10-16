namespace D4L.TakashoFes.DataContext;

public sealed class CardR4ExpAccessor : FlatBuffersAccessorBase<CardR4Exp, CardR4ExpEntry, GuardInt>, ICardR4ExpAccessor, IFlatBuffersAccessor<CardR4Exp, CardR4ExpEntry, GuardInt>, IDaoAccessor<CardR4Exp, CardR4ExpEntry, GuardInt>
{

	public CardR4ExpAccessor() { }

	protected virtual CardR4Exp Parse(Byte[] source) { }

}

