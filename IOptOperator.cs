using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmCommandLineParser
{
	public interface IOptOperator 
	{
		void Execute(string arg);
	}
}
