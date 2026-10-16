namespace System.Linq.Expressions.Interpreter;

internal abstract class EqualInstruction : Instruction
{
	private sealed class EqualBoolean : EqualInstruction
	{

		public EqualBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualBooleanLiftedToNull : EqualInstruction
	{

		public EqualBooleanLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualByte : EqualInstruction
	{

		public EqualByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualByteLiftedToNull : EqualInstruction
	{

		public EqualByteLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualChar : EqualInstruction
	{

		public EqualChar() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualCharLiftedToNull : EqualInstruction
	{

		public EqualCharLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualDouble : EqualInstruction
	{

		public EqualDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualDoubleLiftedToNull : EqualInstruction
	{

		public EqualDoubleLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt16 : EqualInstruction
	{

		public EqualInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt16LiftedToNull : EqualInstruction
	{

		public EqualInt16LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt32 : EqualInstruction
	{

		public EqualInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt32LiftedToNull : EqualInstruction
	{

		public EqualInt32LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt64 : EqualInstruction
	{

		public EqualInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualInt64LiftedToNull : EqualInstruction
	{

		public EqualInt64LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualReference : EqualInstruction
	{

		public EqualReference() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualSByte : EqualInstruction
	{

		public EqualSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualSByteLiftedToNull : EqualInstruction
	{

		public EqualSByteLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualSingle : EqualInstruction
	{

		public EqualSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualSingleLiftedToNull : EqualInstruction
	{

		public EqualSingleLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt16 : EqualInstruction
	{

		public EqualUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt16LiftedToNull : EqualInstruction
	{

		public EqualUInt16LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt32 : EqualInstruction
	{

		public EqualUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt32LiftedToNull : EqualInstruction
	{

		public EqualUInt32LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt64 : EqualInstruction
	{

		public EqualUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class EqualUInt64LiftedToNull : EqualInstruction
	{

		public EqualUInt64LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_reference; //Field offset: 0x0
	private static Instruction s_Boolean; //Field offset: 0x4
	private static Instruction s_SByte; //Field offset: 0x8
	private static Instruction s_Int16; //Field offset: 0xC
	private static Instruction s_Char; //Field offset: 0x10
	private static Instruction s_Int32; //Field offset: 0x14
	private static Instruction s_Int64; //Field offset: 0x18
	private static Instruction s_Byte; //Field offset: 0x1C
	private static Instruction s_UInt16; //Field offset: 0x20
	private static Instruction s_UInt32; //Field offset: 0x24
	private static Instruction s_UInt64; //Field offset: 0x28
	private static Instruction s_Single; //Field offset: 0x2C
	private static Instruction s_Double; //Field offset: 0x30
	private static Instruction s_BooleanLiftedToNull; //Field offset: 0x34
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x38
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x3C
	private static Instruction s_CharLiftedToNull; //Field offset: 0x40
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x44
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x48
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x4C
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0x50
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0x54
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0x58
	private static Instruction s_SingleLiftedToNull; //Field offset: 0x5C
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0x60

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 35
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	private EqualInstruction() { }

	public static Instruction Create(Type type, bool liftedToNull) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

