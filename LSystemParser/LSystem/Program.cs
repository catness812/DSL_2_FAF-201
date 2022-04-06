using System.Drawing;
using System.Text;
using Antlr4.Runtime;

namespace LSystem;

public class Program
{
    static void Main(string[] args)
    {
        var path = "test.dsl";

        var fileContent = File.ReadAllText(path);

        var inputStream = new AntlrInputStream(fileContent);
        var lexer = new DslLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new DslParser(commonTokenStream);
        var context = parser.program();
        var visitor = new DslVisitor();        
        visitor.Visit(context);
        ;
    }
}