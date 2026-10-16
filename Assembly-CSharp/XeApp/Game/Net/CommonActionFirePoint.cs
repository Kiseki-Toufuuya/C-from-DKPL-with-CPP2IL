namespace XeApp.Game.Net;

public struct CommonActionFirePoint
{
	public static long counter; //Field offset: 0x0
	private static GuardLong lastCheckTime; //Field offset: 0x8

	private static CommonActionFirePoint() { }

	[Preserve]
	public void Check() { }

	[Preserve]
	public void Check2(int priority) { }

}

