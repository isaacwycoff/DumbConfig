﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbConfig
{
	public class NameAttribute : Attribute
	{
		public readonly string Name;

		public NameAttribute(string name)
		{
			Name = name;
		}
	}
}
