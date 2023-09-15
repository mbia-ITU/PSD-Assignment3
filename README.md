# Assignment 03

PLC:  3.3, 3.4, 3.5, 3.6, 3.7

Run instruction:

* run lex on the lex specification `fslex --unicode ExprLex.fsl` (On MacBook `mono ~/bin/fsharp/fslex.exe --unicode ExprLEx.fsl`)
* run yacc on the parser specification `fsyacc --module ExprPar Exprpar.fsy` (On MacBook `mono ~/bin/fsharp/fsyacc.exe --module ExprPar ExprPar.fsy`)
* run the project together using `dotnet fsi -r FsLexYacc.Runtime.dll Absyn.fs ExprPar.fs ExprLex.fs Parse.fs Expr.fs`

Solved by the group Recursive Rebels.

Handin file name:
BPRD-03-AMDH-EMNO-MBIA.zip
