L01BDB1:
	SUB r0
	RAMB
	LMS r0, [#0066]
	ROMB
	LMS r14, [#0064]
	DEC r14
	TO r1
	GETB
	DEC r14
	WITH r1
	GETBH
	DEC r14
	DEC r14
	DEC r14
	TO r3
	GETB
	DEC r14
	WITH r3
	GETBH
	DEC r14
	TO r2
	GETB
	DEC r14
	WITH r2
	GETBH
	LMS r9, [#002C]
	WITH r1
	ADD r9
	SMS r1, [#005C]
	IBT r4, #0000
	IBT r6, #0000
	IBT r5, #0000
	IWT r7, #BF66
	CACHE
	MOVE r8, r15
	IBT r12, #0003
	LINK L01BDEE
	IWT r15, L01BF62

L01BDEE:
	IBT r0, #00FF
	AND r4
	BNE L01BDF8
	NOP
	IWT r15, L01BE71

L01BDF8:
	IBT r0, #0007
	CMP r4
	BNE L01BE30
	NOP
	WITH r2
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BNE L01BE0D
	NOP
	LINK L01BE0D
	IWT r15, L01BF4A

L01BE0D:
	BCC L01BE26
	NOP
	IBT r12, #000A
	LINK L01BE17
	IWT r15, L01BF62

L01BE17:
	MOVES r4, r4
	BNE L01BE30
	NOP
	IBT r12, #0012
	LINK L01BE23
	IWT r15, L01BF62

L01BE23:
	BRA L01BE30

L01BE26:
	IBT r12, #0004
	LINK L01BE2D
	IWT r15, L01BF62

L01BE2D:
	WITH r4
	ADD r7, #BF36

L01BE30:
	IBT r12, #0008
	MOVE r13, r15
	WITH r2
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BEQ L01BE4E
	NOP
	WITH r6
	ROL
	WITH r5
	ROL
	LOOP
	NOP
	DEC r1
	FROM r6
	STB r1
	DEC r4
	BNE L01BE30
	NOP
	BRA L01BE71

L01BE4E:
	DEC r14
	TO r3
	GETB
	DEC r14
	WITH r3
	GETBH
	DEC r14
	TO r2
	GETB
	DEC r14
	WITH r2
	GETBH
	IBT r0, #0001
	ROR
	WITH r2
	ROR
	WITH r3
	ROR
	WITH r6
	ROL
	WITH r5
	ROL
	LOOP
	NOP
	DEC r1
	FROM r6
	STB r1
	DEC r4
	BNE L01BE30
	NOP

L01BE71:
	WITH r9
	CMP r1
	BNE L01BE96
	IBT r12, #0002
	SMS r14, [#0064]
	LMS r3, [#0098]
	MOVES r3, r3
	BEQ L01BE94
	NOP
	LMS r1, [#002C]
	LMS r2, [#005C]
	TO r12
	FROM r2
	SUB r1
	MOVE r13, r15
	LDW r1
	ADD r3
	STW r1
	INC r1
	LOOP
	INC r1

L01BE94:
	STOP

L01BE96:
	CACHE
	LINK L01BE9C
	IWT r15, L01BF62

L01BE9C:
	IBT r6, #0002
	IBT r5, #0000
	IBT r12, #0008
	MOVES r4, r4
	BNE L01BEAB
	NOP
	IWT r15, L01BF36

L01BEAB:
	IBT r6, #0004
	IBT r0, #0002
	CMP r4
	BEQ L01BF0E
	NOP
	IBT r6, #0003
	IBT r0, #0001
	CMP r4
	BEQ L01BEF5
	NOP
	IBT r12, #0002
	LINK L01BEC4
	IWT r15, L01BF62

L01BEC4:
	IBT r0, #0003
	CMP r4
	BEQ L01BEE9
	NOP
	IBT r0, #0002
	CMP r4
	BEQ L01BEDA
	NOP
	WITH r4
	ADD r5, #0009
	MOVE r6, r4
	BRA L01BF0E

L01BEDA:
	IBT r12, #0002
	LINK L01BEE1
	IWT r15, L01BF62

L01BEE1:
	WITH r4
	ADD r7, #001A
	MOVE r6, r4
	BRA L01BF0E

L01BEE9:
	IBT r12, #0008
	LINK L01BEF0
	IWT r15, L01BF62

L01BEF0:
	MOVE r6, r4
	BRA L01BF0E

L01BEF5:
	IBT r12, #0008
	WITH r2
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BNE L01BF06
	NOP
	LINK L01BF05
	IWT r15, L01BF4A

L01BF05:
	NOP

L01BF06:
	BCS L01BF36
	NOP
	IBT r12, #000E
	BRA L01BF36

L01BF0E:
	IBT r12, #0010
	WITH r2
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BNE L01BF1E
	NOP
	LINK L01BF1E
	IWT r15, L01BF4A

L01BF1E:
	BCC L01BF36
	NOP
	IBT r12, #0008
	WITH r2
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BNE L01BF31
	NOP
	LINK L01BF31
	IWT r15, L01BF4A

L01BF31:
	BCS L01BF36
	NOP
	IBT r12, #000C

L01BF36:
	LINK L01BF3B
	IWT r15, L01BF62

L01BF3B:
	DEC r6

L01BF3C:
	FROM r1
	ADD r4
	DEC r0
	LDB r0
	DEC r1
	STB r1
	DEC r6
	BPL L01BF3C
	NOP
	JMP r8
	NOP

L01BF4A:
	TO r3
	GETB
	DEC r14
	WITH r3
	GETBH
	DEC r14
	TO r2
	GETB
	DEC r14
	WITH r2
	GETBH
	IBT r0, #0001
	ROR
	WITH r2
	ROR
	WITH r3
	ROR
	FROM r2
	OR r3
	JMP r11
	NOP

L01BF62:
	SUB r4
	MOVE r13, r7
	WITH r2

L01BF66:
	LSR
	WITH r3
	ROR
	FROM r2
	OR r3
	BEQ L01BF74
	NOP
	WITH r4
	ROL
	LOOP
	WITH r2
	JMP r11
	NOP

L01BF74:
	DEC r14
	TO r3
	GETB
	DEC r14
	WITH r3
	GETBH
	DEC r14
	TO r2
	GETB
	DEC r14
	WITH r2
	GETBH
	IBT r0, #0001
	ROR
	WITH r2
	ROR
	WITH r3
	ROR
	WITH r4
	ROL
	LOOP
	WITH r2
	JMP r11
	NOP
	IWT r1, #0200
	IWT r12, #3F00
	MOVE r13, r15
	SUB r0
	STW r1
	INC r1
	LOOP
	INC r1
	STOP
