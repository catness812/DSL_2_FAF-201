grammar Dsl;

program: line* EOF;

line: function;

function: freestyle;

freestyle: 'ls freestyle' '(' '"' axiom '"' ',' applies ',' angle ',' length ',' rules ')' ';';
axiom: AXIOM;
applies: NUM;
angle: NUM;
length: NUM;
rules: task | rules ',' rules;
task: '{' '"' AXIOM '"' ':' '"' path '"' '}';
path
    : axiom
    | '[' path ']'
    | path '[' path ']'
    | '[' path ']' path
    | path '[' path ']' path;

NUM: [1-9][0-9]*;
AXIOM: [a-zA-Z+-]+;