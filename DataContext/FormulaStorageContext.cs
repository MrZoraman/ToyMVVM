using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
using ToyMvvm.Commands;
using ToyMvvm.Model;

namespace ToyMvvm.DataContext
{
    public class FormulaStorageContext
    {
        private readonly FormulaStorage _storage;

        public ObservableCollection<FormulaContext> Formulas { get; set; } = new();

        public FormulaContext SelectedFormula { get; set; }

        public SaveFormulaCommand SaveFormulaCommand { get; }

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public FormulaStorageContext(FormulaStorage storage)
        {
            _storage = storage;

            foreach (var formula in _storage.Formulas)
            {
                Formulas.Add(new FormulaContext(formula));
            }

            SaveFormulaCommand = new SaveFormulaCommand(this);
        }
    }
}
