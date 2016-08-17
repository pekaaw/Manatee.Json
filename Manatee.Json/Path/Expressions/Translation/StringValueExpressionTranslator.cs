/***************************************************************************************

	Copyright 2016 Greg Dennis

	   Licensed under the Apache License, Version 2.0 (the "License");
	   you may not use this file except in compliance with the License.
	   You may obtain a copy of the License at

		 http://www.apache.org/licenses/LICENSE-2.0

	   Unless required by applicable law or agreed to in writing, software
	   distributed under the License is distributed on an "AS IS" BASIS,
	   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	   See the License for the specific language governing permissions and
	   limitations under the License.
 
	File Name:		StringValueExpressionTranslator.cs
	Namespace:		Manatee.Json.Path.Expressions.Translation
	Class Name:		StringValueExpressionTranslator
	Purpose:		Translates from a LINQ Constant Expression with a string
					value to a ValueExpression.

***************************************************************************************/
using System;
using System.Linq.Expressions;

namespace Manatee.Json.Path.Expressions.Translation
{
	internal class StringValueExpressionTranslator : IExpressionTranslator
	{
		public ExpressionTreeNode<T> Translate<T>(Expression body)
		{
			var constant = body as ConstantExpression;
			if (constant == null)
				throw new InvalidOperationException();
			return new ValueExpression<T> { Value = constant.Value };
		}
	}
}