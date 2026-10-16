namespace UnityEngine.UIElements.UIR;

internal class TextureSlotManager
{
	internal static readonly int k_SlotCount; //Field offset: 0x0
	internal static readonly int k_SlotSize; //Field offset: 0x4
	internal static readonly Int32[] slotIds; //Field offset: 0x8
	internal static readonly int textureTableId; //Field offset: 0xC
	private TextureId[] m_Textures; //Field offset: 0x8
	private Int32[] m_Tickets; //Field offset: 0xC
	private int m_CurrentTicket; //Field offset: 0x10
	private int m_FirstUsedTicket; //Field offset: 0x14
	private Vector4[] m_GpuTextures; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <FreeSlots>k__BackingField; //Field offset: 0x1C
	internal TextureRegistry textureRegistry; //Field offset: 0x20

	public private int FreeSlots
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static TextureSlotManager() { }

	public TextureSlotManager() { }

	public void Bind(TextureId id, float sdfScale, float sharpness, int slot, MaterialPropertyBlock mat, CommandList commandList = null) { }

	public int FindOldestSlot() { }

	[CompilerGenerated]
	public int get_FreeSlots() { }

	public int IndexOf(TextureId id) { }

	public void MarkUsed(int slotIndex) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_FreeSlots(int value) { }

	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness) { }

	public void StartNewBatch() { }

}

