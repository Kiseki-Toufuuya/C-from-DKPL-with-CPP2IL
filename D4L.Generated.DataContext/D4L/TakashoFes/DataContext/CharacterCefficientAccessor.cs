namespace D4L.TakashoFes.DataContext;

public sealed class CharacterCefficientAccessor : FlatBuffersAccessorBase<CharacterCefficient, CharacterCefficientEntry, GuardInt>, ICharacterCefficientAccessor, IFlatBuffersAccessor<CharacterCefficient, CharacterCefficientEntry, GuardInt>, IDaoAccessor<CharacterCefficient, CharacterCefficientEntry, GuardInt>
{

	public CharacterCefficientAccessor() { }

	protected virtual CharacterCefficient Parse(Byte[] source) { }

}

