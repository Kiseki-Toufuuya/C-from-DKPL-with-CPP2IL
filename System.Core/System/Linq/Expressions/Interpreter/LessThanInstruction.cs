namespace System.Linq.Expressions.Interpreter;

internal abstract class LessThanInstruction : Instruction
{
	private sealed class LessThanByte : LessThanInstruction
	{

		public LessThanByte(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanChar : LessThanInstruction
	{

		public LessThanChar(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanDouble : LessThanInstruction
	{

		public LessThanDouble(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanInt16 : LessThanInstruction
	{

		public LessThanInt16(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanInt32 : LessThanInstruction
	{

		public LessThanInt32(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanInt64 : LessThanInstruction
	{

		public LessThanInt64(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanSByte : LessThanInstruction
	{

		public LessThanSByte(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanSingle : LessThanInstruction
	{

		public LessThanSingle(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanUInt16 : LessThanInstruction
	{

		public LessThanUInt16(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanUInt32 : LessThanInstruction
	{

		public LessThanUInt32(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanUInt64 : LessThanInstruction
	{

		public LessThanUInt64(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_SByte; //Field offset: 0x0
	private static Instruction s_Int16; //Field offset: 0x4
	private static Instruction s_Char; //Field offset: 0x8
	private static Instruction s_Int32; //Field offset: 0xC
	private static Instruction s_Int64; //Field offset: 0x10
	private static Instruction s_Byte; //Field offset: 0x14
	private static Instruction s_UInt16; //Field offset: 0x18
	private static Instruction s_UInt32; //Field offset: 0x1C
	private static Instruction s_UInt64; //Field offset: 0x20
	private static Instruction s_Single; //Field offset: 0x24
	private static Instruction s_Double; //Field offset: 0x28
	private static Instruction s_liftedToNullSByte; //Field offset: 0x2C
	private static Instruction s_liftedToNullInt16; //Field offset: 0x30
	private static Instruction s_liftedToNullChar; //Field offset: 0x34
	private static Instruction s_liftedToNullInt32; //Field offset: 0x38
	private static Instruction s_liftedToNullInt64; //Field offset: 0x3C
	private static Instruction s_liftedToNullByte; //Field offset: 0x40
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x44
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x48
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x4C
	private static Instruction s_liftedToNullSingle; //Field offset: 0x50
	private static Instruction s_liftedToNullDouble; //Field offset: 0x54
	private readonly object _nullValue; //Field offset: 0x8

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

	private LessThanInstruction(object nullValue) { }

	public static Instruction Create(Type type, bool liftedToNull = false) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

