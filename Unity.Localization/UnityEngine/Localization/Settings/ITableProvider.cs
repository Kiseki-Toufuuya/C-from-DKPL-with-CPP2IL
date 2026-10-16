namespace UnityEngine.Localization.Settings;

public interface ITableProvider
{

	public AsyncOperationHandle<TTable> ProvideTableAsync(string tableCollectionName, Locale locale) { }

}

