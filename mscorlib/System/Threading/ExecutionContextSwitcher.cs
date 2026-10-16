namespace System.Threading;

internal struct ExecutionContextSwitcher
{
	internal Reader outerEC; //Field offset: 0x0
	internal bool outerECBelongsToScope; //Field offset: 0x4
	internal object hecsw; //Field offset: 0x8
	internal Thread thread; //Field offset: 0xC

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	internal void Undo() { }

	[HandleProcessCorruptedStateExceptions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	internal bool UndoNoThrow() { }

}

