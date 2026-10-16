namespace System.Xml.Schema;

internal class UpaException : Exception
{
	private object particle1; //Field offset: 0x48
	private object particle2; //Field offset: 0x4C

	public object Particle1
	{
		 get { } //Length: 11
	}

	public object Particle2
	{
		 get { } //Length: 11
	}

	public UpaException(object particle1, object particle2) { }

	public object get_Particle1() { }

	public object get_Particle2() { }

}

