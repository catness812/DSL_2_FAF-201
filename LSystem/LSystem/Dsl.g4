grammar Dsl;

program: line* EOF;

line: function | forLoop;

forLoop: 'for(' start ';' end ';' incrementSize ') {' function* '}';

start: type ' ' name '=' NUM;
type: 'int';
name: NAME | NAME NUM | NAME NUM name;
end: NAME '<' NUM;
incrementSize: NAME '++'| NAME '--';

function: freestyle | lstree | lsdragon;

lstree: 'ls tree(' applies (',' color)? ');';

lsdragon: 'ls dragon(' applies (',' color)? ');';

freestyle: 'ls freestyle' '(' '"' axiom '"' ',' applies ',' angle ',' length ',' rules (',' color)? ');';
axiom: AXIOM | NAME;
applies: NUM;
angle: NUM;
length: NUM;
rules: task | rules ',' rules;
color: NAME;
task: '{' '"' axiom '"' ':' '"' path '"' '}';
path
    : axiom
    | '[' path ']'
    | path '[' path ']'
    | '[' path ']' path
    | path '[' path ']' path;

NUM: [1-9][0-9]*;
NAME: [_a-zA-Z]+;
AXIOM: [a-zA-Z+-]+;