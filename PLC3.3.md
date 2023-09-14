# PLC 3.3

Goal: Use the derivations to get to `let z = (17) in z + 2 * 3 end EOF`.

Expr EOF (A)
LET NAME EQ Expr IN EXPR end EOF (F)
LET NAME EQ Expr IN Expr * Expr end EOF (G)
let NAME EQ Expr in Expr * 3 end EOF (C)
let NAME EQ Expr in Expr + Expr * 3 end EOF (H)
let NAME EQ Expr in Expr + 2 * 3 end EOF (C)
let NAME EQ Expr in z + 2 * 3 end EOF (B)
let NAME EQ (Expr) in z + 2 * 3 end EOF (E)
let NAME EQ (17) in z + 2 * 3 end EOF (C)
let NAME = (17) in z + 2 * 3 end EOF
let z = (17) in z + 2 * 3 end EOF (B)
