using Antlr4.Runtime;
using System.Text;
using System.Text.RegularExpressions;

namespace LSystem
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var path = @"C:\Users\mariu\Desktop\LSystemProject\LSystem\LSystem\test.dsl";
            var fileContent = File.ReadAllText(path);

            var inputStream = new AntlrInputStream(fileContent);
            var lexer = new DslLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new DslParser(commonTokenStream);
            var context = parser.program();
            var visitor = new DslVisitor();
            visitor.Visit(context);

            List<object> result = DslParser.Result;
            var functions = ObjectParser.Parse(result);

            Form1[] forms = new Form1[functions.Count];

            for (int i = 0; i < functions.Count; i++)
            {
                forms[i] = new Form1(functions[i]);
            }

            for (int i = 0; i < forms.Length; i++)
            {
                Application.Run(forms[i]);
            }
        }
    }

    // parse + convert objects to a list of tuples
    public static class ObjectParser
    {
        public static List<(int applies, int angle, int length, StringBuilder rule)> Parse(List<object> objects)
        {
            List<(int applies, int angle, int length, StringBuilder rule)> functions = new();
            foreach (object obj in objects)
            {
                string func = obj.ToString();
                func = func.Substring(1, func.Length - 2);
                func = Regex.Replace(func, @"\s+", "");
                string[] function = func.Split(',');
                (int applies, int angle, int length, StringBuilder rule) tuple = new();
                tuple.applies = int.Parse(function[0]);
                tuple.angle = int.Parse(function[1]);
                tuple.length = int.Parse(function[2]);
                StringBuilder rule = new(function[3]);
                tuple.rule = rule;

                functions.Add(tuple);
            }
            return functions;
        }
    }
}