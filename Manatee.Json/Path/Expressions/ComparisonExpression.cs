/***************************************************************************************

	Copyright 2014 Greg Dennis

	   Licensed under the Apache License, Version 2.0 (the "License");
	   you may not use this file except in compliance with the License.
	   You may obtain a copy of the License at

		 http://www.apache.org/licenses/LICENSE-2.0

	   Unless required by applicable law or agreed to in writing, software
	   distributed under the License is distributed on an "AS IS" BASIS,
	   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	   See the License for the specific language governing permissions and
	   limitations under the License.
 
	File Name:		ComparisonExpression.cs
	Namespace:		Manatee.Json.Path.Expressions
	Class Name:		ComparisonExpression
	Purpose:		Provides a base class for expression objects which
					express comparison operations.

***************************************************************************************/
using System;

namespace Manatee.Json.Path.Expressions
{
	internal abstract class ComparisonExpression<T> : ExpressionTreeBranch<T>
	{
		protected static double? GetDouble(object value)
		{
			if (value == null) return null;
			var json = value as JsonValue;
			if (json == null) return Convert.ToDouble(value);
			return json.Type == JsonValueType.Number ? json.Number : (double?) null;
		}
	}
}