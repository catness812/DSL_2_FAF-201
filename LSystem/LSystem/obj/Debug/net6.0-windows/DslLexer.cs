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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class DslLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, NUM=22, NAME=23, AXIOM=24;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "NUM", "NAME", "AXIOM"
	};


	public DslLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'for('", "';'", "') {'", "'}'", "' '", "'='", "'int'", "'<'", "'++'", 
		"'--'", "'ls tree('", "','", "');'", "'ls dragon('", "'ls freestyle'", 
		"'('", "'\"'", "'{'", "':'", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "NUM", "NAME", 
		"AXIOM"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Dsl.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1A\x93\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3"+
		"\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v"+
		"\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\xE"+
		"\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3"+
		"\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\a\x17\x85\n\x17"+
		"\f\x17\xE\x17\x88\v\x17\x3\x18\x6\x18\x8B\n\x18\r\x18\xE\x18\x8C\x3\x19"+
		"\x6\x19\x90\n\x19\r\x19\xE\x19\x91\x2\x2\x2\x1A\x3\x2\x3\x5\x2\x4\a\x2"+
		"\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r"+
		"\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2"+
		"\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x3\x2\x6\x3\x2\x33;\x3"+
		"\x2\x32;\x5\x2\x43\\\x61\x61\x63|\x6\x2--//\x43\\\x63|\x95\x2\x3\x3\x2"+
		"\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2"+
		"\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3"+
		"\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2"+
		"\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2"+
		"\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+"+
		"\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x3\x33"+
		"\x3\x2\x2\x2\x5\x38\x3\x2\x2\x2\a:\x3\x2\x2\x2\t>\x3\x2\x2\x2\v@\x3\x2"+
		"\x2\x2\r\x42\x3\x2\x2\x2\xF\x44\x3\x2\x2\x2\x11H\x3\x2\x2\x2\x13J\x3\x2"+
		"\x2\x2\x15M\x3\x2\x2\x2\x17P\x3\x2\x2\x2\x19Y\x3\x2\x2\x2\x1B[\x3\x2\x2"+
		"\x2\x1D^\x3\x2\x2\x2\x1Fi\x3\x2\x2\x2!v\x3\x2\x2\x2#x\x3\x2\x2\x2%z\x3"+
		"\x2\x2\x2\'|\x3\x2\x2\x2)~\x3\x2\x2\x2+\x80\x3\x2\x2\x2-\x82\x3\x2\x2"+
		"\x2/\x8A\x3\x2\x2\x2\x31\x8F\x3\x2\x2\x2\x33\x34\ah\x2\x2\x34\x35\aq\x2"+
		"\x2\x35\x36\at\x2\x2\x36\x37\a*\x2\x2\x37\x4\x3\x2\x2\x2\x38\x39\a=\x2"+
		"\x2\x39\x6\x3\x2\x2\x2:;\a+\x2\x2;<\a\"\x2\x2<=\a}\x2\x2=\b\x3\x2\x2\x2"+
		">?\a\x7F\x2\x2?\n\x3\x2\x2\x2@\x41\a\"\x2\x2\x41\f\x3\x2\x2\x2\x42\x43"+
		"\a?\x2\x2\x43\xE\x3\x2\x2\x2\x44\x45\ak\x2\x2\x45\x46\ap\x2\x2\x46G\a"+
		"v\x2\x2G\x10\x3\x2\x2\x2HI\a>\x2\x2I\x12\x3\x2\x2\x2JK\a-\x2\x2KL\a-\x2"+
		"\x2L\x14\x3\x2\x2\x2MN\a/\x2\x2NO\a/\x2\x2O\x16\x3\x2\x2\x2PQ\an\x2\x2"+
		"QR\au\x2\x2RS\a\"\x2\x2ST\av\x2\x2TU\at\x2\x2UV\ag\x2\x2VW\ag\x2\x2WX"+
		"\a*\x2\x2X\x18\x3\x2\x2\x2YZ\a.\x2\x2Z\x1A\x3\x2\x2\x2[\\\a+\x2\x2\\]"+
		"\a=\x2\x2]\x1C\x3\x2\x2\x2^_\an\x2\x2_`\au\x2\x2`\x61\a\"\x2\x2\x61\x62"+
		"\a\x66\x2\x2\x62\x63\at\x2\x2\x63\x64\a\x63\x2\x2\x64\x65\ai\x2\x2\x65"+
		"\x66\aq\x2\x2\x66g\ap\x2\x2gh\a*\x2\x2h\x1E\x3\x2\x2\x2ij\an\x2\x2jk\a"+
		"u\x2\x2kl\a\"\x2\x2lm\ah\x2\x2mn\at\x2\x2no\ag\x2\x2op\ag\x2\x2pq\au\x2"+
		"\x2qr\av\x2\x2rs\a{\x2\x2st\an\x2\x2tu\ag\x2\x2u \x3\x2\x2\x2vw\a*\x2"+
		"\x2w\"\x3\x2\x2\x2xy\a$\x2\x2y$\x3\x2\x2\x2z{\a}\x2\x2{&\x3\x2\x2\x2|"+
		"}\a<\x2\x2}(\x3\x2\x2\x2~\x7F\a]\x2\x2\x7F*\x3\x2\x2\x2\x80\x81\a_\x2"+
		"\x2\x81,\x3\x2\x2\x2\x82\x86\t\x2\x2\x2\x83\x85\t\x3\x2\x2\x84\x83\x3"+
		"\x2\x2\x2\x85\x88\x3\x2\x2\x2\x86\x84\x3\x2\x2\x2\x86\x87\x3\x2\x2\x2"+
		"\x87.\x3\x2\x2\x2\x88\x86\x3\x2\x2\x2\x89\x8B\t\x4\x2\x2\x8A\x89\x3\x2"+
		"\x2\x2\x8B\x8C\x3\x2\x2\x2\x8C\x8A\x3\x2\x2\x2\x8C\x8D\x3\x2\x2\x2\x8D"+
		"\x30\x3\x2\x2\x2\x8E\x90\t\x5\x2\x2\x8F\x8E\x3\x2\x2\x2\x90\x91\x3\x2"+
		"\x2\x2\x91\x8F\x3\x2\x2\x2\x91\x92\x3\x2\x2\x2\x92\x32\x3\x2\x2\x2\x6"+
		"\x2\x86\x8C\x91\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LSystem
