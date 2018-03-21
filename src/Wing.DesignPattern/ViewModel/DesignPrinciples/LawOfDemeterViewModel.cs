using ICSharpCode.AvalonEdit.Document;
using System.Text;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class LawOfDemeterViewModel : DesignPrinciplesViewModelBase
	{
		public LawOfDemeterViewModel()
		{
			Concepts = new StringBuilder()
				.Append("").ToString();

			ExampleCode = new TextDocument(GetCode(""));
		}
	}
}
