using ToyMvvm.Model;

namespace ToyMvvm.DataContext
{
    public class FormulaContext
    {
        private readonly Formula _formula;

        public FormulaContext(Formula formula)
        {
            _formula = formula;
        }

        public string PrettyView => $"{_formula.A}X^2 + {_formula.B}X + {_formula.C}";
    }
}
