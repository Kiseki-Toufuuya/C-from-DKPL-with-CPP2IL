namespace D4L.TakashoFes.DataContext;

public sealed class CharacterAccessor : FlatBuffersAccessorBase<Character, CharacterEntry, GuardInt>, ICharacterAccessor, IFlatBuffersAccessor<Character, CharacterEntry, GuardInt>, IDaoAccessor<Character, CharacterEntry, GuardInt>
{

	public CharacterAccessor() { }

	protected virtual Character Parse(Byte[] source) { }

}

