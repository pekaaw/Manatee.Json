﻿/***************************************************************************************

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
 
	File Name:		JsonIgnoreAttribute.cs
	Namespace:		Manatee.Json.Serialization
	Class Name:		JsonIgnoreAttribute
	Purpose:		Applied to properties to indicate that they are not to be
					serialized.

***************************************************************************************/
using System;

namespace Manatee.Json.Serialization
{
	/// <summary>
	/// Applied to properties to indicate that they are not to be serialized.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class JsonIgnoreAttribute : Attribute
	{
	}
}
