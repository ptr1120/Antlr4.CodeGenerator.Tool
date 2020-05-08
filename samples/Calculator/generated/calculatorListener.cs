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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="calculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IcalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquation([NotNull] calculatorParser.EquationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquation([NotNull] calculatorParser.EquationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] calculatorParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] calculatorParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplyingExpression([NotNull] calculatorParser.MultiplyingExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.multiplyingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplyingExpression([NotNull] calculatorParser.MultiplyingExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.powExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowExpression([NotNull] calculatorParser.PowExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.powExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowExpression([NotNull] calculatorParser.PowExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignedAtom([NotNull] calculatorParser.SignedAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.signedAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignedAtom([NotNull] calculatorParser.SignedAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] calculatorParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] calculatorParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.scientific"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScientific([NotNull] calculatorParser.ScientificContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.scientific"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScientific([NotNull] calculatorParser.ScientificContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] calculatorParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] calculatorParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] calculatorParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] calculatorParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc([NotNull] calculatorParser.FuncContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc([NotNull] calculatorParser.FuncContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncname([NotNull] calculatorParser.FuncnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncname([NotNull] calculatorParser.FuncnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="calculatorParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelop([NotNull] calculatorParser.RelopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="calculatorParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelop([NotNull] calculatorParser.RelopContext context);
}
} // namespace MyCalculator
