using System.ComponentModel.Composition;

namespace Quiz
{
    [Export(typeof (IShell))]
    public class ShellViewModel : IShell
    {
    }
}