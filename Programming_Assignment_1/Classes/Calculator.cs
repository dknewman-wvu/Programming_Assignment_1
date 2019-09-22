using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programming_Assignment_1.Classes
{
    class Calculator
    {
        private readonly Regex _matcher = new Regex(
            @"(?<x>\d+([.]\d+)?)\s*(?<operator>.+?)\s*(?<y>\d+([.]\d+)?)",
            RegexOptions.ExplicitCapture
        );

        public Calculator(IEnumerable<IBinaryOperation> operations)
        {
            Operations = operations;
        }

        public IEnumerable<IBinaryOperation> Operations { get; }

        public double? Calcualte(string expression)
        {
            var expr = Parse(expression);
            return Operations.FirstOrDefault(o => o.CanCalculate(expr.BinaryOperator))?.Calculate(expr.X, expr.Y);
        }

        private BinaryExpression Parse(string expression)
        {
            var match = _matcher.Match(expression);
            if (!match.Success)
            {
                throw new ArgumentException($"Could not parse expression: {expression}");
            }
            return new BinaryExpression(
                double.Parse(match.Groups["x"].Value, CultureInfo.InvariantCulture),
                double.Parse(match.Groups["y"].Value, CultureInfo.InvariantCulture),
                match.Groups["operator"].Value);
        }
    }
}