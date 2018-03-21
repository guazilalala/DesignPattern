using ICSharpCode.AvalonEdit.Document;
using System.Text;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class InterfaceSegregationPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public InterfaceSegregationPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append("").ToString();

			ExampleCode = new TextDocument(GetCode(""));
		}
	}
}
