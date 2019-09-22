using System;
namespace Programming_Assignment_1.Classes
{
    class BinaryExpression
    {
        public BinaryExpression(double x, double y, string binaryOperator)
        {
            X = x;
            Y = y;
            BinaryOperator = binaryOperator;
        }

        public double X { get; }
        public double Y { get; }
        public string BinaryOperator { get; }
    }
}
