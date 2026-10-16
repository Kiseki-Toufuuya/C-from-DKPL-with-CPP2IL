namespace Unity.Services.Core.Configuration.Internal;

public interface IProjectConfiguration : IServiceComponent
{

	public string GetString(string key, string defaultValue = null) { }

}

