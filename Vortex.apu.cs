public class ApuProgram
{
	public void L02B0()
	{
		// Value1439 = 0;
		A = 0x00;
		[0x1439] = A;
	}

	public void L02B5_Reset()
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

	public void L02BC_Loop()
	{
		[X++] = A;

		if (Z == 0)
			return this.L02BC_Loop();

		// Clear RAM 0x0100 - 0x01FF
		X = A;
	}

	public void L02C2_Loop()
	{
		[0x0100 + X] = A;
		C = 1; temp = X - 0xB0;

		if (C == 1)
			return this.L02CC_Skip();

		// Clear RAM 0x02B0 - 0x02FF
		[0x0200 + X] = A;
	}

	public void L02CC_Skip()
	{
		X++;

		if (Z == 0)
			return this.L02C2_Loop();

		// Reset I/O Ports
		Y = A;
		[0xF4] = YA;
		[0xF6] = YA;

		A++;

		this.L0FE7_SetValue36();

		[0x31] |= 0x20;

		// Dsp.Directory = 0x1500;
		A = 0x15;
		Y = 0x5D;
		[0xF2] = Y;
		[0xF3] = A;

		[0xF1] = 0xF0;

		// Timer 1/2 = 0x10 (500 ticks per second)
		A = 0x10;
		[0xFA] = A;
		[0xFB] = A;
		[0x3B] = A;
		[0xF1] = 0x03;
		[0xF4] = 0x02;
		[0xF5] = 0x00;

		// Value06 = Value06DF;
		A = [0x06DF + X];
		Y = [0x06E0];
		[0x06] = YA;

		// Value2F = 2;
		[0x2F] = 0x02;
	}

	public void L0301_MainLoop()
	{
		Y = 0x0A;
	}

	public void L0303_Loop()
	{
		// Update DSP Registers
		C = 1; temp = Y - 0x05;

		if (Z == 1)
			return this.L030E();

		if (C == 1)
			return this.L0311();

		C = 1; temp = [0x36] - [0x35];

		if (Z == 0)
			return this.L031D_Skip();
	}

	public void L030E()
	{
		if (([0x35] & 0x80) != 0)
			return this.L031D_Skip();
	}

	public void L0311()
	{	
		// ValueF2_DSPAddress = Table038E[Y];
		A = [0x038E + Y];
		[0xF2] = A;

		// X = Table0398[Y];
		A = [0x0398 + Y];
		X = A;

		// ValueF3_DSPData = [X];
		A = [X];
		[0xF3] = A;
	}

	public void L031D_Skip()
	{
		Y--; if (Z == 0)
			return this.L0303_Loop();

		[0x29] = Y;
		[0x2A] = Y;
	}

	public void L0323_Wait()
	{
		// Y = Timer 2 Counter (Resets Counter)
		Y = [0xFE];

		if (Z == 1)
			return this.L0323_Wait();

		// Value58 += Timer 2 Counter * 0x30;
		A = 0x30;
		YA = Y * A;
		C = 0;
		A += [0x58] + C;
		[0x58] = A;

		if (C == 0)
			return this.L0334_Wait();

		this.L03A3_HandleTimer2Events();
	}

	public void L0334_Wait()
	{
		// Y = Timer 1 Counter (Resets Counter)
		Y = [0xFD];

		if (Z == 1)
			return this.L0334_Wait();

		Stack.Push(Y);

		// Value14 += Timer 1 Counter * 0x40;
		A = 0x40;
		YA = Y * A;
		C = 0;
		A += [0x14] + C;
		[0x14] = A;

		if (C == 0)
			return this.L035B_Skip();
	}

	public void L0343_Wait()
	{
		YA = [0xF4];
		C = 1; temp = YA - [0xF4];

		if (Z == 0)
			return this.L0343_Wait();

		C = 1; temp = YA - [0x00];

		if (Z == 1)
			return this.L0354_Skip();

		[0x00] = YA;
		[0xF4] = YA;

		this.L0469_HandleCommand();
	}

	public void L0354_Skip()
	{
		C = 1; temp = [0x36] - [0x35];

		if (Z == 1)
			return this.L035B_Skip();

		[0x35]++;
	}

	public void L035B_Skip()
	{
		Y = Stack.Pop();
		A = [0x3B];
		YA = Y * A;
		C = 0;
		A += [0x39] + C;
		[0x39] = A;

		if (C == 0)
			return this.L036B();

		this.L09CF();

		return this.L0301_MainLoop();
	}

	public void L036B()
	{
		A = [0x05];

		if (Z == 1)
			return this.L0301_MainLoop();

		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0374_Loop()
	{
		A = [0x19 + X];

		if (Z == 1)
			return this.L037B_Skip();

		this.L135D();
	}

	public void L037B_Skip()
	{
		X++;
		X++;
		[0x2B] <<= 1;
		A = [0x19 + X];

		if (Z == 1)
			return this.L0386_Skip();

		this.L135D();
	}

	public void L0386_Skip()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0374_Loop();

		return this.L0301_MainLoop();
	}

	public byte[] L038E = new byte[]
	{
		0x03,	// = 0x5C
		0x2C,	// = 0x4A
		0x3C,	// = 0x47
		0x0D,	// = 0x33
		0x4D,	// = 0x31
		0x6C,	// = 0x29
		0x4C,	// = 0x09
		0x5C,	// = 0x32
		0x3D,	// = 0x34
		0x2D	// = 0x2A
	}

	public byte[] L0398 = new byte[]
	{
		0x5C,
		0x4A,
		0x47,
		0x33,
		0x31,
		0x29,
		0x09,
		0x32,
		0x34,
		0x2A
	}

	public void L03A3_HandleTimer2Events()
	{
		// A = Value13;
		A = [0x13];

		if (Z == 1)
			return this.L03AA_Skip();

		this.L0718_HandleTimer2Events();
	}

	public void L03AA_Skip()
	{
		Y = [0x71];

		if (Z == 1)
			return this.L0423_Done();
	}

	public void L03AE()
	{
		Y--;
		Stack.Push(Y);
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

	public void L03C5_Loop()
	{
		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L03CD_Skip();

		[0x62 + X]++;
	}

	public void L03CD_Skip()
	{
		Y = A;

		if (Z == 0)
			return this.L03E7_Skip();

		A = [0x8F + X];

		if (Z == 1)
			return this.L0424_Skip();

		this.L0E78();

		[0x8F]--;

		if (Z == 0)
			return this.L03C5_Loop();

		A = [0x0160 + X];
		[0x61 + X] = A;
		A = [0x0161 + X];
		[0x62 + X] = A;

		return this.L03C5_Loop();
	}

	public void L03E7_Skip()
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

		return this.L03C5_Loop();
	}

	public void L03FE()
	{
		this.L0748_HandleNote();

		A = [0x0130 + X];
		[0x7F + X] = A;
		[0x80 + X] = A;

		return this.L040D_Skip();
	}

	public void L040A()
	{
		this.L123E();
	}

	public void L040D_Skip()
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
			return this.L041F_Skip();

		this.L0615_FadeVolume();
	}

	public void L041F_Skip()
	{
		A = Stack.Pop();
		Y = A;

		if (Z == 0)
			return this.L03AE();
	}

	public void L0423_Done()
	{
		return;
	}

	public void L0424_Skip()
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
		Stack.Push(A);
		A = [0x0A76 + Y];
		Stack.Push(A);
		A = Y;
		A >>= 1;
		Y = A;
		A = [0x0B0A + Y];

		if (Z == 1)
			return this.L0468_Done();

		A = [0x61 + X];
		[0x61 + X]++;

		if (Z == 0)
			return this.L0467_Done();

		[0x62 + X]++;
	}

	public void L0467_Done()
	{
		Y = A;
	}

	public void L0468_Done()
	{
		return;
	}

	public void L0469_HandleCommand()
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

	public byte[] L0477 = new byte[]
	{
		0x59, 0x06,		// L0659
		0x87, 0x04,		// L0487
		0x98, 0x04,		// L0498
		0xB1, 0x05,		// L05B1
		0xD8, 0x04,		// L04D8
		0xE0, 0x04,		// L04E0
		0xA8, 0x04,		// L04A8
		0xE5, 0x05		// L05E5
	}

	public void L0487()
	{
		[0x05] = [0x00];
		A = 0xFF;
		[0x04] = A;
		A = [0x2C];
		A >>= 1;
		[0xE6] = A;
		A = 0x02;
		[0x2F] = A;

		return;
	}

	public void L0498()
	{
		A = [0x00];
		[0xE6] = A;
		A = 0x01;
		[0x7D] = A;
		A = 0x7E;
		[0x05] = A;
		[0x2F] = 0x02;

		return;
	}

	public void L04A8()
	{
		A = [0x1439 + X];
		A ^= 0x01;
		[0x1439] = A;

		if (Z == 1)
			return this.L04CC();

		A = [0x4A];
		A |= [0x4C];

		if (Z == 1)
			return this.L04D7_Done();

		A = [0x4A];

		if (N == 0)
			return this.L04C1();

		A ^= 0xFF;
		A++;
		[0x4A] = A;
	}

	public void L04C1()
	{
		A = [0x4C];

		if (N == 0)
			return this.L04D4();

		A ^= 0xFF;
		A++;
		[0x4C] = A;

		return this.L04D4();
	}

	public void L04CC()
	{
		A = [0x51];
		[0x4A] = A;
		A = [0x52];
		[0x4C] = A;
	}

	public void L04D4()
	{
		[0x46] = 0xFF;
	}

	public void L04D7_Done()
	{
		return;
	}

	public void L04D8()
	{
		A = [0x00];
		C = 0;
		A += [0x7E] + C;
		[0x3B] = A;

		return;
	}

	public void L04E0()
	{
		X = [0x2C];
		A = [0x19 + X];
		[0x10] = A;
		[0x0D] = A;

		if (Z == 1)
			return this.L04F4();

		C = 1; temp = X - 0x02;

		if (Z == 1)
			return this.L04F1();

		return this.L05B0_Done();
	}

	public void L04F1()
	{
		return this.L06E1();
	}

	public void L04F4()
	{
		A = [0x00];

		if (([0x00] & 0x40) == 0)
			return this.L052D();

		A &= 0xBF;
		[0x0F] = A;
		X = 0x00;
	}

	public void L04FF()
	{
		X--;

		if (Z == 1)
			return this.L052D();
	}

	public void L0502()
	{
		YA = [0xF6];
		C = 1; temp = YA - [0xF6];

		if (Z == 0)
			return this.L0502();

		C = 1; temp = YA - [0x02];

		if (Z == 1)
			return this.L04FF();

		[0x02] = YA;
		[0xF6] = YA;
		A ^= 0xFF;
		[0xE3] = A;
		A = Y;

		if (N == 0)
			return this.L051C();

		A ^= 0xFF;
		A++;
		[0x0D] |= 0x80;
	}

	public void L051C()
	{
		X = 0x06;
		Y = 0x00;
		A = YA / X; Y = YA % X;

		if (([0x0D] & 0x80) != 0)
			return this.L0527();

		A ^= 0xFF;
		A++;
	}

	public void L0527()
	{
		[0xE2] = A;
		A = [0x0F];

		return this.L0536();
	}

	public void L052D()
	{
		A = 0xFF;
		[0xE3] = A;
		A++;
		[0xE2] = A;
		A = [0x00];
	}

	public void L0536()
	{
		X = [0x2C];
		Y = [0x2C];
		C = 1; temp = X - 0x0C;

		if (Z == 0)
			return this.L0542();

		[0xE4] = A;

		return this.L0559();
	}

	public void L0542()
	{
		A = [0x0271 + X];

		if (N == 1)
			return this.L0559();

		[0x10]++;
		X--;
		X--;
		A = [0xE4];

		if (Z == 1)
			return this.L0559();

		A &= 0x0F;
		C = 1; temp = A - 0x02;

		if (Z == 1)
			return this.L0559();

		[0x10 + X]--;
		X++;
		X++;
	}

	public void L0559()
	{
		A = [0x00];
		A &= 0xBF;
		A <<= 1;

		if (C == 1)
			return this.L0571();

		C = 1; temp = A - [0x0271 + X];

		if (Z == 1)
			return this.L057A();

		if (C == 0)
			return this.L057A();

		A = [0x10];

		if (Z == 1)
			return this.L05B0_Done();

		[0x10 + X]--;
		X++;
		X++;

		return this.L0559();
	}

	public void L0571()
	{
		Stack.Push(A);
		A = 0x00;
		[0x0271 + X] = A;
		A = Stack.Pop();

		return this.L057D_UpdateKeyOff();
	}

	public void L057A()
	{
		[0x0271 + X] = A;
	}

	public void L057D_UpdateKeyOff()
	{
		[0x0F] = A;
		A = [0xE2];
		[0x0290 + X] = A;
		A = [0xE3];
		[0x0291 + X] = A;
		A = [0x02A0 + Y];
		C = 0;
		A += [0x0F] + C;
		[0x0F] = A;
		A = [0x02A1 + Y];
		A += [0x09] + C;
		[0x10] = A;
		Y = 0x00;
		A = [[0x0F] + Y];
		[0x61 + X] = A;
		Y++;
		A = [[0x0F] + Y];
		[0x62 + X] = A;

		// A = Table08BC_ChannelTable[X];
		A = [0x08BC + X];

		// DSPKeyOff = A;
		Y = 0x5C;
		[0xF2] = Y;
		[0xF3] = A;

		// Value28 |= A
		A |= [0x28];
		[0x28] = A;
	}

	public void L05B0_Done()
	{
		return;
	}

	public void L05B1()
	{
		X = [0x2C];
		A = [0x19 + X];

		if (Z == 0)
			return this.L05D4_Done();

		// A = Table08BC_ChannelTable[X];
		A = [0x08BC + X];
		A &= [0xE8];

		if (Z == 1)
			return this.L05D4_Done();

		A = [0x0281 + X];
		Y = A;
		A = 0x00;
		[0xD0 + X] = A;
		A = [0x00];
		A >>= 1;
		Cpu.ROR([0xD0 + X]);
		A >>= 1;
		Cpu.ROR([0xD0 + X]);
		[0x0280 + X] = A;

		this.L0748_HandleNote();
	}

	public void L05D4_Done()
	{
		return;
	}

	public void L05D5()
	{
		A = 0xFF;
		[0xE3] = A;
		A++;
		[0xE2] = A;
		A = 0x0C;
		X = 0x0E;
		Y = 0x0E;

		return this.L057A();
	}

	public void L05E5()
	{
		C = 1; temp = [0x + 01] - 0x00;

		if (Z == 1)
			return this.L062D();

		[0xDF] = 0x01;
		C = 1; temp = [0x + 02] - 0x00;

		if (Z == 1)
			return this.L05F5();

		[0xE7] = 0x00;
	}

	public void L05F5()
	{
		[0xE7] = 0x25;

		return this.L05D5();
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

	public void L0615_FadeVolume()
	{
		// Value30 -= 1;
		[0x30]--;

		// Volume = [0x30];
		A = [0x30];
		Y = 0x0C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = 0x1C;
		[0xF2] = Y;
		[0xF3] = A;

		// if (Volume == ValueE7) skip;
		C = 1; temp = A - [0xE7];

		if (Z == 0)
			return this.L062C_Done();

		// ValueDF = 0;
		[0xDF] = 0x00;
	}

	public void L062C_Done()
	{
		return;
	}

	public void L0659()
	{
		[0xE0] = [0x00];
		[0x2B] = 0x01;
		X = 0x00;
	}

	public void L0661()
	{
		A = [0x62 + X];

		if (Z == 0)
			return this.L0668();

		[0xE1] |= [0x2B];
	}

	public void L0668()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0661();

		A = 0x5C;
		Y = [0xE1];
		[0xF2] = YA;

		return;
	}

	public void L0675_LoadData()
	{
		// DSPFlags = 0x20;
		[0xF2] = 0x6C;
		[0xF3] = 0x20;

		// I/O Port 0 = 0xAA
		[0xF4] = 0xAA;
		// I/O Port 1 = 0xBB
		[0xF5] = 0xBB;
	}

	public void L0681_Wait()
	{
		A = [0xF4];
		C = 1; temp = A - [0xF4];

		if (Z == 0)
			return this.L0681_Wait();

		C = 1; temp = A - 0xCC;

		if (Z == 0)
			return this.L0681_Wait();

		return this.L06A8();
	}

	public void L068D_ReadData()
	{
		// while (I/O Port 0 != 0) Wait;
		Y = [0xF4];

		if (Z == 0)
			return this.L068D_ReadData();
	}

	public void L0691_Loop()
	{
		// while (I/O Port 0 == Y) ReadByte;
		C = 1; temp = Y - [0xF4];

		if (Z == 0)
			return this.L06A2();

		// Word7A_WriteAddress[Y++] = I/O Port 1;
		A = [0xF5];
		[0xF4] = Y;

		[[0x7A] + Y] = A;
		Y++;

		if (Z == 0)
			return this.L0691_Loop();

		[0x7B]++;

		return this.L0691_Loop();
	}

	public void L06A2()
	{
		// if (Y > I/O Port) Loop;
		if (N == 0)
			return this.L0691_Loop();

		C = 1; temp = Y - [0xF4];

		if (N == 0)
			return this.L0691_Loop();
	}

	public void L06A8()
	{
		// Word7A_WriteAddress = I/O Port 2
		YA = [0xF6];
		[0x7A] = YA;

		YA = [0xF4];
		[0xF4] = A;
		A = Y;
		X = A;

		if (Z == 0)
			return this.L068D_ReadData();
	}

	public void L06B4_Wait()
	{
		// while(I/O Port 0 != 0) Wait;
		YA = [0xF4];

		if (Z == 0)
			return this.L06B4_Wait();

		[0x00] = YA;
		[0xF4] = YA;
	}

	public void L06BC_Wait()
	{
		// while(I/O Port 2 != 0) Wait;
		YA = [0xF6];

		if (Z == 0)
			return this.L06BC_Wait();

		[0x02] = YA;
		[0xF6] = YA;

		// DSPKeyOff = 0xFF;
		A = 0x5C;
		Y = 0xFF;
		[0xF2] = YA;

		// DSPEchoVolume = 0;
		Y = 0x00;
		A = 0x2C;
		[0xF2] = YA;

		A = 0x3C;
		[0xF2] = YA;

		// Value06DF = Word7A_WriteAddress
		YA = [0x7A];
		[0x06DF] = A;
		[0x06E0] = Y;

		return this.L02B5_Reset();
	}

	public byte[] Value06DF = new byte[2];

	public void L0718_HandleTimer2Events()
	{
		// A = DSPChannel1Envelope
		[0xF2] = 0x18;
		A = [0xF3];

		if (Z == 0)
			return this.L0747_Done();

		X = 0x02;
		A = [0x0281 + X];
		C = 1; temp = A - 0xC5;

		if (Z == 1)
			return this.L0741();

		C = 1; temp = A - 0xC0;

		if (Z == 1)
			return this.L0730_Skip();

		A = 0xC0;

		return this.L0732_UpdateKeyOn();
	}

	public void L0730_Skip()
	{
		A = 0xC5;
	}

	public void L0732_UpdateKeyOn()
	{
		Y = A;

		this.L0748_HandleNote();

		// A = Table08BC_ChannelTable[X]
		A = [0x08BC + X];

		// DSPKeyOn = A;
		Y = 0x4C;
		[0xF2] = Y;
		[0xF3] = A;

		return this.L0747_Done();
	}

	public void L0741()
	{
		[0x46] = [0x13];
		[0x13] = 0x00;
	}

	public void L0747_Done()
	{
		return;
	}

	public void L0748_HandleNote()
	{
		C = 1; temp = Y - 0xC8;

		if (C == 1)
			return this.L0747_Done();

		A = Y;
		[0x0281 + X] = A;
		A &= 0x7F;

		return this.L0767_Skip();
	}

	public void L0754_HandleNote()
	{
		C = 1; temp = Y - 0xC8;

		if (C == 1)
			return this.L0747_Done();

		[0xE9] |= [0x2B];
		A = [0x13];
		A &= [0x2B];

		if (Z == 0)
			return this.L0747_Done();

		A = Y;
		A &= 0x7F;
		C = 0;
		A += [0x38] + C;
	}

	public void L0767_Skip()
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
			return this.L078D_Skip();

		[0x29] |= [0x2B];
	}

	public void L078D_Skip()
	{
		[0x46] |= [0x2B];
		A = [0x0221 + X];
		[0xAF + X] = A;

		if (Z == 1)
			return this.L07FE_Skip();

		A = [0x0230 + X];
		[0xB0 + X] = A;
		A = [0x0231 + X];
		C = 1; temp = A - 0x01;

		if (Z == 1)
			return this.L07B8_Skip();

		if (C == 1)
			return this.L07C1_Skip();

		A = [0x0201 + X];
		C = 1;
		A -= [0x0240 + X] + !C;
		[0x0201 + X] = A;
		A = [0x0240 + X];
		C = 0;
		A += [0x0201 + X] + C;

		return this.L07CF_Skip();
	}

	public void L07B8_Skip()
	{
		A = [0x0201 + X];
		C = 1;
		A -= [0x0240 + X] + !C;

		return this.L07CF_Skip();
	}

	public void L07C1_Skip()
	{
		A = [0x0201 + X];
		Y = A;
		A = [0x0240 + X];
		[0x0201 + X] = A;
		A = Y;
		[0x0240 + X] = A;
	}

	public void L07CF_Skip()
	{
		A &= 0x7F;
		[0x0220 + X] = A;
		C = 1;
		A -= [0x0201 + X] + !C;
		Y = [0xAF + X];
		Stack.Push(Y);
		X = Stack.Pop();
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
		Stack.Push(A);
		A = 0x00;
		A = YA / X; Y = YA % X;
		Y = Stack.Pop();
		X = [0x2C];

		if (([0x0D] & 0x80) == 0)
			return this.L07F7_Skip();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L07F7_Skip()
	{
		[0x0210 + X] = A;
		A = Y;
		[0x0211 + X] = A;
	}

	public void L07FE_Skip()
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
		Stack.Push(X);
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
		Stack.Push(A);
		A = [0x0894 + Y];
		Y = Stack.Pop();
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

		return this.L0851_Skip();
	}

	public void L084D()
	{
		[0x10] <<= 1;
		Cpu.ROR(A);
		X++;
	}

	public void L0851_Skip()
	{
		C = 1; temp = X - 0x06;

		if (Z == 0)
			return this.L084D();

		[0x0F] = A;
		X = Stack.Pop();
		A = [0x0150 + X];
		Y = [0x10];
		YA = Y * A;
		[0x11] = YA;
		A = [0x0150 + X];
		Y = [0x0F];
		YA = Y * A;
		Stack.Push(Y);
		A = [0x0151 + X];
		Y = [0x0F];
		YA = Y * A;
		YA += [0x11] + C;
		[0x11] = YA;
		A = [0x0151 + X];
		Y = [0x10];
		YA = Y * A;
		Y = A;
		A = Stack.Pop();
		YA += [0x11] + C;
		[0x11] = YA;
		A = [0x2B];
		A &= [0x13];

		if (Z == 0)
			return this.L0891_Done();

		A = [0x08AC + X];
		A |= 0x02;
		Y = [0x11];
		[0xF2] = YA;
		A++;
		Y = [0x12];
		[0xF2] = YA;
	}

	public void L0891_Done()
	{
		return;
	}

	public byte[] L08AC = new byte[]
	{
		0x00, 0x00,
		0x10, 0x00,
		0x20, 0x00,
		0x30, 0x00,
		0x40, 0x00,
		0x50, 0x00,
		0x60, 0x00,
		0x70, 0x00,
		0x01, 0x00,
		0x02, 0x00,
		0x04, 0x00,
		0x08, 0x00,
		0x10, 0x00,
		0x20, 0x00,
		0x40, 0x00,
		0x80, 0x00
	}

	public void L08CC_GetWord15()
	{
		Y = 0x00;
		[0x29] = Y;
		[0xE0] = Y;
		A = [0x15 + Y];
		[0x15]++;   // 16-bit
		Stack.Push(A);
		A = [0x15 + Y];
		[0x15]++;   // 16-bit
		Y = A;
		A = Stack.Pop();

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

		[0x2E] = [0xE6];
		A--;

		if (Z == 1)
			return this.L08F0_UpdateVolumeAndEcho();

		A--;
	}

	public void L08F0_UpdateVolumeAndEcho()
	{
		// DSPVolume = Value30;
		[0x30] = A;
		Y = 0x0C;
		[0xF2] = Y;
		[0xF3] = A;
		Y = 0x1C;
		[0xF2] = Y;
		[0xF3] = A;

		// Y = Value4A_EchoVolumeLeft
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

		// DSPEchoVolumeLeft = Y;
		A = 0x2C;
		[0xF2] = YA;
	}

	public void L0916()
	{
		// Y = Value4C_EchoVolumeRight
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

		// DSPEchoVolumeRight = Y;
		A = 0x3C;
		[0xF2] = YA;
	}

	public void L092E()
	{
		return this.L09D5();
	}

	public void L0931()
	{
		[0x2E] = [0xE6];
		[0x2F + X]--;

		if (Z == 0)
			return this.L092E();
	}

	public void L0938()
	{
		A = [0x7D];

		if (Z == 1)
			return this.L093F_Skip();

		return this.L0675_LoadData();
	}

	public void L093F_Skip()
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
		Stack.Push(A);
		Y--;
		A = [0x06 + Y];
		Y = Stack.Pop();
		[0x15] = YA;
		[0x08] = 0x02;
	}

	public void L095A()
	{
		A = [0x13];
		A ^= 0xFF;
		temp = A - [0x002A]; [0x002A] |= A;
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

		// Volume = 0x70 (50%)
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

	public void L09CE_Done()
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
			return this.L09CE_Done();

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
		this.L08CC_GetWord15();

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
		this.L08CC_GetWord15();

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
		temp = A - [0x0056]; [0x0056] &= ~A;
		temp = A - [0x0057]; [0x0057] &= ~A;
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

	public void L0A4F_Loop()
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
			return this.L0A4F_Loop();

		A = [0x0160 + X];
		[0x18 + X] = A;
		A = [0x0161 + X];
		[0x19 + X] = A;

		return this.L0A4F_Loop();
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

		Stack.Push(A);
		A = (A >> 4) | (A << 4)
		A &= 0x07;
		Y = A;
		A = [0x0435 + Y];
		[0x0131 + X] = A;
		A = Stack.Pop();
		A &= 0x0F;
		Y = A;
		A = [0x043D + Y];
		[0x0140 + X] = A;

		return this.L0A4F_Loop();
	}

	public void L0A98()
	{
		C = 1; temp = A - 0xCE;

		if (C == 0)
			return this.L0AA1_Skip();

		this.L0B7B_HandleEventCE();

		return this.L0A4F_Loop();
	}

	public void L0AA1_Skip()
	{
		this.L0754_HandleNote();
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

		[0x57] = [0x56];
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
			return this.L0AFF_Skip();

		YA = [0x44];
		YA += [0x40] + C;

		[0x0042]--; if (Z == 0)
			return this.L0AFA_Skip();

		YA = [0x42];
	}

	public void L0AFA_Skip()
	{
		[0x40] = YA;
		[0x46] = 0xFF;
	}

	public void L0AFF_Skip()
	{
		X = 0x00;
		[0x2B] = 0x01;
	}

	public void L0B04_Loop()
	{
		A = [0x19 + X];

		if (Z == 1)
			return this.L0B0B_Skip();

		this.L114C();
	}

	public void L0B0B_Skip()
	{
		X++;
		X++;
		[0x2B] <<= 1;

		if (Z == 0)
			return this.L0B04_Loop();

		return;
	}

	public void L0B7B_HandleEventCE()
	{
		A <<= 1;
		Y = A;
		A = [0x0A77 + Y];
		Stack.Push(A);
		A = [0x0A76 + Y];
		Stack.Push(A);
		A = Y;
		A >>= 1;
		Y = A;
		A = [0x0B0A + Y];

		if (Z == 1)
			return this.L0B96_Done();

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

	public void L0B96_Done()
	{
		return;
	}

	public void L0BAF()
	{
		Y = 0x06;
		YA = Y * A;
		[0x0F] = YA;
		C = 0;
		[0x0F] += 0x7B;
		[0x10] += 0x14;
		A = [0x13];
		A &= [0x2B];

		if (Z == 0)
			return this.L0BFE();

		Stack.Push(X);
		A = [0x08AC + X];
		A |= 0x04;
		X = A;
		Y = 0x00;
		A = [[0x0F] + Y];

		if (N == 0)
			return this.L0BE1();

		A &= 0x1F;
		[0x31] &= 0x20;
		temp = A - [0x0031];[0x0031] |= A;
		[0x32] |= [0x2B];
		Y = 0x04;
		A = [[0x0F] + Y];
		Y = 0x00;
		return this.L0BE8();
	}

	public void L0BE1()
	{
		A = [0x2B];
		temp = A - [0x0032];[0x0032] &= ~A;
	}

	public void L0BE6()
	{
		A = [[0x0F] + Y];
	}

	public void L0BE8()
	{
		[0xF2] = X;
		[0xF3] = A;
		X++;
		Y++;
		C = 1; temp = Y - 0x04;

		if (Z == 0)
			return this.L0BE6();

		X = Stack.Pop();
		A = [[0x0F] + Y];
		[0x0151 + X] = A;
		Y++;
		A = [[0x0F] + Y];
		[0x0150 + X] = A;
	}

	public void L0BFE()
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

		return this.L0E98_Done();
	}

	public void L0E8E()
	{
		A = [0x0170 + X];
		[0x18 + X] = A;
		A = [0x0171 + X];
		[0x19 + X] = A;
	}

	public void L0E98_Done()
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

	public void L0FE7_SetValue36()
	{
		[0x36] = A;
		Y = 0x7D;
		A &= 0x0F;
		A ^= 0xFF;

		if (([0x35] & 0x80) == 0)
			return this.L0FF5_Skip();

		C = 0;
		A += [0x35] + C;
	}

	public void L0FF5_Skip()
	{
		[0x35] = A;

		// Reset DSP Registers
		Y = 0x04;
	}

	public void L0FF9_Loop()
	{
		// A = Table038E[Y]
		A = [0x038E + Y];

		// DSP[A] = 0;
		[0xF2] = A;
		A = 0x00;
		[0xF3] = A;

		Y--; if (Z == 0)
			return this.L0FF9_Loop();

		// DSPFlags = 0x20;
		A |= 0x20;
		Y = 0x6C;
		[0xF2] = Y;
		[0xF3] = A;

		// DSPEchoDelay = Value36_EchoDelay;
		A = [0x36];
		Y = 0x7D;
		[0xF2] = Y;
		[0xF3] = A;

		// DSPEchoBufferStart = 0x10000 - (Value36_EchoDelay * 8) + 1;
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
			return this.L1056_Done();

		A = [0x61 + X];
		C = 1; temp = A - 0xE7;

		if (Z == 0)
			return this.L1056_Done();

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

	public void L1056_Done()
	{
		return;
	}

	public void L1057()
	{
		A = [0xAF + X];

		if (Z == 0)
			return this.L1056_Done();

		A = [0x18 + X];
		C = 1; temp = A - 0xE7;

		if (Z == 0)
			return this.L1056_Done();

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
		Stack.Push(Y);
		X = Stack.Pop();
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
		Stack.Push(A);
		A = 0x00;
		A = YA / X; Y = YA % X;
		Y = Stack.Pop();
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
		[0x46] |= [0x2B];
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

		[0x46] |= [0x2B];
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
		return this.L11C3_Skip();
	}

	public void L114C()
	{
		A = [0xCF + X];

		if (Z == 1)
			return this.L1154_Skip();

		[0xCF]--;

		return this.L1181_Skip();
	}

	public void L1154_Skip()
	{
		A = [0x9F + X];

		if (Z == 1)
			return this.L1181_Skip();

		A = [0x0190 + X];
		[0xCF + X] = A;
		[0x46] |= [0x2B];
		[0x9F]--;

		if (Z == 0)
			return this.L116E_Skip();

		A = 0x00;
		[0x01A0 + X] = A;
		A = [0x01C0 + X];

		return this.L117E_Skip();
	}

	public void L116E_Skip()
	{
		C = 0;
		A = [0x01A0 + X];
		A += [0x01B0 + X] + C;
		[0x01A0 + X] = A;
		A = [0x01A1 + X];
		A += [0x01B1 + X] + C;
	}

	public void L117E_Skip()
	{
		[0x01A1 + X] = A;
	}

	public void L1181_Skip()
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
			return this.L11C3_Skip();

		A = 0xD0;
		Y = 0x01;
		[0xA0]--;
		Stack.Push(P);
		[0x46] |= [0x2B];
		P = Stack.Pop();
		[0x0F] = YA;
		[0x11] = YA;
		Stack.Push(X);
		Y = Stack.Pop();
		C = 0;

		if (Z == 0)
			return this.L11B3_Skip();

		[0x111F] += 0x00;
		A = 0x00;
		[[0x0F] +Y] = A;
		Y++;

		return this.L11BF_Skip();
	}

	public void L11B3_Skip()
	{
		[0x1110] += 0x00;
		A = [[0x0F] + Y];
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
		Y++;
		A = [[0x0F] + Y];
	}

	public void L11BF_Skip()
	{
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
	}

	public void L11C3_Skip()
	{
		A = [0x2B];
		A &= [0x46];

		if (Z == 1)
			return this.L1228_Done();

		A = [0x01D1 + X];
		Y = A;
		A = [0x01D0 + X];
		[0x0B] = YA;
	}

	public void L11D2_Loop()
	{
		A = [0x08AC + X];
		[0x0D] = A;
	}

	public void L11D7_Loop()
	{
		Y = 0x51;
		A = [0x1439 + X];

		if (Z == 0)
			return this.L11F2_Skip();

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

	public void L11F2_Skip()
	{
		A = [0x01C1 + X];
		YA = Y * A;
		C = 0;
		A = [0x1439 + X];

		if (Z == 0)
			return this.L1204_Skip();

		A = [0x01F1 + X];
		A <<= 1;

		if (([0x0D] & 0x01) == 0)
			return this.L1204_Skip();

		A <<= 1;
	}

	public void L1204_Skip()
	{
		A = Y;

		if (C == 0)
			return this.L120A_Skip();

		A ^= 0xFF;
		A++;
	}

	public void L120A_Skip()
	{
		// Y = Value0D;
		Y = [0x0D];
		Stack.Push(A);
		A = [0x2B];
		A &= [0x13];
		A = Stack.Pop();

		if (Z == 0)
			return this.L1218_Skip();

		// DSP[Y] = A;
		[0xF2] = Y;
		[0xF3] = A;
	}

	public void L1218_Skip()
	{
		Y = 0x14;
		A = 0x00;
		YA -= [0x0B];
		[0x0B] = YA;
		[0x0D]++;

		if (([0x0D] & 0x02) == 0)
			return this.L11D7_Loop();

		[0x46] ^= [0x2B];
	}

	public void L1228_Done()
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
		// Value12 = Table8F_Channel[X]
		A = [0x8F + X];
		[0x12] = A;

		// YA = Table61_Channel[X]
		Y = [0x62 + X];

		if (Z == 1)
			return this.L1259();

		A = [0x61 + X];

		return this.L125D_JumpToAddress();
	}

	public void L1259()
	{
		// YA = Table18_Channel[X]
		A = [0x18 + X];
		Y = [0x19 + X];
	}

	public void L125D_JumpToAddress()
	{
		[0x0F] = YA;
		Y = 0x00;
	}

	public void L1261_Loop()
	{
		A = [[0x0F] + Y];

		if (Z == 1)
			return this.L1281_HandleEndEvent();

		if (N == 1)
			return this.L126C_HandleNoteEvent();
	}

	public void L1267_FindNoteEvent()
	{
		Y++;
		A = [[0x0F] + Y];

		if (N == 0)
			return this.L1267_FindNoteEvent();
	}

	public void L126C_HandleNoteEvent()
	{
		C = 1; temp = A - 0xC8;

		if (Z == 1)
			return this.L12BE_HandleEventC8();

		C = 1; temp = A - 0xDD;

		if (Z == 1)
			return this.L129D_HandleCallEvent();

		// if(A < 0xCE) return L12A8()
		C = 1; temp = A - 0xCE;

		if (C == 0)
			return this.L12A8();

		// Y += Table0A8A_EventLengths[A]
		Stack.Push(Y);
		Y = A;
		A = Stack.Pop();
		A += [0x0A8A + Y] + C;
		Y = A;

		return this.L1261_Loop();
	}

	// Event Lengths Table (actually starts at 0x0B58)
	public byte[] Table0A8A_EventLengths = new byte[]
	{
		01		// CE
		01		// CF
		02		// D0
		03		// D1
		00		// D2
		01		// D3
		02		// D4
		01		// D5
		02		// D6
		01		// D7
		01		// D8
		01		// D9
		01		// DA
		01		// DB
		02		// DC
		03		// DD
		01		// DE
		03		// DF
		03		// E0
		00		// E1
		01		// E2
		03		// E3
		00		// E4
		03		// E5
		03		// E6
		03		// E7
		01		// E8
		01		// E9
		00		// EA
		00		// EB
		00		// EC
		01		// ED
		01		// EE
		01		// EF
		00		// F0
	}

	public void L1281_HandleEndEvent()
	{
		A = [0x12];

		if (Z == 1)
			return this.L12A8();

		[0x12 + X]--;

		if (Z == 0)
			return this.L1293_HandleRepeatEvent();
		
		// YA = Table0160_ChannelReturnAddress[X]
		A = [0x0161 + X];
		Stack.Push(A);
		A = [0x0160 + X];
		Y = Stack.Pop();

		return this.L125D_JumpToAddress();
	}

	public void L1293_HandleRepeatEvent()
	{
		// YA = Table0170_ChannelRepeatAddress[X]
		A = [0x0171 + X];
		Stack.Push(A);
		A = [0x0170 + X];
		Y = Stack.Pop();

		return this.L125D_JumpToAddress();
	}

	public void L129D_HandleCallEvent()
	{
		Y++;
		A = [[0x0F] + Y];
		Stack.Push(A);
		Y++;
		A = [[0x0F] + Y];
		Y = A;
		A = Stack.Pop();

		return this.L125D_JumpToAddress();
	}

	public void L12A8()
	{
		A = [0x57];
		A &= [0x2B];

		if (Z == 0)
			return this.L12BE();

		A = [0x2B];

		// Y = DSPKeyOff;
		Y = 0x5C;
		Stack.Push(A);
		A = [0x2B];
		A &= [0x13];
		A = Stack.Pop();

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
			return this.L12F7_Skip();

		A = [0xB0 + X];

		if (Z == 1)
			return this.L12CC_Skip();

		[0xB0]--;

		return this.L12F7_Skip();
	}

	public void L12CC_Skip()
	{
		[0x0E] |= 0x80;
		A = 0x00;
		Y = 0x02;
		[0xAF]--;
		[0x0F] = YA;
		[0x11] = YA;
		Stack.Push(X);
		Y = Stack.Pop();
		C = 0;

		if (Z == 0)
			return this.L12E7_Skip();

		[0x111F] += 0x00;
		A = 0x00;
		[[0x0F] +Y] = A;
		Y++;

		return this.L12F3_Skip();
	}

	public void L12E7_Skip()
	{
		[0x1110] += 0x00;
		A = [[0x0F] + Y];
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
		Y++;
		A = [[0x0F] + Y];
	}

	public void L12F3_Skip()
	{
		A += [[0x11] + Y] +C;
		[[0x0F] +Y] = A;
	}

	public void L12F7_Skip()
	{
		A = [0x0201 + X];
		[0x0C] = A;
		A = [0x0200 + X];
		[0x0B] = A;
		A = [0xC0 + X];

		if (Z == 1)
			return this.L1359_Done();

		A = [0x0251 + X];

		C = 1; temp = A - [0xBF + X]; if (Z == 0)
			return this.L1357();

		A = [0x0090 + X];
		C = 1; temp = A - [0x0260 + X];

		if (Z == 0)
			return this.L1318_Skip();

		A = [0x0270 + X];

		return this.L1323_Skip();
	}

	public void L1318_Skip()
	{
		[0x90 + X]++;
		Y = A;

		if (Z == 1)
			return this.L131F_Skip();

		A = [0xC0 + X];
	}

	public void L131F_Skip()
	{
		C = 0;
		A += [0x0261 + X] + C;
	}

	public void L1323_Skip()
	{
		[0xC0 + X] = A;
		A = [0x0241 + X];
		C = 0;
		A += [0x0250 + X] + C;
		[0x0241 + X] = A;
	}

	public void L132F_Loop()
	{
		[0x0D] = A;
		A <<= 1;
		A <<= 1;

		if (C == 0)
			return this.L1337_Skip();

		A ^= 0xFF;
	}

	public void L1337_Skip()
	{
		Y = A;
		A = [0xC0 + X];
		C = 1; temp = A - 0xF1;

		if (C == 0)
			return this.L1343_Skip();

		A &= 0x0F;
		YA = Y * A;

		return this.L1347_Skip();
	}

	public void L1343_Skip()
	{
		YA = Y * A;
		A = Y;
		Y = 0x00;
	}

	public void L1347_Skip()
	{
		if (([0x0D] & 0x80) == 0)
			return this.L1350_Skip();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L1350_Skip()
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

	public void L1359_Done()
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
			return this.L1376_Skip();

		A = [0x01E1 + X];
		Y = A;
		A = [0x01E0 + X];

		this.L13B2();
	}

	public void L1376_Skip()
	{
		if (([0x0E] & 0x80) == 0)
			return this.L137C_Skip();

		this.L11D2_Loop();
	}

	public void L137C_Skip()
	{
		[0x0E] &= ~0x80;
		A = [0x0201 + X];
		[0x0C] = A;
		A = [0x0200 + X];
		[0x0B] = A;
		A = [0xAF + X];

		if (Z == 1)
			return this.L139A_Skip();

		A = [0xB0 + X];

		if (Z == 0)
			return this.L139A_Skip();

		A = [0x0211 + X];
		Y = A;
		A = [0x0210 + X];

		this.L13B2();
	}

	public void L139A_Skip()
	{
		A = [0xC0 + X];

		if (Z == 1)
			return this.L1359_Done();

		A = [0x0251 + X];

		C = 1; temp = A - [0xBF + X]; if (Z == 0)
			return this.L1359_Done();

		Y = [0x39];
		A = [0x0250 + X];
		YA = Y * A;
		A = Y;
		C = 0;
		A += [0x0241 + X] + C;

		return this.L132F_Loop();
	}

	public void L13B2()
	{
		// Flags0E |= 0x80;
		[0x0E] |= 0x80;
		// Flags0D = Y;
		[0x0D] = Y;

		if (([0x0D] & 0x80) == 0)
			return this.L13BF_Skip();

		// Word0F = YA;
		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L13BF_Skip()
	{
		Stack.Push(Y);
		Y = [0x39];
		YA = Y * A;
		[0x0F] = Y;
		[0x10] = 0x00;
		Y = [0x39];
		A = Stack.Pop();
		YA = Y * A;
		YA += [0x0F] + C;

		if (([0x0D] & 0x80) == 0)
			return this.L13D7_Skip();

		[0x0F] = YA;
		YA = [0x09];
		YA -= [0x0F];
	}

	public void L13D7_Skip()
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
			return this.L1428_Done();

		A = [0x08AC + X];
		A |= 0x08;
		[0xF2] = A;

		// A = DSP[A];
		A = [0xF3];

		if (Z == 0)
			return this.L1428_Done();

		A = [0x2B];
		temp = A - [0x0056]; [0x0056] &= ~A;
		temp = A - [0x0057]; [0x0057] &= ~A;
		temp = A - [0x00E8]; [0x00E8] &= ~A;
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
		[0x28] ^= [0x2B];
	}

	public void L1428_Done()
	{
		return;
	}
}
