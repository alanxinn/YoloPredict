using System.Windows.Input;

namespace YoloPredict.Common;

public class CommandBase : ICommand
{
    public CommandBase(Action<object> doExecute, Func<object, bool> doCanExecute)
    {
        DoExecute = doExecute;
        DoCanExecute = doCanExecute;
    }

    private Action<object> DoExecute { get; }

    private Func<object, bool> DoCanExecute { get; }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return DoCanExecute?.Invoke(parameter) == true;
    }

    public void Execute(object? parameter)
    {
        DoExecute?.Invoke(parameter);
    }
}