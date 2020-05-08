grammar calculator;

equation
   : expression relop expression
   ;

expression
   : multiplyingExpression ((PLUS | MINUS) multiplyingExpression)*
   ;

multiplyingExpression
   : powExpression ((TIMES | DIV) powExpression)*
   ;

powExpression
   : signedAtom (POW signedAtom)*
   ;

signedAtom
   : PLUS signedAtom
   | MINUS signedAtom
   | func
   | atom
   ;

atom
   : scientific
   | variable
   | constant
   | LPAREN expression RPAREN
   ;

scientific
   : SCIENTIFIC_NUMBER
   ;

constant
   : PI
   | EULER
   | I
   ;

variable
   : VARIABLE
   ;

func
   : funcname LPAREN expression (COMMA expression)* RPAREN
   ;

funcname
   : COS
   | TAN
   | SIN
   | ACOS
   | ATAN
   | ASIN
   | LOG
   | LN
   | SQRT
   ;

relop
   : EQ
   | GT
   | LT
   ;


COS
   : 'cos'
   ;


SIN
   : 'sin'
   ;


TAN
   : 'tan'
   ;


ACOS
   : 'acos'
   ;


ASIN
   : 'asin'
   ;


ATAN
   : 'atan'
   ;


LN
   : 'ln'
   ;


LOG
   : 'log'
   ;


SQRT
   : 'sqrt'
   ;


LPAREN
   : '('
   ;


RPAREN
   : ')'
   ;


PLUS
   : '+'
   ;


MINUS
   : '-'
   ;


TIMES
   : '*'
   ;


DIV
   : '/'
   ;


GT
   : '>'
   ;


LT
   : '<'
   ;


EQ
   : '='
   ;


COMMA
   : ','
   ;


POINT
   : '.'
   ;


POW
   : '^'
   ;


PI
   : 'pi'
   ;


EULER
   : E2
   ;


I
   : 'i'
   ;


VARIABLE
   : VALID_ID_START VALID_ID_CHAR*
   ;


fragment VALID_ID_START
   : ('a' .. 'z') | ('A' .. 'Z') | '_'
   ;


fragment VALID_ID_CHAR
   : VALID_ID_START | ('0' .. '9')
   ;


SCIENTIFIC_NUMBER
   : NUMBER ((E1 | E2) SIGN? NUMBER)?
   ;


fragment NUMBER
   : ('0' .. '9') + ('.' ('0' .. '9') +)?
   ;


fragment E1
   : 'E'
   ;


fragment E2
   : 'e'
   ;


fragment SIGN
   : ('+' | '-')
   ;


WS
   : [ \r\n\t] + -> skip
   ;