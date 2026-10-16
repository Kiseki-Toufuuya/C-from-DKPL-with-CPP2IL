namespace UnityEngine.Localization.Metadata;

[Metadata]
public class Comment : IMetadata
{
	[SerializeField]
	[TextArea(1, 2147483647)]
	private string m_CommentText; //Field offset: 0x8

	public string CommentText
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Comment() { }

	public string get_CommentText() { }

	public void set_CommentText(string value) { }

	public virtual string ToString() { }

}

