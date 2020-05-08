//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Source\Antlr4.CodeGenerator.Tool\samples\Calculator\calculator.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MyCalculator {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class calculatorLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COS=1, SIN=2, TAN=3, ACOS=4, ASIN=5, ATAN=6, LN=7, LOG=8, SQRT=9, LPAREN=10, 
		RPAREN=11, PLUS=12, MINUS=13, TIMES=14, DIV=15, GT=16, LT=17, EQ=18, COMMA=19, 
		POINT=20, POW=21, PI=22, EULER=23, I=24, VARIABLE=25, SCIENTIFIC_NUMBER=26, 
		WS=27;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COS", "SIN", "TAN", "ACOS", "ASIN", "ATAN", "LN", "LOG", "SQRT", "LPAREN", 
		"RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "GT", "LT", "EQ", "COMMA", 
		"POINT", "POW", "PI", "EULER", "I", "VARIABLE", "VALID_ID_START", "VALID_ID_CHAR", 
		"SCIENTIFIC_NUMBER", "NUMBER", "E1", "E2", "SIGN", "WS"
	};


	public calculatorLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public calculatorLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'cos'", "'sin'", "'tan'", "'acos'", "'asin'", "'atan'", "'ln'", 
		"'log'", "'sqrt'", "'('", "')'", "'+'", "'-'", "'*'", "'/'", "'>'", "'<'", 
		"'='", "','", "'.'", "'^'", "'pi'", null, "'i'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COS", "SIN", "TAN", "ACOS", "ASIN", "ATAN", "LN", "LOG", "SQRT", 
		"LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "GT", "LT", "EQ", 
		"COMMA", "POINT", "POW", "PI", "EULER", "I", "VARIABLE", "SCIENTIFIC_NUMBER", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "calculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static calculatorLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1D', '\xBF', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\a', '\x1A', 
		'\x8E', '\n', '\x1A', '\f', '\x1A', '\xE', '\x1A', '\x91', '\v', '\x1A', 
		'\x3', '\x1B', '\x5', '\x1B', '\x94', '\n', '\x1B', '\x3', '\x1C', '\x3', 
		'\x1C', '\x5', '\x1C', '\x98', '\n', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x5', '\x1D', '\x9D', '\n', '\x1D', '\x3', '\x1D', '\x5', 
		'\x1D', '\xA0', '\n', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x5', '\x1D', 
		'\xA4', '\n', '\x1D', '\x3', '\x1E', '\x6', '\x1E', '\xA7', '\n', '\x1E', 
		'\r', '\x1E', '\xE', '\x1E', '\xA8', '\x3', '\x1E', '\x3', '\x1E', '\x6', 
		'\x1E', '\xAD', '\n', '\x1E', '\r', '\x1E', '\xE', '\x1E', '\xAE', '\x5', 
		'\x1E', '\xB1', '\n', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', 
		'\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x6', '\"', '\xBA', 
		'\n', '\"', '\r', '\"', '\xE', '\"', '\xBB', '\x3', '\"', '\x3', '\"', 
		'\x2', '\x2', '#', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', 
		'+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', 
		'\x35', '\x2', '\x37', '\x2', '\x39', '\x1C', ';', '\x2', '=', '\x2', 
		'?', '\x2', '\x41', '\x2', '\x43', '\x1D', '\x3', '\x2', '\x5', '\x5', 
		'\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x4', '\x2', '-', '-', 
		'/', '/', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xC1', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x3', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x5', 'I', '\x3', '\x2', '\x2', '\x2', '\a', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\t', 'Q', '\x3', '\x2', '\x2', '\x2', '\v', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\r', '[', '\x3', '\x2', '\x2', '\x2', '\xF', '`', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '\x63', '\x3', '\x2', '\x2', '\x2', 
		'\x13', 'g', '\x3', '\x2', '\x2', '\x2', '\x15', 'l', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'n', '\x3', '\x2', '\x2', '\x2', '\x19', 'p', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', 'r', '\x3', '\x2', '\x2', '\x2', '\x1D', 't', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', 'v', '\x3', '\x2', '\x2', '\x2', '!', 'x', 
		'\x3', '\x2', '\x2', '\x2', '#', 'z', '\x3', '\x2', '\x2', '\x2', '%', 
		'|', '\x3', '\x2', '\x2', '\x2', '\'', '~', '\x3', '\x2', '\x2', '\x2', 
		')', '\x80', '\x3', '\x2', '\x2', '\x2', '+', '\x82', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x84', '\x3', '\x2', '\x2', '\x2', '/', '\x87', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x89', '\x3', '\x2', '\x2', '\x2', '\x33', '\x8B', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x93', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x97', '\x3', '\x2', '\x2', '\x2', '\x39', '\x99', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xA6', '\x3', '\x2', '\x2', '\x2', '=', '\xB2', '\x3', 
		'\x2', '\x2', '\x2', '?', '\xB4', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\xB6', '\x3', '\x2', '\x2', '\x2', '\x43', '\xB9', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\x46', '\a', '\x65', '\x2', '\x2', '\x46', 'G', '\a', 
		'q', '\x2', '\x2', 'G', 'H', '\a', 'u', '\x2', '\x2', 'H', '\x4', '\x3', 
		'\x2', '\x2', '\x2', 'I', 'J', '\a', 'u', '\x2', '\x2', 'J', 'K', '\a', 
		'k', '\x2', '\x2', 'K', 'L', '\a', 'p', '\x2', '\x2', 'L', '\x6', '\x3', 
		'\x2', '\x2', '\x2', 'M', 'N', '\a', 'v', '\x2', '\x2', 'N', 'O', '\a', 
		'\x63', '\x2', '\x2', 'O', 'P', '\a', 'p', '\x2', '\x2', 'P', '\b', '\x3', 
		'\x2', '\x2', '\x2', 'Q', 'R', '\a', '\x63', '\x2', '\x2', 'R', 'S', '\a', 
		'\x65', '\x2', '\x2', 'S', 'T', '\a', 'q', '\x2', '\x2', 'T', 'U', '\a', 
		'u', '\x2', '\x2', 'U', '\n', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', 
		'\x63', '\x2', '\x2', 'W', 'X', '\a', 'u', '\x2', '\x2', 'X', 'Y', '\a', 
		'k', '\x2', '\x2', 'Y', 'Z', '\a', 'p', '\x2', '\x2', 'Z', '\f', '\x3', 
		'\x2', '\x2', '\x2', '[', '\\', '\a', '\x63', '\x2', '\x2', '\\', ']', 
		'\a', 'v', '\x2', '\x2', ']', '^', '\a', '\x63', '\x2', '\x2', '^', '_', 
		'\a', 'p', '\x2', '\x2', '_', '\xE', '\x3', '\x2', '\x2', '\x2', '`', 
		'\x61', '\a', 'n', '\x2', '\x2', '\x61', '\x62', '\a', 'p', '\x2', '\x2', 
		'\x62', '\x10', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', 'n', 
		'\x2', '\x2', '\x64', '\x65', '\a', 'q', '\x2', '\x2', '\x65', '\x66', 
		'\a', 'i', '\x2', '\x2', '\x66', '\x12', '\x3', '\x2', '\x2', '\x2', 'g', 
		'h', '\a', 'u', '\x2', '\x2', 'h', 'i', '\a', 's', '\x2', '\x2', 'i', 
		'j', '\a', 't', '\x2', '\x2', 'j', 'k', '\a', 'v', '\x2', '\x2', 'k', 
		'\x14', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', '*', '\x2', '\x2', 
		'm', '\x16', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '+', '\x2', '\x2', 
		'o', '\x18', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', '-', '\x2', '\x2', 
		'q', '\x1A', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', '/', '\x2', '\x2', 
		's', '\x1C', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', ',', '\x2', '\x2', 
		'u', '\x1E', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', '\x31', '\x2', 
		'\x2', 'w', ' ', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', '@', '\x2', 
		'\x2', 'y', '\"', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', '>', '\x2', 
		'\x2', '{', '$', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', '?', '\x2', 
		'\x2', '}', '&', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\a', '.', '\x2', 
		'\x2', '\x7F', '(', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', 
		'\x30', '\x2', '\x2', '\x81', '*', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\a', '`', '\x2', '\x2', '\x83', ',', '\x3', '\x2', '\x2', '\x2', 
		'\x84', '\x85', '\a', 'r', '\x2', '\x2', '\x85', '\x86', '\a', 'k', '\x2', 
		'\x2', '\x86', '.', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\x5', 
		'?', ' ', '\x2', '\x88', '\x30', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 'k', '\x2', '\x2', '\x8A', '\x32', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8F', '\x5', '\x35', '\x1B', '\x2', '\x8C', '\x8E', '\x5', '\x37', '\x1C', 
		'\x2', '\x8D', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '\x8F', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', 
		'\x90', '\x3', '\x2', '\x2', '\x2', '\x90', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x91', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x92', '\x94', '\t', 
		'\x2', '\x2', '\x2', '\x93', '\x92', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x95', '\x98', '\x5', '\x35', '\x1B', 
		'\x2', '\x96', '\x98', '\x4', '\x32', ';', '\x2', '\x97', '\x95', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x96', '\x3', '\x2', '\x2', '\x2', '\x98', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\x99', '\xA3', '\x5', ';', '\x1E', 
		'\x2', '\x9A', '\x9D', '\x5', '=', '\x1F', '\x2', '\x9B', '\x9D', '\x5', 
		'?', ' ', '\x2', '\x9C', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9B', 
		'\x3', '\x2', '\x2', '\x2', '\x9D', '\x9F', '\x3', '\x2', '\x2', '\x2', 
		'\x9E', '\xA0', '\x5', '\x41', '!', '\x2', '\x9F', '\x9E', '\x3', '\x2', 
		'\x2', '\x2', '\x9F', '\xA0', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', 
		'\x3', '\x2', '\x2', '\x2', '\xA1', '\xA2', '\x5', ';', '\x1E', '\x2', 
		'\xA2', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA3', '\x9C', '\x3', '\x2', 
		'\x2', '\x2', '\xA3', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA4', ':', 
		'\x3', '\x2', '\x2', '\x2', '\xA5', '\xA7', '\x4', '\x32', ';', '\x2', 
		'\xA6', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', 
		'\x2', '\x2', '\xA8', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', 
		'\x3', '\x2', '\x2', '\x2', '\xA9', '\xB0', '\x3', '\x2', '\x2', '\x2', 
		'\xAA', '\xAC', '\a', '\x30', '\x2', '\x2', '\xAB', '\xAD', '\x4', '\x32', 
		';', '\x2', '\xAC', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', 
		'\x3', '\x2', '\x2', '\x2', '\xAE', '\xAC', '\x3', '\x2', '\x2', '\x2', 
		'\xAE', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB1', '\x3', '\x2', 
		'\x2', '\x2', '\xB0', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', 
		'\x3', '\x2', '\x2', '\x2', '\xB1', '<', '\x3', '\x2', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', 'G', '\x2', '\x2', '\xB3', '>', '\x3', '\x2', '\x2', '\x2', 
		'\xB4', '\xB5', '\a', 'g', '\x2', '\x2', '\xB5', '@', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\xB7', '\t', '\x3', '\x2', '\x2', '\xB7', '\x42', '\x3', 
		'\x2', '\x2', '\x2', '\xB8', '\xBA', '\t', '\x4', '\x2', '\x2', '\xB9', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\x3', '\x2', '\x2', 
		'\x2', '\xBB', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', '\x3', 
		'\x2', '\x2', '\x2', '\xBC', '\xBD', '\x3', '\x2', '\x2', '\x2', '\xBD', 
		'\xBE', '\b', '\"', '\x2', '\x2', '\xBE', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x2', '\x8F', '\x93', '\x97', '\x9C', '\x9F', '\xA3', '\xA8', 
		'\xAE', '\xB0', '\xBB', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MyCalculator