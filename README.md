# Domain-Specific Language for *Lindenmayer Systems*
### Table of contents
1. [Project Purpose and Description](#1)
2. [Language Grammar](#2)
3. [Grammar Description](#3)
4. [Program Examples and Output](#4)

<a name="1"></a>
## Project Purpose and Description
This project focuses on creating a DSL that will generate and design fractals, fractal plants, and architectural geometries of different colors, dimensions, using Lindenmayer systems, otherwise known as L-systems.

The DSL of this project is based on a sequential mathematical model of computation, specifically a finite automaton that will operate on predefined grammar rules for different types of graphic outputs. The lexical analyzer creates a sequence of language tokens (such as reserved words, literals, and identifiers) from a sequence of characters, which the parser uses to create a syntax tree.

There are 3 data types: integer, character, and string, and 1 composite data type - functions, which represent the main way of generating a graphical output. String literals have some limitations in terms of their definition: they can only contain symbols that are allowed by the function type, implying that some graphical designs must adhere to particular character and symbol constraints. Functions save more data about L-system items.

The main criterion for any source code is that a set of statements separated by ';' is expected. A variable definition or a function call can be used in the statement. A variable name, assignment symbol, and a call to a function that returns an object are all required for the variable definition command. In terms of syntax, a function call offers more options. Arguments should be enclosed in braces and separated by a comma if a function requires them. For its arguments, each function has some specific constraints or limitations.

The DSL's general method is as follows: source code is separated into tokens, which are then processed by a parser to locate parser rule matches. All rules and tokens are described in a particular grammar file, which is then processed by ANTLR to generate lexer, parser, and listener files. The flow of the language is always the same: it executes each command one by one, one at a time, from top to bottom. The program will provide an appropriate error notice if there is an unknown syntax or semantic validation issue.

<a name="2"></a>
## Language Grammar
```
G = (Vn, Vt, S, P):

Vn = { <program>, <ls freestyle>, <ls tree>, <ls dragon>, <define>, 
       <type>, <alphalower>, <identifier>, <value>, 
       <parameters>, <axiom>, <applies>, <angle>, <length>, <rules>, 
       <start>, <short>, <long>, <directions>, 
       <num>, 
       <rule>, <first>, <second>, 
       <for>, <A>, <B>, <C>, <X>, <Y>, 
       <if>, <expression>, <statement> }

Vt = { [a-z],  [A-Z],  [0-9],  [ + | - ],  ls  freestyle(),  ls  tree(),  ls  dragon(),  
       int,  char,  string, _,  ”,  ;,  for(;;),  if(){}else{}, 
       [ _ | ++ | -- | = | < | > | <= | >= | == | != ] }

S = <program>

P = { <program> → <ls freestyle>; | <ls tree>; | <ls dragon>; | <define>; | <for>; | <if>; 

        <define> → <type> <identifier> = <value> | <type> <identifier>
<type> → int | char | string 
<identifier> → <alphalower> | <alphalower><num> | <alphalower>_<alphalower> 
<alphalower> → a|...|z | <alphalower> a|...|z 
<value> → <num> | <alphalower>

        <ls freestyle> → ls freestyle(<parameters>) 
<parameters> → ”<axiom>”, <applies>, <angle>, <length>, {<rules>}
<axiom> → <start>
<start> → <short> | <long>
<short> → [a-z] | [A-Z] | [0-9] 
<long> → <short> | <short><long> | <long><directions> | <directions><long> | <long><directions><long>
<directions> → [ + | − ] | [ + | − ] <directions>

<applies> → [1-9] | [1-9]<num>
<num> → [0-9] | [0-9]<num>
<color> → red | green

<angle> → [0-9] | [1-9][0-9] | [1-2][0-9][0-9] | 3[0-5][0-9] | 360
<length> → [0-9] | [1-9][0-9] | 100 

<rules> → <rule> | <rule>,<rules>
<rule> → ”<first>”:”<second>” 
<first> → <short>
<second> → <long> | [<second>] | <long>[<second>] | [<second>]<long> | <long>[<second>]<long>

        <ls tree> → ls tree(<num>)

        <ls dragon> → ls dragon(<num>)

        <for> → for(<A>;<B>;<C>){}
<A> → <X>=<Y>
<B> → <X><<Y> | <X>><Y> | <X><=<Y> | <X>>=<Y> 
<C> → <X>++ | <X>--
<X> → [A-Z] | [a-z] | [A-Z]<X> | [a-z]<X> | _<X> | <X><num> | <X><num><X>
<Y> → <num>

        <if> → if(<expression>){} | if(<expression>){};else{}
<expression> → <identifier>[< | > | == | <= | >= | !=]<statement>
<statement> → <statement> | <num> | ”<X>” | ’<short>’
}
```

<a name="3"></a>
## Grammar Description
-	define **variables**:\
`<type>` - data type of variable\
`<identifier>` - name of variable

-	***ls freestyle***: function to design plants using L-systems, according to user's personal preferences\
`<axiom>` - The starting string of the L-System\
`<applies>` - The number of times the rules are applied to the string\
`<angle>` -  The angle to apply for the turning commands, in degrees\
`<length>` - The length of each `f` (move) command, in pixels\
`<rules>` - A dictionary of characters and substitution strings

Supported commands:\
	`f` : move forward\
  `+` : turn angle right\
  `-` : turn angle left\
  `[` : start branch\
  `]` : end branch

-	***ls tree***/***ls dragon***: functions that generate 2 examples of L-systems designs\
`<num>` - The number of recursions\
`<color>` - The color of the output (optional parameter; default color - blue)

-	***for*** statement:\
`<A>` - Initialization\
`<B>` - Condition\
`<C>` - Increment / Decrement

-	***if*** statement:\
`<expression>` - Condition

<a name="4"></a>
## Program Examples and Output
```
ls freestyle(”X”, 6, 25, 10,{”X”:  ”f−[[X]+X]+f[+fX]−X”, ”f”:  ”ff”});
```
<img width="280" alt="s0" src="https://user-images.githubusercontent.com/91728316/171996531-097bd796-5f79-42b2-ac5d-f4036ecdc15f.png">

```
ls tree(8);
```
<img width="280" alt="s1" src="https://user-images.githubusercontent.com/91728316/171996623-591b98bd-bc2e-4007-a7bd-1238a1889486.png">

```
ls tree(8, green);
```
<img width="280" alt="s2" src="https://user-images.githubusercontent.com/91728316/171996630-240ab6d9-7730-4ab1-bfbb-b21766c96463.png">

```
ls dragon(12, red);
```
<img width="280" alt="s3" src="https://user-images.githubusercontent.com/91728316/171996692-22497588-6980-4ace-a6ab-791ca50fc174.png">
