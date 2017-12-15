using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmCommandLineParser
{
	public class Parser
	{
		List<Option> optList = new List<Option>();

		public void Add(Option option)
		{
			optList.Add(option);
		}

		public void Process(string[] args)
		{
			Ready(args);

			foreach (var opt in optList)
			{
				opt.Execute(opt.ArgValue);
			}
		}

		string[] Split(string arg)
		{
			string argK = "";
			string argV = "";

			var split = arg.Split('=');

			argK = split[0];

			if (split.Length > 1)
				argV = string.Join("=", split.AsEnumerable().Skip(1).ToArray());

			return new string[] { argK, argV };
		}

		void Ready(string[] args)
		{
			List<string> tmpArgK = new List<string>();

			foreach (string arg in args)
			{
				var split = Split(arg);

				tmpArgK.Add(split[0]);

				var option = optList.Find(x => x.ArgType == split[0]);
				if (option == null)
					continue;

				option.ArgValue = split[1];
			}

			var supportOptList = optList.Where(x => tmpArgK.Contains(x.ArgType)).ToList();
			optList = supportOptList;
		}
	}
}
