﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace PermissionControlSystem
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface IResource 
	{
		string Name { get; }

		IEnumerable<IOperation> Operations { get;set; }


	}
}

