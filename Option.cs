using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmCommandLineParser
{
	public class Option<T> where T : IOptOperator
	{
		public string ArgType { get; set; }
		public string ArgValue { get; set; } = "";

		T Opt;

		public Option(string argType, T op)
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
