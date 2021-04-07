using System.Collections.Generic;

namespace ToyMvvm.Model
{
    public class FormulaStorage
    {
        private readonly List<Formula> _formulas = new();

        public void Load()
        {
            _formulas.Add(new Formula(5, -3, 2));
            _formulas.Add(new Formula(2, 1, 0));
            _formulas.Add(new Formula(-3, 1, 7));
        }

        public IReadOnlyList<Formula> Formulas => _formulas.AsReadOnly();

        public void Save()
        {
        }

        public void AddFormula(Formula formula)
        {
            _formulas.Add(formula);
        }

        public void RemoveFormula(Formula formula)
        {
            _formulas.Remove(formula);
        }
    }
}
