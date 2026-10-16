namespace XeApp.Game.Net;

public class ModelCache
{
	public static Dictionary<TId, TModel> CacheEntries; //Field offset: 0x0

	private static ModelCache`2() { }

	public ModelCache`2() { }

	public static void Clear() { }

	public static TModel Get(TId id, Func<TId, TModel> GetFromRepositiory) { }

	public static void Remove(TId id) { }

	public static void Remove(Func<TId, Boolean> match) { }

	public static void SetEntry(TId id, TModel model) { }

}

