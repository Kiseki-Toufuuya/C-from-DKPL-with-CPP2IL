namespace Mono.Security.Interface;

public class Alert
{
	private AlertLevel level; //Field offset: 0x8
	private AlertDescription description; //Field offset: 0x9

	public AlertDescription Description
	{
		 get { } //Length: 11
	}

	public AlertLevel Level
	{
		 get { } //Length: 11
	}

	public Alert(AlertDescription description) { }

	public AlertDescription get_Description() { }

	public AlertLevel get_Level() { }

	private void inferAlertLevel() { }

	public virtual string ToString() { }

}

