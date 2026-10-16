namespace System.Collections;

internal sealed class CompatibleComparer : IEqualityComparer
{
	private readonly IHashCodeProvider _hcp; //Field offset: 0x8
	private readonly IComparer _comparer; //Field offset: 0xC

	internal IComparer Comparer
	{
		internal get { } //Length: 11
	}

	internal IHashCodeProvider HashCodeProvider
	{
		internal get { } //Length: 11
	}

	internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	public int Compare(object a, object b) { }

	public override bool Equals(object a, object b) { }

	internal IComparer get_Comparer() { }

	internal IHashCodeProvider get_HashCodeProvider() { }

	public override int GetHashCode(object obj) { }

}

