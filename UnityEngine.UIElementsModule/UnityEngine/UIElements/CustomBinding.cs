namespace UnityEngine.UIElements;

[UxmlObject]
public abstract class CustomBinding : Binding
{
	[ExcludeFromDocs]
	internal abstract class UxmlSerializedData : UxmlSerializedData
	{

		protected UxmlSerializedData() { }

	}


	protected CustomBinding() { }

	protected private override BindingResult Update(in BindingContext context) { }

}

