namespace Live2D.Cubism.Framework;

public interface ICubismUpdatable
{

	public int ExecutionOrder
	{
		 get { } //Length: 0
	}

	public bool HasUpdateController
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool NeedsUpdateOnEditing
	{
		 get { } //Length: 0
	}

	public int get_ExecutionOrder() { }

	public bool get_HasUpdateController() { }

	public bool get_NeedsUpdateOnEditing() { }

	public void OnLateUpdate() { }

	public void set_HasUpdateController(bool value) { }

}

