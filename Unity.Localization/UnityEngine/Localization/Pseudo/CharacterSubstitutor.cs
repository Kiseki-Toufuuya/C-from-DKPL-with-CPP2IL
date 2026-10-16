namespace UnityEngine.Localization.Pseudo;

public class CharacterSubstitutor : IPseudoLocalizationMethod, ISerializationCallbackReceiver
{
	private struct CharReplacement
	{
		public char original; //Field offset: 0x0
		public char replacement; //Field offset: 0x2

	}

	internal enum ListSelectionMethod
	{
		Random = 0,
		LoopFromPrevious = 1,
		LoopFromStart = 2,
	}

	internal enum SubstitutionMethod
	{
		ToUpper = 0,
		ToLower = 1,
		List = 2,
		Map = 3,
	}

	[SerializeField]
	private SubstitutionMethod m_SubstitutionMethod; //Field offset: 0x8
	[SerializeField]
	private ListSelectionMethod m_ListMode; //Field offset: 0xC
	[SerializeField]
	private List<CharReplacement> m_ReplacementsMap; //Field offset: 0x10
	[SerializeField]
	private List<Char> m_ReplacementList; //Field offset: 0x14
	internal int m_ReplacementsPosition; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<Char, Char> <ReplacementMap>k__BackingField; //Field offset: 0x1C

	public ListSelectionMethod ListMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public SubstitutionMethod Method
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public List<Char> ReplacementList
	{
		 get { } //Length: 11
	}

	public private Dictionary<Char, Char> ReplacementMap
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CharacterSubstitutor() { }

	public ListSelectionMethod get_ListMode() { }

	public SubstitutionMethod get_Method() { }

	public List<Char> get_ReplacementList() { }

	[CompilerGenerated]
	public Dictionary<Char, Char> get_ReplacementMap() { }

	private int GetRandomSeed(string input) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	internal char ReplaceCharFromMap(char value) { }

	public void set_ListMode(ListSelectionMethod value) { }

	public void set_Method(SubstitutionMethod value) { }

	[CompilerGenerated]
	private void set_ReplacementMap(Dictionary<Char, Char> value) { }

	public override void Transform(Message message) { }

	private void TransformFragment(WritableMessageFragment writableFragment) { }

}

