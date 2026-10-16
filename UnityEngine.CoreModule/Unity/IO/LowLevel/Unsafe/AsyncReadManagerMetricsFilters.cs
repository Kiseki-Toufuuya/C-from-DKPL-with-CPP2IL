namespace Unity.IO.LowLevel.Unsafe;

[NativeAsStruct]
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
public class AsyncReadManagerMetricsFilters
{
	[NativeName("typeIDs")]
	internal UInt64[] TypeIDs; //Field offset: 0x8
	[NativeName("states")]
	internal ProcessingState[] States; //Field offset: 0xC
	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes; //Field offset: 0x10
	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels; //Field offset: 0x14
	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems; //Field offset: 0x18

}

