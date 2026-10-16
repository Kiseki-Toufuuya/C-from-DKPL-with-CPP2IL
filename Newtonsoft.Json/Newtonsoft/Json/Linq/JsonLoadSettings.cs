namespace Newtonsoft.Json.Linq;

public class JsonLoadSettings
{
	private CommentHandling _commentHandling; //Field offset: 0x8
	private LineInfoHandling _lineInfoHandling; //Field offset: 0xC
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; //Field offset: 0x10

	public CommentHandling CommentHandling
	{
		 get { } //Length: 11
	}

	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
	{
		 get { } //Length: 11
	}

	public LineInfoHandling LineInfoHandling
	{
		 get { } //Length: 11
	}

	public CommentHandling get_CommentHandling() { }

	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

	public LineInfoHandling get_LineInfoHandling() { }

}

