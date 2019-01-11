using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
	static class Program
	{
		private static void OutputErrors(AppSettings settings)
		{
			var errors = settings.GetErrors();
			if (errors.Length == 0) return;

			Console.WriteLine($"There were {errors.Length} errors: ");
			Console.WriteLine($"==========================================");
			foreach(var error in errors)
			{
				Console.WriteLine(error);
			}
			Console.WriteLine($"==========================================");
		}

		static void Main(string[] args)
		{
			var config = new AppSettings();

			OutputErrors(config);

			Console.WriteLine($"Path = {config.Path}");
			Console.WriteLine($"User = {config.DefaultUser}");
			Console.WriteLine($"StartDate = {config.StartDate}");
			Console.WriteLine($"Max Threads = {config.MaximumThreads}");
			Console.WriteLine($"Secret = {config.GetSecretValue()}");

			Console.WriteLine();
			Console.WriteLine($"Press Enter ...");
			Console.ReadLine();
		}
	}
}
