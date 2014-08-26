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
 
	File Name:		IsGreaterThanEqualExpression.cs
	Namespace:		Manatee.Json.Path.Expressions
	Class Name:		IsGreaterThanEqualExpression
	Purpose:		Expresses the intent to compare two values.

***************************************************************************************/

namespace Manatee.Json.Path.Expressions
{
	internal class IsGreaterThanEqualExpression<T> : ComparisonExpression<T>
	{
		public override int Priority { get { return 1; } }

		public override object Evaluate(T json)
		{
			var left = GetDouble(Left.Evaluate(json));
			if (left == null) return false;
			var right = GetDouble(Right.Evaluate(json));
			return left.Value.CompareTo(right) >= 0;
		}
		public override string ToString()
		{
			return string.Format("{0} >= {1}", Left, Right);
		}
	}
}