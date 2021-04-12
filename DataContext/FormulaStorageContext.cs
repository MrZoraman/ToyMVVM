using System.Collections.ObjectModel;
using ToyMvvm.Model;

namespace ToyMvvm.DataContext
{
    public class FormulaStorageContext
    {
        private readonly FormulaStorage _storage;

        public ObservableCollection<FormulaContext> Formulas { get; set; } = new();

        public FormulaStorageContext(FormulaStorage storage)
        {
            _storage = storage;

            foreach (var formula in _storage.Formulas)
            {
                Formulas.Add(new FormulaContext(formula));
            }
        }
    }
}
