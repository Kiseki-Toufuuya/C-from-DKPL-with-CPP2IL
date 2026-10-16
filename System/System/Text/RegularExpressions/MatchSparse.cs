namespace System.Text.RegularExpressions;

internal class MatchSparse : Match
{
	internal readonly Hashtable _caps; //Field offset: 0x48

	public virtual GroupCollection Groups
	{
		 get { } //Length: 118
	}

	internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	public virtual GroupCollection get_Groups() { }

}

