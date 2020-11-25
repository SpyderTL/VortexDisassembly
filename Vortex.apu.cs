public class ApuProgram
{
	public void L02B0()
	{
		// Value1439 = 0;
		A = 0x00;
		[0x1439] = A;
	}

	public void L02B5()
	{
		// Direct Page = 0;
		D = 0;

		// Stack Pointer = 0x2F;
		X = 0x2F;
		S = X;

		// Clear RAM 0x0000 - 0x00FF
		A = 0x00;
		X = A;
	}

	public void L02BC()
	{
		[X++] = A;

		if (Z == 0)
			return this.L02BC();

		// Clear RAM 0x0100 - 0x01FF
		X = A;
	}

	public void L02C2()
	{
		[0x0100 + X] = A;
		C = 1; temp = X - 0xB0;

		if (C == 1)
			return this.L02CC();

		// Clear RAM 0x02B0 - 0x02FF
		[0x0200 + X] = A;
	}

	public void L02CC()
	{
		X++;

		if (Z == 0)
			return this.L02C2();

		// Reset I/O Ports
		Y = A;
		[0xF4] = YA;
		[0xF6] = YA;

		A++;
		this.L0FE7();
		[0x31] |= 0x20;

		// WordF2 = 0x155D;
		A = 0x15;
		Y = 0x5D;
		[0xF2] = Y;
		[0xF3] = A;

		[0xF1] = 0xF0;

		A = 0x10;
		[0xFA] = A;
		[0xFB] = A;
		[0x3B] = A;
		[0xF1] = 0x03;
		[0xF4] = 0x02;
		[0xF5] = 0x00;

		// A = Table06DF[X];
		A = [0x06DF + X];
		Y = [0x06E0];
		[0x06] = YA;
		[0x2F] = 0x02;
	}

	public void L0301()
	{
		Y = 0x0A;
	}

	public void L0303()
	{
		C = 1; temp = Y - 0x05;

		if (Z == 1)
			return this.L030E();


		if (C == 1)
			return this.L0311();

		C = 1; temp = [0x36] - [0x35];

		if (Z == 0)
			return this.L031D();

	}

	public void L030E()
	{
		if (([0x35] & 0x80) != 0)
			return this.L031D();
	}

	public void L0311()
	{
		// ValueF2 = Table038E[Y];
		A = [0x038E + Y];
		[0xF2] = A;

		// X = Table0398[Y];
		A = [0x0398 + Y];
		X = A;

		// ValueF3 = [X];
		A = [X];
		[0xF3] = A;
	}

	public void L031D()
	{
		Y--; if (Z == 0)
			return this.L0303();

		[0x29] = Y;
		[0x2A] = Y;
	}

	public void L0323()
	{
		Y = [0xFE];

		if (Z == 1)
			return this.L0323();

		A = 0x30;
		YA = Y * A;
		C = 0;
		A += [0x58] + C;
		[0x58] = A;

		if (C == 0)
			return this.L0334();

		this.L03A3();
	}

	public void L0334()
	{
		Y = [0xFD];

		if (Z == 1)
			return this.L0334();

		[S--] = Y;
		A = 0x40;
		YA = Y * A;
		C = 0;
		A += [0x14] + C;
		[0x14] = A;

		if (C == 0)
			return this.L035B();

	}

	public void L0343()
	{
		YA = [0xF4];
		C = 1; temp = YA - [0xF4];

		if (Z == 0)
			return this.L0343();

		C = 1; temp = YA - [0x00];

		if (Z == 1)
			return this.L0354();

		[0x00] = YA;
		[0xF4] = YA;
		this.L0469();
	}

	public void L0354()
	{
		C = 1; temp = [0x36] - [0x35];

		if (Z == 1)
			return this.L035B();

		[0x35]++;
	}

	public void L035B()
	{
		Y = [++S];
		A = [0x3B];
		YA = Y * A;
		C = 0;
		A += [0x39] + C;
		[0x39] = A;

		if (C == 0)
			return this.L036B();

		this.L09CF();
		return this.L0301();
	}

	public void L036B()
	{
		A = [0x05];

		if (Z == 1)
			return this.L0301();

		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0374()
	{
		A = [0x19 + X];

		if (Z == 1)
			return this.L037B();

		this.L135D();
	}

	public void L037B()
	{
		X++;
		X++;
		[0x2B] <<= 1;
		A = [0x19 + X];

		if (Z == 1)
			return this.L0386();

		this.L135D();
	}

	public void L0386()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0374();

		return this.L0301();
	}

	public void L03A3()
	{
		A = [0x13];

		if (Z == 1)
			return this.L03AA();

		this.L0718();
	}

	public void L03AA()
	{
		Y = [0x71];

		if (Z == 1)
			return this.L0423();

	}

	public void L03AE()
	{
		Y--;
		[S--] = Y;
		X = [0x72 + Y];
		[0x2B] = X;
		A = X;
		X = [0x59 + Y];
		A &= [0x28];

		if (Z == 0)
			return this.L040A();

		Y = [0x62 + X];

		if (Z == 1)
			return this.L0416();

		[0x2C] = X;
		[0x7F]--;

		if (Z == 0)
			return this.L040A();

	}

	public void L03C5()
	{
		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L03CD();

		[0x62 + X]++;
	}

	public void L03CD()
	{
		Y = A;

		if (Z == 0)
			return this.L03E7();

		A = [0x8F + X];

		if (Z == 1)
			return this.L0424();

		this.L0E78();
		[0x8F]--;

		if (Z == 0)
			return this.L03C5();

		A = [0x0160 + X];
		[0x61 + X] = A;
		A = [0x0161 + X];
		[0x62 + X] = A;
		return this.L03C5();
	}

	public void L03E7()
	{

		if (N == 1)
			return this.L03F5();

		[0x0130 + X] = A;
		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L03F4();

		[0x62 + X]++;
	}

	public void L03F4()
	{
		Y = A;
	}

	public void L03F5()
	{
		C = 1; temp = A - 0xCE;

		if (C == 0)
			return this.L03FE();

		this.L044D();
		return this.L03C5();
	}

	public void L03FE()
	{
		this.L0748();
		A = [0x0130 + X];
		[0x7F + X] = A;
		[0x80 + X] = A;
		return this.L040D();
	}

	public void L040A()
	{
		this.L123E();
	}

	public void L040D()
	{
		this.L102B();
		this.L10EA();
		this.L13DC();
	}

	public void L0416()
	{
		A = [0xDF];
		C = 1; temp = A - 0x02;

		if (Z == 0)
			return this.L041F();

		this.L0615();
	}

	public void L041F()
	{
		A = [++S];
		Y = A;

		if (Z == 0)
			return this.L03AE();

	}

	public void L0423()
	{
		return;
	}

	public void L0424()
	{
		A = 0xFF;
		[0x0271 + X] = A;
		A++;
		[0x62 + X] = A;
		A = [0xDF];

		if (Z == 1)
			return this.L0416();

		this.L05FB();
		return this.L0416();
	}

	public void L044D()
	{
		A <<= 1;
		Y = A;
		A = [0x0A77 + Y];
		[S--] = A;
		A = [0x0A76 + Y];
		[S--] = A;
		A = Y;
		A >>= 1;
		Y = A;
		A = [0x0B0A + Y];

		if (Z == 1)
			return this.L0468();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L0467();

		[0x62 + X]++;
	}

	public void L0467()
	{
		Y = A;
	}

	public void L0468()
	{
		return;
	}

	public void L0469()
	{
		A = Y;
		A &= 0x0E;
		X = A;
		A = Y;
		A &= 0xE0;
		A = (A >> 4) | (A << 4)
		[0x2C] = A;
		return [0x0477 + X]();
	}

	public void L05FB()
	{
		[0xDF] = 0x02;
		C = 0;
		A = [0x4A];

		if (N == 0)
			return this.L0604();

		C = 1;
	}

	public void L0604()
	{
		Cpu.ROR(A);
		[0x4A] = A;
		C = 0;
		A = [0x4C];

		if (N == 0)
			return this.L060D();

		C = 1;
	}

	public void L060D()
	{
		Cpu.ROR(A);
		[0x4C] = A;
		A = 0x70;
		[0x30] = A;
		return;
	}

	public void L0615()
	{
		[0x30 + X]--;
		A = [0x30];
		Y = 0x0C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = 0x1C;
		[0xF2] = Y;
		[0xF3] = A;
		C = 1; temp = A - [0xE7];

		if (Z == 0)
			return this.L062C();

		[0xDF] = 0x00;
	}

	public void L062C()
	{
		return;
	}

	public void L0675()
	{
		[0xF2] = 0x6C;
		[0xF3] = 0x20;
		[0xF4] = 0xAA;
		[0xF5] = 0xBB;
	}

	public void L0681()
	{
		A = [0xF4];
		C = 1; temp = A - [0xF4];

		if (Z == 0)
			return this.L0681();

		C = 1; temp = A - 0xCC;

		if (Z == 0)
			return this.L0681();

		return this.L06A8();
	}

	public void L068D()
	{
		Y = [0xF4];

		if (Z == 0)
			return this.L068D();

	}

	public void L0691()
	{
		C = 1; temp = Y - [0xF4];

		if (Z == 0)
			return this.L06A2();

		A = [0xF5];
		[0xF4] = Y;
		[[0x7A] +Y] = A;
		Y++;

		if (Z == 0)
			return this.L0691();

		[0x7B]++;
		return this.L0691();
	}

	public void L06A2()
	{

		if (N == 0)
			return this.L0691();

		C = 1; temp = Y - [0xF4];

		if (N == 0)
			return this.L0691();

	}

	public void L06A8()
	{
		YA = [0xF6];
		[0x7A] = YA;
		YA = [0xF4];
		[0xF4] = A;
		A = Y;
		X = A;

		if (Z == 0)
			return this.L068D();

	}

	public void L06B4()
	{
		YA = [0xF4];

		if (Z == 0)
			return this.L06B4();

		[0x00] = YA;
		[0xF4] = YA;
	}

	public void L06BC()
	{
		YA = [0xF6];

		if (Z == 0)
			return this.L06BC();

		[0x02] = YA;
		[0xF6] = YA;
		A = 0x5C;
		Y = 0xFF;
		[0xF2] = YA;
		Y = 0x00;
		A = 0x2C;
		[0xF2] = YA;
		A = 0x3C;
		[0xF2] = YA;
		YA = [0x7A];
		[0x06DF] = A;
		[0x06E0] = Y;
		return this.L02B5();
	}

	public void L0718()
	{
		[0xF2] = 0x18;
		A = [0xF3];

		if (Z == 0)
			return this.L0747();

		X = 0x02;
		A = [0x0281 + X];
		C = 1; temp = A - 0xC5;

		if (Z == 1)
			return this.L0741();

		C = 1; temp = A - 0xC0;

		if (Z == 1)
			return this.L0730();

		A = 0xC0;
		return this.L0732();
	}

	public void L0730()
	{
		A = 0xC5;
	}

	public void L0732()
	{
		Y = A;
		this.L0748();
		A = [0x08BC + X];
		Y = 0x4C;
		[0xF2] = Y;
		[0xF3] = A;
		return this.L0747();
	}

	public void L0741()
	{
		[0x13] = [0x46];
		[0x13] = 0x00;
	}

	public void L0747()
	{
		return;
	}

	public void L0748()
	{
		C = 1; temp = Y - 0xC8;

		if (C == 1)
			return this.L0747();

		A = Y;
		[0x0281 + X] = A;
		A &= 0x7F;
		return this.L0767();
	}

	public void L0754()
	{
		C = 1; temp = Y - 0xC8;

		if (C == 1)
			return this.L0747();

		[0xE92B] |= [0x00]; 0xE92B;
		A = [0x13];
		A &= [0x2B];

		if (Z == 0)
			return this.L0747();

		A = Y;
		A &= 0x7F;
		C = 0;
		A += [0x38] + C;
	}

	public void L0767()
	{
		C = 0;
		A += [0x0280 + X] + C;
		[0x0201 + X] = A;
		A = [0xD0 + X];
		[0x0200 + X] = A;
		A = [0x0260 + X];
		A >>= 1;
		A = 0x00;
		Cpu.ROR(A);
		[0x0241 + X] = A;
		A = 0x00;
		[0xBF + X] = A;
		[0x0090 + X] = A;
		A = [0x2B];
		A &= [0x57];

		if (Z == 0)
			return this.L078D();

		[0x292B] |= [0x00]; 0x292B;
	}

	public void L078D()
	{
		[0x462B] |= [0x00]; 0x462B;
		A = [0x0221 + X];
		[0xAF + X] = A;

		if (Z == 1)
			return this.L07FE();

		A = [0x0230 + X];
		[0xB0 + X] = A;
		A = [0x0231 + X];
		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L07B8();


		if (C == 1)
			return this.L07C1();

		A = [0x0201 + X];
		C = 1;
		A -= [0x0240 + X] + !C;
		[0x0201 + X] = A;
		A = [0x0240 + X];
		C = 0;
		A += [0x0201 + X] + C;
		return this.L07CF();
	}

	public void L07B8()
	{
		A = [0x0201 + X];
		C = 1;
		A -= [0x0240 + X] + !C;
		return this.L07CF();
	}

	public void L07C1()
	{
		A = [0x0201 + X];
		Y = A;
		A = [0x0240 + X];
		[0x0201 + X] = A;
		A = Y;
		[0x0240 + X] = A;
	}

	public void L07CF()
	{
		A &= 0x7F;
		[0x0220 + X] = A;
		C = 1;
		A -= [0x0201 + X] + !C;
		Y = [0xAF + X];
		[S--] = Y;
		X = [++S];
		C = !C;
		Cpu.ROR([0x0D]);

		if (N == 0)
			return this.L07E4();

		A ^= 0xFF;
		A++;
	}

	public void L07E4()
	{
		Y = 0x00;
		A = YA / X; Y = YA % X;
		[S--] = A;
		A = 0x00;
		A = YA / X; Y = YA % X;
		Y = [++S];
		X = [0x2C];

		if (([0x0D] & 0x80) == 0)
			return this.L07F7();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L07F7()
	{
		[0x0210 + X] = A;
		A = Y;
		[0x0211 + X] = A;
	}

	public void L07FE()
	{
		A = [0x0201 + X];
		[0x0C] = A;
		A = [0x0200 + X];
		[0x0B] = A;
	}

	public void L0808()
	{
		Y = 0x00;
		A = [0x0C];
		C = 1;
		A -= 0x34 + !C;

		if (C == 1)
			return this.L081A();

		A = [0x0C];
		C = 1;
		A -= 0x13 + !C;

		if (C == 1)
			return this.L081E();

		Y--;
		A <<= 1;
	}

	public void L081A()
	{
		YA += [0x0B] + C;
		[0x0B] = YA;
	}

	public void L081E()
	{
		[S--] = X;
		A = [0x0C];
		A <<= 1;
		Y = 0x00;
		X = 0x18;
		A = YA / X; Y = YA % X;
		X = A;
		A = [0x0893 + Y];
		[0x10] = A;
		A = [0x0892 + Y];
		[0x0F] = A;
		A = [0x0895 + Y];
		[S--] = A;
		A = [0x0894 + Y];
		Y = [++S];
		YA -= [0x0F];
		Y = [0x0B];
		YA = Y * A;
		A = Y;
		Y = 0x00;
		YA += [0x0F] + C;
		[0x10] = Y;
		A <<= 1;
		Cpu.ROL([0x10]);
		[0x0F] = A;
		return this.L0851();
	}

	public void L084D()
	{
		[0x10] <<= 1;
		Cpu.ROR(A);
		X++;
	}

	public void L0851()
	{
		C = 1; temp = X - 0x06;

		if (Z == 0)
			return this.L084D();

		[0x0F] = A;
		X = [++S];
		A = [0x0150 + X];
		Y = [0x10];
		YA = Y * A;
		[0x11] = YA;
		A = [0x0150 + X];
		Y = [0x0F];
		YA = Y * A;
		[S--] = Y;
		A = [0x0151 + X];
		Y = [0x0F];
		YA = Y * A;
		YA += [0x11] + C;
		[0x11] = YA;
		A = [0x0151 + X];
		Y = [0x10];
		YA = Y * A;
		Y = A;
		A = [++S];
		YA += [0x11] + C;
		[0x11] = YA;
		A = [0x2B];
		A &= [0x13];

		if (Z == 0)
			return this.L0891();

		A = [0x08AC + X];
		A |= 0x02;
		Y = [0x11];
		[0xF2] = YA;
		A++;
		Y = [0x12];
		[0xF2] = YA;
	}

	public void L0891()
	{
		return;
	}

	public void L08CC()
	{
		Y = 0x00;
		[0x29] = Y;
		[0xE0] = Y;
		A = [0x15 + Y];
		[0x15]++;   // 16-bit
		[S--] = A;
		A = [0x15 + Y];
		[0x15]++;   // 16-bit
		Y = A;
		A = [++S];
		return;
	}

	public void L08DE()
	{
		[0x04] = 0xFF;
		[0x2E + X]--;

		if (N == 0)
			return this.L092E();

		A = [0x30];

		if (Z == 1)
			return this.L0931();

		[0xE6] = [0x2E];
		A--;

		if (Z == 1)
			return this.L08F0();

		A--;
	}

	public void L08F0()
	{
		[0x30] = A;
		Y = 0x0C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = 0x1C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = [0x4A];

		if (Z == 1)
			return this.L0916();


		if (N == 0)
			return this.L090A();

		Y++;

		if (Z == 1)
			return this.L090E();

		Y++;
		return this.L090E();
	}

	public void L090A()
	{
		Y--;

		if (Z == 1)
			return this.L090E();

		Y--;
	}

	public void L090E()
	{
		[0x4A] = Y;
		[0x51] = Y;
		A = 0x2C;
		[0xF2] = YA;
	}

	public void L0916()
	{
		Y = [0x4C];

		if (Z == 1)
			return this.L092E();


		if (N == 0)
			return this.L0922();

		Y++;

		if (Z == 1)
			return this.L0926();

		Y++;
		return this.L0926();
	}

	public void L0922()
	{
		Y--;

		if (Z == 1)
			return this.L0926();

		Y--;
	}

	public void L0926()
	{
		[0x4C] = Y;
		[0x52] = Y;
		A = 0x3C;
		[0xF2] = YA;
	}

	public void L092E()
	{
		return this.L09D5();
	}

	public void L0931()
	{
		[0xE6] = [0x2E];
		[0x2F + X]--;

		if (Z == 0)
			return this.L092E();

	}

	public void L0938()
	{
		A = [0x7D];

		if (Z == 1)
			return this.L093F();

		return this.L0675();
	}

	public void L093F()
	{
		A = [0x05];
		[0x04] = A;
		A <<= 1;

		if (Z == 1)
			return this.L095A();

		A--;
		Y = A;
		A = 0x00;
		[0xE4] = A;
		[0x2D] = A;
		A = [0x06 + Y];
		[S--] = A;
		Y--;
		A = [0x06 + Y];
		Y = [++S];
		[0x15] = YA;
		[0x08] = 0x02;
	}

	public void L095A()
	{
		A = [0x13];
		A ^= 0xFF;
		temp = A - [0x002A];[0x002A] |= A;
		A = 0x00;
		Y = 0x00;
		this.L0F62();
		return;
	}

	public void L0969()
	{
		A = [0x05];

		if (N == 1)
			return this.L0938();

		return this.L08DE();
	}

	public void L0970()
	{
		X = 0x0E;
		[0x2B] = 0x80;
	}

	public void L0975()
	{
		A = 0x0A;
		this.L0BFF();
		A = 0x00;
		[0x01A1 + X] = A;
		[0xD0 + X] = A;
		[0x0280 + X] = A;
		[0xAF + X] = A;
		[0x0221 + X] = A;
		[0x0230 + X] = A;
		[0x0231 + X] = A;
		[0x00C0 + X] = A;
		[0x62 + X] = A;
		A--;
		[0x0271 + X] = A;
		X--;
		X--;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0975();

		A = 0x00;
		Y = 0x07;
	}

	public void L09A2()
	{
		[0x0072 + Y] = A;
		Y--;

		if (N == 0)
			return this.L09A2();

		[0x42] = A;
		[0x53] = A;
		[0x3C] = A;
		[0x38] = A;
		[0x17] = A;
		[0x56] = A;
		[0x57] = A;
		[0x71] = A;
		A = 0x70;
		[0x30] = A;
		Y = 0x0C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = 0x1C;
		[0xF2] = Y;
		[0xF3] = A;
		[0x41] = 0xC0;
		[0x3B] = 0x30;
	}

	public void L09CE()
	{
		return;
	}

	public void L09CF()
	{
		Y = [0x04];
		C = 1; temp = Y - [0x05];

		if (Z == 0)
			return this.L0969();

	}

	public void L09D5()
	{
		A = [0xE0];

		if (Z == 0)
			return this.L09E8();

		A = [0x04];

		if (Z == 1)
			return this.L09CE();

		A = [0x08];

		if (Z == 1)
			return this.L0A40();


		[0x0008]--; if (Z == 0)
			return this.L0970();

		A = 0x00;
		[0x2D] = A;
	}

	public void L09E8()
	{
		this.L08CC();

		if (Z == 0)
			return this.L0A04();

		Y = A;

		if (Z == 0)
			return this.L09F3();

		return this.L08DE();
	}

	public void L09F3()
	{
		[0x17 + X]--;

		if (N == 0)
			return this.L09F9();

		[0x17] = A;
	}

	public void L09F9()
	{
		this.L08CC();
		X = [0x17];

		if (Z == 1)
			return this.L09E8();

		[0x15] = YA;
		return this.L09E8();
	}

	public void L0A04()
	{
		[0x11] = YA;
		Y = 0x0F;
	}

	public void L0A08()
	{
		A = [0x11 + Y];
		[0x0018 + Y] = A;
		Y--;

		if (N == 0)
			return this.L0A08();

		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0A15()
	{
		A = [0x62 + X];

		if (Z == 0)
			return this.L0A38();

		A = [0x19 + X];

		if (Z == 1)
			return this.L0A38();

		A = 0x00;
		[0x8F + X] = A;
		[0x9F + X] = A;
		[0xA0 + X] = A;
		[0xCF + X] = A;
		[0x0230 + X] = A;
		[0x0221 + X] = A;
		A++;
		[0x7F + X] = A;
		A = [0x2B];
		temp = A - [0x0056];[0x0056] &= ~A;
		temp = A - [0x0057];[0x0057] &= ~A;
	}

	public void L0A38()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0A15();

		A = 0x00;
	}

	public void L0A40()
	{
		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0A45()
	{
		[0x2C] = X;
		A = [0x19 + X];

		if (Z == 1)
			return this.L0ABC();

		[0x7F]--;

		if (Z == 0)
			return this.L0AB6();

	}

	public void L0A4F()
	{
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L0A57();

		[0x19 + X]++;
	}

	public void L0A57()
	{
		Y = A;

		if (Z == 0)
			return this.L0A71();

		A = [0x8F + X];

		if (Z == 1)
			return this.L09E8();

		this.L0E8E();
		[0x8F]--;

		if (Z == 0)
			return this.L0A4F();

		A = [0x0160 + X];
		[0x18 + X] = A;
		A = [0x0161 + X];
		[0x19 + X] = A;
		return this.L0A4F();
	}

	public void L0A71()
	{

		if (N == 1)
			return this.L0A98();

		[0x0130 + X] = A;
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L0A7E();

		[0x19 + X]++;
	}

	public void L0A7E()
	{
		Y = A;

		if (N == 1)
			return this.L0A98();

		[S--] = A;
		A = (A >> 4) | (A << 4)
		A &= 0x07;
		Y = A;
		A = [0x0435 + Y];
		[0x0131 + X] = A;
		A = [++S];
		A &= 0x0F;
		Y = A;
		A = [0x043D + Y];
		[0x0140 + X] = A;
		return this.L0A4F();
	}

	public void L0A98()
	{
		C = 1; temp = A - 0xCE;

		if (C == 0)
			return this.L0AA1();

		this.L0B7B();
		return this.L0A4F();
	}

	public void L0AA1()
	{
		this.L0754();
		A = [0x0130 + X];
		[0x7F + X] = A;
		Y = A;
		A = [0x0131 + X];
		YA = Y * A;
		A = Y;

		if (Z == 0)
			return this.L0AB2();

		A++;
	}

	public void L0AB2()
	{
		[0x80 + X] = A;
		return this.L0AB9();
	}

	public void L0AB6()
	{
		this.L123E();
	}

	public void L0AB9()
	{
		this.L1057();
	}

	public void L0ABC()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0A45();

		[0x56] = [0x57];
		A = [0x3C];

		if (Z == 1)
			return this.L0AD4();

		YA = [0x3E];
		YA += [0x3A] + C;

		[0x003C]--; if (Z == 0)
			return this.L0AD2();

		YA = [0x3C];
	}

	public void L0AD2()
	{
		[0x3A] = YA;
	}

	public void L0AD4()
	{
		A = [0x53];

		if (Z == 1)
			return this.L0AED();

		YA = [0x4D];
		YA += [0x49] + C;
		[0x49] = YA;
		YA = [0x4F];
		YA += [0x4B] + C;

		[0x0053]--; if (Z == 0)
			return this.L0AEB();

		YA = [0x53];
		[0x49] = YA;
		Y = [0x55];
	}

	public void L0AEB()
	{
		[0x4B] = YA;
	}

	public void L0AED()
	{
		A = [0x42];

		if (Z == 1)
			return this.L0AFF();

		YA = [0x44];
		YA += [0x40] + C;

		[0x0042]--; if (Z == 0)
			return this.L0AFA();

		YA = [0x42];
	}

	public void L0AFA()
	{
		[0x40] = YA;
		[0x46] = 0xFF;
	}

	public void L0AFF()
	{
		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0B04()
	{
		A = [0x19 + X];

		if (Z == 1)
			return this.L0B0B();

		this.L114C();
	}

	public void L0B0B()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0B04();

		return;
	}

	public void L0B7B()
	{
		A <<= 1;
		Y = A;
		A = [0x0A77 + Y];
		[S--] = A;
		A = [0x0A76 + Y];
		[S--] = A;
		A = Y;
		A >>= 1;
		Y = A;
		A = [0x0B0A + Y];

		if (Z == 1)
			return this.L0B96();

		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L0B95();

		[0x19 + X]++;
	}

	public void L0B95()
	{
		Y = A;
	}

	public void L0B96()
	{
		return;
	}

	public void L0BFF()
	{
		A = [0x62 + X];

		if (Z == 0)
			return this.L0C06();

		A = Y;
		return this.L0C25();
	}

	public void L0C06()
	{
		A = Y;
		C = 0;
		A += [0x0290 + X] + C;

		if (N == 0)
			return this.L0C14();

		A ^= 0xFF;
		A++;
		A &= 0x9F;
		return this.L0C23();
	}

	public void L0C14()
	{
		C = 1; temp = A - 0x14;

		if (Z == 1)
			return this.L0C25();


		if (C == 0)
			return this.L0C25();

		C = 1;
		A -= 0x14 + !C;
		[0x0F] = A;
		A = 0x14;
		A -= [0x0F] + !C;
	}

	public void L0C23()
	{
		A |= 0x80;
	}

	public void L0C25()
	{
		[0x01F1 + X] = A;
		A &= 0x1F;
		[0x01D1 + X] = A;
		A = 0x00;
		[0x01D0 + X] = A;
		return;
	}

	public void L0CAF()
	{
		[0xC0 + X] = A;
		[0x0270 + X] = A;
		A = 0x00;
		[0x0260 + X] = A;
		return;
	}

	public void L0DB8()
	{
		[0x0230 + X] = A;
		[0x0221 + X] = A;
		return;
	}

	public void L0E78()
	{
		A = [0x0170 + X];
		[0x61 + X] = A;
		A = [0x0171 + X];
		[0x62 + X] = A;
		return this.L0E98();
	}

	public void L0E8E()
	{
		A = [0x0170 + X];
		[0x18 + X] = A;
		A = [0x0171 + X];
		[0x19 + X] = A;
	}

	public void L0E98()
	{
		return;
	}

	public void L0F62()
	{
		[0x49] = YA;
		[0x4B] = YA;
		[0x31] |= 0x20;
		return;
	}

	public void L0FE7()
	{
		[0x36] = A;
		Y = 0x7D;
		A &= 0x0F;
		A ^= 0xFF;

		if (([0x35] & 0x80) == 0)
			return this.L0FF5();

		C = 0;
		A += [0x35] + C;
	}

	public void L0FF5()
	{
		[0x35] = A;
		Y = 0x04;
	}

	public void L0FF9()
	{
		A = [0x038E + Y];
		[0xF2] = A;
		A = 0x00;
		[0xF3] = A;

		Y--; if (Z == 0)
			return this.L0FF9();

		A |= 0x20;
		Y = 0x6C;
		[0xF2] = Y;
		[0xF3] = A;
		A = [0x36];
		Y = 0x7D;
		[0xF2] = Y;
		[0xF3] = A;
		A <<= 1;
		A <<= 1;
		A <<= 1;
		A ^= 0xFF;
		A++;
		Y = 0x6D;
		[0xF2] = Y;
		[0xF3] = A;
		return;
	}

	public void L102B()
	{
		A = [0xAF + X];

		if (Z == 0)
			return this.L1056();

		A = [0x61 + X];
		C = 1; temp = A - 0xE7;

		if (Z == 0)
			return this.L1056();

		[0x61 + X]++;

		if (Z == 0)
			return this.L103B();

		[0x62 + X]++;
	}

	public void L103B()
	{
		Y = A;
		A = [0x19 + X];

		if (Z == 0)
			return this.L104B();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L1048();

		[0x62 + X]++;
	}

	public void L1048()
	{
		Y = A;
		return this.L1054();
	}

	public void L104B()
	{
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L1053();

		[0x19 + X]++;
	}

	public void L1053()
	{
		Y = A;
	}

	public void L1054()
	{
		return this.L1080();
	}

	public void L1056()
	{
		return;
	}

	public void L1057()
	{
		A = [0xAF + X];

		if (Z == 0)
			return this.L1056();

		A = [0x18 + X];
		C = 1; temp = A - 0xE7;

		if (Z == 0)
			return this.L1056();

		[0x18 + X]++;

		if (Z == 0)
			return this.L1067();

		[0x19 + X]++;
	}

	public void L1067()
	{
		Y = A;
		A = [0x19 + X];

		if (Z == 0)
			return this.L1077();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L1074();

		[0x62 + X]++;
	}

	public void L1074()
	{
		Y = A;
		return this.L1080();
	}

	public void L1077()
	{
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L107F();

		[0x19 + X]++;
	}

	public void L107F()
	{
		Y = A;
	}

	public void L1080()
	{
		[0xB0 + X] = A;
		A = [0x19 + X];

		if (Z == 0)
			return this.L1091();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L108E();

		[0x62 + X]++;
	}

	public void L108E()
	{
		Y = A;
		return this.L109A();
	}

	public void L1091()
	{
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L1099();

		[0x19 + X]++;
	}

	public void L1099()
	{
		Y = A;
	}

	public void L109A()
	{
		[0xAF + X] = A;
		A = [0x19 + X];

		if (Z == 0)
			return this.L10AB();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L10A8();

		[0x62 + X]++;
	}

	public void L10A8()
	{
		Y = A;
		return this.L10B4();
	}

	public void L10AB()
	{
		A = [0x18 + X];
		[0x18 + X]++;

		if (Z == 0)
			return this.L10B3();

		[0x19 + X]++;
	}

	public void L10B3()
	{
		Y = A;
	}

	public void L10B4()
	{
		C = 0;
		A += [0x38] + C;
		A += [0x0280 + X] + C;
		A &= 0x7F;
		[0x0220 + X] = A;
		C = 1;
		A -= [0x0201 + X] + !C;
		Y = [0xAF + X];
		[S--] = Y;
		X = [++S];
		C = !C;
		Cpu.ROR([0x0D]);

		if (N == 0)
			return this.L10CF();

		A ^= 0xFF;
		A++;
	}

	public void L10CF()
	{
		Y = 0x00;
		A = YA / X; Y = YA % X;
		[S--] = A;
		A = 0x00;
		A = YA / X; Y = YA % X;
		Y = [++S];
		X = [0x2C];

		if (([0x0D] & 0x80) == 0)
			return this.L10E2();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L10E2()
	{
		[0x0210 + X] = A;
		A = Y;
		[0x0211 + X] = A;
		return;
	}

	public void L10EA()
	{
		A = [0x9F + X];

		if (Z == 1)
			return this.L1116();

		A = 0xA0;
		Y = 0x01;
		[0x462B] |= [0x00]; 0x462B;
		[0x9F]--;

		if (Z == 0)
			return this.L1103();

		A = 0x00;
		[0x01A0 + X] = A;
		A = [0x01C0 + X];
		return this.L1113();
	}

	public void L1103()
	{
		C = 0;
		A = [0x01A0 + X];
		A += [0x01B0 + X] + C;
		[0x01A0 + X] = A;
		A = [0x01A1 + X];
		A += [0x01B1 + X] + C;
	}

	public void L1113()
	{
		[0x01A1 + X] = A;
	}

	public void L1116()
	{
		A = [0x01A1 + X];
		Y = A;
		A = [0x0291 + X];
		YA = Y * A;
		A = Y;
		[0x01C1 + X] = A;
		A = [0xA0 + X];

		if (Z == 1)
			return this.L114A();

		[0x462B] |= [0x00]; 0x462B;
		[0xA0]--;

		if (Z == 0)
			return this.L1137();

		A = 0x00;
		[0x01D0 + X] = A;
		A = [0x01F0 + X];
		return this.L1147();
	}

	public void L1137()
	{
		C = 0;
		A = [0x01D0 + X];
		A += [0x01E0 + X] + C;
		[0x01D0 + X] = A;
		A = [0x01D1 + X];
		A += [0x01E1 + X] + C;
	}

	public void L1147()
	{
		[0x01D1 + X] = A;
	}

	public void L114A()
	{
		return this.L11C3();
	}

	public void L114C()
	{
		A = [0xCF + X];

		if (Z == 1)
			return this.L1154();

		[0xCF]--;
		return this.L1181();
	}

	public void L1154()
	{
		A = [0x9F + X];

		if (Z == 1)
			return this.L1181();

		A = [0x0190 + X];
		[0xCF + X] = A;
		[0x462B] |= [0x00]; 0x462B;
		[0x9F]--;

		if (Z == 0)
			return this.L116E();

		A = 0x00;
		[0x01A0 + X] = A;
		A = [0x01C0 + X];
		return this.L117E();
	}

	public void L116E()
	{
		C = 0;
		A = [0x01A0 + X];
		A += [0x01B0 + X] + C;
		[0x01A0 + X] = A;
		A = [0x01A1 + X];
		A += [0x01B1 + X] + C;
	}

	public void L117E()
	{
		[0x01A1 + X] = A;
	}

	public void L1181()
	{
		Y = [0x41];
		A = [0x0140 + X];
		YA = Y * A;
		A = [0x01A1 + X];
		YA = Y * A;
		A = Y;
		YA = Y * A;
		A = Y;
		[0x01C1 + X] = A;
		A = [0xA0 + X];

		if (Z == 1)
			return this.L11C3();

		A = 0xD0;
		Y = 0x01;
		[0xA0]--;
		[S--] = P;
		[0x462B] |= [0x00]; 0x462B;
		P = [++S];
		[0x0F] = YA;
		[0x11] = YA;
		[S--] = X;
		Y = [++S];
		C = 0;

		if (Z == 0)
			return this.L11B3();

		[0x111F] += 0x00;
		A = 0x00;
		[[0x0F] +Y] = A;
		Y++;
		return this.L11BF();
	}

	public void L11B3()
	{
		[0x1110] += 0x00;
		A = [0x0F + Y];
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
		Y++;
		A = [0x0F + Y];
	}

	public void L11BF()
	{
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
	}

	public void L11C3()
	{
		A = [0x2B];
		A &= [0x46];

		if (Z == 1)
			return this.L1228();

		A = [0x01D1 + X];
		Y = A;
		A = [0x01D0 + X];
		[0x0B] = YA;
	}

	public void L11D2()
	{
		A = [0x08AC + X];
		[0x0D] = A;
	}

	public void L11D7()
	{
		Y = 0x51;
		A = [0x1439 + X];

		if (Z == 0)
			return this.L11F2();

		Y = [0x0C];
		A = [0x122A + Y];
		C = 1;
		A -= [0x1229 + Y] + !C;
		Y = [0x0B];
		YA = Y * A;
		A = Y;
		Y = [0x0C];
		C = 0;
		A += [0x1229 + Y] + C;
		Y = A;
	}

	public void L11F2()
	{
		A = [0x01C1 + X];
		YA = Y * A;
		C = 0;
		A = [0x1439 + X];

		if (Z == 0)
			return this.L1204();

		A = [0x01F1 + X];
		A <<= 1;

		if (([0x0D] & 0x01) == 0)
			return this.L1204();

		A <<= 1;
	}

	public void L1204()
	{
		A = Y;

		if (C == 0)
			return this.L120A();

		A ^= 0xFF;
		A++;
	}

	public void L120A()
	{
		Y = [0x0D];
		[S--] = A;
		A = [0x2B];
		A &= [0x13];
		A = [++S];

		if (Z == 0)
			return this.L1218();

		[0xF2] = Y;
		[0xF3] = A;
	}

	public void L1218()
	{
		Y = 0x14;
		A = 0x00;
		YA -= [0x0B];
		[0x0B] = YA;
		[0x0D]++;

		if (([0x0D] & 0x02) == 0)
			return this.L11D7();

		[0x462B] ^= [0x00];
	}

	public void L1228()
	{
		return;
	}

	public void L123E()
	{

		if (Z == 1)
			return this.L12BE();

		A = [0x80 + X];

		if (Z == 1)
			return this.L12BE();

		[0x80]--;

		if (Z == 1)
			return this.L124D();

		A = 0x02;

		C = 1; temp = A - [0x7F + X]; if (Z == 0)
			return this.L12BE();

	}

	public void L124D()
	{
		A = [0x8F + X];
		[0x12] = A;
		Y = [0x62 + X];

		if (Z == 1)
			return this.L1259();

		A = [0x61 + X];
		return this.L125D();
	}

	public void L1259()
	{
		A = [0x18 + X];
		Y = [0x19 + X];
	}

	public void L125D()
	{
		[0x0F] = YA;
		Y = 0x00;
	}

	public void L1261()
	{
		A = [0x0F + Y];

		if (Z == 1)
			return this.L1281();


		if (N == 1)
			return this.L126C();

	}

	public void L1267()
	{
		Y++;
		A = [0x0F + Y];

		if (N == 0)
			return this.L1267();

	}

	public void L126C()
	{
		C = 1; temp = A - 0xC8;

		if (Z == 1)
			return this.L12BE();

		C = 1; temp = A - 0xDD;

		if (Z == 1)
			return this.L129D();

		C = 1; temp = A - 0xCE;

		if (C == 0)
			return this.L12A8();

		[S--] = Y;
		Y = A;
		A = [++S];
		A += [0x0A8A + Y] + C;
		Y = A;
		return this.L1261();
	}

	public void L1281()
	{
		A = [0x12];

		if (Z == 1)
			return this.L12A8();

		[0x12 + X]--;

		if (Z == 0)
			return this.L1293();

		A = [0x0161 + X];
		[S--] = A;
		A = [0x0160 + X];
		Y = [++S];
		return this.L125D();
	}

	public void L1293()
	{
		A = [0x0171 + X];
		[S--] = A;
		A = [0x0170 + X];
		Y = [++S];
		return this.L125D();
	}

	public void L129D()
	{
		Y++;
		A = [0x0F + Y];
		[S--] = A;
		Y++;
		A = [0x0F + Y];
		Y = A;
		A = [++S];
		return this.L125D();
	}

	public void L12A8()
	{
		A = [0x57];
		A &= [0x2B];

		if (Z == 0)
			return this.L12BE();

		A = [0x2B];
		Y = 0x5C;
		[S--] = A;
		A = [0x2B];
		A &= [0x13];
		A = [++S];

		if (Z == 0)
			return this.L12BE();

		[0xF2] = Y;
		[0xF3] = A;
	}

	public void L12BE()
	{
		[0x0E] &= ~0x80;
		A = [0xAF + X];

		if (Z == 1)
			return this.L12F7();

		A = [0xB0 + X];

		if (Z == 1)
			return this.L12CC();

		[0xB0]--;
		return this.L12F7();
	}

	public void L12CC()
	{
		[0x0E] |= 0x80;
		A = 0x00;
		Y = 0x02;
		[0xAF]--;
		[0x0F] = YA;
		[0x11] = YA;
		[S--] = X;
		Y = [++S];
		C = 0;

		if (Z == 0)
			return this.L12E7();

		[0x111F] += 0x00;
		A = 0x00;
		[[0x0F] +Y] = A;
		Y++;
		return this.L12F3();
	}

	public void L12E7()
	{
		[0x1110] += 0x00;
		A = [0x0F + Y];
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
		Y++;
		A = [0x0F + Y];
	}

	public void L12F3()
	{
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
	}

	public void L12F7()
	{
		A = [0x0201 + X];
		[0x0C] = A;
		A = [0x0200 + X];
		[0x0B] = A;
		A = [0xC0 + X];

		if (Z == 1)
			return this.L1359();

		A = [0x0251 + X];

		C = 1; temp = A - [0xBF + X]; if (Z == 0)
			return this.L1357();

		A = [0x0090 + X];
		C = 1; temp = A - [0x0260 + X];

		if (Z == 0)
			return this.L1318();

		A = [0x0270 + X];
		return this.L1323();
	}

	public void L1318()
	{
		[0x90 + X]++;
		Y = A;

		if (Z == 1)
			return this.L131F();

		A = [0xC0 + X];
	}

	public void L131F()
	{
		C = 0;
		A += [0x0261 + X] + C;
	}

	public void L1323()
	{
		[0xC0 + X] = A;
		A = [0x0241 + X];
		C = 0;
		A += [0x0250 + X] + C;
		[0x0241 + X] = A;
	}

	public void L132F()
	{
		[0x0D] = A;
		A <<= 1;
		A <<= 1;

		if (C == 0)
			return this.L1337();

		A ^= 0xFF;
	}

	public void L1337()
	{
		Y = A;
		A = [0xC0 + X];
		C = 1; temp = A - 0xF1;

		if (C == 0)
			return this.L1343();

		A &= 0x0F;
		YA = Y * A;
		return this.L1347();
	}

	public void L1343()
	{
		YA = Y * A;
		A = Y;
		Y = 0x00;
	}

	public void L1347()
	{

		if (([0x0D] & 0x80) == 0)
			return this.L1350();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L1350()
	{
		YA += [0x0B] + C;
		[0x0B] = YA;
	}

	public void L1354()
	{
		return this.L0808();
	}

	public void L1357()
	{
		[0xBF + X]++;
	}

	public void L1359()
	{

		if (([0x0E] & 0x80) != 0)
			return this.L1354();

		return;
	}

	public void L135D()
	{
		[0x0E] &= ~0x80;
		A = [0x01D1 + X];
		Y = A;
		A = [0x01D0 + X];
		[0x0B] = YA;
		A = [0xA0 + X];

		if (Z == 1)
			return this.L1376();

		A = [0x01E1 + X];
		Y = A;
		A = [0x01E0 + X];
		this.L13B2();
	}

	public void L1376()
	{

		if (([0x0E] & 0x80) == 0)
			return this.L137C();

		this.L11D2();
	}

	public void L137C()
	{
		[0x0E] &= ~0x80;
		A = [0x0201 + X];
		[0x0C] = A;
		A = [0x0200 + X];
		[0x0B] = A;
		A = [0xAF + X];

		if (Z == 1)
			return this.L139A();

		A = [0xB0 + X];

		if (Z == 0)
			return this.L139A();

		A = [0x0211 + X];
		Y = A;
		A = [0x0210 + X];
		this.L13B2();
	}

	public void L139A()
	{
		A = [0xC0 + X];

		if (Z == 1)
			return this.L1359();

		A = [0x0251 + X];

		C = 1; temp = A - [0xBF + X]; if (Z == 0)
			return this.L1359();

		Y = [0x39];
		A = [0x0250 + X];
		YA = Y * A;
		A = Y;
		C = 0;
		A += [0x0241 + X] + C;
		return this.L132F();
	}

	public void L13B2()
	{
		[0x0E] |= 0x80;
		[0x0D] = Y;

		if (([0x0D] & 0x80) == 0)
			return this.L13BF();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L13BF()
	{
		[S--] = Y;
		Y = [0x39];
		YA = Y * A;
		[0x0F] = Y;
		[0x10] = 0x00;
		Y = [0x39];
		A = [++S];
		YA = Y * A;
		YA += [0x0F] + C;

		if (([0x0D] & 0x80) == 0)
			return this.L13D7();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L13D7()
	{
		YA += [0x0B] + C;
		[0x0B] = YA;
		return;
	}

	public void L13DC()
	{
		A = [0x2B];
		A &= [0x28];

		if (Z == 1)
			return this.L1428();

		A = [0x08AC + X];
		A |= 0x08;
		[0xF2] = A;
		A = [0xF3];

		if (Z == 0)
			return this.L1428();

		A = [0x2B];
		temp = A - [0x0056];[0x0056] &= ~A;
		temp = A - [0x0057];[0x0057] &= ~A;
		temp = A - [0x00E8];[0x00E8] &= ~A;
		A = 0x00;
		[0x0281 + X] = A;
		[0x80 + X] = A;
		[0xA0 + X] = A;
		[0x9F + X] = A;
		[0x8F + X] = A;
		[0x0280 + X] = A;
		[0xD0 + X] = A;
		[0x01D0 + X] = A;
		this.L0DB8();
		[0x0231 + X] = A;
		[0x00B0 + X] = A;
		this.L0CAF();
		A = 0x02;
		[0x7F + X] = A;
		A = 0x0A;
		[0x01F1 + X] = A;
		[0x01D1 + X] = A;
		[0x282B] ^= [0x00];
	}

	public void L1428()
	{
		return;
	}

}
