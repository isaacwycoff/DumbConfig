using System;

namespace DumbConfig
{
	public class SettingNotFoundException : Exception
	{
		public string Name { get; set; }

		public SettingNotFoundException(string name)
			: base("Couldn't find setting with that name.")
		{
			Name = name;
		}
	}

	public class InvalidSettingTypeException : Exception
	{
		public Type Type { get; set; }

		public InvalidSettingTypeException(Type type)
			: base ("Invalid type")
		{
			Type = type;
		}
	}
}
