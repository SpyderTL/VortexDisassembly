public class SnesRom
{
	public void L00DDDE()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x11B5];

		if (Z == 0)
			return this.L00DDEA();

		[0x1273] = 0;
	}

	public void L00DDEA()
	{
		A = [0x1ACF];

		if (Z == 0)
			return this.L00DDF4();

		A = [0x1DBA];

		if (Z == 0)
			return this.L00DDF5();
	}

	public void L00DDF4()
	{
		return;
	}

	public void L00DDF5()
	{
		P &= ~0x20;
		X = 0x30D4;
		[0x11FF] = X;
		A = [0x1277];
		A &= 0x00FF;

		if (Z == 1)
			return this.L00DE08();

		return this.L00E09A();
	}

	public void L00DE08()
	{
		A = [0x112D];
		A &= 0x0002;

		if (Z == 1)
			return this.L00DE13();

		return this.L00E09A();
	}

	public void L00DE13()
	{
		P |= 0x20;
		A = [0x1284];

		if (Z == 1)
			return this.L00DE30();

		A = [0x00F4];
		C = 1; temp = A - 0x06;

		if (Z == 1)
			return this.L00DE30();

		C = 1; temp = A - 0x02;

		if (Z == 1)
			return this.L00DE30();

		[0x127A] = 0;
		A = [0x1ABF];

		if (Z == 1)
			return this.L00DE92();

		return this.L00E09A();
	}

	public void L00DE30()
	{
		P &= ~0x20;
		this.L00E996();
		this.L00EAD5();
		P |= 0x20;
		A = [0x1284];

		if (Z == 0)
			return this.L00DE92();

		A = [0x1276];

		if (Z == 1)
			return this.L00DE4B();

		[0x1276]--;
		return this.L00DE92();
	}

	public void L00DE4B()
	{
		A = [0x1982];
		A &= 0x1F;

		if (Z == 0)
			return this.L00DE92();

		A = [0x1274];

		if (Z == 1)
			return this.L00DE92();

		C = 1; temp = A - 0x05;

		if (N == 1)
			return this.L00DE8F();

		A = [0x1275];
		C = 1; temp = A - 0x02;

		if (Z == 1)
			return this.L00DE7F();

		[0x1275]++;
		P &= ~0x20;
		A = 0x3C3C;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.L03855E();
		A = 0x64;
		[0x1276] = A;
		return this.L00DE8F();
	}

	public void L00DE7F()
	{
		A = [0x118F];

		if (Z == 0)
			return this.L00DE8F();

		X = [0x10FC];
		A = [0x15 + X];

		if (Z == 1)
			return this.L00DE8F();

		this.L03B515();
	}

	public void L00DE8F()
	{
		[0x1274] = 0;
	}

	public void L00DE92()
	{
		A = [0x127A];
		C = 1; temp = A - [0x1279];

		if (Z == 1)
			return this.L00DEA2();

		[0x1279] = A;
		A = 0x05;
		[0x1278] = A;
	}

	public void L00DEA2()
	{
		A = [0x1278];

		if (Z == 1)
			return this.L00DEAA();

		[0x1278]--;
	}

	public void L00DEAA()
	{
		P &= ~0x30;
		X = [0x10FC];
		A = [0x0C + X];
		[0x113E] = A;
		A = [0x10 + X];
		[0x1142] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.L00DED8();

		A = [0x10 + X];
		C = 1; temp = A - [0x1222];

		if (N == 1)
			return this.L00DECB();

		A = 0x0000;
		return this.L00DF4C();
	}

	public void L00DECB()
	{
		C = 1; temp = A - [0x121E];

		if (N == 0)
			return this.L00DED5();

		A = 0x0002;
		return this.L00DF4C();
	}

	public void L00DED5()
	{
		return this.L00E04D();
	}

	public void L00DED8()
	{
		A = [0x10 + X];
		C = 1; temp = A - [0x1222];

		if (N == 1)
			return this.L00DEEF();

		A = [0x31 + X];

		if (N == 1)
			return this.L00DF33();

		A = [0x10 + X];
		C = 1;
		A -= [0x31 + X] - !C;
		[0x10 + X] = A;
		A = 0x0000;
		return this.L00DF33();
	}

	public void L00DEEF()
	{
		C = 1; temp = A - [0x121E];

		if (N == 0)
			return this.L00DF04();

		A = [0x31 + X];

		if (N == 0)
			return this.L00DF33();

		A = [0x10 + X];
		C = 1;
		A -= [0x31 + X] - !C;
		[0x10 + X] = A;
		A = 0x0002;
		return this.L00DF33();
	}

	public void L00DF04()
	{
		A = [0x0C + X];
		C = 1; temp = A - [0x1220];

		if (N == 1)
			return this.L00DF1B();

		A = [0x2D + X];

		if (N == 1)
			return this.L00DF33();

		A = [0x0C + X];
		C = 1;
		A -= [0x2D + X] - !C;
		[0x0C + X] = A;
		A = 0x0003;
		return this.L00DF33();
	}

	public void L00DF1B()
	{
		C = 1; temp = A - [0x121C];

		if (N == 0)
			return this.L00DF30();

		A = [0x2D + X];

		if (N == 0)
			return this.L00DF33();

		A = [0x0C + X];
		C = 1;
		A -= [0x2D + X] - !C;
		[0x0C + X] = A;
		A = 0x0001;
		return this.L00DF33();
	}

	public void L00DF30()
	{
		return this.L00E04D();
	}

	public void L00DF33()
	{
		P |= 0x20;
		A = 0xFF;
		[0x1273] = A;
		[0x1274]++;
		P &= ~0x20;
		A = [0x0C + X];
		[0x113E] = A;
		A = [0x10 + X];
		[0x1142] = A;
		return this.L00E04D();
	}

	public void L00DF4C()
	{
		[0x192C]++;
		P &= ~0x20;
		A &= 0x00FF;
		[0x3A] = A;
		A = [0x001224];
		[0x3C] = A;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		X = A;
		A = [0x048487 + X];
		A &= 0x00FF;
		C = 1; temp = A - 0x00FF;

		if (Z == 0)
			return this.L00DF71();

		return this.L00E04D();
	}

	public void L00DF71()
	{
		[0x001224] = A;
		A <<= 1;
		[0x00] = A;
		A = [0x1226];
		C = 0;
		A += [0x00] + C;
		X = A;
		A = [0x02F4F2 + X];

		if (Z == 0)
			return this.L00DF8E();

		A = [0x3C];
		[0x001224] = A;
		return this.L00E04D();
	}

	public void L00DF8E()
	{
		[0x1228] = A;
		P &= ~0x20;
		A = [0x3A];
		Stack.Push(A);
		this.L00EA70();
		P |= 0x20;
		P &= ~0x20;
		A = 0x3BA1;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.L03855E();
		P &= ~0x20;
		A = Stack.Pop();
		[0x3A] = A;
		X = [0x10FC];
		A = [0x0C + X];
		[0x24] = A;
		A = [0x10 + X];
		[0x26] = A;
		A = [0x3A];
		C = 1; temp = A - 0x0000;

		if (Z == 0)
			return this.L00DFCE();

		A = [0x00121E];
		[0x10 + X] = A;
		return this.L00DFF3();
	}

	public void L00DFCE()
	{
		C = 1; temp = A - 0x0001;

		if (Z == 0)
			return this.L00DFDB();

		A = [0x001220];
		[0x0C + X] = A;
		return this.L00DFF3();
	}

	public void L00DFDB()
	{
		C = 1; temp = A - 0x0002;

		if (Z == 0)
			return this.L00DFE8();

		A = [0x001222];
		[0x10 + X] = A;
		return this.L00DFF3();
	}

	public void L00DFE8()
	{
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L00DFF3();

		A = [0x00121C];
		[0x0C + X] = A;
	}

	public void L00DFF3()
	{
		A = [0x0C + X];
		C = 1;
		A -= [0x24] - !C;
		[0x24] = A;
		A = [0x10 + X];
		C = 1;
		A -= [0x26] - !C;
		[0x26] = A;
		X = [0x10DB];

		if (Z == 1)
			return this.L00E022();

	}

	public void L00E006()
	{
		A = X;
		C = 1; temp = A - [0x10FC];

		if (Z == 1)
			return this.L00E01A();

		A = [0x0C + X];
		C = 0;
		A += [0x24] + C;
		[0x0C + X] = A;
		A = [0x10 + X];
		C = 0;
		A += [0x26] + C;
		[0x10 + X] = A;
	}

	public void L00E01A()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 1)
			return this.L00E022();

		return this.L00E006();
	}

	public void L00E022()
	{
		A = [0x11CE];
		C = 0;
		A += [0x24] + C;
		[0x11CE] = A;
		[0x00C5] = A;
		A = [0x11D2];
		C = 0;
		A += [0x26] + C;
		[0x11D2] = A;
		[0x00C9] = A;
		this.L00E996();
		this.L00EAD5();
		P |= 0x20;
		A = 0x01;
		[0x192E] = A;
		this.L04BA61();
	}

	public void L00E04D()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		A = [0x192F];
		C = 1;
		A -= [0x15 + X] - !C;

		if (Z == 0)
			return this.L00E061();

		[0x192E]--;

		if (Z == 0)
			return this.L00E09A();

	}

	public void L00E061()
	{
		A = 0x5A;
		C = 1;
		A -= [0x15 + X] - !C;

		if (N == 0)
			return this.L00E06A();

		A = 0x00;
	}

	public void L00E06A()
	{
		A >>= 1;
		A >>= 1;
		C = 1; temp = A - 0x04;

		if (N == 0)
			return this.L00E072();

		A = 0x04;
	}

	public void L00E072()
	{
		C = 1; temp = A - 0x19;

		if (N == 1)
			return this.L00E078();

		A = 0x19;
	}

	public void L00E078()
	{
		[0x192E] = A;
		A = [0x1216];

		if (Z == 0)
			return this.L00E090();

		A = [0x1284];

		if (Z == 1)
			return this.L00E090();

		A = [0x00F4];
		C = 1; temp = A - 0x06;

		if (Z == 1)
			return this.L00E090();

		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L00E09A();
	}

	public void L00E090()
	{
		P &= ~0x20;
		this.L02C580();
		this.L00E0A7();
	}

	public void L00E09A()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		A = [0x15 + X];
		[0x192F] = A;
		return;
	}

	public void L00E0A7()
	{
		P &= ~0x30;
		X = [0x1932];
		A = 0xFFFF;
		[0x11F5] = A;
		[0x124C] = 0;
		this.L00E0F6();
		return;
	}

	public void L00E0BA_Done()
	{
		return;
	}

	public void L00E0F6()
	{
		P &= ~0x20;
		A = [0x048000 + X];
		A &= 0x00FF;
		Y = X;
		X = A;
		return [(0xE104 + X)]();
	}

	public void L00E8D5()
	{
		P &= ~0x30;
		A = 0x0000;
		X = 0x0FFE;
	}

	public void L00E8DD()
	{
		[0x7E563E + X] = A;
		X--;
		X--;

		if (Z == 0)
			return this.L00E8DD();

		P |= 0x20;
		P &= ~0x10;
		[0x1254] = 0;
		[0x127A] = 0;
		return;
	}

	public void L00E8F0()
	{
		P &= ~0x20;
		A = 0x0040;
		[0x1255] = A;
		[0x1257] = A;
		A = 0x0020;
		[0x1259] = A;
		[0x125B] = A;
		P |= 0x20;
		P &= ~0x10;
		[0x1254] = 0;
		[0x127A] = 0;
		P &= ~0x20;
		X = [0x1228];

		if (Z == 0)
			return this.L00E918();

		return this.L00E995_Done();
	}

	public void L00E918()
	{
		A = [0x02F4F2 + X];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1254] = A;
		A = [0x02F4F4 + X];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = [0x701000];
		[0x1255] = A;
		A = [0x701002];
		[0x1257] = A;
		A = [0x701008];
		[0x00121C] = A;
		A = [0x70100A];
		[0x001222] = A;
		A = [0x70100C];
		[0x001220] = A;
		A = [0x70100E];
		[0x00121E] = A;
		Y = 0x1000;
		P |= 0x20;
		X = 0x0000;
	}

	public void L00E977_Loop()
	{
		A = [0x701010 + X];
		[0x7E463E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L00E977_Loop();

		Y = 0x1000;
		X = 0x0000;
	}

	public void L00E989_Loop()
	{
		A = [0x701010 + X];
		[0x7E563E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L00E989_Loop();
	}

	public void L00E995_Done()
	{
		return;
	}

	public void L00E996()
	{
		P |= 0x20;
		[0x127A] = 0;
		P &= ~0x30;
		X = [0x10FC];
		A = [0x0C + X];
		C = 0;
		A += 0x00FF + C;
		A &= 0xFE00;
		[0x1263] = A;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += 0x0020 + C;
		[0x125F] = A;
		A = [0x10 + X];
		C = 0;
		A += 0x00FF + C;
		A &= 0xFE00;
		[0x1265] = A;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += 0x0020 + C;
		A ^= 0xFFFF;
		A++;
		C = 0;
		A += [0x1257] + C;
		[0x1261] = A;
		X = A;
		A = 0x0000;
	}

	public void L00EA1A_Loop()
	{
		C = 0;
		A += [0x1255] + C;
		X--;

		if (Z == 0)
			return this.L00EA1A_Loop();

		C = 0;
		A += [0x125F] + C;
		[0x125D] = A;
		C = 1; temp = A - 0x1000;

		if (C == 1)
			return this.L00EA53_Done();

		X = A;
		A = [0x1254];
		A &= 0x00FF;

		if (Z == 1)
			return this.L00EA53_Done();

		P |= 0x20;
		A = [0x7E563E + X];

		if (Z == 1)
			return this.L00EA53_Done();

		A--;
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x0AF34D + X];
		[0x127A] = A;
		return;
	}

	public void L00EA53_Done()
	{
		P |= 0x20;
		A = 0x00;
		[0x127A] = A;
		return;
	}

	public void L00EA5B()
	{
		P &= ~0x30;
		A = 0x0000;
		X = 0x0FFE;
	}

	public void L00EA63_Loop()
	{
		[0x7E363E + X] = A;
		X--;
		X--;

		if (Z == 0)
			return this.L00EA63_Loop();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L00EA70()
	{
		P &= ~0x30;
		X = [0x1228];

		if (Z == 1)
			return this.L00EAD4_Done();

		A = [0x02F4F5 + X];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = [0x02F4F7 + X];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = [0x701004];
		[0x126B] = A;
		A = [0x701006];
		[0x126D] = A;
		A = 0x0002;
		C = 1;
		A -= [0x10B4] - !C;
		[0x3A] = A;
		A = 0x1000;
		Y = A;
		P |= 0x20;
		X = 0x0000;
	}

	public void L00EABB_Loop()
	{
		A = [0x701010 + X];
		C = 1; temp = A - 0x5C;

		if (Z == 0)
			return this.L00EACC_Skip();

		A = [0x3A];

		if (Z == 1)
			return this.L00EACC_Skip();

		A--;
		[0x3A] = A;
		A = 0x5C;
	}

	public void L00EACC_Skip()
	{
		[0x7E363E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L00EABB_Loop();
	}

	public void L00EAD4_Done()
	{
		return;
	}

	public void L00EAD5()
	{
		P &= ~0x30;
		[0x127B] = 0;
		A = [0x125F];
		C = 1; temp = A - 0x0007;

		if (C == 1)
			return this.L00EAE5_Skip();

		A = 0x0007;
	}

	public void L00EAE5_Skip()
	{
		C = 1; temp = A - 0x0039;

		if (C == 0)
			return this.L00EAED_Skip();

		A = 0x0039;
	}

	public void L00EAED_Skip()
	{
		[0x3A] = A;
		C = 1;
		A -= [0x125F] - !C;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		[0x0A] = A;
		A = [0x1261];
		C = 1; temp = A - 0x0007;

		if (C == 1)
			return this.L00EB09_Skip();

		A = 0x0007;
	}

	public void L00EB09_Skip()
	{
		C = 1; temp = A - 0x0039;

		if (C == 0)
			return this.L00EB11_Skip();

		A = 0x0039;
	}

	public void L00EB11_Skip()
	{
		[0x3C] = A;
		C = 1;
		A -= [0x1261] - !C;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		[0x0C] = A;
		A = [0x3C];
		X = A;
		A = 0x0000;
	}

	public void L00EB28_Loop()
	{
		C = 0;
		A += [0x1255] + C;
		X--;

		if (Z == 0)
			return this.L00EB28_Loop();

		C = 0;
		A += [0x3A] + C;
		C = 1;
		A -= 0x0186 - !C;
		Stack.Push(A);
		X = [0x10FC];
		A = [0x0C + X];
		C = 0;
		A += 0x00FF + C;
		A &= 0xFE00;
		C = 1;
		A -= 0x0C00 - !C;
		C = 0;
		A += [0x0A] + C;
		[0x1250] = A;
		[0x124E] = A;
		[0x126F] = A;
		A = [0x10 + X];
		C = 0;
		A += 0x00FF + C;
		A &= 0xFE00;
		C = 0;
		A += 0x0C00 + C;
		C = 1;
		A -= [0x0C] - !C;
		[0x1252] = A;
		[0x1271] = A;
		A = Stack.Pop();
		X = A;
		this.L00EB70();
		return;
	}

	public void L00EB70()
	{
		A = 0x000C;
		Y = A;
	}

	public void L00EB74_Loop()
	{
		Stack.Push(Y);
		Y = 0x000C;
		Stack.Push(X);
	}

	public void L00EB79_Loop()
	{
		[0x125D] = X;
		P |= 0x20;
		A = [0x7E363E + X];
		P &= ~0x20;
		A &= 0x00FF;

		if (Z == 1)
			return this.L00EBA5();

		[0x36] = A;
		[0x127B]++;
		Stack.Push(X);
		Stack.Push(Y);
		A--;
		this.L00EC12();
		Y = Stack.Pop();
		X = Stack.Pop();
		A &= 0xFFFF;

		if (Z == 0)
			return this.L00EBA5();

		P |= 0x20;
		A = 0x00;
		[0x7E363E + X] = A;
		P &= ~0x20;
	}

	public void L00EBA5()
	{
		Stack.Push(X);
		A = [0x1254];
		A &= 0x00FF;

		if (Z == 1)
			return this.L00EBE0_Skip();

		A = X;
		C = 0;
		A += 0x1000 + C;
		X = A;
		[0x125D] = X;
		P |= 0x20;
		A = [0x7E363E + X];
		P &= ~0x20;
		A &= 0x00FF;

		if (Z == 1)
			return this.L00EBE0_Skip();

		[0x36] = A;
		[0x127B]++;
		Stack.Push(X);
		Stack.Push(Y);
		A--;
		this.L00EC12();
		Y = Stack.Pop();
		X = Stack.Pop();
		A &= 0xFFFF;

		if (Z == 0)
			return this.L00EBE0_Skip();

		P |= 0x20;
		A = 0x00;
		[0x7E363E + X] = A;
		P &= ~0x20;
	}

	public void L00EBE0_Skip()
	{
		X = Stack.Pop();
		A = [0x1250];
		C = 0;
		A += 0x0200 + C;
		[0x1250] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L00EB79_Loop();

		X = Stack.Pop();
		A = X;
		C = 0;
		A += 0x0040 + C;
		X = A;
		A = [0x124E];
		[0x1250] = A;
		A = [0x1252];
		C = 1;
		A -= 0x0200 - !C;
		[0x1252] = A;
		Y = Stack.Pop();
		Y--;

		if (Z == 1)
			return this.L00EC0D_Done();

		return this.L00EB74_Loop();
	}

	public void L00EC0D_Done()
	{
		return;
	}

	public void L00EC12()
	{
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		Stack.Push(X);
		A = [0x0AF34D + X];
		A &= 0x00FF;

		if (Z == 0)
			return this.L00EC38();

		A = [0x0AF348 + X];
		C = 1; temp = A - 0xE51D;

		if (Z == 0)
			return this.L00EC38();

		A = [0x127F];
		A &= 0x00FF;
		C = 1; temp = A - 0x002C;

		if (C == 0)
			return this.L00EC38();

		return this.L00ED14_Done();
	}

	public void L00EC38()
	{
		X = [0x10DB];
		Y = X;
		X = [0x10DD];

		if (Z == 0)
			return this.L00EC45();

		X = Y;
		return this.L00ED14_Done();
	}

	public void L00EC45()
	{
		A = [0x00 + X];
		[0x10DD] = A;
		A = Y;

		if (Z == 0)
			return this.L00EC59();

		A = [0x10DB];
		[0x00 + X] = A;
		[0x02 + X] = 0;
		[0x10DB] = X;
		return this.L00EC62();
	}

	public void L00EC59()
	{
		A = [0x0000 + Y];
		[0x00 + X] = A;
		[0x00 + Y] = Y;
		[0x02 + X] = X;
	}

	public void L00EC62()
	{
		Y = [0x00 + X];

		if (Z == 1)
			return this.L00EC68();

		[0x02 + Y] = Y;
	}

	public void L00EC68()
	{
		Y = X;
		X = Stack.Pop();
		P |= 0x20;
		this.L03A054();
		P |= 0x20;
		A = [0x36];
		Stack.Push(X);
		X = Y;
		[0x7E1CDE + X] = A;
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x125D];
		[0x0034 + Y] = A;
		A = [0x0AF340 + X];
		C = 0;
		A += [0x1250] + C;
		[0x000C + Y] = A;
		A = [0x0AF342 + X];
		[0x000E + Y] = A;
		A = [0x0AF344 + X];
		C = 0;
		A += [0x1252] + C;
		[0x0010 + Y] = A;
		A = [0x0AF346 + X];
		[0x0004 + Y] = A;
		C = 1; temp = A - 0xCBFC;

		if (Z == 0)
			return this.L00ECCA();

		Stack.Push(X);
		X = Y;
		this.L02C640();
		C = 1; temp = A - [0x11FF];

		if (N == 0)
			return this.L00ECC9();

		[0x11FF] = A;
		A = [0x0C + X];
		[0x1201] = A;
		A = [0x0E + X];
		[0x1203] = A;
		A = [0x10 + X];
		[0x1205] = A;
	}

	public void L00ECC9()
	{
		X = Stack.Pop();
	}

	public void L00ECCA()
	{
		A = [0x0AF348 + X];
		[0x0016 + Y] = A;
		C = 1; temp = A - 0xE567;

		if (Z == 0)
			return this.L00ECDF();

		P |= 0x20;
		A = 0x20;
		[0x0009 + Y] = A;
		return this.L00ED00();
	}

	public void L00ECDF()
	{
		P &= ~0x20;
		C = 1; temp = A - 0xE51D;

		if (Z == 0)
			return this.L00ECED();

		P |= 0x20;
		A = 0x01;
		[0x0009 + Y] = A;
	}

	public void L00ECED()
	{
		P |= 0x20;
		A = [0x0AF34D + X];
		C = 1; temp = A - 0x01;

		if (C == 0)
			return this.L00ED00();

		C = 1; temp = A - 0x12;

		if (C == 1)
			return this.L00ED00();

		A = 0x10;
		[0x0009 + Y] = A;
	}

	public void L00ED00()
	{
		A = [0x0AF34A + X];
		[0x0018 + Y] = A;
		P &= ~0x20;
		A = [0x0AF34B + X];
		[0x0006 + Y] = A;
		A = 0x0000;
		return;
	}

	public void L00ED14_Done()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0xFFFF;
		return;
	}

	public void L00FD1B_Reset()
	{
		// Disable Emulation
		C = 0;
		temp = C; C = E; E = temp;

		return this.L0293A1_Start();
	}

	public void L00FD21_Break()
	{
		return;
	}

	public void L01F074()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x3A;
		[0xF7] = A;
		A = 0xA7;
		[0xF8] = A;
		A = 0x55;
		[0xF9] = A;
		A = 0x7F;
		[0xFA] = A;
		A = [0x9307];
		[0x1095] = A;
		A = [0x9317];
		[0x1096] = A;
		A = [0x9327];
		[0x1097] = A;
		A = [0x9337];
		[0x1098] = A;
		[0x9B] = 0;
		[0xBD] = 0;
		[0x98] = 0;
		[0x9F] = 0;
		[0xA0] = 0;
		[0xA1] = 0;
		[0x9C] = 0;
		[0xE0] = 0;
		[0x1A09] = 0;
		[0x1A0B] = 0;
		[0x1A0D] = 0;
		[0x110C] = 0;
		[0x110D] = 0;
		A = 0x00;
		[0x199F] = A;
		A = 0xF4;
		[0xBB] = A;
		A = 0x01;
		[0xBC] = A;
		this.L01F136();
		this.L01F11B();
		this.L01F0DA();
		P = Stack.Pop();
		return;
	}

	public void L01F0DA()
	{
		A = 0xFF;
		[0x1994] = A;
		this.L01F815();
		P &= ~0x20;
		A = [0xCE];
		[0x700034] = A;
		A = [0xD0];
		[0x700036] = A;
		A = [0x24];
		[0x700038] = A;
		A = [0x28];
		[0x70003A] = A;
		A = [0x26];
		[0x70003C] = A;
		A = [0x2A];
		[0x70003E] = A;
		A = 0x154D;
		A = [0x2C];
		[0x7000A4] = A;
		A = [0x2E];
		[0x7000A6] = A;
		P |= 0x20;
		return;
	}

	public void L01F11B()
	{
		Stack.Push(P);
		P |= 0x30;
		Y = 0x00;
		X = 0x00;
		A = 0x80;
		[0x63] = A;
	}

	public void L01F126()
	{
		A = [0x9648 + Y];
		[0x7010EE + X] = A;
		X++;
		Y++;
		Y++;
		[0x63]--;

		if (Z == 0)
			return this.L01F126();

		P = Stack.Pop();
		return;
	}

	public void L01F136()
	{
		Stack.Push(P);
		P &= ~0x20;
		[0x1A08] = 0;
		[0x1A0A] = 0;
		[0x1A0C] = 0;
		A = [0x1A08];
		[0x1A02] = A;
		A = [0x1A0A];
		[0x1A04] = A;
		A = [0x1A0C];
		[0x1A06] = A;
		P |= 0x20;
		this.L01F208();
		P &= ~0x20;
		A = [0x19AC];
		[0x19F0] = A;
		A = [0x19AE];
		[0x19F2] = A;
		A = [0x19B0];
		[0x19F4] = A;
		A = [0x19B2];
		[0x19F6] = A;
		A = [0x19B4];
		[0x19F8] = A;
		A = [0x19B6];
		[0x19FA] = A;
		A = [0x19B8];
		[0x19FC] = A;
		A = [0x19BA];
		[0x19FE] = A;
		A = [0x19BC];
		[0x1A00] = A;
		P |= 0x20;
		A = 0x7F;
		[0x19DF] = A;
		[0x19E1] = 0;
		[0x19E3] = 0;
		[0x19E5] = 0;
		[0x19E7] = A;
		[0x19E9] = 0;
		[0x19EB] = 0;
		[0x19ED] = 0;
		[0x19EF] = A;
		[0x19DE] = 0;
		[0x19E0] = 0;
		[0x19E2] = 0;
		[0x19E4] = 0;
		[0x19E6] = 0;
		[0x19E8] = 0;
		[0x19EA] = 0;
		[0x19EC] = 0;
		[0x19EE] = 0;
		P = Stack.Pop();
		return;
	}

	public void L01F1CE()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x30;
		A = [0x00];
		[0x700064] = A;
		A = [0x06];
		[0x70002C] = A;
		A = [0x93];
		[0x70002E] = A;
		P |= 0x20;
		A = 0x01;
		X = 0x84BC;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = [0x700026];
		[0xB7] = A;
		A = [0x700028];
		[0xB9] = A;
		A = [0x70002A];
		[0xBB] = A;
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L01F208()
	{
		P &= ~0x20;
		A = [0x1A02];
		[0x700020] = A;
		A = [0x1A04];
		[0x700022] = A;
		A = [0x1A06];
		[0x700024] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0x8513;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = [0x7000E4];
		[0x19AC] = A;
		A = [0x7000E6];
		[0x19AE] = A;
		A = [0x7000E8];
		[0x19B0] = A;
		A = [0x7000EA];
		[0x19B2] = A;
		A = [0x7000EC];
		[0x19B4] = A;
		A = [0x7000EE];
		[0x19B6] = A;
		A = [0x7000F0];
		[0x19B8] = A;
		A = [0x7000F2];
		[0x19BA] = A;
		A = [0x7000F4];
		[0x19BC] = A;
		P |= 0x30;
		return;
	}

	public void L01F334()
	{
		A = [0x00];
		[0x87] = A;
		A = [0x01];
		[0x88] = A;
		A = [0x93];
		[0x89] = A;
		A = [0x94];
		[0x8A] = A;
		this.L01F387();
		A = [0x8B];
		[0x75] = A;
		A = [0x8C];
		[0x76] = A;
		A = [0x06];
		[0x87] = A;
		A = [0x07];
		[0x88] = A;
		A = [0x93];
		[0x89] = A;
		A = [0x94];
		[0x8A] = A;
		this.L01F387();
		A = [0x8B];
		[0x77] = A;
		A = [0x8C];
		[0x78] = A;
		C = 0;
		A = [0xD0];
		A += [0x77] + C;
		[0x77] = A;
		A = [0xD1];
		A += [0x78] + C;
		[0x78] = A;
		C = 1;
		A = [0x77];
		A -= [0xCE] - !C;
		[0x77] = A;
		A = [0x78];
		A -= [0xCF] - !C;
		[0x78] = A;
		return;
	}

	public void L01F387()
	{
		X = 0x00;
		A = [0x8A];

		if (Z == 1)
			return this.L01F399();

		X++;
		A >>= 1;

		if (Z == 1)
			return this.L01F397();

	}

	public void L01F391()
	{
		Cpu.ROR(0x89);
		X++;
		A >>= 1;

		if (Z == 0)
			return this.L01F391();

	}

	public void L01F397()
	{
		Cpu.ROR(0x89);
	}

	public void L01F399()
	{
		[0x95] = X;
		X = 0x00;
		A = [0x88];
		[0x8E] = A;

		if (N == 0)
			return this.L01F3B0();

		A = 0x00;
		C = 1;
		A -= [0x87] - !C;
		[0x87] = A;
		A = 0x00;
		A -= [0x88] - !C;
		[0x88] = A;
	}

	public void L01F3B0()
	{

		if (Z == 1)
			return this.L01F3C1();

		X++;
		A >>= 1;

		if (Z == 1)
			return this.L01F3BC();

	}

	public void L01F3B6()
	{
		Cpu.ROR(0x87);
		X++;
		A >>= 1;

		if (Z == 0)
			return this.L01F3B6();

	}

	public void L01F3BC()
	{
		Cpu.ROR(0x87);
		return this.L01F3D8();
	}

	public void L01F3C1()
	{
		A = [0x87];

		if (N == 1)
			return this.L01F3D8();


		if (Z == 0)
			return this.L01F3D2();

		A = [0xCE];
		[0x8B] = A;
		A = [0xCF];
		[0x8C] = A;
		return this.L01F438_Done();
	}

	public void L01F3D2()
	{
		X--;
		A <<= 1;

		if (N == 0)
			return this.L01F3D2();

		[0x87] = A;
	}

	public void L01F3D8()
	{
		A = [0x89];
		C = 1; temp = A - [0x87];

		if (C == 0)
			return this.L01F3E6();

	}

	public void L01F3DE()
	{
		X--;
		A >>= 1;
		C = 1; temp = A - [0x87];

		if (C == 1)
			return this.L01F3DE();

		[0x89] = A;
	}

	public void L01F3E6()
	{
		A = X;
		C = 1;
		A -= [0x95] - !C;
		[0x8D] = A;
		X = [0x87];
		A = [0x8204 + X];
		X = [0x89];
		C = 1;
		A -= [0x8204 + X] - !C;
		X = A;
		A = [0x8104 + X];
		[0x8C] = A;
		A = [0x8004 + X];
		X = [0x8D];

		if (N == 1)
			return this.L01F40F();


		if (Z == 1)
			return this.L01F415();

	}

	public void L01F406()
	{
		A <<= 1;
		Cpu.ROL(0x8C);
		X--;

		if (Z == 0)
			return this.L01F406();

		return this.L01F415();
	}

	public void L01F40F()
	{
		[0x8C] >>= 1;
		Cpu.ROR();
		X++;

		if (Z == 0)
			return this.L01F40F();

	}

	public void L01F415()
	{
		[0x8B] = A;
		temp = A & [0x8E];

		if (N == 0)
			return this.L01F42B();

		C = 1;
		A = [0xCE];
		A -= [0x8B] - !C;
		[0x8B] = A;
		A = [0xCF];
		A -= [0x8C] - !C;
		[0x8C] = A;
		return this.L01F438_Done();
	}

	public void L01F42B()
	{
		C = 0;
		A = [0x8B];
		A += [0xCE] + C;
		[0x8B] = A;
		A = [0x8C];
		A += [0xCF] + C;
		[0x8C] = A;
	}

	public void L01F438_Done()
	{
		return;
	}

	public void L01F622()
	{

		if (N == 0)
			return this.L01F627();

		return this.L01F825();
	}

	public void L01F627()
	{
		P &= ~0x20;
		A = [0x1135];
		A &= 0x00FF;
		A ^= 0x00FF;
		C = 1;
		A -= 0x0780 - !C;
		[0x00] = A;
		A = [0x1139];
		A &= 0x00FF;
		A ^= 0x00FF;
		C = 1;
		A -= 0x0780 - !C;
		[0x93] = A;
		A = 0x0000;
		C = 1;
		A -= [0x1137] - !C;
		[0x06] = A;
		A = [0x1135];
		A &= 0xFF00;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		P |= 0x20;
		[0x1A93] = A;
		P &= ~0x20;
		A = [0x1139];
		A &= 0xFF00;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		P |= 0x20;
		[0x1A94] = A;
		this.L01F1CE();
		P &= ~0x20;
		A = [0xB7];
		[0x00] = A;
		A = [0xB9];
		[0x06] = A;
		A = [0xBB];
		[0x93] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x19F0];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A81] = A;
		A = [0x19F2];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A83] = A;
		A = [0x19F4];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A85] = A;
		A = [0x19F6];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A87] = A;
		A = [0x19F8];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A89] = A;
		A = [0x19FA];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8B] = A;
		A = [0x19FC];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8D] = A;
		A = [0x19FE];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8F] = A;
		A = [0x1A00];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x1A91] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x00];
		[0x700064] = A;
		A = [0x06];
		[0x70002C] = A;
		A = [0x93];
		[0x70002E] = A;
		A = [0x1A81];
		[0x700154] = A;
		A = [0x1A83];
		[0x700156] = A;
		A = [0x1A85];
		[0x700158] = A;
		A = [0x1A8D];
		[0x70015A] = A;
		A = [0x1A8F];
		[0x70015C] = A;
		A = [0x1A91];
		[0x70015E] = A;
		P |= 0x20;
		P &= ~0x10;
		A = [0x1A93];
		[0x700162] = A;
		A = [0x1A94];
		[0x700164] = A;
		P |= 0x30;
		return;
	}

	public void L01F815()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBA8F;
		this.L7ED7E8_ExecuteSuperFX();
		P |= 0x30;
		return;
	}

	public void L01F825()
	{
		P &= ~0x20;
		A = [0x1135];
		[0x7000D8] = A;
		A = [0x1137];
		[0x7000DA] = A;
		A = [0x1139];
		[0x7000DC] = A;
		A = [0x19F0];
		[0x7000E4] = A;
		A = [0x19F2];
		[0x7000E6] = A;
		A = [0x19F4];
		[0x7000E8] = A;
		A = [0x19F6];
		[0x7000EA] = A;
		A = [0x19F8];
		[0x7000EC] = A;
		A = [0x19FA];
		[0x7000EE] = A;
		A = [0x19FC];
		[0x7000F0] = A;
		A = [0x19FE];
		[0x7000F2] = A;
		A = [0x1A00];
		[0x7000F4] = A;
		P |= 0x30;
		return;
	}

	public void L01F87E_CopyRomToRam()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		X = 0x001C;
	}

	public void L01F886()
	{
		A = [0x01F8BD + X];
		[0x7ED7E8 + X] = A;
		X--;

		if (N == 0)
			return this.L01F886();

		X = 0x0053;
	}

	public void L01F894()
	{
		A = [0x01FC87 + X];
		[0x000101 + X] = A;
		X--;

		if (N == 0)
			return this.L01F894();

		X = 0x03AE;
	}

	public void L01F8A2()
	{
		A = [0x01F8D9 + X];
		[0x7ED804 + X] = A;
		X--;

		if (N == 0)
			return this.L01F8A2();

		X = 0x1193;
	}

	public void L01F8B0_Loop()
	{
		A = [0x028000 + X];
		[0x7EC654 + X] = A;
		X--;

		if (N == 0)
			return this.L01F8B0_Loop();

		P = Stack.Pop();
		return;
	}

	public void L02915C()
	{
		P &= ~0x20;
		A = 0x0C00;
		A |= [0x10B2];
		return this.L029213_SendApuCommand();
	}

	public void L029167_ResetSound()
	{
		P &= ~0x30;
		A = 0x0000;
		[0x10A0] = A;
		[0x10A2] = A;
		[0x10A4] = A;
		[0x10A6] = A;
		X = 0x0000;
		Y = 0x001E;
	}

	public void L02917E_Loop()
	{
		[0x7E2D5E + X] = A;
		[0x7E2D9A + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L02917E_Loop();

		return;
	}

	public void L029213_SendApuCommand()
	{
		P &= ~0x30;
		A |= [0x109C];
		Stack.Push(X);
		X = [0x10A0];
		C = 1; temp = X - [0x10A2];

		if (Z == 0)
			return this.L029225();

		[0x002140] = A;
	}

	public void L029225()
	{
		[0x7E2D5E + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x003C;

		if (Z == 0)
			return this.L029233();

		X = 0x0000;
	}

	public void L029233()
	{
		[0x10A0] = X;
		A = [0x109C];
		A ^= 0x0100;
		[0x109C] = A;
		X = Stack.Pop();
		return;
	}

	public void L029241_InitializeSound()
	{
		P &= ~0x20;
		[0x109C] = 0;
		[0x109E] = 0;
		A = 0x8000;
		[0x53] = A;
		A = 0x000E;
		[0x55] = A;
		this.L02931D_LoadApu();
		return;
	}

	public void L029283_LoadSong()
	{
		Stack.Push(X);
		Stack.Push(A);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x30;
		A <<= 1;
		X = A;
		this.L0292C9_LoadCompressedApuData();
		A = 0x4201;
		this.L029213_SendApuCommand();
		P = Stack.Pop();
		Y = Stack.Pop();
		A = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L02929A_LoadSong()
	{
		P &= ~0x30;
		[0x0010B0] = A;
		A <<= 1;
		X = A;
		this.L0292C9_LoadCompressedApuData();
		A = 0x4203;
		this.L029213_SendApuCommand();
		return;
	}

	public void L0292AD_LoadSong11()
	{
		Stack.Push(X);
		Stack.Push(A);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x30;
		A = 0x0011;
		A <<= 1;
		X = A;
		this.L0292C9_LoadCompressedApuData();
		A = 0x0001;
		this.L029310_SendApuCommand();
		P &= ~0x20;
		P = Stack.Pop();
		Y = Stack.Pop();
		A = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public byte[] L029257_Pointers = new byte[]
	{
		0xC8, 0x81,		// 0x0F81C8
		0xE4, 0x87,		// 0x0F87E4
		0x1C, 0x91,		// 0x0F911C
		0x04, 0x98,		// 0x0F9804
		0x6C, 0x9D,		// 0x0F9D6C
		0xE8, 0x9E,		// 0x0F9EE8
		0x40, 0xA5,		// 0x0FA540
		0x20, 0xAD,		// 0x0FAD20
		0xD4, 0xB4,		// 0x0FB4D4
		0x9C, 0xBD,		// 0x0FBD9C
		0x44, 0xBF,		// 0x0FBF44
		0x84, 0xC0,		// 0x0FC084
		0x68, 0xC3,		// 0x0FC368
		0x14, 0xC4,		// 0x0FC414
		0x14, 0xC4,		// 0x0FC414
		0x14, 0xC4,		// 0x0FC414
		0x10, 0xC7,		// 0x0FC710
		0x7C, 0xCB,		// 0x0FCB7C
		0xE4, 0xCC,		// 0x0FCCE4
		0x64, 0xD1,		// 0x0FD164
		0x58, 0xD2,		// 0x0FD258
		0x98, 0xD4 		// 0x0FD498
	}

	public void L0292C9_LoadCompressedApuData()
	{
		// Source = PointerTable029257[X];
		A = [0x029257 + X];
		[0x700064] = A;

		// Destination = 0x1000;
		A = 0x1000;
		[0x70002C] = A;

		// Source Bank = 0x0F;
		P |= 0x20;
		A = 0x0F;
		[0x700066] = A;

		// Function = 0x01BDB1;
		A = 0x01;
		X = 0xBDB1;

		this.L7ED7E8_ExecuteSuperFX();

		P &= ~0x20;
		A = 0x1000;
		[0x53] = A;
		A = 0x0070;
		[0x55] = A;

		this.L02931D_LoadApu();

		P &= ~0x20;
		Y = 0x0002;
	}

	public void L0292FD_Loop()
	{
		C = 1; temp = Y - [0x2140];

		if (Z == 0)
			return this.L0292FD_Loop();

		this.L029167_ResetSound();

		return;
	}

	public void L029310_SendApuCommand()
	{
		P &= ~0x20;
		A &= 0x00FF;
		A |= 0x0400;

		this.L029213_SendApuCommand();

		return;
	}

	public void L02931D_LoadApu()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(A);
		Stack.Push(P);

		this.L029167_ResetSound();

		P &= ~0x30;
		Y = 0x0000;
		A = 0xBBAA;
	}

	public void L02932C_Wait()
	{
		C = 1; temp = A - [0x2140];

		if (Z == 0)
			return this.L02932C_Wait();

		P |= 0x20;
		A = 0xCC;

		return this.L029367_LoadAPU();
	}

	public void L029337()
	{
		[0x55]++;
		Y = 0x0000;
		A = (A >> 8) | (A << 8);

		return this.L02934E_Wait();
	}

	public void L02933F_Loop()
	{
		A = [[0x53] + Y];
		Y++;
		A = (A >> 8) | (A << 8);
		A = 0x00;

		return this.L029354_Skip();
	}

	public void L029347_Loop()
	{
		A = (A >> 8) | (A << 8);
		A = [[0x53] + Y];
		Y++;

		if (N == 1)
			return this.L029337();

		A = (A >> 8) | (A << 8);
	}

	public void L02934E_Wait()
	{
		C = 1; temp = A - [0x2140];

		if (Z == 0)
			return this.L02934E_Wait();

		A++;
	}

	public void L029354_Skip()
	{
		P &= ~0x20;
		[0x2140] = A;
		P |= 0x20;
		X--;

		if (Z == 0)
			return this.L029347_Loop();
	}

	public void L02935E()
	{
		C = 1; temp = A - [0x2140];

		if (Z == 0)
			return this.L02935E();
	}

	public void L029363()
	{
		A += 0x03 + C;

		if (Z == 1)
			return this.L029363();
	}

	public void L029367_LoadAPU()
	{
		Stack.Push(A);
		P &= ~0x20;
		A = [[0x53] + Y];
		Y++;
		Y++;
		X = A;
		A = [[0x53] + Y];
		Y++;
		Y++;
		[0x2142] = A;
		P |= 0x20;
		C = 1; temp = X - 0x0001;
		A = 0x00;
		Cpu.ROL();
		[0x2141] = A;
		A += 0x7F + C;
		A = Stack.Pop();
		[0x2140] = A;
	}

	public void L029387_Wait()
	{
		C = 1; temp = A - [0x2140];

		if (Z == 0)
			return this.L029387_Wait();

		if (V == 1)
			return this.L02933F_Loop();

		[0x2140] = 0;
		[0x2141] = 0;
		[0x2142] = 0;
		[0x2143] = 0;
		P &= ~0x30;
		P = Stack.Pop();
		A = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L0293A1_Start()
	{
		// Disable Interrupts
		I = 1;

		// Disable Emulation (again)
		C = 0;
		temp = C; C = E; E = temp;

		// Direct Register = 0;
		P &= ~0x30;
		A = 0x0000;
		D = A;

		// Stack = 0x02FF;
		X = 0x02FF;
		S = X;

		// Data Bank = 0;
		P |= 0x30;
		Stack.Push(A);
		B = Stack.Pop();

		// SuperFX Speed = High
		P |= 0x30;
		A = 0x20;
		[0x3037] = A;

		// SuperFX Clock = 21.4MHz
		A = 0x01;
		[0x3039] = A;

		this.L0293FA_InitializeRegisters();
		this.L02950C_InitializeRam();

		// Stack = 0x02FF;
		P &= ~0x10;
		X = 0x02FF;
		S = X;

		P |= 0x30;
		P &= ~0x30;
		this.L029241_InitializeSound();
		A = 0x0002;
	}

	public void L0293D6_Wait()
	{
		C = 1; temp = A - [0x002140];

		if (Z == 0)
			return this.L0293D6_Wait();

		this.L029167_ResetSound();
		P |= 0x30;
		this.L029599_SetSuperFXScreenBase();
		return this.L029EDB_InitializeRegisters();
	}

	public void L0293E9()
	{
		Stack.Push(P);
		P &= ~0x30;
		Y = 0x0005;
	}

	public void L0293EF()
	{
		X = 0x0000;
	}

	public void L0293F2()
	{
		X--;

		if (Z == 0)
			return this.L0293F2();

		Y--;

		if (Z == 0)
			return this.L0293EF();

		P = Stack.Pop();
		return;
	}

	public void L0293FA_InitializeRegisters()
	{
		I = 1;
		A = 0x01;
		[0x00FB] = A;
		this.L02B1E5();
		P |= 0x30;
		A = 0x00;
		[0x00FB] = A;
		this.L02B1E5();
		P |= 0x30;
		A = 0x80;
		[0x2100] = A;
		A = 0x00;
		[0x2101] = A;
		[0x2102] = A;
		[0x2103] = A;
		[0x2105] = A;
		[0x2106] = A;
		[0x2107] = A;
		[0x2108] = A;
		[0x2109] = A;
		[0x210A] = A;
		[0x210B] = A;
		[0x210C] = A;
		[0x210D] = A;
		[0x210D] = A;
		[0x210E] = A;
		[0x210E] = A;
		[0x210F] = A;
		[0x210F] = A;
		[0x2110] = A;
		[0x2110] = A;
		[0x2111] = A;
		[0x2112] = A;
		[0x2112] = A;
		[0x2113] = A;
		[0x2113] = A;
		[0x2114] = A;
		[0x2114] = A;
		X = 0x80;
		[0x2115] = X;
		[0x2116] = A;
		[0x2117] = A;
		[0x211A] = A;
		X = 0x01;
		[0x211B] = A;
		[0x211B] = X;
		[0x211C] = A;
		[0x211C] = A;
		[0x211D] = A;
		[0x211D] = A;
		[0x211E] = A;
		[0x211E] = X;
		[0x211F] = A;
		[0x211F] = A;
		[0x2120] = A;
		[0x2120] = A;
		[0x2121] = A;
		[0x2122] = A;
		[0x2123] = A;
		[0x2124] = A;
		[0x2125] = A;
		[0x2126] = A;
		[0x2127] = A;
		[0x2128] = A;
		[0x2129] = A;
		[0x212A] = A;
		[0x212B] = A;
		[0x212C] = A;
		[0x212D] = A;
		[0x212E] = A;
		Y = 0x30;
		[0x2130] = Y;
		[0x2131] = A;
		X = 0xE0;
		[0x2132] = X;
		[0x2133] = A;
		[0x4200] = A;
		X = 0xFF;
		[0x4201] = X;
		[0x4202] = A;
		[0x4203] = A;
		[0x4204] = A;
		[0x4205] = A;
		[0x4206] = A;
		[0x4207] = A;
		[0x4208] = A;
		[0x4209] = A;
		[0x420A] = A;
		[0x420B] = A;
		[0x420C] = A;
		[0x420D] = A;
		return;
	}

	public void L02950C_InitializeRam()
	{
		Stack.Push(P);
		P |= 0x20;
		A = 0x7E;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x30;
		X = 0x2000;
		return this.L02951D_Skip();
	}

	public void L02951A_Loop()
	{
		[0x0000 + X] = 0;
	}

	public void L02951D_Skip()
	{
		[0x0002 + X] = 0;
		[0x0004 + X] = 0;
		[0x0006 + X] = 0;
		A = X;
		C = 0;
		A += 0x0008 + C;
		X = A;

		if (Z == 0)
			return this.L02951A_Loop();

		P |= 0x20;
		A = 0x7F;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
	}

	public void L029536_Loop()
	{
		[0x0000 + X] = 0;
		[0x0002 + X] = 0;
		[0x0004 + X] = 0;
		[0x0006 + X] = 0;
		A = X;
		C = 0;
		A += 0x0008 + C;
		X = A;

		if (Z == 0)
			return this.L029536_Loop();

		P |= 0x20;
		A = 0x70;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x30;
		X = 0x7FF8;
	}

	public void L029555_Loop()
	{
		[0x0000 + X] = 0;
		[0x0002 + X] = 0;
		[0x0004 + X] = 0;
		[0x0006 + X] = 0;
		A = X;
		C = 1;
		A -= 0x0008 - !C;
		X = A;

		if (N == 0)
			return this.L029555_Loop();

		P |= 0x20;
		A = 0x00;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
		X = 0x1CF8;
	}

	public void L029574_Loop()
	{
		[0x0300 + X] = 0;
		[0x0302 + X] = 0;
		[0x0304 + X] = 0;
		[0x0306 + X] = 0;
		A = X;
		C = 1;
		A -= 0x0008 - !C;
		X = A;

		if (N == 0)
			return this.L029574_Loop();

		X = 0x00FE;
	}

	public void L02958B_Loop()
	{
		[0x00 + X] = 0;
		X--;
		X--;

		if (N == 0)
			return this.L02958B_Loop();

		this.L01F87E_CopyRomToRam();
		P |= 0x20;
		P = Stack.Pop();
		return;
	}

	public void L029599_SetSuperFXScreenBase()
	{
		this.L02C494();
		P |= 0x20;
		P &= ~0x10;

		// SuperFX.ScreenBase = Value45 / 4;
		A = [0x45];
		A >>= 1;
		A >>= 1;
		[0x3038] = A;
		[0x38] = 0;
		[0x39] = 0;
		P |= 0x04;
		X = 0x00CF;
		[0x4209] = X;
		X = 0x008C;
		[0x4207] = X;
		P &= ~0x20;
		return;
	}

	public void L0295BD_InitializeRegisters()
	{
		this.L0293E9();
		this.L09FB88();
		P |= 0x20;
		P &= ~0x10;
		[0x10CD] = 0;
		A = 0x00;
		[0x10CB] = A;
		[0xF4] = 0;
		[0x110A] = 0;
		A = 0x00;
		[0x10D2] = A;
		[0x10EF] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x70022C] = A;
		[0x700230] = A;
		A = 0x07D0;
		[0x120A] = A;
		A = 0x0001;
		[0x10B2] = A;
		A = 0x0001;
		[0x10B4] = A;
		[0x10E5] = A;
		[0x10B6] = 0;
		[0x10AC] = 0;
		this.L078486();
		this.L0CF55D();
	}

	public void L02960E_MainLoop()
	{
		this.L07852B_UpdateSound();
		P &= ~0x20;
		[0x120C] = 0;
		P |= 0x20;
		P &= ~0x10;
		[0x1210] = 0;
		A = 0x03;
		[0x120E] = A;
		A = 0x01;
		[0x120F] = A;
		A = 0x00;
		[0x1211] = A;
		this.L02A04E();
		return this.L02BEBF();
	}

	public void L029634()
	{
		this.L029649();
		this.L02CD1E();
		this.L038168();
		this.L0387D7();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L029649()
	{
		P |= 0x20;
		[0x18C1] = 0;
		[0x10ED] = 0;
		[0x1273] = 0;
		[0x11D4] = 0;
		[0x11D5] = 0;
		[0x1DB9] = 0;
		[0x118C] = 0;
		[0x11C9] = 0;
		[0x11C6] = 0;
		[0x118D] = 0;
		[0x1209] = 0;
		[0x1232] = 0;
		[0x1277] = 0;
		[0x1285] = 0;
		[0x1284] = 0;
		[0x1274] = 0;
		[0x1275] = 0;
		[0x1276] = 0;
		A = 0x0A;
		[0x192E] = A;
		[0x1AD1] = 0;
		[0x1AD4] = 0;
		[0x1AD5] = 0;
		[0x11D9] = 0;
		[0x122B] = 0;
		[0x122E] = 0;
		[0x122F] = 0;
		[0x11DA] = 0;
		[0x122A] = 0;
		[0x11AE] = 0;
		[0x11BF] = 0;
		A = 0x03;
		[0x128C] = A;
		[0x1219] = 0;
		[0x113B] = 0;
		A = 0x0F;
		[0x0011D8] = A;
		A = 0xFF;
		[0x7E328F] = A;
		[0x1109] = A;
		[0x110B] = 0;
		A = 0x00;
		[0x11AF] = A;
		[0x7EC644] = A;
		[0x7EC651] = A;
		[0x7E328E] = A;
		[0x00197E] = A;
		P &= ~0x30;
		[0x18BC] = 0;
		[0x18C3] = 0;
		A = 0x0003;
		[0x128D] = A;
		[0x1245] = 0;
		[0x1247] = 0;
		[0x1249] = 0;
		A = 0x0000;
		[0x7E32A8] = A;
		A = 0x0002;
		[0x10D0] = A;
		[0x10D3] = 0;
		A = [0x10D2];
		A &= 0x00FF;

		if (Z == 1)
			return this.L029713();

		A = [0x7E2DD8];
		C = 1;
		A -= 0x0004 - !C;
		[0x10D3] = A;
	}

	public void L029713()
	{
		[0x1982] = 0;
		[0x10CE] = 0;
		[0x11C0] = 0;
		[0x11C2] = 0;
		[0x11C4] = 0;
		[0x1235] = 0;
		[0x1237] = 0;
		[0x1239] = 0;
		A = 0xFFFF;
		[0x0010A8] = A;
		A = 0x0005;
		[0x10AA] = A;
		A = 0x0000;
		[0x10AE] = A;
		[0x110E] = 0;
		[0xC5] = 0;
		[0xC7] = 0;
		A = 0xF830;
		[0xC9] = A;
		[0x10F4] = 0;
		[0x10F6] = 0;
		[0x10F8] = 0;
		[0x11CE] = 0;
		[0x11D0] = 0;
		A = 0xF830;
		[0x11D2] = 0;
		A = 0xC000;
		[0x00121C] = A;
		[0x00121E] = A;
		A = 0x4000;
		[0x001220] = A;
		[0x001222] = A;
		A = 0xC000;
		[0x116F] = A;
		[0x1177] = A;
		A = 0x4000;
		[0x1171] = A;
		[0x1179] = A;
		A = 0x000C;
		[0x001224] = A;
		[0x1226] = 0;
		[0x1228] = 0;
		A = 0x2555;
		[0x118A] = A;
		P |= 0x20;
		A = 0x03;
		[0x121A] = A;
		[0x121B] = 0;
		[0x1215] = 0;
		[0x1216] = 0;
		[0x1214] = 0;
		[0x1217] = 0;
		[0x1218] = 0;
		[0x1DDC] = 0;
		[0x1DED] = 0;
		[0x1DFA] = 0;
		[0x1DD0] = 0;
		A = 0x02;
		[0x1DDE] = A;
		A = 0x02;
		[0x1DEF] = A;
		A = 0x16;
		[0x1DDF] = A;
		A = 0x1A;
		[0x1DE0] = A;
		A = 0x18;
		[0x1DF1] = A;
		A = 0x2E;
		[0x1DF0] = A;
		[0x1DE4] = 0;
		[0x1DE5] = 0;
		[0x1DE6] = 0;
		[0x1DF5] = 0;
		[0x1DF6] = 0;
		[0x1DF7] = 0;
		[0x1DFB] = 0;
		P &= ~0x20;
		[0x122C] = 0;
		[0x1233] = 0;
		[0x1AC1] = 0;
		[0x1ABF] = 0;
		[0x127B] = 0;
		[0x11C7] = 0;
		[0x1286] = 0;
		A = 0x002E;
		[0x1DEB] = A;
		A = 0x0000;
		[0x700248] = A;
		[0x700244] = A;
		A = 0x0016;
		[0x1DDA] = A;
		A = 0x0000;
		[0x70024A] = A;
		[0x700246] = A;
		[0x700240] = A;
		this.L039E48();
		P |= 0x20;
		[0x1DBA] = 0;
		A = [0x1DBA];
		[0x700234] = A;
		P &= ~0x20;
		A = 0x00E0;
		[0x1B70] = A;
		A = 0xFFFF;
		[0x1B78] = A;
		return;
	}

	public void L02984E()
	{
		this.L02C494();
		P &= ~0x30;
		A = 0x0000;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P |= 0x20;
		A = [0xF3];
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = [0x1AC1];
		A &= 0x00FF;

		if (Z == 1)
			return this.L0298B4();

		A = [0x1230];
		A = [0x10EF];
		A &= 0x00FF;
		temp = A & 0x0010;

		if (Z == 1)
			return this.L0298A8();

		A = 0x0008;
		[0x1230] = A;
	}

	public void L0298A8()
	{
		A = [0x1230];
		A <<= 1;
		X = A;
		A = [0x02F5C0 + X];
		[0x1228] = A;
	}

	public void L0298B4()
	{
		P |= 0x20;
		this.L03A17D_ResetSound();
		this.L038186();
		P &= ~0x20;
		[0x11DB] = 0;
		this.L0387A6();
		P |= 0x20;
		A = 0xFF;
		[0x1DBA] = A;
		[0x1DB9] = 0;
		this.L039DFF();
		this.L00E8D5();
		this.L00E8F0();
		this.L00EA5B();
		this.L00EA70();
		this.L04BA41();
		this.L00E996();
		this.L00EAD5();
		return;
	}

	public void L0298F2()
	{
		this.L029634();
		this.L02984E();
	}

	public void L0298FA()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.L02990C();

		this.L02C42B();
		P |= 0x20;
		P &= ~0x10;
		[0x10ED] = 0;
	}

	public void L02990C()
	{
		P |= 0x20;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = [0x112D];
		temp = A & 0x08;

		if (Z == 0)
			return this.L02991E();

		return this.L0298FA();
	}

	public void L02991E()
	{
		P |= 0x20;
		A = 0x00;
		[0x70025E] = A;
		[0x70025F] = A;
		A = [0x112D];
		[0x1125] = A;
		[0x112D] = 0;
		[0x1219] = 0;
		[0x11B5] = 0;
		A = [0x1232];

		if (Z == 1)
			return this.L029941();

		return this.L0299C3();
	}

	public void L029941()
	{
		A = [0x1125];
		temp = A & 0x02;

		if (Z == 0)
			return this.L02995D();

		A = [0x1217];

		if (Z == 1)
			return this.L029950();

		return this.L0299C3();
	}

	public void L029950()
	{
		A = [0x1215];

		if (Z == 0)
			return this.L0299C3();

		A = [0x10D2];

		if (Z == 1)
			return this.L02995D();

		return this.L029AEB();
	}

	public void L02995D()
	{
		P |= 0x20;
		A = [0x10EF];
		temp = A & 0x02;

		if (Z == 0)
			return this.L029972();

		A = [0x120E];
		A--;
		[0x120E] = A;

		if (Z == 0)
			return this.L029972();

		return this.L029A8A();
	}

	public void L029972()
	{
		A = [0x1284];

		if (Z == 1)
			return this.L029998();

		A = 0x01;
		this.L029310_SendApuCommand();
		P |= 0x20;
		this.L02CC8F();
		P &= ~0x30;
		A = [0xF3];
		A &= 0x00FF;
		X = A;
		A = [0x048062 + X];
		A &= 0x00FF;
		this.L029283_LoadSong();
		return this.L0299A7();
	}

	public void L029998()
	{
		P &= ~0x20;
		A = 0x0201;
		this.L029213_SendApuCommand();
		P |= 0x20;
		this.L02CC8F();
	}

	public void L0299A7()
	{
		P &= ~0x20;
		this.L02C494();
		this.L029634();
		this.L02984E();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
		P |= 0x20;
		P &= ~0x10;
		return this.L0298FA();
	}

	public void L0299C3()
	{
		A = [0x1AD0];

		if (Z == 1)
			return this.L0299E7();

		this.L029AF1();
		this.L038168();
		this.L02C494();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = 0x0004;
		this.L029283_LoadSong();
		A = 0xFFFF;
		return;
	}

	public void L0299E7()
	{
		P |= 0x20;
		A = [0x1232];

		if (Z == 0)
			return this.L029A66();

		A = [0x122E];

		if (Z == 1)
			return this.L029A66();

		P &= ~0x20;
		A = [0x1233];

		if (Z == 1)
			return this.L029A66();

		A = 0x0001;
		this.L029310_SendApuCommand();
		P &= ~0x20;
		A = [0x1233];
		Stack.Push(A);
		this.L02CC8F();
		this.L029634();
		this.L02C494();
		P &= ~0x30;
		A = Stack.Pop();
		[0x1228] = A;
		X = 0x0000;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		this.L0298B4();
		P &= ~0x20;
		A = 0x0010;
		this.L029283_LoadSong();
		P &= ~0x20;
		A = 0x0028;
		[0x00197C] = A;
		P |= 0x20;
		A = 0x3C;
		[0x1981] = A;
		A = 0x00;
		[0x00197E] = A;
		A = 0xFF;
		[0x1232] = A;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
		return this.L0298FA();
	}

	public void L029A66()
	{
		this.L029C2D();

		if (Z == 0)
			return this.L029A6E();

		return this.L029AC7();
	}

	public void L029A6E()
	{
		this.L038168();
		this.L02C494();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = 0x0005;
		this.L029283_LoadSong();
		A = 0xFFFF;
		return;
	}

	public void L029A8A()
	{
		this.L029D2E();

		if (Z == 1)
			return this.L029AC7();

		P |= 0x20;
		A = [0x120F];
		A--;

		if (Z == 1)
			return this.L029AC7();

		[0x120F] = A;
		A = 0x03;
		[0x120E] = A;
		P &= ~0x20;
		[0x120C] = 0;
		A = 0x0001;
		this.L029310_SendApuCommand();
		P |= 0x20;
		this.L02CC8F();
		P &= ~0x30;
		A = [0xF3];
		A &= 0x00FF;
		X = A;
		A = [0x048062 + X];
		A &= 0x00FF;
		this.L029283_LoadSong();
		return this.L0299A7();
	}

	public void L029AC7()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		P &= ~0x20;
		A = 0x0004;
		this.L029283_LoadSong();
	}

	public void L029ADD()
	{
		this.L02C494();
		this.L038168();
		P &= ~0x20;
		A = 0x0000;
		return;
	}

	public void L029AEB()
	{
		this.L02CC8F();
		return this.L029ADD();
	}

	public void L029AF1()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		this.L02BD43();
		P &= ~0x20;
		A = [0xF3];
		A &= 0x00FF;
		C = 1; temp = A - 0x000A;

		if (Z == 0)
			return this.L029B18();

		A = [0x1235];
		C = 1; temp = A - 0x001E;

		if (C == 1)
			return this.L029B3D();

		return this.L029B2F();
	}

	public void L029B18()
	{
		C = 1; temp = A - 0x000B;

		if (Z == 0)
			return this.L029B20();

		return this.L029B3D();
	}

	public void L029B20()
	{
		C = 1; temp = A - 0x000C;

		if (Z == 0)
			return this.L029B2F();

		A = [0x1237];
		C = 1; temp = A - 0x0005;

		if (C == 1)
			return this.L029B3D();

		return this.L029B2F();
	}

	public void L029B2F()
	{
		A = 0x0000;
		[0x3A] = A;
		A = 0x000B;
		this.L029283_LoadSong();
		return this.L029B4B();
	}

	public void L029B3D()
	{
		P &= ~0x20;
		A = 0xFFFF;
		[0x3A] = A;
		A = 0x000C;
		this.L029283_LoadSong();
	}

	public void L029B4B()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L029BBA();
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		X = 0x0011;
		[0x197C] = X;
	}

	public void L029B65()
	{
		Stack.Push(X);
		P |= 0x20;
		this.L029BD6();
		P &= ~0x30;
		A = 0x0036;
		[0x700064] = A;
		A = 0x0038;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		A = 0x0D79;
		[0x7000BA] = A;
		A = [0x3A];

		if (Z == 0)
			return this.L029B9B();

		A = 0x0DB3;
		[0x7000BA] = A;
	}

	public void L029B9B()
	{
		this.L03EA3E();
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.L029BAE();

		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 1)
			return this.L029B65();

	}

	public void L029BAE()
	{
		P |= 0x20;
		this.L02CC8F();
		[0x1ACF] = 0;
		A = [0x3A];
		return;
	}

	public void L029BBA()
	{
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L029BC1()
	{
		this.L029BD6();
		P |= 0x20;
		A = 0x02;
		[0x38] = A;
	}

	public void L029BCA()
	{
		A = [0x38];

		if (Z == 0)
			return this.L029BCA();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L029BC1();

		return;
	}

	public void L029BD6()
	{
		P |= 0x20;
		A = 0x02;
		[0x38] = A;
		[0x1982]++;

		if (Z == 0)
			return this.L029BE4();

		[0x1983]++;
	}

	public void L029BE4()
	{
		P |= 0x20;
	}

	public void L029BE6()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.L029BE6();

	}

	public void L029BEB()
	{
		A = [0x1ADF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L029BEB();

		[0x1ADF] = 0;
	}

	public void L029BF5()
	{
		A = [0x38];

		if (Z == 0)
			return this.L029BF5();

		this.L02C418();
		P &= ~0x20;
		A = 0xFFD8;
		[0x700240] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xCA04;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = 0x0000;
		[0x700240] = A;
		P |= 0x20;
		return;
	}

	public void L029C1F()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBA8F;
		this.L7ED7E8_ExecuteSuperFX();
		return;
	}

	public void L029C2D()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = [0xF4];
		C = 1; temp = A - 0x0006;

		if (Z == 0)
			return this.L029C49();

		this.L04B592();
		this.L029C49();
		P |= 0x20;
		A = 0x00;
		return;
	}

	public void L029C49()
	{
		P |= 0x20;
		this.L02CC8F();
		this.L02BD43();
		P &= ~0x20;
		A = 0x000C;
		this.L029283_LoadSong();
		this.L029BBA();
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		[0x197A] = 0;
		A = 0x0001;
		[0x198C] = A;
		X = 0x0011;
		[0x197C] = X;
	}

	public void L029C79()
	{
		Stack.Push(X);
		P |= 0x20;
		this.L029BD6();
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0038;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		A = [0xF4];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BF802 + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 0)
			return this.L029CBB();

		return this.L029D0E();
	}

	public void L029CBB()
	{
		A = [0x197A];
		C = 0;
		A += 0x0064 + C;
		C = 1; temp = A - [0x120C];

		if (N == 1)
			return this.L029CCA();

		A = [0x120C];
	}

	public void L029CCA()
	{
		[0x197A] = A;
		[0x70002E] = A;
		A = 0x0070;
		[0x700064] = A;
		A = 0x0069;
		[0x70002C] = A;
		A = 0x000E;
		[0x700208] = A;
		this.L09FA8C();
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0080;
		[0x70002C] = A;
		A = [0xF4];
		A++;
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BF810 + X];
		[0x7000BA] = A;
		this.L03EA3E();
	}

	public void L029D0E()
	{
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.L029D20();

		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.L029D20();

		return this.L029C79();
	}

	public void L029D20()
	{
		P |= 0x20;
		this.L02CC8F();
		P |= 0x20;
		[0x1ACF] = 0;
		A = 0xFF;
		return;
	}

	public void L029D2E()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		this.L02BD43();
		P &= ~0x20;
		A = 0x000B;
		this.L029283_LoadSong();
		this.L029BBA();
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		[0x197A] = 0;
		A = 0x0001;
		[0x198C] = A;
		X = 0x0011;
		[0x197C] = X;
	}

	public void L029D65()
	{
		Stack.Push(X);
		P |= 0x20;
		this.L029BD6();
		P &= ~0x30;
		A = 0x004C;
		[0x700064] = A;
		A = 0x0038;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		A = 0x0D1A;
		[0x7000BA] = A;
		A = [0x1AD0];
		A &= 0x00FF;

		if (Z == 1)
			return this.L029D9F();

		A = 0x0878;
		[0x7000BA] = A;
	}

	public void L029D9F()
	{
		this.L03EA3E();
		P |= 0x20;
		A = [0x1AD0];

		if (Z == 1)
			return this.L029DAD();

		return this.L029E0A();
	}

	public void L029DAD()
	{
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 0)
			return this.L029DB8();

		return this.L029E0A();
	}

	public void L029DB8()
	{
		A = [0x197A];
		C = 0;
		A += 0x0064 + C;
		C = 1; temp = A - [0x120C];

		if (N == 1)
			return this.L029DC7();

		A = [0x120C];
	}

	public void L029DC7()
	{
		[0x197A] = A;
		[0x70002E] = A;
		A = 0x0070;
		[0x700064] = A;
		A = 0x0069;
		[0x70002C] = A;
		A = 0x000E;
		[0x700208] = A;
		this.L09FA8C();
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0080;
		[0x70002C] = A;
		A = [0xF4];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BF810 + X];
		[0x7000BA] = A;
		this.L03EA3E();
	}

	public void L029E0A()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.L029E25();

		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.L029E39();

		A = [0x10BC];
		A &= 0xFF;

		if (Z == 0)
			return this.L029E25();

		return this.L029D65();
	}

	public void L029E25()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		[0x1ACF] = 0;
		A = 0x0000;
		return;
	}

	public void L029E39()
	{
		P |= 0x20;
		this.L02CC8F();
		[0x1ACF] = 0;
		A = 0xFF;
		return;
	}

	public void L029E45()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void L029E49()
	{
		A = [0x38];

		if (Z == 0)
			return this.L029E49();

		this.L078010();
		P |= 0x20;
		P &= ~0x10;
	}

	public void L029E55()
	{
		this.L078072_Skip();
		P |= 0x20;
		P &= ~0x10;
		[0x1982]++;
		A = 0x02;
		[0x38] = A;
	}

	public void L029E64()
	{
		A = [0x38];

		if (Z == 0)
			return this.L029E64();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 1)
			return this.L029E55();

	}

	public void L029E6F()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void L029E73()
	{
		A = [0x38];

		if (Z == 0)
			return this.L029E73();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L029E6F();

		[0x38] = 0;
	}

	public void L029E80()
	{
		A = [0x1ADF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L029E80();

		[0x1ADF] = 0;
		return;
	}

	public void L029EDB_InitializeRegisters()
	{
		P |= 0x30;
		A = 0x21;
		[0x1923] = A;
		this.L02A2C4();
		P &= ~0x10;
		X = 0x0000;
		[0x4A] = X;
		X = 0x3000;
		[0x4C] = X;
		X = 0x2C00;
		[0x44] = X;
		X = 0x2C00;
		[0x46] = X;
		A = [0x4B];
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A |= 0x50;
		[0x210B] = A;
		A = 0x03;
		[0x2101] = A;
		A = 0x2C;
		[0x2107] = A;
		A = 0x7A;
		[0x2108] = A;
		A = 0x02;
		[0x2105] = A;
		this.L02CD22();
		P |= 0x20;
		P &= ~0x10;
		this.L02CD9F();
		P &= ~0x20;
		A = 0x00F0;
		P |= 0x20;
		[0x2110] = A;
		A = (A >> 8) | (A << 8);
		[0x2110] = A;
		A = [0x2110];
		[0x1B72] = A;
		A = [0x2110];
		[0x1B73] = A;
		[0x1B74] = 0;
		A = [0x210F];
		[0x1B75] = A;
		A = [0x210F];
		[0x1B76] = A;
		[0x1B77] = 0;
		[0x1DBA] = 0;
		[0x18C3] = 0;
		[0x18C4] = 0;
		this.L038168();
		this.L038000();
		this.L0387A6();
		P |= 0x20;
		P &= ~0x10;
		[0x2123] = 0;
		[0x2124] = 0;
		A = 0x20;
		[0x2125] = A;
		[0x212A] = 0;
		A = 0x0C;
		[0x212B] = A;
		[0x212E] = 0;
		[0x212F] = 0;
		[0x2126] = 0;
		[0x2127] = 0;
		A = 0x02;
		[0x2130] = A;
		A = 0x17;
		[0x212C] = A;
		A = 0x07;
		[0x212D] = A;
		A = 0x57;
		[0x2131] = A;
		A = 0x00;
		[0x2132] = A;
		P &= ~0x20;
		X = 0x0000;
	}

	public void L029FA7_Loop()
	{
		A = [0x02A37E + X];
		[0x7EDE0E + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x0D9C;

		if (C == 0)
			return this.L029FA7_Loop();

		P |= 0x20;
		A = 0x00;
		[0x4310] = A;
		A = 0x00;
		[0x4311] = A;
		X = 0xDE0E;
		[0x4312] = X;
		A = 0x7E;
		[0x4314] = A;
		[0x4317] = 0;
		A = 0x00;
		[0x4320] = A;
		A = 0x21;
		[0x4321] = A;
		X = 0xDE17;
		[0x4322] = X;
		A = 0x7E;
		[0x4324] = A;
		[0x4327] = 0;
		A = 0x02;
		[0x4330] = A;
		A = 0x22;
		[0x4331] = A;
		X = 0xDF98;
		[0x4332] = X;
		A = 0x7E;
		[0x4334] = A;
		[0x4337] = 0;
		A = 0x00;
		[0x4340] = A;
		A = 0x26;
		[0x4341] = A;
		X = 0xE7C0;
		[0x4342] = X;
		A = 0x7E;
		[0x4344] = A;
		[0x4347] = 0;
		A = 0x00;
		[0x4350] = A;
		A = 0x27;
		[0x4351] = A;
		X = 0xE9B5;
		[0x4352] = X;
		A = 0x7E;
		[0x4354] = A;
		[0x4357] = 0;
		A = 0x06;
		[0x10C4] = A;
		X = 0xE1E2;
		[0x1AD8] = X;
		X = 0xE4D1;
		[0x1ADA] = X;
		A = 0x31;
		[0x4200] = A;
		A = [0x004211];
		I = 0;
		return this.L0295BD_InitializeRegisters();
	}

	public void L02A04E()
	{
		P &= ~0x20;
		[0x10B9] = 0;
		A = 0x0000;
		[0x70022A] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		A = 0x0068;
		[0x700226] = A;
		P |= 0x20;
		this.L029634();
		A = 0xFF;
		[0x1AD1] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x0009;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		A = 0xFFF0;
		[0x1B75] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1B77] = A;
		P |= 0x20;
		this.L03A17D_ResetSound();
		return this.L02A0F6_Done();
	}

	public void L02A0F6_Done()
	{
		P |= 0x20;
		return;
	}

	public void L02A0F9()
	{
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x005C;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = 0x00C8;
		[0x7000BA] = A;
		this.L03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0068;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = 0x00DC;
		[0x7000BA] = A;
		this.L03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0078;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0004;

		if (C == 0)
			return this.L02A164();

		A = 0x0145;
		return this.L02A16A();
	}

	public void L02A164()
	{
		A <<= 1;
		X = A;
		A = [0x0BF7E2 + X];
	}

	public void L02A16A()
	{
		[0x7000BA] = A;
		this.L03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0090;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0004;

		if (C == 0)
			return this.L02A196();

		return this.L02A1A8_Done();
	}

	public void L02A196()
	{
		A <<= 1;
		C = 0;
		A += [0x10B9] + C;
		X = A;
		A = [0x0BF7EA + X];
		[0x7000BA] = A;
		this.L03EA39();
	}

	public void L02A1A8_Done()
	{
		return;
	}

	public void L02A258()
	{
		P |= 0x20;
		A = 0x80;
		[0x2115] = A;
		P &= ~0x30;
		A = 0x2C40;
		[0x2116] = A;
		A = 0x1C00;
		Y = 0x0000;
	}

	public void L02A26D()
	{
		Stack.Push(A);
		A = 0x3AA0;
		[0x2118] = A;
		[0x2118] = A;
		A = Stack.Pop();
		X = 0x0000;
	}

	public void L02A27B()
	{
		[0x2118] = A;
		C = 0;
		A += 0x0018 + C;
		X++;
		C = 1; temp = X - 0x001C;

		if (Z == 0)
			return this.L02A27B();

		Stack.Push(A);
		A = 0x3AA0;
		[0x2118] = A;
		[0x2118] = A;
		A = Stack.Pop();
		C = 1;
		A -= 0x029F - !C;
		Y++;
		C = 1; temp = Y - 0x0018;

		if (Z == 0)
			return this.L02A26D();

		X = 0x2A00;
		[0x2116] = X;
		X = 0xFFFF;
		Y = 0x0010;
	}

	public void L02A2A9()
	{
		[0x2118] = X;
		Y--;

		if (Z == 0)
			return this.L02A2A9();

		X = 0x5A00;
		[0x2116] = X;
		X = 0xFFFF;
		Y = 0x0010;
	}

	public void L02A2BB()
	{
		[0x2118] = X;
		Y--;

		if (Z == 0)
			return this.L02A2BB();

		P |= 0x20;
		return;
	}

	public void L02A2C4()
	{
		[0x2121] = 0;
		[0x2116] = 0;
		[0x2117] = 0;
		A = 0x80;
		[0x2100] = A;
		[0x2115] = A;
		[0x420B] = 0;
		[0x420C] = 0;
		[0x1ACB] = 0;
		[0x1ACC] = 0;
		[0x1ACD] = 0;
		[0x1ACE] = 0;
		A = 0x00;
		X = 0x7F;
	}

	public void L02A2EB()
	{
		Y = 0x00;
	}

	public void L02A2ED()
	{
		[0x2118] = A;
		[0x2119] = A;
		Y--;

		if (Z == 0)
			return this.L02A2ED();

		X--;

		if (Z == 0)
			return this.L02A2EB();

		this.L02A36B();
		A = 0x80;
		[0xA0] = A;
		A = 0xFF;
		[0x1994] = A;
		P &= ~0x30;
		A = 0x0000;
		[0x70021E] = A;
		A = 0x2C00;
		[0x2116] = A;
		A = 0x02A1;
		X = 0x0400;
	}

	public void L02A31B()
	{
		[0x2118] = A;
		X--;

		if (Z == 0)
			return this.L02A31B();

		P |= 0x20;
		P &= ~0x10;
		this.L02A258();
		return;
	}

	public void L02A32A()
	{
		A = 0x00;
		[0x24] = A;
		A = 0x00;
		[0x25] = A;
		A = 0xDF;
		[0x28] = A;
		A = 0x00;
		[0x29] = A;
		A = 0x00;
		[0x26] = A;
		A = 0x00;
		[0x27] = A;
		A = 0xBF;
		[0x2A] = A;
		A = 0x00;
		[0x2B] = A;
		A = 0x70;
		[0xCE] = A;
		A = 0x00;
		[0xCF] = A;
		A = 0x60;
		[0xD0] = A;
		A = 0x00;
		[0xD1] = A;
		A = 0x55;
		[0x2E] = A;
		A = 0x55;
		[0x2F] = A;
		A = 0x24;
		[0x2C] = A;
		A = 0x49;
		[0x2D] = A;
		return;
	}

	public void L02A36B()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x1234;
		[0x7001B4] = A;
		P |= 0x30;
		this.L02A32A();
		return this.L01F074();
	}

	public void L02B1CB()
	{
		Stack.Push(P);
		P &= ~0x30;
		X = 0x0000;
	}

	public void L02B1D1()
	{
		A = [0x701000 + X];
		C = 0;
		A += 0x00C0 + C;
		[0x2118] = A;
		X++;
		X++;
		C = 1; temp = X - 0x0800;

		if (Z == 0)
			return this.L02B1D1();

		P = Stack.Pop();
		return;
	}

	public void L02B1E5()
	{
		Stack.Push(P);
		P &= ~0x30;
		Stack.Push(X);
		Stack.Push(A);
		P |= 0x20;
		[0xFC] = 0;
	}

	public void L02B1EE()
	{
		P |= 0x20;
		A = [0x2137];
		A = [0x213D];
		A = (A >> 8) | (A << 8);
		A = [0x213D];
		A = (A >> 8) | (A << 8);
		C = 1; temp = A - [0xFB];

		if (Z == 0)
			return this.L02B1EE();

		P &= ~0x30;
		A = Stack.Pop();
		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void L02B2F9()
	{
		A = 0xE0;
		[0x1B70] = A;
		[0x1B80] = 0;
		[0x1B78] = 0;
		[0x1B79] = 0;
		P &= ~0x20;
		A = 0x0000;
		[0x001ABB] = A;
		A = 0x0000;
		[0x001ABD] = A;
		[0x18C3] = 0;
		[0x18BC] = 0;
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L02B322_Dma()
	{
		A = 0x22;
		[0x4301] = A;
		A = 0x00;
		[0x2121] = A;
		X = [0x18C5];
		[0x4302] = X;
		A = [0x18C7];
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x22;
		[0x4301] = A;
		A = 0x80;
		[0x2121] = A;
		X = 0xEB2D;
		[0x4302] = X;
		A = 0x08;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		Y = 0x0000;
		X = [0x18C5];
		Stack.Push(B);
		A = [0x18C7];
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
	}

	public void L02B37B_Loop()
	{
		A = [0x0000 + X];
		Stack.Push(X);
		X = Y;
		[0x00129C + X] = A;
		X = Stack.Pop();
		X++;
		X++;
		Y++;
		Y++;
		C = 1; temp = Y - 0x0100;

		if (Z == 0)
			return this.L02B37B_Loop();

		A = 0x0000;
		[0x00137A] = A;
		P |= 0x20;
		B = Stack.Pop();
		P &= ~0x20;
		X = 0x0000;
	}

	public void L02B39D_Loop()
	{
		A = [0x08EB2D + X];
		[0x00139C + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x0100;

		if (Z == 0)
			return this.L02B39D_Loop();

		A = 0x0004;
		[0x18C9] = A;
		A = 0x0080;
		[0x18CB] = A;
		A = 0x1000;
		[0x18CD] = A;
		A = 0xFFFC;
		[0x18CF] = A;
		A = 0xFF80;
		[0x18D1] = A;
		A = 0xF000;
		[0x18D3] = A;
		P |= 0x20;
		return;
	}

	public void L02B484()
	{
		A = 0x61;
		[0x70004E] = A;
		A = 0x89;
		[0x70004F] = A;
		P |= 0x20;
		A = 0x80;
		[0x2115] = A;
		P &= ~0x30;
		X = 0x7800;
		[0x2116] = X;
		P &= ~0x20;
		A = 0x94F1;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x08;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B1CB();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L02BD43()
	{
		this.L029C1F();
		P &= ~0x20;
		[0x10F8] = 0;
		this.L02CD1E();
		P &= ~0x20;
		[0x18C3] = 0;
		[0x18BC] = 0;
		P |= 0x20;
		[0x18C1] = 0;
		this.L038168();
		this.L02BE25();
		this.L02C418();
		this.L02BE3B();
		P &= ~0x20;
		[0x18C3] = 0;
		[0x18BC] = 0;
		P |= 0x20;
		[0x18C1] = 0;
		P |= 0x20;
		P &= ~0x10;
		X = 0xFCC8;
		[0x18C5] = X;
		A = 0x0C;
		[0x18C7] = A;
		this.L02B322_Dma();
		P &= ~0x20;
		A = 0xF4A4;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0F;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x5C00;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x1800;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		this.L02B484();
		P &= ~0x30;
		P &= ~0x20;
		A = 0xE799;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0B;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B2F9();
		P |= 0x20;
		[0x210F] = 0;
		[0x210F] = 0;
		this.L078001();
		A = [0x10C4];
		[0x420C] = A;
		return;
	}

	public void L02BE25()
	{
		P |= 0x30;
	}

	public void L02BE27()
	{
		A = [0x2137];
		X = [0x213D];
		A = [0x213D];
		A &= 0x01;

		if (Z == 0)
			return this.L02BE27();

		C = 1; temp = X - 0xCF;

		if (Z == 0)
			return this.L02BE27();

		P &= ~0x30;
		return;
	}

	public void L02BE3B()
	{
		A = 0x0002;
		[0x38] = A;
	}

	public void L02BE40_Wait()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02BE40_Wait();

		return;
	}

	public void L02BE46()
	{
		P &= ~0x20;
		A = 0xEB79;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0B;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		X = 0x0000;
	}

	public void L02BE6C()
	{
		A = [0x701000 + X];
		[0x7E2DD8 + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x04B0;

		if (Z == 0)
			return this.L02BE6C();

		this.L00E8D5();
		this.L00EA5B();
		P |= 0x20;
		this.L02CC8F();
		this.L038168();
		this.L038000();
		this.L0387A6();
		P |= 0x20;
		[0x1ACF] = 0;
		A = 0xFF;
		[0x10D2] = A;
		A = 0x05;
		[0xF3] = A;
		this.L0298F2();
		P &= ~0x20;
		A = 0x0000;
		[0x700226] = A;
		P |= 0x20;
		[0x10D2] = 0;
		[0x1ACF] = 0;
		[0x1AD2] = 0;
		[0x10B6] = 0;
		return;
	}

	public void L02BEBF()
	{
		P &= ~0x20;
		A = 0x0000;
		[0x70022A] = A;

		this.L00E8D5();
		this.L00EA5B();

		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		A = 0xFFF0;
		[0x700226] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x700222] = A;
		[0x70021E] = A;
		A = 0x0069;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		[0x1986] = 0;

		this.L02C23D();

		P |= 0x20;
		P &= ~0x20;
		A = 0x0000;
		[0x70021E] = A;

		this.L02C127();

		if (Z == 0)
			return this.L02BF18();

		this.L0784F5();

		return this.L02960E_MainLoop();
	}

	public void L02BF18()
	{
		P &= ~0x20;
		A = [0x1986];
		C = 1; temp = A - 0x0001;

		if (Z == 1)
			return this.L02BF29();

		this.L02BFF2();

		return this.L02960E_MainLoop();
	}

	public void L02BF29()
	{
		this.L02BF54();

		return this.L02960E_MainLoop();
	}

	public void L02BF54()
	{
		P &= ~0x20;
		[0x1ACF] = 0;
		[0x1AD1] = 0;
		A = [0xF4];
		A &= 0x00FF;
		[0x1986] = A;
		A = 0x0007;
		[0x198A] = A;
		A = 0x0001;
		[0x1AD6] = A;
		this.L0CF6F7();

		if (Z == 0)
			return this.L02BF8B();

		P &= ~0x20;
		[0x198C] = 0;
		P |= 0x20;
		A = [0x1986];
		[0xF4] = A;

		this.L02CC8F();
		this.L0784F5();

		return;
	}

	public void L02BF8B()
	{
		P |= 0x20;
		A = [0x1986];
		[0xF4] = A;
		P &= ~0x20;
		[0x198C] = 0;
		P |= 0x20;
		[0x1AD4] = 0;

		this.L02C08F();

		P |= 0x20;

		this.L02CC8F();

		P |= 0x20;
		[0x1ACF] = 0;
		P &= ~0x30;
		A = 0x0000;
		[0x700226] = A;
		A = [0x1986];
		X = A;
		P |= 0x20;
		A++;
		[0xF3] = A;
		P &= ~0x30;
		A = [0xF3];
		A &= 0x00FF;
		X = A;
		A = [0x048062 + X];
		A &= 0x00FF;
		Stack.Push(A);
		A = 0x0001;

		this.L029310_SendApuCommand();

		A = Stack.Pop();

		this.L029283_LoadSong();

		[0x1230] = 0;

		this.L0298F2();

		if (Z == 1)
			return this.L02BFEF_Done();

		P |= 0x20;
		A = [0xF4];
		A++;
		[0xF4] = A;
		C = 1; temp = A - 0x07;

		if (Z == 1)
			return this.L02BFEF_Done();

		return this.L02BF54();
	}

	public void L02BFEF_Done()
	{
		[0xF4] = 0;
		return;
	}

	public void L02BFF2()
	{
		P &= ~0x20;
		[0x1ACF] = 0;
		[0x1AD1] = 0;
		[0x1986] = 0;
		A = 0x0003;
		[0x198A] = A;
		A = 0x000A;
		[0x1AD6] = A;

		this.L0CF6F7();

		if (Z == 0)
			return this.L02C018();

		this.L02CC8F();
		this.L0784F5();

		return;
	}

	public void L02C018()
	{
		P |= 0x20;
		[0x1AD4] = 0;

		this.L02C08F();

		P |= 0x20;

		this.L02CC8F();

		P &= ~0x20;
		A = 0x0000;
		[0x700226] = A;
		P |= 0x20;
		[0x1ACF] = 0;
		P &= ~0x20;
		A = [0x1986];
		C = 0;
		A += 0x000A + C;
		P |= 0x20;
		[0xF3] = A;
		P &= ~0x20;
		A = 0x0001;

		this.L029310_SendApuCommand();

		A = 0x0006;

		this.L029283_LoadSong();

		P |= 0x20;
		A = 0xFF;
		[0x1AD0] = A;

		this.L0298F2();

		P |= 0x20;
		[0x1AD0] = 0;

		return;
	}

	public void L02C062()
	{
		this.L02C066();

		return;
	}

	public void L02C066()
	{
		Y = 0x0000;
	}

	public void L02C069()
	{
		Y--;

		if (Z == 0)
			return this.L02C069();

		X--;

		if (Z == 0)
			return this.L02C066();

		return;
	}

	public void L02C08F()
	{
		P &= ~0x20;
		A = 0xFFFF;
		[0x70021E] = A;
	}

	public void L02C098()
	{
		P |= 0x20;

		this.L02C278();

		P &= ~0x20;
		A = [0x70021E];

		if (Z == 0)
			return this.L02C098();

		return;
	}

	public void L02C127()
	{
		this.L02BE25();
	}

	public void L02C12B()
	{
		P |= 0x20;
		P &= ~0x10;

		this.L02C897_LongFunction();

		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 1)
			return this.L02C13D();

		return this.L02C12B();
	}

	public void L02C13D()
	{
		P |= 0x20;
		P &= ~0x10;

		this.L02C1B3();

		P |= 0x20;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;

		this.L02C897_LongFunction();

		P &= ~0x30;
		A = 0x000C;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;

		if (Z == 1)
			return this.L02C17C();

		this.L03EA39();
	}

	public void L02C17C()
	{
		this.L02A0F9();

		A = [0x10BE];
		temp = A & 0x0040;

		if (Z == 0)
			return this.L02C1AC();

		A = [0x10BC];
		temp = A & 0x0090;

		if (Z == 0)
			return this.L02C193();

		return this.L02C13D();
	}

	public void L02C193()
	{
		P &= ~0x20;
		A = 0xEA03;

		this.L029213_SendApuCommand();

		P |= 0x20;
	}

	public void L02C19E()
	{
		this.L02C897_LongFunction();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L02C19E();

		A = 0xFF;

		return;
	}

	public void L02C1AC()
	{
		this.L02CC8F();

		A = 0x6000;
	}

	public void L02C1B3()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		P &= ~0x20;
		A &= 0x00FF;
		[0x7001B2] = A;
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.L02C1D0();

		return this.L02C1FA();
	}

	public void L02C1D0()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.L02C1DB();

		return this.L02C1FA();
	}

	public void L02C1DB()
	{
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		A = [0x1986];
		A++;
		C = 1; temp = A - [0x198A];

		if (Z == 0)
			return this.L02C1F2();

		A = 0x0000;
	}

	public void L02C1F2()
	{
		[0x1986] = A;

		this.L02C23D();

		return this.L02C22D();
	}

	public void L02C1FA()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.L02C207();

		return this.L02C238_Done();
	}

	public void L02C207()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.L02C212();

		return this.L02C238_Done();
	}

	public void L02C212()
	{
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		A = [0x1986];
		A--;

		if (N == 0)
			return this.L02C227();

		A = [0x198A];
		A--;
	}

	public void L02C227()
	{
		[0x1986] = A;

		this.L02C23D();
	}

	public void L02C22D()
	{
		P &= ~0x20;
		A = 0xEA03;

		this.L029213_SendApuCommand();

		P |= 0x20;
	}

	public void L02C238_Done()
	{
		return;
	}

	public void L02C239()
	{
		this.L02C23D();

		return;
	}

	public void L02C23D()
	{
		P &= ~0x20;
		A = [0x1986];
		A <<= 1;
		C = 0;
		A += [0x1986] + C;
		C = 0;
		A += [0x1988] + C;
		X = A;
		A = [0x0BFB14 + X];

		if (Z == 0)
			return this.L02C264();

		A = [0x1986];
		A++;
		C = 1; temp = A - [0x198A];

		if (Z == 0)
			return this.L02C25E();

		A = 0x0000;
	}

	public void L02C25E()
	{
		[0x1986] = A;

		return this.L02C23D();
	}

	public void L02C264()
	{
		[0x700222] = A;
		P |= 0x20;
		A = [0x0BFB16 + X];
		P &= ~0x20;
		A &= 0x00FF;
		[0x700220] = A;

		return;
	}

	public void L02C278()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		[0x1ADF] = 0;
		A = 0x02;
		[0x38] = A;
		[0x1982]++;

		if (Z == 0)
			return this.L02C298();

		[0x1983]++;
	}

	public void L02C298()
	{
		P |= 0x20;
	}

	public void L02C29A()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.L02C29A();

	}

	public void L02C29F()
	{
		A = [0x1ADF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L02C29F();

		[0x1ADF] = 0;
	}

	public void L02C2A9()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02C2A9();

		this.L02C418();

		P &= ~0x30;
		[0x198C]++;
		A = 0x000C;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;

		if (Z == 1)
			return this.L02C2D9();

		this.L03EA3E();
	}

	public void L02C2D9()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.L02C330();

		P &= ~0x20;
		A = 0x000C;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00D7;
		[0x700228] = A;
		A = 0x07A9;
		[0x7000BA] = A;

		this.L03EA3E();

		P |= 0x20;
		A = [0x1DFB];

		if (Z == 1)
			return this.L02C330();

		P &= ~0x20;
		A &= 0x00FF;
		C = 1;
		A -= 0x0003 - !C;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += 0x093C + C;
		[0x7000BA] = A;
		A = 0x000C;
		[0x700064] = A;
		A = 0x0030;
		[0x70002C] = A;

		this.L03EA3E();

		P |= 0x20;
	}

	public void L02C330()
	{
		P |= 0x20;
		A = [0x1AD4];

		if (Z == 0)
			return this.L02C33A();

		return this.L02C3DE();
	}

	public void L02C33A()
	{
		P &= ~0x30;
		A = [0x1986];
		C = 0;
		A += [0x1AD6] + C;
		P |= 0x20;
		[0xF3] = A;
		P &= ~0x20;
		A = [0x198C];
		[0x70022C] = A;
		A = 0x006C;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00D7;
		[0x700228] = A;
		A = [0x1990];

		if (Z == 1)
			return this.L02C37C();

		A = [0xF3];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x1990] + C;
		X = A;
		A = [0x0BFB83 + X];

		if (Z == 0)
			return this.L02C388();

	}

	public void L02C37C()
	{
		A = [0xF3];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x0BFB83 + X];
	}

	public void L02C388()
	{
		[0x7000BA] = A;

		this.L03EA3E();

		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L02C3B1();

		A = [0x198C];
		C = 1; temp = A - 0x00C8;

		if (N == 1)
			return this.L02C3B3();

		A = [0x1990];
		A ^= 0x0002;
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;

		return this.L02C3B3();
	}

	public void L02C3B1()
	{
		P &= ~0x20;
	}

	public void L02C3B3()
	{
		A = 0x0000;
		[0x70022C] = A;
		A = 0x0010;
		[0x700064] = A;
		A = 0x005C;
		[0x70002C] = A;
		A = 0x00D7;
		[0x700228] = A;
		A = 0x2D5B;
		[0x7000BA] = A;

		this.L03EA3E();
		this.L078010();
	}

	public void L02C3DE()
	{
		P &= ~0x20;
		A = 0x000C;
		[0x700224] = A;
		A = 0x0000;
		[0x70021E] = A;
		P = Stack.Pop();

		return;
	}

	public void L02C418()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC88E;

		this.L7ED7E8_ExecuteSuperFX();

		P = Stack.Pop();

		return;
	}

	public void L02C42B()
	{
		P &= ~0x20;
		A = 0x0E02;

		this.L029213_SendApuCommand();

		P |= 0x20;
		A = 0xFF;
		[0x1AD4] = A;
		[0x1AD5] = A;

		this.L029E45();

		P |= 0x20;
		[0x1AD4] = 0;
		[0x1AD5] = 0;
		P &= ~0x20;
		A = 0x0E01;

		this.L029213_SendApuCommand();

		return;
	}

	public void L02C494()
	{
		P &= ~0x30;
		[0x10DB] = 0;
		A = 0x0339;
		[0x10DD] = A;
		Y = 0x003C;
	}

	public void L02C4A2()
	{
		X = A;
		C = 0;
		A += 0x0039 + C;
		[0x00 + X] = A;
		Y--;

		if (Z == 0)
			return this.L02C4A2();

		[0x00 + X] = 0;
		P |= 0x20;

		return;
	}

	public void L02C4B1()
	{
		Stack.Push(X);
		P |= 0x20;
		P &= ~0x10;
		A = [0x121B];

		if (Z == 0)
			return this.L02C4D8_Done();

		A = 0x28;
		[0x121B] = A;
		A = [0x121A];

		if (Z == 1)
			return this.L02C4D8_Done();

		A--;
		[0x121A] = A;
		P &= ~0x20;
		A = 0xEA90;

		this.L029213_SendApuCommand();

		P |= 0x20;

		this.L02C4DE();
	}

	public void L02C4D8_Done()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();

		return;
	}

	public void L02C4DE()
	{
		P &= ~0x30;
		A = 0x0001;
		[0x11C7] = A;
		A = 0x0014;
		[0x3E] = A;
		X = [0x10DB];

		if (Z == 1)
			return this.L02C538_Done();
	}

	public void L02C4F0()
	{
		C = 1; temp = X - [0x1286];

		if (Z == 1)
			return this.L02C501();

		C = 1; temp = X - [0x1288];

		if (Z == 1)
			return this.L02C530();

		C = 1; temp = X - [0x128A];

		if (Z == 1)
			return this.L02C530();

		return this.L02C505();
	}

	public void L02C501()
	{
		P |= 0x20;

		return this.L02C515_Skip();
	}

	public void L02C505()
	{
		P |= 0x20;
		A = [0x001E + X];
		A &= 0x10;

		if (Z == 0)
			return this.L02C515_Skip();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 1)
			return this.L02C530();

	}

	public void L02C515_Skip()
	{
		[0x3A] = 0;
		A = [0x28 + X];
		C = 1;
		A -= 0x0A - !C;

		if (N == 0)
			return this.L02C522_Skip();

		[0x3A] = A;
		A = 0x00;
	}

	public void L02C522_Skip()
	{
		[0x28 + X] = A;
		A = 0xF6;
		C = 1;
		A -= [0x3A] - !C;
		C = 0;
		A += [0x3E] + C;

		if (N == 1)
			return this.L02C538_Done();

		[0x3E] = A;
	}

	public void L02C530()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 1)
			return this.L02C538_Done();

		return this.L02C4F0();
	}

	public void L02C538_Done()
	{
		P &= ~0x20;
		A = 0x0002;
		[0x18BC] = A;
		P |= 0x20;
		return;
	}

	public void L02C580()
	{
		P &= ~0x30;
		A = 0x0F00;
		[0x1267] = A;
		[0x1269] = A;
		A = [0x1263];
		C = 1;
		A -= 0x3400 - !C;

		if (N == 1)
			return this.L02C59D();

		C = 0;
		A += [0x1267] + C;
		[0x1267] = A;
		return this.L02C5B1();
	}

	public void L02C59D()
	{
		A = [0x1263];
		C = 1;
		A -= 0xCC00 - !C;

		if (N == 0)
			return this.L02C5B1();

		A ^= 0xFFFF;
		A++;
		C = 0;
		A += [0x1267] + C;
		[0x1267] = A;
	}

	public void L02C5B1()
	{
		A = [0x1265];
		C = 1;
		A -= 0x3400 - !C;

		if (N == 1)
			return this.L02C5C3();

		C = 0;
		A += [0x1269] + C;
		[0x1269] = A;
		return this.L02C5D7();
	}

	public void L02C5C3()
	{
		A = [0x1265];
		C = 1;
		A -= 0xCC00 - !C;

		if (N == 0)
			return this.L02C5D7();

		A ^= 0xFFFF;
		A++;
		C = 0;
		A += [0x1269] + C;
		[0x1269] = A;
	}

	public void L02C5D7()
	{
		X = [0x10DB];

		if (Z == 1)
			return this.L02C63F_Done();

	}

	public void L02C5DC()
	{
		[0x10FE] = X;
		P |= 0x20;
		A = [0x09 + X];
		A &= 0x08;

		if (Z == 1)
			return this.L02C5F1();

		P &= ~0x20;
		A = [0x10 + X];
		C = 1;
		A -= [0x11D2] - !C;

		if (N == 1)
			return this.L02C61C();

	}

	public void L02C5F1()
	{
		P &= ~0x20;
		A = [0x04 + X];
		C = 1; temp = A - 0xCD16;

		if (Z == 1)
			return this.L02C634();

		A = [0x0C + X];
		C = 1;
		A -= [0x1263] - !C;

		if (N == 0)
			return this.L02C606();

		A ^= 0xFFFF;
		A++;
	}

	public void L02C606()
	{
		C = 1; temp = A - [0x1267];

		if (C == 1)
			return this.L02C61C();

		A = [0x10 + X];
		C = 1;
		A -= [0x1265] - !C;

		if (N == 0)
			return this.L02C617();

		A ^= 0xFFFF;
		A++;
	}

	public void L02C617()
	{
		C = 1; temp = A - [0x1269];

		if (C == 0)
			return this.L02C634();

	}

	public void L02C61C()
	{
		A = X;
		C = 1; temp = A - [0x1286];

		if (Z == 1)
			return this.L02C634();

		C = 1; temp = A - [0x128A];

		if (Z == 1)
			return this.L02C634();

		C = 1; temp = A - [0x1288];

		if (Z == 1)
			return this.L02C634();

		Y = [0x00 + X];
		this.L038DC1();
		return this.L02C639();
	}

	public void L02C634()
	{
		X = [0x10FE];
		Y = [0x00 + X];
	}

	public void L02C639()
	{
		X = Y;

		if (Z == 1)
			return this.L02C63F_Done();

		return this.L02C5DC();
	}

	public void L02C63F_Done()
	{
		return;
	}

	public void L02C640()
	{
		this.L02C644();
		return;
	}

	public void L02C644()
	{
		A = [0xC5];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x0C] = A;
		A = [0xC9];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x08] = A;
		A = [0x0C + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1;
		A -= [0x0C] - !C;

		if (N == 0)
			return this.L02C66F();

		A ^= 0xFFFF;
		A++;
	}

	public void L02C66F()
	{
		[0x0A] = A;
		A = [0x10 + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1;
		A -= [0x08] - !C;

		if (N == 0)
			return this.L02C684_Done();

		A ^= 0xFFFF;
		A++;
	}

	public void L02C684_Done()
	{
		C = 0;
		A += [0x0A] + C;
		return;
	}

	public void L02C688()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = [0x10DB];

		if (Z == 1)
			return this.L02C6A0_Done();

		this.L02C6A2();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC8AE;
		this.L7ED7E8_ExecuteSuperFX();
	}

	public void L02C6A0_Done()
	{
		P = Stack.Pop();
		return;
	}

	public void L02C6A2()
	{
		Stack.Push(P);
		Stack.Push(B);
		P |= 0x20;
		A = 0x7E;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x30;
		[0x1AC3] = 0;
		A = [0xC7];
		[0x7000DA] = A;
		X = 0x096E;
		A = [0x10DB];
		Y = A;

		if (Z == 0)
			return this.L02C6C1();

		B = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void L02C6C1()
	{
		P |= 0x20;
		[0x10FE] = Y;
		C = 1; temp = Y - [0x119E];

		if (Z == 1)
			return this.L02C6DA();

		C = 1; temp = Y - [0x11A0];

		if (Z == 1)
			return this.L02C6DA();

		C = 1; temp = Y - [0x11A2];

		if (Z == 1)
			return this.L02C6DA();

		C = 1; temp = Y - [0x10FC];

		if (Z == 0)
			return this.L02C6E7();

	}

	public void L02C6DA()
	{
		A = [0x11C2];

		if (Z == 1)
			return this.L02C6E7();

		A = [0x11C4];

		if (Z == 0)
			return this.L02C6E7();

		return this.L02C7F7();
	}

	public void L02C6E7()
	{
		A = [0x0008 + Y];
		A &= 0xE1;
		A |= 0x08;
		[0x0008 + Y] = A;
		A = [0x0009 + Y];
		P &= ~0x20;
		A &= 0x00FF;
		temp = A & 0x0020;

		if (Z == 0)
			return this.L02C715();

		temp = A & 0x0010;

		if (Z == 0)
			return this.L02C708();

		temp = A & 0x0001;

		if (Z == 1)
			return this.L02C71A();

	}

	public void L02C708()
	{
		Stack.Push(X);
		A = [0x0004 + Y];
		X = A;
		A = [0x11 + X];
		X = Stack.Pop();
		C = 1; temp = A - 0x0046;

		if (C == 1)
			return this.L02C71A();

	}

	public void L02C715()
	{
		A = 0x3A98;
		return this.L02C71D();
	}

	public void L02C71A()
	{
		A = 0x0000;
	}

	public void L02C71D()
	{
		[0x700002 + X] = A;
		A = [0x000C + Y];
		C = 1;
		A -= [0xC5] - !C;
		[0x70000E + X] = A;
		Stack.Push(X);
		A = [0x0004 + Y];
		X = A;
		A = [0x000008 + X];
		X = Stack.Pop();
		C = 0;
		A += [0x000E + Y] + C;
		C = 1;
		A -= [0xC7] - !C;
		[0x70000C + X] = A;
		A = [0x0010 + Y];
		C = 1;
		A -= [0xC9] - !C;
		[0x700010 + X] = A;
		A = [0x0004 + Y];
		[0x700004 + X] = A;
		P |= 0x20;
		A = [0x0012 + Y];
		[0x700015 + X] = A;
		A = [0x0013 + Y];
		[0x700016 + X] = A;
		A = [0x0014 + Y];
		[0x700017 + X] = A;
		A = [0x0008 + Y];
		A &= 0x01;

		if (Z == 1)
			return this.L02C79D();

		A = [0x000A + Y];
		[0x700012 + X] = A;
		A = [0x001D + Y];
		temp = A & 0x20;

		if (Z == 1)
			return this.L02C7A3();

		P &= ~0x20;
		A = Y;
		[0x700006 + X] = A;
		P |= 0x20;
		A = [0x0020 + Y];
		[0x700008 + X] = A;
		A = [0x0021 + Y];
		[0x700009 + X] = A;
		A = [0x0022 + Y];
		[0x70000A + X] = A;
		return this.L02C7A3();
	}

	public void L02C79D()
	{
		A = 0x00;
		[0x700012 + X] = A;
	}

	public void L02C7A3()
	{
		A = [0x001D + Y];
		[0x700018 + X] = A;
		A &= 0xFD;
		[0x001D + Y] = A;
		A = [0x0038 + Y];
		[0x700019 + X] = A;
		A = [0x0036 + Y];
		[0x70001A + X] = A;
		A = [0x0037 + Y];
		[0x70001B + X] = A;
		Stack.Push(X);
		X = Y;
		A = [0x7E1CDC + X];
		X = Stack.Pop();
		temp = A & 0x80;

		if (Z == 0)
			return this.L02C7D2();

		A = [0x1982];
	}

	public void L02C7D2()
	{
		A &= 0x7F;
		[0x700013 + X] = A;
		Stack.Push(X);
		X = Y;
		A = [0x7E1CDB + X];
		X = Stack.Pop();
		temp = A & 0x80;

		if (Z == 0)
			return this.L02C7E6();

		A = [0x1982];
	}

	public void L02C7E6()
	{
		A &= 0x7F;
		[0x700014 + X] = A;
		P &= ~0x20;
		[0x1AC3]++;
		A = X;
		C = 0;
		A += 0x001C + C;
		X = A;
	}

	public void L02C7F7()
	{
		P &= ~0x20;
		A = [0x0000 + Y];
		Y = A;

		if (Z == 1)
			return this.L02C802_Done();

		return this.L02C6C1();
	}

	public void L02C802_Done()
	{
		A = [0x1AC3];
		[0x7001BA] = A;
		B = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void L02C897_LongFunction()
	{
		P |= 0x20;
		this.L03EC1A();
		P |= 0x20;
		A = [0x1AC1];

		if (Z == 1)
			return this.L02C8DA_Skip();

		A = [0x7EC644];

		if (Z == 1)
			return this.L02C8DA_Skip();

		A = [0x7EC643];
		A--;
		[0x7EC643] = A;

		if (N == 0)
			return this.L02C8DA_Skip();

		A = 0x28;
		[0x7EC643] = A;
		A = [0x7EC644];
		P &= ~0x20;
		A &= 0x00FF;
		A |= 0x0800;
		this.L029213_SendApuCommand();
		P |= 0x20;
		A = [0x7EC644];
		A++;
		C = 1; temp = A - 0x10;

		if (Z == 1)
			return this.L02C8DA_Skip();

		[0x7EC644] = A;
	}

	public void L02C8DA_Skip()
	{
		P |= 0x20;
		A = [0x122F];

		if (Z == 1)
			return this.L02C8FA_Skip();

		[0x122F] = 0;
		P &= ~0x20;
		A = [0x1230];
		A++;
		[0x1230] = A;
		A <<= 1;
		X = A;
		A = [0x02F5C0 + X];
		[0x1228] = A;
		this.L04B914();
	}

	public void L02C8FA_Skip()
	{
		P |= 0x20;
		A = [0x122B];

		if (Z == 1)
			return this.L02C920_Skip();

		[0x122B] = 0;
		A = [0x122A];
		A ^= 0xFF;
		[0x122A] = A;
		P &= ~0x20;
		A = [0x1228];
		Stack.Push(A);
		A = [0x122C];
		[0x1228] = A;
		A = Stack.Pop();
		[0x122C] = A;
		this.L04B93D();
	}

	public void L02C920_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void L02C924_Wait()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02C924_Wait();

		[0x1ADF] = 0;
		A = 0x02;
		[0x38] = A;
		[0x118C] = 0;
		this.L00DDDE();
		P &= ~0x20;
		A = [0x1AD0];
		A &= 0x00FF;

		if (Z == 1)
			return this.L02C971_Skip();

		A = [0xF3];
		A &= 0x00FF;
		C = 1; temp = A - 0x000C;

		if (Z == 0)
			return this.L02C954_Skip();

		A = [0x1237];
		C = 1; temp = A - 0x0005;

		if (C == 0)
			return this.L02C971_Skip();

		return this.L02C961_Skip();
	}

	public void L02C954_Skip()
	{
		C = 1; temp = A - 0x000A;

		if (Z == 0)
			return this.L02C971_Skip();

		A = [0x1235];
		C = 1; temp = A - 0x001E;

		if (C == 0)
			return this.L02C971_Skip();
	}

	public void L02C961_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x118F];

		if (Z == 0)
			return this.L02C971_Skip();

		X = [0x10FC];
		this.L03B469();
	}

	public void L02C971_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
		[0x1982]++;

		if (Z == 0)
			return this.L02C97D_Skip();

		[0x1983]++;
	}

	public void L02C97D_Skip()
	{
		this.L03A5C3_UpdateSound();
		P |= 0x20;
		P &= ~0x10;
		X = 0xFFFF;
		[0x11F7] = X;
		X = [0x10DB];

		if (Z == 1)
			return this.L02C9AB();

	}

	public void L02C990()
	{
		[0x1108] = 0;
		this.L039F42();
		A = [0x1108];

		if (Z == 0)
			return this.L02C9A3();

		Y = [0x00 + X];
	}

	public void L02C99E()
	{
		X = Y;

		if (Z == 0)
			return this.L02C990();

		return this.L02C9AB();
	}

	public void L02C9A3()
	{
		Y = [0x00 + X];
		this.L038D6F();
		return this.L02C99E();
	}

	public void L02C9AB()
	{
		P |= 0x20;
		A = [0x118C];
		C = 1; temp = A - [0x118D];

		if (Z == 1)
			return this.L02C9D4();

		[0x118D] = A;
		C = 1; temp = A - 0x00;

		if (Z == 0)
			return this.L02C9C9();

		P &= ~0x20;
		A = 0xEA22;
		this.L029213_SendApuCommand();
		P |= 0x20;
		return this.L02C9D4();
	}

	public void L02C9C9()
	{
		P &= ~0x20;
		A = 0xEA23;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L02C9D4()
	{
		this.L03E3B5();
		this.L02CDE9();
		this.L03848F();
		this.L02CD22();
		P &= ~0x20;
		A = [0x1AE6];

		if (Z == 1)
			return this.L02C9FB();

		X = [0x10FA];
		A = [0x0E + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		A += 0x0080 + C;
		[0x1B70] = A;
		[0x1B78] = 0;
	}

	public void L02C9FB()
	{
		A = [0x1ADC];

		if (Z == 1)
			return this.L02CA11();

		X = [0x10FA];
		A = [0x0C + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
	}

	public void L02CA11()
	{
		[0x1ADD] = A;
		this.L02C688();
		this.L02D24F();
		this.L038EA8();
		P |= 0x20;
	}

	public void L02CA21()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.L02CA21();

		this.L02CDC9();
	}

	public void L02CA2A()
	{
		A = [0x1ADF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L02CA2A();

		[0x1ADF] = 0;
		P &= ~0x30;
		A = [0x1926];
		[0x7001AC] = A;

		if (Z == 1)
			return this.L02CA43();

		this.L01F622();
	}

	public void L02CA43()
	{
		this.L7EC654();
		P &= ~0x20;
		A = [0x10E5];

		if (Z == 1)
			return this.L02CA52();

		this.L07814C();
	}

	public void L02CA52()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.L02CA5C();

		return this.L02CB5C();
	}

	public void L02CA5C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.L02CA8D();

		A = [0x00197E];

		if (Z == 0)
			return this.L02CA8D();

		P &= ~0x20;
		A = [0x197C];

		if (N == 1)
			return this.L02CA8D();

		[0x70002E] = A;
		A = 0x0064;
		[0x700064] = A;
		A = 0x000E;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.L03EB92();
	}

	public void L02CA8D()
	{
		P |= 0x20;
		A = [0x10D2];

		if (Z == 1)
			return this.L02CABD();

		A = [0x1982];
		A &= 0x04;

		if (Z == 1)
			return this.L02CABD();

		P &= ~0x20;
		A = 0x0046;
		[0x700064] = A;
		A = 0x004C;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0902;
		[0x7000BA] = A;
		this.L03EA3E();
	}

	public void L02CABD()
	{
		P |= 0x20;
		A = [0x11D4];

		if (Z == 1)
			return this.L02CB17();

		A--;
		[0x11D4] = A;
		A = [0x11D5];

		if (Z == 1)
			return this.L02CAD2();

		[0x11D4] = 0;
		return this.L02CB17();
	}

	public void L02CAD2()
	{
		P &= ~0x20;
		A = 0x0032;
		[0x700064] = A;
		A = 0x00A7;
		[0x70002C] = A;
		A = [0x1285];
		A &= 0x00FF;

		if (Z == 1)
			return this.L02CAF6();

		A = [0x70002C];
		C = 1;
		A -= 0x0008 - !C;
		[0x70002C] = A;
	}

	public void L02CAF6()
	{
		A = 0x00DF;
		[0x700228] = A;
		A = [0x11D6];
		[0x7000BA] = A;
		this.L03EA39();
		P |= 0x20;
		this.L0385AB();
		A = [0x11D4];

		if (Z == 0)
			return this.L02CB17();

		this.L03853B_ClearRam();
	}

	public void L02CB17()
	{
		P |= 0x20;
		A = [0x1DBA];

		if (Z == 0)
			return this.L02CB21();

		return this.L02CBCE();
	}

	public void L02CB21()
	{
		P &= ~0x30;
		A = [0x70021E];

		if (Z == 1)
			return this.L02CB5C();

		A--;
		[0x70021E] = A;
		A = 0x0008;
		[0x700064] = A;
		A = 0x0090;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;

		if (Z == 1)
			return this.L02CB5C();

		this.L03EA39();
		P &= ~0x20;
		A = [0x70022A];
		A++;
		[0x70022A] = A;
	}

	public void L02CB5C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.L02CBCE();

		P &= ~0x20;
		A = [0xF3];
		A &= 0x00FF;
		C = 1; temp = A - 0x000C;

		if (Z == 0)
			return this.L02CB74();

		A = [0x1237];
		return this.L02CB7C();
	}

	public void L02CB74()
	{
		C = 1; temp = A - 0x000A;

		if (Z == 0)
			return this.L02CB9B();

		A = [0x1235];
	}

	public void L02CB7C()
	{
		[0x70002E] = A;
		A = 0x00B0;
		[0x700064] = A;
		A = 0x0008;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.L03EB92();
		return this.L02CBCA();
	}

	public void L02CB9B()
	{
		[0x3A] = 0;
		A = [0x120C];
		[0x70002E] = A;
		C = 1; temp = A - 0x270F;

		if (N == 1)
			return this.L02CBAE();

		A = 0xFFF8;
		[0x3A] = A;
	}

	public void L02CBAE()
	{
		A = 0x00B0;
		C = 0;
		A += [0x3A] + C;
		[0x700064] = A;
		A = 0x0008;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.L03EB30();
	}

	public void L02CBCA()
	{
		this.L078237();
	}

	public void L02CBCE()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.L02CBFB();

		this.L078010();
		P &= ~0x30;
		A = 0x0054;
		[0x700064] = A;
		A = 0x00A8;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0796;
		[0x7000BA] = A;
		this.L03EA3E();
	}

	public void L02CBFB()
	{
		P |= 0x20;
		P &= ~0x10;
		[0x1280] = 0;
		A = 0x00;
		X = [0x10DB];

		if (Z == 1)
			return this.L02CC22();

	}

	public void L02CC09()
	{
		Stack.Push(A);
		A = [0x001E + X];
		A &= 0x20;

		if (Z == 0)
			return this.L02CC1B();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 1)
			return this.L02CC1B();

		[0x1280]++;
	}

	public void L02CC1B()
	{
		A = Stack.Pop();
		A++;
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L02CC09();

	}

	public void L02CC22()
	{
		[0x127F] = A;
		P |= 0x20;
		A = [0x11DA];

		if (Z == 1)
			return this.L02CC46_Done();

		P &= ~0x20;
	}

	public void L02CC2E()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02CC2E();

		this.L09FA1A();
		P &= ~0x20;
		A = 0x000A;
		[0x38] = A;
	}

	public void L02CC3D()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02CC3D();

		P |= 0x20;
		[0x11DA] = 0;
	}

	public void L02CC46_Done()
	{
		return;
	}

	public void L02CC50()
	{
		P &= ~0x20;
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void L02CC59()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void L02CC61()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02CC61();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L02CC59();

		P &= ~0x20;
		A = 0x0000;
		[0x70021E] = A;
		[0x700224] = A;
		P |= 0x20;
		return;
	}

	public void L02CC7C()
	{
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void L02CC83()
	{
		this.L02C897_LongFunction();
		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L02CC83();

		return;
	}

	public void L02CC8F()
	{
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void L02CC96()
	{
		A = 0x10;
		[0x38] = A;
		A = [0x109B];
	}

	public void L02CC9D()
	{
		C = 1; temp = A - [0x109B];

		if (Z == 1)
			return this.L02CC9D();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L02CC96();

		[0x38] = 0;
		return;
	}

	public void L02CCC9()
	{
		P |= 0x30;
		P |= 0x10;
	}

	public void L02CCCD()
	{
		A = [0x2137];
		X = [0x213D];
		A = [0x213D];
		A &= 0x01;

		if (Z == 0)
			return this.L02CCCD();

		C = 1; temp = X - 0xCF;

		if (Z == 0)
			return this.L02CCCD();

		P &= ~0x10;
		P &= ~0x20;
		A = 0x0001;
		[0x70021E] = A;
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L02CCF0()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void L02CCF8()
	{
		A = [0x38];

		if (Z == 0)
			return this.L02CCF8();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L02CCF0();

		return;
	}

	public void L02CD1E()
	{
		this.L02CD30();
		return;
	}

	public void L02CD22()
	{
		P &= ~0x30;
		[0x1B7A] = 0;
		A = [0x122A];
		A &= 0x00FF;

		if (Z == 0)
			return this.L02CD30();

		return;
	}

	public void L02CD30()
	{
		P &= ~0x30;
		A = [0x10F8];

		if (N == 1)
			return this.L02CD67();

		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x008A44 + X];
		C = 1; temp = A - [0x1B78];

		if (Z == 0)
			return this.L02CD47();

		return;
	}

	public void L02CD47()
	{
		[0x1B78] = A;
		X = A;
		Y = 0x0000;
	}

	public void L02CD4E()
	{
		A = [0x00 + X];
		C = 0;
		A += [0x1B70] + C;
		[0x1AF0 + Y] = A;
		Y++;
		Y++;
		X++;
		X++;
		C = 1; temp = Y - 0x0040;

		if (Z == 0)
			return this.L02CD4E();

		A = 0x0001;
		[0x1B7A] = A;
		return;
	}

	public void L02CD67()
	{
		A ^= 0xFFFF;
		A++;
		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x008A44 + X];
		C = 1; temp = A - [0x1B78];

		if (Z == 0)
			return this.L02CD7B();

		return;
	}

	public void L02CD7B()
	{
		[0x1B78] = A;
		C = 0;
		A += 0x003E + C;
		X = A;
		Y = 0x0000;
	}

	public void L02CD86()
	{
		A = [0x00 + X];
		C = 0;
		A += [0x1B70] + C;
		[0x1AF0 + Y] = A;
		X--;
		X--;
		Y++;
		Y++;
		C = 1; temp = Y - 0x0040;

		if (Z == 0)
			return this.L02CD86();

		A = 0x0001;
		[0x1B7A] = A;
		return;
	}

	public void L02CD9F()
	{
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x1AF0;
		[0x4302] = X;
		[0x4304] = 0;
		X = 0x2FA0;
		[0x2116] = X;
		X = 0x0040;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		return;
	}

	public void L02CDC9()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC85E;
		this.L7ED7E8_ExecuteSuperFX();
		P = Stack.Pop();
		return;
	}

	public void L02CDE9()
	{
		P &= ~0x30;
		X = [0x1B7E];

		if (Z == 0)
			return this.L02CDF1();

		return;
	}

	public void L02CDF1()
	{
		P &= ~0x20;
		A = [0x02CE6B + X];
		C = 1; temp = A - 0x1234;

		if (Z == 0)
			return this.L02CE1A();

		P |= 0x20;
		A = 0x00;
		[0x2132] = A;
		[0x1B7F] = A;
		[0x1B7E] = A;
		[0x700021] = A;
		[0x700020] = A;
		A = [0x10C4];
		A &= 0xCF;
		[0x420C] = A;
		return;
	}

	public void L02CE1A()
	{
		A = [0x02CE6C + X];
		[0x700020] = A;
		A = 0x0000;
		[0x700026] = A;
		[0x700028] = A;
		P |= 0x20;
		A = [0x02CE6B + X];
		X++;
		X++;
		X++;
		[0x1B7E] = X;
		A = 0x01;
		X = 0xBCFC;
		this.L7ED7E8_ExecuteSuperFX();
		A = [0x10C4];
		[0x420C] = A;
		X = 0x0000;
	}

	public void L02CE4B()
	{
		A = [0x701F0C + X];
		[0x7EE9B6 + X] = A;
		C = 1;
		A -= 0x80 - !C;
		[0x1125] = A;
		A = 0x80;
		C = 1;
		A -= [0x1125] - !C;
		[0x7EE7C1 + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x01C0;

		if (Z == 0)
			return this.L02CE4B();

		return;
	}

	public void L02D24B()
	{
		this.L02D24F();
		return;
	}

	public void L02D24F()
	{
		P |= 0x20;
		P &= ~0x10;
		P &= ~0x20;
		X = [0x10FC];
		A = [0x0C + X];
		[0x700238] = A;
		A = [0x10 + X];
		[0x70023A] = A;
		P |= 0x20;
		A = [0x120E];
		P &= ~0x20;
		A &= 0x00FF;
		[0x700242] = A;
		P |= 0x20;
		A = [0x118C];
		[0x700258] = A;
		A = [0x1191];
		C = 0;
		A += 0x01 + C;
		[0x700252] = A;
		A = [0x1210];
		[0x70025A] = A;
		X = [0x1DDC];
		A = [0x001DE4 + X];
		[0x70024C] = A;
		X = [0x1DED];
		A = [0x001DF5 + X];
		[0x70024D] = A;
		A = [0x1186];
		C = 1; temp = A - 0x03;

		if (Z == 0)
			return this.L02D2B4_Skip();

		A = [0x121A];
		[0x70024C] = A;
		[0x70024D] = A;
	}

	public void L02D2B4_Skip()
	{
		P &= ~0x20;
		A = [0x11F9];
		A ^= 0xFFFF;
		A++;
		[0x00] = A;
		A = [0x11FB];
		[0x06] = A;
		this.L03E8FD();
		P &= ~0x20;
		[0x3A] = A;
		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		P |= 0x20;
		X = [0x10FC];
		C = 1;
		A -= [0x13 + X] - !C;
		C = 0;
		A += 0x0F + C;
		P &= ~0x20;
		A &= 0x00FF;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += 0x0022 + C;
		[0x700250] = A;
		A = [0x118A];
		[0x7001BC] = A;
		P |= 0x20;
		X = [0x116C];
		A = [0x28 + X];

		if (N == 0)
			return this.L02D30E();

		A = 0x00;
	}

	public void L02D30E()
	{
		[0x7001BE] = A;
		P |= 0x20;
		A = [0x11BE];
		A |= [0x1109];
		P &= ~0x20;
		A &= 0x00FF;
		[0x70023E] = A;
		P |= 0x20;
		A = [0xF3];
		P &= ~0x20;
		A--;
		A &= 0x00FF;
		[0x70023C] = A;
		this.L0782A9();
		return;
	}

	public void L02D337()
	{
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void L02D33E()
	{
		A = [0x0BFBBB + X];
		[0x7EEBAA + X] = A;
		X++;
		C = 1; temp = X - [0x0018];

		if (Z == 0)
			return this.L02D33E();

		A = 0x06;
		[0x1E02] = A;
		return;
	}

	public void L02D352()
	{
		P &= ~0x30;
		X = 0x0000;
		Y = 0x0000;
	}

	public void L02D35A_Loop()
	{
		P &= ~0x30;
		Stack.Push(X);
		Stack.Push(Y);
		A = [0x7EEBAC + X];
		A &= 0x00FF;
		[0x700064] = A;
		A = [0x7EEBAD + X];
		A &= 0x00FF;
		[0x70002C] = A;
		A = [0x7EEBAB + X];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BFC8B + X];
		X = A;
		Y = 0x0000;
		A = [0x0BFBD3 + X];
		A &= 0x00FF;
		X++;
		[0x3A] = A;
		[0x70002E] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		[0x3A] = A;
		P |= 0x20;
		P &= ~0x10;
	}

	public void L02D39D_Loop()
	{
		A = [0x0BFBD3 + X];
		Stack.Push(X);
		X = Y;
		[0x701000 + X] = A;
		X = Stack.Pop();
		X++;
		Y++;
		[0x3A]--;

		if (Z == 0)
			return this.L02D39D_Loop();

		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xCE5B;
		this.L7ED7E8_ExecuteSuperFX();
		Y = Stack.Pop();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		A = [0x7EEBAA + X];

		if (Z == 1)
			return this.L02D3CE_Skip();

		A--;
		[0x7EEBAA + X] = A;
		return this.L02D3EA_Skip();
	}

	public void L02D3CE_Skip()
	{
		A = [0x7EEBAB + X];
		A++;
		C = 1; temp = A - 0x07;

		if (Z == 0)
			return this.L02D3E6_Skip();

		this.L03E814();
		A &= 0x3F;
		C = 0;
		A += 0x14 + C;
		[0x7EEBAA + X] = A;
		A = 0x00;
	}

	public void L02D3E6_Skip()
	{
		[0x7EEBAB + X] = A;
	}

	public void L02D3EA_Skip()
	{
		X++;
		X++;
		X++;
		X++;
		Y++;
		A = Y;
		C = 1; temp = A - [0x1E02];

		if (Z == 1)
			return this.L02D3F8_Done();

		return this.L02D35A_Loop();
	}

	public void L02D3F8_Done()
	{
		return;
	}

	public void L038000()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		[0x1B90] = 0;
		P &= ~0x20;
		A = 0xF789;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0B;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x6800;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x2000;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
	}

	public void L03805D()
	{
		A = 0x04;
		[0x4301] = A;
		X = 0x0000;
		[0x2102] = X;
		X = 0x1B91;
		[0x4302] = X;
		A = 0x00;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x04;
		[0x4301] = A;
		X = 0x0080;
		[0x2102] = X;
		X = 0x1B91;
		[0x4302] = X;
		A = 0x00;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x04;
		[0x4301] = A;
		X = 0x0100;
		[0x2102] = X;
		X = 0x1B91;
		[0x4302] = X;
		A = 0x00;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x04;
		[0x4301] = A;
		X = 0x0180;
		[0x2102] = X;
		X = 0x1B91;
		[0x4302] = X;
		A = 0x00;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		P = Stack.Pop();
		return;
	}

	public void L0380F7()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		P &= ~0x20;
		A = 0xE25B;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0A;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x6800;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x2000;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
		return this.L03805D();
	}

	public void L038154()
	{
		P &= ~0x30;
		A = 0xAAAA;
		X = 0x0000;
		Y = 0x0010;
	}

	public void L03815F()
	{
		[0x1D91 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L03815F();

		return;
	}

	public void L038168()
	{
		Stack.Push(P);
		P |= 0x20;
		[0x1B90] = 0;
		P &= ~0x20;
		A = 0xFEFE;
		Y = 0x0100;
		X = 0x0000;
	}

	public void L038179()
	{
		[0x1B91 + X] = A;
		[0x1B91 + X] = 0;
		X++;
		X++;
		Y--;

		if (N == 0)
			return this.L038179();

		P = Stack.Pop();
		return;
	}

	public void L038186()
	{
		Stack.Push(P);
		P |= 0x20;
		[0x1B90] = 0;
		P &= ~0x20;
		A = 0xAFB0;
		[0x1B95] = A;
		A = 0x348D;
		[0x1B97] = A;
		A = 0xB7B0;
		[0x1B99] = A;
		A = 0x348E;
		[0x1B9B] = A;
		A = 0xBFB0;
		[0x1B9D] = A;
		A = 0x348E;
		[0x1B9F] = A;
		A = 0xC7B0;
		[0x1BA1] = A;
		A = 0x348F;
		[0x1BA3] = A;
		A = 0xAFB8;
		[0x1BA5] = A;
		A = 0x348D;
		[0x1BA7] = A;
		A = 0xB7B8;
		[0x1BA9] = A;
		A = 0x348E;
		[0x1BAB] = A;
		A = 0xBFB8;
		[0x1BAD] = A;
		A = 0x348E;
		[0x1BAF] = A;
		A = 0xC7B8;
		[0x1BB1] = A;
		A = 0x348F;
		[0x1BB3] = A;
		A = 0xAFC0;
		[0x1C01] = A;
		A = 0x3493;
		[0x1C03] = A;
		A = 0xAFC8;
		[0x1C05] = A;
		A = 0x3494;
		[0x1C07] = A;
		A = 0xAFD0;
		[0x1C09] = A;
		A = 0x3495;
		[0x1C0B] = A;
		A = 0xB7C0;
		[0x1C0D] = A;
		A = 0x3496;
		[0x1C0F] = A;
		A = 0xB7C8;
		[0x1C11] = A;
		A = 0x3497;
		[0x1C13] = A;
		A = 0xB7D0;
		[0x1C15] = A;
		A = 0x3498;
		[0x1C17] = A;
		A = 0xBFC0;
		[0x1C19] = A;
		A = 0x3499;
		[0x1C1B] = A;
		A = 0xBFC8;
		[0x1C1D] = A;
		A = 0x349A;
		[0x1C1F] = A;
		A = 0xBFD0;
		[0x1C21] = A;
		A = 0x349B;
		[0x1C23] = A;
		A = 0xAFD8;
		[0x1C25] = A;
		A = 0x349C;
		[0x1C27] = A;
		A = 0xAFE0;
		[0x1C29] = A;
		A = 0x349D;
		[0x1C2B] = A;
		A = 0xAFE8;
		[0x1C2D] = A;
		A = 0x349E;
		[0x1C2F] = A;
		A = 0xB7D8;
		[0x1C31] = A;
		A = 0x349F;
		[0x1C33] = A;
		A = 0xB7E0;
		[0x1C35] = A;
		A = 0x34A0;
		[0x1C37] = A;
		A = 0xB7E8;
		[0x1C39] = A;
		A = 0x34A1;
		[0x1C3B] = A;
		A = 0xBFD8;
		[0x1C3D] = A;
		A = 0x34A2;
		[0x1C3F] = A;
		A = 0xBFE0;
		[0x1C41] = A;
		A = 0x34A3;
		[0x1C43] = A;
		A = 0xBFE8;
		[0x1C45] = A;
		A = 0x34A4;
		[0x1C47] = A;
		A = 0xC7C0;
		[0x1C49] = A;
		A = 0x32D0;
		[0x1C4B] = A;
		A = 0xC7C8;
		[0x1C4D] = A;
		A = 0x32D1;
		[0x1C4F] = A;
		A = 0xC7D0;
		[0x1C51] = A;
		A = 0x32D1;
		[0x1C53] = A;
		A = 0xC7D8;
		[0x1C55] = A;
		A = 0x32D0;
		[0x1C57] = A;
		A = 0xC7E0;
		[0x1C59] = A;
		A = 0x32D1;
		[0x1C5B] = A;
		A = 0xC7E8;
		[0x1C5D] = A;
		A = 0x32D1;
		[0x1C5F] = A;
		A = 0xAF10;
		[0x1C91] = A;
		A = 0x3500;
		[0x1C93] = A;
		A = 0xAF20;
		[0x1C95] = A;
		A = 0x3502;
		[0x1C97] = A;
		A = 0xAF30;
		[0x1C99] = A;
		A = 0x3504;
		[0x1C9B] = A;
		A = 0xBF10;
		[0x1C9D] = A;
		A = 0x3506;
		[0x1C9F] = A;
		A = 0xBF20;
		[0x1CA1] = A;
		A = 0x3508;
		[0x1CA3] = A;
		A = 0xBF30;
		[0x1CA5] = A;
		A = 0x350A;
		[0x1CA7] = A;
		A = 0x1818;
		[0x1CA9] = A;
		A = 0x350C;
		[0x1CAB] = A;
		A = 0x1828;
		[0x1C61] = A;
		A = 0x34CA;
		[0x1C63] = A;
		A = 0x1830;
		[0x1C65] = A;
		A = 0x34C3;
		[0x1C67] = A;
		A = 0x106D;
		[0x1C69] = A;
		A = 0x34DB;
		[0x1C6B] = A;
		A = 0x186D;
		[0x1C6D] = A;
		A = 0x34DC;
		[0x1C6F] = A;
		A = 0x1875;
		[0x1C71] = A;
		A = 0x34DD;
		[0x1C73] = A;
		A = 0x187D;
		[0x1C75] = A;
		A = 0x34DD;
		[0x1C77] = A;
		A = 0x1885;
		[0x1C79] = A;
		A = 0x34DE;
		[0x1C7B] = A;
		A = 0x1085;
		[0x1C7D] = A;
		A = 0x34DF;
		[0x1C7F] = A;
		A = 0x1075;
		[0x1C81] = A;
		A = 0x34E0;
		[0x1C83] = A;
		A = 0x107D;
		[0x1C85] = A;
		A = 0x34E1;
		[0x1C87] = A;
		this.L03840A();
		A = 0x0000;
		X = 0x0000;
		Y = 0x0008;
	}

	public void L0383E7()
	{
		[0x1D91 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L0383E7();

		A = 0xAAAA;
		X = 0x0000;
		Y = 0x0008;
	}

	public void L0383F8()
	{
		[0x1DA1 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L0383F8();

		P &= ~0x20;
		A = 0x001B;
		[0x1DB7] = A;
		P = Stack.Pop();
		return;
	}

	public void L03840A()
	{
		Stack.Push(P);
		Stack.Push(X);
		P &= ~0x20;
		A = [0x1DDA];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B + X];
		C = 0;
		A += 0x0080 + C;
		[0x3E] = A;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L03842E();

		A = 0x0080;
		[0x3E] = A;
	}

	public void L03842E()
	{
		Y = 0x0009;
		X = 0x0070;
	}

	public void L038434()
	{
		A = [0x1B93 + X];
		A &= 0xFE00;
		C = 0;
		A += [0x3E] + C;
		[0x1B93 + X] = A;
		A = [0x3E];
		A++;
		[0x3E] = A;
		X++;
		X++;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L038434();

		P &= ~0x20;
		A = [0x1DEB];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B + X];
		C = 0;
		A += 0x0080 + C;
		[0x3E] = A;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L03846E();

		A = 0x0080;
		[0x3E] = A;
	}

	public void L03846E()
	{
		Y = 0x0009;
		X = 0x0094;
	}

	public void L038474()
	{
		A = [0x1B93 + X];
		A &= 0xFE00;
		C = 0;
		A += [0x3E] + C;
		[0x1B93 + X] = A;
		A = [0x3E];
		A++;
		[0x3E] = A;
		X++;
		X++;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.L038474();

		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void L03848F()
	{
		P |= 0x20;
		A = [0x1DBA];
		[0x700234] = A;

		if (Z == 1)
			return this.L0384A6_Done();

		this.L0384FD();
		this.L038503();
		this.L03880A();
		this.L0385F7();
	}

	public void L0384A6_Done()
	{
		return;
	}

	public void L0384B4()
	{
		P |= 0x20;
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		A--;
		X = A;
		P |= 0x20;
		A = [0x0384A7 + X];
		C = 1; temp = A - [0x1DB9];

		if (Z == 0)
			return this.L0384CB();

		return;
	}

	public void L0384CB()
	{
		[0x1DB9] = A;
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		[0x3C] = A;
		Y = 0x0009;
		X = 0x0024;
	}

	public void L0384E4()
	{
		A = [0x1B93 + X];
		A &= 0xF1FF;
		A |= [0x3C];
		A |= 0x3000;
		[0x1B93 + X] = A;
		X++;
		X++;
		X++;
		X++;
		Y++;
		C = 1; temp = Y - [0x1DB7];

		if (Z == 0)
			return this.L0384E4();

		return;
	}

	public void L0384FD()
	{
		this.L0384B4();
		P &= ~0x20;
		return;
	}

	public void L038503()
	{
		A = 0x0002;
		P &= ~0x20;
		A &= 0x00FF;
		A = (A >> 8) | (A << 8);
		A <<= 1;
		A |= 0x3000;
		[0x1DCA] = A;
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		A = [0x13 + X];
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A >>= 1;
		A <<= 1;
		P &= ~0x20;
		A &= 0x00FF;
		C = 0;
		A += 0x00E0 + C;
		A |= [0x1DCA];
		X = 0x00F0;
		[0x1B93 + X] = A;
		C = 0;
		A += 0x0001 + C;
		[0x1B97 + X] = A;
		return;
	}

	public void L03853B_ClearRam()
	{
		P &= ~0x20;
		X = 0x011C;
		A = 0x0000;
		[0x1B91 + X] = A;
		[0x1B93 + X] = A;
		[0x1B95 + X] = A;
		[0x1B97 + X] = A;
		[0x1B99 + X] = A;
		[0x1B9B + X] = A;
		[0x1B9D + X] = A;
		[0x1B9F + X] = A;
		P |= 0x20;
		return;
	}

	public void L03855E()
	{
		P &= ~0x30;
		Stack.Push(X);
		A = [0x1DBA];
		A &= 0x00FF;

		if (Z == 1)
			return this.L038599_Done();

		A = 0xAF13;
		[0x1CAD] = A;
		A = 0x3120;
		[0x1CAF] = A;
		A = 0xAF23;
		[0x1CB1] = A;
		A = 0x3122;
		[0x1CB3] = A;
		A = 0xBF13;
		[0x1CB5] = A;
		A = 0x3124;
		[0x1CB7] = A;
		A = 0xBF23;
		[0x1CB9] = A;
		A = 0x3126;
		[0x1CBB] = A;
	}

	public void L038599_Done()
	{
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L0385AB()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L03E814();
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		A <<= 1;
		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		X = A;
		A = [0x03859F + X];
		A &= 0x00FF;
		C = 0;
		A += 0x0080 + C;
		[0x3A] = A;
		X = 0x011C;
	}

	public void L0385D5()
	{
		A = [0x1B93 + X];
		A &= 0xFE00;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		A = [0x3A];
		C = 0;
		A += 0x0002 + C;
		[0x3A] = A;
		X++;
		X++;
		X++;
		X++;
		C = 1; temp = X - 0x012C;

		if (Z == 0)
			return this.L0385D5();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L0385F7()
	{
		P &= ~0x20;
		X = 0x00D4;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x120E];
		A &= 0x00FF;
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0040 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		P |= 0x20;
		A = [0x70024C];
		C = 1; temp = A - [0x70024E];

		if (Z == 0)
			return this.L038627();

		return this.L0386AC();
	}

	public void L038627()
	{
		[0x70024E] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = 0x0000;
	}

	public void L038633()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.L03863C();

		X++;
		return this.L038633();
	}

	public void L03863C()
	{
		C = 0;
		A += 0x0064 + C;
		[0x1125] = X;
		X = 0x0000;
	}

	public void L038646()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.L03864F();

		X++;
		return this.L038646();
	}

	public void L03864F()
	{
		C = 0;
		A += 0x000A + C;
		[0x3C] = A;
		[0x3E] = X;
		X = 0x00B8;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x1125];

		if (Z == 0)
			return this.L038668();

		A--;
	}

	public void L038668()
	{
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		X = 0x00BC;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x3E];
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		X = 0x00C0;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x3C];
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
	}

	public void L0386AC()
	{
		P |= 0x20;
		A = [0x70024D];
		C = 1; temp = A - [0x70024F];

		if (Z == 0)
			return this.L0386B9();

		return;
	}

	public void L0386B9()
	{
		[0x70024F] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = 0x0000;
	}

	public void L0386C5()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.L0386CE();

		X++;
		return this.L0386C5();
	}

	public void L0386CE()
	{
		C = 0;
		A += 0x0064 + C;
		[0x1125] = X;
		X = 0x0000;
	}

	public void L0386D8()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.L0386E1();

		X++;
		return this.L0386D8();
	}

	public void L0386E1()
	{
		C = 0;
		A += 0x000A + C;
		[0x3C] = A;
		[0x3E] = X;
		X = 0x00C4;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x1125];

		if (Z == 0)
			return this.L0386FA();

		A--;
	}

	public void L0386FA()
	{
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		X = 0x00C8;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x3E];
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		X = 0x00CC;
		A = [0x1B93 + X];
		A &= 0xFE00;
		[0x3A] = A;
		A = [0x3C];
		C = 0;
		A += 0x0080 + C;
		C = 0;
		A += 0x0051 + C;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		return;
	}

	public void L0387A6()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0xFFFF;
		[0x11EF] = A;
		A = 0x0000;
		[0x11F1] = A;
		P = Stack.Pop();
	}

	public void L0387B6_Done()
	{
		return;
	}

	public void L0387D7()
	{
		P &= ~0x20;
		A = 0x0014;
		[0x11DD] = A;
		A = 0x0014;
		[0x11DF] = A;
		A = 0x00E4;
		[0x11E3] = A;
		A = 0x0014;
		[0x11E5] = A;
		A = 0x00E4;
		[0x11E7] = A;
		A = 0x00A4;
		[0x11E9] = A;
		A = 0x0014;
		[0x11EB] = A;
		A = 0x00A4;
		[0x11ED] = A;
		return;
	}

	public void L03880A()
	{
		P &= ~0x30;
		A = [0x122A];

		if (Z == 0)
			return this.L038821();

		A = [0x1DDA];
		C = 1; temp = A - 0x0016;

		if (Z == 0)
			return this.L038829();

		A = [0x1DE4];
		A &= 0x00FF;

		if (Z == 1)
			return this.L038829();
	}

	public void L038821()
	{
		A = [0x10ED];
		A &= 0x00FF;

		if (Z == 1)
			return this.L038830();
	}

	public void L038829()
	{
		this.L0387D7();
		return this.L038D64_Done();
	}

	public void L038830()
	{
		A = [0x11C2];
		A &= 0x00FF;

		if (Z == 1)
			return this.L038845();

		A = 0x0070;
		[0x75] = A;
		A = 0x0060;
		[0x77] = A;
		return this.L038A4C();
	}

	public void L038845()
	{
		X = [0x10E1];
		[0x11DB] = X;
		A = X;
		[0x700254] = A;

		if (Z == 1)
			return this.L038855();

		return this.L038A1B();
	}

	public void L038855()
	{
		[0x11DB] = 0;
		A = [0x11EF];
		C = 1; temp = A - 0xFFFF;

		if (Z == 1)
			return this.L038864();

		this.L0387A6();
	}

	public void L038864()
	{
		P |= 0x20;
		P &= ~0x10;
		P &= ~0x20;
		A = 0x0014;
		C = 1; temp = A - [0x11DD];

		if (Z == 1)
			return this.L038899();

		C = 1;
		A -= [0x11DD] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038885();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L03888D();

		A = 0x0004;
		return this.L03888D();
	}

	public void L038885()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L03888D();

		A = 0xFFFC;
	}

	public void L03888D()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DD] + C;
	}

	public void L038899()
	{
		[0x11DD] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		C = 1; temp = A - [0x11DF];

		if (Z == 1)
			return this.L0388CF();

		C = 1;
		A -= [0x11DF] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L0388BB();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L0388C3();

		A = 0x0004;
		return this.L0388C3();
	}

	public void L0388BB()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L0388C3();

		A = 0xFFFC;
	}

	public void L0388C3()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DF] + C;
	}

	public void L0388CF()
	{
		[0x11DF] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00E4;
		C = 1; temp = A - [0x11E3];

		if (Z == 1)
			return this.L038905();

		C = 1;
		A -= [0x11E3] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L0388F1();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L0388F9();

		A = 0x0004;
		return this.L0388F9();
	}

	public void L0388F1()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L0388F9();

		A = 0xFFFC;
	}

	public void L0388F9()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E3] + C;
	}

	public void L038905()
	{
		[0x11E3] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		C = 1; temp = A - [0x11E5];

		if (Z == 1)
			return this.L03893B();

		C = 1;
		A -= [0x11E5] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038927();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L03892F();

		A = 0x0004;
		return this.L03892F();
	}

	public void L038927()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L03892F();

		A = 0xFFFC;
	}

	public void L03892F()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E5] + C;
	}

	public void L03893B()
	{
		[0x11E5] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00E4;
		C = 1; temp = A - [0x11E7];

		if (Z == 1)
			return this.L038971();

		C = 1;
		A -= [0x11E7] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L03895D();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038965();

		A = 0x0004;
		return this.L038965();
	}

	public void L03895D()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038965();

		A = 0xFFFC;
	}

	public void L038965()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E7] + C;
	}

	public void L038971()
	{
		[0x11E7] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00A4;
		C = 1; temp = A - [0x11E9];

		if (Z == 1)
			return this.L0389A7();

		C = 1;
		A -= [0x11E9] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038993();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L03899B();

		A = 0x0004;
		return this.L03899B();
	}

	public void L038993()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L03899B();

		A = 0xFFFC;
	}

	public void L03899B()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E9] + C;
	}

	public void L0389A7()
	{
		[0x11E9] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		C = 1; temp = A - [0x11EB];

		if (Z == 1)
			return this.L0389DD();

		C = 1;
		A -= [0x11EB] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L0389C9();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L0389D1();

		A = 0x0004;
		return this.L0389D1();
	}

	public void L0389C9()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L0389D1();

		A = 0xFFFC;
	}

	public void L0389D1()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11EB] + C;
	}

	public void L0389DD()
	{
		[0x11EB] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00A4;
		C = 1; temp = A - [0x11ED];

		if (Z == 1)
			return this.L038A13();

		C = 1;
		A -= [0x11ED] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L0389FF();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038A07();

		A = 0x0004;
		return this.L038A07();
	}

	public void L0389FF()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038A07();

		A = 0xFFFC;
	}

	public void L038A07()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11ED] + C;
	}

	public void L038A13()
	{
		[0x11ED] = A;
		P |= 0x20;
		return this.L038D64_Done();
	}

	public void L038A1B()
	{
		A = [0x0C + X];
		C = 1;
		A -= [0xC5] - !C;
		[0x00] = A;
		A = [0x0E + X];
		C = 1;
		A -= [0xC7] - !C;
		[0x06] = A;
		A = [0x10 + X];
		C = 1;
		A -= [0xC9] - !C;
		[0x93] = A;
		P |= 0x20;
		this.L01F1CE();
		P &= ~0x20;
		A = [0xB7];
		[0x00] = A;
		A = [0xB9];
		[0x06] = A;
		A = [0xBB];
		[0x93] = A;
		P |= 0x20;
		P |= 0x30;
		this.L01F334();
	}

	public void L038A4C()
	{
		P &= ~0x30;
		A = [0x75];
		C = 1; temp = A - 0x0014;

		if (C == 1)
			return this.L038A58();

		A = 0x0014;
	}

	public void L038A58()
	{
		C = 1; temp = A - 0x00CC;

		if (C == 0)
			return this.L038A60();

		A = 0x00CC;
	}

	public void L038A60()
	{
		[0x75] = A;
		A = [0x77];
		C = 1; temp = A - 0x0014;

		if (C == 1)
			return this.L038A6C();

		A = 0x0014;
	}

	public void L038A6C()
	{
		C = 1; temp = A - 0x00AC;

		if (C == 0)
			return this.L038A74();

		A = 0x00AC;
	}

	public void L038A74()
	{
		[0x77] = A;
		A = [0x75];
		A &= 0x00FF;
		[0x75] = A;
		C = 0;
		A += 0x0004 + C;
		[0x00] = A;
		A = [0x77];
		A &= 0x00FF;
		[0x77] = A;
		C = 0;
		A += 0x0004 + C;
		[0x06] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x00];
		C = 1; temp = A - [0x11DD];

		if (Z == 1)
			return this.L038AC2();

		C = 1;
		A -= [0x11DD] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038AAE();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038AB6();

		A = 0x0004;
		return this.L038AB6();
	}

	public void L038AAE()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038AB6();

		A = 0xFFFC;
	}

	public void L038AB6()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DD] + C;
	}

	public void L038AC2()
	{
		[0x11DD] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		C = 1; temp = A - [0x11DF];

		if (Z == 1)
			return this.L038AF7();

		C = 1;
		A -= [0x11DF] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038AE3();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038AEB();

		A = 0x0004;
		return this.L038AEB();
	}

	public void L038AE3()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038AEB();

		A = 0xFFFC;
	}

	public void L038AEB()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DF] + C;
	}

	public void L038AF7()
	{
		[0x11DF] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x75];
		C = 0;
		A += 0x0014 + C;
		[0x00] = A;
		A = [0x77];
		C = 0;
		A += 0x0004 + C;
		[0x06] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x00];
		C = 1; temp = A - [0x11E3];

		if (Z == 1)
			return this.L038B40();

		C = 1;
		A -= [0x11E3] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038B2C();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038B34();

		A = 0x0004;
		return this.L038B34();
	}

	public void L038B2C()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038B34();

		A = 0xFFFC;
	}

	public void L038B34()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E3] + C;
	}

	public void L038B40()
	{
		[0x11E3] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		C = 1; temp = A - [0x11E5];

		if (Z == 1)
			return this.L038B75();

		C = 1;
		A -= [0x11E5] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038B61();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038B69();

		A = 0x0004;
		return this.L038B69();
	}

	public void L038B61()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038B69();

		A = 0xFFFC;
	}

	public void L038B69()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E5] + C;
	}

	public void L038B75()
	{
		[0x11E5] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x75];
		C = 0;
		A += 0x0014 + C;
		[0x00] = A;
		A = [0x77];
		C = 0;
		A += 0x0014 + C;
		[0x06] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x00];
		C = 1; temp = A - [0x11E7];

		if (Z == 1)
			return this.L038BBE();

		C = 1;
		A -= [0x11E7] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038BAA();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038BB2();

		A = 0x0004;
		return this.L038BB2();
	}

	public void L038BAA()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038BB2();

		A = 0xFFFC;
	}

	public void L038BB2()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E7] + C;
	}

	public void L038BBE()
	{
		[0x11E7] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		C = 1; temp = A - [0x11E9];

		if (Z == 1)
			return this.L038BF3();

		C = 1;
		A -= [0x11E9] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038BDF();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038BE7();

		A = 0x0004;
		return this.L038BE7();
	}

	public void L038BDF()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038BE7();

		A = 0xFFFC;
	}

	public void L038BE7()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E9] + C;
	}

	public void L038BF3()
	{
		[0x11E9] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x75];
		C = 0;
		A += 0x0004 + C;
		[0x00] = A;
		A = [0x77];
		C = 0;
		A += 0x0014 + C;
		[0x06] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x00];
		C = 1; temp = A - [0x11EB];

		if (Z == 1)
			return this.L038C3C();

		C = 1;
		A -= [0x11EB] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038C28();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038C30();

		A = 0x0004;
		return this.L038C30();
	}

	public void L038C28()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038C30();

		A = 0xFFFC;
	}

	public void L038C30()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11EB] + C;
	}

	public void L038C3C()
	{
		[0x11EB] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		C = 1; temp = A - [0x11ED];

		if (Z == 1)
			return this.L038C71();

		C = 1;
		A -= [0x11ED] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L038C5D();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L038C65();

		A = 0x0004;
		return this.L038C65();
	}

	public void L038C5D()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L038C65();

		A = 0xFFFC;
	}

	public void L038C65()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11ED] + C;
	}

	public void L038C71()
	{
		[0x11ED] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x11EF];

		if (Z == 1)
			return this.L038CAB();

		A = [0x11EB];
		C = 1;
		A -= [0x00] - !C;

		if (N == 0)
			return this.L038C89();

		A ^= 0xFFFF;
		A++;
	}

	public void L038C89()
	{
		[0x11EF] = A;

		if (Z == 0)
			return this.L038C93();

		[0x11F1]++;
		Stack.Push(A);
		A = Stack.Pop();
	}

	public void L038C93()
	{
		C = 1; temp = A - 0x0014;

		if (C == 1)
			return this.L038CAB();

		A = [0x118E];
		A &= 0x00FF;

		if (Z == 0)
			return this.L038CAB();

		P &= ~0x20;
		A = 0xEA1D;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L038CAB()
	{
		P &= ~0x20;
		A = [0x11EF];

		if (Z == 0)
			return this.L038CC2();

		A = [0x11E7];
		C = 1; temp = A - 0x00BD;

		if (C == 1)
			return this.L038CC2();

		A = [0x11E9];
		C = 1; temp = A - 0x00B8;

		if (C == 0)
			return this.L038CC5();

	}

	public void L038CC2()
	{
		return this.L038D64_Done();
	}

	public void L038CC5()
	{
		this.L0387B6_Done();
		X = [0x10E1];
		P |= 0x20;
		A = [0x001E + X];
		A &= 0x20;

		if (Z == 1)
			return this.L038CD9();

		return this.L038D64_Done();
	}

	public void L038CD9()
	{
		P &= ~0x20;
		A = [0x04 + X];
		C = 1; temp = A - 0xBE6B;

		if (Z == 1)
			return this.L038CC2();

		C = 0;
		A += 0x0021 + C;
		[0x50] = A;
		A = 0x0008;
		[0x00] = A;
		X = 0x0024;
		Y = [0x11F1];

		if (Z == 1)
			return this.L038CC2();

		A = [0x11F1];
		A++;
		C = 1; temp = A - 0x0006;

		if (Z == 1)
			return this.L038D01();

		[0x11F1] = A;
	}

	public void L038D01()
	{
		A = [(0x50)];
		A &= 0x00FF;
		C = 1; temp = A - 0x0020;

		if (Z == 0)
			return this.L038D10();

		A = 0x0000;
		return this.L038D36();
	}

	public void L038D10()
	{
		A &= 0x00FF;

		if (Z == 0)
			return this.L038D18();

		return this.L038D64_Done();
	}

	public void L038D18()
	{
		C = 1; temp = A - 0x0041;

		if (C == 1)
			return this.L038D23();

		C = 1;
		A -= 0x0041 - !C;
		return this.L038D32();
	}

	public void L038D23()
	{
		C = 1; temp = A - 0x0061;

		if (C == 0)
			return this.L038D2E();

		C = 1;
		A -= 0x0061 - !C;
		return this.L038D32();
	}

	public void L038D2E()
	{
		C = 1;
		A -= 0x0041 - !C;
	}

	public void L038D32()
	{
		C = 0;
		A += 0x00B7 + C;
	}

	public void L038D36()
	{
		[0x3A] = A;
		[0x50]++;
		P |= 0x20;
		A = [0x11E9];
		A = (A >> 8) | (A << 8);
		A = [0x11E7];
		P &= ~0x20;
		C = 0;
		A += [0x00] + C;
		A = [0x00];
		C = 0;
		A += 0x0007 + C;
		[0x00] = A;
		A = [0x1B93 + X];
		A &= 0xFE00;
		A |= [0x3A];
		A = X;
		C = 0;
		A += 0x0004 + C;
		Y--;

		if (Z == 1)
			return this.L038D64_Done();

		X = A;
		return this.L038D01();
	}

	public void L038D64_Done()
	{
		P &= ~0x20;
		return;
	}

	public void L038D6F()
	{
		this.L038D73();
		return;
	}

	public void L038D73()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x20;
		Stack.Push(X);
		A = X;
		X = [0x10DB];
	}

	public void L038D7D()
	{
		C = 1; temp = A - [0x19 + X];

		if (Z == 0)
			return this.L038D83();

		[0x19 + X] = 0;
	}

	public void L038D83()
	{
		C = 1; temp = A - [0x06 + X];

		if (Z == 0)
			return this.L038D89();

		[0x06 + X] = 0;
	}

	public void L038D89()
	{
		C = 1; temp = A - [0x1B + X];

		if (Z == 0)
			return this.L038D90();

		A = X;
		[0x1B + X] = A;
	}

	public void L038D90()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L038D7D();

		X = Stack.Pop();
		Y = [0x02 + X];

		if (Z == 0)
			return this.L038DA7();

		Y = [0x00 + X];
		[0x10DB] = Y;
		A = 0x0000;
		[0x0002 + Y] = A;
		return this.L038DB5_Done();
	}

	public void L038DA7()
	{
		Stack.Push(X);
		A = [0x00 + X];
		X = A;
		[0x00 + Y] = Y;
		C = 1; temp = A - 0x0000;

		if (Z == 1)
			return this.L038DB4();

		[0x02 + X] = X;
	}

	public void L038DB4()
	{
		X = Stack.Pop();
	}

	public void L038DB5_Done()
	{
		A = [0x10DD];
		[0x00 + X] = A;
		[0x10DD] = X;
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L038DC1()
	{
		this.L038DC5();
		return;
	}

	public void L038DC5()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x20;
		Stack.Push(X);
		Stack.Push(Y);
		A = [0x34 + X];
		Y = A;
		P |= 0x20;
		A = [0x7E1CDE + X];

		if (Z == 1)
			return this.L038DDC();

		X = Y;
		[0x7E363E + X] = A;
	}

	public void L038DDC()
	{
		P &= ~0x20;
		Y = Stack.Pop();
		X = Stack.Pop();
		Stack.Push(X);
		A = X;
		X = [0x10DB];
	}

	public void L038DE5()
	{
		C = 1; temp = A - [0x19 + X];

		if (Z == 0)
			return this.L038DEB();

		[0x19 + X] = 0;
	}

	public void L038DEB()
	{
		C = 1; temp = A - [0x06 + X];

		if (Z == 0)
			return this.L038DF1();

		[0x06 + X] = 0;
	}

	public void L038DF1()
	{
		C = 1; temp = A - [0x1B + X];

		if (Z == 0)
			return this.L038DF8();

		A = X;
		[0x1B + X] = A;
	}

	public void L038DF8()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L038DE5();

		X = Stack.Pop();
		Y = [0x02 + X];

		if (Z == 0)
			return this.L038E0F();

		Y = [0x00 + X];
		[0x10DB] = Y;
		A = 0x0000;
		[0x0002 + Y] = A;
		return this.L038E1D_Done();
	}

	public void L038E0F()
	{
		Stack.Push(X);
		A = [0x00 + X];
		X = A;
		[0x00 + Y] = Y;
		C = 1; temp = A - 0x0000;

		if (Z == 1)
			return this.L038E1C();

		[0x02 + X] = X;
	}

	public void L038E1C()
	{
		X = Stack.Pop();
	}

	public void L038E1D_Done()
	{
		A = [0x10DD];
		[0x00 + X] = A;
		[0x10DD] = X;
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L038EA8()
	{
		Stack.Push(P);
		P &= ~0x30;
		[0x1DC6] = 0;
		X = [0x10DB];

		if (Z == 0)
			return this.L038EB5();

		P = Stack.Pop();
		return;
	}

	public void L038EB5()
	{
		Y = 0x0000;
	}

	public void L038EB8()
	{
		Stack.Push(X);
		A = [0x002C + X];
		A &= 0x0004;

		if (Z == 0)
			return this.L038F05();

		A = [0x1D + X];
		A &= 0x0010;

		if (Z == 0)
			return this.L038F05();

		A = [0x28 + X];
		A &= 0x00FF;

		if (Z == 1)
			return this.L038F05();

		A = [0x08 + X];
		temp = A & 0x0001;

		if (Z == 0)
			return this.L038F05();

		Stack.Push(X);
		A = [0x04 + X];
		X = Y;
		Y = A;
		A = Stack.Pop();
		[0x7EDBB2 + X] = A;
		A = [0x000D + Y];
		[0x7EDBB4 + X] = A;
		A = [0x000F + Y];
		[0x7EDBB6 + X] = A;
		A = [0x0011 + Y];
		[0x7EDBB8 + X] = A;
		A = [0x0013 + Y];
		[0x7EDBBA + X] = A;
		[0x1DC6]++;
		A = X;
		C = 0;
		A += 0x000A + C;
		Y = A;
	}

	public void L038F05()
	{
		X = Stack.Pop();
		A = [0x00 + X];
		X = A;

		if (Z == 0)
			return this.L038EB8();

		P = Stack.Pop();
		return;
	}

	public void L0394BE()
	{
		C = 1; temp = A - 0x0000;

		if (Z == 1)
			return this.L0394E5_Done();

		[0x3A] = X;
		X = [0x112A];

		if (Z == 1)
			return this.L0394E1_Done();

		Y = X;
	}

	public void L0394CB()
	{
		C = 1; temp = A - [0x04 + X];

		if (Z == 1)
			return this.L0394D4();

	}

	public void L0394CF()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L0394CB();

	}

	public void L0394D4()
	{
		C = 1; temp = X - [0x3A];

		if (Z == 1)
			return this.L0394CF();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = X;
		X = [0x3A];
		return;
	}

	public void L0394E1_Done()
	{
		Y = 0x0000;
		return;
	}

	public void L0394E5_Done()
	{
		Y = [0x112A];
		A = [0x00 + X];
		[0x112A] = A;
		return;
	}

	public void L039551()
	{
		C = 1; temp = A - 0x0000;

		if (Z == 1)
			return this.L039591();

		[0x02] = X;
		X = [0x112A];

		if (Z == 1)
			return this.L03958D_Done();

		[0x08] = A;
		[0x3C] = 0;
	}

	public void L039561()
	{
		C = 1; temp = X - [0x02];

		if (Z == 1)
			return this.L03957E();

		A = [0x04 + X];
		C = 1; temp = A - [0x08];

		if (Z == 0)
			return this.L03957E();

		Y = [0x02];
		this.L039CC4();
		P &= ~0x20;
		A = [0x1115];
		C = 1; temp = A - [0x3A];

		if (N == 0)
			return this.L03957E();

		[0x3A] = A;
		[0x3C] = X;
	}

	public void L03957E()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L039561();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = [0x3C];
		X = [0x02];
		return;
	}

	public void L03958D_Done()
	{
		Y = 0x0000;
		return;
	}

	public void L039591()
	{
		[0x02] = X;
		X = [0x112A];

		if (Z == 1)
			return this.L039604_Done();

		[0x3C] = 0;
		[0x1125] = 0;
	}

	public void L03959D()
	{
		C = 1; temp = X - [0x02];

		if (Z == 1)
			return this.L0395F3();

		P |= 0x20;
		A = [0x001E + X];
		A &= [0x3F];

		if (Z == 1)
			return this.L0395F3();

		P &= ~0x20;
		Y = [0x02];
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		this.L039CC4();
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = [0x00];
		A ^= 0xFFFF;
		A++;
		[0x00] = A;
		this.L03E8FD();
		P &= ~0x20;
		Y = [0x02];
		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		P |= 0x20;
		C = 1;
		A -= [0x0013 + Y] - !C;

		if (N == 0)
			return this.L0395D9();

		A ^= 0xFF;
		A++;
	}

	public void L0395D9()
	{
		C = 1; temp = A - [0x0E];

		if (C == 1)
			return this.L0395E2();

		[0x0E] = A;
		[0x1125] = X;
	}

	public void L0395E2()
	{
		C = 1; temp = A - 0x19;

		if (C == 1)
			return this.L0395F3();

		P &= ~0x20;
		A = [0x1115];
		C = 1; temp = A - [0x3A];

		if (C == 1)
			return this.L0395F3();

		[0x3A] = A;
		[0x3C] = X;
	}

	public void L0395F3()
	{
		P &= ~0x20;
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.L03959D();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = [0x3C];
		X = [0x02];
		return;
	}

	public void L039604_Done()
	{
		Y = 0x0000;
		return;
	}

	public void L039A6B()
	{
		[0x3A] = X;
		[0x3C] = Y;
		Stack.Push(P);
		P |= 0x10;
		X = A;
		A = [0x9FDD + X];
		[0x199B] = A;
		A = [0xA01D + X];
		[0x199C] = A;
		A = [0x00];
		[0x66] = A;
		A = [0x01];
		[0x67] = A;
		A = [0x199B];
		[0x68] = A;
		this.L03E880();
		A = [0x69];
		[0x1997] = A;
		A = [0x6A];
		[0x1998] = A;
		A = [0x93];
		[0x66] = A;
		A = [0x94];
		[0x67] = A;
		A = [0x199C];
		[0x68] = A;
		this.L03E880();
		A = [0x69];
		C = 0;
		A += [0x1997] + C;
		[0x1997] = A;
		A = [0x6A];
		A += [0x1998] + C;
		[0x1998] = A;
		A = [0x93];
		[0x66] = A;
		A = [0x94];
		[0x67] = A;
		A = [0x199B];
		[0x68] = A;
		this.L03E880();
		A = [0x69];
		[0x02] = A;
		A = [0x6A];
		[0x03] = A;
		A = [0x00];
		[0x66] = A;
		A = [0x01];
		[0x67] = A;
		A = [0x199C];
		[0x68] = A;
		this.L03E880();
		A = [0x69];
		C = 1;
		A -= [0x02] - !C;
		[0x02] = A;
		A = [0x6A];
		A -= [0x03] - !C;
		[0x03] = A;
		P = Stack.Pop();
		Y = [0x3C];
		X = [0x3A];
		return;
	}

	public void L039CC4()
	{
		P &= ~0x20;
		A = [0x000C + Y];
		C = 1;
		A -= [0x0C + X] - !C;
		[0x00] = A;

		if (N == 0)
			return this.L039CD6();

		A = 0x0000;
		C = 1;
		A -= [0x00] - !C;
	}

	public void L039CD6()
	{
		[0x1115] = A;
		A = [0x0010 + Y];
		C = 1;
		A -= [0x10 + X] - !C;
		[0x06] = A;

		if (N == 1)
			return this.L039CE9();

		C = 0;
		A += [0x1115] + C;
		return this.L039CEF_Done();
	}

	public void L039CE9()
	{
		C = 1;
		A = [0x1115];
		A -= [0x06] - !C;
	}

	public void L039CEF_Done()
	{
		[0x1115] = A;
		P |= 0x20;
		return;
	}

	public void L039DFF()
	{
		this.L039E06();
		this.L039E27();
		return;
	}

	public void L039E06()
	{
		P &= ~0x30;
		A = [0x1DDA];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B + X];
		[0x70024A] = A;
		A = 0x0000;
		[0x700246] = A;
		A = [0x039D21 + X];
		[0x1DD8] = A;
		P |= 0x20;
		return;
	}

	public void L039E27()
	{
		P &= ~0x30;
		A = [0x1DEB];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B + X];
		[0x700248] = A;
		A = 0x0000;
		[0x700244] = A;
		A = [0x039D21 + X];
		[0x1DE9] = A;
		P |= 0x20;
		return;
	}

	public void L039E48()
	{
		P |= 0x20;
		A = 0x0A;
		[0x1DE4] = A;
		A = 0x32;
		[0x1DE5] = A;
		A = 0x63;
		[0x1DF5] = A;
		A = 0x32;
		[0x1DF6] = A;
		P &= ~0x20;
		return;
	}

	public void L039E61()
	{
		P |= 0x20;
		A = [0x1186];
		C = 1; temp = A - 0x00;

		if (Z == 0)
			return this.L039EA4_Done();

		A = [0x1DDC];
		A++;
		C = 1; temp = A - [0x1DDE];

		if (Z == 0)
			return this.L039E75();

		A = 0x00;
	}

	public void L039E75()
	{
		C = 1; temp = A - [0x1DDC];

		if (Z == 1)
			return this.L039EA4_Done();

		[0x1DDC] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x1DDF + X];
		[0x1DDA] = A;
		this.L039E06();
		P &= ~0x20;
		A = [0x1DD8];
		X = [0x11A0];
		[0x04 + X] = A;
		A = [0x1DDA];
		this.L039EED();
		this.L03840A();
		P |= 0x20;
	}

	public void L039EA4_Done()
	{
		return;
	}

	public void L039EA5()
	{
		P |= 0x20;
		A = [0x1DED];
		A++;
		C = 1; temp = A - [0x1DEF];

		if (Z == 0)
			return this.L039EB2();

		A = 0x00;
	}

	public void L039EB2()
	{
		C = 1; temp = A - [0x1DED];

		if (Z == 1)
			return this.L039EEC_Done();

		[0x1DED] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x1DF0 + X];
		[0x1DEB] = A;
		this.L039E27();
		P &= ~0x20;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0000;

		if (Z == 0)
			return this.L039EE0();

		A = [0x1DE9];
		X = [0x11A2];
		[0x04 + X] = A;
	}

	public void L039EE0()
	{
		A = [0x1DEB];
		this.L039EED();
		this.L03840A();
		P |= 0x20;
	}

	public void L039EEC_Done()
	{
		return;
	}

	public void L039EED()
	{
		P &= ~0x20;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x039D20 + X];
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039DEB + X];
		[0x700222] = A;
		A = [0x039DED + X];
		[0x700220] = A;
		A = 0x0010;
		[0x70021E] = A;
		P |= 0x20;
		return;
	}

	public void L039F42()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		[0x1129] = 0;
		[0x10FE] = X;
		A = [0x001E + X];
		A &= 0x08;

		if (Z == 0)
			return this.L039F58();

		return this.L039F7C();
	}

	public void L039F58()
	{
		A = [0x11B5];

		if (Z == 0)
			return this.L039F69();

		A = [0x118E];

		if (Z == 1)
			return this.L039F7C();

		A = [0x1216];

		if (Z == 0)
			return this.L039F7C();

		P = Stack.Pop();
		return;
	}

	public void L039F69()
	{
		A = [0x1216];

		if (Z == 0)
			return this.L039F7C();

		Y = [0x04 + X];
		C = 1; temp = Y - 0xCAE7;

		if (Z == 1)
			return this.L039F7C();

		C = 1; temp = Y - 0xCB11;

		if (Z == 1)
			return this.L039F7C();

		P = Stack.Pop();
		return;
	}

	public void L039F7C()
	{
		A = [0x28 + X];

		if (Z == 0)
			return this.L039F91();

		A = [0x7E1CD1 + X];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CCF + X];

		if (Z == 0)
			return this.L039FDA();

		P |= 0x20;
	}

	public void L039F91()
	{
		A = [0x1D + X];
		temp = A & 0x08;

		if (Z == 1)
			return this.L039FB2();

		A = [0x7E1CD4 + X];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CD2 + X];

		if (Z == 0)
			return this.L039FDA();

		P |= 0x20;
		A = [0x001D + X];
		A &= 0xF7;
		[0x001D + X] = A;
		return this.L039FCF();
	}

	public void L039FB2()
	{
		temp = A & 0x80;

		if (Z == 1)
			return this.L039FCF();

		A = [0x001D + X];
		A &= 0x7F;
		[0x001D + X] = A;
		A = [0x7E1CD7 + X];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CD5 + X];

		if (Z == 0)
			return this.L039FDA();

		P |= 0x20;
	}

	public void L039FCF()
	{
		A = [0x18 + X];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x16 + X];

		if (Z == 1)
			return this.L03A003_Done();

	}

	public void L039FDA()
	{
		[0x1104] = A;
		P |= 0x20;
		A = [0x002C + X];
		A &= 0xFB;
		[0x002C + X] = A;
		A = 0x03;
		Stack.Push(A);
		P &= ~0x20;
		A = 0x9FFD;
		Stack.Push(A);
		P |= 0x20;
		A = [0x1106];
		Stack.Push(A);
		P &= ~0x20;
		A = [0x1104];
		A--;
		Stack.Push(A);
		return;
	}

	public void L03A003_Done()
	{
		P = Stack.Pop();
		return;
	}

	public void L03A054()
	{
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0xFFFF;
		[0x34 + X] = A;
		A = 0x0000;
		[0x24 + X] = A;
		[0x19 + X] = A;
		[0x06 + X] = A;
		[0x7E1CD5 + X] = A;
		[0x7E1CD9 + X] = A;
		P |= 0x20;
		[0x7E1CDC + X] = A;
		[0x7E1CDB + X] = A;
		[0x1F + X] = A;
		[0x20 + X] = A;
		[0x21 + X] = A;
		[0x22 + X] = A;
		[0x09 + X] = A;
		[0x08 + X] = A;
		[0x15 + X] = A;
		[0x1D + X] = A;
		[0x1E + X] = A;
		[0x2C + X] = A;
		[0x33 + X] = A;
		[0x36 + X] = A;
		[0x37 + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x2D + X] = A;
		[0x2F + X] = A;
		[0x31 + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x12 + X] = A;
		[0x13 + X] = A;
		[0x14 + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x0C + X] = A;
		[0x0E + X] = A;
		[0x10 + X] = A;
		P |= 0x20;
		A = [0x0008 + X];
		A |= 0x10;
		[0x0008 + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x0016 + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x0018 + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CD2 + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD4 + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CCF + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD1 + X] = A;
		A = 0x00;
		[0x28 + X] = A;
		A = 0x00;
		[0x29 + X] = A;
		A = [0x002C + X];
		A |= 0x04;
		[0x002C + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		return;
	}

	public void L03A102()
	{
		P &= ~0x20;
		Y = X;
		X = [0x10DD];

		if (Z == 0)
			return this.L03A110();

		P |= 0x20;
		X = Y;
		return this.L03A137_Done();
	}

	public void L03A110()
	{
		A = [0x00 + X];
		[0x10DD] = A;
		A = Y;

		if (Z == 0)
			return this.L03A124();

		A = [0x10DB];
		[0x00 + X] = A;
		[0x02 + X] = 0;
		[0x10DB] = X;
		return this.L03A12D();
	}

	public void L03A124()
	{
		A = [0x0000 + Y];
		[0x00 + X] = A;
		[0x00 + Y] = Y;
		[0x02 + X] = X;
	}

	public void L03A12D()
	{
		Y = [0x00 + X];

		if (Z == 1)
			return this.L03A133_Done();

		[0x02 + Y] = Y;
	}

	public void L03A133_Done()
	{
		P |= 0x20;
		C = 1;
		return;
	}

	public void L03A137_Done()
	{
		P &= ~0x20;
		[0x127B]++;
		P |= 0x20;
		C = 0;
		return;
	}

	public void L03A17D_ResetSound()
	{
		P &= ~0x20;
		A = 0x012C;
		[0x1AEE] = A;
		[0x1AE8] = 0;
		[0x1AEA] = 0;
		[0x1AEC] = 0;
		[0x10E1] = 0;
		[0x11DB] = 0;
		X = [0x10FC];
		A = [0x0C + X];
		[0xC5] = A;
		A = [0x0E + X];
		[0xC7] = A;
		A = [0x10 + X];
		C = 0;
		A += 0xF830 + C;
		[0xC9] = A;
		[0x11B9] = 0;
		A = 0x0000;
		[0x11B7] = A;
		P |= 0x20;
		[0x112D] = 0;
		[0x11BD] = 0;
		[0x11BE] = 0;
		[0x118C] = 0;
		A = 0x28;
		P |= 0x20;
		[0x1186] = 0;
		[0x1187] = 0;
		A = [0x1186];
		this.L03A3B4();
		P |= 0x20;
		P &= ~0x10;
		[0x1130] = 0;
		this.L03A5C3_UpdateSound();
		this.L03A1E2();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L03A1E2()
	{
		P &= ~0x30;
		X = [0x10DB];
		A = X;

		if (Z == 1)
			return this.L03A205_Done();

	}

	public void L03A1EA()
	{
		[0x1108] = 0;
		this.L039F42();
		A = [0x1108];

		if (Z == 0)
			return this.L03A1FD();

		Y = [0x00 + X];
	}

	public void L03A1F8()
	{
		X = Y;

		if (Z == 0)
			return this.L03A1EA();

		return this.L03A205_Done();
	}

	public void L03A1FD()
	{
		Y = [0x00 + X];
		this.L038D6F();
		return this.L03A1F8();
	}

	public void L03A205_Done()
	{
		return;
	}

	public void L03A3B4()
	{
		Stack.Push(X);
		Stack.Push(Y);
		P &= ~0x20;
		A &= 0x00FF;
		C = 1; temp = A - 0x0001;

		if (Z == 0)
			return this.L03A3CD();

		Stack.Push(A);
		X = [0x10FC];
		A = [0x0E + X];
		C = 1;
		A -= 0x005D - !C;
		[0x0E + X] = A;
		A = Stack.Pop();
	}

	public void L03A3CD()
	{
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x03A206 + X];
		[0x7E3291] = A;
		A = [0x03A208 + X];
		[0x7E3293] = A;
		A = [0x03A20A + X];
		[0x7E3295] = A;
		P |= 0x20;
		A = [0x03A20C + X];
		[0x1194] = A;
		A = [0x03A20D + X];
		[0x1195] = A;
		A = [0x03A20E + X];
		[0x1196] = A;
		A = [0x03A20F + X];
		[0x1197] = A;
		A = [0x03A210 + X];
		[0x119A] = A;
		A = [0x03A211 + X];
		[0x119B] = A;
		A = [0x03A212 + X];
		Stack.Push(X);
		X = [0x10FC];
		A |= 0x80;
		[0x7E1CDC + X] = A;
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x03A214 + X];
		C = 1; temp = A - [0x11A6];

		if (Z == 1)
			return this.L03A436();

		[0x11A6] = A;
		[0x11A4] = A;
	}

	public void L03A436()
	{
		P |= 0x20;
		this.L03840A();
		Y = Stack.Pop();
		X = Stack.Pop();
		[0x1DFC] = 0;
		A = [0x1186];
		C = 1; temp = A - 0x06;

		if (Z == 1)
			return this.L03A45B();

		C = 1; temp = A - 0x05;

		if (Z == 1)
			return this.L03A45B();

		C = 1; temp = A - 0x04;

		if (Z == 1)
			return this.L03A45B();

		C = 1; temp = A - 0x00;

		if (Z == 1)
			return this.L03A45B();

		this.L03A4FD();
		this.L03A51A();
		return;
	}

	public void L03A45B()
	{
		this.L03A537();
		this.L03A554();
		return;
	}

	public void L03A479()
	{
		this.L03A485();
		return;
	}

	public void L03A47D()
	{
		this.L03A481();
		return;
	}

	public void L03A481()
	{
		Stack.Push(A);
		return this.L03A49E();
	}

	public void L03A485()
	{
		Stack.Push(A);
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = 0x01;
		C = 1; temp = X - 0x0000;

		if (Z == 1)
			return this.L03A499();

	}

	public void L03A495()
	{
		A <<= 1;
		X--;

		if (Z == 0)
			return this.L03A495();

	}

	public void L03A499()
	{
		A &= [0x11D8];

		if (Z == 1)
			return this.L03A4F9();

	}

	public void L03A49E()
	{
		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L03A4B4();

		P &= ~0x20;
		X = [0x10FC];
		A = [0x0E + X];
		C = 0;
		A += 0x005D + C;
		[0x0E + X] = A;
		P |= 0x20;
	}

	public void L03A4B4()
	{
		A = [0x1186];
		C = 1; temp = A - 0x04;

		if (C == 1)
			return this.L03A4F9();

		A <<= 1;
		A <<= 1;
		A <<= 1;
		P &= ~0x20;
		A &= 0x00FF;
		[0x00] = A;
		P |= 0x20;
		A = Stack.Pop();
		A <<= 1;
		P &= ~0x20;
		A &= 0x00FF;
		C = 0;
		A += [0x00] + C;
		X = A;
		A = [0x03A376 + X];

		if (Z == 1)
			return this.L03A4FA();

		A--;
		P |= 0x20;
		[0x1186] = A;
		[0x1187] = A;
		this.L03A3B4();
		[0x10F1] = A;
		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L03A4F0();

		return this.L03A4F6_Done();
	}

	public void L03A4F0()
	{
		[0x1193] = 0;
		[0x1191] = 0;
	}

	public void L03A4F6_Done()
	{
		A = 0x00;
		return;
	}

	public void L03A4F9()
	{
		A = Stack.Pop();
	}

	public void L03A4FA()
	{
		A = 0x60FF;
	}

	public void L03A4FD()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.L03A516_Done();

	}

	public void L03A505()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L03A516_Done();

		A = 0xE035;
		C = 1; temp = A - [0x16 + X];

		if (Z == 0)
			return this.L03A505();

		A = 0xBE6B;
		[0x04 + X] = A;
	}

	public void L03A516_Done()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void L03A51A()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.L03A533_Done();

	}

	public void L03A522()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L03A533_Done();

		A = 0xE182;
		C = 1; temp = A - [0x16 + X];

		if (Z == 0)
			return this.L03A522();

		A = 0xBE6B;
		[0x04 + X] = A;
	}

	public void L03A533_Done()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void L03A537()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.L03A550_Done();

	}

	public void L03A53F()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L03A550_Done();

		A = 0xE035;
		C = 1; temp = A - [0x16 + X];

		if (Z == 0)
			return this.L03A53F();

		A = [0x1DE9];
		[0x04 + X] = A;
	}

	public void L03A550_Done()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void L03A554()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.L03A56D_Done();

	}

	public void L03A55C()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L03A56D_Done();

		A = 0xE182;
		C = 1; temp = A - [0x16 + X];

		if (Z == 0)
			return this.L03A55C();

		A = [0x1DD8];
		[0x04 + X] = A;
	}

	public void L03A56D_Done()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void L03A572()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void L03A576()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void L03A57A()
	{
		A = [0x38];

		if (Z == 0)
			return this.L03A57A();

		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 0)
			return this.L03A576();

	}

	public void L03A585()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void L03A58D()
	{
		A = [0x38];

		if (Z == 0)
			return this.L03A58D();

	}

	public void L03A591()
	{
		A = [0x10C2];
		temp = A & 0x20;

		if (Z == 1)
			return this.L03A5A5();

		A = [0x10C1];
		temp = A & 0x20;

		if (Z == 0)
			return this.L03A5A5();

		this.L02C897_LongFunction();
		return this.L03A591();
	}

	public void L03A5A5()
	{
		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 1)
			return this.L03A585();

	}

	public void L03A5AC()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void L03A5B4()
	{
		A = [0x38];

		if (Z == 0)
			return this.L03A5B4();

		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 0)
			return this.L03A5AC();

		[0x10ED] = 0;
		return;
	}

	public void L03A5C3_UpdateSound()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x121B];

		if (Z == 1)
			return this.L03A5CF();

		[0x121B]--;
	}

	public void L03A5CF()
	{
		A = [0x1AD1];

		if (Z == 1)
			return this.L03A61C();

		X = [0x10FC];
		P &= ~0x20;
		A = [0x04 + X];
		C = 1; temp = A - 0xCD40;
		P |= 0x20;

		if (Z == 1)
			return this.L03A61C();

		P &= ~0x20;
		[0x24 + X]--;
		P |= 0x20;

		if (Z == 1)
			return this.L03A5EE();

		return this.L03A61C();
	}

	public void L03A5EE()
	{
		P &= ~0x20;
		A = 0x0064;
		[0x24 + X] = A;
		P |= 0x20;
		A = [0x1186];
		A++;
		C = 1; temp = A - 0x04;

		if (Z == 0)
			return this.L03A617();

		P &= ~0x20;
		A = [0x10B9];
		C = 0;
		A += 0x0008 + C;
		C = 1; temp = A - 0x0018;

		if (Z == 0)
			return this.L03A610();

		A = 0x0000;
	}

	public void L03A610()
	{
		[0x10B9] = A;
		P |= 0x20;
		A = 0x00;
	}

	public void L03A617()
	{
		Stack.Push(X);
		this.L03A485();
		X = Stack.Pop();
	}

	public void L03A61C()
	{
		A = [0x9E];
		C = 1; temp = A - 0x00;

		if (Z == 1)
			return this.L03A625();

		return this.L03A901();
	}

	public void L03A625()
	{
		A = [0x1186];
		C = 1; temp = A - [0x1187];

		if (Z == 1)
			return this.L03A64C();

		A = [0x1187];
		[0x1186] = A;
		this.L03A3B4();
		A = [0x1ABF];

		if (Z == 0)
			return this.L03A64C();

		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L03A64C();

		A = 0x40;
		[0x1193] = A;
		A = 0x03;
		[0x1191] = A;
	}

	public void L03A64C()
	{
		A = [0x1AD1];

		if (Z == 1)
			return this.L03A654();

		return this.L03AE3E_Done();
	}

	public void L03A654()
	{
		A = [0x10BC];
		A &= 0x10;

		if (Z == 0)
			return this.L03A65F();

		return this.L03A687();
	}

	public void L03A65F()
	{
		A = [0x1188];
		A &= 0x10;

		if (Z == 1)
			return this.L03A66A();

		return this.L03A687();
	}

	public void L03A66A()
	{
		P &= ~0x20;
		A = [0x1982];
		C = 1; temp = A - 0x0028;
		P |= 0x20;

		if (N == 1)
			return this.L03A687();

		A = [0x1216];

		if (Z == 0)
			return this.L03A687();

		X = [0x116C];
		A = [0x28 + X];

		if (Z == 1)
			return this.L03A687();

		A = 0xFF;
		[0x10ED] = A;
	}

	public void L03A687()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 0)
			return this.L03A692();

		return this.L03A6E2();
	}

	public void L03A692()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.L03A69D();

		return this.L03A6BA();
	}

	public void L03A69D()
	{
		A = [0x1188];
		A &= 0x40;

		if (Z == 1)
			return this.L03A6A8();

		return this.L03A6BA();
	}

	public void L03A6A8()
	{
		this.L039E61();
		P &= ~0x20;
		A = 0xEA28;
		this.L029213_SendApuCommand();
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A6BA()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.L03A6C5();

		return this.L03A6E2();
	}

	public void L03A6C5()
	{
		A = [0x1189];
		A &= 0x80;

		if (Z == 1)
			return this.L03A6D0();

		return this.L03A6E2();
	}

	public void L03A6D0()
	{
		this.L039EA5();
		P &= ~0x20;
		A = 0xEA28;
		this.L029213_SendApuCommand();
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A6E2()
	{
		A = 0x03;
		C = 1; temp = A - [0x1186];

		if (Z == 1)
			return this.L03A6EC();

		return this.L03A70A();
	}

	public void L03A6EC()
	{
		A = [0x10BE];
		A &= 0x30;
		C = 1; temp = A - 0x30;

		if (Z == 1)
			return this.L03A6F9();

		return this.L03A70A();
	}

	public void L03A6F9()
	{
		A = [0x1189];
		A &= 0x30;
		C = 1; temp = A - 0x30;

		if (Z == 0)
			return this.L03A706();

		return this.L03A70A();
	}

	public void L03A706()
	{
		this.L02C4B1();
	}

	public void L03A70A()
	{
		A = [0x10BC];
		A &= 0x20;

		if (Z == 0)
			return this.L03A715();

		return this.L03A764();
	}

	public void L03A715()
	{
		A = [0x1188];
		A &= 0x20;

		if (Z == 1)
			return this.L03A720();

		return this.L03A764();
	}

	public void L03A720()
	{
		A = 0x03;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A731();

	}

	public void L03A727()
	{
		A = [0x11D8];
		temp = A & 0x01;

		if (Z == 1)
			return this.L03A738();

		return this.L03A798();
	}

	public void L03A731()
	{
		A = 0x00;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A742();
	}

	public void L03A738()
	{
		A = [0x11D8];
		temp = A & 0x02;

		if (Z == 1)
			return this.L03A749();

		return this.L03A7F9();
	}

	public void L03A742()
	{
		A = 0x01;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A753();
	}

	public void L03A749()
	{
		A = [0x11D8];
		temp = A & 0x04;

		if (Z == 1)
			return this.L03A75A();

		return this.L03A85A();
	}

	public void L03A753()
	{
		A = 0x02;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A764();
	}

	public void L03A75A()
	{
		A = [0x11D8];
		temp = A & 0x08;

		if (Z == 1)
			return this.L03A727();

		return this.L03A8BA();
	}

	public void L03A764()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 1)
			return this.L03A76F();

		return this.L03A782();
	}

	public void L03A76F()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.L03A77A();

		return this.L03A901();
	}

	public void L03A77A()
	{
		A = [0x118E];

		if (Z == 1)
			return this.L03A782();

		return this.L03A901();
	}

	public void L03A782()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.L03A78D();

		return this.L03A7E3();
	}

	public void L03A78D()
	{
		A = [0x1188];
		A &= 0x40;

		if (Z == 1)
			return this.L03A798();

		return this.L03A7E3();
	}

	public void L03A798()
	{
		A = 0x00;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A7A2();

		return this.L03A901();
	}

	public void L03A7A2()
	{
		this.L03A485();

		if (Z == 1)
			return this.L03A7AA();

		return this.L03A901();
	}

	public void L03A7AA()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA80;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x07EB;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A7E3()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.L03A7EE();

		return this.L03A844();
	}

	public void L03A7EE()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.L03A7F9();

		return this.L03A844();
	}

	public void L03A7F9()
	{
		A = 0x01;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A803();

		return this.L03A901();
	}

	public void L03A803()
	{
		this.L03A485();

		if (Z == 1)
			return this.L03A80B();

		return this.L03A901();
	}

	public void L03A80B()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA84;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x07FB;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A844()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.L03A84F();

		return this.L03A8A4();
	}

	public void L03A84F()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.L03A85A();

		return this.L03A8A4();
	}

	public void L03A85A()
	{
		A = 0x02;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A864();

		return this.L03A901();
	}

	public void L03A864()
	{
		this.L03A485();

		if (Z == 1)
			return this.L03A86C();

		return this.L03A901();
	}

	public void L03A86C()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA83;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x0811;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A8A4()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.L03A8AF();

		return this.L03A901();
	}

	public void L03A8AF()
	{
		A = [0x1189];
		A &= 0x80;

		if (Z == 1)
			return this.L03A8BA();

		return this.L03A901();
	}

	public void L03A8BA()
	{
		A = 0x03;
		C = 1; temp = A - [0x1186];

		if (Z == 0)
			return this.L03A8C4();

		return this.L03A901();
	}

	public void L03A8C4()
	{
		this.L03A485();

		if (Z == 0)
			return this.L03A901();

		P &= ~0x20;
		A = 0xEA27;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA80;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x082B;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
		return this.L03A901();
	}

	public void L03A901()
	{
		A = [0x1186];
		C = 1; temp = A - 0x02;

		if (Z == 1)
			return this.L03A917();

		C = 1; temp = A - 0x06;

		if (Z == 1)
			return this.L03A917();

		C = 1; temp = A - 0x00;

		if (Z == 1)
			return this.L03A917();

		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L03A917();

		return this.L03AABA_Skip();
	}

	public void L03A917()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 1)
			return this.L03A922();

		return this.L03AABA_Skip();
	}

	public void L03A922()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.L03A92D();

		return this.L03AABA_Skip();
	}

	public void L03A92D()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.L03A938();

		return this.L03AABA_Skip();
	}

	public void L03A938()
	{
		A = [0x1191];

		if (N == 0)
			return this.L03A940();

		return this.L03AA43();
	}

	public void L03A940()
	{
		A = [0x127A];
		P &= ~0x20;
		A &= 0x00FF;
		Stack.Push(X);
		X = A;
		A = [0x0AFDB5 + X];
		X = Stack.Pop();
		P |= 0x20;
		A &= 0xFF;

		if (Z == 1)
			return this.L03A9B1();

		A = [0x11B5];

		if (Z == 0)
			return this.L03A9B1();

		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L03A9B4();

		A = [0x7E328E];

		if (N == 1)
			return this.L03A969();


		if (Z == 0)
			return this.L03A9B1();

	}

	public void L03A969()
	{
		A = 0x14;
		[0x7E328E] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.L03A986();

		X = [0x10FC];
		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;
		C = 1; temp = A - 0x80;

		if (C == 0)
			return this.L03A986();

		A = 0xEC;
		[0x7E328E] = A;
	}

	public void L03A986()
	{
		P &= ~0x20;
		A = 0xEA1B;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x08DB;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
	}

	public void L03A9B1()
	{
		return this.L03AABA_Skip();
	}

	public void L03A9B4()
	{
		A = [0x1ABF];

		if (Z == 0)
			return this.L03A9B1();

		P &= ~0x20;
		A = [0x118A];
		C = 1; temp = A - 0x0000;
		P |= 0x20;

		if (Z == 0)
			return this.L03A9C8();

		return this.L03AABA_Skip();
	}

	public void L03A9C8()
	{
		A = [0x1ABB];

		if (Z == 1)
			return this.L03A9DC();

		A = [0x1278];

		if (Z == 0)
			return this.L03A9DC();

		A = [0x127A];
		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L03A9DC();

		return this.L03AABA_Skip();
	}

	public void L03A9DC()
	{
		X = [0x10FC];
		P &= ~0x20;
		A = [0x1175];
		C = 1; temp = A - [0x0E + X];

		if (Z == 1)
			return this.L03A9F5();

		C = 0;
		A += 0x0014 + C;
		C = 1; temp = A - [0x0E + X];

		if (N == 1)
			return this.L03A9F5();

		P |= 0x20;
		return this.L03AABA_Skip();
	}

	public void L03A9F5()
	{
		P &= ~0x20;
		Stack.Push(X);
		A = [0x1186];
		A &= 0x00FF;
		X = 0xEA1A;
		C = 1; temp = A - 0x0002;

		if (Z == 0)
			return this.L03AA09_Skip();

		X = 0xEA1B;
	}

	public void L03AA09_Skip()
	{
		A = X;
		this.L029213_SendApuCommand();
		X = Stack.Pop();
		P |= 0x20;
		A = 0x01;
		[0x11AB] = A;
		A = 0x0C;
		[0x11C9] = A;
		A = [0x1186];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L03AA2F_Skip();

		P &= ~0x20;
		A = 0xFFCE;
		[0x11A8] = A;
		P |= 0x20;
		return this.L03AABA_Skip();
	}

	public void L03AA2F_Skip()
	{
		A = 0x04;
		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.L03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		return this.L03AABA_Skip();
	}

	public void L03AA43()
	{
		A = [0x1186];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L03AA4D();

		return this.L03AABA_Skip();
	}

	public void L03AA4D()
	{
		A = [0x127A];
		P &= ~0x20;
		A &= 0x00FF;
		Stack.Push(X);
		X = A;
		A = [0x0AFDB5 + X];
		X = Stack.Pop();
		P |= 0x20;
		A &= 0xFF;

		if (Z == 1)
			return this.L03AA64();

		return this.L03AA67();
	}

	public void L03AA64()
	{
		return this.L03AABA_Skip();
	}

	public void L03AA67()
	{
		P &= ~0x20;
		A = [0x118A];
		C = 1; temp = A - 0x0000;
		P |= 0x20;

		if (Z == 1)
			return this.L03AABA_Skip();

		A = [0x1ABF];

		if (Z == 0)
			return this.L03AABA_Skip();

		A = [0x1ABB];

		if (Z == 1)
			return this.L03AA87();

		A = [0x127A];
		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L03AA87();

		return this.L03AA43();
	}

	public void L03AA87()
	{
		X = [0x10FC];
		P &= ~0x20;
		A = [0x000E + X];
		C = 1; temp = A - [0x1175];
		P |= 0x20;

		if (Z == 1)
			return this.L03AA99();

		return this.L03AABA_Skip();
	}

	public void L03AA99()
	{
		P &= ~0x20;
		A = 0xEA1A;
		this.L029213_SendApuCommand();
		P |= 0x20;
		A = 0xFF;
		[0x11AB] = A;
		A = 0x04;
		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.L03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
	}

	public void L03AABA_Skip()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 1)
			return this.L03AAC5_Skip();

		return this.L03AB6C_Skip();
	}

	public void L03AAC5_Skip()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.L03AAD0_Skip();

		return this.L03AB6C_Skip();
	}

	public void L03AAD0_Skip()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.L03AADB_Skip();

		return this.L03AB6C_Skip();
	}

	public void L03AADB_Skip()
	{
		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L03AB33_Skip();

		A = [0x7E328E];

		if (N == 1)
			return this.L03AB30_Skip();

		A = 0xEC;
		[0x7E328E] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.L03AB05_Skip();

		X = [0x10FC];
		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;
		C = 1; temp = A - 0x80;

		if (C == 0)
			return this.L03AB05_Skip();

		A = 0x14;
		[0x7E328E] = A;
	}

	public void L03AB05_Skip()
	{
		P &= ~0x20;
		A = 0xEA1B;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x08F0;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
	}

	public void L03AB30_Skip()
	{
		return this.L03AB6C_Skip();
	}

	public void L03AB33_Skip()
	{
		P &= ~0x20;
		A = [0x1ABF];

		if (Z == 0)
			return this.L03AB44_Skip();

		X = [0x10FC];
		A = [0x0E + X];
		C = 1; temp = A - [0x1175];

		if (Z == 0)
			return this.L03AB6C_Skip();

	}

	public void L03AB44_Skip()
	{
		A = 0x0008;
		[0x11C9] = A;
		A = 0xFFE7;
		[0x11A8] = A;
		A = [0x10F6];
		C = 0;
		A += 0x8000 + C;
		[0x11AC] = A;
		P |= 0x20;
		A = 0x10;
		[0x11AE] = A;
		P &= ~0x20;
		A = 0xEA1C;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L03AB6C_Skip()
	{
		P |= 0x20;
		A = [0x1186];
		C = 1; temp = A - 0x00;

		if (Z == 0)
			return this.L03AB89_Skip();

		A = [0x1DFC];

		if (Z == 1)
			return this.L03AB89_Skip();

		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.L03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
	}

	public void L03AB89_Skip()
	{
		P &= ~0x20;
		A = [0x118A];

		if (Z == 0)
			return this.L03AB97_Skip();

		P |= 0x20;
		X = [0x116C];
		[0x28 + X] = 0;
	}

	public void L03AB97_Skip()
	{
		P |= 0x20;
		A = [0x10EF];
		temp = A & 0x08;

		if (Z == 0)
			return this.L03ABA3_Skip();

		return this.L03AC4F_Skip();
	}

	public void L03ABA3_Skip()
	{
		A = [0x10C0];
		A &= 0x10;

		if (Z == 1)
			return this.L03ABB1_Skip();

		this.L03A572();
		return this.L03AE3E_Done();
	}

	public void L03ABB1_Skip()
	{
		A = [0x10C2];
		A &= 0x10;

		if (Z == 1)
			return this.L03ABC0_Skip();

		A = [0x10EF];
		A |= 0x0F;
		[0x10EF] = A;
	}

	public void L03ABC0_Skip()
	{
		Stack.Push(X);

		A = [0x10C0];
		A &= 0x40;

		if (Z == 1)
			return this.L03ABD6_Skip();

		A = [0x10BF];
		A &= 0x40;

		if (Z == 0)
			return this.L03ABD6_Skip();

		P |= 0x20;
		X = [0x116C];
		[0x28 + X] = 0;
	}

	public void L03ABD6_Skip()
	{
		A = [0x10EF];
		temp = A & 0x10;

		if (Z == 1)
			return this.L03AC11_Skip();

		A = [0x10C0];
		A &= 0x80;

		if (Z == 1)
			return this.L03AC11_Skip();

		A = [0x10BF];
		A &= 0x80;

		if (Z == 0)
			return this.L03AC11_Skip();

		A = [0x1285];

		if (Z == 0)
			return this.L03ABFE_Skip();

		this.L04B41C();

		A = 0xFF;
		[0x1215] = A;
		[0x122E] = A;
		return this.L03AC0D_Skip();
	}

	public void L03ABFE_Skip()
	{
		X = [0x1286];
		[0x28 + X] = 0;
		X = [0x128A];
		[0x28 + X] = 0;
		X = [0x1288];
		[0x28 + X] = 0;
	}

	public void L03AC0D_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void L03AC11_Skip()
	{
		A = [0x10C2];
		A &= 0x40;

		if (Z == 1)
			return this.L03AC27_Skip();

		A = [0x10C1];
		A &= 0x40;

		if (Z == 0)
			return this.L03AC27_Skip();

		A = [0x10EE];
		A ^= 0xFF;
		[0x10EE] = A;
	}

	public void L03AC27_Skip()
	{
		A = [0x10C2];
		A &= 0x80;

		if (Z == 1)
			return this.L03AC4A_Skip();

		A = [0x10C1];
		A &= 0x80;

		if (Z == 0)
			return this.L03AC4A_Skip();

		A = [0x112D];
		A |= 0x08;
		[0x112D] = A;
		A = 0xFF;
		[0x1215] = A;
		[0x1217] = A;
		A = 0x1E;
		[0x1235] = A;
	}

	public void L03AC4A_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();
	}

	public void L03AC4F_Skip()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.L03AC5A_Skip();

		return this.L03AC8E_Skip();
	}

	public void L03AC5A_Skip()
	{
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.L03AC65_Skip();

		return this.L03AC74_Skip();
	}

	public void L03AC65_Skip()
	{
		A = [0x11BD];
		A--;

		if (N == 0)
			return this.L03AC6D_Skip();

		A = 0xFF;
	}

	public void L03AC6D_Skip()
	{
		[0x11BD] = A;
		return this.L03AC91_Skip();
	}

	public void L03AC74_Skip()
	{
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.L03AC7F_Skip();

		return this.L03AC8E_Skip();
	}

	public void L03AC7F_Skip()
	{
		A = [0x11BD];
		A++;

		if (Z == 1)
			return this.L03AC87_Skip();

		A = 0x01;
	}

	public void L03AC87_Skip()
	{
		[0x11BD] = A;
		return this.L03AC91_Skip();
	}

	public void L03AC8E_Skip()
	{
		[0x11BD] = 0;
	}

	public void L03AC91_Skip()
	{
		A = [0x118E];
		C = 1; temp = A - 0x00;

		if (Z == 1)
			return this.L03ACB5_Skip();

		A = [0x10BC];
		A &= 0xEC;

		if (Z == 0)
			return this.L03ACA6_Skip();

		A = [0x10BE];
		A &= 0xC0;

		if (Z == 1)
			return this.L03ACB5_Skip();

	}

	public void L03ACA6_Skip()
	{
		A = [0x1ABF];

		if (Z == 0)
			return this.L03ACB5_Skip();

		A = [0x1216];

		if (Z == 0)
			return this.L03ACB5_Skip();

		A = 0x00;
		[0x118E] = A;
	}

	public void L03ACB5_Skip()
	{
		P &= ~0x20;
		X = [0x10FC];
		A = [0x0C + X];
		[0x113E] = A;
		A = [0x0E + X];
		[0x1140] = A;
		A = [0x10 + X];
		[0x1142] = A;
		P |= 0x20;
		A = [0x10D2];

		if (Z == 0)
			return this.L03ACD5_Skip();

		A = [0x1AD2];

		if (Z == 1)
			return this.L03ACD8_Skip();

	}

	public void L03ACD5_Skip()
	{
		return this.L03AD43_Skip();
	}

	public void L03ACD8_Skip()
	{
		A = [0x1982];
		A &= 0x7F;

		if (Z == 0)
			return this.L03AD0D_Skip();

		X = [0x116C];
		A = [0x28 + X];

		if (Z == 1)
			return this.L03AD0D_Skip();

		C = 1; temp = A - 0x0A;

		if (N == 0)
			return this.L03AD0D_Skip();

		A = [0x1DBA];

		if (Z == 1)
			return this.L03AD0D_Skip();

		P &= ~0x20;
		A = 0x3872;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x14;
		[0x11D4] = A;
		this.L03855E();
		P &= ~0x20;
		A = 0xEA0F;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L03AD0D_Skip()
	{
		P &= ~0x20;
		A = [0x118A];
		C = 1; temp = A - 0x04B0;
		P |= 0x20;

		if (N == 0)
			return this.L03AD43_Skip();

		A = [0x1982];
		C = 0;
		A += 0x0A + C;
		A &= 0x7F;

		if (Z == 0)
			return this.L03AD43_Skip();

		P &= ~0x20;
		A = 0x38AC;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x14;
		[0x11D4] = A;
		this.L03855E();
		P &= ~0x20;
		A = 0xEA0F;
		this.L029213_SendApuCommand();
		P |= 0x20;
		return this.L03AD43_Skip();
	}

	public void L03AD43_Skip()
	{
		A = [0x1219];

		if (Z == 1)
			return this.L03AD62_Skip();

		A--;
		[0x1219] = A;
		C = 1; temp = A - 0x14;

		if (Z == 0)
			return this.L03AD50_Skip();
	}

	public void L03AD50_Skip()
	{
		A = [0x1219];

		if (Z == 1)
			return this.L03AD58_Skip();

		return this.L03ADC0_Skip();
	}

	public void L03AD58_Skip()
	{
		A = [0x112D];
		A |= 0x08;
		[0x112D] = A;
		return this.L03ADC0_Skip();
	}

	public void L03AD62_Skip()
	{
		A = [0x112D];
		temp = A & 0x02;

		if (Z == 0)
			return this.L03AD6D_Skip();

		return this.L03ADC0_Skip();
	}

	public void L03AD6D_Skip()
	{
		P &= ~0x20;
		A = 0x0064;
		[0x3E] = A;
		A = [0x122A];
		A &= 0x00FF;

		if (Z == 1)
			return this.L03AD81_Skip();

		A = 0x0000;
		[0x3E] = A;
	}

	public void L03AD81_Skip()
	{
		P |= 0x20;
		P &= ~0x20;
		A = [0x3E];
		C = 1; temp = A - [0x11B7];

		if (Z == 1)
			return this.L03ADBB_Skip();

		C = 1;
		A -= [0x11B7] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L03AD9F_Skip();

		C = 1; temp = A - 0x0010;

		if (N == 0)
			return this.L03ADA7_Skip();

		A = 0x0010;
		return this.L03ADA7_Skip();
	}

	public void L03AD9F_Skip()
	{
		C = 1; temp = A - 0xFFF0;

		if (N == 1)
			return this.L03ADA7_Skip();

		A = 0xFFF0;
	}

	public void L03ADA7_Skip()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11B7] + C;
	}

	public void L03ADBB_Skip()
	{
		[0x11B7] = A;
		P |= 0x20;
	}

	public void L03ADC0_Skip()
	{
		A = [0x7E328F];

		if (N == 1)
			return this.L03ADEB_Skip();


		if (Z == 0)
			return this.L03ADEB_Skip();

		A = 0xFF;
		[0x7E328F] = A;
		[0x1215] = A;
		[0x122E] = A;
		P &= ~0x20;
		A = 0x3797;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.L03855E();
		this.L04B41C();
	}

	public void L03ADEB_Skip()
	{
		A = [0x001217];

		if (Z == 1)
			return this.L03ADFB_Skip();

		A = [0x1219];

		if (Z == 0)
			return this.L03ADFB_Skip();

		A = 0x14;
		[0x1219] = A;
	}

	public void L03ADFB_Skip()
	{
		A = [0x112D];
		temp = A & 0x08;

		if (Z == 0)
			return this.L03AE3E_Done();

		A = [0x1DBA];

		if (Z == 1)
			return this.L03AE3E_Done();

		A = [0x1219];

		if (Z == 0)
			return this.L03AE3E_Done();

		A = [0x00197E];

		if (Z == 0)
			return this.L03AE3E_Done();

		A = [0x197D];

		if (N == 1)
			return this.L03AE19_Skip();

		return this.L03AE3E_Done();
	}

	public void L03AE19_Skip()
	{
		P &= ~0x20;
		A = 0x0843;
		[0x700222] = A;
		A = 0x0000;
		[0x700220] = A;
		A = 0x000E;
		[0x70021E] = A;
		A = 0x0002;
		[0x70022A] = A;
		P |= 0x20;
		A = 0x14;
		[0x1219] = A;
	}

	public void L03AE3E_Done()
	{
		return;
	}

	public void L03B469()
	{
		Stack.Push(X);
		A = 0x01;
		[0x1190] = A;
		[0x3A] = X;
		this.L03A102();

		if (C == 0)
			return this.L03B479();

		return this.L03B482();
	}

	public void L03B479()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.L03B500();
	}

	public void L03B482()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xCD16;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.L03A054();
		X = [0x10FC];
		P &= ~0x20;
		A = [0x000C + X];
		C = 0;
		A += 0x0000 + C;
		[0x000C + Y] = A;
		A = [0x000E + X];
		C = 0;
		A += 0xFD44 + C;
		[0x000E + Y] = A;
		A = [0x0010 + X];
		C = 0;
		A += 0x0000 + C;
		[0x0010 + Y] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0xBB36;
		[0x0016 + Y] = A;
		P |= 0x20;
		A = 0x09;
		[0x0018 + Y] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CD2 + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD4 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CCF + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD1 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0xCA85;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L03B500()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0x3AA7;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.L03855E();
		return;
	}

	public void L03B515()
	{
		Stack.Push(X);
		A = 0x02;
		[0x1190] = A;
		[0x3A] = X;
		this.L03A102();

		if (C == 0)
			return this.L03B525();

		return this.L03B52E();
	}

	public void L03B525()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.L03B5AC();
	}

	public void L03B52E()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xCD16;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.L03A054();
		X = [0x10FC];
		P &= ~0x20;
		A = [0x000C + X];
		C = 0;
		A += 0x0000 + C;
		[0x000C + Y] = A;
		A = [0x000E + X];
		C = 0;
		A += 0xFD44 + C;
		[0x000E + Y] = A;
		A = [0x0010 + X];
		C = 0;
		A += 0x0000 + C;
		[0x0010 + Y] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0xBB36;
		[0x0016 + Y] = A;
		P |= 0x20;
		A = 0x09;
		[0x0018 + Y] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CD2 + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD4 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0x0000;
		[0x7E1CCF + X] = A;
		P |= 0x20;
		A = 0x00;
		[0x7E1CD1 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0xCA85;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L03B5AC()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0x3AA7;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.L03855E();
		return;
	}

	public void L03E3B5()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.L03E3BF();

		return this.L03E492();
	}

	public void L03E3BF()
	{
		A = [0x1AD2];

		if (Z == 1)
			return this.L03E3C7();

		return this.L03E492();
	}

	public void L03E3C7()
	{
		P &= ~0x20;
		[0x1A08] = 0;
		[0x1A0A] = 0;
		[0x1A0C] = 0;
		A = [0x1AD3];
		A &= 0x00FF;

		if (Z == 0)
			return this.L03E40F();

		A = [0x1926];

		if (N == 1)
			return this.L03E3F1();

		A = 0x0000;
		[0xC5] = A;
		A = 0x0000;
		[0xC7] = A;
		A = 0xFE0C;
		[0xC9] = A;
		return this.L03E6D8();
	}

	public void L03E3F1()
	{
		A = [0x11CE];
		[0xC5] = A;
		[0x7000D8] = A;
		A = [0x11D0];
		[0xC7] = A;
		[0x7000DA] = A;
		A = [0x11D2];
		[0xC9] = A;
		[0x7000DC] = A;
		return this.L03E6D8();
	}

	public void L03E40F()
	{
		P |= 0x20;
		P &= ~0x20;
		A = 0xFCAE;
		C = 1; temp = A - [0x11D2];

		if (Z == 1)
			return this.L03E44A();

		C = 1;
		A -= [0x11D2] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L03E42E();

		C = 1; temp = A - 0x0010;

		if (N == 0)
			return this.L03E436();

		A = 0x0010;
		return this.L03E436();
	}

	public void L03E42E()
	{
		C = 1; temp = A - 0xFFF0;

		if (N == 1)
			return this.L03E436();

		A = 0xFFF0;
	}

	public void L03E436()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11D2] + C;
	}

	public void L03E44A()
	{
		[0x11D2] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0xFFB0;
		C = 1; temp = A - [0x11D0];

		if (Z == 1)
			return this.L03E488();

		C = 1;
		A -= [0x11D0] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L03E46C();

		C = 1; temp = A - 0x0010;

		if (N == 0)
			return this.L03E474();

		A = 0x0010;
		return this.L03E474();
	}

	public void L03E46C()
	{
		C = 1; temp = A - 0xFFF0;

		if (N == 1)
			return this.L03E474();

		A = 0xFFF0;
	}

	public void L03E474()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11D0] + C;
	}

	public void L03E488()
	{
		[0x11D0] = A;
		P |= 0x20;
		P &= ~0x20;
		return this.L03E3F1();
	}

	public void L03E492()
	{
		P &= ~0x20;
		A = [0x11CA];
		A <<= 1;
		A <<= 1;
		A = (A >> 8) | (A << 8);
		temp = A & 0x0080;

		if (Z == 1)
			return this.L03E4A4();

		A |= 0xFF00;
		return this.L03E4A7();
	}

	public void L03E4A4()
	{
		A &= 0x00FF;
	}

	public void L03E4A7()
	{
		A ^= 0xFFFF;
		A++;
		C = 0;
		A += 0x00FF + C;
		C = 1; temp = A - 0x00EE;

		if (N == 0)
			return this.L03E4B7();

		A = 0x00EE;
	}

	public void L03E4B7()
	{
		C = 1; temp = A - 0x01B8;

		if (N == 1)
			return this.L03E4BF();

		A = 0x01B8;
	}

	public void L03E4BF()
	{
		A = 0x0110;
		C = 1; temp = A - [0x1B72];

		if (Z == 1)
			return this.L03E4D3();

		[0x1B72] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1B74] = A;
		P &= ~0x20;
	}

	public void L03E4D3()
	{
		[0x10E3] = 0;
		A = [0x112D];
		temp = A & 0x0002;

		if (Z == 1)
			return this.L03E4E4();

		[0x10E1] = 0;
		return this.L03E583();
	}

	public void L03E4E4()
	{
		X = [0x10FC];
		P |= 0x20;
		P &= ~0x20;
		A = [0x10DB];
		[0x112A] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0018;
		[0x3F] = A;
		A = 0x0FA0;
		[0x3A] = A;
		A = 0x001E;
		[0x0E] = A;
		A = 0x0000;
		this.L039551();
		C = 1; temp = Y - 0x0000;
		P |= 0x20;

		if (Z == 0)
			return this.L03E516();

		return this.L03E564();
	}

	public void L03E516()
	{
		P &= ~0x20;
		A = [0x1125];

		if (Z == 1)
			return this.L03E520();

		[0x10E3] = A;
	}

	public void L03E520()
	{
		P |= 0x20;
		C = 1; temp = Y - [0x10FC];

		if (Z == 0)
			return this.L03E52B();

		return this.L03E564();
	}

	public void L03E52B()
	{
		X = Y;
		[0x10E1] = X;
		P &= ~0x20;
		A = [0x3A];
		[0x10E8] = A;
		P &= ~0x20;
		A = [0x1186];
		A &= 0x00FF;
		C = 1; temp = A - 0x0001;

		if (Z == 1)
			return this.L03E569();

		A = [0x1ABF];

		if (Z == 0)
			return this.L03E569();

		P &= ~0x20;
		A = [0x0E + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0xFF4C;

		if (N == 0)
			return this.L03E55A();

		A = 0xFF4C;
		return this.L03E562();
	}

	public void L03E55A()
	{
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L03E562();

		A = 0x0000;
	}

	public void L03E562()
	{
		return this.L03E56C();
	}

	public void L03E564()
	{
		P &= ~0x20;
		[0x10E1] = 0;
	}

	public void L03E569()
	{
		A = 0x0000;
	}

	public void L03E56C()
	{
		Stack.Push(A);
		A <<= 1;
		[0x11B7] = A;
		A = Stack.Pop();
		C = 0;
		A += 0xFF9C + C;
		X = [0x10FC];
		C = 0;
		A += [0x11A6] + C;
		C = 0;
		A += [0x0E + X] + C;
		[0x11D0] = A;
	}

	public void L03E583()
	{
		A = [0x112D];
		A &= 0x0008;

		if (Z == 1)
			return this.L03E58E();

		return this.L03E680();
	}

	public void L03E58E()
	{
		A = [0x1219];
		A &= 0x00FF;

		if (Z == 1)
			return this.L03E599();

		return this.L03E611();
	}

	public void L03E599()
	{
		A = [0x11C2];

		if (Z == 0)
			return this.L03E5A1();

		return this.L03E611();
	}

	public void L03E5A1()
	{
		X = [0x10FC];
		A = [0x0C + X];
		[0xC5] = A;
		[0x11CE] = A;
		A = [0x11A6];
		C = 1;
		A -= 0x0011 - !C;
		A <<= 1;
		[0x3C] = A;
		A = [0x3C];
		C = 1; temp = A - [0x11A4];

		if (Z == 1)
			return this.L03E5CB();

		C = 1;
		A -= [0x11A4] - !C;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11A4] + C;
		[0x11A4] = A;
	}

	public void L03E5CB()
	{
		A = [0x11A4];
		C = 0;
		A += [0x0E + X] + C;
		[0x11D0] = A;
		[0xC7] = A;
		A = [0x10 + X];
		[0xC9] = A;
		[0x11D2] = A;
		A = [0x11C4];

		if (Z == 1)
			return this.L03E5E9();

		A--;
		[0x11C4] = A;
		return this.L03E680();
	}

	public void L03E5E9()
	{
		P |= 0x20;
		A = [0x12 + X];
		A ^= 0xFF;
		A++;
		[0x1A09] = A;
		[0x1A08] = 0;
		A = [0x13 + X];
		A ^= 0xFF;
		A++;
		[0x1A0B] = A;
		[0x1A0A] = 0;
		A = [0x14 + X];
		A ^= 0xFF;
		A++;
		[0x1A0D] = A;
		[0x1A0C] = 0;
		return this.L03E6C4();
	}

	public void L03E611()
	{
		A = 0x0000;
		[0x00] = A;
		A = [0x11B7];
		C = 1;
		A -= 0x015E - !C;
		[0x93] = A;
		P |= 0x20;
		X = [0x10FC];
		A = [0x1ABF];

		if (Z == 1)
			return this.L03E635();

		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;

		if (N == 0)
			return this.L03E635();

		A = [0x93];
		A <<= 1;
		[0x93] = A;
	}

	public void L03E635()
	{
		A = [0x112D];
		temp = A & 0x02;

		if (Z == 1)
			return this.L03E661();

		P &= ~0x20;
		A = [0x0E + X];
		C = 0;
		A += 0xFFD8 + C;
		[0x11D0] = A;
		P |= 0x20;
		A = [0x11BF];
		A++;
		C = 1; temp = A - 0x05;

		if (N == 0)
			return this.L03E654();

		[0x11BF] = A;
	}

	public void L03E654()
	{
		A = [0x11BE];
		C = 0;
		A += [0x11BF] + C;
		[0x11BE] = A;
		X = [0x119E];
	}

	public void L03E661()
	{
		A = [0x13 + X];
		C = 0;
		A += [0x11BE] + C;
		this.L039A6B();
		P &= ~0x20;
		A = [0x02];
		C = 0;
		A += [0x113E] + C;
		[0x11CE] = A;
		A = [0x1997];
		C = 0;
		A += [0x1142] + C;
		[0x11D2] = A;
	}

	public void L03E680()
	{
		P &= ~0x30;
		X = [0x11BB];
		A = [0x0C + X];
		[0xC5] = A;
		A = [0x0E + X];
		[0xC7] = A;
		A = [0x10 + X];
		[0xC9] = A;
		P |= 0x20;
		A = [0x14 + X];
		A ^= 0xFF;
		A++;
		[0x1A0D] = A;
		[0x1A0C] = 0;
		P &= ~0x20;
		A = [0x11CA];
		[0x1A08] = A;
		A = [0x11CC];
		[0x1A0A] = A;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
	}

	public void L03E6C4()
	{
		C = 1; temp = A - [0x1B75];

		if (Z == 1)
			return this.L03E6D5();

		[0x1B75] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1B77] = A;
		P &= ~0x20;
	}

	public void L03E6D5()
	{
		return this.L03E6D8();
	}

	public void L03E6D8()
	{
		P |= 0x10;
		P &= ~0x20;
		A = [0xC5];
		[0x1135] = A;
		A = [0xC7];
		[0x1137] = A;
		A = [0xC9];
		[0x1139] = A;
		P |= 0x30;
		return this.L03E728();
	}

	public void L03E728()
	{
		A = [0x199F];

		if (Z == 0)
			return this.L03E730();

		return this.L03E7BF();
	}

	public void L03E730()
	{
		P &= ~0x20;
		A = [0x1A08];
		A ^= 0xFFFF;
		A++;
		[0x1A02] = A;
		A = [0x1A0A];
		A ^= 0xFFFF;
		A++;
		[0x1A04] = A;
		A = [0x1A0C];
		A ^= 0xFFFF;
		A++;
		[0x1A06] = A;
		P |= 0x20;
		this.L01F208();
		P &= ~0x20;
		A = [0x19AC];
		[0x19F0] = A;
		A = [0x19AE];
		[0x19F2] = A;
		A = [0x19B0];
		[0x19F4] = A;
		A = [0x19B2];
		[0x19F6] = A;
		A = [0x19B4];
		[0x19F8] = A;
		A = [0x19B6];
		[0x19FA] = A;
		A = [0x19B8];
		[0x19FC] = A;
		A = [0x19BA];
		[0x19FE] = A;
		A = [0x19BC];
		[0x1A00] = A;
		[0xB7] = 0;
		[0xB9] = 0;
		[0xBB] = 0;
		C = 0;
		A = [0xB7];
		A += [0xC5] + C;
		[0xC5] = A;
		C = 0;
		A = [0xB9];
		A += [0xC7] + C;
		[0xC7] = A;
		C = 0;
		A = [0xBB];
		A += [0xC9] + C;
		[0xC9] = A;
		Stack.Push(P);
		P &= ~0x30;
		X = 0x0300;
		[0x10FA] = X;
		A = [0xC5];
		[0x0C + X] = A;
		A = [0xC7];
		[0x0E + X] = A;
		A = [0xC9];
		[0x10 + X] = A;
		P = Stack.Pop();
	}

	public void L03E7BF()
	{
		P &= ~0x20;
		A = [0x1A08];
		[0x1A02] = A;
		A = [0x1A0A];
		[0x1A04] = A;
		A = [0x1A0C];
		[0x1A06] = A;
		P |= 0x30;
		this.L01F208();
		P &= ~0x20;
		A = [0x19AC];
		[0x19F0] = A;
		A = [0x19AE];
		[0x19F2] = A;
		A = [0x19B0];
		[0x19F4] = A;
		A = [0x19B2];
		[0x19F6] = A;
		A = [0x19B4];
		[0x19F8] = A;
		A = [0x19B6];
		[0x19FA] = A;
		A = [0x19B8];
		[0x19FC] = A;
		A = [0x19BA];
		[0x19FE] = A;
		A = [0x19BC];
		[0x1A00] = A;
		P |= 0x20;
		return;
	}

	public void L03E814()
	{
		this.L03E818();
		return;
	}

	public void L03E818()
	{
		A = [0xF7];
		C = 1;
		A -= [0xF8] - !C;
		[0xF8] = A;
		A -= [0xF9] - !C;
		[0xF9] = A;
		A -= [0xFA] - !C;
		[0xFA] = A;
		A -= [0xF7] - !C;
		[0xF7] = A;
		return;
	}

	public void L03E880()
	{
		[0x6B] = 0;
		[0x6C] = 0;
		[0x6A] = 0;
		A = [0x68];

		if (N == 1)
			return this.L03E8AD();

		A <<= 1;
		[0x4202] = A;
		A = [0x67];

		if (N == 1)
			return this.L03E89E();

		A = [0x66];
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		A = [0x67];
		return this.L03E8E6();
	}

	public void L03E89E()
	{
		A = 0x00;
		C = 1;
		A -= [0x66] - !C;
		[0x4203] = A;
		A = 0x00;
		A -= [0x67] - !C;
		return this.L03E8C2();
	}

	public void L03E8AD()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x4202] = A;
		A = [0x67];

		if (N == 1)
			return this.L03E8D8();

		A = [0x66];
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x67];
	}

	public void L03E8C2()
	{
		Y = [0x4217];
		[0x4203] = A;
		[0x69] = Y;
		P &= ~0x20;
		A = [0x6B];
		C = 1;
		A -= [0x4216] - !C;
		C = 1;
		A -= [0x69] - !C;
		return this.L03E8F8_Done();
	}

	public void L03E8D8()
	{
		A = 0x00;
		C = 1;
		A -= [0x66] - !C;
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		A = 0x00;
		A -= [0x67] - !C;
	}

	public void L03E8E6()
	{
		Y = [0x4217];
		[0x4203] = A;
		[0x69] = Y;
		P &= ~0x21;
		A = [0x6B];
		A += [0x4216] + C;
		C = 0;
		A += [0x69] + C;
	}

	public void L03E8F8_Done()
	{
		[0x69] = A;
		P |= 0x20;
		return;
	}

	public void L03E8FD()
	{
		this.L03E903();
		P &= ~0x20;
		return;
	}

	public void L03E903()
	{
		Stack.Push(X);
		Stack.Push(P);
		P &= ~0x20;
		A = [0x00];
		[0x700064] = A;
		A = [0x06];
		[0x70002C] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0x8428;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = [0x700040];
		P = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L03EA26()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x0000;
		[0x700064] = A;
		A = 0x0001;
		[0x700230] = A;
		return this.L03EA85();
	}

	public void L03EA39()
	{
		Stack.Push(P);
		P &= ~0x20;
		return this.L03EA4F();
	}

	public void L03EA3E()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x0000;
		[0x700064] = A;
		A = 0x0001;
		[0x700230] = A;
	}

	public void L03EA4F()
	{
		P |= 0x20;
		Stack.Push(B);
		A = 0x7F;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
		A = [0x7000BA];
		Y = A;
		X = A;
		P |= 0x20;
		A = [0x0010CB];

		if (Z == 1)
			return this.L03EA72();

	}

	public void L03EA66()
	{
		Y++;
		A = [0x7FFF + Y];

		if (Z == 0)
			return this.L03EA66();

		A = [0x8000 + Y];

		if (Z == 0)
			return this.L03EA72();

		Y = X;
	}

	public void L03EA72()
	{
		X = 0x0000;
	}

	public void L03EA75()
	{
		A = [0x8000 + Y];
		[0x702090 + X] = A;

		if (Z == 1)
			return this.L03EA82();

		X++;
		Y++;
		return this.L03EA75();
	}

	public void L03EA82()
	{
		P |= 0x20;
		B = Stack.Pop();
	}

	public void L03EA85()
	{
		P &= ~0x20;
		A = [0x7000BA];
		Stack.Push(A);
		A = [0x700064];
		Stack.Push(A);
		A = [0x70002C];
		Stack.Push(A);
		A = [0x700230];

		if (Z == 0)
			return this.L03EAA5();

		A = [0x700064];
		A++;
		[0x700064] = A;
	}

	public void L03EAA5()
	{
		A = [0x70002C];
		A++;
		[0x70002C] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF9E;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = Stack.Pop();
		[0x70002C] = A;
		A = Stack.Pop();
		[0x700064] = A;
		A = Stack.Pop();
		[0x7000BA] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBFC3;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = 0x0000;
		[0x700230] = A;
		P = Stack.Pop();
		return;
	}

	public void L03EAE4()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = [0x1982];
		A &= 0x04;

		if (Z == 1)
			return this.L03EB2E_Done();

		P &= ~0x20;
		A = [0x700238];
		A++;
		[0x700238] = A;
		A = [0x70023A];
		A++;
		[0x70023A] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xC0D3;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x30;
		A = [0x700238];
		A--;
		[0x700238] = A;
		A = [0x70023A];
		A--;
		[0x70023A] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xC0DA;
		this.L7ED7E8_ExecuteSuperFX();
	}

	public void L03EB2E_Done()
	{
		P = Stack.Pop();
		return;
	}

	public void L03EB30()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = [0x700064];
		Stack.Push(A);
		A = [0x70002C];
		Stack.Push(A);
		A = [0x70002E];
		Stack.Push(A);
		A = [0x700208];
		Stack.Push(A);
		A = [0x700064];
		A++;
		[0x700064] = A;
		A = [0x70002C];
		A++;
		[0x70002C] = A;
		A = 0x0009;
		[0x700208] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC1C2;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = Stack.Pop();
		[0x700208] = A;
		A = Stack.Pop();
		[0x70002E] = A;
		A = Stack.Pop();
		[0x70002C] = A;
		A = Stack.Pop();
		[0x700064] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC1C2;
		this.L7ED7E8_ExecuteSuperFX();
		P = Stack.Pop();
		return;
	}

	public void L03EB92()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = [0x700064];
		Stack.Push(A);
		A = [0x70002C];
		Stack.Push(A);
		A = [0x70002E];
		Stack.Push(A);
		A = [0x700208];
		Stack.Push(A);
		A = [0x700064];
		A++;
		[0x700064] = A;
		A = [0x70002C];
		A++;
		[0x70002C] = A;
		A = 0x0009;
		[0x700208] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC1F4;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = Stack.Pop();
		[0x700208] = A;
		A = Stack.Pop();
		[0x70002E] = A;
		A = Stack.Pop();
		[0x70002C] = A;
		A = Stack.Pop();
		[0x700064] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC1F4;
		this.L7ED7E8_ExecuteSuperFX();
		P = Stack.Pop();
		return;
	}

	public void L03EC1A()
	{
		P &= ~0x30;
		X = [0x18BC];

		if (Z == 0)
			return this.L03EC22_Skip();

		return;
	}

	public void L03EC22_Skip()
	{
		A = [0x18C3];

		if (Z == 1)
			return this.L03EC31_Skip();

		this.L03EDDF();
		A = [0x18C3];

		if (Z == 1)
			return this.L03EC31_Skip();

		return;
	}

	public void L03EC31_Skip()
	{
		P &= ~0x20;
		X = [0x18BC];
		A = [0x03EBF4 + X];
		A &= 0x00FF;
		Y = X;
		X = A;
		return [(0xEC4B + X)]();
	}

	public void L03EDC2_Loop()
	{
		X = 0x0000;
	}

	public void L03EDC5_Loop()
	{
		A = [0x00149C + X];
		[0x00169C + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x0200;

		if (Z == 0)
			return this.L03EDC5_Loop();

		[0x18C3] = 0;
		P |= 0x20;
		A = 0x01;
		[0x18C1] = A;
		return;
	}

	public void L03EDDF()
	{
		P &= ~0x20;
		A = [0x18C9];
		C = 1; temp = A - 0x000F;

		if (Z == 0)
			return this.L03EDEC_Skip();

		return this.L03EDC2_Loop();
	}

	public void L03EDEC_Skip()
	{
		X = 0x0000;
		Y = 0x0000;
	}

	public void L03EDF2_Loop()
	{
		A = [0x00169C + X];
		[0x18C7] = A;
		A &= 0x001F;
		[0x18C5] = A;
		A = [0x00149C + X];
		A &= 0x001F;
		C = 1;
		A -= [0x18C5] - !C;

		if (Z == 1)
			return this.L03EE3B_Skip();

		if (N == 1)
			return this.L03EE1F_Skip();

		C = 1; temp = A - [0x18C9];

		if (N == 1)
			return this.L03EE16_Skip();

		A = [0x18C9];
	}

	public void L03EE16_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.L03EE2E_Skip();
	}

	public void L03EE1F_Skip()
	{
		C = 1; temp = A - [0x18CF];

		if (N == 0)
			return this.L03EE27_Skip();

		A = [0x18CF];
	}

	public void L03EE27_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void L03EE2E_Skip()
	{
		Y++;
		A = [0x18C7];
		A &= 0x7FE0;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void L03EE3B_Skip()
	{
		A = [0x00169C + X];
		A &= 0x03E0;
		[0x18C5] = A;
		A = [0x00149C + X];
		A &= 0x03E0;
		C = 1;
		A -= [0x18C5] - !C;

		if (Z == 1)
			return this.L03EE81_Skip();

		if (N == 1)
			return this.L03EE65_Skip();

		C = 1; temp = A - [0x18CB];

		if (N == 1)
			return this.L03EE5C_Skip();

		A = [0x18CB];
	}

	public void L03EE5C_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.L03EE74_Skip();
	}

	public void L03EE65_Skip()
	{
		C = 1; temp = A - [0x18D1];

		if (N == 0)
			return this.L03EE6D_Skip();

		A = [0x18D1];
	}

	public void L03EE6D_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void L03EE74_Skip()
	{
		Y++;
		A = [0x18C7];
		A &= 0x7C1F;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void L03EE81_Skip()
	{
		A = [0x00169C + X];
		A &= 0x7C00;
		[0x18C5] = A;
		A = [0x00149C + X];
		A &= 0x7C00;
		C = 1;
		A -= [0x18C5] - !C;

		if (Z == 1)
			return this.L03EEC7_Skip();


		if (N == 1)
			return this.L03EEAB_Skip();

		C = 1; temp = A - [0x18CD];

		if (N == 1)
			return this.L03EEA2_Skip();

		A = [0x18CD];
	}

	public void L03EEA2_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.L03EEBA_Skip();
	}

	public void L03EEAB_Skip()
	{
		C = 1; temp = A - [0x18D3];

		if (N == 0)
			return this.L03EEB3_Skip();

		A = [0x18D3];
	}

	public void L03EEB3_Skip()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void L03EEBA_Skip()
	{
		Y++;
		A = [0x18C7];
		A &= 0x03FF;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void L03EEC7_Skip()
	{
		A = [0x18C7];
		[0x00169C + X] = A;
		X++;
		X++;
		C = 1; temp = X - 0x0200;

		if (Z == 1)
			return this.L03EED8_Skip();

		return this.L03EDF2_Loop();
	}

	public void L03EED8_Skip()
	{
		C = 1; temp = Y - 0x0000;

		if (Z == 1)
			return this.L03EEE6_Skip();

		P |= 0x20;
		A = 0x01;
		[0x18C1] = A;
		return this.L03EEEB_Done();
	}

	public void L03EEE6_Skip()
	{
		P &= ~0x20;
		[0x18C3] = 0;
	}

	public void L03EEEB_Done()
	{
		return;
	}

	public void L03EF53()
	{
		P &= ~0x30;
		Stack.Push(X);
		A = 0xAE13;
		[0x1CAD] = A;
		A = 0x3080;
		[0x1CAF] = A;
		A = 0xAE23;
		[0x1CB1] = A;
		A = 0x3082;
		[0x1CB3] = A;
		A = 0xBE13;
		[0x1CB5] = A;
		A = 0x3084;
		[0x1CB7] = A;
		A = 0xBE23;
		[0x1CB9] = A;
		A = 0x3086;
		[0x1CBB] = A;
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L03EF8C()
	{
		P &= ~0x30;
		A = 0x1412;
		[0x1CAD] = A;
		A = 0x30E0;
		[0x1CAF] = A;
		A = 0x1422;
		[0x1CB1] = A;
		A = 0x30E2;
		[0x1CB3] = A;
		A = 0x2412;
		[0x1CB5] = A;
		A = 0x30E4;
		[0x1CB7] = A;
		A = 0x2422;
		[0x1CB9] = A;
		A = 0x30E6;
		[0x1CBB] = A;
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L03EFCF()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L03E814();
		P &= ~0x30;
		A &= 0x000F;

		if (Z == 0)
			return this.L03EFE4_Skip();

		A = 0x0008;
		return this.L03F008_Skip();
	}

	public void L03EFE4_Skip()
	{
		A = 0x0000;
		return this.L03F008_Skip();
	}

	public void L03EFEA()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L03E814();
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		A <<= 1;
		A = (A >> 8) | (A << 8);
		A &= 0x00FF;
		X = A;
		A = [0x03EFC3 + X];
	}

	public void L03F008_Skip()
	{
		A &= 0x00FF;
		C = 0;
		A += 0x0080 + C;
		[0x3A] = A;
		A = [0x198F];
		A &= 0x00FF;

		if (Z == 1)
			return this.L03F026_Skip();

		A = [0x1990];
		X = A;
		A = [0x0BF8A8 + X];
		C = 0;
		A += [0x3A] + C;
		[0x3A] = A;
	}

	public void L03F026_Skip()
	{
		X = 0x011C;
	}

	public void L03F029_Loop()
	{
		A = [0x1B93 + X];
		A &= 0xFE00;
		C = 0;
		A += [0x3A] + C;
		[0x1B93 + X] = A;
		A = [0x3A];
		C = 0;
		A += 0x0002 + C;
		[0x3A] = A;
		X++;
		X++;
		X++;
		X++;
		C = 1; temp = X - 0x012C;

		if (Z == 0)
			return this.L03F029_Loop();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L04B41C()
	{
		Stack.Push(X);
		[0x3A] = X;
		this.L03A102();

		if (C == 0)
			return this.L04B427_Skip();

		return this.L04B42F_Skip();
	}

	public void L04B427_Skip()
	{
		Y = 0xA600;
		A--;
		return this.L04B4A3_Skip();
	}

	public void L04B42F_Skip()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xDD90;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.L03A054();
		X = [0x10FC];
		P &= ~0x20;
		A = [0x000C + X];
		[0x000C + Y] = A;
		A = [0x000E + X];
		[0x000E + Y] = A;
		A = [0x0010 + X];
		[0x0010 + Y] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0000;
		[0x000E + Y] = A;
		A = 0x0000;
		[0x00] = A;
		A = 0x05DC;
		[0x93] = A;
		P |= 0x20;
		A = [0x13 + X];
		this.L039A6B();
		P &= ~0x20;
		A = [0x000C + Y];
		C = 0;
		A += [0x02] + C;
		[0x000C + Y] = A;
		A = [0x000E + Y];
		C = 0;
		A += 0x0000 + C;
		[0x000E + Y] = A;
		A = [0x0010 + Y];
		C = 0;
		A += [0x1997] + C;
		[0x0010 + Y] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0xB633;
		[0x0016 + Y] = A;
		P |= 0x20;
		A = 0x09;
		[0x0018 + Y] = A;
	}

	public void L04B4A3_Skip()
	{
		X = Stack.Pop();
		A = 0xFF;
		[0x00197E] = A;
		return;
	}

	public void L04B592()
	{
		this.L02CC8F();
		P &= ~0x20;
		A = 0x000C;
		this.L029283_LoadSong();
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.L029634();
		this.L0380F7();
		this.L038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		[0x1AD3] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x0013;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.L03A17D_ResetSound();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF8C();
		P |= 0x20;
		A = 0xFF;
		[0x1216] = A;
		[0x1ACB] = 0;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L04B62E_Loop()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L02C897_LongFunction();
		P &= ~0x30;
		A = 0x0002;
		[0x700064] = A;
		A = 0x002C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		A = 0x000C;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x1990] + C;
		[0x1988] = A;
		X = A;
		A = [0x0BF83C + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L04B6A7_Skip();

		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L04B681_Skip();

		[0x1992] = A;
		return this.L04B6AD_Skip();
	}

	public void L04B681_Skip()
	{
		X = [0x1988];
		A = [0x0BF83E + X];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0004 + C;
		C = 1; temp = A - 0x0008;

		if (Z == 0)
			return this.L04B69C_Skip();

		A = 0x0000;
		return this.L04B6C1_Skip();
	}

	public void L04B69C_Skip()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.L04B6AD_Skip();
	}

	public void L04B6A7_Skip()
	{
		this.L03EFEA();
		return this.L04B6B1_Skip();
	}

	public void L04B6AD_Skip()
	{
		this.L03EFCF();
	}

	public void L04B6B1_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L04B6BF_Skip();

		return this.L04B62E_Loop();
	}

	public void L04B6BF_Skip()
	{
		A = 0xFF;
	}

	public void L04B6C1_Skip()
	{
		P |= 0x20;
		[0x1AD3] = 0;
		[0x1AD1] = 0;
		[0x1ACF] = 0;
		this.L02C494();
		this.L04B73F();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		P |= 0x20;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		this.L02C494();
		this.L038168();
		P |= 0x20;
		A = 0xFF;
		return;
	}

	public void L04B73F()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		P &= ~0x20;
		A = 0x0015;
		this.L029283_LoadSong();
		this.L029634();
		P |= 0x20;
		A = 0x16;
		[0xF3] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x126B] = A;
		A = 0x0000;
		[0x126D] = A;
		this.L02984E();
		P &= ~0x20;
		A = 0xFFD8;
		[0x700240] = A;
		A = 0xFFFE;
		[0x1990] = A;
		A = 0x008C;
		[0x1992] = A;
		A = [0x10DB];
		[0x112A] = A;
		A = 0xCD16;
		this.L0394BE();
		X = Y;
		this.L038D6F();
		this.L038168();
		this.L0387D7();
		P |= 0x20;
		P &= ~0x10;
		[0x1DBA] = 0;
		A = 0xFF;
		[0x1216] = A;
		[0x1ACB] = 0;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L04B7BA_Loop()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x11B5] = A;
		[0x118E] = 0;
		[0x118F] = 0;
		this.L02C897_LongFunction();
		P &= ~0x20;
		A = 0x00FA;
		[0x1175] = A;
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		P &= ~0x20;
		A = 0x0082;
		C = 1; temp = A - [0x0E + X];

		if (Z == 1)
			return this.L04B80E_Skip();

		C = 1;
		A -= [0x0E + X] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L04B7F7_Skip();

		C = 1; temp = A - 0x0008;

		if (N == 0)
			return this.L04B7FF_Skip();

		A = 0x0008;
		return this.L04B7FF_Skip();
	}

	public void L04B7F7_Skip()
	{
		C = 1; temp = A - 0xFFF8;

		if (N == 1)
			return this.L04B7FF_Skip();

		A = 0xFFF8;
	}

	public void L04B7FF_Skip()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x0E + X] + C;
	}

	public void L04B80E_Skip()
	{
		[0x0E + X] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L04B81F_Skip();

		[0x1992] = A;
		return this.L04B84A_Skip();
	}

	public void L04B81F_Skip()
	{
		A = 0x008C;
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0002 + C;
		C = 1; temp = A - 0x0026;

		if (Z == 0)
			return this.L04B834_Skip();

		return this.L04B8B0_Skip();
	}

	public void L04B834_Skip()
	{
		[0x1990] = A;
		this.L089160();
		P |= 0x20;
		A = [0x1186];
		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L04B84A_Skip();

		A = 0x01;
		this.L03A47D();
	}

	public void L04B84A_Skip()
	{
		P |= 0x20;
		P &= ~0x20;
		A = [0x10F6];
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L04B860_Skip();

		C = 1; temp = A - 0x0800;

		if (N == 1)
			return this.L04B868_Skip();

		A = 0x0800;
		return this.L04B868_Skip();
	}

	public void L04B860_Skip()
	{
		C = 1; temp = A - 0xF800;

		if (N == 0)
			return this.L04B868_Skip();

		A = 0xF800;
	}

	public void L04B868_Skip()
	{
		[0x10F6] = A;
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x0F;

		if (Z == 1)
			return this.L04B877_Skip();

		return this.L04B8AD_Skip();
	}

	public void L04B877_Skip()
	{
		P &= ~0x20;
		A = 0x0000;
		C = 1; temp = A - [0x10F6];

		if (Z == 1)
			return this.L04B8A8_Skip();

		C = 1;
		A -= [0x10F6] - !C;
		C = 1; temp = A - 0x0000;

		if (N == 1)
			return this.L04B894();

		C = 1; temp = A - 0x0004;

		if (N == 0)
			return this.L04B89C_Skip();

		A = 0x0004;
		return this.L04B89C_Skip();
	}

	public void L04B894()
	{
		C = 1; temp = A - 0xFFFC;

		if (N == 1)
			return this.L04B89C_Skip();

		A = 0xFFFC;
	}

	public void L04B89C_Skip()
	{
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x10F6] + C;
	}

	public void L04B8A8_Skip()
	{
		[0x10F6] = A;
		P |= 0x20;
	}

	public void L04B8AD_Skip()
	{
		return this.L04B7BA_Loop();
	}

	public void L04B8B0_Skip()
	{
		P &= ~0x20;
		A = 0x0000;
		[0x700240] = A;
		[0x700226] = A;
		P |= 0x20;
		[0x1ACF] = 0;
		[0x1AD0] = 0;
		[0x1AD2] = 0;
		[0x10B6] = 0;
		return;
	}

	public void L04B914()
	{
		Stack.Push(X);
		Stack.Push(Y);
		this.L04BAA2();
		this.L00E8D5();
		this.L00E8F0();
		this.L00EA5B();
		this.L00EA70();
		P |= 0x20;
		P &= ~0x10;
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L04B93D()
	{
		this.L04BAA2();
		this.L04BA06();
		P |= 0x20;
		P &= ~0x10;
		[0x127F] = 0;
		this.L00E996();
		this.L00EAD5();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void L04BA06()
	{
		P |= 0x20;
		P &= ~0x10;
		Y = 0x3000;
		X = 0x0000;
	}

	public void L04BA10_Loop()
	{
		A = [0x7E363E + X];
		[0x7E963E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L04BA10_Loop();

		Y = 0x3000;
		X = 0x0000;
	}

	public void L04BA22_Loop()
	{
		A = [0x7E663E + X];
		[0x7E363E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L04BA22_Loop();

		Y = 0x3000;
		X = 0x0000;
	}

	public void L04BA34_Loop()
	{
		A = [0x7E963E + X];
		[0x7E663E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L04BA34_Loop();

		return;
	}

	public void L04BA41()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.L04BA60_Done();
	}

	public void L04BA48_Loop()
	{
		A = [0x0C + X];
		C = 0;
		A += [0x126B] + C;
		[0x0C + X] = A;
		A = [0x10 + X];
		C = 0;
		A += [0x126D] + C;
		[0x10 + X] = A;
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L04BA60_Done();

		return this.L04BA48_Loop();
	}

	public void L04BA60_Done()
	{
		return;
	}

	public void L04BA61()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.L04BA9D_Skip();
	}

	public void L04BA68_Loop()
	{
		A = X;
		C = 1; temp = A - [0x10FC];

		if (Z == 1)
			return this.L04BA95_Skip();

		C = 1; temp = A - [0x11A0];

		if (Z == 1)
			return this.L04BA95_Skip();

		C = 1; temp = A - [0x11A2];

		if (Z == 1)
			return this.L04BA95_Skip();

		C = 1; temp = A - [0x119E];

		if (Z == 1)
			return this.L04BA95_Skip();

		C = 1; temp = A - [0x116C];

		if (Z == 1)
			return this.L04BA95_Skip();

		C = 1; temp = A - [0x11BB];

		if (Z == 1)
			return this.L04BA95_Skip();

		Y = [0x00 + X];
		P |= 0x20;
		A = 0x00;
		[0x7E1CDE + X] = A;
		P &= ~0x20;
		return this.L04BA97_Skip();
	}

	public void L04BA95_Skip()
	{
		Y = [0x00 + X];
	}

	public void L04BA97_Skip()
	{
		X = Y;

		if (Z == 1)
			return this.L04BA9D_Skip();

		return this.L04BA68_Loop();
	}

	public void L04BA9D_Skip()
	{
		this.L00E0BA_Done();
		return;
	}

	public void L04BAA2()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.L04BAE3_Skip();

	}

	public void L04BAA9_Loop()
	{
		A = X;
		C = 1; temp = A - [0x10FC];

		if (Z == 1)
			return this.L04BADB_Skip();

		C = 1; temp = A - [0x11A0];

		if (Z == 1)
			return this.L04BADB_Skip();

		C = 1; temp = A - [0x11A2];

		if (Z == 1)
			return this.L04BADB_Skip();

		C = 1; temp = A - [0x119E];

		if (Z == 1)
			return this.L04BADB_Skip();

		C = 1; temp = A - [0x116C];

		if (Z == 1)
			return this.L04BADB_Skip();

		C = 1; temp = A - [0x11BB];

		if (Z == 1)
			return this.L04BADB_Skip();

		A = [0x04 + X];
		C = 1; temp = A - 0xCD16;

		if (Z == 1)
			return this.L04BADB_Skip();

		Y = [0x00 + X];
		Stack.Push(Y);
		this.L038DC1();
		Y = Stack.Pop();
		P &= ~0x20;
		return this.L04BADD_Skip();
	}

	public void L04BADB_Skip()
	{
		Y = [0x00 + X];
	}

	public void L04BADD_Skip()
	{
		X = Y;

		if (Z == 1)
			return this.L04BAE3_Skip();

		return this.L04BAA9_Loop();
	}

	public void L04BAE3_Skip()
	{
		this.L00E0BA_Done();
		return;
	}

	public void L078001()
	{
		P &= ~0x30;
		A = 0xFFF0;
		P |= 0x20;
		[0x210F] = A;
		A = (A >> 8) | (A << 8);
		[0x210F] = A;
		return;
	}

	public void L078010()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10ED];

		if (Z == 1)
			return this.L07802D_Skip();

		X = 0x0000;
		Y = 0x1000;
	}

	public void L07801F_Loop()
	{
		A = [0x7E563E + X];
		[0x701010 + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.L07801F_Loop();

		return this.L07805D_Skip();
	}

	public byte[] L048030_IndexTable = new byte[]
	{
		0x44, 0x00,
		0x1A, 0x00,
		0x44, 0x00,
		0x32, 0x00,
		0x56, 0x00,
		0x74, 0x00,
		0x7A, 0x00,
		0x8C, 0x00,
		0x38, 0x00,
		0x38, 0x00,
		0x02, 0x00,
		0x08, 0x00,
		0x0E, 0x00,
		0x38, 0x00,
		0x36, 0x00,
		0x04, 0x00,
		0x37, 0x00,
		0x2C, 0x00,
		0x3B, 0x00,
		0x11, 0x00,
		0x64, 0x00,
		0x54, 0x00,
		0x45, 0x00,
		0xAB, 0x00,
		0x6F, 0x00
	}

	public byte[] L02F4F2_RecordTable = new byte[]
	{
		0x00, 0x00,
		0x8C, 0xFE, 0x04,
		0xB0, 0xFF, 0x04,
		0x7E, 0x93, 0x07,
		0xDE, 0x93, 0x07,
		0x4E, 0x95, 0x07,
		0x16, 0x96, 0x07,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
		0x00, 0x00, 0x00,
	};

	public void L07802D_Skip()
	{
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x048030 + X];
		X = A;
		A = [0x02F4F2 + X];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = [0x02F4F4 + X];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
	}

	public void L07805D_Skip()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 0)
			return this.L078072_Skip();

		P |= 0x20;
		A = 0x01;
		X = 0xCD65;
		this.L7ED7E8_ExecuteSuperFX();
		return this.L07814B_Done();
	}

	public void L078072_Skip()
	{
		P &= ~0x20;
		A = [0x1982];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		A &= 0x0001;
		[0x700044] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCC4A;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x30;
		A = [0x1285];

		if (Z == 1)
			return this.L07809B_Skip();

		return this.L07814B_Done();
	}

	public void L07809B_Skip()
	{
		X = [0x10FC];
		A = [0x0C + X];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x700064] = A;
		A = [0x10 + X];
		A ^= 0xFFFF;
		A++;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x70002C] = A;
		P |= 0x20;
		X = [0x10FC];
		A = [0x13 + X];
		P &= ~0x20;
		A &= 0x00FF;
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		[0x3A] = A;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		X = A;
		P |= 0x20;
		A = [0x0887D9 + X];
		[0x701000] = A;
		A = [0x0887DA + X];
		[0x701001] = A;
		A = [0x0887DB + X];
		[0x701002] = A;
		A = [0x0887DC + X];
		[0x701003] = A;
		A = [0x0887DD + X];
		[0x701004] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCE17;
		this.L7ED7E8_ExecuteSuperFX();
	}

	public void L07814B_Done()
	{
		return;
	}

	public void L07814C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.L0781CE_Done();

		A = [0x1DBA];

		if (Z == 1)
			return this.L0781CE_Done();

		P &= ~0x20;
		A = [0x11DD];
		C = 1;
		A -= 0x0010 - !C;
		[0x700064] = A;
		A = [0x11DF];
		C = 1;
		A -= 0x0010 - !C;
		[0x70002C] = A;
		A = 0x0000;
		this.L0781CF();
		A = [0x11E3];
		C = 1;
		A -= 0x0008 - !C;
		[0x700064] = A;
		A = [0x11E5];
		C = 1;
		A -= 0x0010 - !C;
		[0x70002C] = A;
		A = 0x0001;
		this.L0781CF();
		A = [0x11E7];
		C = 1;
		A -= 0x0008 - !C;
		[0x700064] = A;
		A = [0x11E9];
		C = 1;
		A -= 0x000A - !C;
		[0x70002C] = A;
		A = 0x0002;
		this.L0781CF();
		A = [0x11EB];
		C = 1;
		A -= 0x0010 - !C;
		[0x700064] = A;
		A = [0x11ED];
		C = 1;
		A -= 0x000A - !C;
		[0x70002C] = A;
		A = 0x0003;
		this.L0781CF();
	}

	public void L0781CE_Done()
	{
		return;
	}

	public void L0781CF()
	{
		P &= ~0x20;
		X = [0x11EF];

		if (Z == 0)
			return this.L0781DA();

		C = 0;
		A += 0x0004 + C;
	}

	public void L0781DA()
	{
		[0x3A] = A;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		A = 0x000F;
		[0x700040] = A;
		P |= 0x20;
		A = [0x088799 + X];
		[0x701000] = A;
		A = [0x08879A + X];
		[0x701001] = A;
		A = [0x08879B + X];
		[0x701002] = A;
		A = [0x08879C + X];
		[0x701003] = A;
		A = [0x08879D + X];
		[0x701004] = A;
		A = [0x08879E + X];
		[0x701005] = A;
		A = [0x08879F + X];
		[0x701006] = A;
		A = [0x0887A0 + X];
		[0x701007] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCDD9;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		return;
	}

	public void L078237()
	{
		Stack.Push(P);
		P &= ~0x30;
		P |= 0x20;
		A = [0x001DD0];

		if (Z == 0)
			return this.L078244();

		P = Stack.Pop();
		return;
	}

	public void L078244()
	{
		X = 0x0000;
	}

	public void L078247()
	{
		A = [0x001DD0 + X];
		Stack.Push(A);
		Stack.Push(X);
		X = A;
		A = [0x039D13 + X];
		X = Stack.Pop();
		[0x701010 + X] = A;
		A = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.L07825F();

		X++;
		return this.L078247();
	}

	public void L07825F()
	{
		P &= ~0x20;
		A = 0x00A2;
		[0x700064] = A;
		A = 0x0093;
		[0x70002C] = A;
		A = 0x0009;
		[0x700208] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC499;
		this.L7ED7E8_ExecuteSuperFX();
		P &= ~0x20;
		A = 0x00A1;
		[0x700064] = A;
		A = 0x0092;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC499;
		this.L7ED7E8_ExecuteSuperFX();
		P = Stack.Pop();
		return;
	}

	public void L0782A9()
	{
		P &= ~0x30;
		X = 0x0FFE;
		[0x1DFD] = X;
		[0x1E00] = 0;
		X = [0x10DB];

		if (Z == 0)
			return this.L0782BC();

		return this.L0783F5();
	}

	public void L0782BC()
	{
		A = X;
		C = 1; temp = A - [0x10FC];

		if (Z == 0)
			return this.L0782C5();

		return this.L0783ED();
	}

	public void L0782C5()
	{
		C = 1; temp = A - [0x11A2];

		if (Z == 0)
			return this.L0782CD();

		return this.L0783ED();
	}

	public void L0782CD()
	{
		C = 1; temp = A - [0x11A0];

		if (Z == 0)
			return this.L0782D5();

		return this.L0783ED();
	}

	public void L0782D5()
	{
		C = 1; temp = A - [0x116C];

		if (Z == 0)
			return this.L0782DD();

		return this.L0783ED();
	}

	public void L0782DD()
	{
		A = [0x04 + X];
		C = 1; temp = A - 0xBE6B;

		if (Z == 0)
			return this.L0782E7();

		return this.L0783ED();
	}

	public void L0782E7()
	{
		P |= 0x20;
		A = [0x001E + X];
		P &= ~0x20;
		A &= 0x0020;

		if (Z == 1)
			return this.L0782F6();

		return this.L0783ED();
	}

	public void L0782F6()
	{
		Y = [0x10FC];
		A = [0x0C + X];
		C = 1;
		A -= [0x000C + Y] - !C;
		[0x00] = A;
		A = [0x10 + X];
		C = 1;
		A -= [0x0010 + Y] - !C;
		[0x93] = A;
		Stack.Push(X);
		P |= 0x20;
		A = [0x0013 + Y];
		A ^= 0xFF;
		A++;
		this.L039A6B();
		P &= ~0x20;
		A = [0x02];
		[0x00] = A;
		A = [0x1997];
		[0x93] = A;
		X = Stack.Pop();
		A = [0x00];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x000F;

		if (N == 1)
			return this.L078348();

		return this.L0783ED();
	}

	public void L078348()
	{
		C = 1; temp = A - 0xFFF1;

		if (N == 0)
			return this.L078350();

		return this.L0783ED();
	}

	public void L078350()
	{
		C = 0;
		A += 0x0013 + C;
		[0x00] = A;
		A = [0x93];
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x8000;
		Cpu.ROR();
		C = 1; temp = A - 0x000C;

		if (N == 0)
			return this.L0783ED();

		C = 1; temp = A - 0xFFF4;

		if (N == 1)
			return this.L0783ED();

		A ^= 0xFFFF;
		A++;
		C = 0;
		A += 0x00AF + C;
		[0x93] = A;
		P |= 0x20;
		A = 0x06;
		[0x1DCA] = A;
		A = 0x01;
		[0x3A] = A;
		C = 1; temp = X - [0x1286];

		if (Z == 1)
			return this.L0783A3();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 0)
			return this.L0783A3();

		return this.L0783AC();
	}

	public void L0783A3()
	{
		A = 0x0F;
		[0x1DCA] = A;
		A = 0x02;
		[0x3A] = A;
	}

	public void L0783AC()
	{
		A = [0x001E + X];
		A &= 0x04;

		if (Z == 0)
			return this.L0783B7();

		return this.L0783C0();
	}

	public void L0783B7()
	{
		A = 0x03;
		[0x1DCA] = A;
		A = 0x01;
		[0x3A] = A;
	}

	public void L0783C0()
	{
		Stack.Push(X);
		X = [0x1DFD];
		A = [0x00];
		[0x700000 + X] = A;
		A = [0x93];
		[0x700001 + X] = A;
		A = [0x3A];
		[0x700002 + X] = A;
		A = [0x1DCA];
		[0x700003 + X] = A;
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x1DFD];
		C = 0;
		A += 0x0004 + C;
		[0x1DFD] = A;
		[0x1E00]++;
	}

	public void L0783ED()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.L0783F5();

		return this.L0782BC();
	}

	public void L0783F5()
	{
		A = [0x1E00];
		[0x7001C0] = A;
		return;
	}

	public void L078486()
	{
		P |= 0x20;
		[0x420C] = 0;
		this.L02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.L078EA5();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC50();
		P |= 0x20;
		[0x420C] = 0;
		this.L02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		P &= ~0x20;
		A = 0x000D;
		this.L029283_LoadSong();
		this.L078DDE();
		P |= 0x20;
		[0x420C] = 0;
		this.L02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.L078C2E();
		A = [0x10C4];
		[0x420C] = A;
		this.L02CCC9();
		X = 0x000C;
		this.L02C062();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC50();
		return;
	}

	public void L0784F5()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = 0x0004;
		this.L029283_LoadSong();
		return;
	}

	public void L078506()
	{
		P |= 0x20;
		[0x420C] = 0;
		this.L02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.L02D337();
		this.L078CE0();
		this.L09FB88();
		A = [0x10C4];
		[0x420C] = A;
		this.L0785B5();
		return;
	}

	public void L07852B_UpdateSound()
	{
		this.L078506();
	}

	public void L07852E_Loop()
	{
		P &= ~0x20;
		[0x10B6] = 0;
		A = 0x00C8;
		[0x7E2DD6] = A;
	}

	public void L07853A()
	{
		P |= 0x20;
		[0x10B8] = 0;
		this.L07890F();
		this.L0785DD();
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 1)
			return this.L078589_Skip();

		C = 1; temp = A - 0x0001;

		if (Z == 0)
			return this.L078572_Skip();

		A = [0x10CB];
		Stack.Push(A);
		this.L0786AB();
		P &= ~0x20;
		A = Stack.Pop();
		C = 1; temp = A - [0x10CB];

		if (Z == 1)
			return this.L078570_Skip();

		P |= 0x20;
		A = 0x01;
		[0x110A] = A;
		P &= ~0x20;
		A = 0x0002;
		[0x7E2DD6] = A;
	}

	public void L078570_Skip()
	{
		return this.L07853A();
	}

	public void L078572_Skip()
	{
		C = 1; temp = A - 0x0002;

		if (Z == 0)
			return this.L07857D_Skip();

		this.L078F46();
		return this.L07852E_Loop();
	}

	public void L07857D_Skip()
	{
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L07852E_Loop();

		this.L079164();
		return this.L07852B_UpdateSound();
	}

	public void L078589_Skip()
	{
		A = [0x1982];
		[0xF7] = A;
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		this.L038168();
		this.L038000();
		this.L0387A6();
		P &= ~0x20;
		this.L0292AD_LoadSong11();
		A = 0x0005;
		this.L029283_LoadSong();
		return;
	}

	public void L0785B5()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L0785BE()
	{
		this.L07891C();
		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.L0785BE();

		return;
	}

	public void L0785DD()
	{
		X = 0x012C;
	}

	public void L0785E0_Loop()
	{
		P &= ~0x20;
		A = [0x7E2DD6];
		A--;
		[0x7E2DD6] = A;

		if (Z == 0)
			return this.L07861B();

		A = 0x00C8;
		[0x7E2DD6] = A;
		P |= 0x20;
		A = [0x110A];
		C = 1; temp = A - 0x00;

		if (Z == 1)
			return this.L078603();

		this.L0CF550();
		return this.L078609();
	}

	public void L078603()
	{
		this.L02BE46();
		return this.L078609();
	}

	public void L078609()
	{
		P |= 0x20;
		A = [0x110A];
		A++;
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L078615();

		A = 0x00;
	}

	public void L078615()
	{
		[0x110A] = A;
		this.L078506();
	}

	public void L07861B()
	{
		Stack.Push(X);
		this.L07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.L07862C();

		return this.L078657();
	}

	public void L07862C()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.L078637();

		return this.L078657();
	}

	public void L078637()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x00C8;
		[0x7E2DD6] = A;
		A = [0x10B6];
		A--;

		if (N == 0)
			return this.L078654_Skip();

		A = 0x0003;
	}

	public void L078654_Skip()
	{
		[0x10B6] = A;
	}

	public void L078657()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.L078664_Skip();

		return this.L078692_Skip();
	}

	public void L078664_Skip()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.L07866F_Skip();

		return this.L078692_Skip();
	}

	public void L07866F_Skip()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = 0x00C8;
		[0x7E2DD6] = A;
		A = [0x10B6];
		A++;
		C = 1; temp = A - 0x0004;

		if (Z == 0)
			return this.L07868F_Skip();

		A = 0x0000;
	}

	public void L07868F_Skip()
	{
		[0x10B6] = A;
	}

	public void L078692_Skip()
	{
		X = Stack.Pop();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L07869F_Skip();

		return this.L0785E0_Loop();
	}

	public void L07869F_Skip()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		return;
	}

	public void L0786AB()
	{
		P |= 0x20;
		A = 0x01;
		[0x10B8] = A;
		P &= ~0x20;
		[0x10B6] = 0;
		this.L07890F();
		P &= ~0x20;
		[0x10AC] = 0;
		A = 0x0000;
		[0x7E2DD6] = A;
		P |= 0x20;
		X = 0x012C;
	}

	public void L0786CB_Skip()
	{
		this.L07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.L0786DB();

		return this.L07870B_Skip();
	}

	public void L0786DB()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.L0786E6();

		return this.L07870B_Skip();
	}

	public void L0786E6()
	{
		A = [0x10B6];
		C = 1; temp = A - 0x04;

		if (Z == 1)
			return this.L0786F8();

		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L0786F8()
	{
		P &= ~0x20;
		A = [0x10B6];
		A--;

		if (N == 0)
			return this.L078703_Skip();

		A = 0x0004;
	}

	public void L078703_Skip()
	{
		[0x10B6] = A;
		P |= 0x20;
		return this.L0786CB_Skip();
	}

	public void L07870B_Skip()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.L078718_Skip();

		return this.L07874B_Skip();
	}

	public void L078718_Skip()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.L078723_Skip();

		return this.L07874B_Skip();
	}

	public void L078723_Skip()
	{
		A = [0x10B6];
		C = 1; temp = A - 0x04;

		if (Z == 1)
			return this.L078735_Skip();

		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L078735_Skip()
	{
		P &= ~0x20;
		A = [0x10B6];
		A++;
		C = 1; temp = A - 0x0005;

		if (Z == 0)
			return this.L078743_Skip();

		A = 0x0000;
	}

	public void L078743_Skip()
	{
		[0x10B6] = A;
		P |= 0x20;
		return this.L0786CB_Skip();
	}

	public void L07874B_Skip()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.L078758_Skip();

		return this.L0787C2_Skip();
	}

	public void L078758_Skip()
	{
		A = [0x1188];
		A &= 0x02;

		if (Z == 1)
			return this.L078763_Skip();

		return this.L0787C2_Skip();
	}

	public void L078763_Skip()
	{
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 0)
			return this.L078775_Skip();

		A = [0x10CB];
		A ^= 0x0001;
		[0x10CB] = A;
		return this.L0787B2_Skip();
	}

	public void L078775_Skip()
	{
		C = 1; temp = A - 0x0001;

		if (Z == 0)
			return this.L078788_Skip();

		A = [0x10B4];
		A--;

		if (N == 0)
			return this.L078783_Skip();

		A = 0x0002;
	}

	public void L078783_Skip()
	{
		[0x10B4] = A;
		return this.L0787B2_Skip();
	}

	public void L078788_Skip()
	{
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L07879C_Skip();

		A = [0x10B2];
		A ^= 0x0001;
		[0x10B2] = A;
		this.L02915C();
		return this.L0787B2_Skip();
	}

	public void L07879C_Skip()
	{
		C = 1; temp = A - 0x0002;

		if (Z == 0)
			return this.L0787AC_Skip();

		A = [0x10E5];
		A ^= 0x0001;
		[0x10E5] = A;
		return this.L0787B2_Skip();
	}

	public void L0787AC_Skip()
	{
		this.L0788C6();
		return this.L078854_Skip();
	}

	public void L0787B2_Skip()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P |= 0x20;
		return this.L0786CB_Skip();
	}

	public void L0787C2_Skip()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.L0787CF_Skip();

		return this.L0787DC_Skip();
	}

	public void L0787CF_Skip()
	{
		A = [0x1188];
		A &= 0x01;

		if (Z == 1)
			return this.L0787DA_Skip();

		return this.L0787DC_Skip();
	}

	public void L0787DA_Skip()
	{
		return this.L0787F2_Skip();
	}

	public void L0787DC_Skip()
	{
		A = [0x10BC];
		A &= 0x20;

		if (Z == 0)
			return this.L0787E7_Skip();

		return this.L078854_Skip();
	}

	public void L0787E7_Skip()
	{
		A = [0x1188];
		A &= 0x20;

		if (Z == 1)
			return this.L0787F2_Skip();

		return this.L078854_Skip();
	}

	public void L0787F2_Skip()
	{
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 0)
			return this.L078804_Skip();

		A = [0x10CB];
		A ^= 0x0001;
		[0x10CB] = A;
		return this.L078844_Skip();
	}

	public void L078804_Skip()
	{
		C = 1; temp = A - 0x0001;

		if (Z == 0)
			return this.L07881A_Skip();

		A = [0x10B4];
		A++;
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L078815_Skip();

		A = 0x0000;
	}

	public void L078815_Skip()
	{
		[0x10B4] = A;
		return this.L078844_Skip();
	}

	public void L07881A_Skip()
	{
		C = 1; temp = A - 0x0003;

		if (Z == 0)
			return this.L07882E_Skip();

		A = [0x10B2];
		A ^= 0x0001;
		[0x10B2] = A;
		this.L02915C();
		return this.L078844_Skip();
	}

	public void L07882E_Skip()
	{
		C = 1; temp = A - 0x0002;

		if (Z == 0)
			return this.L07883E_Skip();

		A = [0x10E5];
		A ^= 0x0001;
		[0x10E5] = A;
		return this.L078844_Skip();
	}

	public void L07883E_Skip()
	{
		this.L0788AD();
		return this.L078854_Skip();
	}

	public void L078844_Skip()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P |= 0x20;
		return this.L0786CB_Skip();
	}

	public void L078854_Skip()
	{
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L07887E_Skip();

		P &= ~0x20;
		A = [0x10B6];
		C = 1; temp = A - 0x0004;

		if (Z == 1)
			return this.L078876_Skip();

		A = [0x10AC];

		if (Z == 1)
			return this.L078876_Skip();

		[0x10AC] = 0;
		A = 0x0001;
		[0x7E2DD6] = A;
	}

	public void L078876_Skip()
	{
		this.L0788DC();
		P |= 0x20;
		return this.L0786CB_Skip();
	}

	public void L07887E_Skip()
	{
		A = [0x10B6];
		C = 1; temp = A - 0x04;

		if (Z == 1)
			return this.L078890_Skip();

		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
	}

	public void L078890_Skip()
	{
		A = [0x10AC];

		if (Z == 1)
			return this.L0788A7_Done();

		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		P &= ~0x20;
		A = 0x0004;
		this.L029283_LoadSong();
	}

	public void L0788A7_Done()
	{
		P &= ~0x20;
		[0x10B6] = 0;
		return;
	}

	public void L0788AD()
	{
		P &= ~0x20;
		A = [0x10AC];
		A++;
		C = 1; temp = A - 0x000F;

		if (Z == 0)
			return this.L0788BB_Skip();

		A = 0x0000;
	}

	public void L0788BB_Skip()
	{
		[0x10AC] = A;
		A = 0x001E;
		[0x7E2DD6] = A;
		return;
	}

	public void L0788C6()
	{
		P &= ~0x20;
		A = [0x10AC];
		A--;

		if (N == 0)
			return this.L0788D1();

		A = 0x000E;
	}

	public void L0788D1()
	{
		[0x10AC] = A;
		A = 0x001E;
		[0x7E2DD6] = A;
		return;
	}

	public void L0788DC()
	{
		P &= ~0x20;
		A = [0x7E2DD6];

		if (Z == 1)
			return this.L0788EB();

		A--;
		[0x7E2DD6] = A;

		if (Z == 1)
			return this.L0788EC();

	}

	public void L0788EB()
	{
		return;
	}

	public void L0788EC()
	{
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = [0x10AC];
		X = A;
		A = [0x0BF82C + X];
		A &= 0x00FF;
		this.L02929A_LoadSong();
		Y = 0x0005;
	}

	public void L078905()
	{
		X = 0x0000;
	}

	public void L078908()
	{
		X--;

		if (Z == 0)
			return this.L078908();

		Y--;

		if (Z == 0)
			return this.L078905();

		return;
	}

	public void L07890F()
	{
		this.L07891C();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L07890F();

		return;
	}

	public void L07891C()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		A = 0x02;
		[0x38] = A;
		[0x1982]++;

		if (Z == 0)
			return this.L078938();

		[0x1983]++;
	}

	public void L078938()
	{
		P |= 0x20;
	}

	public void L07893A()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.L07893A();

	}

	public void L07893F()
	{
		A = [0x1ADF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L07893F();

		[0x1ADF] = 0;
	}

	public void L078949()
	{
		A = [0x38];

		if (Z == 0)
			return this.L078949();

		this.L02C418();
		P |= 0x20;
		A = [0x10B8];

		if (Z == 0)
			return this.L07895D();

		this.L078A41();
		return this.L07897F();
	}

	public void L07895D()
	{
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L078966();

		this.L078ADC();
		return this.L07897F();
	}

	public void L078966()
	{
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L07896F();

		this.L0789FA();
		return this.L07897F();
	}

	public void L07896F()
	{
		C = 1; temp = A - 0x03;

		if (Z == 0)
			return this.L078978();

		this.L0789B2();
		return this.L07897F();
	}

	public void L078978()
	{
		C = 1; temp = A - 0x04;

		if (Z == 0)
			return this.L07897F();

		this.L078986();
	}

	public void L07897F()
	{
		this.L02D352();
		P &= ~0x20;
		return;
	}

	public void L078986()
	{
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x10F0];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BF7CA + X];
		[0x7000BA] = A;
		this.L03EA3E();
		return;
	}

	public void L0789B2()
	{
		P &= ~0x30;
		A = 0x0054;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0xF4];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += 0x0000 + C;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0038;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = 0x06D5;
		[0x7000BA] = A;
		this.L03EA3E();
		return;
	}

	public void L0789FA()
	{
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0490;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x30;
		A = 0x005C;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = 0x0007;
		[0x700208] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC4BF;
		this.L7ED7E8_ExecuteSuperFX();
		return;
	}

	public void L078A41()
	{
		P &= ~0x30;
		A = 0x005A;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0C3D;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0054;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = 0x0C4E;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0050;
		[0x700064] = A;
		A = 0x0088;
		[0x70002C] = A;
		A = 0x0C60;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0054;
		[0x700064] = A;
		A = 0x00A0;
		[0x70002C] = A;
		A = 0x0C74;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x10B6];
		A <<= 1;
		C = 0;
		A += [0x10B6] + C;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += 0x0058 + C;
		[0x70002C] = A;
		A = 0x004A;
		[0x700064] = A;
		A = 0x0C86;
		[0x7000BA] = A;
		this.L03EA3E();
		return;
	}

	public void L078ADC()
	{
		P &= ~0x30;
		A = 0x001E;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10CB];
		[0x1986] = A;
		this.L02C239();
		A = 0x0030;
		[0x700064] = A;
		A = 0x0040;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x30;
		A = 0x0024;
		[0x1988] = A;
		A = 0x0003;
		[0x198A] = A;
		A = [0x10B4];
		[0x1986] = A;
		this.L02C239();
		A = 0x0030;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x002D;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10B2];
		[0x1986] = A;
		this.L02C239();
		P &= ~0x20;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0088;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0033;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10E5];
		[0x1986] = A;
		this.L02C239();
		P &= ~0x20;
		A = 0x0034;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0028;
		[0x700064] = A;
		A = 0x00A0;
		[0x70002C] = A;
		A = 0x0AF5;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0039;
		[0x1988] = A;
		A = 0x000F;
		[0x198A] = A;
		A = [0x10AC];
		[0x1986] = A;
		this.L02C239();
		P &= ~0x20;
		A = 0x0074;
		[0x700064] = A;
		A = 0x00B0;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x10B6];
		A <<= 1;
		A <<= 1;
		A <<= 1;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		C = 0;
		A += 0x0040 + C;
		[0x70002C] = A;
		A = 0x0021;
		[0x700064] = A;
		A = 0x0972;
		[0x7000BA] = A;
		this.L03EA3E();
		return;
	}

	public void L078C2E()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x22;
		[0x4301] = A;
		A = 0x00;
		[0x2121] = A;
		X = 0xF03F;
		[0x4302] = X;
		A = 0x0A;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		P &= ~0x20;
		A = 0xF03F;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0A;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x5C00;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x1800;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		this.L02B484();
		P &= ~0x30;
		P &= ~0x20;
		A = 0xFB96;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x03;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
		this.L078001();
		return;
	}

	public void L078CE0()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x22;
		[0x4301] = A;
		A = 0x00;
		[0x2121] = A;
		X = 0xF13F;
		[0x4302] = X;
		A = 0x0A;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		P &= ~0x20;
		A = 0xF8D2;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x09;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x5C00;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x1800;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		P &= ~0x20;
		A = 0xFED3;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0D;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x6800;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x1800;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		this.L02B484();
		P &= ~0x30;
		P &= ~0x20;
		A = 0xE17D;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0B;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
		this.L078001();
		return;
	}

	public void L078DDE()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x22;
		[0x4301] = A;
		A = 0x00;
		[0x2121] = A;
		X = 0xF23F;
		[0x4302] = X;
		A = 0x0A;
		[0x4304] = A;
		X = 0x0100;
		[0x4305] = X;
		A = 0x00;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		P &= ~0x20;
		A = 0x91CC;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x05;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		A = 0x80;
		[0x2115] = A;
		A = 0x18;
		[0x4301] = A;
		X = 0x5C00;
		[0x2116] = X;
		X = 0x1000;
		[0x4302] = X;
		A = 0x70;
		[0x4304] = A;
		X = 0x1C00;
		[0x4305] = X;
		A = 0x01;
		[0x4300] = A;
		A = 0x01;
		[0x420B] = A;
		this.L02B484();
		P &= ~0x30;
		P &= ~0x20;
		A = 0xFCC8;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0C;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		this.L02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.L7ED7E8_ExecuteSuperFX();
		this.L078001();
		A = [0x10C4];
		[0x420C] = A;
		this.L02CCC9();
		X = 0x000C;
		this.L02C062();
		this.L02CC50();
		return;
	}

	public void L078EA5()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		A = 0x0012;
		this.L029283_LoadSong();
		P &= ~0x20;
		A = 0x0000;
		[0x70022A] = A;
		[0x7000BA] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1ACF] = A;
		this.L029634();
		A = 0xFF;
		[0x1AD1] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x000D;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0xC4A0;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		[0x1186] = 0;
		[0x1187] = 0;
		this.L03A17D_ResetSound();
		X = 0x007D;
	}

	public void L078F0C()
	{
		Stack.Push(X);
		this.L03E3B5();
		this.L03A1E2();
		P |= 0x20;
		P &= ~0x10;
		this.L02C278();
		P |= 0x20;
		this.L02C688();
		this.L02D24B();
		this.L038EA8();
		P &= ~0x30;
		A = 0x0000;
		[0x7001AC] = A;
		this.L7EC654();
		X = Stack.Pop();
		X--;

		if (Z == 1)
			return this.L078F3F();

		return this.L078F0C();
	}

	public void L078F3F()
	{
		P &= ~0x20;
		this.L02CC50();
		return;
	}

	public void L078F46()
	{
		P &= ~0x20;
		A = 0x0000;
		[0x702490] = A;
		P |= 0x20;
		A = 0x02;
		[0x10B8] = A;
		P &= ~0x20;
		A = [0xF4];
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0xF4] + C;
		X = A;
		P |= 0x20;
		A = [0x0BF789 + X];
		C = 1;
		A -= 0x60 - !C;
		[0x702492] = A;
		A = [0x0BF78A + X];
		C = 1;
		A -= 0x60 - !C;
		[0x702493] = A;
		A = [0x0BF78B + X];
		C = 1;
		A -= 0x60 - !C;
		[0x702494] = A;
		A = [0x0BF78C + X];
		C = 1;
		A -= 0x60 - !C;
		[0x702495] = A;
		A = [0x0BF78D + X];
		C = 1;
		A -= 0x60 - !C;
		[0x702496] = A;
		A = 0x00;
		[0x702497] = A;
		this.L07890F();
		X = 0x012C;
	}

	public void L078FA5()
	{
		Stack.Push(X);
		this.L07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.L078FB6();

		return this.L078FDC();
	}

	public void L078FB6()
	{
		A = [0x1188];
		A &= 0x02;

		if (Z == 1)
			return this.L078FC1();

		return this.L078FDC();
	}

	public void L078FC1()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		A--;

		if (N == 0)
			return this.L078FD8();

		A = 0x0004;
	}

	public void L078FD8()
	{
		[0x702490] = A;
	}

	public void L078FDC()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.L078FE9();

		return this.L079012();
	}

	public void L078FE9()
	{
		A = [0x1188];
		A &= 0x01;

		if (Z == 1)
			return this.L078FF4();

		return this.L079012();
	}

	public void L078FF4()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		A++;
		C = 1; temp = A - 0x0005;

		if (Z == 0)
			return this.L07900E();

		A = 0x0000;
	}

	public void L07900E()
	{
		[0x702490] = A;
	}

	public void L079012()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.L07901F();

		return this.L07906D();
	}

	public void L07901F()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.L07902A();

		return this.L07906D();
	}

	public void L07902A()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		X = A;
		P |= 0x20;
		A = [0x702492 + X];
		A--;
		C = 1; temp = A - 0x01;

		if (Z == 0)
			return this.L07904B();

		A = 0x1A;
		return this.L079069();
	}

	public void L07904B()
	{
		C = 1; temp = A - 0x05;

		if (Z == 0)
			return this.L079053();

		A = 0x04;
		return this.L079069();
	}

	public void L079053()
	{
		C = 1; temp = A - 0x09;

		if (Z == 0)
			return this.L07905B();

		A = 0x08;
		return this.L079069();
	}

	public void L07905B()
	{
		C = 1; temp = A - 0x0F;

		if (Z == 0)
			return this.L079063();

		A = 0x0E;
		return this.L079069();
	}

	public void L079063()
	{
		C = 1; temp = A - 0x15;

		if (Z == 0)
			return this.L079069();

		A = 0x14;
	}

	public void L079069()
	{
		[0x702492 + X] = A;
	}

	public void L07906D()
	{
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.L079078();

		return this.L0790C6();
	}

	public void L079078()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.L079083();

		return this.L0790C6();
	}

	public void L079083()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		X = A;
		P |= 0x20;
		A = [0x702492 + X];
		A++;
		C = 1; temp = A - 0x1B;

		if (Z == 0)
			return this.L0790A4();

		A = 0x02;
		return this.L0790C2();
	}

	public void L0790A4()
	{
		C = 1; temp = A - 0x05;

		if (Z == 0)
			return this.L0790AC();

		A = 0x06;
		return this.L0790C2();
	}

	public void L0790AC()
	{
		C = 1; temp = A - 0x09;

		if (Z == 0)
			return this.L0790B4();

		A = 0x0A;
		return this.L0790C2();
	}

	public void L0790B4()
	{
		C = 1; temp = A - 0x0F;

		if (Z == 0)
			return this.L0790BC();

		A = 0x10;
		return this.L0790C2();
	}

	public void L0790BC()
	{
		C = 1; temp = A - 0x15;

		if (Z == 0)
			return this.L0790C2();

		A = 0x16;
	}

	public void L0790C2()
	{
		[0x702492 + X] = A;
	}

	public void L0790C6()
	{
		X = Stack.Pop();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L0790D3();

		return this.L078FA5();
	}

	public void L0790D3()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.L029213_SendApuCommand();
		P |= 0x20;
		P |= 0x20;
		P &= ~0x10;
		Y = 0x0000;
		[0x3A] = 0;
	}

	public void L0790E7()
	{
		X = 0x0000;
		Stack.Push(Y);
	}

	public void L0790EB()
	{
		Stack.Push(X);
		X = Y;
		A = [0x0BF789 + X];
		X = Stack.Pop();
		C = 1;
		A -= 0x61 - !C;
		A++;
		C = 1; temp = A - [0x702492 + X];

		if (Z == 0)
			return this.L07910C();

		Y++;
		X++;
		C = 1; temp = X - 0x0005;

		if (Z == 0)
			return this.L0790EB();

		Y = Stack.Pop();
		A = [0x3A];
		C = 1; temp = A - 0x08;

		if (N == 0)
			return this.L079129();

		return this.L07914D();
	}

	public void L07910C()
	{
		Y = Stack.Pop();
		[0x3A]++;
		Y++;
		Y++;
		Y++;
		Y++;
		Y++;
		C = 1; temp = Y - 0x0041;

		if (N == 1)
			return this.L0790E7();

		return;
	}

	public void L079129()
	{
		A = [0x3A];
		C = 1;
		A -= 0x08 - !C;
		[0x10F0] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x0BF827 + X];
		A |= [0x10EF];
		[0x10EF] = A;
		A = 0x04;
		[0x10B8] = A;
		X = 0x001E;
		return this.L07915B();
	}

	public void L07914D()
	{
		P |= 0x20;
		A = [0x3A];
		[0xF4] = A;
		A = 0x03;
		[0x10B8] = A;
		X = 0x001E;
	}

	public void L07915B()
	{
		Stack.Push(X);
		this.L07891C();
		X = Stack.Pop();
		X--;

		if (Z == 0)
			return this.L07915B();

		return;
	}

	public void L079164()
	{
		this.L07890F();
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		P &= ~0x20;
		this.L0292AD_LoadSong11();
		A = 0x0014;
		this.L029283_LoadSong();
		P &= ~0x20;
		A = 0x0000;
		[0x70022A] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		[0x1AD0] = A;
		P &= ~0x20;
		A = 0xFFF0;
		[0x700226] = A;
		A = 0xFFFF;
		[0x1990] = A;
		P |= 0x20;
		this.L029634();
		this.L0380F7();
		this.L038154();
		P |= 0x20;
		A = 0xFF;
		[0x1AD2] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x000E;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P |= 0x20;
		this.L03A17D_ResetSound();
		P |= 0x20;
		[0x10B6] = 0;
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF53();
	}

	public void L079209()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L02C897_LongFunction();
		P &= ~0x20;
		A = 0x002E;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = 0x3EF0;
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = 0x0026;
		[0x700064] = A;
		A = 0x00A5;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x11D6];
		[0x7000BA] = A;
		this.L03EA39();
		P |= 0x20;
		A = [0x11D5];

		if (Z == 1)
			return this.L079266();

		A--;
		[0x11D5] = A;
		this.L03EFEA();
		return this.L07926A();
	}

	public void L079266()
	{
		this.L03EFCF();
	}

	public void L07926A()
	{
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.L0792BC();

		P &= ~0x20;
		A = [0x10B6];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x0BFABE + X];
		C = 1; temp = A - [0x10BE];

		if (Z == 0)
			return this.L0792B9();

		A = [0x0BFABF + X];
		C = 1; temp = A - [0x10BC];

		if (Z == 0)
			return this.L0792B9();

		[0x10B6]++;
		A = [0x10B6];
		C = 1; temp = A - 0x16;

		if (Z == 1)
			return this.L0792BC();

		P &= ~0x30;
		A = [0x10B6];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF53();
	}

	public void L0792B9()
	{
		return this.L079209();
	}

	public void L0792BC()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
		P &= ~0x20;
		A = 0x0004;
		this.L029283_LoadSong();
		this.L02C494();
		this.L038168();
		P &= ~0x20;
		A = 0x0000;
		[0x700226] = A;
		P |= 0x20;
		[0x1ACF] = 0;
		[0x1AD0] = 0;
		[0x1AD2] = 0;
		[0x10B6] = 0;
		return;
	}

	public void L089160()
	{
		P &= ~0x20;
		[0x114C] = 0;
		P |= 0x20;
		A = 0xFF;
		[0x1129] = A;
		P &= ~0x20;
		Stack.Push(X);
		X = [0x1990];
		A = [0x0BFB95 + X];
		X = Stack.Pop();
		[0x9C] = A;
		A = 0xF894;
		[0x3E] = A;
		[0x79] = A;
		A = 0xFED4;
		[0x3C] = A;
		P |= 0x20;
		[0x65] = 0;
		[0x66] = 0;
		Y = 0x0038;
	}

	public void L08918E()
	{
		Stack.Push(Y);
		[0x3A] = X;
		this.L03A102();

		if (C == 0)
			return this.L089199();

		return this.L0891A2();
	}

	public void L089199()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.L08928E();
	}

	public void L0891A2()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xC2B9;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.L03A054();
		P &= ~0x20;
		A = 0x92F9;
		[0x0016 + Y] = A;
		P |= 0x20;
		A = 0x08;
		[0x0018 + Y] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0xAEFF;
		[0x7E1CD2 + X] = A;
		P |= 0x20;
		A = 0x03;
		[0x7E1CD4 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = 0xBA36;
		[0x7E1CCF + X] = A;
		P |= 0x20;
		A = 0x03;
		[0x7E1CD1 + X] = A;
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		A = 0x01;
		[0x0028 + Y] = A;
		A = 0x01;
		[0x0029 + Y] = A;
		A = [0x66];
		[0x0020 + Y] = A;
		C = 0;
		A += 0x3C + C;
		[0x000A + Y] = A;
		[0x66]++;
		Stack.Push(X);
		P &= ~0x20;
		X = [0x9C];
	}

	public void L08920C()
	{
		A = [0x09B2A4 + X];
		A &= 0x00FF;
		C = 1; temp = A - 0x000D;

		if (Z == 0)
			return this.L089226();

		A = [0x3C];
		C = 0;
		A += 0x00FA + C;
		[0x3C] = A;
		A = [0x79];
		[0x3E] = A;
		return this.L089242();
	}

	public void L089226()
	{
		C = 1; temp = A - 0x005F;

		if (Z == 0)
			return this.L089235();

		A = [0x3E];
		C = 0;
		A += 0x0078 + C;
		[0x3E] = A;
		return this.L089242();
	}

	public void L089235()
	{
		C = 1; temp = A - 0x0020;

		if (Z == 0)
			return this.L089247();

		A = [0x3E];
		C = 0;
		A += 0x00F0 + C;
		[0x3E] = A;
	}

	public void L089242()
	{
		X++;
		[0x9C] = X;
		return this.L08920C();
	}

	public void L089247()
	{
		P |= 0x20;
		C = 1;
		A -= 0x41 - !C;
		A |= 0x80;
		X = Y;
		[0x7E1CDB + X] = A;
		X = [0x9C];
		X++;
		[0x9C] = X;
		X = Stack.Pop();
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10FC];
		A = [0x000C + X];
		[0x000C + Y] = A;
		C = 0;
		A += [0x3E] + C;
		[0x0024 + Y] = A;
		A = [0x000E + X];
		C = 0;
		A += [0x3C] + C;
		[0x0022 + Y] = A;
		[0x000E + Y] = A;
		A = [0x10 + X];
		C = 0;
		A += 0x1194 + C;
		[0x0026 + Y] = A;
		C = 0;
		A += 0x1194 + C;
		C = 0;
		A += 0x1194 + C;
		[0x0010 + Y] = A;
		X = Stack.Pop();
		P |= 0x20;
	}

	public void L08928E()
	{
		P &= ~0x20;
		A = [0x3E];
		C = 0;
		A += 0x00F0 + C;
		[0x3E] = A;
		P |= 0x20;
		Y = Stack.Pop();
		Y--;

		if (Z == 1)
			return this.L0892AD();

		Stack.Push(X);
		X = [0x9C];
		A = [0x09B2A4 + X];
		X = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.L0892AD();

		return this.L08918E();
	}

	public void L0892AD()
	{
		return;
	}

	public void L09F8D2()
	{
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.L029634();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x0017;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.L03A17D_ResetSound();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF8C();
		X = 0x005F;
		[0x197C] = X;
		[0x1ACB] = 0;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L09F95E()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x1990];
		A = [0x0BF8F8 + X];
		C = 1; temp = A - [0x1186];

		if (Z == 1)
			return this.L09F972_Skip();

		this.L03A479();
	}

	public void L09F972_Skip()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		this.L02C897_LongFunction();
		P &= ~0x30;
		A = 0x0002;
		[0x700064] = A;
		A = 0x002C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		X = [0x1990];
		A = [0x0BF8F4 + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L09F9E3();

		this.L03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L09F9C4();

		[0x1992] = A;
		return this.L09F9E9();
	}

	public void L09F9C4()
	{
		X = [0x1990];
		A = [0x0BF8F6 + X];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		C = 1; temp = A - 0x0038;

		if (Z == 1)
			return this.L09FA02();

		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
	}

	public void L09F9E3()
	{
		this.L03EFEA();
		return this.L09F9ED();
	}

	public void L09F9E9()
	{
		this.L03EFCF();
	}

	public void L09F9ED()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x1188];
		temp = A & 0x90;

		if (Z == 0)
			return this.L09F9FF();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L09FA02();

	}

	public void L09F9FF()
	{
		return this.L09F95E();
	}

	public void L09FA02()
	{
		P |= 0x20;
		this.L02CC8F();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		return;
	}

	public void L09FA1A()
	{
		Stack.Push(P);
		Stack.Push(X);
		P |= 0x20;
		P &= ~0x10;
		A = [0x122A];

		if (Z == 0)
			return this.L09FA3A();

		P |= 0x20;
		A = 0x08;
		[0x1299] = A;
		X = 0xEA2D;
		[0x1297] = X;
		X = 0x0080;
		[0x129A] = X;
		return this.L09FA5E();
	}

	public void L09FA3A()
	{
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		X = A;
		A = [0x02F4C8 + X];
		[0x1297] = A;
		P |= 0x20;
		A = [0x02F4CA + X];
		[0x1299] = A;
		X = 0x0080;
		[0x129A] = X;
	}

	public void L09FA5E()
	{
		Y = 0x0000;
		X = [0x1297];
		Stack.Push(B);
		A = [0x1299];
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
	}

	public void L09FA6C()
	{
		A = [0x0000 + X];
		Stack.Push(X);
		X = Y;
		[0x00129C + X] = A;
		X = Stack.Pop();
		X++;
		X++;
		Y++;
		Y++;
		C = 1; temp = Y - 0x0080;

		if (Z == 0)
			return this.L09FA6C();

		A = 0x0000;
		[0x00137A] = A;
		P |= 0x20;
		B = Stack.Pop();
		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void L09FA8C()
	{
		P &= ~0x30;
		X = 0x0000;
		A = [0x70002E];

		if (Z == 0)
			return this.L09FA9A();

		return this.L09FB6F();
	}

	public void L09FA9A()
	{
		Y = 0x0000;
	}

	public void L09FA9D()
	{
		C = 1;
		A -= 0x2710 - !C;

		if (N == 1)
			return this.L09FAA6();

		Y++;
		return this.L09FA9D();
	}

	public void L09FAA6()
	{
		C = 0;
		A += 0x2710 + C;
		[0x1125] = A;
		A = Y;
		P |= 0x20;
		C = 0;
		A += 0x30 + C;
		[0x7020F4 + X] = A;
		X++;
		P &= ~0x20;
		A = [0x1125];
		Y = 0x0000;
	}

	public void L09FAC0()
	{
		C = 1;
		A -= 0x03E8 - !C;

		if (N == 1)
			return this.L09FAC9();

		Y++;
		return this.L09FAC0();
	}

	public void L09FAC9()
	{
		C = 0;
		A += 0x03E8 + C;
		[0x1125] = A;
		A = Y;
		P |= 0x20;
		C = 0;
		A += 0x30 + C;
		[0x7020F4 + X] = A;
		X++;
		P &= ~0x20;
		A = [0x1125];
		Y = 0x0000;
	}

	public void L09FAE3()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.L09FAEC();

		Y++;
		return this.L09FAE3();
	}

	public void L09FAEC()
	{
		C = 0;
		A += 0x0064 + C;
		[0x1125] = A;
		A = Y;
		P |= 0x20;
		C = 0;
		A += 0x30 + C;
		[0x7020F4 + X] = A;
		X++;
		P &= ~0x20;
		A = [0x1125];
		Y = 0x0000;
	}

	public void L09FB06()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.L09FB0F();

		Y++;
		return this.L09FB06();
	}

	public void L09FB0F()
	{
		C = 0;
		A += 0x000A + C;
		[0x1125] = A;
		A = Y;
		P |= 0x20;
		C = 0;
		A += 0x30 + C;
		[0x7020F4 + X] = A;
		X++;
		A = [0x1125];
		C = 0;
		A += 0x30 + C;
		[0x7020F4 + X] = A;
		X++;
		A = 0x30;
		[0x7020F4 + X] = A;
		X++;
		A = 0x30;
		[0x7020F4 + X] = A;
		X++;
		A = 0x00;
		[0x7020F4 + X] = A;
		X = 0x0000;
		Y = 0x0000;
	}

	public void L09FB46()
	{
		A = [0x7020F4 + X];
		C = 1; temp = A - 0x30;

		if (Z == 0)
			return this.L09FB51();

		X++;
		return this.L09FB46();
	}

	public void L09FB51()
	{
		A = [0x7020F4 + X];
		Stack.Push(X);
		X = Y;
		[0x702091 + X] = A;
		X = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.L09FB64();

		X++;
		Y++;
		return this.L09FB51();
	}

	public void L09FB64()
	{
		A = 0x0E;
		[0x702090] = A;
		this.L03EA26();
		return;
	}

	public void L09FB6F()
	{
		P |= 0x20;
		A = 0x0E;
		[0x702090] = A;
		A = 0x30;
		[0x702091] = A;
		A = 0x00;
		[0x702092] = A;
		this.L03EA26();
		return;
	}

	public void L09FB88()
	{
		P &= ~0x30;
		A = 0x93B4;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x09;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void L09FBB0()
	{
		A = [0x701000 + X];
		[0x7F8000 + X] = A;
		X++;
		C = 1; temp = X - 0x1800;

		if (Z == 0)
			return this.L09FBB0();

		P &= ~0x30;
		A = 0xA084;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x09;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void L09FBE6()
	{
		A = [0x701000 + X];
		[0x7F9800 + X] = A;
		X++;
		C = 1; temp = X - 0x1800;

		if (Z == 0)
			return this.L09FBE6();

		P &= ~0x30;
		A = 0xAD04;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x09;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void L09FC1C()
	{
		A = [0x701000 + X];
		[0x7FB000 + X] = A;
		X++;
		C = 1; temp = X - 0x1800;

		if (Z == 0)
			return this.L09FC1C();

		P &= ~0x30;
		A = 0xB2A4;
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x09;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.L7ED7E8_ExecuteSuperFX();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void L09FC52()
	{
		A = [0x701000 + X];
		[0x7FC800 + X] = A;
		X++;
		C = 1; temp = X - 0x1800;

		if (Z == 0)
			return this.L09FC52();

		return;
	}

	public void L0CF550()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		this.L02CC8F();
	}

	public void L0CF55D()
	{
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		A = 0x0013;
		this.L029283_LoadSong();
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x198F] = A;
		[0x1ACF] = A;
		P |= 0x20;
		this.L029634();
		this.L0380F7();
		this.L038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x000F;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.L03A17D_ResetSound();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF8C();
		X = 0x005F;
		[0x197C] = X;
	}

	public void L0CF5F2()
	{
		[0x1ACB] = 0;
		this.L02C897_LongFunction();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void L0CF600()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		this.L02C897_LongFunction();
		P &= ~0x30;
		A = 0x0002;
		[0x700064] = A;
		A = 0x002C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		X = [0x1990];
		A = [0x0BF8A4 + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L0CF67B();

		this.L03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L0CF652();

		[0x1992] = A;
		return this.L0CF681();
	}

	public void L0CF652()
	{
		X = [0x1990];
		A = [0x0BF8A6 + X];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		C = 1; temp = A - 0x0050;

		if (Z == 1)
			return this.L0CF681();

		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		A = [0x1990];
		C = 1; temp = A - 0x0040;

		if (Z == 1)
			return this.L0CF6D1();

		return this.L0CF681();
	}

	public void L0CF67B()
	{
		this.L03EFEA();
		return this.L0CF685();
	}

	public void L0CF681()
	{
		this.L03EFCF();
	}

	public void L0CF685()
	{
		P &= ~0x30;
		A = [0x197C];

		if (N == 1)
			return this.L0CF69F();

		P |= 0x20;
		A = [0x1188];
		temp = A & 0x90;

		if (Z == 0)
			return this.L0CF69C();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L0CF69F();

	}

	public void L0CF69C()
	{
		return this.L0CF600();
	}

	public void L0CF69F()
	{
		P &= ~0x20;
		A = 0x0001;
		this.L029310_SendApuCommand();
		P |= 0x20;
		this.L02CC8F();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		P &= ~0x20;
		A = 0x0004;
		this.L029283_LoadSong();
		this.L09F8D2();
		this.L0CF878();
		return;
	}

	public void L0CF6D1()
	{
		this.L02CC7C();
		this.L02C494();
		P &= ~0x20;
		A = 0x0010;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		return this.L0CF5F2();
	}

	public void L0CF6F7()
	{
		this.L02CC8F();
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.L029634();
		this.L0380F7();
		this.L038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.L02C494();
		P &= ~0x20;
		A = [0x1AD6];
		C = 1; temp = A - 0x0001;

		if (Z == 1)
			return this.L0CF740();

		A = 0x0015;
		return this.L0CF743();
	}

	public void L0CF740()
	{
		A = 0x0011;
	}

	public void L0CF743()
	{
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.L03A17D_ResetSound();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF8C();
	}

	public void L0CF77F()
	{
		P |= 0x20;
		A = [0x1AD6];
		C = 1; temp = A - 0x0A;

		if (Z == 1)
			return this.L0CF78F();

		A = [0x10EF];
		temp = A & 0x08;

		if (Z == 1)
			return this.L0CF7B0();

	}

	public void L0CF78F()
	{
		this.L02C1B3();
		P |= 0x20;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		P &= ~0x20;
		A = [0x1AD6];
		C = 1; temp = A - 0x000A;

		if (Z == 1)
			return this.L0CF7B0();

		A = [0x1986];
		[0xF4] = A;
	}

	public void L0CF7B0()
	{
		P |= 0x20;
		P &= ~0x10;
		this.L02C897_LongFunction();
		P &= ~0x30;
		A = 0x0002;
		[0x700064] = A;
		A = 0x0028;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		A = [0x1986];
		C = 0;
		A += [0x1AD6] + C;
		A--;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x1990] + C;
		[0x1988] = A;
		X = A;
		A = [0x0BF83C + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L0CF830();

		this.L03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L0CF80C();

		[0x1992] = A;
		return this.L0CF836();
	}

	public void L0CF80C()
	{
		X = [0x1988];
		A = [0x0BF83E + X];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0004 + C;
		C = 1; temp = A - 0x0008;

		if (Z == 0)
			return this.L0CF825();

		A = 0x0000;
	}

	public void L0CF825()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.L0CF836();
	}

	public void L0CF830()
	{
		this.L03EFEA();
		return this.L0CF83A();
	}

	public void L0CF836()
	{
		this.L03EFCF();
	}

	public void L0CF83A()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.L0CF848();

		return this.L0CF77F();
	}

	public void L0CF848()
	{
		P &= ~0x20;
		A = 0xEA02;
		this.L029213_SendApuCommand();
		P |= 0x20;
		A = 0xFF;
		P |= 0x20;
		Stack.Push(A);
		this.L02CC8F();
		this.L038168();
		this.L038000();
		P |= 0x20;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		A = Stack.Pop();
		return;
	}

	public void L0CF878()
	{
		P &= ~0x20;
		A = 0x0DAC;
		[0x1110] = A;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.L029634();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.L02C494();
		P &= ~0x20;
		A = 0x0014;
		A <<= 1;
		X = A;
		A = [0x048000 + X];
		[0x1932] = A;
		P |= 0x20;
		this.L00E0BA_Done();
		X = [0x1932];
		this.L00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		[0x110E] = 0;
		A = [0x0BF930];
		[0x110C] = A;
		P |= 0x20;
		this.L03A17D_ResetSound();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC + X];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.L03EF8C();
	}

	public void L0CF8F9()
	{
		P &= ~0x20;
		X = [0x1990];
		A = [0x0BF930 + X];
		[0x110C] = A;
		P |= 0x20;
		P &= ~0x10;
		this.L02C897_LongFunction();
		P &= ~0x30;
		A = 0x0000;
		[0x70022C] = A;
		A = 0x0046;
		[0x700064] = A;
		A = 0x00B0;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		X = [0x1990];
		A = [0x0BF932 + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x30;
		A = 0x0002;
		[0x700064] = A;
		A = 0x002C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x198C];
		[0x70022C] = A;
		X = [0x1990];
		A = [0x0BF92C + X];
		[0x7000BA] = A;
		this.L03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.L0CF9A4();

		A = [0x10EF];
		A &= 0x0008;

		if (Z == 1)
			return this.L0CF979();

		return this.L0CF9AA();
	}

	public void L0CF979()
	{
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.L0CF984();

		[0x1992] = A;
		return this.L0CF9AA();
	}

	public void L0CF984()
	{
		A = 0x003C;
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		C = 1; temp = A - 0x0090;

		if (Z == 0)
			return this.L0CF999();

		return this.L0CFAC4_Skip();
	}

	public void L0CF999()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.L0CF9AA();
	}

	public void L0CF9A4()
	{
		this.L03EFEA();
		return this.L0CF9AE();
	}

	public void L0CF9AA()
	{
		this.L03EFCF();
	}

	public void L0CF9AE()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10EF];
		A &= 0x08;

		if (Z == 0)
			return this.L0CF9BC();

		return this.L0CFAAE();
	}

	public void L0CF9BC()
	{
		A = [0x10C0];
		A &= 0x10;

		if (Z == 1)
			return this.L0CF9CA();

		this.L03A572();
		return this.L0CF8F9();
	}

	public void L0CF9CA()
	{
		X = [0x10FC];
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.L0CF9D8();

		return this.L0CF9DC();
	}

	public void L0CF9D8()
	{
		[0x12 + X]++;
		[0x12 + X]++;
	}

	public void L0CF9DC()
	{
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.L0CF9E7();

		return this.L0CF9EB();
	}

	public void L0CF9E7()
	{
		[0x12 + X]--;
		[0x12 + X]--;
	}

	public void L0CF9EB()
	{
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.L0CF9F6();

		return this.L0CF9FA();
	}

	public void L0CF9F6()
	{
		[0x13 + X]++;
		[0x13 + X]++;
	}

	public void L0CF9FA()
	{
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.L0CFA05();

		return this.L0CFA09();
	}

	public void L0CFA05()
	{
		[0x13 + X]--;
		[0x13 + X]--;
	}

	public void L0CFA09()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.L0CFA14();

		return this.L0CFA18();
	}

	public void L0CFA14()
	{
		[0x14 + X]++;
		[0x14 + X]++;
	}

	public void L0CFA18()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.L0CFA23();

		return this.L0CFA27();
	}

	public void L0CFA23()
	{
		[0x14 + X]--;
		[0x14 + X]--;
	}

	public void L0CFA27()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.L0CFA32();

		return this.L0CFA40();
	}

	public void L0CFA32()
	{
		P &= ~0x20;
		A = [0x1110];
		C = 1;
		A -= 0x000A - !C;
		[0x1110] = A;
		P |= 0x20;
	}

	public void L0CFA40()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 0)
			return this.L0CFA4B();

		return this.L0CFA59();
	}

	public void L0CFA4B()
	{
		P &= ~0x20;
		A = [0x1110];
		C = 0;
		A += 0x000A + C;
		[0x1110] = A;
		P |= 0x20;
	}

	public void L0CFA59()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.L0CFA64();

		return this.L0CFA85();
	}

	public void L0CFA64()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.L0CFA6F();

		return this.L0CFA85();
	}

	public void L0CFA6F()
	{
		P &= ~0x20;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		C = 1; temp = A - 0x0190;

		if (Z == 0)
			return this.L0CFA80();

		A = 0x0000;
	}

	public void L0CFA80()
	{
		[0x1990] = A;
		P |= 0x20;
	}

	public void L0CFA85()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.L0CFA90();

		return this.L0CFAAE();
	}

	public void L0CFA90()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.L0CFA9B();

		return this.L0CFAAE();
	}

	public void L0CFA9B()
	{
		P &= ~0x20;
		A = [0x1990];
		C = 1;
		A -= 0x0008 - !C;

		if (N == 0)
			return this.L0CFAA9();

		A = 0x0188;
	}

	public void L0CFAA9()
	{
		[0x1990] = A;
		P |= 0x20;
	}

	public void L0CFAAE()
	{
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.L0CFAC4_Skip();

		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		return this.L0CF8F9();
	}

	public void L0CFAC4_Skip()
	{
		P |= 0x20;
		this.L02CC8F();
		this.L038168();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		return;
	}

	public void L7EC654()
	{
		P &= ~0x30;
		A = [0x10DB];

		if (Z == 0)
			return this.L7EC65C_Skip();

		return;
	}

	public void L7EC65C_Skip()
	{
		A = [0x1AEE];
		[0x7001B6] = A;
		A = [0x001ABB];
		[0x700058] = A;
		A = [0x001ABD];
		[0x70005A] = A;
		A = [0x1ACF];
		A &= 0x00FF;
		[0x700236] = A;
		A = 0xFFFF;
		X = [0x1286];

		if (Z == 1)
			return this.L7EC68B_Skip();

		A = [0x28 + X];
		A >>= 1;
		A &= 0x00FF;
	}

	public void L7EC68B_Skip()
	{
		[0x70025C] = A;
		A = [0x1AC3];
		[0x7001BA] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xC53A;
		[0x3034] = A;
		A = [0x1923];
		A |= 0x18;
		[0x303A] = A;
		[0x301E] = X;
		this.L7EC6C2();
		P |= 0x20;
	}

	public void L7EC6B0_Wait()
	{
		A = [0x3030];
		A &= 0x20;

		if (Z == 0)
			return this.L7EC6B0_Wait();

		A = [0x1923];
		[0x303A] = A;
		this.L02C80C();
		return;
	}

	public void L7EC6C2()
	{
		this.L7EC6CB();
		return;
	}

	public void L7EC6CB()
	{
		Stack.Push(B);
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = 0x7E;
		Stack.Push(A);
		B = Stack.Pop();
		X = [0x10DB];
	}

	public void L7EC6D8()
	{
		A = [0x001D + X];
		A &= 0x08;

		if (Z == 1)
			return this.L7EC6E3();

		return this.L7EC6F2();
	}

	public void L7EC6E3()
	{
		A = 0x01;
		[0x2B + X] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x1B + X] = A;
		P |= 0x20;
		return this.L7EC702();
	}

	public void L7EC6F2()
	{
		A = [0x001D + X];
		A |= 0x80;
		[0x001D + X] = A;
		A = [0x001D + X];
		A &= 0xF7;
		[0x001D + X] = A;
	}

	public void L7EC702()
	{
		Y = X;
		X = [0x00 + Y];

		if (Z == 0)
			return this.L7EC6D8();

		A = [0x1DC6];

		if (Z == 1)
			return this.L7EC723();

		X = 0x0000;
	}

	public void L7EC70F()
	{
		Stack.Push(X);
		this.L7EC726();
		X = Stack.Pop();
		P &= ~0x20;
		A = X;
		C = 0;
		A += 0x000A + C;
		X = A;
		P |= 0x20;
		[0x1DC6]--;

		if (Z == 0)
			return this.L7EC70F();

	}

	public void L7EC723()
	{
		P = Stack.Pop();
		B = Stack.Pop();
		return;
	}

	public void L7EC726()
	{
		[0x7B] = X;
		Y = [0xDBB2 + X];
		X = Y;
		[0x79] = X;
		A = [0x001D + X];
		A &= 0x08;

		if (Z == 1)
			return this.L7EC738();

		return this.L7ECA3A();
	}

	public void L7EC738()
	{
		Y = [0x04 + X];
		[0x1DCE] = Y;
		Y = [0x7B];
		[0x1DC4] = 0;
		[0x1AC6] = 0;
		P &= ~0x20;
		A = [0xDBB4 + Y];

		if (Z == 0)
			return this.L7EC74F();

		return this.L7ECA3D();
	}

	public void L7EC74F()
	{
		Y = A;
		P |= 0x20;
		[0x1DC5] = 0;
		A = [0x0002 + Y];

		if (Z == 1)
			return this.L7EC784();

		A--;
		[0x00] = A;
		A = [0x7E1CDC + X];

		if (N == 0)
			return this.L7EC769();

		A &= [0x00];

		if (Z == 1)
			return this.L7EC784();

		return this.L7EC770();
	}

	public void L7EC769()
	{
		A = [0x00];
		A &= [0x1982];

		if (Z == 1)
			return this.L7EC784();

	}

	public void L7EC770()
	{
		P &= ~0x20;
		A &= 0x007F;
		[0x00] = A;
		A = Y;
		Y = [0x00];
		C = 0;
	}

	public void L7EC77B()
	{
		A += 0x0012 + C;
		Y--;

		if (Z == 0)
			return this.L7EC77B();

		Y = A;
		P |= 0x20;
	}

	public void L7EC784()
	{
		A = [0x0009 + Y];
		[0x1AC5] = A;
		temp = A & 0x70;

		if (Z == 0)
			return this.L7EC791();

		return this.L7EC9F3();
	}

	public void L7EC791()
	{
		temp = A & 0x10;

		if (Z == 1)
			return this.L7EC798();

		return this.L7EC974();
	}

	public void L7EC798()
	{
		temp = A & 0x20;

		if (Z == 1)
			return this.L7EC79F();

		return this.L7EC8F2();
	}

	public void L7EC79F()
	{
		temp = A & 0x40;

		if (Z == 1)
			return this.L7EC7A6();

		return this.L7EC870();
	}

	public void L7EC7A6()
	{
		A = [0x0003 + Y];
		[0x00] = A;
		[0x02] = A;
		A = [0x0005 + Y];
		[0x06] = A;
		[0x08] = A;
		A = [0x14 + X];

		if (Z == 1)
			return this.L7EC7BB();

		this.L7ED2CE();
	}

	public void L7EC7BB()
	{
		A = [0x08];
		[0x06] = A;
		A = [0x0007 + Y];
		[0x93] = A;
		[0x1997] = A;
		A = [0x12 + X];

		if (Z == 1)
			return this.L7EC7CE();

		this.L7ED131();
	}

	public void L7EC7CE()
	{
		A = [0x02];
		[0x00] = A;
		A = [0x08];
		[0x06] = A;
		A = [0x13 + X];

		if (Z == 1)
			return this.L7EC7DD();

		this.L7ECF91();
	}

	public void L7EC7DD()
	{
		P &= ~0x20;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC7EB();

		A |= 0xFF00;
		return this.L7EC7EE();
	}

	public void L7EC7EB()
	{
		A &= 0x00FF;
	}

	public void L7EC7EE()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC807();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC7FE()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC7FE();

		Y = [0x1AC7];
		return this.L7EC809();
	}

	public void L7EC807()
	{
		A = [0x00];
	}

	public void L7EC809()
	{
		C = 0;
		A += [0x0C + X] + C;
		[0x6F] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC81B();

		A |= 0xFF00;
		return this.L7EC81E();
	}

	public void L7EC81B()
	{
		A &= 0x00FF;
	}

	public void L7EC81E()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC837();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC82E()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC82E();

		Y = [0x1AC7];
		return this.L7EC839();
	}

	public void L7EC837()
	{
		A = [0x00];
	}

	public void L7EC839()
	{
		C = 0;
		A += [0x10 + X] + C;
		[0x71] = A;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC84A();

		A |= 0xFF00;
		return this.L7EC84D();
	}

	public void L7EC84A()
	{
		A &= 0x00FF;
	}

	public void L7EC84D()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC866();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC85D()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC85D();

		Y = [0x1AC7];
		return this.L7EC868();
	}

	public void L7EC866()
	{
		A = [0x00];
	}

	public void L7EC868()
	{
		C = 0;
		A += [0x0E + X] + C;
		[0x77] = A;
		return this.L7ECA0D();
	}

	public void L7EC870()
	{
		A = [0x0005 + Y];
		[0x06] = A;
		[0x08] = A;
		A = [0x0007 + Y];
		[0x93] = A;
		[0x1997] = A;
		A = [0x12 + X];

		if (Z == 1)
			return this.L7EC886();

		this.L7ED131();
	}

	public void L7EC886()
	{
		P &= ~0x20;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC894();

		A |= 0xFF00;
		return this.L7EC897();
	}

	public void L7EC894()
	{
		A &= 0x00FF;
	}

	public void L7EC897()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC8B0();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC8A7()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC8A7();

		Y = [0x1AC7];
		return this.L7EC8B2();
	}

	public void L7EC8B0()
	{
		A = [0x00];
	}

	public void L7EC8B2()
	{
		C = 0;
		A += [0x0E + X] + C;
		[0x77] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC8C4();

		A |= 0xFF00;
		return this.L7EC8C7();
	}

	public void L7EC8C4()
	{
		A &= 0x00FF;
	}

	public void L7EC8C7()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC8E0();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC8D7()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC8D7();

		Y = [0x1AC7];
		return this.L7EC8E2();
	}

	public void L7EC8E0()
	{
		A = [0x00];
	}

	public void L7EC8E2()
	{
		C = 0;
		A += [0x10 + X] + C;
		[0x71] = A;
		A = [0x0003 + Y];
		C = 0;
		A += [0x0C + X] + C;
		[0x6F] = A;
		return this.L7ECA0D();
	}

	public void L7EC8F2()
	{
		A = [0x0003 + Y];
		[0x00] = A;
		[0x02] = A;
		A = [0x0007 + Y];
		[0x93] = A;
		[0x1997] = A;
		A = [0x13 + X];

		if (Z == 1)
			return this.L7EC908();

		this.L7ECF91();
	}

	public void L7EC908()
	{
		P &= ~0x20;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC916();

		A |= 0xFF00;
		return this.L7EC919();
	}

	public void L7EC916()
	{
		A &= 0x00FF;
	}

	public void L7EC919()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC932();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC929()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC929();

		Y = [0x1AC7];
		return this.L7EC934();
	}

	public void L7EC932()
	{
		A = [0x00];
	}

	public void L7EC934()
	{
		C = 0;
		A += [0x0C + X] + C;
		[0x6F] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC946();

		A |= 0xFF00;
		return this.L7EC949();
	}

	public void L7EC946()
	{
		A &= 0x00FF;
	}

	public void L7EC949()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC962();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC959()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC959();

		Y = [0x1AC7];
		return this.L7EC964();
	}

	public void L7EC962()
	{
		A = [0x00];
	}

	public void L7EC964()
	{
		C = 0;
		A += [0x10 + X] + C;
		[0x71] = A;
		A = [0x0005 + Y];
		C = 0;
		A += [0x0E + X] + C;
		[0x77] = A;
		return this.L7ECA0D();
	}

	public void L7EC974()
	{
		A = [0x0003 + Y];
		[0x00] = A;
		[0x02] = A;
		A = [0x0005 + Y];
		[0x06] = A;
		[0x08] = A;
		A = [0x14 + X];

		if (Z == 1)
			return this.L7EC989();

		this.L7ED2CE();
	}

	public void L7EC989()
	{
		P &= ~0x20;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC997();

		A |= 0xFF00;
		return this.L7EC99A();
	}

	public void L7EC997()
	{
		A &= 0x00FF;
	}

	public void L7EC99A()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC9B3();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC9AA()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC9AA();

		Y = [0x1AC7];
		return this.L7EC9B5();
	}

	public void L7EC9B3()
	{
		A = [0x00];
	}

	public void L7EC9B5()
	{
		C = 0;
		A += [0x0C + X] + C;
		[0x6F] = A;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7EC9C6();

		A |= 0xFF00;
		return this.L7EC9C9();
	}

	public void L7EC9C6()
	{
		A &= 0x00FF;
	}

	public void L7EC9C9()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7EC9E2();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7EC9D9()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7EC9D9();

		Y = [0x1AC7];
		return this.L7EC9E4();
	}

	public void L7EC9E2()
	{
		A = [0x00];
	}

	public void L7EC9E4()
	{
		C = 0;
		A += [0x0E + X] + C;
		[0x77] = A;
		A = [0x0007 + Y];
		C = 0;
		A += [0x10 + X] + C;
		[0x71] = A;
		return this.L7ECA0D();
	}

	public void L7EC9F3()
	{
		P &= ~0x20;
		A = [0x0003 + Y];
		C = 0;
		A += [0x0C + X] + C;
		[0x6F] = A;
		A = [0x0005 + Y];
		C = 0;
		A += [0x0E + X] + C;
		[0x77] = A;
		A = [0x0007 + Y];
		C = 0;
		A += [0x10 + X] + C;
		[0x71] = A;
	}

	public void L7ECA0D()
	{
		A = [0x000A + Y];
		[0x111D] = A;
		A = [0x000C + Y];
		[0x111F] = A;
		A = [0x000E + Y];
		[0x1121] = A;
		Stack.Push(X);
		Stack.Push(Y);
		P |= 0x20;
		A = [0x0010 + Y];
		[0x1DC4] = A;
		P &= ~0x20;
		this.L7ECA5B();
		Y = Stack.Pop();
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x0000 + Y];

		if (Z == 1)
			return this.L7ECA3A();

		return this.L7EC74F();
	}

	public void L7ECA3A()
	{
		P |= 0x20;
		return;
	}

	public void L7ECA3D()
	{
		A = [0xDBB6 + Y];
		[0x111D] = A;
		A = [0xDBB8 + Y];
		[0x111F] = A;
		A = [0xDBBA + Y];
		[0x1121] = A;
		A = [0x0C + X];
		[0x6F] = A;
		A = [0x10 + X];
		[0x71] = A;
		A = [0x0E + X];
		[0x77] = A;
	}

	public void L7ECA5B()
	{
		A = [0x1DC6];
		[0x1DC8] = A;
		Y = [0x7B];
		[0x1DCA] = Y;
		return this.L7ECF7C();
	}

	public void L7ECA69()
	{
		P |= 0x20;
		[0x1DCA] = Y;
		X = [0xDBB2 + Y];
		[0x1DC3] = 0;
		P &= ~0x20;
		Y = [0x79];
		A = [0x001D + Y];
		A &= 0x0008;

		if (Z == 1)
			return this.L7ECA83();

		return this.L7ECF7C();
	}

	public void L7ECA83()
	{
		A = [0x002C + Y];
		A &= [0x2C + X];
		A &= 0x00F8;

		if (Z == 1)
			return this.L7ECA90();

		return this.L7ECF7C();
	}

	public void L7ECA90()
	{
		A = [0x001E + X];
		A &= 0x0008;

		if (Z == 1)
			return this.L7ECAAE();

		A = [0x001E + Y];
		A &= 0x0008;

		if (Z == 1)
			return this.L7ECAA3();

		return this.L7ECF7C();
	}

	public void L7ECAA3()
	{
		A = [0x002C + Y];
		A &= 0x0001;

		if (Z == 1)
			return this.L7ECAAE();

		return this.L7ECF7C();
	}

	public void L7ECAAE()
	{
		A = [0x001E + Y];
		A &= 0x0008;

		if (Z == 1)
			return this.L7ECACC();

		A = [0x001E + X];
		A &= 0x0008;

		if (Z == 1)
			return this.L7ECAC1();

		return this.L7ECF7C();
	}

	public void L7ECAC1()
	{
		A = [0x002C + X];
		A &= 0x0001;

		if (Z == 1)
			return this.L7ECACC();

		return this.L7ECF7C();
	}

	public void L7ECACC()
	{
		A = Y;
		C = 1; temp = A - [0x19 + X];

		if (Z == 0)
			return this.L7ECAD4();

		return this.L7ECF7C();
	}

	public void L7ECAD4()
	{
		A = X;
		X = Y;
		C = 1; temp = A - [0x19 + X];

		if (Z == 0)
			return this.L7ECADD();

		return this.L7ECF7C();
	}

	public void L7ECADD()
	{
		Y = X;
		X = A;
		A = [0x0C + X];
		[0x3A] = A;
		A = [0x0E + X];
		[0x3C] = A;
		A = [0x10 + X];
		[0x3E] = A;
		A = [0x001E + X];
		A &= 0x0040;

		if (Z == 1)
			return this.L7ECB00();

		A = [0x001E + Y];
		A &= 0x0040;

		if (Z == 1)
			return this.L7ECB00();

		A = [0x04 + X];
		Y = X;
		return this.L7ECB0B();
	}

	public void L7ECB00()
	{
		A = [0x04 + X];
		Y = X;
		C = 1; temp = A - [0x1DCE];

		if (Z == 0)
			return this.L7ECB0B();

		return this.L7ECF7C();
	}

	public void L7ECB0B()
	{
		X = [0x1DCA];
		A = [0xDBB4 + X];

		if (Z == 0)
			return this.L7ECB16();

		return this.L7ECEFE();
	}

	public void L7ECB16()
	{
		Stack.Push(A);
		A = [0x3A];
		[0x1DBD] = A;
		A = [0x3C];
		[0x1DBF] = A;
		A = [0x3E];
		[0x1DC1] = A;
		A = [0xDBBA + X];
		C = 0;
		A += [0x1121] + C;
		[0x1115] = A;
		A = [0x3E];
		C = 1;
		A -= [0x71] - !C;

		if (N == 0)
			return this.L7ECB3B();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECB3B()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECB44();

		return this.L7ECB80();
	}

	public void L7ECB44()
	{
		A = [0xDBB6 + X];
		C = 0;
		A += [0x111D] + C;
		[0x1115] = A;
		A = [0x3A];
		C = 1;
		A -= [0x6F] - !C;

		if (N == 0)
			return this.L7ECB59();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECB59()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECB62();

		return this.L7ECB80();
	}

	public void L7ECB62()
	{
		A = [0xDBB8 + X];
		C = 0;
		A += [0x111F] + C;
		[0x1115] = A;
		A = [0x3C];
		C = 1;
		A -= [0x77] - !C;

		if (N == 0)
			return this.L7ECB77();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECB77()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECB84();

		return this.L7ECB80();
	}

	public void L7ECB80()
	{
		A = Stack.Pop();
		return this.L7ECF7C();
	}

	public void L7ECB84()
	{
		A = Stack.Pop();
		X = A;
	}

	public void L7ECB86()
	{
		P |= 0x20;
		A = [0x0002 + X];

		if (Z == 1)
			return this.L7ECBBB();

		A--;
		[0x00] = A;
		Stack.Push(X);
		X = Y;
		A = [0x7E1CDC + X];

		if (N == 0)
			return this.L7ECB9F();

		X = Stack.Pop();
		A &= [0x00];

		if (Z == 1)
			return this.L7ECBBB();

		return this.L7ECBA7();
	}

	public void L7ECB9F()
	{
		X = Stack.Pop();
		A = [0x00];
		A &= [0x1982];

		if (Z == 1)
			return this.L7ECBBB();

	}

	public void L7ECBA7()
	{
		P &= ~0x20;
		A &= 0x007F;
		[0x00] = A;
		A = X;
		X = [0x00];
		C = 0;
	}

	public void L7ECBB2()
	{
		A += 0x0012 + C;
		X--;

		if (Z == 0)
			return this.L7ECBB2();

		X = A;
		P |= 0x20;
	}

	public void L7ECBBB()
	{
		A = [0x0009 + X];
		[0x1AC5] = A;
		A &= 0x70;

		if (Z == 0)
			return this.L7ECBC8();

		return this.L7ECE3C();
	}

	public void L7ECBC8()
	{
		temp = A & 0x10;

		if (Z == 1)
			return this.L7ECBCF();

		return this.L7ECDB9();
	}

	public void L7ECBCF()
	{
		temp = A & 0x20;

		if (Z == 1)
			return this.L7ECBD6();

		return this.L7ECD33();
	}

	public void L7ECBD6()
	{
		temp = A & 0x40;

		if (Z == 1)
			return this.L7ECBDD();

		return this.L7ECCAD();
	}

	public void L7ECBDD()
	{
		A = [0x0003 + X];
		[0x00] = A;
		[0x02] = A;
		A = [0x0005 + X];
		[0x06] = A;
		[0x08] = A;
		A = [0x0014 + Y];

		if (Z == 1)
			return this.L7ECBF3();

		this.L7ED2CE();
	}

	public void L7ECBF3()
	{
		A = [0x08];
		[0x06] = A;
		A = [0x0007 + X];
		[0x93] = A;
		[0x1997] = A;
		A = [0x0012 + Y];

		if (Z == 1)
			return this.L7ECC07();

		this.L7ED131();
	}

	public void L7ECC07()
	{
		A = [0x02];
		[0x00] = A;
		A = [0x08];
		[0x06] = A;
		A = [0x0013 + Y];

		if (Z == 1)
			return this.L7ECC17();

		this.L7ECF91();
	}

	public void L7ECC17()
	{
		P &= ~0x20;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECC25();

		A |= 0xFF00;
		return this.L7ECC28();
	}

	public void L7ECC25()
	{
		A &= 0x00FF;
	}

	public void L7ECC28()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECC41();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECC38()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECC38();

		Y = [0x1AC7];
		return this.L7ECC43();
	}

	public void L7ECC41()
	{
		A = [0x00];
	}

	public void L7ECC43()
	{
		C = 0;
		A += [0x1DBF] + C;
		[0x3C] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECC56();

		A |= 0xFF00;
		return this.L7ECC59();
	}

	public void L7ECC56()
	{
		A &= 0x00FF;
	}

	public void L7ECC59()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECC72();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECC69()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECC69();

		Y = [0x1AC7];
		return this.L7ECC74();
	}

	public void L7ECC72()
	{
		A = [0x00];
	}

	public void L7ECC74()
	{
		C = 0;
		A += [0x1DC1] + C;
		[0x3E] = A;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECC86();

		A |= 0xFF00;
		return this.L7ECC89();
	}

	public void L7ECC86()
	{
		A &= 0x00FF;
	}

	public void L7ECC89()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECCA2();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECC99()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECC99();

		Y = [0x1AC7];
		return this.L7ECCA4();
	}

	public void L7ECCA2()
	{
		A = [0x00];
	}

	public void L7ECCA4()
	{
		C = 0;
		A += [0x1DBD] + C;
		[0x3A] = A;
		return this.L7ECE59();
	}

	public void L7ECCAD()
	{
		A = [0x0005 + X];
		[0x06] = A;
		[0x08] = A;
		A = [0x0007 + X];
		[0x93] = A;
		[0x1997] = A;
		A = [0x0012 + Y];

		if (Z == 1)
			return this.L7ECCC4();

		this.L7ED131();
	}

	public void L7ECCC4()
	{
		P &= ~0x20;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECCD2();

		A |= 0xFF00;
		return this.L7ECCD5();
	}

	public void L7ECCD2()
	{
		A &= 0x00FF;
	}

	public void L7ECCD5()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECCEE();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECCE5()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECCE5();

		Y = [0x1AC7];
		return this.L7ECCF0();
	}

	public void L7ECCEE()
	{
		A = [0x00];
	}

	public void L7ECCF0()
	{
		C = 0;
		A += [0x1DBF] + C;
		[0x3C] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECD03();

		A |= 0xFF00;
		return this.L7ECD06();
	}

	public void L7ECD03()
	{
		A &= 0x00FF;
	}

	public void L7ECD06()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECD1F();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECD16()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECD16();

		Y = [0x1AC7];
		return this.L7ECD21();
	}

	public void L7ECD1F()
	{
		A = [0x00];
	}

	public void L7ECD21()
	{
		C = 0;
		A += [0x1DC1] + C;
		[0x3E] = A;
		A = [0x1DBD];
		C = 0;
		A += [0x0003 + X] + C;
		[0x3A] = A;
		return this.L7ECE59();
	}

	public void L7ECD33()
	{
		A = [0x0003 + X];
		[0x00] = A;
		[0x02] = A;
		A = [0x0007 + X];
		[0x93] = A;
		[0x1997] = A;
		A = [0x0013 + Y];

		if (Z == 1)
			return this.L7ECD4A();

		this.L7ECF91();
	}

	public void L7ECD4A()
	{
		P &= ~0x20;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECD58();

		A |= 0xFF00;
		return this.L7ECD5B();
	}

	public void L7ECD58()
	{
		A &= 0x00FF;
	}

	public void L7ECD5B()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECD74();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECD6B()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECD6B();

		Y = [0x1AC7];
		return this.L7ECD76();
	}

	public void L7ECD74()
	{
		A = [0x00];
	}

	public void L7ECD76()
	{
		C = 0;
		A += [0x1DBD] + C;
		[0x3A] = A;
		A = [0x1997];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECD89();

		A |= 0xFF00;
		return this.L7ECD8C();
	}

	public void L7ECD89()
	{
		A &= 0x00FF;
	}

	public void L7ECD8C()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECDA5();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECD9C()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECD9C();

		Y = [0x1AC7];
		return this.L7ECDA7();
	}

	public void L7ECDA5()
	{
		A = [0x00];
	}

	public void L7ECDA7()
	{
		C = 0;
		A += [0x1DC1] + C;
		[0x3E] = A;
		A = [0x1DBF];
		C = 0;
		A += [0x0005 + X] + C;
		[0x3C] = A;
		return this.L7ECE59();
	}

	public void L7ECDB9()
	{
		A = [0x0003 + X];
		[0x00] = A;
		[0x02] = A;
		A = [0x0005 + X];
		[0x06] = A;
		[0x08] = A;
		A = [0x0014 + Y];

		if (Z == 1)
			return this.L7ECDCF();

		this.L7ED2CE();
	}

	public void L7ECDCF()
	{
		P &= ~0x20;
		A = [0x02];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECDDD();

		A |= 0xFF00;
		return this.L7ECDE0();
	}

	public void L7ECDDD()
	{
		A &= 0x00FF;
	}

	public void L7ECDE0()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECDF9();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECDF0()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECDF0();

		Y = [0x1AC7];
		return this.L7ECDFB();
	}

	public void L7ECDF9()
	{
		A = [0x00];
	}

	public void L7ECDFB()
	{
		C = 0;
		A += [0x1DBD] + C;
		[0x3A] = A;
		A = [0x08];
		temp = A & 0x0080;

		if (Z == 1)
			return this.L7ECE0D();

		A |= 0xFF00;
		return this.L7ECE10();
	}

	public void L7ECE0D()
	{
		A &= 0x00FF;
	}

	public void L7ECE10()
	{
		[0x00] = A;
		A = [0x1AC5];
		A &= 0x000F;

		if (Z == 1)
			return this.L7ECE29();

		[0x1AC7] = Y;
		Y = A;
		A = [0x00];
	}

	public void L7ECE20()
	{
		A <<= 1;
		Y--;

		if (Z == 0)
			return this.L7ECE20();

		Y = [0x1AC7];
		return this.L7ECE2B();
	}

	public void L7ECE29()
	{
		A = [0x00];
	}

	public void L7ECE2B()
	{
		C = 0;
		A += [0x1DBF] + C;
		[0x3C] = A;
		A = [0x1DC1];
		C = 0;
		A += [0x0007 + X] + C;
		[0x3E] = A;
		return this.L7ECE59();
	}

	public void L7ECE3C()
	{
		P &= ~0x20;
		A = [0x1DBD];
		C = 0;
		A += [0x0003 + X] + C;
		[0x3A] = A;
		A = [0x1DBF];
		C = 0;
		A += [0x0005 + X] + C;
		[0x3C] = A;
		A = [0x1DC1];
		C = 0;
		A += [0x0007 + X] + C;
		[0x3E] = A;
	}

	public void L7ECE59()
	{
		A = [0x000E + X];
		C = 0;
		A += [0x1121] + C;
		[0x1115] = A;
		A = [0x3E];
		C = 1;
		A -= [0x71] - !C;

		if (N == 0)
			return this.L7ECE6E();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECE6E()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECE77();

		return this.L7ECEC0();
	}

	public void L7ECE77()
	{
		A = [0x000A + X];
		C = 0;
		A += [0x111D] + C;
		[0x1115] = A;
		A = [0x3A];
		C = 1;
		A -= [0x6F] - !C;

		if (N == 0)
			return this.L7ECE8C();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECE8C()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECE95();

		return this.L7ECEC0();
	}

	public void L7ECE95()
	{
		A = [0x000C + X];
		C = 0;
		A += [0x111F] + C;
		[0x1115] = A;
		A = [0x3C];
		C = 1;
		A -= [0x77] - !C;

		if (N == 0)
			return this.L7ECEAA();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECEAA()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECEB3();

		return this.L7ECEC0();
	}

	public void L7ECEB3()
	{
		P |= 0x20;
		A = [0x0010 + X];
		A |= [0x1DC3];
		[0x1DC3] = A;
		P &= ~0x20;
	}

	public void L7ECEC0()
	{
		A = [0x0000 + X];
		X = A;

		if (Z == 1)
			return this.L7ECEC9();

		return this.L7ECB86();
	}

	public void L7ECEC9()
	{
		P |= 0x20;
		A = [0x1DC3];

		if (Z == 1)
			return this.L7ECEFB();

		Stack.Push(X);
		X = [0x79];
		A = [0x001D + X];
		A |= 0x08;
		[0x001D + X] = A;
		[0x1B + X] = X;
		A = [0x001D + Y];
		A |= 0x08;
		[0x001D + Y] = A;
		[0x1B + Y] = Y;
		A = [0x0033 + Y];
		A |= [0x1DC3];
		[0x0033 + Y] = A;
		A = [0x33 + X];
		A |= [0x1DC4];
		[0x33 + X] = A;
		X = Stack.Pop();
		return this.L7ECF8E();
	}

	public void L7ECEFB()
	{
		return this.L7ECF7C();
	}

	public void L7ECEFE()
	{
		A = [0xDBBA + X];
		C = 0;
		A += [0x1121] + C;
		[0x1115] = A;
		A = [0x3E];
		C = 1;
		A -= [0x71] - !C;

		if (N == 0)
			return this.L7ECF13();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECF13()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECF1C();

		return this.L7ECF7C();
	}

	public void L7ECF1C()
	{
		A = [0xDBB6 + X];
		C = 0;
		A += [0x111D] + C;
		[0x1115] = A;
		A = [0x3A];
		C = 1;
		A -= [0x6F] - !C;

		if (N == 0)
			return this.L7ECF31();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECF31()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECF3A();

		return this.L7ECF7C();
	}

	public void L7ECF3A()
	{
		A = [0xDBB8 + X];
		C = 0;
		A += [0x111F] + C;
		[0x1115] = A;
		A = [0x3C];
		C = 1;
		A -= [0x77] - !C;

		if (N == 0)
			return this.L7ECF4F();

		A ^= 0xFFFF;
		A++;
	}

	public void L7ECF4F()
	{
		C = 1;
		A -= [0x1115] - !C;

		if (N == 1)
			return this.L7ECF58();

		return this.L7ECF7C();
	}

	public void L7ECF58()
	{
		Stack.Push(X);
		X = [0x79];
		P |= 0x20;
		A = [0x001D + X];
		A |= 0x08;
		[0x001D + X] = A;
		[0x1B + X] = X;
		A = [0x001D + Y];
		A |= 0x08;
		[0x001D + Y] = A;
		[0x1B + Y] = Y;
		A = [0x33 + X];
		A |= [0x1DC4];
		[0x33 + X] = A;
		X = Stack.Pop();
		return this.L7ECF8E();
	}

	public void L7ECF7C()
	{
		P &= ~0x20;
		A = [0x1DCA];
		C = 0;
		A += 0x000A + C;
		Y = A;
		[0x1DC8]--;

		if (Z == 1)
			return this.L7ECF8E();

		return this.L7ECA69();
	}

	public void L7ECF8E()
	{
		P |= 0x20;
		return;
	}

	public void L7ECF91()
	{
		Stack.Push(Y);
		Stack.Push(X);
		Stack.Push(P);
		P |= 0x10;
		A ^= 0xFF;
		A++;
		X = A;
		A = [0x7ED4A6 + X];
		[0x19C9] = A;
		A = [0x7ED466 + X];
		[0x19C8] = A;
		A = [0x00];

		if (N == 1)
			return this.L7ECFC5();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ECFEC();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ECFFC();
	}

	public void L7ECFC5()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ECFDA();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ECFF5();
	}

	public void L7ECFDA()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ECFFC();
	}

	public void L7ECFEC()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ECFF5()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ECFFC()
	{
		X = A;
		[0x02] = X;
		A = [0x93];

		if (N == 1)
			return this.L7ED01C();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED043();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED053();
	}

	public void L7ED01C()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED031();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED04C();
	}

	public void L7ED031()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED053();
	}

	public void L7ED043()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED04C()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED053()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x02] + C;
		[0x02] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED064();

		A = 0xFF;
		[0x03] = A;
		return this.L7ED066();
	}

	public void L7ED064()
	{
		[0x03] = 0;
	}

	public void L7ED066()
	{
		A = [0x00];

		if (N == 1)
			return this.L7ED083();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED0AA();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED0BA();
	}

	public void L7ED083()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED098();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED0B3();
	}

	public void L7ED098()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED0BA();
	}

	public void L7ED0AA()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED0B3()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED0BA()
	{
		X = A;
		A = X;
		A ^= 0xFF;
		A++;
		[0x1997] = A;
		A = [0x93];

		if (N == 1)
			return this.L7ED0DF();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED106();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED116();
	}

	public void L7ED0DF()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED0F4();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED10F();
	}

	public void L7ED0F4()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED116();
	}

	public void L7ED106()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED10F()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED116()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x1997] + C;
		[0x1997] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED12A_Skip();

		A = 0xFF;
		[0x1998] = A;
		return this.L7ED12D_Done();
	}

	public void L7ED12A_Skip()
	{
		[0x1998] = 0;
	}

	public void L7ED12D_Done()
	{
		P = Stack.Pop();
		X = Stack.Pop();
		Y = Stack.Pop();
		return;
	}

	public void L7ED131()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(P);
		P |= 0x10;
		X = A;
		A = [0x7ED4A6 + X];
		[0x19C9] = A;
		A = [0x7ED466 + X];
		[0x19C8] = A;
		A = [0x06];

		if (N == 1)
			return this.L7ED162_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED189_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED199_Skip();
	}

	public void L7ED162_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED177_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED192_Skip();
	}

	public void L7ED177_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED199_Skip();
	}

	public void L7ED189_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED192_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED199_Skip()
	{
		X = A;
		[0x08] = X;
		A = [0x93];

		if (N == 1)
			return this.L7ED1B9_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED1E0_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED1F0_Skip();
	}

	public void L7ED1B9_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED1CE_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED1E9_Skip();
	}

	public void L7ED1CE_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED1F0_Skip();
	}

	public void L7ED1E0_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED1E9_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED1F0_Skip()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x08] + C;
		[0x08] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED201_Skip();

		A = 0xFF;
		[0x09] = A;
		return this.L7ED203_Skip();
	}

	public void L7ED201_Skip()
	{
		[0x09] = 0;
	}

	public void L7ED203_Skip()
	{
		A = [0x06];

		if (N == 1)
			return this.L7ED220_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED247_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED257_Skip();
	}

	public void L7ED220_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED235_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED250_Skip();
	}

	public void L7ED235_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED257_Skip();
	}

	public void L7ED247_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED250_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED257_Skip()
	{
		X = A;
		A = X;
		A ^= 0xFF;
		A++;
		[0x1997] = A;
		A = [0x93];

		if (N == 1)
			return this.L7ED27C_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED2A3_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED2B3_Skip();
	}

	public void L7ED27C_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED291_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED2AC_Skip();
	}

	public void L7ED291_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED2B3_Skip();
	}

	public void L7ED2A3_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED2AC_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED2B3_Skip()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x1997] + C;
		[0x1997] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED2C7_Skip();

		A = 0xFF;
		[0x1998] = A;
		return this.L7ED2CA_Done();
	}

	public void L7ED2C7_Skip()
	{
		[0x1998] = 0;
	}

	public void L7ED2CA_Done()
	{
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void L7ED2CE()
	{
		Stack.Push(Y);
		Stack.Push(X);
		Stack.Push(P);
		P |= 0x10;
		X = A;
		A = [0x7ED4A6 + X];
		[0x19C9] = A;
		A = [0x7ED466 + X];
		[0x19C8] = A;
		A = [0x00];

		if (N == 1)
			return this.L7ED2FF_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED326_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED336_Skip();
	}

	public void L7ED2FF_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED314_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED32F_Skip();
	}

	public void L7ED314_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED336_Skip();
	}

	public void L7ED326_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED32F_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED336_Skip()
	{
		X = A;
		[0x02] = X;
		A = [0x06];

		if (N == 1)
			return this.L7ED356_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED37D_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED38D_Skip();
	}

	public void L7ED356_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED36B_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED386_Skip();
	}

	public void L7ED36B_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED38D_Skip();
	}

	public void L7ED37D_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED386_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED38D_Skip()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x02] + C;
		[0x02] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED39E_Skip();

		A = 0xFF;
		[0x03] = A;
		return this.L7ED3A0_Skip();
	}

	public void L7ED39E_Skip()
	{
		[0x03] = 0;
	}

	public void L7ED3A0_Skip()
	{
		A = [0x00];

		if (N == 1)
			return this.L7ED3BD_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED3E4_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED3F4_Skip();
	}

	public void L7ED3BD_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C8];

		if (N == 1)
			return this.L7ED3D2_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED3ED_Skip();
	}

	public void L7ED3D2_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED3F4_Skip();
	}

	public void L7ED3E4_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED3ED_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED3F4_Skip()
	{
		X = A;
		A = X;
		A ^= 0xFF;
		A++;
		[0x08] = A;
		A = [0x06];

		if (N == 1)
			return this.L7ED418_Skip();

		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED43F_Skip();

		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED44F_Skip();
	}

	public void L7ED418_Skip()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x004202] = A;
		A = [0x19C9];

		if (N == 1)
			return this.L7ED42D_Skip();

		[0x004203] = A;
		Cpu.NOP();
		return this.L7ED448_Skip();
	}

	public void L7ED42D_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x004217];
		return this.L7ED44F_Skip();
	}

	public void L7ED43F_Skip()
	{
		A ^= 0xFF;
		A++;
		[0x004203] = A;
		Cpu.NOP();
		Cpu.NOP();
	}

	public void L7ED448_Skip()
	{
		A = 0x00;
		C = 1;
		A -= [0x004217] - !C;
	}

	public void L7ED44F_Skip()
	{
		X = A;
		A = X;
		C = 0;
		A += [0x08] + C;
		[0x08] = A;
		temp = A & 0x80;

		if (Z == 1)
			return this.L7ED460_Skip();

		A = 0xFF;
		[0x09] = A;
		return this.L7ED462_Done();
	}

	public void L7ED460_Skip()
	{
		[0x09] = 0;
	}

	public void L7ED462_Done()
	{
		P = Stack.Pop();
		X = Stack.Pop();
		Y = Stack.Pop();
		return;
	}

	public void L7ED7E8_ExecuteSuperFX()
	{
		[0x3034] = A;
		A = [0x1923];
		A |= 0x18;
		[0x303A] = A;
		[0x301E] = X;
	}

	public void L7ED7F6_Loop()
	{
		A = [0x3030];
		A &= 0x20;

		if (Z == 0)
			return this.L7ED7F6_Loop();

		A = [0x1923];
		[0x303A] = A;
		return;
	}
}
