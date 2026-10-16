namespace Unity.Services.Core.Environments.Internal;

internal class Environments : IEnvironments, IServiceComponent
{
	private string m_Current; //Field offset: 0x8

	public internal override string Current
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public Environments() { }

	public override string get_Current() { }

	internal void set_Current(string value) { }

}

