using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmCommandLineParser
{
	public class Option
	{
		public string ArgType { get; set; }
		public string ArgValue { get; set; } = "";

		IOptOperator Opt;

		public Option(string argType, IOptOperator op)
		{
			ArgType = argType;
			Opt = op;
		}

		public void Execute(string arg)
		{
			Opt.Execute(ArgValue);
		}
	}
}
