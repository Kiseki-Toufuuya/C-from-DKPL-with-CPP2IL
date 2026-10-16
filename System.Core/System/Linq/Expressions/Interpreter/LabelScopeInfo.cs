namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelScopeInfo
{
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; //Field offset: 0x8
	internal readonly LabelScopeKind Kind; //Field offset: 0xC
	internal readonly LabelScopeInfo Parent; //Field offset: 0x10

	internal bool CanJumpInto
	{
		internal get { } //Length: 15
	}

	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) { }

	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }

	internal bool ContainsTarget(LabelTarget target) { }

	internal bool get_CanJumpInto() { }

	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

}

