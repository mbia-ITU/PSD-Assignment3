(* File Expr/Absyn.fs
   Abstract syntax for the simple expression language 
 *)

module Absyn

(*If union case added by Recursive Rebels*)

type expr = 
  | CstI of int
  | Var of string
  | Let of string * expr * expr
  | Prim of string * expr * expr
  | If of expr * expr * expr;;
