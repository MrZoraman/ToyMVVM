using System.ComponentModel;
using ToyMvvm.Model;

namespace ToyMvvm.DataContext
{
    public class FormulaContext : INotifyPropertyChanged
    {
        private readonly Formula _formula;

        public FormulaContext(Formula formula)
        {
            _formula = formula;
        }

        public Formula Formula => _formula;

        public string PrettyView => $"{_formula.A}X^2 + {_formula.B}X + {_formula.C}";


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
