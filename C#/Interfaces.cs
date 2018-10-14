namespace AiSD
{
    public class Interfaces
    {

        public interface IAdd
        {
            IAdd Add(IAdd add);
        }

        public interface ISubstract
        {
            ISubstract Substract(ISubstract substract);
        }

        public interface IMultiply
        {
            IMultiply Multiply(IMultiply multiply);
        }

        public interface IDivide
        {
            IDivide Divide(IDivide divide);
        }

        public interface IMathOperations : IAdd, ISubstract, IMultiply, IDivide
        {
            IMathOperations Add(IMathOperations add);
            IMathOperations Substract(IMathOperations substract);
            IMathOperations Multiply(IMathOperations multiply);
            IDivide Divide(IMathOperations divide);
        }

        public interface IIntable
        {
            int ToInt();
        }
    }
}
