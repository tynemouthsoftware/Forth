216 CONSTANT REGPORT
208 CONSTANT DATPORT
: DETECT
	CLS
	1 REGPORT OUT
	31 DATPORT OUT
	REGPORT IN 31 < 
	IF ." AY-3-8910/2"
	ELSE ." YM2149" 
	THEN
	."  Detected"
	CR
	CR
;