﻿namespace Manatee.Json.Path.Expressions.Parsing
{
	internal class IsLessThanExpressionParser : IJsonPathExpressionParser
	{
		public bool Handles(string input, int index)
		{
			if (input[index] != '<') return false;

			return index + 1 >= input.Length || input[index + 1] != '=';
		}
		public bool TryParse<TIn>(string source, ref int index, out JsonPathExpression? expression, out string? errorMessage)
		{
			index++;
			expression = new OperatorExpression {Operator = JsonPathOperator.LessThan};
			errorMessage = null!;
			return true;
		}
	}
}