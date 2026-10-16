namespace Google.Protobuf;

internal sealed class FieldMaskTree
{
	public sealed class Node
	{
		[CompilerGenerated]
		private readonly Dictionary<String, Node> <Children>k__BackingField; //Field offset: 0x8

		public Dictionary<String, Node> Children
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public Node() { }

		[CompilerGenerated]
		public Dictionary<String, Node> get_Children() { }

	}

	private const char FIELD_PATH_SEPARATOR = '\u2E'; //Field offset: 0x0
	private readonly Node root; //Field offset: 0x8

	public FieldMaskTree() { }

	public FieldMaskTree(FieldMask mask) { }

	public FieldMaskTree AddFieldPath(string path) { }

	private void GetFieldPaths(Node node, string path, List<String> paths) { }

	public void IntersectFieldPath(string path, FieldMaskTree output) { }

	public void Merge(IMessage source, IMessage destination, MergeOptions options) { }

	private void Merge(Node node, string path, IMessage source, IMessage destination, MergeOptions options) { }

	public FieldMaskTree MergeFromFieldMask(FieldMask mask) { }

	public FieldMask ToFieldMask() { }

	public virtual string ToString() { }

}

