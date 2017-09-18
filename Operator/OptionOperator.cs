using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmCommandLineParser.Operator
{
	public class OptionOperator : IOptOperator
	{
		public virtual void Execute(string arg)
		{
			
		}

	}

	public class FuncOperator : IOptOperator
	{
		public Action<string> func;

		public FuncOperator(Action<string> func)
		{
			this.func = func;
		}

		public virtual void Execute(string arg)
		{
			func(arg);
		}
	}
}
