//Type is in global namespace

[Extension]
public static class ProfileMethodWrapper
{
	public static bool IsActiveProfile; //Field offset: 0x0

	[Extension]
	public static void SetActiveWithProfile(GameObject self, bool on, string profileName) { }

}

