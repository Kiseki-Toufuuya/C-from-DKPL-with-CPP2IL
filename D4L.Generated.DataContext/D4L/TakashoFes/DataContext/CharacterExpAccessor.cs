namespace D4L.TakashoFes.DataContext;

public sealed class CharacterExpAccessor : FlatBuffersAccessorBase<CharacterExp, CharacterExpEntry, GuardInt>, ICharacterExpAccessor, IFlatBuffersAccessor<CharacterExp, CharacterExpEntry, GuardInt>, IDaoAccessor<CharacterExp, CharacterExpEntry, GuardInt>
{

	public CharacterExpAccessor() { }

	protected virtual CharacterExp Parse(Byte[] source) { }

}

