using System;
using System.Collections.Generic;
using System.Linq;

namespace ToyMvvm.Model
{
    public class FormulaStorage
    {
        private readonly List<Formula> _formulas = new();

        public void Load()
        {
            _formulas.Add(new Formula(Guid.NewGuid(), 5, -3, 2));
            _formulas.Add(new Formula(Guid.NewGuid(), 2, 1, 0));
            _formulas.Add(new Formula(Guid.NewGuid(), -3, 1, 7));
        }

        public IReadOnlyList<Formula> Formulas => _formulas.AsReadOnly();

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
