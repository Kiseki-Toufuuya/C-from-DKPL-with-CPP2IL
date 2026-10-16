//Type is in global namespace

public class UiSlider : Slider
{
	public Action SliderUpCallBack; //Field offset: 0xF4

	public UiSlider() { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

}

