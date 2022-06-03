//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from S:\MB\Univer\ANUL II\Classes II\DDSL\LSystemParser\LSystem\LSystem\Dsl.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LSystem {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DslParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDslVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] DslParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] DslParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] DslParser.FunctionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.lstree"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLstree([NotNull] DslParser.LstreeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.lsdragon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLsdragon([NotNull] DslParser.LsdragonContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.freestyle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFreestyle([NotNull] DslParser.FreestyleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.axiom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAxiom([NotNull] DslParser.AxiomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.applies"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitApplies([NotNull] DslParser.AppliesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.angle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAngle([NotNull] DslParser.AngleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.length"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLength([NotNull] DslParser.LengthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.rules"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRules([NotNull] DslParser.RulesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.color"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColor([NotNull] DslParser.ColorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.task"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTask([NotNull] DslParser.TaskContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="DslParser.path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPath([NotNull] DslParser.PathContext context);
}
} // namespace LSystem
