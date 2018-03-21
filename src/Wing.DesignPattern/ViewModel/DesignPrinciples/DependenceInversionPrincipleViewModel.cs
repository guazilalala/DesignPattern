using ICSharpCode.AvalonEdit.Document;
using System.Text;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class DependenceInversionPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public DependenceInversionPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append("").ToString();

			ExampleCode = new TextDocument(GetCode(""));
		}
	}
}
