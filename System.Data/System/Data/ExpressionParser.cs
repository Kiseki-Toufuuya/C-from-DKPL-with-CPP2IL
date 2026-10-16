namespace System.Data;

internal sealed class ExpressionParser
{
	[IsReadOnly]
	private struct ReservedWords
	{
		internal readonly string _word; //Field offset: 0x0
		internal readonly Tokens _token; //Field offset: 0x4
		internal readonly int _op; //Field offset: 0x8

		internal ReservedWords(string word, Tokens token, int op) { }

	}

	private static readonly ReservedWords[] s_reservedwords; //Field offset: 0x0
	private char _escape; //Field offset: 0x8
	private char _decimalSeparator; //Field offset: 0xA
	private char _listSeparator; //Field offset: 0xC
	private char _exponentL; //Field offset: 0xE
	private char _exponentU; //Field offset: 0x10
	internal Char[] _text; //Field offset: 0x14
	internal int _pos; //Field offset: 0x18
	internal int _start; //Field offset: 0x1C
	internal Tokens _token; //Field offset: 0x20
	internal int _op; //Field offset: 0x24
	internal OperatorInfo[] _ops; //Field offset: 0x28
	internal int _topOperator; //Field offset: 0x2C
	internal int _topNode; //Field offset: 0x30
	private readonly DataTable _table; //Field offset: 0x34
	internal ExpressionNode[] _nodeStack; //Field offset: 0x38
	internal int _prevOperand; //Field offset: 0x3C
	internal ExpressionNode _expression; //Field offset: 0x40

	private static ExpressionParser() { }

	internal ExpressionParser(DataTable table) { }

	private void BuildExpression(int pri) { }

	internal void CheckToken(Tokens token) { }

	private bool IsAlpha(char ch) { }

	private bool IsAlphaNumeric(char ch) { }

	private bool IsDigit(char ch) { }

	private bool IsWhiteSpace(char ch) { }

	internal void LoadExpression(string data) { }

	private ExpressionNode NodePeek() { }

	private ExpressionNode NodePop() { }

	private void NodePush(ExpressionNode node) { }

	internal ExpressionNode Parse() { }

	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	internal Tokens Scan() { }

	private void ScanBinaryConstant() { }

	private void ScanDate() { }

	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	private void ScanName() { }

	private void ScanNumeric() { }

	private void ScanReserved() { }

	private void ScanString(char escape) { }

	internal void ScanToken(Tokens token) { }

	private void ScanWhite() { }

	internal void StartScan() { }

}

