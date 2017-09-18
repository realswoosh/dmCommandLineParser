# dmCommandLineParser
Simple Command Line Parser for C#

--
<pre><code>
static dmCommandLineParser.Parser cmdParser2 = new dmCommandLineParser.Parser();

static void InitializeParser()
{

	var opt_test1 = new dmCommandLineParser.Option<IOptOperator>("--out", new OptOperator());
	var opt_test2 = new dmCommandLineParser.Option<IOptOperator>("--cs",
						new dmCommandLineParser.Operator.FuncOperator(TestAction));

	cmdParser2.Add(opt_test1);
	cmdParser2.Add(opt_test2);
}

static void TestAction(string param)
{
	Console.WriteLine(string.Format("TestAction param={0}", param));
}

static void Main(string[] args)
{
	string[] tmpArgs1 =
	{
		"--out=./out",
		"--cs=cs",
		"--lt",
		"--json",
		"--test=a=b=c=d=3=f="
	};

	InitializeParser();

	cmdParser2.Process(tmpArgs1);
}
</code></pre>
