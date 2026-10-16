namespace System;

public class UriBuilder
{
	private bool _changed; //Field offset: 0x8
	private string _fragment; //Field offset: 0xC
	private string _host; //Field offset: 0x10
	private string _password; //Field offset: 0x14
	private string _path; //Field offset: 0x18
	private int _port; //Field offset: 0x1C
	private string _query; //Field offset: 0x20
	private string _scheme; //Field offset: 0x24
	private string _schemeDelimiter; //Field offset: 0x28
	private Uri _uri; //Field offset: 0x2C
	private string _username; //Field offset: 0x30

	public string Path
	{
		 set { } //Length: 142
	}

	public Uri Uri
	{
		 get { } //Length: 124
	}

	public UriBuilder(Uri uri) { }

	public virtual bool Equals(object rparam) { }

	public Uri get_Uri() { }

	public virtual int GetHashCode() { }

	private void Init(Uri uri) { }

	public void set_Path(string value) { }

	private void SetFieldsFromUri(Uri uri) { }

	public virtual string ToString() { }

}

