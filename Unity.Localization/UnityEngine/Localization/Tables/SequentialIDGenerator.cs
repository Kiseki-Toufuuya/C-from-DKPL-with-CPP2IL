namespace UnityEngine.Localization.Tables;

public class SequentialIDGenerator : IKeyGenerator
{
	[SerializeField]
	private long m_NextAvailableId; //Field offset: 0x8

	public long NextAvailableId
	{
		 get { } //Length: 14
	}

	public SequentialIDGenerator() { }

	public SequentialIDGenerator(long startingId) { }

	public long get_NextAvailableId() { }

	public override long GetNextKey() { }

}

