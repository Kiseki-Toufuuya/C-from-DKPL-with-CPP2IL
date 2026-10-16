namespace UnityEngine.Localization.Pseudo;

public class Expander : IPseudoLocalizationMethod
{
	internal struct ExpansionRule : IComparable<ExpansionRule>
	{
		[SerializeField]
		private int m_MinCharacters; //Field offset: 0x0
		[SerializeField]
		private int m_MaxCharacters; //Field offset: 0x4
		[SerializeField]
		private float m_ExpansionAmount; //Field offset: 0x8

		public float ExpansionAmount
		{
			 get { } //Length: 11
			 set { } //Length: 21
		}

		public int MaxCharacters
		{
			 get { } //Length: 11
			 set { } //Length: 21
		}

		public int MinCharacters
		{
			 get { } //Length: 10
			 set { } //Length: 20
		}

		public ExpansionRule(int minCharacters, int maxCharacters, float expansion) { }

		public override int CompareTo(ExpansionRule other) { }

		public float get_ExpansionAmount() { }

		public int get_MaxCharacters() { }

		public int get_MinCharacters() { }

		internal bool InRange(int length) { }

		public void set_ExpansionAmount(float value) { }

		public void set_MaxCharacters(int value) { }

		public void set_MinCharacters(int value) { }

	}

	internal enum InsertLocation
	{
		Start = 0,
		End = 1,
		Both = 2,
	}

	[SerializeField]
	private List<ExpansionRule> m_ExpansionRules; //Field offset: 0x8
	[SerializeField]
	private InsertLocation m_Location; //Field offset: 0xC
	[SerializeField]
	private int m_MinimumStringLength; //Field offset: 0x10
	[SerializeField]
	private List<Char> m_PaddingCharacters; //Field offset: 0x14

	public List<ExpansionRule> ExpansionRules
	{
		 get { } //Length: 11
	}

	public InsertLocation Location
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int MinimumStringLength
	{
		 get { } //Length: 11
		 set { } //Length: 21
	}

	public List<Char> PaddingCharacters
	{
		 get { } //Length: 11
	}

	public Expander() { }

	public Expander(char paddingCharacter) { }

	public Expander(char start, char end) { }

	public void AddCharacterRange(char start, char end) { }

	public void AddExpansionRule(int minCharacters, int maxCharacters, float expansion) { }

	private void AddPaddingToMessage(Message message, Char[] padding) { }

	public List<ExpansionRule> get_ExpansionRules() { }

	public InsertLocation get_Location() { }

	public int get_MinimumStringLength() { }

	public List<Char> get_PaddingCharacters() { }

	internal float GetExpansionForLength(int length) { }

	private int GetRandomSeed(string input) { }

	public void set_Location(InsertLocation value) { }

	public void set_MinimumStringLength(int value) { }

	public void SetConstantExpansion(float expansion) { }

	public override void Transform(Message message) { }

}

