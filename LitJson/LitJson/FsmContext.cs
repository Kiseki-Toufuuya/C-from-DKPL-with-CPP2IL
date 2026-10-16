namespace LitJson;

internal class FsmContext
{
	public bool Return; //Field offset: 0x8
	public int NextState; //Field offset: 0xC
	public Lexer L; //Field offset: 0x10
	public int StateStack; //Field offset: 0x14

	public FsmContext() { }

}

