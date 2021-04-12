using System;
using System.Windows;
using System.Windows.Input;
using ToyMvvm.DataContext;

namespace ToyMvvm.Commands
{
    public class SaveFormulaCommand : ICommand
    {
        private FormulaStorageContext _context;

        public event EventHandler CanExecuteChanged;

        public SaveFormulaCommand(FormulaStorageContext context)
        {
            _context = context;

            // do I need to do something like this?
            //_context.Formulas.CollectionChanged += (sender, args) => CanExecuteChanged.Invoke();
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (_context.SelectedFormula == null)
            {
                return;
            }

            // I know there's abetter way to do this with PreviewTextInput thing
            if (!int.TryParse(_context.A, out var a))
            {
                return;
            }

            if (!int.TryParse(_context.B, out var b))
            {
                return;
            }

            if (!int.TryParse(_context.C, out var c))
            {
                return;
            }

            _context.SelectedFormula.Save(a, b, c);
        }
    }
}
