namespace UnityEngine.Localization.Tables;

public class DistributedUIDGenerator : IKeyGenerator
{
	private const int kMachineIdBits = 10; //Field offset: 0x0
	private const int kSequenceBits = 12; //Field offset: 0x0
	private static readonly int kMaxNodeId; //Field offset: 0x0
	public const string MachineIdPrefKey = "KeyGenerator-MachineId"; //Field offset: 0x0
	private static readonly int kMaxSequence; //Field offset: 0x4
	[HideInInspector]
	[SerializeField]
	private long m_CustomEpoch; //Field offset: 0x8
	private long m_LastTimestamp; //Field offset: 0x10
	private long m_Sequence; //Field offset: 0x18
	private int m_MachineId; //Field offset: 0x20

	public long CustomEpoch
	{
		 get { } //Length: 14
	}

	public int MachineId
	{
		 get { } //Length: 143
		 set { } //Length: 96
	}

	private static DistributedUIDGenerator() { }

	public DistributedUIDGenerator() { }

	public DistributedUIDGenerator(long customEpoch) { }

	public long get_CustomEpoch() { }

	public int get_MachineId() { }

	private static int GetMachineId() { }

	public override long GetNextKey() { }

	public void set_MachineId(int value) { }

	private long TimeStamp() { }

	private long WaitNextMillis(long currentTimestamp) { }

}

