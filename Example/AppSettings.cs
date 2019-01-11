using DumbConfig;
using System;

namespace Example
{
	class AppSettings : AutoConfig
	{
		public readonly string Path;
		public string DefaultUser { get; private set; }
		public readonly DateTime StartDate;

		private int SecretValue;		// this doesn't work for some reason

		[Name("MaxThreads")]
		public readonly int MaximumThreads;

		public int GetSecretValue()
		{
			return SecretValue;
		}
	}
}
