namespace D4L.TakashoFes.DataContext;

public interface IErrorMessageAccessor : IFlatBuffersAccessor<ErrorMessage, ErrorMessageEntry, Int32>, IDaoAccessor<ErrorMessage, ErrorMessageEntry, Int32>
{

	public void BuildAllIndex() { }

}

