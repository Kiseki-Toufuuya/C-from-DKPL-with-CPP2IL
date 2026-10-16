namespace CriWare;

public class CriFs
{
	private class NativeMethods
	{

		public NativeMethods() { }

		internal static int criFs_GetMaxPathLength(ref int length) { }

		internal static int criFs_GetNumBinds(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumOpenedFiles(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumUsedBinders(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumUsedGroupLoaders(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumUsedInstallers(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumUsedLoaders(ref int curNum, ref int maxNum, ref int limit) { }

		internal static int criFs_GetNumUsedStdioHandles(ref int curNum, ref int maxNum, ref int limit) { }

	}


	public CriFs() { }

	public static bool GetMaxPathLength(out int length) { }

	public static bool GetNumBinds(out int curNum, out int maxNum, out int limit) { }

	public static bool GetNumOpenedFiles(out int curNum, out int maxNum, out int limit) { }

	public static bool GetNumUsedBinders(out int curNum, out int maxNum, out int limit) { }

	public static bool GetNumUsedInstallers(out int curNum, out int maxNum, out int limit) { }

	public static bool GetNumUsedLoaders(out int curNum, out int maxNum, out int limit) { }

}

