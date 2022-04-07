# Domain-Specific Language for *Lindenmayer Systems*
## Project Purpose and Description
This project focuses on creating a DSL that will generate and design fractals, fractal plants, and architectural geometries of different colors, dimensions, using Lindenmayer systems, otherwise known as L-systems.

The DSL of this project is based on a sequential mathematical model of computation, specifically a finite automaton that will operate on predefined grammar rules for different types of graphic outputs. The lexical analyzer creates a sequence of language tokens (such as reserved words, literals, and identifiers) from a sequence of characters, which the parser uses to create a syntax tree.

There are 3 data types: integer, character, and string, and 1 composite data type - functions, which represent the main way of generating a graphical output. String literals have some limitations in terms of their definition: they can only contain symbols that are allowed by the function type, implying that some graphical designs must adhere to particular character and symbol constraints. Functions save more data about L-system items.

The main criterion for any source code is that a set of statements separated by ';' is expected. A variable definition or a function call can be used in the statement. A variable name, assignment symbol, and a call to a function that returns an object are all required for the variable definition command. In terms of syntax, a function call offers more options. Arguments should be enclosed in braces and separated by a comma if a function requires them. For its arguments, each function has some specific constraints or limitations.

The DSL's general method is as follows: source code is separated into tokens, which are then processed by a parser to locate parser rule matches. All rules and tokens are described in a particular grammar file, which is then processed by ANTLR to generate lexer, parser, and listener files. The flow of the language is always the same: it executes each command one by one, one at a time, from top to bottom. The program will provide an appropriate error notice if there is an unknown syntax or semantic validation issue.

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
`<num>` - The number of recursions

-	***for*** statement:\
`<A>` - Initialization\
`<B>` - Condition\
`<C>` - Increment / Decrement

-	***if*** statement:\
`<expression>` - Condition


## Program Example and Output
```
ls freestyle(”X”, 6, 25, 10,{”X”:  ”f−[[X]+X]+f[+fX]−X”, ”f”:  ”ff”});
```
![l30](https://user-images.githubusercontent.com/91728316/157959734-df7844f3-7e7e-4912-add3-b50f61da069b.png)

