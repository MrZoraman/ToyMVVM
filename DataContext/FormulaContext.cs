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
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void Save(double a, double b, double c)
        {
            _formula.Save(a, b, c);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Formula)));
        }
    }
}
