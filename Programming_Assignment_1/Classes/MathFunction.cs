using System;
namespace Programming_Assignment_1.Classes
{
    class AddOperation : IBinaryOperation
    {
        public AddOperation()
        {
            Description = "Addition";
            Operator = "+";
        }
        public string Description { get; }
        public string Operator { get; }
        public bool CanCalculate(string binaryOperator) => binaryOperator == Operator;
        public double Calculate(double x, double y) => x + y;
        double SqrtCalculate(double x) => 0;

        double IBinaryOperation.SqrtCalculate(double x)
        {
            throw new NotImplementedException();
        }
    }

    class SubOperation : IBinaryOperation
    {
        public SubOperation()
        {
            Description = "Subtraction";
            Operator = "-";
        }
        public string Description { get; }
        public string Operator { get; }
        public bool CanCalculate(string binaryOperator) => binaryOperator == Operator;
        public double Calculate(double x, double y) => x - y;
        double SqrtCalculate(double x) => 0;

        double IBinaryOperation.SqrtCalculate(double x)
        {
            throw new NotImplementedException();
        }
    }

    class MultiplyOperation : IBinaryOperation
    {
        public MultiplyOperation()
        {
            Description = "Multiply";
            Operator = "*";
        }
        public string Description { get; }
        public string Operator { get; }
        public bool CanCalculate(string binaryOperator) => binaryOperator == Operator;
        public double Calculate(double x, double y) => x * y;
        double SqrtCalculate(double x) => 0;

        double IBinaryOperation.SqrtCalculate(double x)
        {
            throw new NotImplementedException();
        }
    }

    class DivisionOperation : IBinaryOperation
    {
        public DivisionOperation()
        {
            Description = "Division";
            Operator = "/";
        }
        public string Description { get; }
        public string Operator { get; }
        public bool CanCalculate(string binaryOperator) => binaryOperator == Operator;
        public double Calculate(double x, double y) => x / y;
        double SqrtCalculate(double x) => 0;

        double IBinaryOperation.SqrtCalculate(double x)
        {
            throw new NotImplementedException();
        }
    }

    class SquareRootOperation : IBinaryOperation
    {
        public SquareRootOperation()
        {
            Description = "SquareRoot";
            Operator = "L";
        }
        public string Description { get; }
        public string Operator { get; }
        public bool CanCalculate(string binaryOperator) => binaryOperator == Operator;
        //public double Calculate(double x) => Math.Sqrt(x);
        double Calculate(double x, double y) => 0;
        public double SqrtCalculate(double x) => Math.Sqrt(x);

        double IBinaryOperation.Calculate(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}