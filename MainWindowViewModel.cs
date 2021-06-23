using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToyMvvm
{
    class MainWindowViewModel
    {
        private BusinessLogicModel _model;

        public MainWindowViewModel(BusinessLogicModel model)
        {
            _model = model;
            ToggleFooCommand = new ToggleFooCommand(model);
        }

        public string FooSetString => $"Is Foo Set: {_model.IsFooSet}";

        public ToggleFooCommand ToggleFooCommand { get; }
    }

    class ToggleFooCommand : ICommand
    {
        private BusinessLogicModel _model;

        public ToggleFooCommand(BusinessLogicModel model)
        {
            _model = model;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _model.ToggleFoo();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
