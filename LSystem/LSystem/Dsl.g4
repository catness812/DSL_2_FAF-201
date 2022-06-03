grammar Dsl;

program: line* EOF;

line: function;

function: freestyle | lstree | lsdragon;

lstree: 'ls tree(' applies ');';

lsdragon: 'ls dragon(' applies ');';

freestyle: 'ls freestyle' '(' '"' axiom '"' ',' applies ',' angle ',' length ',' rules ',' color ');';
axiom: AXIOM;
applies: NUM;
angle: NUM;
length: NUM;
rules: task | rules ',' rules;
color: AXIOM;
task: '{' '"' AXIOM '"' ':' '"' path '"' '}';
path
    : axiom
    | '[' path ']'
    | path '[' path ']'
    | '[' path ']' path
    | path '[' path ']' path;

NUM: [1-9][0-9]*;
AXIOM: [a-zA-Z+-]+;