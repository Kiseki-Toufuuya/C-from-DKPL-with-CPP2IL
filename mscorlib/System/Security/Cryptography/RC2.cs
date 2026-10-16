namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4
	protected int EffectiveKeySizeValue; //Field offset: 0x2C

	public override int EffectiveKeySize
	{
		 get { } //Length: 22
		 set { } //Length: 145
	}

	public virtual int KeySize
	{
		 get { } //Length: 11
		 set { } //Length: 107
	}

	private static RC2() { }

	protected RC2() { }

	public static RC2 Create() { }

	public static RC2 Create(string AlgName) { }

	public override int get_EffectiveKeySize() { }

	public virtual int get_KeySize() { }

	public override void set_EffectiveKeySize(int value) { }

	public virtual void set_KeySize(int value) { }

}

