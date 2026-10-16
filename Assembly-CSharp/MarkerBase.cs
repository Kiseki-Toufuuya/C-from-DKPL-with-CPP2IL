//Type is in global namespace

public abstract class MarkerBase : Marker, INotification, INotificationOptionProvider
{

	public override NotificationFlags flags
	{
		 get { } //Length: 6
	}

	public override PropertyName id
	{
		 get { } //Length: 50
	}

	public abstract int ID
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	protected MarkerBase() { }

	public override NotificationFlags get_flags() { }

	public override PropertyName get_id() { }

	public abstract int get_ID() { }

	public abstract string get_Name() { }

}

