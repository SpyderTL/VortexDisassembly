public class SnesRom
{
	public void A00DDDE()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x11B5];

		if (Z == 0)
			return this.A00DDEA();

		[0x1273] = 0;
	}

	public void A00DDEA()
	{
		A = [0x1ACF];

		if (Z == 0)
			return this.A00DDF4();

		A = [0x1DBA];

		if (Z == 0)
			return this.A00DDF5();

	}

	public void A00DDF4()
	{
		return;
	}

	public void A00DDF5()
	{
		P &= ~0x20;
		X = 0x30D4;
		[0x11FF] = X;
		A = [0x1277];
		A &= 0x00FF;

		if (Z == 1)
			return this.A00DE08();

		return this.A00E09A();
	}

	public void A00DE08()
	{
		A = [0x112D];
		A &= 0x0002;

		if (Z == 1)
			return this.A00DE13();

		return this.A00E09A();
	}

	public void A00DE13()
	{
		P |= 0x20;
		A = [0x1284];

		if (Z == 1)
			return this.A00DE30();

		A = [0x00F4];
		temp = A - 0x06;

		if (Z == 1)
			return this.A00DE30();

		temp = A - 0x02;

		if (Z == 1)
			return this.A00DE30();

		[0x127A] = 0;
		A = [0x1ABF];

		if (Z == 1)
			return this.A00DE92();

		return this.A00E09A();
	}

	public void A00DE30()
	{
		P &= ~0x20;
		this.A00E996();
		this.A00EAD5();
		P |= 0x20;
		A = [0x1284];

		if (Z == 0)
			return this.A00DE92();

		A = [0x1276];

		if (Z == 1)
			return this.A00DE4B();

		[0x1276]--;
		return this.A00DE92();
	}

	public void A00DE4B()
	{
		A = [0x1982];
		A &= 0x1F;

		if (Z == 0)
			return this.A00DE92();

		A = [0x1274];

		if (Z == 1)
			return this.A00DE92();

		temp = A - 0x05;

		if (N == 1)
			return this.A00DE8F();

		A = [0x1275];
		temp = A - 0x02;

		if (Z == 1)
			return this.A00DE7F();

		[0x1275]++;
		P &= ~0x20;
		A = 0x3C3C;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.A03855E();
		A = 0x64;
		[0x1276] = A;
		return this.A00DE8F();
	}

	public void A00DE7F()
	{
		A = [0x118F];

		if (Z == 0)
			return this.A00DE8F();

		X = [0x10FC];
		A = [0x15 + X];

		if (Z == 1)
			return this.A00DE8F();

		this.A03B515();
	}

	public void A00DE8F()
	{
		[0x1274] = 0;
	}

	public void A00DE92()
	{
		A = [0x127A];
		temp = A - [0x1279];

		if (Z == 1)
			return this.A00DEA2();

		[0x1279] = A;
		A = 0x05;
		[0x1278] = A;
	}

	public void A00DEA2()
	{
		A = [0x1278];

		if (Z == 1)
			return this.A00DEAA();

		[0x1278]--;
	}

	public void A00DEAA()
	{
		P &= ~0x30;
		X = [0x10FC];
		A = [0x0C + X];
		[0x113E] = A;
		A = [0x10 + X];
		[0x1142] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.A00DED8();

		A = [0x10 + X];
		temp = A - [0x1222];

		if (N == 1)
			return this.A00DECB();

		A = 0x0000;
		return this.A00DF4C();
	}

	public void A00DECB()
	{
		temp = A - [0x121E];

		if (N == 0)
			return this.A00DED5();

		A = 0x0002;
		return this.A00DF4C();
	}

	public void A00DED5()
	{
		return this.A00E04D();
	}

	public void A00DED8()
	{
		A = [0x10 + X];
		temp = A - [0x1222];

		if (N == 1)
			return this.A00DEEF();

		A = [0x31 + X];

		if (N == 1)
			return this.A00DF33();

		A = [0x10 + X];
		C = 1;
		A -= [0x31 + X] - !C;
		[0x10 + X] = A;
		A = 0x0000;
		return this.A00DF33();
	}

	public void A00DEEF()
	{
		temp = A - [0x121E];

		if (N == 0)
			return this.A00DF04();

		A = [0x31 + X];

		if (N == 0)
			return this.A00DF33();

		A = [0x10 + X];
		C = 1;
		A -= [0x31 + X] - !C;
		[0x10 + X] = A;
		A = 0x0002;
		return this.A00DF33();
	}

	public void A00DF04()
	{
		A = [0x0C + X];
		temp = A - [0x1220];

		if (N == 1)
			return this.A00DF1B();

		A = [0x2D + X];

		if (N == 1)
			return this.A00DF33();

		A = [0x0C + X];
		C = 1;
		A -= [0x2D + X] - !C;
		[0x0C + X] = A;
		A = 0x0003;
		return this.A00DF33();
	}

	public void A00DF1B()
	{
		temp = A - [0x121C];

		if (N == 0)
			return this.A00DF30();

		A = [0x2D + X];

		if (N == 0)
			return this.A00DF33();

		A = [0x0C + X];
		C = 1;
		A -= [0x2D + X] - !C;
		[0x0C + X] = A;
		A = 0x0001;
		return this.A00DF33();
	}

	public void A00DF30()
	{
		return this.A00E04D();
	}

	public void A00DF33()
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
		return this.A00E04D();
	}

	public void A00DF4C()
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
		A = [0x048487];
		A &= 0x00FF;
		temp = A - 0x00FF;

		if (Z == 0)
			return this.A00DF71();

		return this.A00E04D();
	}

	public void A00DF71()
	{
		[0x001224] = A;
		A <<= 1;
		[0x00] = A;
		A = [0x1226];
		C = 0;
		A += [0x00] + C;
		X = A;
		A = [0x02F4F2];

		if (Z == 0)
			return this.A00DF8E();

		A = [0x3C];
		[0x001224] = A;
		return this.A00E04D();
	}

	public void A00DF8E()
	{
		[0x1228] = A;
		P &= ~0x20;
		A = [0x3A];
		Stack.Push(A);
		this.A00EA70();
		P |= 0x20;
		P &= ~0x20;
		A = 0x3BA1;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.A03855E();
		P &= ~0x20;
		A = Stack.Pop();
		[0x3A] = A;
		X = [0x10FC];
		A = [0x0C + X];
		[0x24] = A;
		A = [0x10 + X];
		[0x26] = A;
		A = [0x3A];
		temp = A - 0x0000;

		if (Z == 0)
			return this.A00DFCE();

		A = [0x00121E];
		[0x10 + X] = A;
		return this.A00DFF3();
	}

	public void A00DFCE()
	{
		temp = A - 0x0001;

		if (Z == 0)
			return this.A00DFDB();

		A = [0x001220];
		[0x0C + X] = A;
		return this.A00DFF3();
	}

	public void A00DFDB()
	{
		temp = A - 0x0002;

		if (Z == 0)
			return this.A00DFE8();

		A = [0x001222];
		[0x10 + X] = A;
		return this.A00DFF3();
	}

	public void A00DFE8()
	{
		temp = A - 0x0003;

		if (Z == 0)
			return this.A00DFF3();

		A = [0x00121C];
		[0x0C + X] = A;
	}

	public void A00DFF3()
	{
		A = [0x0C + X];
		C = 1;
		A -= 0x24 - !C;
		[0x24] = A;
		A = [0x10 + X];
		C = 1;
		A -= 0x26 - !C;
		[0x26] = A;
		X = [0x10DB];

		if (Z == 1)
			return this.A00E022();

	}

	public void A00E006()
	{
		A = X;
		temp = A - [0x10FC];

		if (Z == 1)
			return this.A00E01A();

		A = [0x0C + X];
		C = 0;
		A += [0x24] + C;
		[0x0C + X] = A;
		A = [0x10 + X];
		C = 0;
		A += [0x26] + C;
		[0x10 + X] = A;
	}

	public void A00E01A()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 1)
			return this.A00E022();

		return this.A00E006();
	}

	public void A00E022()
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
		this.A00E996();
		this.A00EAD5();
		P |= 0x20;
		A = 0x01;
		[0x192E] = A;
		this.A04BA61();
	}

	public void A00E04D()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		A = [0x192F];
		C = 1;
		A -= [0x15 + X] - !C;

		if (Z == 0)
			return this.A00E061();

		[0x192E]--;

		if (Z == 0)
			return this.A00E09A();

	}

	public void A00E061()
	{
		A = 0x5A;
		C = 1;
		A -= [0x15 + X] - !C;

		if (N == 0)
			return this.A00E06A();

		A = 0x00;
	}

	public void A00E06A()
	{
		A >>= 1;
		A >>= 1;
		temp = A - 0x04;

		if (N == 0)
			return this.A00E072();

		A = 0x04;
	}

	public void A00E072()
	{
		temp = A - 0x19;

		if (N == 1)
			return this.A00E078();

		A = 0x19;
	}

	public void A00E078()
	{
		[0x192E] = A;
		A = [0x1216];

		if (Z == 0)
			return this.A00E090();

		A = [0x1284];

		if (Z == 1)
			return this.A00E090();

		A = [0x00F4];
		temp = A - 0x06;

		if (Z == 1)
			return this.A00E090();

		temp = A - 0x02;

		if (Z == 0)
			return this.A00E09A();

	}

	public void A00E090()
	{
		P &= ~0x20;
		this.A02C580();
		this.A00E0A7();
	}

	public void A00E09A()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		A = [0x15 + X];
		[0x192F] = A;
		return;
	}

	public void A00E0A7()
	{
		P &= ~0x30;
		X = [0x1932];
		A = 0xFFFF;
		[0x11F5] = A;
		[0x124C] = 0;
		this.A00E0F6();
		return;
	}

	public void A00E0BA()
	{
		return;
	}

	public void A00E0F6()
	{
		P &= ~0x20;
		A = [0x048000];
		A &= 0x00FF;
		Y = X;
		X = A;
		return [(0xE104 + X)]();
		A += [0xE3 + X] + C;
		P &= ~0xE4;
		Cpu.Break();
	}

	public void A00E8D5()
	{
		P &= ~0x30;
		A = 0x0000;
		X = 0x0FFE;
	}

	public void A00E8DD()
	{
		[0x7E563E + X] = A;
		X--;
		X--;

		if (Z == 0)
			return this.A00E8DD();

		P |= 0x20;
		P &= ~0x10;
		[0x1254] = 0;
		[0x127A] = 0;
		return;
	}

	public void A00E8F0()
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
			return this.A00E918();

		return this.A00E995();
	}

	public void A00E918()
	{
		A = [0x02F4F2];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1254] = A;
		A = [0x02F4F4];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.A7ED7E8();
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

	public void A00E977()
	{
		A = [0x701010];
		[0x7E463E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A00E977();

		Y = 0x1000;
		X = 0x0000;
	}

	public void A00E989()
	{
		A = [0x701010];
		[0x7E563E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A00E989();

	}

	public void A00E995()
	{
		return;
	}

	public void A00E996()
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
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += 0x0020 + C;
		[0x125F] = A;
		A = [0x10 + X];
		C = 0;
		A += 0x00FF + C;
		A &= 0xFE00;
		[0x1265] = A;
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
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

	public void A00EA1A()
	{
		C = 0;
		A += [0x1255] + C;
		X--;

		if (Z == 0)
			return this.A00EA1A();

		C = 0;
		A += [0x125F] + C;
		[0x125D] = A;
		temp = A - 0x1000;

		if (C == 1)
			return this.A00EA53();

		X = A;
		A = [0x1254];
		A &= 0x00FF;

		if (Z == 1)
			return this.A00EA53();

		P |= 0x20;
		A = [0x7E563E];

		if (Z == 1)
			return this.A00EA53();

		A--;
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x0AF34D];
		[0x127A] = A;
		return;
	}

	public void A00EA53()
	{
		P |= 0x20;
		A = 0x00;
		[0x127A] = A;
		return;
	}

	public void A00EA5B()
	{
		P &= ~0x30;
		A = 0x0000;
		X = 0x0FFE;
	}

	public void A00EA63()
	{
		[0x7E363E + X] = A;
		X--;
		X--;

		if (Z == 0)
			return this.A00EA63();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A00EA70()
	{
		P &= ~0x30;
		X = [0x1228];

		if (Z == 1)
			return this.A00EAD4();

		A = [0x02F4F5];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = [0x02F4F7];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.A7ED7E8();
		P &= ~0x20;
		A = [0x701004];
		[0x126B] = A;
		A = [0x701006];
		[0x126D] = A;
		A = 0x0002;
		C = 1;
		A -= 0x10B4 - !C;
		[0x3A] = A;
		A = 0x1000;
		Y = A;
		P |= 0x20;
		X = 0x0000;
	}

	public void A00EABB()
	{
		A = [0x701010];
		temp = A - 0x5C;

		if (Z == 0)
			return this.A00EACC();

		A = [0x3A];

		if (Z == 1)
			return this.A00EACC();

		A--;
		[0x3A] = A;
		A = 0x5C;
	}

	public void A00EACC()
	{
		[0x7E363E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A00EABB();

	}

	public void A00EAD4()
	{
		return;
	}

	public void A00EAD5()
	{
		P &= ~0x30;
		[0x127B] = 0;
		A = [0x125F];
		temp = A - 0x0007;

		if (C == 1)
			return this.A00EAE5();

		A = 0x0007;
	}

	public void A00EAE5()
	{
		temp = A - 0x0039;

		if (C == 0)
			return this.A00EAED();

		A = 0x0039;
	}

	public void A00EAED()
	{
		[0x3A] = A;
		C = 1;
		A -= 0x125F - !C;
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
		temp = A - 0x0007;

		if (C == 1)
			return this.A00EB09();

		A = 0x0007;
	}

	public void A00EB09()
	{
		temp = A - 0x0039;

		if (C == 0)
			return this.A00EB11();

		A = 0x0039;
	}

	public void A00EB11()
	{
		[0x3C] = A;
		C = 1;
		A -= 0x1261 - !C;
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

	public void A00EB28()
	{
		C = 0;
		A += [0x1255] + C;
		X--;

		if (Z == 0)
			return this.A00EB28();

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
		A -= 0x0C - !C;
		[0x1252] = A;
		[0x1271] = A;
		A = Stack.Pop();
		X = A;
		this.A00EB70();
		return;
	}

	public void A00EB70()
	{
		A = 0x000C;
		Y = A;
	}

	public void A00EB74()
	{
		Stack.Push(Y);
		Y = 0x000C;
		Stack.Push(X);
	}

	public void A00EB79()
	{
		[0x125D] = X;
		P |= 0x20;
		A = [0x7E363E];
		P &= ~0x20;
		A &= 0x00FF;

		if (Z == 1)
			return this.A00EBA5();

		[0x36] = A;
		[0x127B]++;
		Stack.Push(X);
		Stack.Push(Y);
		A--;
		this.A00EC12();
		Y = Stack.Pop();
		X = Stack.Pop();
		A &= 0xFFFF;

		if (Z == 0)
			return this.A00EBA5();

		P |= 0x20;
		A = 0x00;
		[0x7E363E + X] = A;
		P &= ~0x20;
	}

	public void A00EBA5()
	{
		Stack.Push(X);
		A = [0x1254];
		A &= 0x00FF;

		if (Z == 1)
			return this.A00EBE0();

		A = X;
		C = 0;
		A += 0x1000 + C;
		X = A;
		[0x125D] = X;
		P |= 0x20;
		A = [0x7E363E];
		P &= ~0x20;
		A &= 0x00FF;

		if (Z == 1)
			return this.A00EBE0();

		[0x36] = A;
		[0x127B]++;
		Stack.Push(X);
		Stack.Push(Y);
		A--;
		this.A00EC12();
		Y = Stack.Pop();
		X = Stack.Pop();
		A &= 0xFFFF;

		if (Z == 0)
			return this.A00EBE0();

		P |= 0x20;
		A = 0x00;
		[0x7E363E + X] = A;
		P &= ~0x20;
	}

	public void A00EBE0()
	{
		X = Stack.Pop();
		A = [0x1250];
		C = 0;
		A += 0x0200 + C;
		[0x1250] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A00EB79();

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
			return this.A00EC0D();

		return this.A00EB74();
	}

	public void A00EC0D()
	{
		return;
	}

	public void A00EC12()
	{
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		Stack.Push(X);
		A = [0x0AF34D];
		A &= 0x00FF;

		if (Z == 0)
			return this.A00EC38();

		A = [0x0AF348];
		temp = A - 0xE51D;

		if (Z == 0)
			return this.A00EC38();

		A = [0x127F];
		A &= 0x00FF;
		temp = A - 0x002C;

		if (C == 0)
			return this.A00EC38();

		return this.A00ED14();
	}

	public void A00EC38()
	{
		X = [0x10DB];
		Y = X;
		X = [0x10DD];

		if (Z == 0)
			return this.A00EC45();

		X = Y;
		return this.A00ED14();
	}

	public void A00EC45()
	{
		A = [0x00 + X];
		[0x10DD] = A;
		A = Y;

		if (Z == 0)
			return this.A00EC59();

		A = [0x10DB];
		[0x00 + X] = A;
		[0x02 + X] = 0;
		[0x10DB] = X;
		return this.A00EC62();
	}

	public void A00EC59()
	{
		A = [0x0000 + Y];
		[0x00 + X] = A;
		[0x00 + Y] = Y;
		[0x02 + X] = X;
	}

	public void A00EC62()
	{
		Y = [0x00 + X];

		if (Z == 1)
			return this.A00EC68();

		[0x02 + Y] = Y;
	}

	public void A00EC68()
	{
		Y = X;
		X = Stack.Pop();
		P |= 0x20;
		this.A03A054();
		P |= 0x20;
		A = [0x36];
		Stack.Push(X);
		X = Y;
		[0x7E1CDE + X] = A;
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x125D];
		[0x0034 + Y] = A;
		A = [0x0AF340];
		C = 0;
		A += [0x1250] + C;
		[0x000C + Y] = A;
		A = [0x0AF342];
		[0x000E + Y] = A;
		A = [0x0AF344];
		C = 0;
		A += [0x1252] + C;
		[0x0010 + Y] = A;
		A = [0x0AF346];
		[0x0004 + Y] = A;
		temp = A - 0xCBFC;

		if (Z == 0)
			return this.A00ECCA();

		Stack.Push(X);
		X = Y;
		this.A02C640();
		temp = A - [0x11FF];

		if (N == 0)
			return this.A00ECC9();

		[0x11FF] = A;
		A = [0x0C + X];
		[0x1201] = A;
		A = [0x0E + X];
		[0x1203] = A;
		A = [0x10 + X];
		[0x1205] = A;
	}

	public void A00ECC9()
	{
		X = Stack.Pop();
	}

	public void A00ECCA()
	{
		A = [0x0AF348];
		[0x0016 + Y] = A;
		temp = A - 0xE567;

		if (Z == 0)
			return this.A00ECDF();

		P |= 0x20;
		A = 0x20;
		[0x0009 + Y] = A;
		return this.A00ED00();
	}

	public void A00ECDF()
	{
		P &= ~0x20;
		temp = A - 0xE51D;

		if (Z == 0)
			return this.A00ECED();

		P |= 0x20;
		A = 0x01;
		[0x0009 + Y] = A;
	}

	public void A00ECED()
	{
		P |= 0x20;
		A = [0x0AF34D];
		temp = A - 0x01;

		if (C == 0)
			return this.A00ED00();

		temp = A - 0x12;

		if (C == 1)
			return this.A00ED00();

		A = 0x10;
		[0x0009 + Y] = A;
	}

	public void A00ED00()
	{
		A = [0x0AF34A];
		[0x0018 + Y] = A;
		P &= ~0x20;
		A = [0x0AF34B];
		[0x0006 + Y] = A;
		A = 0x0000;
		return;
	}

	public void A00ED14()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0xFFFF;
		return;
	}

	public void A00FD1B()
	{
		C = 0;
		temp = C; C = E; E = temp;
		return this.A0293A1();
	}

	public void A01F074()
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
		this.A01F136();
		this.A01F11B();
		this.A01F0DA();
		P = Stack.Pop();
		return;
	}

	public void A01F0DA()
	{
		A = 0xFF;
		[0x1994] = A;
		this.A01F815();
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

	public void A01F11B()
	{
		Stack.Push(P);
		P |= 0x30;
		Y = 0x00;
		X = 0x00;
		A = 0x80;
		[0x63] = A;
	}

	public void A01F126()
	{
		A = [0x9648 + Y];
		[0x7010EE + X] = A;
		X++;
		Y++;
		Y++;
		[0x63]--;

		if (Z == 0)
			return this.A01F126();

		P = Stack.Pop();
		return;
	}

	public void A01F136()
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
		this.A01F208();
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

	public void A01F1CE()
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
		this.A7ED7E8();
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

	public void A01F208()
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
		this.A7ED7E8();
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

	public void A01F334()
	{
		A = [0x00];
		[0x87] = A;
		A = [0x01];
		[0x88] = A;
		A = [0x93];
		[0x89] = A;
		A = [0x94];
		[0x8A] = A;
		this.A01F387();
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
		this.A01F387();
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
		A -= 0xCE - !C;
		[0x77] = A;
		A = [0x78];
		A -= 0xCF - !C;
		[0x78] = A;
		return;
	}

	public void A01F387()
	{
		X = 0x00;
		A = [0x8A];

		if (Z == 1)
			return this.A01F399();

		X++;
		A >>= 1;

		if (Z == 1)
			return this.A01F397();

	}

	public void A01F391()
	{
		Cpu.ROR(0x89);
		X++;
		A >>= 1;

		if (Z == 0)
			return this.A01F391();

	}

	public void A01F397()
	{
		Cpu.ROR(0x89);
	}

	public void A01F399()
	{
		[0x95] = X;
		X = 0x00;
		A = [0x88];
		[0x8E] = A;

		if (N == 0)
			return this.A01F3B0();

		A = 0x00;
		C = 1;
		A -= 0x87 - !C;
		[0x87] = A;
		A = 0x00;
		A -= 0x88 - !C;
		[0x88] = A;
	}

	public void A01F3B0()
	{

		if (Z == 1)
			return this.A01F3C1();

		X++;
		A >>= 1;

		if (Z == 1)
			return this.A01F3BC();

	}

	public void A01F3B6()
	{
		Cpu.ROR(0x87);
		X++;
		A >>= 1;

		if (Z == 0)
			return this.A01F3B6();

	}

	public void A01F3BC()
	{
		Cpu.ROR(0x87);
		return this.A01F3D8();
	}

	public void A01F3C1()
	{
		A = [0x87];

		if (N == 1)
			return this.A01F3D8();


		if (Z == 0)
			return this.A01F3D2();

		A = [0xCE];
		[0x8B] = A;
		A = [0xCF];
		[0x8C] = A;
		return this.A01F438();
	}

	public void A01F3D2()
	{
		X--;
		A <<= 1;

		if (N == 0)
			return this.A01F3D2();

		[0x87] = A;
	}

	public void A01F3D8()
	{
		A = [0x89];
		temp = A - [0x87];

		if (C == 0)
			return this.A01F3E6();

	}

	public void A01F3DE()
	{
		X--;
		A >>= 1;
		temp = A - [0x87];

		if (C == 1)
			return this.A01F3DE();

		[0x89] = A;
	}

	public void A01F3E6()
	{
		A = X;
		C = 1;
		A -= 0x95 - !C;
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
			return this.A01F40F();


		if (Z == 1)
			return this.A01F415();

	}

	public void A01F406()
	{
		A <<= 1;
		Cpu.ROL(0x8C);
		X--;

		if (Z == 0)
			return this.A01F406();

		return this.A01F415();
	}

	public void A01F40F()
	{
		[0x8C] >>= 1;
		Cpu.ROR();
		X++;

		if (Z == 0)
			return this.A01F40F();

	}

	public void A01F415()
	{
		[0x8B] = A;
		temp = A & [0x8E];

		if (N == 0)
			return this.A01F42B();

		C = 1;
		A = [0xCE];
		A -= 0x8B - !C;
		[0x8B] = A;
		A = [0xCF];
		A -= 0x8C - !C;
		[0x8C] = A;
		return this.A01F438();
	}

	public void A01F42B()
	{
		C = 0;
		A = [0x8B];
		A += [0xCE] + C;
		[0x8B] = A;
		A = [0x8C];
		A += [0xCF] + C;
		[0x8C] = A;
	}

	public void A01F438()
	{
		return;
	}

	public void A01F622()
	{

		if (N == 0)
			return this.A01F627();

		return this.A01F825();
	}

	public void A01F627()
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
		A -= 0x1137 - !C;
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
		this.A01F1CE();
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
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A81] = A;
		A = [0x19F2];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A83] = A;
		A = [0x19F4];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A85] = A;
		A = [0x19F6];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A87] = A;
		A = [0x19F8];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A89] = A;
		A = [0x19FA];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8B] = A;
		A = [0x19FC];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8D] = A;
		A = [0x19FE];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x1A8F] = A;
		A = [0x1A00];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
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

	public void A01F815()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBA8F;
		this.A7ED7E8();
		P |= 0x30;
		return;
	}

	public void A01F825()
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

	public void A01F87E()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		X = 0x001C;
	}

	public void A01F886()
	{
		A = [0x01F8BD];
		[0x7ED7E8 + X] = A;
		X--;

		if (N == 0)
			return this.A01F886();

		X = 0x0053;
	}

	public void A01F894()
	{
		A = [0x01FC87];
		[0x000101 + X] = A;
		X--;

		if (N == 0)
			return this.A01F894();

		X = 0x03AE;
	}

	public void A01F8A2()
	{
		A = [0x01F8D9];
		[0x7ED804 + X] = A;
		X--;

		if (N == 0)
			return this.A01F8A2();

		X = 0x1193;
	}

	public void A01F8B0()
	{
		A = [0x028000];
		[0x7EC654 + X] = A;
		X--;

		if (N == 0)
			return this.A01F8B0();

		P = Stack.Pop();
		return;
	}

	public void A02915C()
	{
		P &= ~0x20;
		A = 0x0C00;
		A |= [0x10B2];
		return this.A029213();
	}

	public void A029167()
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

	public void A02917E()
	{
		[0x7E2D5E + X] = A;
		[0x7E2D9A + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.A02917E();

		return;
	}

	public void A029213()
	{
		P &= ~0x30;
		A |= [0x109C];
		Stack.Push(X);
		X = [0x10A0];
		temp = X - [0x10A2];

		if (Z == 0)
			return this.A029225();

		[0x002140] = A;
	}

	public void A029225()
	{
		[0x7E2D5E + X] = A;
		X++;
		X++;
		temp = X - 0x003C;

		if (Z == 0)
			return this.A029233();

		X = 0x0000;
	}

	public void A029233()
	{
		[0x10A0] = X;
		A = [0x109C];
		A ^= 0x0100;
		[0x109C] = A;
		X = Stack.Pop();
		return;
	}

	public void A029241()
	{
		P &= ~0x20;
		[0x109C] = 0;
		[0x109E] = 0;
		A = 0x8000;
		[0x53] = A;
		A = 0x000E;
		[0x55] = A;
		this.A02931D();
		return;
	}

	public void A029283()
	{
		Stack.Push(X);
		Stack.Push(A);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x30;
		A <<= 1;
		X = A;
		this.A0292C9();
		A = 0x4201;
		this.A029213();
		P = Stack.Pop();
		Y = Stack.Pop();
		A = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A02929A()
	{
		P &= ~0x30;
		[0x0010B0] = A;
		A <<= 1;
		X = A;
		this.A0292C9();
		A = 0x4203;
		this.A029213();
		return;
	}

	public void A0292AD()
	{
		Stack.Push(X);
		Stack.Push(A);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x30;
		A = 0x0011;
		A <<= 1;
		X = A;
		this.A0292C9();
		A = 0x0001;
		this.A029310();
		P &= ~0x20;
		P = Stack.Pop();
		Y = Stack.Pop();
		A = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A0292C9()
	{
		A = [0x029257];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = 0x0F;
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.A7ED7E8();
		P &= ~0x20;
		A = 0x1000;
		[0x53] = A;
		A = 0x0070;
		[0x55] = A;
		this.A02931D();
		P &= ~0x20;
		Y = 0x0002;
	}

	public void A0292FD()
	{
		temp = Y - [0x2140];

		if (Z == 0)
			return this.A0292FD();

		this.A029167();
		return;
	}

	public void A029310()
	{
		P &= ~0x20;
		A &= 0x00FF;
		A |= 0x0400;
		this.A029213();
		return;
	}

	public void A02931D()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(A);
		Stack.Push(P);
		this.A029167();
		P &= ~0x30;
		Y = 0x0000;
		A = 0xBBAA;
	}

	public void A02932C()
	{
		temp = A - [0x2140];

		if (Z == 0)
			return this.A02932C();

		P |= 0x20;
		A = 0xCC;
		return this.A029367();
	}

	public void A029337()
	{
		[0x55]++;
		Y = 0x0000;
		A = (A >> 4) | (A << 4);
		return this.A02934E();
	}

	public void A02933F()
	{
		A = [[0x53] + Y];
		Y++;
		A = (A >> 4) | (A << 4);
		A = 0x00;
		return this.A029354();
	}

	public void A029347()
	{
		A = (A >> 4) | (A << 4);
		A = [[0x53] + Y];
		Y++;

		if (N == 1)
			return this.A029337();

		A = (A >> 4) | (A << 4);
	}

	public void A02934E()
	{
		temp = A - [0x2140];

		if (Z == 0)
			return this.A02934E();

		A++;
	}

	public void A029354()
	{
		P &= ~0x20;
		[0x2140] = A;
		P |= 0x20;
		X--;

		if (Z == 0)
			return this.A029347();

	}

	public void A02935E()
	{
		temp = A - [0x2140];

		if (Z == 0)
			return this.A02935E();

	}

	public void A029363()
	{
		A += 0x03 + C;

		if (Z == 1)
			return this.A029363();

	}

	public void A029367()
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
		temp = X - 0x0001;
		A = 0x00;
		Cpu.ROL();
		[0x2141] = A;
		A += 0x7F + C;
		A = Stack.Pop();
		[0x2140] = A;
	}

	public void A029387()
	{
		temp = A - [0x2140];

		if (Z == 0)
			return this.A029387();


		if (F.BVS)
			return this.A02933F();

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

	public void A0293A1()
	{
		I = 1;
		C = 0;
		temp = C; C = E; E = temp;
		P &= ~0x30;
		A = 0x0000;
		Cpu.TCD();
		X = 0x02FF;
		S = X;
		P |= 0x30;
		Stack.Push(A);
		B = Stack.Pop();
		P |= 0x30;
		A = 0x20;
		[0x3037] = A;
		A = 0x01;
		[0x3039] = A;
		this.A0293FA();
		this.A02950C();
		P &= ~0x10;
		X = 0x02FF;
		S = X;
		P |= 0x30;
		P &= ~0x30;
		this.A029241();
		A = 0x0002;
	}

	public void A0293D6()
	{
		temp = A - [0x002140];

		if (Z == 0)
			return this.A0293D6();

		this.A029167();
		P |= 0x30;
		this.A029599();
		return this.A029EDB();
	}

	public void A0293E9()
	{
		Stack.Push(P);
		P &= ~0x30;
		Y = 0x0005;
	}

	public void A0293EF()
	{
		X = 0x0000;
	}

	public void A0293F2()
	{
		X--;

		if (Z == 0)
			return this.A0293F2();

		Y--;

		if (Z == 0)
			return this.A0293EF();

		P = Stack.Pop();
		return;
	}

	public void A0293FA()
	{
		I = 1;
		A = 0x01;
		[0x00FB] = A;
		this.A02B1E5();
		P |= 0x30;
		A = 0x00;
		[0x00FB] = A;
		this.A02B1E5();
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

	public void A02950C()
	{
		Stack.Push(P);
		P |= 0x20;
		A = 0x7E;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x30;
		X = 0x2000;
		return this.A02951D();
	}

	public void A02951A()
	{
		[0x0000 + X] = 0;
	}

	public void A02951D()
	{
		[0x0002 + X] = 0;
		[0x0004 + X] = 0;
		[0x0006 + X] = 0;
		A = X;
		C = 0;
		A += 0x0008 + C;
		X = A;

		if (Z == 0)
			return this.A02951A();

		P |= 0x20;
		A = 0x7F;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
	}

	public void A029536()
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
			return this.A029536();

		P |= 0x20;
		A = 0x70;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x30;
		X = 0x7FF8;
	}

	public void A029555()
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
			return this.A029555();

		P |= 0x20;
		A = 0x00;
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
		X = 0x1CF8;
	}

	public void A029574()
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
			return this.A029574();

		X = 0x00FE;
	}

	public void A02958B()
	{
		[0x00 + X] = 0;
		X--;
		X--;

		if (N == 0)
			return this.A02958B();

		this.A01F87E();
		P |= 0x20;
		P = Stack.Pop();
		return;
	}

	public void A029599()
	{
		this.A02C494();
		P |= 0x20;
		P &= ~0x10;
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

	public void A0295BD()
	{
		this.A0293E9();
		this.A09FB88();
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
		this.A078486();
		this.A0CF55D();
	}

	public void A02960E()
	{
		this.A07852B();
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
		this.A02A04E();
		return this.A02BEBF();
	}

	public void A029634()
	{
		this.A029649();
		this.A02CD1E();
		this.A038168();
		this.A0387D7();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A029649()
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
			return this.A029713();

		A = [0x7E2DD8];
		C = 1;
		A -= 0x0004 - !C;
		[0x10D3] = A;
	}

	public void A029713()
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
		this.A039E48();
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

	public void A02984E()
	{
		this.A02C494();
		P &= ~0x30;
		A = 0x0000;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P |= 0x20;
		A = [0xF3];
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = [0x1AC1];
		A &= 0x00FF;

		if (Z == 1)
			return this.A0298B4();

		A = [0x1230];
		A = [0x10EF];
		A &= 0x00FF;
		temp = A & 0x0010;

		if (Z == 1)
			return this.A0298A8();

		A = 0x0008;
		[0x1230] = A;
	}

	public void A0298A8()
	{
		A = [0x1230];
		A <<= 1;
		X = A;
		A = [0x02F5C0];
		[0x1228] = A;
	}

	public void A0298B4()
	{
		P |= 0x20;
		this.A03A17D();
		this.A038186();
		P &= ~0x20;
		[0x11DB] = 0;
		this.A0387A6();
		P |= 0x20;
		A = 0xFF;
		[0x1DBA] = A;
		[0x1DB9] = 0;
		this.A039DFF();
		this.A00E8D5();
		this.A00E8F0();
		this.A00EA5B();
		this.A00EA70();
		this.A04BA41();
		this.A00E996();
		this.A00EAD5();
		return;
	}

	public void A0298F2()
	{
		this.A029634();
		this.A02984E();
	}

	public void A0298FA()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.A02990C();

		this.A02C42B();
		P |= 0x20;
		P &= ~0x10;
		[0x10ED] = 0;
	}

	public void A02990C()
	{
		P |= 0x20;
		this.A02C897();
		P |= 0x20;
		A = [0x112D];
		temp = A & 0x08;

		if (Z == 0)
			return this.A02991E();

		return this.A0298FA();
	}

	public void A02991E()
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
			return this.A029941();

		return this.A0299C3();
	}

	public void A029941()
	{
		A = [0x1125];
		temp = A & 0x02;

		if (Z == 0)
			return this.A02995D();

		A = [0x1217];

		if (Z == 1)
			return this.A029950();

		return this.A0299C3();
	}

	public void A029950()
	{
		A = [0x1215];

		if (Z == 0)
			return this.A0299C3();

		A = [0x10D2];

		if (Z == 1)
			return this.A02995D();

		return this.A029AEB();
	}

	public void A02995D()
	{
		P |= 0x20;
		A = [0x10EF];
		temp = A & 0x02;

		if (Z == 0)
			return this.A029972();

		A = [0x120E];
		A--;
		[0x120E] = A;

		if (Z == 0)
			return this.A029972();

		return this.A029A8A();
	}

	public void A029972()
	{
		A = [0x1284];

		if (Z == 1)
			return this.A029998();

		A = 0x01;
		this.A029310();
		P |= 0x20;
		this.A02CC8F();
		P &= ~0x30;
		A = [0xF3];
		A &= 0x00FF;
		X = A;
		A = [0x048062];
		A &= 0x00FF;
		this.A029283();
		return this.A0299A7();
	}

	public void A029998()
	{
		P &= ~0x20;
		A = 0x0201;
		this.A029213();
		P |= 0x20;
		this.A02CC8F();
	}

	public void A0299A7()
	{
		P &= ~0x20;
		this.A02C494();
		this.A029634();
		this.A02984E();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
		P |= 0x20;
		P &= ~0x10;
		return this.A0298FA();
	}

	public void A0299C3()
	{
		A = [0x1AD0];

		if (Z == 1)
			return this.A0299E7();

		this.A029AF1();
		this.A038168();
		this.A02C494();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		A = 0x0004;
		this.A029283();
		A = 0xFFFF;
		return;
	}

	public void A0299E7()
	{
		P |= 0x20;
		A = [0x1232];

		if (Z == 0)
			return this.A029A66();

		A = [0x122E];

		if (Z == 1)
			return this.A029A66();

		P &= ~0x20;
		A = [0x1233];

		if (Z == 1)
			return this.A029A66();

		A = 0x0001;
		this.A029310();
		P &= ~0x20;
		A = [0x1233];
		Stack.Push(A);
		this.A02CC8F();
		this.A029634();
		this.A02C494();
		P &= ~0x30;
		A = Stack.Pop();
		[0x1228] = A;
		X = 0x0000;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		this.A0298B4();
		P &= ~0x20;
		A = 0x0010;
		this.A029283();
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
		this.A02C897();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
		return this.A0298FA();
	}

	public void A029A66()
	{
		this.A029C2D();

		if (Z == 0)
			return this.A029A6E();

		return this.A029AC7();
	}

	public void A029A6E()
	{
		this.A038168();
		this.A02C494();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		A = 0x0005;
		this.A029283();
		A = 0xFFFF;
		return;
	}

	public void A029A8A()
	{
		this.A029D2E();

		if (Z == 1)
			return this.A029AC7();

		P |= 0x20;
		A = [0x120F];
		A--;

		if (Z == 1)
			return this.A029AC7();

		[0x120F] = A;
		A = 0x03;
		[0x120E] = A;
		P &= ~0x20;
		[0x120C] = 0;
		A = 0x0001;
		this.A029310();
		P |= 0x20;
		this.A02CC8F();
		P &= ~0x30;
		A = [0xF3];
		A &= 0x00FF;
		X = A;
		A = [0x048062];
		A &= 0x00FF;
		this.A029283();
		return this.A0299A7();
	}

	public void A029AC7()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		P &= ~0x20;
		A = 0x0004;
		this.A029283();
	}

	public void A029ADD()
	{
		this.A02C494();
		this.A038168();
		P &= ~0x20;
		A = 0x0000;
		return;
	}

	public void A029AEB()
	{
		this.A02CC8F();
		return this.A029ADD();
	}

	public void A029AF1()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		this.A02BD43();
		P &= ~0x20;
		A = [0xF3];
		A &= 0x00FF;
		temp = A - 0x000A;

		if (Z == 0)
			return this.A029B18();

		A = [0x1235];
		temp = A - 0x001E;

		if (C == 1)
			return this.A029B3D();

		return this.A029B2F();
	}

	public void A029B18()
	{
		temp = A - 0x000B;

		if (Z == 0)
			return this.A029B20();

		return this.A029B3D();
	}

	public void A029B20()
	{
		temp = A - 0x000C;

		if (Z == 0)
			return this.A029B2F();

		A = [0x1237];
		temp = A - 0x0005;

		if (C == 1)
			return this.A029B3D();

		return this.A029B2F();
	}

	public void A029B2F()
	{
		A = 0x0000;
		[0x3A] = A;
		A = 0x000B;
		this.A029283();
		return this.A029B4B();
	}

	public void A029B3D()
	{
		P &= ~0x20;
		A = 0xFFFF;
		[0x3A] = A;
		A = 0x000C;
		this.A029283();
	}

	public void A029B4B()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A029BBA();
		A = 0xFF;
		[0x1ACF] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		X = 0x0011;
		[0x197C] = X;
	}

	public void A029B65()
	{
		Stack.Push(X);
		P |= 0x20;
		this.A029BD6();
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
			return this.A029B9B();

		A = 0x0DB3;
		[0x7000BA] = A;
	}

	public void A029B9B()
	{
		this.A03EA3E();
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.A029BAE();

		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 1)
			return this.A029B65();

	}

	public void A029BAE()
	{
		P |= 0x20;
		this.A02CC8F();
		[0x1ACF] = 0;
		A = [0x3A];
		return;
	}

	public void A029BBA()
	{
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A029BC1()
	{
		this.A029BD6();
		P |= 0x20;
		A = 0x02;
		[0x38] = A;
	}

	public void A029BCA()
	{
		A = [0x38];

		if (Z == 0)
			return this.A029BCA();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A029BC1();

		return;
	}

	public void A029BD6()
	{
		P |= 0x20;
		A = 0x02;
		[0x38] = A;
		[0x1982]++;

		if (Z == 0)
			return this.A029BE4();

		[0x1983]++;
	}

	public void A029BE4()
	{
		P |= 0x20;
	}

	public void A029BE6()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.A029BE6();

	}

	public void A029BEB()
	{
		A = [0x1ADF];
		temp = A - 0x02;

		if (Z == 0)
			return this.A029BEB();

		[0x1ADF] = 0;
	}

	public void A029BF5()
	{
		A = [0x38];

		if (Z == 0)
			return this.A029BF5();

		this.A02C418();
		P &= ~0x20;
		A = 0xFFD8;
		[0x700240] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xCA04;
		this.A7ED7E8();
		P &= ~0x20;
		A = 0x0000;
		[0x700240] = A;
		P |= 0x20;
		return;
	}

	public void A029C1F()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBA8F;
		this.A7ED7E8();
		return;
	}

	public void A029C2D()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		A = [0xF4];
		temp = A - 0x0006;

		if (Z == 0)
			return this.A029C49();

		this.A04B592();
		this.A029C49();
		P |= 0x20;
		A = 0x00;
		return;
	}

	public void A029C49()
	{
		P |= 0x20;
		this.A02CC8F();
		this.A02BD43();
		P &= ~0x20;
		A = 0x000C;
		this.A029283();
		this.A029BBA();
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

	public void A029C79()
	{
		Stack.Push(X);
		P |= 0x20;
		this.A029BD6();
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
		A = [0x0BF802];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 0)
			return this.A029CBB();

		return this.A029D0E();
	}

	public void A029CBB()
	{
		A = [0x197A];
		C = 0;
		A += 0x0064 + C;
		temp = A - [0x120C];

		if (N == 1)
			return this.A029CCA();

		A = [0x120C];
	}

	public void A029CCA()
	{
		[0x197A] = A;
		[0x70002E] = A;
		A = 0x0070;
		[0x700064] = A;
		A = 0x0069;
		[0x70002C] = A;
		A = 0x000E;
		[0x700208] = A;
		this.A09FA8C();
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
		A = [0x0BF810];
		[0x7000BA] = A;
		this.A03EA3E();
	}

	public void A029D0E()
	{
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.A029D20();

		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.A029D20();

		return this.A029C79();
	}

	public void A029D20()
	{
		P |= 0x20;
		this.A02CC8F();
		P |= 0x20;
		[0x1ACF] = 0;
		A = 0xFF;
		return;
	}

	public void A029D2E()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		this.A02BD43();
		P &= ~0x20;
		A = 0x000B;
		this.A029283();
		this.A029BBA();
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

	public void A029D65()
	{
		Stack.Push(X);
		P |= 0x20;
		this.A029BD6();
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
			return this.A029D9F();

		A = 0x0878;
		[0x7000BA] = A;
	}

	public void A029D9F()
	{
		this.A03EA3E();
		P |= 0x20;
		A = [0x1AD0];

		if (Z == 1)
			return this.A029DAD();

		return this.A029E0A();
	}

	public void A029DAD()
	{
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 0)
			return this.A029DB8();

		return this.A029E0A();
	}

	public void A029DB8()
	{
		A = [0x197A];
		C = 0;
		A += 0x0064 + C;
		temp = A - [0x120C];

		if (N == 1)
			return this.A029DC7();

		A = [0x120C];
	}

	public void A029DC7()
	{
		[0x197A] = A;
		[0x70002E] = A;
		A = 0x0070;
		[0x700064] = A;
		A = 0x0069;
		[0x70002C] = A;
		A = 0x000E;
		[0x700208] = A;
		this.A09FA8C();
		P &= ~0x30;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0080;
		[0x70002C] = A;
		A = [0xF4];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BF810];
		[0x7000BA] = A;
		this.A03EA3E();
	}

	public void A029E0A()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();
		X = [0x197C];

		if (N == 1)
			return this.A029E25();

		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.A029E39();

		A = [0x10BC];
		A &= 0xFF;

		if (Z == 0)
			return this.A029E25();

		return this.A029D65();
	}

	public void A029E25()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		[0x1ACF] = 0;
		A = 0x0000;
		return;
	}

	public void A029E39()
	{
		P |= 0x20;
		this.A02CC8F();
		[0x1ACF] = 0;
		A = 0xFF;
		return;
	}

	public void A029E45()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void A029E49()
	{
		A = [0x38];

		if (Z == 0)
			return this.A029E49();

		this.A078010();
		P |= 0x20;
		P &= ~0x10;
	}

	public void A029E55()
	{
		this.A078072();
		P |= 0x20;
		P &= ~0x10;
		[0x1982]++;
		A = 0x02;
		[0x38] = A;
	}

	public void A029E64()
	{
		A = [0x38];

		if (Z == 0)
			return this.A029E64();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 1)
			return this.A029E55();

	}

	public void A029E6F()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void A029E73()
	{
		A = [0x38];

		if (Z == 0)
			return this.A029E73();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A029E6F();

		[0x38] = 0;
	}

	public void A029E80()
	{
		A = [0x1ADF];
		temp = A - 0x02;

		if (Z == 0)
			return this.A029E80();

		[0x1ADF] = 0;
		return;
	}

	public void A029EDB()
	{
		P |= 0x30;
		A = 0x21;
		[0x1923] = A;
		this.A02A2C4();
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
		this.A02CD22();
		P |= 0x20;
		P &= ~0x10;
		this.A02CD9F();
		P &= ~0x20;
		A = 0x00F0;
		P |= 0x20;
		[0x2110] = A;
		A = (A >> 4) | (A << 4);
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
		this.A038168();
		this.A038000();
		this.A0387A6();
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

	public void A029FA7()
	{
		A = [0x02A37E];
		[0x7EDE0E + X] = A;
		X++;
		X++;
		temp = X - 0x0D9C;

		if (C == 0)
			return this.A029FA7();

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
		return this.A0295BD();
	}

	public void A02A04E()
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
		this.A029634();
		A = 0xFF;
		[0x1AD1] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x0009;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
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
		this.A03A17D();
		return this.A02A0F6();
	}

	public void A02A0F6()
	{
		P |= 0x20;
		return;
	}

	public void A02A0F9()
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
		this.A03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0068;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = 0x00DC;
		[0x7000BA] = A;
		this.A03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0078;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0004;

		if (C == 0)
			return this.A02A164();

		A = 0x0145;
		return this.A02A16A();
	}

	public void A02A164()
	{
		A <<= 1;
		X = A;
		A = [0x0BF7E2];
	}

	public void A02A16A()
	{
		[0x7000BA] = A;
		this.A03EA39();
		P &= ~0x30;
		A = 0x000A;
		[0x700064] = A;
		A = 0x0090;
		[0x70002C] = A;
		A = 0x0060;
		[0x700228] = A;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0004;

		if (C == 0)
			return this.A02A196();

		return this.A02A1A8();
	}

	public void A02A196()
	{
		A <<= 1;
		C = 0;
		A += [0x10B9] + C;
		X = A;
		A = [0x0BF7EA];
		[0x7000BA] = A;
		this.A03EA39();
	}

	public void A02A1A8()
	{
		return;
	}

	public void A02A258()
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

	public void A02A26D()
	{
		Stack.Push(A);
		A = 0x3AA0;
		[0x2118] = A;
		[0x2118] = A;
		A = Stack.Pop();
		X = 0x0000;
	}

	public void A02A27B()
	{
		[0x2118] = A;
		C = 0;
		A += 0x0018 + C;
		X++;
		temp = X - 0x001C;

		if (Z == 0)
			return this.A02A27B();

		Stack.Push(A);
		A = 0x3AA0;
		[0x2118] = A;
		[0x2118] = A;
		A = Stack.Pop();
		C = 1;
		A -= 0x029F - !C;
		Y++;
		temp = Y - 0x0018;

		if (Z == 0)
			return this.A02A26D();

		X = 0x2A00;
		[0x2116] = X;
		X = 0xFFFF;
		Y = 0x0010;
	}

	public void A02A2A9()
	{
		[0x2118] = X;
		Y--;

		if (Z == 0)
			return this.A02A2A9();

		X = 0x5A00;
		[0x2116] = X;
		X = 0xFFFF;
		Y = 0x0010;
	}

	public void A02A2BB()
	{
		[0x2118] = X;
		Y--;

		if (Z == 0)
			return this.A02A2BB();

		P |= 0x20;
		return;
	}

	public void A02A2C4()
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

	public void A02A2EB()
	{
		Y = 0x00;
	}

	public void A02A2ED()
	{
		[0x2118] = A;
		[0x2119] = A;
		Y--;

		if (Z == 0)
			return this.A02A2ED();

		X--;

		if (Z == 0)
			return this.A02A2EB();

		this.A02A36B();
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

	public void A02A31B()
	{
		[0x2118] = A;
		X--;

		if (Z == 0)
			return this.A02A31B();

		P |= 0x20;
		P &= ~0x10;
		this.A02A258();
		return;
	}

	public void A02A32A()
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

	public void A02A36B()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x1234;
		[0x7001B4] = A;
		P |= 0x30;
		this.A02A32A();
		return this.A01F074();
	}

	public void A02B1CB()
	{
		Stack.Push(P);
		P &= ~0x30;
		X = 0x0000;
	}

	public void A02B1D1()
	{
		A = [0x701000];
		C = 0;
		A += 0x00C0 + C;
		[0x2118] = A;
		X++;
		X++;
		temp = X - 0x0800;

		if (Z == 0)
			return this.A02B1D1();

		P = Stack.Pop();
		return;
	}

	public void A02B1E5()
	{
		Stack.Push(P);
		P &= ~0x30;
		Stack.Push(X);
		Stack.Push(A);
		P |= 0x20;
		[0xFC] = 0;
	}

	public void A02B1EE()
	{
		P |= 0x20;
		A = [0x2137];
		A = [0x213D];
		A = (A >> 4) | (A << 4);
		A = [0x213D];
		A = (A >> 4) | (A << 4);
		temp = A - [0xFB];

		if (Z == 0)
			return this.A02B1EE();

		P &= ~0x30;
		A = Stack.Pop();
		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void A02B2F9()
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

	public void A02B322()
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

	public void A02B37B()
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
		temp = Y - 0x0100;

		if (Z == 0)
			return this.A02B37B();

		A = 0x0000;
		[0x00137A] = A;
		P |= 0x20;
		B = Stack.Pop();
		P &= ~0x20;
		X = 0x0000;
	}

	public void A02B39D()
	{
		A = [0x08EB2D];
		[0x00139C + X] = A;
		X++;
		X++;
		temp = X - 0x0100;

		if (Z == 0)
			return this.A02B39D();

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

	public void A02B484()
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
		this.A7ED7E8();
		this.A02B1CB();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A02BD43()
	{
		this.A029C1F();
		P &= ~0x20;
		[0x10F8] = 0;
		this.A02CD1E();
		P &= ~0x20;
		[0x18C3] = 0;
		[0x18BC] = 0;
		P |= 0x20;
		[0x18C1] = 0;
		this.A038168();
		this.A02BE25();
		this.A02C418();
		this.A02BE3B();
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
		this.A02B322();
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
		this.A7ED7E8();
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
		this.A02B484();
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
		this.A7ED7E8();
		this.A02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.A7ED7E8();
		this.A02B2F9();
		P |= 0x20;
		[0x210F] = 0;
		[0x210F] = 0;
		this.A078001();
		A = [0x10C4];
		[0x420C] = A;
		return;
	}

	public void A02BE25()
	{
		P |= 0x30;
	}

	public void A02BE27()
	{
		A = [0x2137];
		X = [0x213D];
		A = [0x213D];
		A &= 0x01;

		if (Z == 0)
			return this.A02BE27();

		temp = X - 0xCF;

		if (Z == 0)
			return this.A02BE27();

		P &= ~0x30;
		return;
	}

	public void A02BE3B()
	{
		A = 0x02;
		Cpu.Break();
	}

	public void A02BE46()
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
		this.A7ED7E8();
		P &= ~0x20;
		X = 0x0000;
	}

	public void A02BE6C()
	{
		A = [0x701000];
		[0x7E2DD8 + X] = A;
		X++;
		X++;
		temp = X - 0x04B0;

		if (Z == 0)
			return this.A02BE6C();

		this.A00E8D5();
		this.A00EA5B();
		P |= 0x20;
		this.A02CC8F();
		this.A038168();
		this.A038000();
		this.A0387A6();
		P |= 0x20;
		[0x1ACF] = 0;
		A = 0xFF;
		[0x10D2] = A;
		A = 0x05;
		[0xF3] = A;
		this.A0298F2();
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

	public void A02BEBF()
	{
		P &= ~0x20;
		A = 0x0000;
		[0x70022A] = A;
		this.A00E8D5();
		this.A00EA5B();
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
		this.A02C23D();
		P |= 0x20;
		P &= ~0x20;
		A = 0x0000;
		[0x70021E] = A;
		this.A02C127();

		if (Z == 0)
			return this.A02BF18();

		this.A0784F5();
		return this.A02960E();
	}

	public void A02BF18()
	{
		P &= ~0x20;
		A = [0x1986];
		temp = A - 0x0001;

		if (Z == 1)
			return this.A02BF29();

		this.A02BFF2();
		return this.A02960E();
	}

	public void A02BF29()
	{
		this.A02BF54();
		return this.A02960E();
	}

	public void A02BF54()
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
		this.A0CF6F7();

		if (Z == 0)
			return this.A02BF8B();

		P &= ~0x20;
		[0x198C] = 0;
		P |= 0x20;
		A = [0x1986];
		[0xF4] = A;
		this.A02CC8F();
		this.A0784F5();
		return;
	}

	public void A02BF8B()
	{
		P |= 0x20;
		A = [0x1986];
		[0xF4] = A;
		P &= ~0x20;
		[0x198C] = 0;
		P |= 0x20;
		[0x1AD4] = 0;
		this.A02C08F();
		P |= 0x20;
		this.A02CC8F();
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
		A = [0x048062];
		A &= 0x00FF;
		Stack.Push(A);
		A = 0x0001;
		this.A029310();
		A = Stack.Pop();
		this.A029283();
		[0x1230] = 0;
		this.A0298F2();

		if (Z == 1)
			return this.A02BFEF();

		P |= 0x20;
		A = [0xF4];
		A++;
		[0xF4] = A;
		temp = A - 0x07;

		if (Z == 1)
			return this.A02BFEF();

		return this.A02BF54();
	}

	public void A02BFEF()
	{
		[0xF4] = 0;
		return;
	}

	public void A02BFF2()
	{
		P &= ~0x20;
		[0x1ACF] = 0;
		[0x1AD1] = 0;
		[0x1986] = 0;
		A = 0x0003;
		[0x198A] = A;
		A = 0x000A;
		[0x1AD6] = A;
		this.A0CF6F7();

		if (Z == 0)
			return this.A02C018();

		this.A02CC8F();
		this.A0784F5();
		return;
	}

	public void A02C018()
	{
		P |= 0x20;
		[0x1AD4] = 0;
		this.A02C08F();
		P |= 0x20;
		this.A02CC8F();
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
		this.A029310();
		A = 0x0006;
		this.A029283();
		P |= 0x20;
		A = 0xFF;
		[0x1AD0] = A;
		this.A0298F2();
		P |= 0x20;
		[0x1AD0] = 0;
		return;
	}

	public void A02C062()
	{
		this.A02C066();
		return;
	}

	public void A02C066()
	{
		Y = 0x0000;
	}

	public void A02C069()
	{
		Y--;

		if (Z == 0)
			return this.A02C069();

		X--;

		if (Z == 0)
			return this.A02C066();

		return;
	}

	public void A02C08F()
	{
		P &= ~0x20;
		A = 0xFFFF;
		[0x70021E] = A;
	}

	public void A02C098()
	{
		P |= 0x20;
		this.A02C278();
		P &= ~0x20;
		A = [0x70021E];

		if (Z == 0)
			return this.A02C098();

		return;
	}

	public void A02C127()
	{
		this.A02BE25();
	}

	public void A02C12B()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A02C897();
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 1)
			return this.A02C13D();

		return this.A02C12B();
	}

	public void A02C13D()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A02C1B3();
		P |= 0x20;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		this.A02C897();
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
			return this.A02C17C();

		this.A03EA39();
	}

	public void A02C17C()
	{
		this.A02A0F9();
		A = [0x10BE];
		temp = A & 0x0040;

		if (Z == 0)
			return this.A02C1AC();

		A = [0x10BC];
		temp = A & 0x0090;

		if (Z == 0)
			return this.A02C193();

		return this.A02C13D();
	}

	public void A02C193()
	{
		P &= ~0x20;
		A = 0xEA03;
		this.A029213();
		P |= 0x20;
	}

	public void A02C19E()
	{
		this.A02C897();
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A02C19E();

		A = 0xFF;
		return;
	}

	public void A02C1AC()
	{
		this.A02CC8F();
		A = 0x6000;
	}

	public void A02C1B3()
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
			return this.A02C1D0();

		return this.A02C1FA();
	}

	public void A02C1D0()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.A02C1DB();

		return this.A02C1FA();
	}

	public void A02C1DB()
	{
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		A = [0x1986];
		A++;
		temp = A - [0x198A];

		if (Z == 0)
			return this.A02C1F2();

		A = 0x0000;
	}

	public void A02C1F2()
	{
		[0x1986] = A;
		this.A02C23D();
		return this.A02C22D();
	}

	public void A02C1FA()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.A02C207();

		return this.A02C238();
	}

	public void A02C207()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.A02C212();

		return this.A02C238();
	}

	public void A02C212()
	{
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		A = [0x1986];
		A--;

		if (N == 0)
			return this.A02C227();

		A = [0x198A];
		A--;
	}

	public void A02C227()
	{
		[0x1986] = A;
		this.A02C23D();
	}

	public void A02C22D()
	{
		P &= ~0x20;
		A = 0xEA03;
		this.A029213();
		P |= 0x20;
	}

	public void A02C238()
	{
		return;
	}

	public void A02C239()
	{
		this.A02C23D();
		return;
	}

	public void A02C23D()
	{
		P &= ~0x20;
		A = [0x1986];
		A <<= 1;
		C = 0;
		A += [0x1986] + C;
		C = 0;
		A += [0x1988] + C;
		X = A;
		A = [0x0BFB14];

		if (Z == 0)
			return this.A02C264();

		A = [0x1986];
		A++;
		temp = A - [0x198A];

		if (Z == 0)
			return this.A02C25E();

		A = 0x0000;
	}

	public void A02C25E()
	{
		[0x1986] = A;
		return this.A02C23D();
	}

	public void A02C264()
	{
		[0x700222] = A;
		P |= 0x20;
		A = [0x0BFB16];
		P &= ~0x20;
		A &= 0x00FF;
		[0x700220] = A;
		return;
	}

	public void A02C278()
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
			return this.A02C298();

		[0x1983]++;
	}

	public void A02C298()
	{
		P |= 0x20;
	}

	public void A02C29A()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.A02C29A();

	}

	public void A02C29F()
	{
		A = [0x1ADF];
		temp = A - 0x02;

		if (Z == 0)
			return this.A02C29F();

		[0x1ADF] = 0;
	}

	public void A02C2A9()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02C2A9();

		this.A02C418();
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
			return this.A02C2D9();

		this.A03EA3E();
	}

	public void A02C2D9()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.A02C330();

		P &= ~0x20;
		A = 0x000C;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00D7;
		[0x700228] = A;
		A = 0x07A9;
		[0x7000BA] = A;
		this.A03EA3E();
		P |= 0x20;
		A = [0x1DFB];

		if (Z == 1)
			return this.A02C330();

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
		this.A03EA3E();
		P |= 0x20;
	}

	public void A02C330()
	{
		P |= 0x20;
		A = [0x1AD4];

		if (Z == 0)
			return this.A02C33A();

		return this.A02C3DE();
	}

	public void A02C33A()
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
			return this.A02C37C();

		A = [0xF3];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x1990] + C;
		X = A;
		A = [0x0BFB83];

		if (Z == 0)
			return this.A02C388();

	}

	public void A02C37C()
	{
		A = [0xF3];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x0BFB83];
	}

	public void A02C388()
	{
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A02C3B1();

		A = [0x198C];
		temp = A - 0x00C8;

		if (N == 1)
			return this.A02C3B3();

		A = [0x1990];
		A ^= 0x0002;
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.A02C3B3();
	}

	public void A02C3B1()
	{
		P &= ~0x20;
	}

	public void A02C3B3()
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
		this.A03EA3E();
		this.A078010();
	}

	public void A02C3DE()
	{
		P &= ~0x20;
		A = 0x000C;
		[0x700224] = A;
		A = 0x0000;
		[0x70021E] = A;
		P = Stack.Pop();
		return;
	}

	public void A02C418()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC88E;
		this.A7ED7E8();
		P = Stack.Pop();
		return;
	}

	public void A02C42B()
	{
		P &= ~0x20;
		A = 0x0E02;
		this.A029213();
		P |= 0x20;
		A = 0xFF;
		[0x1AD4] = A;
		[0x1AD5] = A;
		this.A029E45();
		P |= 0x20;
		[0x1AD4] = 0;
		[0x1AD5] = 0;
		P &= ~0x20;
		A = 0x0E01;
		this.A029213();
		return;
	}

	public void A02C494()
	{
		P &= ~0x30;
		[0x10DB] = 0;
		A = 0x0339;
		[0x10DD] = A;
		Y = 0x003C;
	}

	public void A02C4A2()
	{
		X = A;
		C = 0;
		A += 0x0039 + C;
		[0x00 + X] = A;
		Y--;

		if (Z == 0)
			return this.A02C4A2();

		[0x00 + X] = 0;
		P |= 0x20;
		return;
	}

	public void A02C4B1()
	{
		Stack.Push(X);
		P |= 0x20;
		P &= ~0x10;
		A = [0x121B];

		if (Z == 0)
			return this.A02C4D8();

		A = 0x28;
		[0x121B] = A;
		A = [0x121A];

		if (Z == 1)
			return this.A02C4D8();

		A--;
		[0x121A] = A;
		P &= ~0x20;
		A = 0xEA90;
		this.A029213();
		P |= 0x20;
		this.A02C4DE();
	}

	public void A02C4D8()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();
		return;
	}

	public void A02C4DE()
	{
		P &= ~0x30;
		A = 0x0001;
		[0x11C7] = A;
		A = 0x0014;
		[0x3E] = A;
		X = [0x10DB];

		if (Z == 1)
			return this.A02C538();

	}

	public void A02C4F0()
	{
		temp = X - [0x1286];

		if (Z == 1)
			return this.A02C501();

		temp = X - [0x1288];

		if (Z == 1)
			return this.A02C530();

		temp = X - [0x128A];

		if (Z == 1)
			return this.A02C530();

		return this.A02C505();
	}

	public void A02C501()
	{
		P |= 0x20;
		return this.A02C515();
	}

	public void A02C505()
	{
		P |= 0x20;
		A = [0x001E + X];
		A &= 0x10;

		if (Z == 0)
			return this.A02C515();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 1)
			return this.A02C530();

	}

	public void A02C515()
	{
		[0x3A] = 0;
		A = [0x28 + X];
		C = 1;
		A -= 0x0A - !C;

		if (N == 0)
			return this.A02C522();

		[0x3A] = A;
		A = 0x00;
	}

	public void A02C522()
	{
		[0x28 + X] = A;
		A = 0xF6;
		C = 1;
		A -= 0x3A - !C;
		C = 0;
		A += [0x3E] + C;

		if (N == 1)
			return this.A02C538();

		[0x3E] = A;
	}

	public void A02C530()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 1)
			return this.A02C538();

		return this.A02C4F0();
	}

	public void A02C538()
	{
		P &= ~0x20;
		A = 0x0002;
		[0x18BC] = A;
		P |= 0x20;
		return;
	}

	public void A02C580()
	{
		P &= ~0x30;
		A = 0x0F00;
		[0x1267] = A;
		[0x1269] = A;
		A = [0x1263];
		C = 1;
		A -= 0x3400 - !C;

		if (N == 1)
			return this.A02C59D();

		C = 0;
		A += [0x1267] + C;
		[0x1267] = A;
		return this.A02C5B1();
	}

	public void A02C59D()
	{
		A = [0x1263];
		C = 1;
		A -= 0xCC00 - !C;

		if (N == 0)
			return this.A02C5B1();

		A ^= 0xFFFF;
		A++;
		C = 0;
		A += [0x1267] + C;
		[0x1267] = A;
	}

	public void A02C5B1()
	{
		A = [0x1265];
		C = 1;
		A -= 0x3400 - !C;

		if (N == 1)
			return this.A02C5C3();

		C = 0;
		A += [0x1269] + C;
		[0x1269] = A;
		return this.A02C5D7();
	}

	public void A02C5C3()
	{
		A = [0x1265];
		C = 1;
		A -= 0xCC00 - !C;

		if (N == 0)
			return this.A02C5D7();

		A ^= 0xFFFF;
		A++;
		C = 0;
		A += [0x1269] + C;
		[0x1269] = A;
	}

	public void A02C5D7()
	{
		X = [0x10DB];

		if (Z == 1)
			return this.A02C63F();

	}

	public void A02C5DC()
	{
		[0x10FE] = X;
		P |= 0x20;
		A = [0x09 + X];
		A &= 0x08;

		if (Z == 1)
			return this.A02C5F1();

		P &= ~0x20;
		A = [0x10 + X];
		C = 1;
		A -= 0x11D2 - !C;

		if (N == 1)
			return this.A02C61C();

	}

	public void A02C5F1()
	{
		P &= ~0x20;
		A = [0x04 + X];
		temp = A - 0xCD16;

		if (Z == 1)
			return this.A02C634();

		A = [0x0C + X];
		C = 1;
		A -= 0x1263 - !C;

		if (N == 0)
			return this.A02C606();

		A ^= 0xFFFF;
		A++;
	}

	public void A02C606()
	{
		temp = A - [0x1267];

		if (C == 1)
			return this.A02C61C();

		A = [0x10 + X];
		C = 1;
		A -= 0x1265 - !C;

		if (N == 0)
			return this.A02C617();

		A ^= 0xFFFF;
		A++;
	}

	public void A02C617()
	{
		temp = A - [0x1269];

		if (C == 0)
			return this.A02C634();

	}

	public void A02C61C()
	{
		A = X;
		temp = A - [0x1286];

		if (Z == 1)
			return this.A02C634();

		temp = A - [0x128A];

		if (Z == 1)
			return this.A02C634();

		temp = A - [0x1288];

		if (Z == 1)
			return this.A02C634();

		Y = [0x00 + X];
		this.A038DC1();
		return this.A02C639();
	}

	public void A02C634()
	{
		X = [0x10FE];
		Y = [0x00 + X];
	}

	public void A02C639()
	{
		X = Y;

		if (Z == 1)
			return this.A02C63F();

		return this.A02C5DC();
	}

	public void A02C63F()
	{
		return;
	}

	public void A02C640()
	{
		this.A02C644();
		return;
	}

	public void A02C644()
	{
		A = [0xC5];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x0C] = A;
		A = [0xC9];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x08] = A;
		A = [0x0C + X];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 1;
		A -= 0x0C - !C;

		if (N == 0)
			return this.A02C66F();

		A ^= 0xFFFF;
		A++;
	}

	public void A02C66F()
	{
		[0x0A] = A;
		A = [0x10 + X];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 1;
		A -= 0x08 - !C;

		if (N == 0)
			return this.A02C684();

		A ^= 0xFFFF;
		A++;
	}

	public void A02C684()
	{
		C = 0;
		A += [0x0A] + C;
		return;
	}

	public void A02C688()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = [0x10DB];

		if (Z == 1)
			return this.A02C6A0();

		this.A02C6A2();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC8AE;
		this.A7ED7E8();
	}

	public void A02C6A0()
	{
		P = Stack.Pop();
		return;
	}

	public void A02C6A2()
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
			return this.A02C6C1();

		B = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void A02C6C1()
	{
		P |= 0x20;
		[0x10FE] = Y;
		temp = Y - [0x119E];

		if (Z == 1)
			return this.A02C6DA();

		temp = Y - [0x11A0];

		if (Z == 1)
			return this.A02C6DA();

		temp = Y - [0x11A2];

		if (Z == 1)
			return this.A02C6DA();

		temp = Y - [0x10FC];

		if (Z == 0)
			return this.A02C6E7();

	}

	public void A02C6DA()
	{
		A = [0x11C2];

		if (Z == 1)
			return this.A02C6E7();

		A = [0x11C4];

		if (Z == 0)
			return this.A02C6E7();

		return this.A02C7F7();
	}

	public void A02C6E7()
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
			return this.A02C715();

		temp = A & 0x0010;

		if (Z == 0)
			return this.A02C708();

		temp = A & 0x0001;

		if (Z == 1)
			return this.A02C71A();

	}

	public void A02C708()
	{
		Stack.Push(X);
		A = [0x0004 + Y];
		X = A;
		A = [0x11 + X];
		X = Stack.Pop();
		temp = A - 0x0046;

		if (C == 1)
			return this.A02C71A();

	}

	public void A02C715()
	{
		A = 0x3A98;
		return this.A02C71D();
	}

	public void A02C71A()
	{
		A = 0x0000;
	}

	public void A02C71D()
	{
		[0x700002 + X] = A;
		A = [0x000C + Y];
		C = 1;
		A -= 0xC5 - !C;
		[0x70000E + X] = A;
		Stack.Push(X);
		A = [0x0004 + Y];
		X = A;
		A = [0x000008];
		X = Stack.Pop();
		C = 0;
		A += [0x000E + Y] + C;
		C = 1;
		A -= 0xC7 - !C;
		[0x70000C + X] = A;
		A = [0x0010 + Y];
		C = 1;
		A -= 0xC9 - !C;
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
			return this.A02C79D();

		A = [0x000A + Y];
		[0x700012 + X] = A;
		A = [0x001D + Y];
		temp = A & 0x20;

		if (Z == 1)
			return this.A02C7A3();

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
		return this.A02C7A3();
	}

	public void A02C79D()
	{
		A = 0x00;
		[0x700012 + X] = A;
	}

	public void A02C7A3()
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
		A = [0x7E1CDC];
		X = Stack.Pop();
		temp = A & 0x80;

		if (Z == 0)
			return this.A02C7D2();

		A = [0x1982];
	}

	public void A02C7D2()
	{
		A &= 0x7F;
		[0x700013 + X] = A;
		Stack.Push(X);
		X = Y;
		A = [0x7E1CDB];
		X = Stack.Pop();
		temp = A & 0x80;

		if (Z == 0)
			return this.A02C7E6();

		A = [0x1982];
	}

	public void A02C7E6()
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

	public void A02C7F7()
	{
		P &= ~0x20;
		A = [0x0000 + Y];
		Y = A;

		if (Z == 1)
			return this.A02C802();

		return this.A02C6C1();
	}

	public void A02C802()
	{
		A = [0x1AC3];
		[0x7001BA] = A;
		B = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void A02C897()
	{
		P |= 0x20;
		this.A03EC1A();
		P |= 0x20;
		A = [0x1AC1];

		if (Z == 1)
			return this.A02C8DA();

		A = [0x7EC644];

		if (Z == 1)
			return this.A02C8DA();

		A = [0x7EC643];
		A--;
		[0x7EC643] = A;

		if (N == 0)
			return this.A02C8DA();

		A = 0x28;
		[0x7EC643] = A;
		A = [0x7EC644];
		P &= ~0x20;
		A &= 0x00FF;
		A |= 0x0800;
		this.A029213();
		P |= 0x20;
		A = [0x7EC644];
		A++;
		temp = A - 0x10;

		if (Z == 1)
			return this.A02C8DA();

		[0x7EC644] = A;
	}

	public void A02C8DA()
	{
		P |= 0x20;
		A = [0x122F];

		if (Z == 1)
			return this.A02C8FA();

		[0x122F] = 0;
		P &= ~0x20;
		A = [0x1230];
		A++;
		[0x1230] = A;
		A <<= 1;
		X = A;
		A = [0x02F5C0];
		[0x1228] = A;
		this.A04B914();
	}

	public void A02C8FA()
	{
		P |= 0x20;
		A = [0x122B];

		if (Z == 1)
			return this.A02C920();

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
		this.A04B93D();
	}

	public void A02C920()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void A02C924()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02C924();

		[0x1ADF] = 0;
		A = 0x02;
		[0x38] = A;
		[0x118C] = 0;
		this.A00DDDE();
		P &= ~0x20;
		A = [0x1AD0];
		A &= 0x00FF;

		if (Z == 1)
			return this.A02C971();

		A = [0xF3];
		A &= 0x00FF;
		temp = A - 0x000C;

		if (Z == 0)
			return this.A02C954();

		A = [0x1237];
		temp = A - 0x0005;

		if (C == 0)
			return this.A02C971();

		return this.A02C961();
	}

	public void A02C954()
	{
		temp = A - 0x000A;

		if (Z == 0)
			return this.A02C971();

		A = [0x1235];
		temp = A - 0x001E;

		if (C == 0)
			return this.A02C971();

	}

	public void A02C961()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x118F];

		if (Z == 0)
			return this.A02C971();

		X = [0x10FC];
		this.A03B469();
	}

	public void A02C971()
	{
		P |= 0x20;
		P &= ~0x10;
		[0x1982]++;

		if (Z == 0)
			return this.A02C97D();

		[0x1983]++;
	}

	public void A02C97D()
	{
		this.A03A5C3();
		P |= 0x20;
		P &= ~0x10;
		X = 0xFFFF;
		[0x11F7] = X;
		X = [0x10DB];

		if (Z == 1)
			return this.A02C9AB();

	}

	public void A02C990()
	{
		[0x1108] = 0;
		this.A039F42();
		A = [0x1108];

		if (Z == 0)
			return this.A02C9A3();

		Y = [0x00 + X];
	}

	public void A02C99E()
	{
		X = Y;

		if (Z == 0)
			return this.A02C990();

		return this.A02C9AB();
	}

	public void A02C9A3()
	{
		Y = [0x00 + X];
		this.A038D6F();
		return this.A02C99E();
	}

	public void A02C9AB()
	{
		P |= 0x20;
		A = [0x118C];
		temp = A - [0x118D];

		if (Z == 1)
			return this.A02C9D4();

		[0x118D] = A;
		temp = A - 0x00;

		if (Z == 0)
			return this.A02C9C9();

		P &= ~0x20;
		A = 0xEA22;
		this.A029213();
		P |= 0x20;
		return this.A02C9D4();
	}

	public void A02C9C9()
	{
		P &= ~0x20;
		A = 0xEA23;
		this.A029213();
		P |= 0x20;
	}

	public void A02C9D4()
	{
		this.A03E3B5();
		this.A02CDE9();
		this.A03848F();
		this.A02CD22();
		P &= ~0x20;
		A = [0x1AE6];

		if (Z == 1)
			return this.A02C9FB();

		X = [0x10FA];
		A = [0x0E + X];
		temp = A - 0x8000;
		Cpu.ROR();
		A += 0x0080 + C;
		[0x1B70] = A;
		[0x1B78] = 0;
	}

	public void A02C9FB()
	{
		A = [0x1ADC];

		if (Z == 1)
			return this.A02CA11();

		X = [0x10FA];
		A = [0x0C + X];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
	}

	public void A02CA11()
	{
		[0x1ADD] = A;
		this.A02C688();
		this.A02D24F();
		this.A038EA8();
		P |= 0x20;
	}

	public void A02CA21()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.A02CA21();

		this.A02CDC9();
	}

	public void A02CA2A()
	{
		A = [0x1ADF];
		temp = A - 0x02;

		if (Z == 0)
			return this.A02CA2A();

		[0x1ADF] = 0;
		P &= ~0x30;
		A = [0x1926];
		[0x7001AC] = A;

		if (Z == 1)
			return this.A02CA43();

		this.A01F622();
	}

	public void A02CA43()
	{
		this.A7EC654();
		P &= ~0x20;
		A = [0x10E5];

		if (Z == 1)
			return this.A02CA52();

		this.A07814C();
	}

	public void A02CA52()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.A02CA5C();

		return this.A02CB5C();
	}

	public void A02CA5C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.A02CA8D();

		A = [0x00197E];

		if (Z == 0)
			return this.A02CA8D();

		P &= ~0x20;
		A = [0x197C];

		if (N == 1)
			return this.A02CA8D();

		[0x70002E] = A;
		A = 0x0064;
		[0x700064] = A;
		A = 0x000E;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.A03EB92();
	}

	public void A02CA8D()
	{
		P |= 0x20;
		A = [0x10D2];

		if (Z == 1)
			return this.A02CABD();

		A = [0x1982];
		A &= 0x04;

		if (Z == 1)
			return this.A02CABD();

		P &= ~0x20;
		A = 0x0046;
		[0x700064] = A;
		A = 0x004C;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0902;
		[0x7000BA] = A;
		this.A03EA3E();
	}

	public void A02CABD()
	{
		P |= 0x20;
		A = [0x11D4];

		if (Z == 1)
			return this.A02CB17();

		A--;
		[0x11D4] = A;
		A = [0x11D5];

		if (Z == 1)
			return this.A02CAD2();

		[0x11D4] = 0;
		return this.A02CB17();
	}

	public void A02CAD2()
	{
		P &= ~0x20;
		A = 0x0032;
		[0x700064] = A;
		A = 0x00A7;
		[0x70002C] = A;
		A = [0x1285];
		A &= 0x00FF;

		if (Z == 1)
			return this.A02CAF6();

		A = [0x70002C];
		C = 1;
		A -= 0x0008 - !C;
		[0x70002C] = A;
	}

	public void A02CAF6()
	{
		A = 0x00DF;
		[0x700228] = A;
		A = [0x11D6];
		[0x7000BA] = A;
		this.A03EA39();
		P |= 0x20;
		this.A0385AB();
		A = [0x11D4];

		if (Z == 0)
			return this.A02CB17();

		this.A03853B();
	}

	public void A02CB17()
	{
		P |= 0x20;
		A = [0x1DBA];

		if (Z == 0)
			return this.A02CB21();

		return this.A02CBCE();
	}

	public void A02CB21()
	{
		P &= ~0x30;
		A = [0x70021E];

		if (Z == 1)
			return this.A02CB5C();

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
			return this.A02CB5C();

		this.A03EA39();
		P &= ~0x20;
		A = [0x70022A];
		A++;
		[0x70022A] = A;
	}

	public void A02CB5C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.A02CBCE();

		P &= ~0x20;
		A = [0xF3];
		A &= 0x00FF;
		temp = A - 0x000C;

		if (Z == 0)
			return this.A02CB74();

		A = [0x1237];
		return this.A02CB7C();
	}

	public void A02CB74()
	{
		temp = A - 0x000A;

		if (Z == 0)
			return this.A02CB9B();

		A = [0x1235];
	}

	public void A02CB7C()
	{
		[0x70002E] = A;
		A = 0x00B0;
		[0x700064] = A;
		A = 0x0008;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.A03EB92();
		return this.A02CBCA();
	}

	public void A02CB9B()
	{
		[0x3A] = 0;
		A = [0x120C];
		[0x70002E] = A;
		temp = A - 0x270F;

		if (N == 1)
			return this.A02CBAE();

		A = 0xFFF8;
		[0x3A] = A;
	}

	public void A02CBAE()
	{
		A = 0x00B0;
		C = 0;
		A += [0x3A] + C;
		[0x700064] = A;
		A = 0x0008;
		[0x70002C] = A;
		A = 0x000F;
		[0x700208] = A;
		this.A03EB30();
	}

	public void A02CBCA()
	{
		this.A078237();
	}

	public void A02CBCE()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 1)
			return this.A02CBFB();

		this.A078010();
		P &= ~0x30;
		A = 0x0054;
		[0x700064] = A;
		A = 0x00A8;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = 0x0796;
		[0x7000BA] = A;
		this.A03EA3E();
	}

	public void A02CBFB()
	{
		P |= 0x20;
		P &= ~0x10;
		[0x1280] = 0;
		A = 0x00;
		X = [0x10DB];

		if (Z == 1)
			return this.A02CC22();

	}

	public void A02CC09()
	{
		Stack.Push(A);
		A = [0x001E + X];
		A &= 0x20;

		if (Z == 0)
			return this.A02CC1B();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 1)
			return this.A02CC1B();

		[0x1280]++;
	}

	public void A02CC1B()
	{
		A = Stack.Pop();
		A++;
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A02CC09();

	}

	public void A02CC22()
	{
		[0x127F] = A;
		P |= 0x20;
		A = [0x11DA];

		if (Z == 1)
			return this.A02CC46();

		P &= ~0x20;
	}

	public void A02CC2E()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02CC2E();

		this.A09FA1A();
		P &= ~0x20;
		A = 0x000A;
		[0x38] = A;
	}

	public void A02CC3D()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02CC3D();

		P |= 0x20;
		[0x11DA] = 0;
	}

	public void A02CC46()
	{
		return;
	}

	public void A02CC50()
	{
		P &= ~0x20;
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void A02CC59()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void A02CC61()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02CC61();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A02CC59();

		P &= ~0x20;
		A = 0x0000;
		[0x70021E] = A;
		[0x700224] = A;
		P |= 0x20;
		return;
	}

	public void A02CC7C()
	{
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void A02CC83()
	{
		this.A02C897();
		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A02CC83();

		return;
	}

	public void A02CC8F()
	{
		P |= 0x20;
		A = 0xFF;
		[0x1ACB] = A;
	}

	public void A02CC96()
	{
		A = 0x10;
		[0x38] = A;
		A = [0x109B];
	}

	public void A02CC9D()
	{
		temp = A - [0x109B];

		if (Z == 1)
			return this.A02CC9D();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A02CC96();

		[0x38] = 0;
		return;
	}

	public void A02CCC9()
	{
		P |= 0x30;
		P |= 0x10;
	}

	public void A02CCCD()
	{
		A = [0x2137];
		X = [0x213D];
		A = [0x213D];
		A &= 0x01;

		if (Z == 0)
			return this.A02CCCD();

		temp = X - 0xCF;

		if (Z == 0)
			return this.A02CCCD();

		P &= ~0x10;
		P &= ~0x20;
		A = 0x0001;
		[0x70021E] = A;
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A02CCF0()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void A02CCF8()
	{
		A = [0x38];

		if (Z == 0)
			return this.A02CCF8();

		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A02CCF0();

		return;
	}

	public void A02CD1E()
	{
		this.A02CD30();
		return;
	}

	public void A02CD22()
	{
		P &= ~0x30;
		[0x1B7A] = 0;
		A = [0x122A];
		A &= 0x00FF;

		if (Z == 0)
			return this.A02CD30();

		return;
	}

	public void A02CD30()
	{
		P &= ~0x30;
		A = [0x10F8];

		if (N == 1)
			return this.A02CD67();

		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x008A44];
		temp = A - [0x1B78];

		if (Z == 0)
			return this.A02CD47();

		return;
	}

	public void A02CD47()
	{
		[0x1B78] = A;
		X = A;
		Y = 0x0000;
	}

	public void A02CD4E()
	{
		A = [0x00 + X];
		C = 0;
		A += [0x1B70] + C;
		[0x1AF0 + Y] = A;
		Y++;
		Y++;
		X++;
		X++;
		temp = Y - 0x0040;

		if (Z == 0)
			return this.A02CD4E();

		A = 0x0001;
		[0x1B7A] = A;
		return;
	}

	public void A02CD67()
	{
		A ^= 0xFFFF;
		A++;
		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x008A44];
		temp = A - [0x1B78];

		if (Z == 0)
			return this.A02CD7B();

		return;
	}

	public void A02CD7B()
	{
		[0x1B78] = A;
		C = 0;
		A += 0x003E + C;
		X = A;
		Y = 0x0000;
	}

	public void A02CD86()
	{
		A = [0x00 + X];
		C = 0;
		A += [0x1B70] + C;
		[0x1AF0 + Y] = A;
		X--;
		X--;
		Y++;
		Y++;
		temp = Y - 0x0040;

		if (Z == 0)
			return this.A02CD86();

		A = 0x0001;
		[0x1B7A] = A;
		return;
	}

	public void A02CD9F()
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

	public void A02CDC9()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xC85E;
		this.A7ED7E8();
		P = Stack.Pop();
		return;
	}

	public void A02CDE9()
	{
		P &= ~0x30;
		X = [0x1B7E];

		if (Z == 0)
			return this.A02CDF1();

		return;
	}

	public void A02CDF1()
	{
		P &= ~0x20;
		A = [0x02CE6B];
		temp = A - 0x1234;

		if (Z == 0)
			return this.A02CE1A();

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

	public void A02CE1A()
	{
		A = [0x02CE6C];
		[0x700020] = A;
		A = 0x0000;
		[0x700026] = A;
		[0x700028] = A;
		P |= 0x20;
		A = [0x02CE6B];
		X++;
		X++;
		X++;
		[0x1B7E] = X;
		A = 0x01;
		X = 0xBCFC;
		this.A7ED7E8();
		A = [0x10C4];
		[0x420C] = A;
		X = 0x0000;
	}

	public void A02CE4B()
	{
		A = [0x701F0C];
		[0x7EE9B6 + X] = A;
		C = 1;
		A -= 0x80 - !C;
		[0x1125] = A;
		A = 0x80;
		C = 1;
		A -= 0x1125 - !C;
		[0x7EE7C1 + X] = A;
		X++;
		X++;
		temp = X - 0x01C0;

		if (Z == 0)
			return this.A02CE4B();

		return;
	}

	public void A02D24B()
	{
		this.A02D24F();
		return;
	}

	public void A02D24F()
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
		A = [0x001DE4];
		[0x70024C] = A;
		X = [0x1DED];
		A = [0x001DF5];
		[0x70024D] = A;
		A = [0x1186];
		temp = A - 0x03;

		if (Z == 0)
			return this.A02D2B4();

		A = [0x121A];
		[0x70024C] = A;
		[0x70024D] = A;
	}

	public void A02D2B4()
	{
		P &= ~0x20;
		A = [0x11F9];
		A ^= 0xFFFF;
		A++;
		[0x00] = A;
		A = [0x11FB];
		[0x06] = A;
		this.A03E8FD();
		P &= ~0x20;
		[0x3A] = A;
		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		P |= 0x20;
		X = [0x10FC];
		C = 1;
		A -= [0x13 + X] - !C;
		C = 0;
		A += 0x0F + C;
		P &= ~0x20;
		A &= 0x00FF;
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
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
			return this.A02D30E();

		A = 0x00;
	}

	public void A02D30E()
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
		this.A0782A9();
		return;
	}

	public void A02D337()
	{
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void A02D33E()
	{
		A = [0x0BFBBB];
		[0x7EEBAA + X] = A;
		X++;
		temp = X - [0x0018];

		if (Z == 0)
			return this.A02D33E();

		A = 0x06;
		[0x1E02] = A;
		return;
	}

	public void A02D352()
	{
		P &= ~0x30;
		X = 0x0000;
		Y = 0x0000;
	}

	public void A02D35A()
	{
		P &= ~0x30;
		Stack.Push(X);
		Stack.Push(Y);
		A = [0x7EEBAC];
		A &= 0x00FF;
		[0x700064] = A;
		A = [0x7EEBAD];
		A &= 0x00FF;
		[0x70002C] = A;
		A = [0x7EEBAB];
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x0BFC8B];
		X = A;
		Y = 0x0000;
		A = [0x0BFBD3];
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

	public void A02D39D()
	{
		A = [0x0BFBD3];
		Stack.Push(X);
		X = Y;
		[0x701000 + X] = A;
		X = Stack.Pop();
		X++;
		Y++;
		[0x3A]--;

		if (Z == 0)
			return this.A02D39D();

		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xCE5B;
		this.A7ED7E8();
		Y = Stack.Pop();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		A = [0x7EEBAA];

		if (Z == 1)
			return this.A02D3CE();

		A--;
		[0x7EEBAA + X] = A;
		return this.A02D3EA();
	}

	public void A02D3CE()
	{
		A = [0x7EEBAB];
		A++;
		temp = A - 0x07;

		if (Z == 0)
			return this.A02D3E6();

		this.A03E814();
		A &= 0x3F;
		C = 0;
		A += 0x14 + C;
		[0x7EEBAA + X] = A;
		A = 0x00;
	}

	public void A02D3E6()
	{
		[0x7EEBAB + X] = A;
	}

	public void A02D3EA()
	{
		X++;
		X++;
		X++;
		X++;
		Y++;
		A = Y;
		temp = A - [0x1E02];

		if (Z == 1)
			return this.A02D3F8();

		return this.A02D35A();
	}

	public void A02D3F8()
	{
		return;
	}

	public void A038000()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
	}

	public void A03805D()
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

	public void A0380F7()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
		return this.A03805D();
	}

	public void A038154()
	{
		P &= ~0x30;
		A = 0xAAAA;
		X = 0x0000;
		Y = 0x0010;
	}

	public void A03815F()
	{
		[0x1D91 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.A03815F();

		return;
	}

	public void A038168()
	{
		Stack.Push(P);
		P |= 0x20;
		[0x1B90] = 0;
		P &= ~0x20;
		A = 0xFEFE;
		Y = 0x0100;
		X = 0x0000;
	}

	public void A038179()
	{
		[0x1B91 + X] = A;
		[0x1B91 + X] = 0;
		X++;
		X++;
		Y--;

		if (N == 0)
			return this.A038179();

		P = Stack.Pop();
		return;
	}

	public void A038186()
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
		this.A03840A();
		A = 0x0000;
		X = 0x0000;
		Y = 0x0008;
	}

	public void A0383E7()
	{
		[0x1D91 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.A0383E7();

		A = 0xAAAA;
		X = 0x0000;
		Y = 0x0008;
	}

	public void A0383F8()
	{
		[0x1DA1 + X] = A;
		X++;
		X++;
		Y--;

		if (Z == 0)
			return this.A0383F8();

		P &= ~0x20;
		A = 0x001B;
		[0x1DB7] = A;
		P = Stack.Pop();
		return;
	}

	public void A03840A()
	{
		Stack.Push(P);
		Stack.Push(X);
		P &= ~0x20;
		A = [0x1DDA];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B];
		C = 0;
		A += 0x0080 + C;
		[0x3E] = A;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0003;

		if (Z == 0)
			return this.A03842E();

		A = 0x0080;
		[0x3E] = A;
	}

	public void A03842E()
	{
		Y = 0x0009;
		X = 0x0070;
	}

	public void A038434()
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
			return this.A038434();

		P &= ~0x20;
		A = [0x1DEB];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B];
		C = 0;
		A += 0x0080 + C;
		[0x3E] = A;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0003;

		if (Z == 0)
			return this.A03846E();

		A = 0x0080;
		[0x3E] = A;
	}

	public void A03846E()
	{
		Y = 0x0009;
		X = 0x0094;
	}

	public void A038474()
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
			return this.A038474();

		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void A03848F()
	{
		P |= 0x20;
		A = [0x1DBA];
		[0x700234] = A;

		if (Z == 1)
			return this.A0384A6();

		this.A0384FD();
		this.A038503();
		this.A03880A();
		this.A0385F7();
	}

	public void A0384A6()
	{
		return;
	}

	public void A0384B4()
	{
		P |= 0x20;
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		A--;
		X = A;
		P |= 0x20;
		A = [0x0384A7];
		temp = A - [0x1DB9];

		if (Z == 0)
			return this.A0384CB();

		return;
	}

	public void A0384CB()
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

	public void A0384E4()
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
		temp = Y - [0x1DB7];

		if (Z == 0)
			return this.A0384E4();

		return;
	}

	public void A0384FD()
	{
		this.A0384B4();
		P &= ~0x20;
		return;
	}

	public void A038503()
	{
		A = 0x02;
		Cpu.Break();
	}

	public void A03853B()
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

	public void A03855E()
	{
		P &= ~0x30;
		Stack.Push(X);
		A = [0x1DBA];
		A &= 0x00FF;

		if (Z == 1)
			return this.A038599();

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

	public void A038599()
	{
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A0385AB()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A03E814();
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		A <<= 1;
		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		X = A;
		A = [0x03859F];
		A &= 0x00FF;
		C = 0;
		A += 0x0080 + C;
		[0x3A] = A;
		X = 0x011C;
	}

	public void A0385D5()
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
		temp = X - 0x012C;

		if (Z == 0)
			return this.A0385D5();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A0385F7()
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
		temp = A - [0x70024E];

		if (Z == 0)
			return this.A038627();

		return this.A0386AC();
	}

	public void A038627()
	{
		[0x70024E] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = 0x0000;
	}

	public void A038633()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.A03863C();

		X++;
		return this.A038633();
	}

	public void A03863C()
	{
		C = 0;
		A += 0x0064 + C;
		[0x1125] = X;
		X = 0x0000;
	}

	public void A038646()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.A03864F();

		X++;
		return this.A038646();
	}

	public void A03864F()
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
			return this.A038668();

		A--;
	}

	public void A038668()
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

	public void A0386AC()
	{
		P |= 0x20;
		A = [0x70024D];
		temp = A - [0x70024F];

		if (Z == 0)
			return this.A0386B9();

		return;
	}

	public void A0386B9()
	{
		[0x70024F] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = 0x0000;
	}

	public void A0386C5()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.A0386CE();

		X++;
		return this.A0386C5();
	}

	public void A0386CE()
	{
		C = 0;
		A += 0x0064 + C;
		[0x1125] = X;
		X = 0x0000;
	}

	public void A0386D8()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.A0386E1();

		X++;
		return this.A0386D8();
	}

	public void A0386E1()
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
			return this.A0386FA();

		A--;
	}

	public void A0386FA()
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

	public void A0387A6()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0xFFFF;
		[0x11EF] = A;
		A = 0x0000;
		[0x11F1] = A;
		P = Stack.Pop();
	}

	public void A0387B6()
	{
		return;
	}

	public void A0387D7()
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

	public void A03880A()
	{
		P &= ~0x30;
		A = [0x122A];

		if (Z == 0)
			return this.A038821();

		A = [0x1DDA];
		temp = A - 0x0016;

		if (Z == 0)
			return this.A038829();

		A = [0x1DE4];
		A &= 0x00FF;

		if (Z == 1)
			return this.A038829();

	}

	public void A038821()
	{
		A = [0x10ED];
		A &= 0x00FF;

		if (Z == 1)
			return this.A038830();

	}

	public void A038829()
	{
		this.A0387D7();
		return this.A038D64();
	}

	public void A038830()
	{
		A = [0x11C2];
		A &= 0x00FF;

		if (Z == 1)
			return this.A038845();

		A = 0x0070;
		[0x75] = A;
		A = 0x0060;
		[0x77] = A;
		return this.A038A4C();
	}

	public void A038845()
	{
		X = [0x10E1];
		[0x11DB] = X;
		A = X;
		[0x700254] = A;

		if (Z == 1)
			return this.A038855();

		return this.A038A1B();
	}

	public void A038855()
	{
		[0x11DB] = 0;
		A = [0x11EF];
		temp = A - 0xFFFF;

		if (Z == 1)
			return this.A038864();

		this.A0387A6();
	}

	public void A038864()
	{
		P |= 0x20;
		P &= ~0x10;
		P &= ~0x20;
		A = 0x0014;
		temp = A - [0x11DD];

		if (Z == 1)
			return this.A038899();

		C = 1;
		A -= 0x11DD - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038885();

		temp = A - 0x0004;

		if (N == 0)
			return this.A03888D();

		A = 0x0004;
		return this.A03888D();
	}

	public void A038885()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A03888D();

		A = 0xFFFC;
	}

	public void A03888D()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DD] + C;
	}

	public void A038899()
	{
		[0x11DD] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		temp = A - [0x11DF];

		if (Z == 1)
			return this.A0388CF();

		C = 1;
		A -= 0x11DF - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A0388BB();

		temp = A - 0x0004;

		if (N == 0)
			return this.A0388C3();

		A = 0x0004;
		return this.A0388C3();
	}

	public void A0388BB()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A0388C3();

		A = 0xFFFC;
	}

	public void A0388C3()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DF] + C;
	}

	public void A0388CF()
	{
		[0x11DF] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00E4;
		temp = A - [0x11E3];

		if (Z == 1)
			return this.A038905();

		C = 1;
		A -= 0x11E3 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A0388F1();

		temp = A - 0x0004;

		if (N == 0)
			return this.A0388F9();

		A = 0x0004;
		return this.A0388F9();
	}

	public void A0388F1()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A0388F9();

		A = 0xFFFC;
	}

	public void A0388F9()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E3] + C;
	}

	public void A038905()
	{
		[0x11E3] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		temp = A - [0x11E5];

		if (Z == 1)
			return this.A03893B();

		C = 1;
		A -= 0x11E5 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038927();

		temp = A - 0x0004;

		if (N == 0)
			return this.A03892F();

		A = 0x0004;
		return this.A03892F();
	}

	public void A038927()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A03892F();

		A = 0xFFFC;
	}

	public void A03892F()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E5] + C;
	}

	public void A03893B()
	{
		[0x11E5] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00E4;
		temp = A - [0x11E7];

		if (Z == 1)
			return this.A038971();

		C = 1;
		A -= 0x11E7 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A03895D();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038965();

		A = 0x0004;
		return this.A038965();
	}

	public void A03895D()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038965();

		A = 0xFFFC;
	}

	public void A038965()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E7] + C;
	}

	public void A038971()
	{
		[0x11E7] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00A4;
		temp = A - [0x11E9];

		if (Z == 1)
			return this.A0389A7();

		C = 1;
		A -= 0x11E9 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038993();

		temp = A - 0x0004;

		if (N == 0)
			return this.A03899B();

		A = 0x0004;
		return this.A03899B();
	}

	public void A038993()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A03899B();

		A = 0xFFFC;
	}

	public void A03899B()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E9] + C;
	}

	public void A0389A7()
	{
		[0x11E9] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x0014;
		temp = A - [0x11EB];

		if (Z == 1)
			return this.A0389DD();

		C = 1;
		A -= 0x11EB - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A0389C9();

		temp = A - 0x0004;

		if (N == 0)
			return this.A0389D1();

		A = 0x0004;
		return this.A0389D1();
	}

	public void A0389C9()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A0389D1();

		A = 0xFFFC;
	}

	public void A0389D1()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11EB] + C;
	}

	public void A0389DD()
	{
		[0x11EB] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0x00A4;
		temp = A - [0x11ED];

		if (Z == 1)
			return this.A038A13();

		C = 1;
		A -= 0x11ED - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A0389FF();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038A07();

		A = 0x0004;
		return this.A038A07();
	}

	public void A0389FF()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038A07();

		A = 0xFFFC;
	}

	public void A038A07()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11ED] + C;
	}

	public void A038A13()
	{
		[0x11ED] = A;
		P |= 0x20;
		return this.A038D64();
	}

	public void A038A1B()
	{
		A = [0x0C + X];
		C = 1;
		A -= 0xC5 - !C;
		[0x00] = A;
		A = [0x0E + X];
		C = 1;
		A -= 0xC7 - !C;
		[0x06] = A;
		A = [0x10 + X];
		C = 1;
		A -= 0xC9 - !C;
		[0x93] = A;
		P |= 0x20;
		this.A01F1CE();
		P &= ~0x20;
		A = [0xB7];
		[0x00] = A;
		A = [0xB9];
		[0x06] = A;
		A = [0xBB];
		[0x93] = A;
		P |= 0x20;
		P |= 0x30;
		this.A01F334();
	}

	public void A038A4C()
	{
		P &= ~0x30;
		A = [0x75];
		temp = A - 0x0014;

		if (C == 1)
			return this.A038A58();

		A = 0x0014;
	}

	public void A038A58()
	{
		temp = A - 0x00CC;

		if (C == 0)
			return this.A038A60();

		A = 0x00CC;
	}

	public void A038A60()
	{
		[0x75] = A;
		A = [0x77];
		temp = A - 0x0014;

		if (C == 1)
			return this.A038A6C();

		A = 0x0014;
	}

	public void A038A6C()
	{
		temp = A - 0x00AC;

		if (C == 0)
			return this.A038A74();

		A = 0x00AC;
	}

	public void A038A74()
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
		temp = A - [0x11DD];

		if (Z == 1)
			return this.A038AC2();

		C = 1;
		A -= 0x11DD - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038AAE();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038AB6();

		A = 0x0004;
		return this.A038AB6();
	}

	public void A038AAE()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038AB6();

		A = 0xFFFC;
	}

	public void A038AB6()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DD] + C;
	}

	public void A038AC2()
	{
		[0x11DD] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		temp = A - [0x11DF];

		if (Z == 1)
			return this.A038AF7();

		C = 1;
		A -= 0x11DF - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038AE3();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038AEB();

		A = 0x0004;
		return this.A038AEB();
	}

	public void A038AE3()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038AEB();

		A = 0xFFFC;
	}

	public void A038AEB()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11DF] + C;
	}

	public void A038AF7()
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
		temp = A - [0x11E3];

		if (Z == 1)
			return this.A038B40();

		C = 1;
		A -= 0x11E3 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038B2C();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038B34();

		A = 0x0004;
		return this.A038B34();
	}

	public void A038B2C()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038B34();

		A = 0xFFFC;
	}

	public void A038B34()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E3] + C;
	}

	public void A038B40()
	{
		[0x11E3] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		temp = A - [0x11E5];

		if (Z == 1)
			return this.A038B75();

		C = 1;
		A -= 0x11E5 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038B61();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038B69();

		A = 0x0004;
		return this.A038B69();
	}

	public void A038B61()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038B69();

		A = 0xFFFC;
	}

	public void A038B69()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E5] + C;
	}

	public void A038B75()
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
		temp = A - [0x11E7];

		if (Z == 1)
			return this.A038BBE();

		C = 1;
		A -= 0x11E7 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038BAA();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038BB2();

		A = 0x0004;
		return this.A038BB2();
	}

	public void A038BAA()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038BB2();

		A = 0xFFFC;
	}

	public void A038BB2()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E7] + C;
	}

	public void A038BBE()
	{
		[0x11E7] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		temp = A - [0x11E9];

		if (Z == 1)
			return this.A038BF3();

		C = 1;
		A -= 0x11E9 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038BDF();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038BE7();

		A = 0x0004;
		return this.A038BE7();
	}

	public void A038BDF()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038BE7();

		A = 0xFFFC;
	}

	public void A038BE7()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11E9] + C;
	}

	public void A038BF3()
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
		temp = A - [0x11EB];

		if (Z == 1)
			return this.A038C3C();

		C = 1;
		A -= 0x11EB - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038C28();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038C30();

		A = 0x0004;
		return this.A038C30();
	}

	public void A038C28()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038C30();

		A = 0xFFFC;
	}

	public void A038C30()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11EB] + C;
	}

	public void A038C3C()
	{
		[0x11EB] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x06];
		temp = A - [0x11ED];

		if (Z == 1)
			return this.A038C71();

		C = 1;
		A -= 0x11ED - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A038C5D();

		temp = A - 0x0004;

		if (N == 0)
			return this.A038C65();

		A = 0x0004;
		return this.A038C65();
	}

	public void A038C5D()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A038C65();

		A = 0xFFFC;
	}

	public void A038C65()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11ED] + C;
	}

	public void A038C71()
	{
		[0x11ED] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x11EF];

		if (Z == 1)
			return this.A038CAB();

		A = [0x11EB];
		C = 1;
		A -= 0x00 - !C;

		if (N == 0)
			return this.A038C89();

		A ^= 0xFFFF;
		A++;
	}

	public void A038C89()
	{
		[0x11EF] = A;

		if (Z == 0)
			return this.A038C93();

		[0x11F1]++;
		Stack.Push(A);
		A = Stack.Pop();
	}

	public void A038C93()
	{
		temp = A - 0x0014;

		if (C == 1)
			return this.A038CAB();

		A = [0x118E];
		A &= 0x00FF;

		if (Z == 0)
			return this.A038CAB();

		P &= ~0x20;
		A = 0xEA1D;
		this.A029213();
		P |= 0x20;
	}

	public void A038CAB()
	{
		P &= ~0x20;
		A = [0x11EF];

		if (Z == 0)
			return this.A038CC2();

		A = [0x11E7];
		temp = A - 0x00BD;

		if (C == 1)
			return this.A038CC2();

		A = [0x11E9];
		temp = A - 0x00B8;

		if (C == 0)
			return this.A038CC5();

	}

	public void A038CC2()
	{
		return this.A038D64();
	}

	public void A038CC5()
	{
		this.A0387B6();
		X = [0x10E1];
		P |= 0x20;
		A = [0x001E + X];
		A &= 0x20;

		if (Z == 1)
			return this.A038CD9();

		return this.A038D64();
	}

	public void A038CD9()
	{
		P &= ~0x20;
		A = [0x04 + X];
		temp = A - 0xBE6B;

		if (Z == 1)
			return this.A038CC2();

		C = 0;
		A += 0x0021 + C;
		[0x50] = A;
		A = 0x0008;
		[0x00] = A;
		X = 0x0024;
		Y = [0x11F1];

		if (Z == 1)
			return this.A038CC2();

		A = [0x11F1];
		A++;
		temp = A - 0x0006;

		if (Z == 1)
			return this.A038D01();

		[0x11F1] = A;
	}

	public void A038D01()
	{
		A = [(0x50)];
		A &= 0x00FF;
		temp = A - 0x0020;

		if (Z == 0)
			return this.A038D10();

		A = 0x0000;
		return this.A038D36();
	}

	public void A038D10()
	{
		A &= 0x00FF;

		if (Z == 0)
			return this.A038D18();

		return this.A038D64();
	}

	public void A038D18()
	{
		temp = A - 0x0041;

		if (C == 1)
			return this.A038D23();

		C = 1;
		A -= 0x0041 - !C;
		return this.A038D32();
	}

	public void A038D23()
	{
		temp = A - 0x0061;

		if (C == 0)
			return this.A038D2E();

		C = 1;
		A -= 0x0061 - !C;
		return this.A038D32();
	}

	public void A038D2E()
	{
		C = 1;
		A -= 0x0041 - !C;
	}

	public void A038D32()
	{
		C = 0;
		A += 0x00B7 + C;
	}

	public void A038D36()
	{
		[0x3A] = A;
		[0x50]++;
		P |= 0x20;
		A = [0x11E9];
		A = (A >> 4) | (A << 4);
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
			return this.A038D64();

		X = A;
		return this.A038D01();
	}

	public void A038D64()
	{
		P &= ~0x20;
		return;
	}

	public void A038D6F()
	{
		this.A038D73();
		return;
	}

	public void A038D73()
	{
		Stack.Push(X);
		Stack.Push(Y);
		Stack.Push(P);
		P &= ~0x20;
		Stack.Push(X);
		A = X;
		X = [0x10DB];
	}

	public void A038D7D()
	{
		temp = A - [0x19 + X];

		if (Z == 0)
			return this.A038D83();

		[0x19 + X] = 0;
	}

	public void A038D83()
	{
		temp = A - [0x06 + X];

		if (Z == 0)
			return this.A038D89();

		[0x06 + X] = 0;
	}

	public void A038D89()
	{
		temp = A - [0x1B + X];

		if (Z == 0)
			return this.A038D90();

		A = X;
		[0x1B + X] = A;
	}

	public void A038D90()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A038D7D();

		X = Stack.Pop();
		Y = [0x02 + X];

		if (Z == 0)
			return this.A038DA7();

		Y = [0x00 + X];
		[0x10DB] = Y;
		A = 0x0000;
		[0x0002 + Y] = A;
		return this.A038DB5();
	}

	public void A038DA7()
	{
		Stack.Push(X);
		A = [0x00 + X];
		X = A;
		[0x00 + Y] = Y;
		temp = A - 0x0000;

		if (Z == 1)
			return this.A038DB4();

		[0x02 + X] = X;
	}

	public void A038DB4()
	{
		X = Stack.Pop();
	}

	public void A038DB5()
	{
		A = [0x10DD];
		[0x00 + X] = A;
		[0x10DD] = X;
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A038DC1()
	{
		this.A038DC5();
		return;
	}

	public void A038DC5()
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
		A = [0x7E1CDE];

		if (Z == 1)
			return this.A038DDC();

		X = Y;
		[0x7E363E + X] = A;
	}

	public void A038DDC()
	{
		P &= ~0x20;
		Y = Stack.Pop();
		X = Stack.Pop();
		Stack.Push(X);
		A = X;
		X = [0x10DB];
	}

	public void A038DE5()
	{
		temp = A - [0x19 + X];

		if (Z == 0)
			return this.A038DEB();

		[0x19 + X] = 0;
	}

	public void A038DEB()
	{
		temp = A - [0x06 + X];

		if (Z == 0)
			return this.A038DF1();

		[0x06 + X] = 0;
	}

	public void A038DF1()
	{
		temp = A - [0x1B + X];

		if (Z == 0)
			return this.A038DF8();

		A = X;
		[0x1B + X] = A;
	}

	public void A038DF8()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A038DE5();

		X = Stack.Pop();
		Y = [0x02 + X];

		if (Z == 0)
			return this.A038E0F();

		Y = [0x00 + X];
		[0x10DB] = Y;
		A = 0x0000;
		[0x0002 + Y] = A;
		return this.A038E1D();
	}

	public void A038E0F()
	{
		Stack.Push(X);
		A = [0x00 + X];
		X = A;
		[0x00 + Y] = Y;
		temp = A - 0x0000;

		if (Z == 1)
			return this.A038E1C();

		[0x02 + X] = X;
	}

	public void A038E1C()
	{
		X = Stack.Pop();
	}

	public void A038E1D()
	{
		A = [0x10DD];
		[0x00 + X] = A;
		[0x10DD] = X;
		P = Stack.Pop();
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A038EA8()
	{
		Stack.Push(P);
		P &= ~0x30;
		[0x1DC6] = 0;
		X = [0x10DB];

		if (Z == 0)
			return this.A038EB5();

		P = Stack.Pop();
		return;
	}

	public void A038EB5()
	{
		Y = 0x0000;
	}

	public void A038EB8()
	{
		Stack.Push(X);
		A = [0x002C + X];
		A &= 0x0004;

		if (Z == 0)
			return this.A038F05();

		A = [0x1D + X];
		A &= 0x0010;

		if (Z == 0)
			return this.A038F05();

		A = [0x28 + X];
		A &= 0x00FF;

		if (Z == 1)
			return this.A038F05();

		A = [0x08 + X];
		temp = A & 0x0001;

		if (Z == 0)
			return this.A038F05();

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

	public void A038F05()
	{
		X = Stack.Pop();
		A = [0x00 + X];
		X = A;

		if (Z == 0)
			return this.A038EB8();

		P = Stack.Pop();
		return;
	}

	public void A0394BE()
	{
		temp = A - 0x0000;

		if (Z == 1)
			return this.A0394E5();

		[0x3A] = X;
		X = [0x112A];

		if (Z == 1)
			return this.A0394E1();

		Y = X;
	}

	public void A0394CB()
	{
		temp = A - [0x04 + X];

		if (Z == 1)
			return this.A0394D4();

	}

	public void A0394CF()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A0394CB();

	}

	public void A0394D4()
	{
		temp = X - [0x3A];

		if (Z == 1)
			return this.A0394CF();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = X;
		X = [0x3A];
		return;
	}

	public void A0394E1()
	{
		Y = 0x0000;
		return;
	}

	public void A0394E5()
	{
		Y = [0x112A];
		A = [0x00 + X];
		[0x112A] = A;
		return;
	}

	public void A039551()
	{
		temp = A - 0x0000;

		if (Z == 1)
			return this.A039591();

		[0x02] = X;
		X = [0x112A];

		if (Z == 1)
			return this.A03958D();

		[0x08] = A;
		[0x3C] = 0;
	}

	public void A039561()
	{
		temp = X - [0x02];

		if (Z == 1)
			return this.A03957E();

		A = [0x04 + X];
		temp = A - [0x08];

		if (Z == 0)
			return this.A03957E();

		Y = [0x02];
		this.A039CC4();
		P &= ~0x20;
		A = [0x1115];
		temp = A - [0x3A];

		if (N == 0)
			return this.A03957E();

		[0x3A] = A;
		[0x3C] = X;
	}

	public void A03957E()
	{
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A039561();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = [0x3C];
		X = [0x02];
		return;
	}

	public void A03958D()
	{
		Y = 0x0000;
		return;
	}

	public void A039591()
	{
		[0x02] = X;
		X = [0x112A];

		if (Z == 1)
			return this.A039604();

		[0x3C] = 0;
		[0x1125] = 0;
	}

	public void A03959D()
	{
		temp = X - [0x02];

		if (Z == 1)
			return this.A0395F3();

		P |= 0x20;
		A = [0x001E + X];
		A &= [0x3F];

		if (Z == 1)
			return this.A0395F3();

		P &= ~0x20;
		Y = [0x02];
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		this.A039CC4();
		Stack.Push(X);
		X = Y;
		Y = Stack.Pop();
		P &= ~0x20;
		A = [0x00];
		A ^= 0xFFFF;
		A++;
		[0x00] = A;
		this.A03E8FD();
		P &= ~0x20;
		Y = [0x02];
		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		P |= 0x20;
		C = 1;
		A -= [0x0013 + Y] - !C;

		if (N == 0)
			return this.A0395D9();

		A ^= 0xFF;
		A++;
	}

	public void A0395D9()
	{
		temp = A - [0x0E];

		if (C == 1)
			return this.A0395E2();

		[0x0E] = A;
		[0x1125] = X;
	}

	public void A0395E2()
	{
		temp = A - 0x19;

		if (C == 1)
			return this.A0395F3();

		P &= ~0x20;
		A = [0x1115];
		temp = A - [0x3A];

		if (C == 1)
			return this.A0395F3();

		[0x3A] = A;
		[0x3C] = X;
	}

	public void A0395F3()
	{
		P &= ~0x20;
		Y = [0x00 + X];
		X = Y;

		if (Z == 0)
			return this.A03959D();

		Y = [0x00 + X];
		[0x112A] = Y;
		Y = [0x3C];
		X = [0x02];
		return;
	}

	public void A039604()
	{
		Y = 0x0000;
		return;
	}

	public void A039A6B()
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
		this.A03E880();
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
		this.A03E880();
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
		this.A03E880();
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
		this.A03E880();
		A = [0x69];
		C = 1;
		A -= 0x02 - !C;
		[0x02] = A;
		A = [0x6A];
		A -= 0x03 - !C;
		[0x03] = A;
		P = Stack.Pop();
		Y = [0x3C];
		X = [0x3A];
		return;
	}

	public void A039CC4()
	{
		P &= ~0x20;
		A = [0x000C + Y];
		C = 1;
		A -= [0x0C + X] - !C;
		[0x00] = A;

		if (N == 0)
			return this.A039CD6();

		A = 0x0000;
		C = 1;
		A -= 0x00 - !C;
	}

	public void A039CD6()
	{
		[0x1115] = A;
		A = [0x0010 + Y];
		C = 1;
		A -= [0x10 + X] - !C;
		[0x06] = A;

		if (N == 1)
			return this.A039CE9();

		C = 0;
		A += [0x1115] + C;
		return this.A039CEF();
	}

	public void A039CE9()
	{
		C = 1;
		A = [0x1115];
		A -= 0x06 - !C;
	}

	public void A039CEF()
	{
		[0x1115] = A;
		P |= 0x20;
		return;
	}

	public void A039DFF()
	{
		this.A039E06();
		this.A039E27();
		return;
	}

	public void A039E06()
	{
		P &= ~0x30;
		A = [0x1DDA];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B];
		[0x70024A] = A;
		A = 0x0000;
		[0x700246] = A;
		A = [0x039D21];
		[0x1DD8] = A;
		P |= 0x20;
		return;
	}

	public void A039E27()
	{
		P &= ~0x30;
		A = [0x1DEB];
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039D1B];
		[0x700248] = A;
		A = 0x0000;
		[0x700244] = A;
		A = [0x039D21];
		[0x1DE9] = A;
		P |= 0x20;
		return;
	}

	public void A039E48()
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

	public void A039E61()
	{
		P |= 0x20;
		A = [0x1186];
		temp = A - 0x00;

		if (Z == 0)
			return this.A039EA4();

		A = [0x1DDC];
		A++;
		temp = A - [0x1DDE];

		if (Z == 0)
			return this.A039E75();

		A = 0x00;
	}

	public void A039E75()
	{
		temp = A - [0x1DDC];

		if (Z == 1)
			return this.A039EA4();

		[0x1DDC] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x1DDF + X];
		[0x1DDA] = A;
		this.A039E06();
		P &= ~0x20;
		A = [0x1DD8];
		X = [0x11A0];
		[0x04 + X] = A;
		A = [0x1DDA];
		this.A039EED();
		this.A03840A();
		P |= 0x20;
	}

	public void A039EA4()
	{
		return;
	}

	public void A039EA5()
	{
		P |= 0x20;
		A = [0x1DED];
		A++;
		temp = A - [0x1DEF];

		if (Z == 0)
			return this.A039EB2();

		A = 0x00;
	}

	public void A039EB2()
	{
		temp = A - [0x1DED];

		if (Z == 1)
			return this.A039EEC();

		[0x1DED] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x1DF0 + X];
		[0x1DEB] = A;
		this.A039E27();
		P &= ~0x20;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0000;

		if (Z == 0)
			return this.A039EE0();

		A = [0x1DE9];
		X = [0x11A2];
		[0x04 + X] = A;
	}

	public void A039EE0()
	{
		A = [0x1DEB];
		this.A039EED();
		this.A03840A();
		P |= 0x20;
	}

	public void A039EEC()
	{
		return;
	}

	public void A039EED()
	{
		P &= ~0x20;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x039D20];
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x039DEB];
		[0x700222] = A;
		A = [0x039DED];
		[0x700220] = A;
		A = 0x0010;
		[0x70021E] = A;
		P |= 0x20;
		return;
	}

	public void A039F42()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		[0x1129] = 0;
		[0x10FE] = X;
		A = [0x001E + X];
		A &= 0x08;

		if (Z == 0)
			return this.A039F58();

		return this.A039F7C();
	}

	public void A039F58()
	{
		A = [0x11B5];

		if (Z == 0)
			return this.A039F69();

		A = [0x118E];

		if (Z == 1)
			return this.A039F7C();

		A = [0x1216];

		if (Z == 0)
			return this.A039F7C();

		P = Stack.Pop();
		return;
	}

	public void A039F69()
	{
		A = [0x1216];

		if (Z == 0)
			return this.A039F7C();

		Y = [0x04 + X];
		temp = Y - 0xCAE7;

		if (Z == 1)
			return this.A039F7C();

		temp = Y - 0xCB11;

		if (Z == 1)
			return this.A039F7C();

		P = Stack.Pop();
		return;
	}

	public void A039F7C()
	{
		A = [0x28 + X];

		if (Z == 0)
			return this.A039F91();

		A = [0x7E1CD1];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CCF];

		if (Z == 0)
			return this.A039FDA();

		P |= 0x20;
	}

	public void A039F91()
	{
		A = [0x1D + X];
		temp = A & 0x08;

		if (Z == 1)
			return this.A039FB2();

		A = [0x7E1CD4];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CD2];

		if (Z == 0)
			return this.A039FDA();

		P |= 0x20;
		A = [0x001D + X];
		A &= 0xF7;
		[0x001D + X] = A;
		return this.A039FCF();
	}

	public void A039FB2()
	{
		temp = A & 0x80;

		if (Z == 1)
			return this.A039FCF();

		A = [0x001D + X];
		A &= 0x7F;
		[0x001D + X] = A;
		A = [0x7E1CD7];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x7E1CD5];

		if (Z == 0)
			return this.A039FDA();

		P |= 0x20;
	}

	public void A039FCF()
	{
		A = [0x18 + X];
		[0x1106] = A;
		P &= ~0x20;
		A = [0x16 + X];

		if (Z == 1)
			return this.A03A003();

	}

	public void A039FDA()
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

	public void A03A003()
	{
		P = Stack.Pop();
		return;
	}

	public void A03A054()
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

	public void A03A102()
	{
		P &= ~0x20;
		Y = X;
		X = [0x10DD];

		if (Z == 0)
			return this.A03A110();

		P |= 0x20;
		X = Y;
		return this.A03A137();
	}

	public void A03A110()
	{
		A = [0x00 + X];
		[0x10DD] = A;
		A = Y;

		if (Z == 0)
			return this.A03A124();

		A = [0x10DB];
		[0x00 + X] = A;
		[0x02 + X] = 0;
		[0x10DB] = X;
		return this.A03A12D();
	}

	public void A03A124()
	{
		A = [0x0000 + Y];
		[0x00 + X] = A;
		[0x00 + Y] = Y;
		[0x02 + X] = X;
	}

	public void A03A12D()
	{
		Y = [0x00 + X];

		if (Z == 1)
			return this.A03A133();

		[0x02 + Y] = Y;
	}

	public void A03A133()
	{
		P |= 0x20;
		C = 1;
		return;
	}

	public void A03A137()
	{
		P &= ~0x20;
		[0x127B]++;
		P |= 0x20;
		C = 0;
		return;
	}

	public void A03A17D()
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
		this.A03A3B4();
		P |= 0x20;
		P &= ~0x10;
		[0x1130] = 0;
		this.A03A5C3();
		this.A03A1E2();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A03A1E2()
	{
		P &= ~0x30;
		X = [0x10DB];
		A = X;

		if (Z == 1)
			return this.A03A205();

	}

	public void A03A1EA()
	{
		[0x1108] = 0;
		this.A039F42();
		A = [0x1108];

		if (Z == 0)
			return this.A03A1FD();

		Y = [0x00 + X];
	}

	public void A03A1F8()
	{
		X = Y;

		if (Z == 0)
			return this.A03A1EA();

		return this.A03A205();
	}

	public void A03A1FD()
	{
		Y = [0x00 + X];
		this.A038D6F();
		return this.A03A1F8();
	}

	public void A03A205()
	{
		return;
	}

	public void A03A3B4()
	{
		Stack.Push(X);
		Stack.Push(Y);
		P &= ~0x20;
		A &= 0x00FF;
		temp = A - 0x0001;

		if (Z == 0)
			return this.A03A3CD();

		Stack.Push(A);
		X = [0x10FC];
		A = [0x0E + X];
		C = 1;
		A -= 0x005D - !C;
		[0x0E + X] = A;
		A = Stack.Pop();
	}

	public void A03A3CD()
	{
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x03A206];
		[0x7E3291] = A;
		A = [0x03A208];
		[0x7E3293] = A;
		A = [0x03A20A];
		[0x7E3295] = A;
		P |= 0x20;
		A = [0x03A20C];
		[0x1194] = A;
		A = [0x03A20D];
		[0x1195] = A;
		A = [0x03A20E];
		[0x1196] = A;
		A = [0x03A20F];
		[0x1197] = A;
		A = [0x03A210];
		[0x119A] = A;
		A = [0x03A211];
		[0x119B] = A;
		A = [0x03A212];
		Stack.Push(X);
		X = [0x10FC];
		A |= 0x80;
		[0x7E1CDC + X] = A;
		X = Stack.Pop();
		P &= ~0x20;
		A = [0x03A214];
		temp = A - [0x11A6];

		if (Z == 1)
			return this.A03A436();

		[0x11A6] = A;
		[0x11A4] = A;
	}

	public void A03A436()
	{
		P |= 0x20;
		this.A03840A();
		Y = Stack.Pop();
		X = Stack.Pop();
		[0x1DFC] = 0;
		A = [0x1186];
		temp = A - 0x06;

		if (Z == 1)
			return this.A03A45B();

		temp = A - 0x05;

		if (Z == 1)
			return this.A03A45B();

		temp = A - 0x04;

		if (Z == 1)
			return this.A03A45B();

		temp = A - 0x00;

		if (Z == 1)
			return this.A03A45B();

		this.A03A4FD();
		this.A03A51A();
		return;
	}

	public void A03A45B()
	{
		this.A03A537();
		this.A03A554();
		return;
	}

	public void A03A479()
	{
		this.A03A485();
		return;
	}

	public void A03A47D()
	{
		this.A03A481();
		return;
	}

	public void A03A481()
	{
		Stack.Push(A);
		return this.A03A49E();
	}

	public void A03A485()
	{
		Stack.Push(A);
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = 0x01;
		temp = X - 0x0000;

		if (Z == 1)
			return this.A03A499();

	}

	public void A03A495()
	{
		A <<= 1;
		X--;

		if (Z == 0)
			return this.A03A495();

	}

	public void A03A499()
	{
		A &= [0x11D8];

		if (Z == 1)
			return this.A03A4F9();

	}

	public void A03A49E()
	{
		A = [0x1186];
		temp = A - 0x01;

		if (Z == 0)
			return this.A03A4B4();

		P &= ~0x20;
		X = [0x10FC];
		A = [0x0E + X];
		C = 0;
		A += 0x005D + C;
		[0x0E + X] = A;
		P |= 0x20;
	}

	public void A03A4B4()
	{
		A = [0x1186];
		temp = A - 0x04;

		if (C == 1)
			return this.A03A4F9();

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
		A = [0x03A376];

		if (Z == 1)
			return this.A03A4FA();

		A--;
		P |= 0x20;
		[0x1186] = A;
		[0x1187] = A;
		this.A03A3B4();
		[0x10F1] = A;
		A = [0x1186];
		temp = A - 0x01;

		if (Z == 0)
			return this.A03A4F0();

		return this.A03A4F6();
	}

	public void A03A4F0()
	{
		[0x1193] = 0;
		[0x1191] = 0;
	}

	public void A03A4F6()
	{
		A = 0x00;
		return;
	}

	public void A03A4F9()
	{
		A = Stack.Pop();
	}

	public void A03A4FA()
	{
		A = 0x60FF;
	}

	public void A03A4FD()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.A03A516();

	}

	public void A03A505()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.A03A516();

		A = 0xE035;
		temp = A - [0x16 + X];

		if (Z == 0)
			return this.A03A505();

		A = 0xBE6B;
		[0x04 + X] = A;
	}

	public void A03A516()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void A03A51A()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.A03A533();

	}

	public void A03A522()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.A03A533();

		A = 0xE182;
		temp = A - [0x16 + X];

		if (Z == 0)
			return this.A03A522();

		A = 0xBE6B;
		[0x04 + X] = A;
	}

	public void A03A533()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void A03A537()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.A03A550();

	}

	public void A03A53F()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.A03A550();

		A = 0xE035;
		temp = A - [0x16 + X];

		if (Z == 0)
			return this.A03A53F();

		A = [0x1DE9];
		[0x04 + X] = A;
	}

	public void A03A550()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void A03A554()
	{
		P &= ~0x20;
		Stack.Push(X);
		X = [0x10DB];

		if (Z == 1)
			return this.A03A56D();

	}

	public void A03A55C()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.A03A56D();

		A = 0xE182;
		temp = A - [0x16 + X];

		if (Z == 0)
			return this.A03A55C();

		A = [0x1DD8];
		[0x04 + X] = A;
	}

	public void A03A56D()
	{
		X = Stack.Pop();
		P |= 0x20;
		return;
	}

	public void A03A572()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void A03A576()
	{
		A = 0x02;
		[0x38] = A;
	}

	public void A03A57A()
	{
		A = [0x38];

		if (Z == 0)
			return this.A03A57A();

		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 0)
			return this.A03A576();

	}

	public void A03A585()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void A03A58D()
	{
		A = [0x38];

		if (Z == 0)
			return this.A03A58D();

	}

	public void A03A591()
	{
		A = [0x10C2];
		temp = A & 0x20;

		if (Z == 1)
			return this.A03A5A5();

		A = [0x10C1];
		temp = A & 0x20;

		if (Z == 0)
			return this.A03A5A5();

		this.A02C897();
		return this.A03A591();
	}

	public void A03A5A5()
	{
		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 1)
			return this.A03A585();

	}

	public void A03A5AC()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x02;
		[0x38] = A;
	}

	public void A03A5B4()
	{
		A = [0x38];

		if (Z == 0)
			return this.A03A5B4();

		A = [0x10C0];
		temp = A & 0x10;

		if (Z == 0)
			return this.A03A5AC();

		[0x10ED] = 0;
		return;
	}

	public void A03A5C3()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x121B];

		if (Z == 1)
			return this.A03A5CF();

		[0x121B]--;
	}

	public void A03A5CF()
	{
		A = [0x1AD1];

		if (Z == 1)
			return this.A03A61C();

		X = [0x10FC];
		P &= ~0x20;
		A = [0x04 + X];
		temp = A - 0xCD40;
		P |= 0x20;

		if (Z == 1)
			return this.A03A61C();

		P &= ~0x20;
		[0x24 + X]--;
		P |= 0x20;

		if (Z == 1)
			return this.A03A5EE();

		return this.A03A61C();
	}

	public void A03A5EE()
	{
		P &= ~0x20;
		A = 0x0064;
		[0x24 + X] = A;
		P |= 0x20;
		A = [0x1186];
		A++;
		temp = A - 0x04;

		if (Z == 0)
			return this.A03A617();

		P &= ~0x20;
		A = [0x10B9];
		C = 0;
		A += 0x0008 + C;
		temp = A - 0x0018;

		if (Z == 0)
			return this.A03A610();

		A = 0x0000;
	}

	public void A03A610()
	{
		[0x10B9] = A;
		P |= 0x20;
		A = 0x00;
	}

	public void A03A617()
	{
		Stack.Push(X);
		this.A03A485();
		X = Stack.Pop();
	}

	public void A03A61C()
	{
		A = [0x9E];
		temp = A - 0x00;

		if (Z == 1)
			return this.A03A625();

		return this.A03A901();
	}

	public void A03A625()
	{
		A = [0x1186];
		temp = A - [0x1187];

		if (Z == 1)
			return this.A03A64C();

		A = [0x1187];
		[0x1186] = A;
		this.A03A3B4();
		A = [0x1ABF];

		if (Z == 0)
			return this.A03A64C();

		A = [0x1186];
		temp = A - 0x01;

		if (Z == 0)
			return this.A03A64C();

		A = 0x40;
		[0x1193] = A;
		A = 0x03;
		[0x1191] = A;
	}

	public void A03A64C()
	{
		A = [0x1AD1];

		if (Z == 1)
			return this.A03A654();

		return this.A03AE3E();
	}

	public void A03A654()
	{
		A = [0x10BC];
		A &= 0x10;

		if (Z == 0)
			return this.A03A65F();

		return this.A03A687();
	}

	public void A03A65F()
	{
		A = [0x1188];
		A &= 0x10;

		if (Z == 1)
			return this.A03A66A();

		return this.A03A687();
	}

	public void A03A66A()
	{
		P &= ~0x20;
		A = [0x1982];
		temp = A - 0x0028;
		P |= 0x20;

		if (N == 1)
			return this.A03A687();

		A = [0x1216];

		if (Z == 0)
			return this.A03A687();

		X = [0x116C];
		A = [0x28 + X];

		if (Z == 1)
			return this.A03A687();

		A = 0xFF;
		[0x10ED] = A;
	}

	public void A03A687()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 0)
			return this.A03A692();

		return this.A03A6E2();
	}

	public void A03A692()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.A03A69D();

		return this.A03A6BA();
	}

	public void A03A69D()
	{
		A = [0x1188];
		A &= 0x40;

		if (Z == 1)
			return this.A03A6A8();

		return this.A03A6BA();
	}

	public void A03A6A8()
	{
		this.A039E61();
		P &= ~0x20;
		A = 0xEA28;
		this.A029213();
		P |= 0x20;
		return this.A03A901();
	}

	public void A03A6BA()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.A03A6C5();

		return this.A03A6E2();
	}

	public void A03A6C5()
	{
		A = [0x1189];
		A &= 0x80;

		if (Z == 1)
			return this.A03A6D0();

		return this.A03A6E2();
	}

	public void A03A6D0()
	{
		this.A039EA5();
		P &= ~0x20;
		A = 0xEA28;
		this.A029213();
		P |= 0x20;
		return this.A03A901();
	}

	public void A03A6E2()
	{
		A = 0x03;
		temp = A - [0x1186];

		if (Z == 1)
			return this.A03A6EC();

		return this.A03A70A();
	}

	public void A03A6EC()
	{
		A = [0x10BE];
		A &= 0x30;
		temp = A - 0x30;

		if (Z == 1)
			return this.A03A6F9();

		return this.A03A70A();
	}

	public void A03A6F9()
	{
		A = [0x1189];
		A &= 0x30;
		temp = A - 0x30;

		if (Z == 0)
			return this.A03A706();

		return this.A03A70A();
	}

	public void A03A706()
	{
		this.A02C4B1();
	}

	public void A03A70A()
	{
		A = [0x10BC];
		A &= 0x20;

		if (Z == 0)
			return this.A03A715();

		return this.A03A764();
	}

	public void A03A715()
	{
		A = [0x1188];
		A &= 0x20;

		if (Z == 1)
			return this.A03A720();

		return this.A03A764();
	}

	public void A03A720()
	{
		A = 0x03;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A731();

	}

	public void A03A727()
	{
		A = [0x11D8];
		temp = A & 0x01;

		if (Z == 1)
			return this.A03A738();

		return this.A03A798();
	}

	public void A03A731()
	{
		A = 0x00;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A742();

	}

	public void A03A738()
	{
		A = [0x11D8];
		temp = A & 0x02;

		if (Z == 1)
			return this.A03A749();

		return this.A03A7F9();
	}

	public void A03A742()
	{
		A = 0x01;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A753();

	}

	public void A03A749()
	{
		A = [0x11D8];
		temp = A & 0x04;

		if (Z == 1)
			return this.A03A75A();

		return this.A03A85A();
	}

	public void A03A753()
	{
		A = 0x02;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A764();

	}

	public void A03A75A()
	{
		A = [0x11D8];
		temp = A & 0x08;

		if (Z == 1)
			return this.A03A727();

		return this.A03A8BA();
	}

	public void A03A764()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 1)
			return this.A03A76F();

		return this.A03A782();
	}

	public void A03A76F()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.A03A77A();

		return this.A03A901();
	}

	public void A03A77A()
	{
		A = [0x118E];

		if (Z == 1)
			return this.A03A782();

		return this.A03A901();
	}

	public void A03A782()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.A03A78D();

		return this.A03A7E3();
	}

	public void A03A78D()
	{
		A = [0x1188];
		A &= 0x40;

		if (Z == 1)
			return this.A03A798();

		return this.A03A7E3();
	}

	public void A03A798()
	{
		A = 0x00;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A7A2();

		return this.A03A901();
	}

	public void A03A7A2()
	{
		this.A03A485();

		if (Z == 1)
			return this.A03A7AA();

		return this.A03A901();
	}

	public void A03A7AA()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA80;
		this.A029213();
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
		return this.A03A901();
	}

	public void A03A7E3()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.A03A7EE();

		return this.A03A844();
	}

	public void A03A7EE()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.A03A7F9();

		return this.A03A844();
	}

	public void A03A7F9()
	{
		A = 0x01;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A803();

		return this.A03A901();
	}

	public void A03A803()
	{
		this.A03A485();

		if (Z == 1)
			return this.A03A80B();

		return this.A03A901();
	}

	public void A03A80B()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA84;
		this.A029213();
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
		return this.A03A901();
	}

	public void A03A844()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.A03A84F();

		return this.A03A8A4();
	}

	public void A03A84F()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.A03A85A();

		return this.A03A8A4();
	}

	public void A03A85A()
	{
		A = 0x02;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A864();

		return this.A03A901();
	}

	public void A03A864()
	{
		this.A03A485();

		if (Z == 1)
			return this.A03A86C();

		return this.A03A901();
	}

	public void A03A86C()
	{
		P &= ~0x20;
		A = 0xEA27;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA83;
		this.A029213();
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
		return this.A03A901();
	}

	public void A03A8A4()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.A03A8AF();

		return this.A03A901();
	}

	public void A03A8AF()
	{
		A = [0x1189];
		A &= 0x80;

		if (Z == 1)
			return this.A03A8BA();

		return this.A03A901();
	}

	public void A03A8BA()
	{
		A = 0x03;
		temp = A - [0x1186];

		if (Z == 0)
			return this.A03A8C4();

		return this.A03A901();
	}

	public void A03A8C4()
	{
		this.A03A485();

		if (Z == 0)
			return this.A03A901();

		P &= ~0x20;
		A = 0xEA27;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0xCA80;
		this.A029213();
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
		return this.A03A901();
	}

	public void A03A901()
	{
		A = [0x1186];
		temp = A - 0x02;

		if (Z == 1)
			return this.A03A917();

		temp = A - 0x06;

		if (Z == 1)
			return this.A03A917();

		temp = A - 0x00;

		if (Z == 1)
			return this.A03A917();

		temp = A - 0x01;

		if (Z == 1)
			return this.A03A917();

		return this.A03AABA();
	}

	public void A03A917()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 1)
			return this.A03A922();

		return this.A03AABA();
	}

	public void A03A922()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.A03A92D();

		return this.A03AABA();
	}

	public void A03A92D()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.A03A938();

		return this.A03AABA();
	}

	public void A03A938()
	{
		A = [0x1191];

		if (N == 0)
			return this.A03A940();

		return this.A03AA43();
	}

	public void A03A940()
	{
		A = [0x127A];
		P &= ~0x20;
		A &= 0x00FF;
		Stack.Push(X);
		X = A;
		A = [0x0AFDB5];
		X = Stack.Pop();
		P |= 0x20;
		A &= 0xFF;

		if (Z == 1)
			return this.A03A9B1();

		A = [0x11B5];

		if (Z == 0)
			return this.A03A9B1();

		A = [0x1186];
		temp = A - 0x01;

		if (Z == 0)
			return this.A03A9B4();

		A = [0x7E328E];

		if (N == 1)
			return this.A03A969();


		if (Z == 0)
			return this.A03A9B1();

	}

	public void A03A969()
	{
		A = 0x14;
		[0x7E328E] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.A03A986();

		X = [0x10FC];
		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;
		temp = A - 0x80;

		if (C == 0)
			return this.A03A986();

		A = 0xEC;
		[0x7E328E] = A;
	}

	public void A03A986()
	{
		P &= ~0x20;
		A = 0xEA1B;
		this.A029213();
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

	public void A03A9B1()
	{
		return this.A03AABA();
	}

	public void A03A9B4()
	{
		A = [0x1ABF];

		if (Z == 0)
			return this.A03A9B1();

		P &= ~0x20;
		A = [0x118A];
		temp = A - 0x0000;
		P |= 0x20;

		if (Z == 0)
			return this.A03A9C8();

		return this.A03AABA();
	}

	public void A03A9C8()
	{
		A = [0x1ABB];

		if (Z == 1)
			return this.A03A9DC();

		A = [0x1278];

		if (Z == 0)
			return this.A03A9DC();

		A = [0x127A];
		temp = A - 0x01;

		if (Z == 1)
			return this.A03A9DC();

		return this.A03AABA();
	}

	public void A03A9DC()
	{
		X = [0x10FC];
		P &= ~0x20;
		A = [0x1175];
		temp = A - [0x0E + X];

		if (Z == 1)
			return this.A03A9F5();

		C = 0;
		A += 0x0014 + C;
		temp = A - [0x0E + X];

		if (N == 1)
			return this.A03A9F5();

		P |= 0x20;
		return this.A03AABA();
	}

	public void A03A9F5()
	{
		P &= ~0x20;
		Stack.Push(X);
		A = [0x1186];
		A &= 0x00FF;
		X = 0xEA1A;
		temp = A - 0x0002;

		if (Z == 0)
			return this.A03AA09();

		X = 0xEA1B;
	}

	public void A03AA09()
	{
		A = X;
		this.A029213();
		X = Stack.Pop();
		P |= 0x20;
		A = 0x01;
		[0x11AB] = A;
		A = 0x0C;
		[0x11C9] = A;
		A = [0x1186];
		temp = A - 0x02;

		if (Z == 0)
			return this.A03AA2F();

		P &= ~0x20;
		A = 0xFFCE;
		[0x11A8] = A;
		P |= 0x20;
		return this.A03AABA();
	}

	public void A03AA2F()
	{
		A = 0x04;
		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.A03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
		return this.A03AABA();
	}

	public void A03AA43()
	{
		A = [0x1186];
		temp = A - 0x02;

		if (Z == 0)
			return this.A03AA4D();

		return this.A03AABA();
	}

	public void A03AA4D()
	{
		A = [0x127A];
		P &= ~0x20;
		A &= 0x00FF;
		Stack.Push(X);
		X = A;
		A = [0x0AFDB5];
		X = Stack.Pop();
		P |= 0x20;
		A &= 0xFF;

		if (Z == 1)
			return this.A03AA64();

		return this.A03AA67();
	}

	public void A03AA64()
	{
		return this.A03AABA();
	}

	public void A03AA67()
	{
		P &= ~0x20;
		A = [0x118A];
		temp = A - 0x0000;
		P |= 0x20;

		if (Z == 1)
			return this.A03AABA();

		A = [0x1ABF];

		if (Z == 0)
			return this.A03AABA();

		A = [0x1ABB];

		if (Z == 1)
			return this.A03AA87();

		A = [0x127A];
		temp = A - 0x01;

		if (Z == 1)
			return this.A03AA87();

		return this.A03AA43();
	}

	public void A03AA87()
	{
		X = [0x10FC];
		P &= ~0x20;
		A = [0x000E + X];
		temp = A - [0x1175];
		P |= 0x20;

		if (Z == 1)
			return this.A03AA99();

		return this.A03AABA();
	}

	public void A03AA99()
	{
		P &= ~0x20;
		A = 0xEA1A;
		this.A029213();
		P |= 0x20;
		A = 0xFF;
		[0x11AB] = A;
		A = 0x04;
		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.A03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
	}

	public void A03AABA()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 1)
			return this.A03AAC5();

		return this.A03AB6C();
	}

	public void A03AAC5()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.A03AAD0();

		return this.A03AB6C();
	}

	public void A03AAD0()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.A03AADB();

		return this.A03AB6C();
	}

	public void A03AADB()
	{
		A = [0x1186];
		temp = A - 0x01;

		if (Z == 0)
			return this.A03AB33();

		A = [0x7E328E];

		if (N == 1)
			return this.A03AB30();

		A = 0xEC;
		[0x7E328E] = A;
		A = [0x1ABF];

		if (Z == 1)
			return this.A03AB05();

		X = [0x10FC];
		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;
		temp = A - 0x80;

		if (C == 0)
			return this.A03AB05();

		A = 0x14;
		[0x7E328E] = A;
	}

	public void A03AB05()
	{
		P &= ~0x20;
		A = 0xEA1B;
		this.A029213();
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

	public void A03AB30()
	{
		return this.A03AB6C();
	}

	public void A03AB33()
	{
		P &= ~0x20;
		A = [0x1ABF];

		if (Z == 0)
			return this.A03AB44();

		X = [0x10FC];
		A = [0x0E + X];
		temp = A - [0x1175];

		if (Z == 0)
			return this.A03AB6C();

	}

	public void A03AB44()
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
		this.A029213();
		P |= 0x20;
	}

	public void A03AB6C()
	{
		P |= 0x20;
		A = [0x1186];
		temp = A - 0x00;

		if (Z == 0)
			return this.A03AB89();

		A = [0x1DFC];

		if (Z == 1)
			return this.A03AB89();

		[0x1186] = A;
		[0x1187] = A;
		Stack.Push(X);
		this.A03A3B4();
		X = Stack.Pop();
		P |= 0x20;
		P &= ~0x10;
	}

	public void A03AB89()
	{
		P &= ~0x20;
		A = [0x118A];

		if (Z == 0)
			return this.A03AB97();

		P |= 0x20;
		X = [0x116C];
		[0x28 + X] = 0;
	}

	public void A03AB97()
	{
		P |= 0x20;
		A = [0x10EF];
		temp = A & 0x08;

		if (Z == 0)
			return this.A03ABA3();

		return this.A03AC4F();
	}

	public void A03ABA3()
	{
		A = [0x10C0];
		A &= 0x10;

		if (Z == 1)
			return this.A03ABB1();

		this.A03A572();
		return this.A03AE3E();
	}

	public void A03ABB1()
	{
		A = [0x10C2];
		A &= 0x10;

		if (Z == 1)
			return this.A03ABC0();

		A = [0x10EF];
		A |= 0x0F;
		[0x10EF] = A;
	}

	public void A03ABC0()
	{
		Stack.Push(X);
		A = [0x10C0];
		A &= 0x40;

		if (Z == 1)
			return this.A03ABD6();

		A = [0x10BF];
		A &= 0x40;

		if (Z == 0)
			return this.A03ABD6();

		P |= 0x20;
		X = [0x116C];
		[0x28 + X] = 0;
	}

	public void A03ABD6()
	{
		A = [0x10EF];
		temp = A & 0x10;

		if (Z == 1)
			return this.A03AC11();

		A = [0x10C0];
		A &= 0x80;

		if (Z == 1)
			return this.A03AC11();

		A = [0x10BF];
		A &= 0x80;

		if (Z == 0)
			return this.A03AC11();

		A = [0x1285];

		if (Z == 0)
			return this.A03ABFE();

		this.A04B41C();
		A = 0xFF;
		[0x1215] = A;
		[0x122E] = A;
		return this.A03AC0D();
	}

	public void A03ABFE()
	{
		X = [0x1286];
		[0x28 + X] = 0;
		X = [0x128A];
		[0x28 + X] = 0;
		X = [0x1288];
		[0x28 + X] = 0;
	}

	public void A03AC0D()
	{
		P |= 0x20;
		P &= ~0x10;
	}

	public void A03AC11()
	{
		A = [0x10C2];
		A &= 0x40;

		if (Z == 1)
			return this.A03AC27();

		A = [0x10C1];
		A &= 0x40;

		if (Z == 0)
			return this.A03AC27();

		A = [0x10EE];
		A ^= 0xFF;
		[0x10EE] = A;
	}

	public void A03AC27()
	{
		A = [0x10C2];
		A &= 0x80;

		if (Z == 1)
			return this.A03AC4A();

		A = [0x10C1];
		A &= 0x80;

		if (Z == 0)
			return this.A03AC4A();

		A = [0x112D];
		A |= 0x08;
		[0x112D] = A;
		A = 0xFF;
		[0x1215] = A;
		[0x1217] = A;
		A = 0x1E;
		[0x1235] = A;
	}

	public void A03AC4A()
	{
		P |= 0x20;
		P &= ~0x10;
		X = Stack.Pop();
	}

	public void A03AC4F()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.A03AC5A();

		return this.A03AC8E();
	}

	public void A03AC5A()
	{
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.A03AC65();

		return this.A03AC74();
	}

	public void A03AC65()
	{
		A = [0x11BD];
		A--;

		if (N == 0)
			return this.A03AC6D();

		A = 0xFF;
	}

	public void A03AC6D()
	{
		[0x11BD] = A;
		return this.A03AC91();
	}

	public void A03AC74()
	{
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.A03AC7F();

		return this.A03AC8E();
	}

	public void A03AC7F()
	{
		A = [0x11BD];
		A++;

		if (Z == 1)
			return this.A03AC87();

		A = 0x01;
	}

	public void A03AC87()
	{
		[0x11BD] = A;
		return this.A03AC91();
	}

	public void A03AC8E()
	{
		[0x11BD] = 0;
	}

	public void A03AC91()
	{
		A = [0x118E];
		temp = A - 0x00;

		if (Z == 1)
			return this.A03ACB5();

		A = [0x10BC];
		A &= 0xEC;

		if (Z == 0)
			return this.A03ACA6();

		A = [0x10BE];
		A &= 0xC0;

		if (Z == 1)
			return this.A03ACB5();

	}

	public void A03ACA6()
	{
		A = [0x1ABF];

		if (Z == 0)
			return this.A03ACB5();

		A = [0x1216];

		if (Z == 0)
			return this.A03ACB5();

		A = 0x00;
		[0x118E] = A;
	}

	public void A03ACB5()
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
			return this.A03ACD5();

		A = [0x1AD2];

		if (Z == 1)
			return this.A03ACD8();

	}

	public void A03ACD5()
	{
		return this.A03AD43();
	}

	public void A03ACD8()
	{
		A = [0x1982];
		A &= 0x7F;

		if (Z == 0)
			return this.A03AD0D();

		X = [0x116C];
		A = [0x28 + X];

		if (Z == 1)
			return this.A03AD0D();

		temp = A - 0x0A;

		if (N == 0)
			return this.A03AD0D();

		A = [0x1DBA];

		if (Z == 1)
			return this.A03AD0D();

		P &= ~0x20;
		A = 0x3872;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x14;
		[0x11D4] = A;
		this.A03855E();
		P &= ~0x20;
		A = 0xEA0F;
		this.A029213();
		P |= 0x20;
	}

	public void A03AD0D()
	{
		P &= ~0x20;
		A = [0x118A];
		temp = A - 0x04B0;
		P |= 0x20;

		if (N == 0)
			return this.A03AD43();

		A = [0x1982];
		C = 0;
		A += 0x0A + C;
		A &= 0x7F;

		if (Z == 0)
			return this.A03AD43();

		P &= ~0x20;
		A = 0x38AC;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x14;
		[0x11D4] = A;
		this.A03855E();
		P &= ~0x20;
		A = 0xEA0F;
		this.A029213();
		P |= 0x20;
		return this.A03AD43();
	}

	public void A03AD43()
	{
		A = [0x1219];

		if (Z == 1)
			return this.A03AD62();

		A--;
		[0x1219] = A;
		temp = A - 0x14;

		if (Z == 0)
			return this.A03AD50();

	}

	public void A03AD50()
	{
		A = [0x1219];

		if (Z == 1)
			return this.A03AD58();

		return this.A03ADC0();
	}

	public void A03AD58()
	{
		A = [0x112D];
		A |= 0x08;
		[0x112D] = A;
		return this.A03ADC0();
	}

	public void A03AD62()
	{
		A = [0x112D];
		temp = A & 0x02;

		if (Z == 0)
			return this.A03AD6D();

		return this.A03ADC0();
	}

	public void A03AD6D()
	{
		P &= ~0x20;
		A = 0x0064;
		[0x3E] = A;
		A = [0x122A];
		A &= 0x00FF;

		if (Z == 1)
			return this.A03AD81();

		A = 0x0000;
		[0x3E] = A;
	}

	public void A03AD81()
	{
		P |= 0x20;
		P &= ~0x20;
		A = [0x3E];
		temp = A - [0x11B7];

		if (Z == 1)
			return this.A03ADBB();

		C = 1;
		A -= 0x11B7 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A03AD9F();

		temp = A - 0x0010;

		if (N == 0)
			return this.A03ADA7();

		A = 0x0010;
		return this.A03ADA7();
	}

	public void A03AD9F()
	{
		temp = A - 0xFFF0;

		if (N == 1)
			return this.A03ADA7();

		A = 0xFFF0;
	}

	public void A03ADA7()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11B7] + C;
	}

	public void A03ADBB()
	{
		[0x11B7] = A;
		P |= 0x20;
	}

	public void A03ADC0()
	{
		A = [0x7E328F];

		if (N == 1)
			return this.A03ADEB();


		if (Z == 0)
			return this.A03ADEB();

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
		this.A03855E();
		this.A04B41C();
	}

	public void A03ADEB()
	{
		A = [0x001217];

		if (Z == 1)
			return this.A03ADFB();

		A = [0x1219];

		if (Z == 0)
			return this.A03ADFB();

		A = 0x14;
		[0x1219] = A;
	}

	public void A03ADFB()
	{
		A = [0x112D];
		temp = A & 0x08;

		if (Z == 0)
			return this.A03AE3E();

		A = [0x1DBA];

		if (Z == 1)
			return this.A03AE3E();

		A = [0x1219];

		if (Z == 0)
			return this.A03AE3E();

		A = [0x00197E];

		if (Z == 0)
			return this.A03AE3E();

		A = [0x197D];

		if (N == 1)
			return this.A03AE19();

		return this.A03AE3E();
	}

	public void A03AE19()
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

	public void A03AE3E()
	{
		return;
	}

	public void A03B469()
	{
		Stack.Push(X);
		A = 0x01;
		[0x1190] = A;
		[0x3A] = X;
		this.A03A102();

		if (C == 0)
			return this.A03B479();

		return this.A03B482();
	}

	public void A03B479()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.A03B500();
	}

	public void A03B482()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xCD16;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.A03A054();
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
		this.A029213();
		P |= 0x20;
	}

	public void A03B500()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0x3AA7;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.A03855E();
		return;
	}

	public void A03B515()
	{
		Stack.Push(X);
		A = 0x02;
		[0x1190] = A;
		[0x3A] = X;
		this.A03A102();

		if (C == 0)
			return this.A03B525();

		return this.A03B52E();
	}

	public void A03B525()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.A03B5AC();
	}

	public void A03B52E()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xCD16;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.A03A054();
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
		this.A029213();
		P |= 0x20;
	}

	public void A03B5AC()
	{
		X = Stack.Pop();
		P &= ~0x20;
		A = 0x3AA7;
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D4] = A;
		this.A03855E();
		return;
	}

	public void A03E3B5()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.A03E3BF();

		return this.A03E492();
	}

	public void A03E3BF()
	{
		A = [0x1AD2];

		if (Z == 1)
			return this.A03E3C7();

		return this.A03E492();
	}

	public void A03E3C7()
	{
		P &= ~0x20;
		[0x1A08] = 0;
		[0x1A0A] = 0;
		[0x1A0C] = 0;
		A = [0x1AD3];
		A &= 0x00FF;

		if (Z == 0)
			return this.A03E40F();

		A = [0x1926];

		if (N == 1)
			return this.A03E3F1();

		A = 0x0000;
		[0xC5] = A;
		A = 0x0000;
		[0xC7] = A;
		A = 0xFE0C;
		[0xC9] = A;
		return this.A03E6D8();
	}

	public void A03E3F1()
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
		return this.A03E6D8();
	}

	public void A03E40F()
	{
		P |= 0x20;
		P &= ~0x20;
		A = 0xFCAE;
		temp = A - [0x11D2];

		if (Z == 1)
			return this.A03E44A();

		C = 1;
		A -= 0x11D2 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A03E42E();

		temp = A - 0x0010;

		if (N == 0)
			return this.A03E436();

		A = 0x0010;
		return this.A03E436();
	}

	public void A03E42E()
	{
		temp = A - 0xFFF0;

		if (N == 1)
			return this.A03E436();

		A = 0xFFF0;
	}

	public void A03E436()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11D2] + C;
	}

	public void A03E44A()
	{
		[0x11D2] = A;
		P |= 0x20;
		P &= ~0x20;
		A = 0xFFB0;
		temp = A - [0x11D0];

		if (Z == 1)
			return this.A03E488();

		C = 1;
		A -= 0x11D0 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A03E46C();

		temp = A - 0x0010;

		if (N == 0)
			return this.A03E474();

		A = 0x0010;
		return this.A03E474();
	}

	public void A03E46C()
	{
		temp = A - 0xFFF0;

		if (N == 1)
			return this.A03E474();

		A = 0xFFF0;
	}

	public void A03E474()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11D0] + C;
	}

	public void A03E488()
	{
		[0x11D0] = A;
		P |= 0x20;
		P &= ~0x20;
		return this.A03E3F1();
	}

	public void A03E492()
	{
		P &= ~0x20;
		A = [0x11CA];
		A <<= 1;
		A <<= 1;
		A = (A >> 4) | (A << 4);
		temp = A & 0x0080;

		if (Z == 1)
			return this.A03E4A4();

		A |= 0xFF00;
		return this.A03E4A7();
	}

	public void A03E4A4()
	{
		A &= 0x00FF;
	}

	public void A03E4A7()
	{
		A ^= 0xFFFF;
		A++;
		C = 0;
		A += 0x00FF + C;
		temp = A - 0x00EE;

		if (N == 0)
			return this.A03E4B7();

		A = 0x00EE;
	}

	public void A03E4B7()
	{
		temp = A - 0x01B8;

		if (N == 1)
			return this.A03E4BF();

		A = 0x01B8;
	}

	public void A03E4BF()
	{
		A = 0x0110;
		temp = A - [0x1B72];

		if (Z == 1)
			return this.A03E4D3();

		[0x1B72] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1B74] = A;
		P &= ~0x20;
	}

	public void A03E4D3()
	{
		[0x10E3] = 0;
		A = [0x112D];
		temp = A & 0x0002;

		if (Z == 1)
			return this.A03E4E4();

		[0x10E1] = 0;
		return this.A03E583();
	}

	public void A03E4E4()
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
		this.A039551();
		temp = Y - 0x0000;
		P |= 0x20;

		if (Z == 0)
			return this.A03E516();

		return this.A03E564();
	}

	public void A03E516()
	{
		P &= ~0x20;
		A = [0x1125];

		if (Z == 1)
			return this.A03E520();

		[0x10E3] = A;
	}

	public void A03E520()
	{
		P |= 0x20;
		temp = Y - [0x10FC];

		if (Z == 0)
			return this.A03E52B();

		return this.A03E564();
	}

	public void A03E52B()
	{
		X = Y;
		[0x10E1] = X;
		P &= ~0x20;
		A = [0x3A];
		[0x10E8] = A;
		P &= ~0x20;
		A = [0x1186];
		A &= 0x00FF;
		temp = A - 0x0001;

		if (Z == 1)
			return this.A03E569();

		A = [0x1ABF];

		if (Z == 0)
			return this.A03E569();

		P &= ~0x20;
		A = [0x0E + X];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0xFF4C;

		if (N == 0)
			return this.A03E55A();

		A = 0xFF4C;
		return this.A03E562();
	}

	public void A03E55A()
	{
		temp = A - 0x0000;

		if (N == 1)
			return this.A03E562();

		A = 0x0000;
	}

	public void A03E562()
	{
		return this.A03E56C();
	}

	public void A03E564()
	{
		P &= ~0x20;
		[0x10E1] = 0;
	}

	public void A03E569()
	{
		A = 0x0000;
	}

	public void A03E56C()
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

	public void A03E583()
	{
		A = [0x112D];
		A &= 0x0008;

		if (Z == 1)
			return this.A03E58E();

		return this.A03E680();
	}

	public void A03E58E()
	{
		A = [0x1219];
		A &= 0x00FF;

		if (Z == 1)
			return this.A03E599();

		return this.A03E611();
	}

	public void A03E599()
	{
		A = [0x11C2];

		if (Z == 0)
			return this.A03E5A1();

		return this.A03E611();
	}

	public void A03E5A1()
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
		temp = A - [0x11A4];

		if (Z == 1)
			return this.A03E5CB();

		C = 1;
		A -= 0x11A4 - !C;
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x11A4] + C;
		[0x11A4] = A;
	}

	public void A03E5CB()
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
			return this.A03E5E9();

		A--;
		[0x11C4] = A;
		return this.A03E680();
	}

	public void A03E5E9()
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
		return this.A03E6C4();
	}

	public void A03E611()
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
			return this.A03E635();

		A = [0x13 + X];
		C = 0;
		A += 0x40 + C;

		if (N == 0)
			return this.A03E635();

		A = [0x93];
		A <<= 1;
		[0x93] = A;
	}

	public void A03E635()
	{
		A = [0x112D];
		temp = A & 0x02;

		if (Z == 1)
			return this.A03E661();

		P &= ~0x20;
		A = [0x0E + X];
		C = 0;
		A += 0xFFD8 + C;
		[0x11D0] = A;
		P |= 0x20;
		A = [0x11BF];
		A++;
		temp = A - 0x05;

		if (N == 0)
			return this.A03E654();

		[0x11BF] = A;
	}

	public void A03E654()
	{
		A = [0x11BE];
		C = 0;
		A += [0x11BF] + C;
		[0x11BE] = A;
		X = [0x119E];
	}

	public void A03E661()
	{
		A = [0x13 + X];
		C = 0;
		A += [0x11BE] + C;
		this.A039A6B();
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

	public void A03E680()
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
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
	}

	public void A03E6C4()
	{
		temp = A - [0x1B75];

		if (Z == 1)
			return this.A03E6D5();

		[0x1B75] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1B77] = A;
		P &= ~0x20;
	}

	public void A03E6D5()
	{
		return this.A03E6D8();
	}

	public void A03E6D8()
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
		return this.A03E728();
	}

	public void A03E728()
	{
		A = [0x199F];

		if (Z == 0)
			return this.A03E730();

		return this.A03E7BF();
	}

	public void A03E730()
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
		this.A01F208();
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

	public void A03E7BF()
	{
		P &= ~0x20;
		A = [0x1A08];
		[0x1A02] = A;
		A = [0x1A0A];
		[0x1A04] = A;
		A = [0x1A0C];
		[0x1A06] = A;
		P |= 0x30;
		this.A01F208();
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

	public void A03E814()
	{
		this.A03E818();
		return;
	}

	public void A03E818()
	{
		A = [0xF7];
		C = 1;
		A -= 0xF8 - !C;
		[0xF8] = A;
		A -= 0xF9 - !C;
		[0xF9] = A;
		A -= 0xFA - !C;
		[0xFA] = A;
		A -= 0xF7 - !C;
		[0xF7] = A;
		return;
	}

	public void A03E880()
	{
		[0x6B] = 0;
		[0x6C] = 0;
		[0x6A] = 0;
		A = [0x68];

		if (N == 1)
			return this.A03E8AD();

		A <<= 1;
		[0x4202] = A;
		A = [0x67];

		if (N == 1)
			return this.A03E89E();

		A = [0x66];
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		A = [0x67];
		return this.A03E8E6();
	}

	public void A03E89E()
	{
		A = 0x00;
		C = 1;
		A -= 0x66 - !C;
		[0x4203] = A;
		A = 0x00;
		A -= 0x67 - !C;
		return this.A03E8C2();
	}

	public void A03E8AD()
	{
		A ^= 0xFF;
		A++;
		A <<= 1;
		[0x4202] = A;
		A = [0x67];

		if (N == 1)
			return this.A03E8D8();

		A = [0x66];
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		Cpu.NOP();
		A = [0x67];
	}

	public void A03E8C2()
	{
		Y = [0x4217];
		[0x4203] = A;
		[0x69] = Y;
		P &= ~0x20;
		A = [0x6B];
		C = 1;
		A -= 0x4216 - !C;
		C = 1;
		A -= 0x69 - !C;
		return this.A03E8F8();
	}

	public void A03E8D8()
	{
		A = 0x00;
		C = 1;
		A -= 0x66 - !C;
		[0x4203] = A;
		Cpu.NOP();
		Cpu.NOP();
		A = 0x00;
		A -= 0x67 - !C;
	}

	public void A03E8E6()
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

	public void A03E8F8()
	{
		[0x69] = A;
		P |= 0x20;
		return;
	}

	public void A03E8FD()
	{
		this.A03E903();
		P &= ~0x20;
		return;
	}

	public void A03E903()
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
		this.A7ED7E8();
		P &= ~0x20;
		A = [0x700040];
		P = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A03EA26()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x0000;
		[0x700064] = A;
		A = 0x0001;
		[0x700230] = A;
		return this.A03EA85();
	}

	public void A03EA39()
	{
		Stack.Push(P);
		P &= ~0x20;
		return this.A03EA4F();
	}

	public void A03EA3E()
	{
		Stack.Push(P);
		P &= ~0x20;
		A = 0x0000;
		[0x700064] = A;
		A = 0x0001;
		[0x700230] = A;
	}

	public void A03EA4F()
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
			return this.A03EA72();

	}

	public void A03EA66()
	{
		Y++;
		A = [0x7FFF + Y];

		if (Z == 0)
			return this.A03EA66();

		A = [0x8000 + Y];

		if (Z == 0)
			return this.A03EA72();

		Y = X;
	}

	public void A03EA72()
	{
		X = 0x0000;
	}

	public void A03EA75()
	{
		A = [0x8000 + Y];
		[0x702090 + X] = A;

		if (Z == 1)
			return this.A03EA82();

		X++;
		Y++;
		return this.A03EA75();
	}

	public void A03EA82()
	{
		P |= 0x20;
		B = Stack.Pop();
	}

	public void A03EA85()
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
			return this.A03EAA5();

		A = [0x700064];
		A++;
		[0x700064] = A;
	}

	public void A03EAA5()
	{
		A = [0x70002C];
		A++;
		[0x70002C] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF9E;
		this.A7ED7E8();
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
		this.A7ED7E8();
		P &= ~0x20;
		A = 0x0000;
		[0x700230] = A;
		P = Stack.Pop();
		return;
	}

	public void A03EAE4()
	{
		Stack.Push(P);
		P |= 0x20;
		P &= ~0x10;
		A = [0x1982];
		A &= 0x04;

		if (Z == 1)
			return this.A03EB2E();

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
		this.A7ED7E8();
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
		this.A7ED7E8();
	}

	public void A03EB2E()
	{
		P = Stack.Pop();
		return;
	}

	public void A03EB30()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
		P = Stack.Pop();
		return;
	}

	public void A03EB92()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
		P = Stack.Pop();
		return;
	}

	public void A03EC1A()
	{
		P &= ~0x30;
		X = [0x18BC];

		if (Z == 0)
			return this.A03EC22();

		return;
	}

	public void A03EC22()
	{
		A = [0x18C3];

		if (Z == 1)
			return this.A03EC31();

		this.A03EDDF();
		A = [0x18C3];

		if (Z == 1)
			return this.A03EC31();

		return;
	}

	public void A03EC31()
	{
		P &= ~0x20;
		X = [0x18BC];
		A = [0x03EBF4];
		A &= 0x00FF;
		Y = X;
		X = A;
		return [(0xEC4B + X)]();
		X = [0x18BC];
		X++;
		X++;
		[0x18BC] = X;
		return;
	}

	public void A03EDC2()
	{
		X = 0x0000;
	}

	public void A03EDC5()
	{
		A = [0x00149C];
		[0x00169C + X] = A;
		X++;
		X++;
		temp = X - 0x0200;

		if (Z == 0)
			return this.A03EDC5();

		[0x18C3] = 0;
		P |= 0x20;
		A = 0x01;
		[0x18C1] = A;
		return;
	}

	public void A03EDDF()
	{
		P &= ~0x20;
		A = [0x18C9];
		temp = A - 0x000F;

		if (Z == 0)
			return this.A03EDEC();

		return this.A03EDC2();
	}

	public void A03EDEC()
	{
		X = 0x0000;
		Y = 0x0000;
	}

	public void A03EDF2()
	{
		A = [0x00169C];
		[0x18C7] = A;
		A &= 0x001F;
		[0x18C5] = A;
		A = [0x00149C];
		A &= 0x001F;
		C = 1;
		A -= 0x18C5 - !C;

		if (Z == 1)
			return this.A03EE3B();


		if (N == 1)
			return this.A03EE1F();

		temp = A - [0x18C9];

		if (N == 1)
			return this.A03EE16();

		A = [0x18C9];
	}

	public void A03EE16()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.A03EE2E();
	}

	public void A03EE1F()
	{
		temp = A - [0x18CF];

		if (N == 0)
			return this.A03EE27();

		A = [0x18CF];
	}

	public void A03EE27()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void A03EE2E()
	{
		Y++;
		A = [0x18C7];
		A &= 0x7FE0;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void A03EE3B()
	{
		A = [0x00169C];
		A &= 0x03E0;
		[0x18C5] = A;
		A = [0x00149C];
		A &= 0x03E0;
		C = 1;
		A -= 0x18C5 - !C;

		if (Z == 1)
			return this.A03EE81();


		if (N == 1)
			return this.A03EE65();

		temp = A - [0x18CB];

		if (N == 1)
			return this.A03EE5C();

		A = [0x18CB];
	}

	public void A03EE5C()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.A03EE74();
	}

	public void A03EE65()
	{
		temp = A - [0x18D1];

		if (N == 0)
			return this.A03EE6D();

		A = [0x18D1];
	}

	public void A03EE6D()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void A03EE74()
	{
		Y++;
		A = [0x18C7];
		A &= 0x7C1F;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void A03EE81()
	{
		A = [0x00169C];
		A &= 0x7C00;
		[0x18C5] = A;
		A = [0x00149C];
		A &= 0x7C00;
		C = 1;
		A -= 0x18C5 - !C;

		if (Z == 1)
			return this.A03EEC7();


		if (N == 1)
			return this.A03EEAB();

		temp = A - [0x18CD];

		if (N == 1)
			return this.A03EEA2();

		A = [0x18CD];
	}

	public void A03EEA2()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
		return this.A03EEBA();
	}

	public void A03EEAB()
	{
		temp = A - [0x18D3];

		if (N == 0)
			return this.A03EEB3();

		A = [0x18D3];
	}

	public void A03EEB3()
	{
		C = 0;
		A += [0x18C5] + C;
		[0x18C5] = A;
	}

	public void A03EEBA()
	{
		Y++;
		A = [0x18C7];
		A &= 0x03FF;
		A |= [0x18C5];
		[0x18C7] = A;
	}

	public void A03EEC7()
	{
		A = [0x18C7];
		[0x00169C + X] = A;
		X++;
		X++;
		temp = X - 0x0200;

		if (Z == 1)
			return this.A03EED8();

		return this.A03EDF2();
	}

	public void A03EED8()
	{
		temp = Y - 0x0000;

		if (Z == 1)
			return this.A03EEE6();

		P |= 0x20;
		A = 0x01;
		[0x18C1] = A;
		return this.A03EEEB();
	}

	public void A03EEE6()
	{
		P &= ~0x20;
		[0x18C3] = 0;
	}

	public void A03EEEB()
	{
		return;
	}

	public void A03EF53()
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

	public void A03EF8C()
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

	public void A03EFCF()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A03E814();
		P &= ~0x30;
		A &= 0x000F;

		if (Z == 0)
			return this.A03EFE4();

		A = 0x0008;
		return this.A03F008();
	}

	public void A03EFE4()
	{
		A = 0x0000;
		return this.A03F008();
	}

	public void A03EFEA()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A03E814();
		P &= ~0x30;
		A &= 0x00FF;
		A <<= 1;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		A <<= 1;
		A = (A >> 4) | (A << 4);
		A &= 0x00FF;
		X = A;
		A = [0x03EFC3];
	}

	public void A03F008()
	{
		A &= 0x00FF;
		C = 0;
		A += 0x0080 + C;
		[0x3A] = A;
		A = [0x198F];
		A &= 0x00FF;

		if (Z == 1)
			return this.A03F026();

		A = [0x1990];
		X = A;
		A = [0x0BF8A8];
		C = 0;
		A += [0x3A] + C;
		[0x3A] = A;
	}

	public void A03F026()
	{
		X = 0x011C;
	}

	public void A03F029()
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
		temp = X - 0x012C;

		if (Z == 0)
			return this.A03F029();

		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A04B41C()
	{
		Stack.Push(X);
		[0x3A] = X;
		this.A03A102();

		if (C == 0)
			return this.A04B427();

		return this.A04B42F();
	}

	public void A04B427()
	{
		Y = 0xA600;
		A--;
		return this.A04B4A3();
	}

	public void A04B42F()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xDD90;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.A03A054();
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
		this.A039A6B();
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

	public void A04B4A3()
	{
		X = Stack.Pop();
		A = 0xFF;
		[0x00197E] = A;
		return;
	}

	public void A04B592()
	{
		this.A02CC8F();
		P &= ~0x20;
		A = 0x000C;
		this.A029283();
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.A029634();
		this.A0380F7();
		this.A038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		[0x1AD3] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x0013;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.A03A17D();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF8C();
		P |= 0x20;
		A = 0xFF;
		[0x1216] = A;
		[0x1ACB] = 0;
		this.A02C897();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A04B62E()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A02C897();
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
		A = [0x0BF83C];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A04B6A7();

		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A04B681();

		[0x1992] = A;
		return this.A04B6AD();
	}

	public void A04B681()
	{
		X = [0x1988];
		A = [0x0BF83E];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0004 + C;
		temp = A - 0x0008;

		if (Z == 0)
			return this.A04B69C();

		A = 0x0000;
		return this.A04B6C1();
	}

	public void A04B69C()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.A04B6AD();
	}

	public void A04B6A7()
	{
		this.A03EFEA();
		return this.A04B6B1();
	}

	public void A04B6AD()
	{
		this.A03EFCF();
	}

	public void A04B6B1()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A04B6BF();

		return this.A04B62E();
	}

	public void A04B6BF()
	{
		A = 0xFF;
	}

	public void A04B6C1()
	{
		P |= 0x20;
		[0x1AD3] = 0;
		[0x1AD1] = 0;
		[0x1ACF] = 0;
		this.A02C494();
		this.A04B73F();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		P |= 0x20;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		this.A02C494();
		this.A038168();
		P |= 0x20;
		A = 0xFF;
		return;
	}

	public void A04B73F()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		P &= ~0x20;
		A = 0x0015;
		this.A029283();
		this.A029634();
		P |= 0x20;
		A = 0x16;
		[0xF3] = A;
		P &= ~0x20;
		A = 0x0000;
		[0x126B] = A;
		A = 0x0000;
		[0x126D] = A;
		this.A02984E();
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
		this.A0394BE();
		X = Y;
		this.A038D6F();
		this.A038168();
		this.A0387D7();
		P |= 0x20;
		P &= ~0x10;
		[0x1DBA] = 0;
		A = 0xFF;
		[0x1216] = A;
		[0x1ACB] = 0;
		this.A02C897();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A04B7BA()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x11B5] = A;
		[0x118E] = 0;
		[0x118F] = 0;
		this.A02C897();
		P &= ~0x20;
		A = 0x00FA;
		[0x1175] = A;
		P |= 0x20;
		P &= ~0x10;
		X = [0x10FC];
		P &= ~0x20;
		A = 0x0082;
		temp = A - [0x0E + X];

		if (Z == 1)
			return this.A04B80E();

		C = 1;
		A -= [0x0E + X] - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A04B7F7();

		temp = A - 0x0008;

		if (N == 0)
			return this.A04B7FF();

		A = 0x0008;
		return this.A04B7FF();
	}

	public void A04B7F7()
	{
		temp = A - 0xFFF8;

		if (N == 1)
			return this.A04B7FF();

		A = 0xFFF8;
	}

	public void A04B7FF()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x0E + X] + C;
	}

	public void A04B80E()
	{
		[0x0E + X] = A;
		P |= 0x20;
		P &= ~0x20;
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A04B81F();

		[0x1992] = A;
		return this.A04B84A();
	}

	public void A04B81F()
	{
		A = 0x008C;
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0002 + C;
		temp = A - 0x0026;

		if (Z == 0)
			return this.A04B834();

		return this.A04B8B0();
	}

	public void A04B834()
	{
		[0x1990] = A;
		this.A089160();
		P |= 0x20;
		A = [0x1186];
		temp = A - 0x01;

		if (Z == 1)
			return this.A04B84A();

		A = 0x01;
		this.A03A47D();
	}

	public void A04B84A()
	{
		P |= 0x20;
		P &= ~0x20;
		A = [0x10F6];
		temp = A - 0x0000;

		if (N == 1)
			return this.A04B860();

		temp = A - 0x0800;

		if (N == 1)
			return this.A04B868();

		A = 0x0800;
		return this.A04B868();
	}

	public void A04B860()
	{
		temp = A - 0xF800;

		if (N == 0)
			return this.A04B868();

		A = 0xF800;
	}

	public void A04B868()
	{
		[0x10F6] = A;
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x0F;

		if (Z == 1)
			return this.A04B877();

		return this.A04B8AD();
	}

	public void A04B877()
	{
		P &= ~0x20;
		A = 0x0000;
		temp = A - [0x10F6];

		if (Z == 1)
			return this.A04B8A8();

		C = 1;
		A -= 0x10F6 - !C;
		temp = A - 0x0000;

		if (N == 1)
			return this.A04B894();

		temp = A - 0x0004;

		if (N == 0)
			return this.A04B89C();

		A = 0x0004;
		return this.A04B89C();
	}

	public void A04B894()
	{
		temp = A - 0xFFFC;

		if (N == 1)
			return this.A04B89C();

		A = 0xFFFC;
	}

	public void A04B89C()
	{
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		C = 0;
		A += [0x10F6] + C;
	}

	public void A04B8A8()
	{
		[0x10F6] = A;
		P |= 0x20;
	}

	public void A04B8AD()
	{
		return this.A04B7BA();
	}

	public void A04B8B0()
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

	public void A04B914()
	{
		Stack.Push(X);
		Stack.Push(Y);
		this.A04BAA2();
		this.A00E8D5();
		this.A00E8F0();
		this.A00EA5B();
		this.A00EA70();
		P |= 0x20;
		P &= ~0x10;
		Y = Stack.Pop();
		X = Stack.Pop();
		return;
	}

	public void A04B93D()
	{
		this.A04BAA2();
		this.A04BA06();
		P |= 0x20;
		P &= ~0x10;
		[0x127F] = 0;
		this.A00E996();
		this.A00EAD5();
		P |= 0x20;
		P &= ~0x10;
		return;
	}

	public void A04BA06()
	{
		P |= 0x20;
		P &= ~0x10;
		Y = 0x3000;
		X = 0x0000;
	}

	public void A04BA10()
	{
		A = [0x7E363E];
		[0x7E963E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A04BA10();

		Y = 0x3000;
		X = 0x0000;
	}

	public void A04BA22()
	{
		A = [0x7E663E];
		[0x7E363E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A04BA22();

		Y = 0x3000;
		X = 0x0000;
	}

	public void A04BA34()
	{
		A = [0x7E963E];
		[0x7E663E + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A04BA34();

		return;
	}

	public void A04BA41()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.A04BA60();

	}

	public void A04BA48()
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
			return this.A04BA60();

		return this.A04BA48();
	}

	public void A04BA60()
	{
		return;
	}

	public void A04BA61()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.A04BA9D();

	}

	public void A04BA68()
	{
		A = X;
		temp = A - [0x10FC];

		if (Z == 1)
			return this.A04BA95();

		temp = A - [0x11A0];

		if (Z == 1)
			return this.A04BA95();

		temp = A - [0x11A2];

		if (Z == 1)
			return this.A04BA95();

		temp = A - [0x119E];

		if (Z == 1)
			return this.A04BA95();

		temp = A - [0x116C];

		if (Z == 1)
			return this.A04BA95();

		temp = A - [0x11BB];

		if (Z == 1)
			return this.A04BA95();

		Y = [0x00 + X];
		P |= 0x20;
		A = 0x00;
		[0x7E1CDE + X] = A;
		P &= ~0x20;
		return this.A04BA97();
	}

	public void A04BA95()
	{
		Y = [0x00 + X];
	}

	public void A04BA97()
	{
		X = Y;

		if (Z == 1)
			return this.A04BA9D();

		return this.A04BA68();
	}

	public void A04BA9D()
	{
		this.A00E0BA();
		return;
	}

	public void A04BAA2()
	{
		P &= ~0x30;
		X = [0x10DB];

		if (Z == 1)
			return this.A04BAE3();

	}

	public void A04BAA9()
	{
		A = X;
		temp = A - [0x10FC];

		if (Z == 1)
			return this.A04BADB();

		temp = A - [0x11A0];

		if (Z == 1)
			return this.A04BADB();

		temp = A - [0x11A2];

		if (Z == 1)
			return this.A04BADB();

		temp = A - [0x119E];

		if (Z == 1)
			return this.A04BADB();

		temp = A - [0x116C];

		if (Z == 1)
			return this.A04BADB();

		temp = A - [0x11BB];

		if (Z == 1)
			return this.A04BADB();

		A = [0x04 + X];
		temp = A - 0xCD16;

		if (Z == 1)
			return this.A04BADB();

		Y = [0x00 + X];
		Stack.Push(Y);
		this.A038DC1();
		Y = Stack.Pop();
		P &= ~0x20;
		return this.A04BADD();
	}

	public void A04BADB()
	{
		Y = [0x00 + X];
	}

	public void A04BADD()
	{
		X = Y;

		if (Z == 1)
			return this.A04BAE3();

		return this.A04BAA9();
	}

	public void A04BAE3()
	{
		this.A00E0BA();
		return;
	}

	public void A078001()
	{
		P &= ~0x30;
		A = 0xFFF0;
		P |= 0x20;
		[0x210F] = A;
		A = (A >> 4) | (A << 4);
		[0x210F] = A;
		return;
	}

	public void A078010()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10ED];

		if (Z == 1)
			return this.A07802D();

		X = 0x0000;
		Y = 0x1000;
	}

	public void A07801F()
	{
		A = [0x7E563E];
		[0x701010 + X] = A;
		X++;
		Y--;

		if (Z == 0)
			return this.A07801F();

		return this.A07805D();
	}

	public void A07802D()
	{
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		A <<= 1;
		X = A;
		A = [0x048030];
		X = A;
		A = [0x02F4F2];
		[0x700064] = A;
		A = 0x1000;
		[0x70002C] = A;
		P |= 0x20;
		A = [0x02F4F4];
		[0x700066] = A;
		A = 0x01;
		X = 0xBDB1;
		this.A7ED7E8();
	}

	public void A07805D()
	{
		P |= 0x20;
		A = [0x10ED];

		if (Z == 0)
			return this.A078072();

		P |= 0x20;
		A = 0x01;
		X = 0xCD65;
		this.A7ED7E8();
		return this.A07814B();
	}

	public void A078072()
	{
		P &= ~0x20;
		A = [0x1982];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		A &= 0x0001;
		[0x700044] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCC4A;
		this.A7ED7E8();
		P &= ~0x30;
		A = [0x1285];

		if (Z == 1)
			return this.A07809B();

		return this.A07814B();
	}

	public void A07809B()
	{
		X = [0x10FC];
		A = [0x0C + X];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x700064] = A;
		A = [0x10 + X];
		A ^= 0xFFFF;
		A++;
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x70002C] = A;
		P |= 0x20;
		X = [0x10FC];
		A = [0x13 + X];
		P &= ~0x20;
		A &= 0x00FF;
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		[0x3A] = A;
		A <<= 1;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		X = A;
		P |= 0x20;
		A = [0x0887D9];
		[0x701000] = A;
		A = [0x0887DA];
		[0x701001] = A;
		A = [0x0887DB];
		[0x701002] = A;
		A = [0x0887DC];
		[0x701003] = A;
		A = [0x0887DD];
		[0x701004] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCE17;
		this.A7ED7E8();
	}

	public void A07814B()
	{
		return;
	}

	public void A07814C()
	{
		P |= 0x20;
		A = [0x1ACF];

		if (Z == 0)
			return this.A0781CE();

		A = [0x1DBA];

		if (Z == 1)
			return this.A0781CE();

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
		this.A0781CF();
		A = [0x11E3];
		C = 1;
		A -= 0x0008 - !C;
		[0x700064] = A;
		A = [0x11E5];
		C = 1;
		A -= 0x0010 - !C;
		[0x70002C] = A;
		A = 0x0001;
		this.A0781CF();
		A = [0x11E7];
		C = 1;
		A -= 0x0008 - !C;
		[0x700064] = A;
		A = [0x11E9];
		C = 1;
		A -= 0x000A - !C;
		[0x70002C] = A;
		A = 0x0002;
		this.A0781CF();
		A = [0x11EB];
		C = 1;
		A -= 0x0010 - !C;
		[0x700064] = A;
		A = [0x11ED];
		C = 1;
		A -= 0x000A - !C;
		[0x70002C] = A;
		A = 0x0003;
		this.A0781CF();
	}

	public void A0781CE()
	{
		return;
	}

	public void A0781CF()
	{
		P &= ~0x20;
		X = [0x11EF];

		if (Z == 0)
			return this.A0781DA();

		C = 0;
		A += 0x0004 + C;
	}

	public void A0781DA()
	{
		[0x3A] = A;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		X = A;
		A = 0x000F;
		[0x700040] = A;
		P |= 0x20;
		A = [0x088799];
		[0x701000] = A;
		A = [0x08879A];
		[0x701001] = A;
		A = [0x08879B];
		[0x701002] = A;
		A = [0x08879C];
		[0x701003] = A;
		A = [0x08879D];
		[0x701004] = A;
		A = [0x08879E];
		[0x701005] = A;
		A = [0x08879F];
		[0x701006] = A;
		A = [0x0887A0];
		[0x701007] = A;
		P |= 0x20;
		A = 0x01;
		X = 0xCDD9;
		this.A7ED7E8();
		P &= ~0x20;
		return;
	}

	public void A078237()
	{
		Stack.Push(P);
		P &= ~0x30;
		P |= 0x20;
		A = [0x001DD0];

		if (Z == 0)
			return this.A078244();

		P = Stack.Pop();
		return;
	}

	public void A078244()
	{
		X = 0x0000;
	}

	public void A078247()
	{
		A = [0x001DD0];
		Stack.Push(A);
		Stack.Push(X);
		X = A;
		A = [0x039D13];
		X = Stack.Pop();
		[0x701010 + X] = A;
		A = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.A07825F();

		X++;
		return this.A078247();
	}

	public void A07825F()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
		P = Stack.Pop();
		return;
	}

	public void A0782A9()
	{
		P &= ~0x30;
		X = 0x0FFE;
		[0x1DFD] = X;
		[0x1E00] = 0;
		X = [0x10DB];

		if (Z == 0)
			return this.A0782BC();

		return this.A0783F5();
	}

	public void A0782BC()
	{
		A = X;
		temp = A - [0x10FC];

		if (Z == 0)
			return this.A0782C5();

		return this.A0783ED();
	}

	public void A0782C5()
	{
		temp = A - [0x11A2];

		if (Z == 0)
			return this.A0782CD();

		return this.A0783ED();
	}

	public void A0782CD()
	{
		temp = A - [0x11A0];

		if (Z == 0)
			return this.A0782D5();

		return this.A0783ED();
	}

	public void A0782D5()
	{
		temp = A - [0x116C];

		if (Z == 0)
			return this.A0782DD();

		return this.A0783ED();
	}

	public void A0782DD()
	{
		A = [0x04 + X];
		temp = A - 0xBE6B;

		if (Z == 0)
			return this.A0782E7();

		return this.A0783ED();
	}

	public void A0782E7()
	{
		P |= 0x20;
		A = [0x001E + X];
		P &= ~0x20;
		A &= 0x0020;

		if (Z == 1)
			return this.A0782F6();

		return this.A0783ED();
	}

	public void A0782F6()
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
		this.A039A6B();
		P &= ~0x20;
		A = [0x02];
		[0x00] = A;
		A = [0x1997];
		[0x93] = A;
		X = Stack.Pop();
		A = [0x00];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x000F;

		if (N == 1)
			return this.A078348();

		return this.A0783ED();
	}

	public void A078348()
	{
		temp = A - 0xFFF1;

		if (N == 0)
			return this.A078350();

		return this.A0783ED();
	}

	public void A078350()
	{
		C = 0;
		A += 0x0013 + C;
		[0x00] = A;
		A = [0x93];
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x8000;
		Cpu.ROR();
		temp = A - 0x000C;

		if (N == 0)
			return this.A0783ED();

		temp = A - 0xFFF4;

		if (N == 1)
			return this.A0783ED();

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
		temp = X - [0x1286];

		if (Z == 1)
			return this.A0783A3();

		A = [0x001E + X];
		A &= 0x08;

		if (Z == 0)
			return this.A0783A3();

		return this.A0783AC();
	}

	public void A0783A3()
	{
		A = 0x0F;
		[0x1DCA] = A;
		A = 0x02;
		[0x3A] = A;
	}

	public void A0783AC()
	{
		A = [0x001E + X];
		A &= 0x04;

		if (Z == 0)
			return this.A0783B7();

		return this.A0783C0();
	}

	public void A0783B7()
	{
		A = 0x03;
		[0x1DCA] = A;
		A = 0x01;
		[0x3A] = A;
	}

	public void A0783C0()
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

	public void A0783ED()
	{
		A = [0x00 + X];
		X = A;

		if (Z == 1)
			return this.A0783F5();

		return this.A0782BC();
	}

	public void A0783F5()
	{
		A = [0x1E00];
		[0x7001C0] = A;
		return;
	}

	public void A078486()
	{
		P |= 0x20;
		[0x420C] = 0;
		this.A02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.A078EA5();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC50();
		P |= 0x20;
		[0x420C] = 0;
		this.A02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		P &= ~0x20;
		A = 0x000D;
		this.A029283();
		this.A078DDE();
		P |= 0x20;
		[0x420C] = 0;
		this.A02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.A078C2E();
		A = [0x10C4];
		[0x420C] = A;
		this.A02CCC9();
		X = 0x000C;
		this.A02C062();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC50();
		return;
	}

	public void A0784F5()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		A = 0x0004;
		this.A029283();
		return;
	}

	public void A078506()
	{
		P |= 0x20;
		[0x420C] = 0;
		this.A02BE25();
		P |= 0x20;
		A = 0x80;
		[0x2100] = A;
		this.A02D337();
		this.A078CE0();
		this.A09FB88();
		A = [0x10C4];
		[0x420C] = A;
		this.A0785B5();
		return;
	}

	public void A07852B()
	{
		this.A078506();
	}

	public void A07852E()
	{
		P &= ~0x20;
		[0x10B6] = 0;
		A = 0x00C8;
		[0x7E2DD6] = A;
	}

	public void A07853A()
	{
		P |= 0x20;
		[0x10B8] = 0;
		this.A07890F();
		this.A0785DD();
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 1)
			return this.A078589();

		temp = A - 0x0001;

		if (Z == 0)
			return this.A078572();

		A = [0x10CB];
		Stack.Push(A);
		this.A0786AB();
		P &= ~0x20;
		A = Stack.Pop();
		temp = A - [0x10CB];

		if (Z == 1)
			return this.A078570();

		P |= 0x20;
		A = 0x01;
		[0x110A] = A;
		P &= ~0x20;
		A = 0x0002;
		[0x7E2DD6] = A;
	}

	public void A078570()
	{
		return this.A07853A();
	}

	public void A078572()
	{
		temp = A - 0x0002;

		if (Z == 0)
			return this.A07857D();

		this.A078F46();
		return this.A07852E();
	}

	public void A07857D()
	{
		temp = A - 0x0003;

		if (Z == 0)
			return this.A07852E();

		this.A079164();
		return this.A07852B();
	}

	public void A078589()
	{
		A = [0x1982];
		[0xF7] = A;
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		this.A038168();
		this.A038000();
		this.A0387A6();
		P &= ~0x20;
		this.A0292AD();
		A = 0x0005;
		this.A029283();
		return;
	}

	public void A0785B5()
	{
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A0785BE()
	{
		this.A07891C();
		P |= 0x20;
		A = [0x1ACB];

		if (Z == 0)
			return this.A0785BE();

		return;
	}

	public void A0785DD()
	{
		X = 0x012C;
	}

	public void A0785E0()
	{
		P &= ~0x20;
		A = [0x7E2DD6];
		A--;
		[0x7E2DD6] = A;

		if (Z == 0)
			return this.A07861B();

		A = 0x00C8;
		[0x7E2DD6] = A;
		P |= 0x20;
		A = [0x110A];
		temp = A - 0x00;

		if (Z == 1)
			return this.A078603();

		this.A0CF550();
		return this.A078609();
	}

	public void A078603()
	{
		this.A02BE46();
		return this.A078609();
	}

	public void A078609()
	{
		P |= 0x20;
		A = [0x110A];
		A++;
		temp = A - 0x02;

		if (Z == 0)
			return this.A078615();

		A = 0x00;
	}

	public void A078615()
	{
		[0x110A] = A;
		this.A078506();
	}

	public void A07861B()
	{
		Stack.Push(X);
		this.A07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.A07862C();

		return this.A078657();
	}

	public void A07862C()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.A078637();

		return this.A078657();
	}

	public void A078637()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0x00C8;
		[0x7E2DD6] = A;
		A = [0x10B6];
		A--;

		if (N == 0)
			return this.A078654();

		A = 0x0003;
	}

	public void A078654()
	{
		[0x10B6] = A;
	}

	public void A078657()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.A078664();

		return this.A078692();
	}

	public void A078664()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.A07866F();

		return this.A078692();
	}

	public void A07866F()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = 0x00C8;
		[0x7E2DD6] = A;
		A = [0x10B6];
		A++;
		temp = A - 0x0004;

		if (Z == 0)
			return this.A07868F();

		A = 0x0000;
	}

	public void A07868F()
	{
		[0x10B6] = A;
	}

	public void A078692()
	{
		X = Stack.Pop();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A07869F();

		return this.A0785E0();
	}

	public void A07869F()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		return;
	}

	public void A0786AB()
	{
		P |= 0x20;
		A = 0x01;
		[0x10B8] = A;
		P &= ~0x20;
		[0x10B6] = 0;
		this.A07890F();
		P &= ~0x20;
		[0x10AC] = 0;
		A = 0x0000;
		[0x7E2DD6] = A;
		P |= 0x20;
		X = 0x012C;
	}

	public void A0786CB()
	{
		this.A07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.A0786DB();

		return this.A07870B();
	}

	public void A0786DB()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.A0786E6();

		return this.A07870B();
	}

	public void A0786E6()
	{
		A = [0x10B6];
		temp = A - 0x04;

		if (Z == 1)
			return this.A0786F8();

		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
	}

	public void A0786F8()
	{
		P &= ~0x20;
		A = [0x10B6];
		A--;

		if (N == 0)
			return this.A078703();

		A = 0x0004;
	}

	public void A078703()
	{
		[0x10B6] = A;
		P |= 0x20;
		return this.A0786CB();
	}

	public void A07870B()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.A078718();

		return this.A07874B();
	}

	public void A078718()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.A078723();

		return this.A07874B();
	}

	public void A078723()
	{
		A = [0x10B6];
		temp = A - 0x04;

		if (Z == 1)
			return this.A078735();

		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
	}

	public void A078735()
	{
		P &= ~0x20;
		A = [0x10B6];
		A++;
		temp = A - 0x0005;

		if (Z == 0)
			return this.A078743();

		A = 0x0000;
	}

	public void A078743()
	{
		[0x10B6] = A;
		P |= 0x20;
		return this.A0786CB();
	}

	public void A07874B()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.A078758();

		return this.A0787C2();
	}

	public void A078758()
	{
		A = [0x1188];
		A &= 0x02;

		if (Z == 1)
			return this.A078763();

		return this.A0787C2();
	}

	public void A078763()
	{
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 0)
			return this.A078775();

		A = [0x10CB];
		A ^= 0x0001;
		[0x10CB] = A;
		return this.A0787B2();
	}

	public void A078775()
	{
		temp = A - 0x0001;

		if (Z == 0)
			return this.A078788();

		A = [0x10B4];
		A--;

		if (N == 0)
			return this.A078783();

		A = 0x0002;
	}

	public void A078783()
	{
		[0x10B4] = A;
		return this.A0787B2();
	}

	public void A078788()
	{
		temp = A - 0x0003;

		if (Z == 0)
			return this.A07879C();

		A = [0x10B2];
		A ^= 0x0001;
		[0x10B2] = A;
		this.A02915C();
		return this.A0787B2();
	}

	public void A07879C()
	{
		temp = A - 0x0002;

		if (Z == 0)
			return this.A0787AC();

		A = [0x10E5];
		A ^= 0x0001;
		[0x10E5] = A;
		return this.A0787B2();
	}

	public void A0787AC()
	{
		this.A0788C6();
		return this.A078854();
	}

	public void A0787B2()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P |= 0x20;
		return this.A0786CB();
	}

	public void A0787C2()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.A0787CF();

		return this.A0787DC();
	}

	public void A0787CF()
	{
		A = [0x1188];
		A &= 0x01;

		if (Z == 1)
			return this.A0787DA();

		return this.A0787DC();
	}

	public void A0787DA()
	{
		return this.A0787F2();
	}

	public void A0787DC()
	{
		A = [0x10BC];
		A &= 0x20;

		if (Z == 0)
			return this.A0787E7();

		return this.A078854();
	}

	public void A0787E7()
	{
		A = [0x1188];
		A &= 0x20;

		if (Z == 1)
			return this.A0787F2();

		return this.A078854();
	}

	public void A0787F2()
	{
		P &= ~0x20;
		A = [0x10B6];

		if (Z == 0)
			return this.A078804();

		A = [0x10CB];
		A ^= 0x0001;
		[0x10CB] = A;
		return this.A078844();
	}

	public void A078804()
	{
		temp = A - 0x0001;

		if (Z == 0)
			return this.A07881A();

		A = [0x10B4];
		A++;
		temp = A - 0x0003;

		if (Z == 0)
			return this.A078815();

		A = 0x0000;
	}

	public void A078815()
	{
		[0x10B4] = A;
		return this.A078844();
	}

	public void A07881A()
	{
		temp = A - 0x0003;

		if (Z == 0)
			return this.A07882E();

		A = [0x10B2];
		A ^= 0x0001;
		[0x10B2] = A;
		this.A02915C();
		return this.A078844();
	}

	public void A07882E()
	{
		temp = A - 0x0002;

		if (Z == 0)
			return this.A07883E();

		A = [0x10E5];
		A ^= 0x0001;
		[0x10E5] = A;
		return this.A078844();
	}

	public void A07883E()
	{
		this.A0788AD();
		return this.A078854();
	}

	public void A078844()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P |= 0x20;
		return this.A0786CB();
	}

	public void A078854()
	{
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A07887E();

		P &= ~0x20;
		A = [0x10B6];
		temp = A - 0x0004;

		if (Z == 1)
			return this.A078876();

		A = [0x10AC];

		if (Z == 1)
			return this.A078876();

		[0x10AC] = 0;
		A = 0x0001;
		[0x7E2DD6] = A;
	}

	public void A078876()
	{
		this.A0788DC();
		P |= 0x20;
		return this.A0786CB();
	}

	public void A07887E()
	{
		A = [0x10B6];
		temp = A - 0x04;

		if (Z == 1)
			return this.A078890();

		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
	}

	public void A078890()
	{
		A = [0x10AC];

		if (Z == 1)
			return this.A0788A7();

		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		P &= ~0x20;
		A = 0x0004;
		this.A029283();
	}

	public void A0788A7()
	{
		P &= ~0x20;
		[0x10B6] = 0;
		return;
	}

	public void A0788AD()
	{
		P &= ~0x20;
		A = [0x10AC];
		A++;
		temp = A - 0x000F;

		if (Z == 0)
			return this.A0788BB();

		A = 0x0000;
	}

	public void A0788BB()
	{
		[0x10AC] = A;
		A = 0x001E;
		[0x7E2DD6] = A;
		return;
	}

	public void A0788C6()
	{
		P &= ~0x20;
		A = [0x10AC];
		A--;

		if (N == 0)
			return this.A0788D1();

		A = 0x000E;
	}

	public void A0788D1()
	{
		[0x10AC] = A;
		A = 0x001E;
		[0x7E2DD6] = A;
		return;
	}

	public void A0788DC()
	{
		P &= ~0x20;
		A = [0x7E2DD6];

		if (Z == 1)
			return this.A0788EB();

		A--;
		[0x7E2DD6] = A;

		if (Z == 1)
			return this.A0788EC();

	}

	public void A0788EB()
	{
		return;
	}

	public void A0788EC()
	{
		A = 0x0001;
		this.A029310();
		A = [0x10AC];
		X = A;
		A = [0x0BF82C];
		A &= 0x00FF;
		this.A02929A();
		Y = 0x0005;
	}

	public void A078905()
	{
		X = 0x0000;
	}

	public void A078908()
	{
		X--;

		if (Z == 0)
			return this.A078908();

		Y--;

		if (Z == 0)
			return this.A078905();

		return;
	}

	public void A07890F()
	{
		this.A07891C();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A07890F();

		return;
	}

	public void A07891C()
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
			return this.A078938();

		[0x1983]++;
	}

	public void A078938()
	{
		P |= 0x20;
	}

	public void A07893A()
	{
		A = [0x1ADF];

		if (Z == 1)
			return this.A07893A();

	}

	public void A07893F()
	{
		A = [0x1ADF];
		temp = A - 0x02;

		if (Z == 0)
			return this.A07893F();

		[0x1ADF] = 0;
	}

	public void A078949()
	{
		A = [0x38];

		if (Z == 0)
			return this.A078949();

		this.A02C418();
		P |= 0x20;
		A = [0x10B8];

		if (Z == 0)
			return this.A07895D();

		this.A078A41();
		return this.A07897F();
	}

	public void A07895D()
	{
		temp = A - 0x01;

		if (Z == 0)
			return this.A078966();

		this.A078ADC();
		return this.A07897F();
	}

	public void A078966()
	{
		temp = A - 0x02;

		if (Z == 0)
			return this.A07896F();

		this.A0789FA();
		return this.A07897F();
	}

	public void A07896F()
	{
		temp = A - 0x03;

		if (Z == 0)
			return this.A078978();

		this.A0789B2();
		return this.A07897F();
	}

	public void A078978()
	{
		temp = A - 0x04;

		if (Z == 0)
			return this.A07897F();

		this.A078986();
	}

	public void A07897F()
	{
		this.A02D352();
		P &= ~0x20;
		return;
	}

	public void A078986()
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
		A = [0x0BF7CA];
		[0x7000BA] = A;
		this.A03EA3E();
		return;
	}

	public void A0789B2()
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
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0038;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = 0x06D5;
		[0x7000BA] = A;
		this.A03EA3E();
		return;
	}

	public void A0789FA()
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
		this.A03EA3E();
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
		this.A7ED7E8();
		return;
	}

	public void A078A41()
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
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0054;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = 0x0C4E;
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0050;
		[0x700064] = A;
		A = 0x0088;
		[0x70002C] = A;
		A = 0x0C60;
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0054;
		[0x700064] = A;
		A = 0x00A0;
		[0x70002C] = A;
		A = 0x0C74;
		[0x7000BA] = A;
		this.A03EA3E();
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
		this.A03EA3E();
		return;
	}

	public void A078ADC()
	{
		P &= ~0x30;
		A = 0x001E;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10CB];
		[0x1986] = A;
		this.A02C239();
		A = 0x0030;
		[0x700064] = A;
		A = 0x0040;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x30;
		A = 0x0024;
		[0x1988] = A;
		A = 0x0003;
		[0x198A] = A;
		A = [0x10B4];
		[0x1986] = A;
		this.A02C239();
		A = 0x0030;
		[0x700064] = A;
		A = 0x0058;
		[0x70002C] = A;
		A = 0x00DF;
		[0x700228] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x002D;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10B2];
		[0x1986] = A;
		this.A02C239();
		P &= ~0x20;
		A = 0x0040;
		[0x700064] = A;
		A = 0x0088;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0033;
		[0x1988] = A;
		A = 0x0002;
		[0x198A] = A;
		A = [0x10E5];
		[0x1986] = A;
		this.A02C239();
		P &= ~0x20;
		A = 0x0034;
		[0x700064] = A;
		A = 0x0070;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0028;
		[0x700064] = A;
		A = 0x00A0;
		[0x70002C] = A;
		A = 0x0AF5;
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0039;
		[0x1988] = A;
		A = 0x000F;
		[0x198A] = A;
		A = [0x10AC];
		[0x1986] = A;
		this.A02C239();
		P &= ~0x20;
		A = 0x0074;
		[0x700064] = A;
		A = 0x00B0;
		[0x70002C] = A;
		A = [0x700222];
		[0x7000BA] = A;
		this.A03EA3E();
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
		this.A03EA3E();
		return;
	}

	public void A078C2E()
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
		this.A7ED7E8();
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
		this.A02B484();
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
		this.A7ED7E8();
		this.A02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.A7ED7E8();
		this.A078001();
		return;
	}

	public void A078CE0()
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
		this.A7ED7E8();
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
		this.A7ED7E8();
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
		this.A02B484();
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
		this.A7ED7E8();
		this.A02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.A7ED7E8();
		this.A078001();
		return;
	}

	public void A078DDE()
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
		this.A7ED7E8();
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
		this.A02B484();
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
		this.A7ED7E8();
		this.A02B1CB();
		P |= 0x20;
		P &= ~0x10;
		A = 0x01;
		X = 0xBF8F;
		this.A7ED7E8();
		this.A078001();
		A = [0x10C4];
		[0x420C] = A;
		this.A02CCC9();
		X = 0x000C;
		this.A02C062();
		this.A02CC50();
		return;
	}

	public void A078EA5()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		A = 0x0012;
		this.A029283();
		P &= ~0x20;
		A = 0x0000;
		[0x70022A] = A;
		[0x7000BA] = A;
		P |= 0x20;
		A = 0xFF;
		[0x1ACF] = A;
		this.A029634();
		A = 0xFF;
		[0x1AD1] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x000D;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0xC4A0;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		[0x1186] = 0;
		[0x1187] = 0;
		this.A03A17D();
		X = 0x007D;
	}

	public void A078F0C()
	{
		Stack.Push(X);
		this.A03E3B5();
		this.A03A1E2();
		P |= 0x20;
		P &= ~0x10;
		this.A02C278();
		P |= 0x20;
		this.A02C688();
		this.A02D24B();
		this.A038EA8();
		P &= ~0x30;
		A = 0x0000;
		[0x7001AC] = A;
		this.A7EC654();
		X = Stack.Pop();
		X--;

		if (Z == 1)
			return this.A078F3F();

		return this.A078F0C();
	}

	public void A078F3F()
	{
		P &= ~0x20;
		this.A02CC50();
		return;
	}

	public void A078F46()
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
		A = [0x0BF789];
		C = 1;
		A -= 0x60 - !C;
		[0x702492] = A;
		A = [0x0BF78A];
		C = 1;
		A -= 0x60 - !C;
		[0x702493] = A;
		A = [0x0BF78B];
		C = 1;
		A -= 0x60 - !C;
		[0x702494] = A;
		A = [0x0BF78C];
		C = 1;
		A -= 0x60 - !C;
		[0x702495] = A;
		A = [0x0BF78D];
		C = 1;
		A -= 0x60 - !C;
		[0x702496] = A;
		A = 0x00;
		[0x702497] = A;
		this.A07890F();
		X = 0x012C;
	}

	public void A078FA5()
	{
		Stack.Push(X);
		this.A07891C();
		P |= 0x20;
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.A078FB6();

		return this.A078FDC();
	}

	public void A078FB6()
	{
		A = [0x1188];
		A &= 0x02;

		if (Z == 1)
			return this.A078FC1();

		return this.A078FDC();
	}

	public void A078FC1()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		A--;

		if (N == 0)
			return this.A078FD8();

		A = 0x0004;
	}

	public void A078FD8()
	{
		[0x702490] = A;
	}

	public void A078FDC()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.A078FE9();

		return this.A079012();
	}

	public void A078FE9()
	{
		A = [0x1188];
		A &= 0x01;

		if (Z == 1)
			return this.A078FF4();

		return this.A079012();
	}

	public void A078FF4()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		A++;
		temp = A - 0x0005;

		if (Z == 0)
			return this.A07900E();

		A = 0x0000;
	}

	public void A07900E()
	{
		[0x702490] = A;
	}

	public void A079012()
	{
		P |= 0x20;
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.A07901F();

		return this.A07906D();
	}

	public void A07901F()
	{
		A = [0x1188];
		A &= 0x04;

		if (Z == 1)
			return this.A07902A();

		return this.A07906D();
	}

	public void A07902A()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		X = A;
		P |= 0x20;
		A = [0x702492];
		A--;
		temp = A - 0x01;

		if (Z == 0)
			return this.A07904B();

		A = 0x1A;
		return this.A079069();
	}

	public void A07904B()
	{
		temp = A - 0x05;

		if (Z == 0)
			return this.A079053();

		A = 0x04;
		return this.A079069();
	}

	public void A079053()
	{
		temp = A - 0x09;

		if (Z == 0)
			return this.A07905B();

		A = 0x08;
		return this.A079069();
	}

	public void A07905B()
	{
		temp = A - 0x0F;

		if (Z == 0)
			return this.A079063();

		A = 0x0E;
		return this.A079069();
	}

	public void A079063()
	{
		temp = A - 0x15;

		if (Z == 0)
			return this.A079069();

		A = 0x14;
	}

	public void A079069()
	{
		[0x702492 + X] = A;
	}

	public void A07906D()
	{
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.A079078();

		return this.A0790C6();
	}

	public void A079078()
	{
		A = [0x1188];
		A &= 0x08;

		if (Z == 1)
			return this.A079083();

		return this.A0790C6();
	}

	public void A079083()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P &= ~0x20;
		A = [0x702490];
		X = A;
		P |= 0x20;
		A = [0x702492];
		A++;
		temp = A - 0x1B;

		if (Z == 0)
			return this.A0790A4();

		A = 0x02;
		return this.A0790C2();
	}

	public void A0790A4()
	{
		temp = A - 0x05;

		if (Z == 0)
			return this.A0790AC();

		A = 0x06;
		return this.A0790C2();
	}

	public void A0790AC()
	{
		temp = A - 0x09;

		if (Z == 0)
			return this.A0790B4();

		A = 0x0A;
		return this.A0790C2();
	}

	public void A0790B4()
	{
		temp = A - 0x0F;

		if (Z == 0)
			return this.A0790BC();

		A = 0x10;
		return this.A0790C2();
	}

	public void A0790BC()
	{
		temp = A - 0x15;

		if (Z == 0)
			return this.A0790C2();

		A = 0x16;
	}

	public void A0790C2()
	{
		[0x702492 + X] = A;
	}

	public void A0790C6()
	{
		X = Stack.Pop();
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A0790D3();

		return this.A078FA5();
	}

	public void A0790D3()
	{
		P &= ~0x20;
		A = 0x2A00;
		this.A029213();
		P |= 0x20;
		P |= 0x20;
		P &= ~0x10;
		Y = 0x0000;
		[0x3A] = 0;
	}

	public void A0790E7()
	{
		X = 0x0000;
		Stack.Push(Y);
	}

	public void A0790EB()
	{
		Stack.Push(X);
		X = Y;
		A = [0x0BF789];
		X = Stack.Pop();
		C = 1;
		A -= 0x61 - !C;
		A++;
		temp = A - [0x702492 + X];

		if (Z == 0)
			return this.A07910C();

		Y++;
		X++;
		temp = X - 0x0005;

		if (Z == 0)
			return this.A0790EB();

		Y = Stack.Pop();
		A = [0x3A];
		temp = A - 0x08;

		if (N == 0)
			return this.A079129();

		return this.A07914D();
	}

	public void A07910C()
	{
		Y = Stack.Pop();
		[0x3A]++;
		Y++;
		Y++;
		Y++;
		Y++;
		Y++;
		temp = Y - 0x0041;

		if (N == 1)
			return this.A0790E7();

		return;
	}

	public void A079129()
	{
		A = [0x3A];
		C = 1;
		A -= 0x08 - !C;
		[0x10F0] = A;
		P &= ~0x20;
		A &= 0x00FF;
		X = A;
		P |= 0x20;
		A = [0x0BF827];
		A |= [0x10EF];
		[0x10EF] = A;
		A = 0x04;
		[0x10B8] = A;
		X = 0x001E;
		return this.A07915B();
	}

	public void A07914D()
	{
		P |= 0x20;
		A = [0x3A];
		[0xF4] = A;
		A = 0x03;
		[0x10B8] = A;
		X = 0x001E;
	}

	public void A07915B()
	{
		Stack.Push(X);
		this.A07891C();
		X = Stack.Pop();
		X--;

		if (Z == 0)
			return this.A07915B();

		return;
	}

	public void A079164()
	{
		this.A07890F();
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		P &= ~0x20;
		this.A0292AD();
		A = 0x0014;
		this.A029283();
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
		this.A029634();
		this.A0380F7();
		this.A038154();
		P |= 0x20;
		A = 0xFF;
		[0x1AD2] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x000E;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P |= 0x20;
		this.A03A17D();
		P |= 0x20;
		[0x10B6] = 0;
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF53();
	}

	public void A079209()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A02C897();
		P &= ~0x20;
		A = 0x002E;
		[0x700064] = A;
		A = 0x000C;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = 0x3EF0;
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = 0x0026;
		[0x700064] = A;
		A = 0x00A5;
		[0x70002C] = A;
		A = 0x00E0;
		[0x700228] = A;
		A = [0x11D6];
		[0x7000BA] = A;
		this.A03EA39();
		P |= 0x20;
		A = [0x11D5];

		if (Z == 1)
			return this.A079266();

		A--;
		[0x11D5] = A;
		this.A03EFEA();
		return this.A07926A();
	}

	public void A079266()
	{
		this.A03EFCF();
	}

	public void A07926A()
	{
		P |= 0x20;
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.A0792BC();

		P &= ~0x20;
		A = [0x10B6];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		P |= 0x20;
		A = [0x0BFABE];
		temp = A - [0x10BE];

		if (Z == 0)
			return this.A0792B9();

		A = [0x0BFABF];
		temp = A - [0x10BC];

		if (Z == 0)
			return this.A0792B9();

		[0x10B6]++;
		A = [0x10B6];
		temp = A - 0x16;

		if (Z == 1)
			return this.A0792BC();

		P &= ~0x30;
		A = [0x10B6];
		A &= 0x00FF;
		A <<= 1;
		A <<= 1;
		X = A;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF53();
	}

	public void A0792B9()
	{
		return this.A079209();
	}

	public void A0792BC()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
		P &= ~0x20;
		A = 0x0004;
		this.A029283();
		this.A02C494();
		this.A038168();
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

	public void A089160()
	{
		P &= ~0x20;
		[0x114C] = 0;
		P |= 0x20;
		A = 0xFF;
		[0x1129] = A;
		P &= ~0x20;
		Stack.Push(X);
		X = [0x1990];
		A = [0x0BFB95];
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

	public void A08918E()
	{
		Stack.Push(Y);
		[0x3A] = X;
		this.A03A102();

		if (C == 0)
			return this.A089199();

		return this.A0891A2();
	}

	public void A089199()
	{
		Y = 0x0000;
		X = [0x3A];
		return this.A08928E();
	}

	public void A0891A2()
	{
		Y = X;
		X = [0x3A];
		P &= ~0x20;
		A = 0xC2B9;
		[0x0004 + Y] = A;
		P |= 0x20;
		this.A03A054();
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

	public void A08920C()
	{
		A = [0x09B2A4];
		A &= 0x00FF;
		temp = A - 0x000D;

		if (Z == 0)
			return this.A089226();

		A = [0x3C];
		C = 0;
		A += 0x00FA + C;
		[0x3C] = A;
		A = [0x79];
		[0x3E] = A;
		return this.A089242();
	}

	public void A089226()
	{
		temp = A - 0x005F;

		if (Z == 0)
			return this.A089235();

		A = [0x3E];
		C = 0;
		A += 0x0078 + C;
		[0x3E] = A;
		return this.A089242();
	}

	public void A089235()
	{
		temp = A - 0x0020;

		if (Z == 0)
			return this.A089247();

		A = [0x3E];
		C = 0;
		A += 0x00F0 + C;
		[0x3E] = A;
	}

	public void A089242()
	{
		X++;
		[0x9C] = X;
		return this.A08920C();
	}

	public void A089247()
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

	public void A08928E()
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
			return this.A0892AD();

		Stack.Push(X);
		X = [0x9C];
		A = [0x09B2A4];
		X = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.A0892AD();

		return this.A08918E();
	}

	public void A0892AD()
	{
		return;
	}

	public void A09F8D2()
	{
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.A029634();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x0017;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.A03A17D();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF8C();
		X = 0x005F;
		[0x197C] = X;
		[0x1ACB] = 0;
		this.A02C897();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A09F95E()
	{
		P |= 0x20;
		P &= ~0x10;
		X = [0x1990];
		A = [0x0BF8F8];
		temp = A - [0x1186];

		if (Z == 1)
			return this.A09F972();

		this.A03A479();
	}

	public void A09F972()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		this.A02C897();
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
		A = [0x0BF8F4];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A09F9E3();

		this.A03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A09F9C4();

		[0x1992] = A;
		return this.A09F9E9();
	}

	public void A09F9C4()
	{
		X = [0x1990];
		A = [0x0BF8F6];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		temp = A - 0x0038;

		if (Z == 1)
			return this.A09FA02();

		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
	}

	public void A09F9E3()
	{
		this.A03EFEA();
		return this.A09F9ED();
	}

	public void A09F9E9()
	{
		this.A03EFCF();
	}

	public void A09F9ED()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x1188];
		temp = A & 0x90;

		if (Z == 0)
			return this.A09F9FF();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A09FA02();

	}

	public void A09F9FF()
	{
		return this.A09F95E();
	}

	public void A09FA02()
	{
		P |= 0x20;
		this.A02CC8F();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		return;
	}

	public void A09FA1A()
	{
		Stack.Push(P);
		Stack.Push(X);
		P |= 0x20;
		P &= ~0x10;
		A = [0x122A];

		if (Z == 0)
			return this.A09FA3A();

		P |= 0x20;
		A = 0x08;
		[0x1299] = A;
		X = 0xEA2D;
		[0x1297] = X;
		X = 0x0080;
		[0x129A] = X;
		return this.A09FA5E();
	}

	public void A09FA3A()
	{
		A = [0xF3];
		P &= ~0x20;
		A &= 0x00FF;
		[0x3A] = A;
		A <<= 1;
		C = 0;
		A += [0x3A] + C;
		X = A;
		A = [0x02F4C8];
		[0x1297] = A;
		P |= 0x20;
		A = [0x02F4CA];
		[0x1299] = A;
		X = 0x0080;
		[0x129A] = X;
	}

	public void A09FA5E()
	{
		Y = 0x0000;
		X = [0x1297];
		Stack.Push(B);
		A = [0x1299];
		Stack.Push(A);
		B = Stack.Pop();
		P &= ~0x20;
	}

	public void A09FA6C()
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
		temp = Y - 0x0080;

		if (Z == 0)
			return this.A09FA6C();

		A = 0x0000;
		[0x00137A] = A;
		P |= 0x20;
		B = Stack.Pop();
		X = Stack.Pop();
		P = Stack.Pop();
		return;
	}

	public void A09FA8C()
	{
		P &= ~0x30;
		X = 0x0000;
		A = [0x70002E];

		if (Z == 0)
			return this.A09FA9A();

		return this.A09FB6F();
	}

	public void A09FA9A()
	{
		Y = 0x0000;
	}

	public void A09FA9D()
	{
		C = 1;
		A -= 0x2710 - !C;

		if (N == 1)
			return this.A09FAA6();

		Y++;
		return this.A09FA9D();
	}

	public void A09FAA6()
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

	public void A09FAC0()
	{
		C = 1;
		A -= 0x03E8 - !C;

		if (N == 1)
			return this.A09FAC9();

		Y++;
		return this.A09FAC0();
	}

	public void A09FAC9()
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

	public void A09FAE3()
	{
		C = 1;
		A -= 0x0064 - !C;

		if (N == 1)
			return this.A09FAEC();

		Y++;
		return this.A09FAE3();
	}

	public void A09FAEC()
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

	public void A09FB06()
	{
		C = 1;
		A -= 0x000A - !C;

		if (N == 1)
			return this.A09FB0F();

		Y++;
		return this.A09FB06();
	}

	public void A09FB0F()
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

	public void A09FB46()
	{
		A = [0x7020F4];
		temp = A - 0x30;

		if (Z == 0)
			return this.A09FB51();

		X++;
		return this.A09FB46();
	}

	public void A09FB51()
	{
		A = [0x7020F4];
		Stack.Push(X);
		X = Y;
		[0x702091 + X] = A;
		X = Stack.Pop();
		A &= 0xFF;

		if (Z == 1)
			return this.A09FB64();

		X++;
		Y++;
		return this.A09FB51();
	}

	public void A09FB64()
	{
		A = 0x0E;
		[0x702090] = A;
		this.A03EA26();
		return;
	}

	public void A09FB6F()
	{
		P |= 0x20;
		A = 0x0E;
		[0x702090] = A;
		A = 0x30;
		[0x702091] = A;
		A = 0x00;
		[0x702092] = A;
		this.A03EA26();
		return;
	}

	public void A09FB88()
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
		this.A7ED7E8();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void A09FBB0()
	{
		A = [0x701000];
		[0x7F8000 + X] = A;
		X++;
		temp = X - 0x1800;

		if (Z == 0)
			return this.A09FBB0();

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
		this.A7ED7E8();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void A09FBE6()
	{
		A = [0x701000];
		[0x7F9800 + X] = A;
		X++;
		temp = X - 0x1800;

		if (Z == 0)
			return this.A09FBE6();

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
		this.A7ED7E8();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void A09FC1C()
	{
		A = [0x701000];
		[0x7FB000 + X] = A;
		X++;
		temp = X - 0x1800;

		if (Z == 0)
			return this.A09FC1C();

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
		this.A7ED7E8();
		P |= 0x20;
		P &= ~0x10;
		X = 0x0000;
	}

	public void A09FC52()
	{
		A = [0x701000];
		[0x7FC800 + X] = A;
		X++;
		temp = X - 0x1800;

		if (Z == 0)
			return this.A09FC52();

		return;
	}

	public void A0CF550()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		this.A02CC8F();
	}

	public void A0CF55D()
	{
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		A = 0x0013;
		this.A029283();
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x198F] = A;
		[0x1ACF] = A;
		P |= 0x20;
		this.A029634();
		this.A0380F7();
		this.A038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x000F;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0xC544;
		[0x1DE9] = A;
		A = 0xC4C7;
		[0x1DD8] = A;
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.A03A17D();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF8C();
		X = 0x005F;
		[0x197C] = X;
	}

	public void A0CF5F2()
	{
		[0x1ACB] = 0;
		this.A02C897();
		P |= 0x20;
		A = 0x01;
		[0x1ACB] = A;
	}

	public void A0CF600()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		[0x1188] = A;
		this.A02C897();
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
		A = [0x0BF8A4];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A0CF67B();

		this.A03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A0CF652();

		[0x1992] = A;
		return this.A0CF681();
	}

	public void A0CF652()
	{
		X = [0x1990];
		A = [0x0BF8A6];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		temp = A - 0x0050;

		if (Z == 1)
			return this.A0CF681();

		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		A = [0x1990];
		temp = A - 0x0040;

		if (Z == 1)
			return this.A0CF6D1();

		return this.A0CF681();
	}

	public void A0CF67B()
	{
		this.A03EFEA();
		return this.A0CF685();
	}

	public void A0CF681()
	{
		this.A03EFCF();
	}

	public void A0CF685()
	{
		P &= ~0x30;
		A = [0x197C];

		if (N == 1)
			return this.A0CF69F();

		P |= 0x20;
		A = [0x1188];
		temp = A & 0x90;

		if (Z == 0)
			return this.A0CF69C();

		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A0CF69F();

	}

	public void A0CF69C()
	{
		return this.A0CF600();
	}

	public void A0CF69F()
	{
		P &= ~0x20;
		A = 0x0001;
		this.A029310();
		P |= 0x20;
		this.A02CC8F();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		P &= ~0x20;
		A = 0x0004;
		this.A029283();
		this.A09F8D2();
		this.A0CF878();
		return;
	}

	public void A0CF6D1()
	{
		this.A02CC7C();
		this.A02C494();
		P &= ~0x20;
		A = 0x0010;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		return this.A0CF5F2();
	}

	public void A0CF6F7()
	{
		this.A02CC8F();
		P &= ~0x20;
		A = 0x0028;
		[0x1992] = A;
		P |= 0x20;
		P &= ~0x10;
		A = 0xFF;
		[0x1ACF] = A;
		P |= 0x20;
		this.A029634();
		this.A0380F7();
		this.A038154();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.A02C494();
		P &= ~0x20;
		A = [0x1AD6];
		temp = A - 0x0001;

		if (Z == 1)
			return this.A0CF740();

		A = 0x0015;
		return this.A0CF743();
	}

	public void A0CF740()
	{
		A = 0x0011;
	}

	public void A0CF743()
	{
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		this.A03A17D();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF8C();
	}

	public void A0CF77F()
	{
		P |= 0x20;
		A = [0x1AD6];
		temp = A - 0x0A;

		if (Z == 1)
			return this.A0CF78F();

		A = [0x10EF];
		temp = A & 0x08;

		if (Z == 1)
			return this.A0CF7B0();

	}

	public void A0CF78F()
	{
		this.A02C1B3();
		P |= 0x20;
		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		P &= ~0x20;
		A = [0x1AD6];
		temp = A - 0x000A;

		if (Z == 1)
			return this.A0CF7B0();

		A = [0x1986];
		[0xF4] = A;
	}

	public void A0CF7B0()
	{
		P |= 0x20;
		P &= ~0x10;
		this.A02C897();
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
		A = [0x0BF83C];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A0CF830();

		this.A03EAE4();
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A0CF80C();

		[0x1992] = A;
		return this.A0CF836();
	}

	public void A0CF80C()
	{
		X = [0x1988];
		A = [0x0BF83E];
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0004 + C;
		temp = A - 0x0008;

		if (Z == 0)
			return this.A0CF825();

		A = 0x0000;
	}

	public void A0CF825()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.A0CF836();
	}

	public void A0CF830()
	{
		this.A03EFEA();
		return this.A0CF83A();
	}

	public void A0CF836()
	{
		this.A03EFCF();
	}

	public void A0CF83A()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10BC];
		temp = A & 0x90;

		if (Z == 0)
			return this.A0CF848();

		return this.A0CF77F();
	}

	public void A0CF848()
	{
		P &= ~0x20;
		A = 0xEA02;
		this.A029213();
		P |= 0x20;
		A = 0xFF;
		P |= 0x20;
		Stack.Push(A);
		this.A02CC8F();
		this.A038168();
		this.A038000();
		P |= 0x20;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		A = Stack.Pop();
		return;
	}

	public void A0CF878()
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
		this.A029634();
		P |= 0x20;
		A = 0x10;
		[0x7EDE0E] = A;
		A = 0x5B;
		[0x7EDE12] = A;
		A = 0xFF;
		[0x1AD1] = A;
		this.A02C494();
		P &= ~0x20;
		A = 0x0014;
		A <<= 1;
		X = A;
		A = [0x048000];
		[0x1932] = A;
		P |= 0x20;
		this.A00E0BA();
		X = [0x1932];
		this.A00E0F6();
		P &= ~0x20;
		A = 0x0001;
		[0x198C] = A;
		[0x1990] = 0;
		[0x110E] = 0;
		A = [0x0BF930];
		[0x110C] = A;
		P |= 0x20;
		this.A03A17D();
		P &= ~0x20;
		X = 0x0000;
		A = [0x0BFABC];
		[0x11D6] = A;
		P |= 0x20;
		A = 0x1E;
		[0x11D5] = A;
		this.A03EF8C();
	}

	public void A0CF8F9()
	{
		P &= ~0x20;
		X = [0x1990];
		A = [0x0BF930];
		[0x110C] = A;
		P |= 0x20;
		P &= ~0x10;
		this.A02C897();
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
		A = [0x0BF932];
		[0x7000BA] = A;
		this.A03EA3E();
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
		A = [0x0BF92C];
		[0x7000BA] = A;
		this.A03EA3E();
		P &= ~0x20;
		A = [0x70022E];

		if (Z == 1)
			return this.A0CF9A4();

		A = [0x10EF];
		A &= 0x0008;

		if (Z == 1)
			return this.A0CF979();

		return this.A0CF9AA();
	}

	public void A0CF979()
	{
		A = [0x1992];
		A--;

		if (Z == 1)
			return this.A0CF984();

		[0x1992] = A;
		return this.A0CF9AA();
	}

	public void A0CF984()
	{
		A = 0x003C;
		[0x1992] = A;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		temp = A - 0x0090;

		if (Z == 0)
			return this.A0CF999();

		return this.A0CFAC4();
	}

	public void A0CF999()
	{
		[0x1990] = A;
		A = 0x0001;
		[0x198C] = A;
		return this.A0CF9AA();
	}

	public void A0CF9A4()
	{
		this.A03EFEA();
		return this.A0CF9AE();
	}

	public void A0CF9AA()
	{
		this.A03EFCF();
	}

	public void A0CF9AE()
	{
		P |= 0x20;
		P &= ~0x10;
		A = [0x10EF];
		A &= 0x08;

		if (Z == 0)
			return this.A0CF9BC();

		return this.A0CFAAE();
	}

	public void A0CF9BC()
	{
		A = [0x10C0];
		A &= 0x10;

		if (Z == 1)
			return this.A0CF9CA();

		this.A03A572();
		return this.A0CF8F9();
	}

	public void A0CF9CA()
	{
		X = [0x10FC];
		A = [0x10BC];
		A &= 0x08;

		if (Z == 0)
			return this.A0CF9D8();

		return this.A0CF9DC();
	}

	public void A0CF9D8()
	{
		[0x12 + X]++;
		[0x12 + X]++;
	}

	public void A0CF9DC()
	{
		A = [0x10BC];
		A &= 0x04;

		if (Z == 0)
			return this.A0CF9E7();

		return this.A0CF9EB();
	}

	public void A0CF9E7()
	{
		[0x12 + X]--;
		[0x12 + X]--;
	}

	public void A0CF9EB()
	{
		A = [0x10BC];
		A &= 0x02;

		if (Z == 0)
			return this.A0CF9F6();

		return this.A0CF9FA();
	}

	public void A0CF9F6()
	{
		[0x13 + X]++;
		[0x13 + X]++;
	}

	public void A0CF9FA()
	{
		A = [0x10BC];
		A &= 0x01;

		if (Z == 0)
			return this.A0CFA05();

		return this.A0CFA09();
	}

	public void A0CFA05()
	{
		[0x13 + X]--;
		[0x13 + X]--;
	}

	public void A0CFA09()
	{
		A = [0x10BC];
		A &= 0x40;

		if (Z == 0)
			return this.A0CFA14();

		return this.A0CFA18();
	}

	public void A0CFA14()
	{
		[0x14 + X]++;
		[0x14 + X]++;
	}

	public void A0CFA18()
	{
		A = [0x10BE];
		A &= 0x80;

		if (Z == 0)
			return this.A0CFA23();

		return this.A0CFA27();
	}

	public void A0CFA23()
	{
		[0x14 + X]--;
		[0x14 + X]--;
	}

	public void A0CFA27()
	{
		A = [0x10BE];
		A &= 0x20;

		if (Z == 0)
			return this.A0CFA32();

		return this.A0CFA40();
	}

	public void A0CFA32()
	{
		P &= ~0x20;
		A = [0x1110];
		C = 1;
		A -= 0x000A - !C;
		[0x1110] = A;
		P |= 0x20;
	}

	public void A0CFA40()
	{
		A = [0x10BE];
		A &= 0x10;

		if (Z == 0)
			return this.A0CFA4B();

		return this.A0CFA59();
	}

	public void A0CFA4B()
	{
		P &= ~0x20;
		A = [0x1110];
		C = 0;
		A += 0x000A + C;
		[0x1110] = A;
		P |= 0x20;
	}

	public void A0CFA59()
	{
		A = [0x10BE];
		A &= 0x40;

		if (Z == 0)
			return this.A0CFA64();

		return this.A0CFA85();
	}

	public void A0CFA64()
	{
		A = [0x1189];
		A &= 0x40;

		if (Z == 1)
			return this.A0CFA6F();

		return this.A0CFA85();
	}

	public void A0CFA6F()
	{
		P &= ~0x20;
		A = [0x1990];
		C = 0;
		A += 0x0008 + C;
		temp = A - 0x0190;

		if (Z == 0)
			return this.A0CFA80();

		A = 0x0000;
	}

	public void A0CFA80()
	{
		[0x1990] = A;
		P |= 0x20;
	}

	public void A0CFA85()
	{
		A = [0x10BC];
		A &= 0x80;

		if (Z == 0)
			return this.A0CFA90();

		return this.A0CFAAE();
	}

	public void A0CFA90()
	{
		A = [0x1188];
		A &= 0x80;

		if (Z == 1)
			return this.A0CFA9B();

		return this.A0CFAAE();
	}

	public void A0CFA9B()
	{
		P &= ~0x20;
		A = [0x1990];
		C = 1;
		A -= 0x0008 - !C;

		if (N == 0)
			return this.A0CFAA9();

		A = 0x0188;
	}

	public void A0CFAA9()
	{
		[0x1990] = A;
		P |= 0x20;
	}

	public void A0CFAAE()
	{
		A = [0x10BC];
		temp = A & 0x10;

		if (Z == 0)
			return this.A0CFAC4();

		A = [0x10BC];
		[0x1188] = A;
		A = [0x10BE];
		[0x1189] = A;
		return this.A0CF8F9();
	}

	public void A0CFAC4()
	{
		P |= 0x20;
		this.A02CC8F();
		this.A038168();
		P |= 0x20;
		[0x198F] = 0;
		A = 0x0F;
		[0x7EDE0E] = A;
		A = 0x5C;
		[0x7EDE12] = A;
		return;
	}

	public void A7EC654()
	{
		Cpu.Break();
	}

	public void A7ED7E8()
	{
		Cpu.Break();
	}

}
