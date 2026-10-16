namespace System.Data;

internal sealed class LikeNode : BinaryNode
{
	private int _kind; //Field offset: 0x18
	private string _pattern; //Field offset: 0x1C

	internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	internal string AnalyzePattern(string pat) { }

	internal virtual object Eval(DataRow row, DataRowVersion version) { }

}

