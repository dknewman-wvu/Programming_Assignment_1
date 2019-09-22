interface IBinaryOperation
{
    string Description { get; }
    string Operator { get; }
    bool CanCalculate(string binaryOperator);
    double Calculate(double x, double y);
    double SqrtCalculate(double x);

}