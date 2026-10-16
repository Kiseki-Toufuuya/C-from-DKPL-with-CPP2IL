namespace UnityEngine.UIElements;

[Obsolete("UxmlTemplateFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
{

	public virtual string uxmlName
	{
		 get { } //Length: 35
	}

	public virtual string uxmlQualifiedName
	{
		 get { } //Length: 95
	}

	public UxmlTemplateFactory() { }

	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	public virtual string get_uxmlName() { }

	public virtual string get_uxmlQualifiedName() { }

}

