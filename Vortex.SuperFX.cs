public class SnesRom
{
	public void L01BDB1()
	{
		// ram = 0;
		r[d] = r[s] - r[0];
		ram = r[s];

		// rom = Value66;
		r[0] = [0x66];
		rom = r[s];

		// Stream = Value64 - 1;
		r[14] = [0x64];
		r[14] -= 1;

		// r1_Length = Stream.ReadInt16();
		d = 1;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 1; d = 1;
		r[d] = r[s] | (rom[r[14]] << 8);
		r[14] -= 1;

		// Stream.Skip(2);
		r[14] -= 1;
		r[14] -= 1;

		// r3 = Stream.ReadInt16();
		d = 3;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 3; d = 3;
		r[d] = r[s] | (rom[r[14]] << 8);
		r[14] -= 1;

		// r2 = Stream.ReadInt16();
		d = 2;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 2; d = 2;
		r[d] = r[s] | (rom[r[14]] << 8);

		// r9_Destination = Value2C_Destination;
		r[9] = [0x2C];

		// Value5C_Last = r1_Length + r9_Destination;
		s = 1; d = 1;
		r[d] = r[s] + r[9];
		[0x5C] = r[1];

		r[4] = 0x00;
		r[6] = 0x00;
		r[5] = 0x00;
		
		// r7 = this.L01BF66;
		r[7] = 0xBF66;

		Cpu.Cache();

		// r8 = Return Address;
		r[8] = r[15];

		// r12 = 3;
		r[12] = 0x03;

		// r11 = Return Address;
		r[11] = this.L01BDEE;

		return this.L01BF62_Start();
	}

	public void L01BDEE()
	{
		r[0] = 0xFF;
		r[d] = r[s] & r[4];

		if (z == 0)
			return this.L01BDF8();

		return this.L01BE71();
	}

	public void L01BDF8()
	{
		// if (r4 != 7) Skip;
		r[0] = 0x07;
		c = 1; temp = r[s] - r[4];

		if (z == 0)
			return this.L01BE30();

		// r2 >>= 1;
		s = 2; d = 2;
		r[d] = r[s] >> 1;

		// Ror r3;
		s = 3; d = 3;
		Cpu.Ror();

		// r2 |= r3;
		s = 2;
		r[d] = r[s] | r[3];

		// if (r2 != 0) Skip;
		if (z == 0)
			return this.L01BE0D();

		r[11] = this.L01BE0D;
		return this.L01BF4A();
	}

	public void L01BE0D()
	{
		if (c == 0)
			return this.L01BE26();

		r[12] = 0x0A;
		r[11] = this.L01BE17;
		return this.L01BF62_Start();
	}

	public void L01BE17()
	{
		r[4] = r[4]; Cpu.SetFlags(r[4]);

		if (z == 0)
			return this.L01BE30();

		r[12] = 0x12;
		r[11] = this.L01BE23;
		return this.L01BF62_Start();
	}

	public void L01BE23()
	{
		return this.L01BE30();
	}

	public void L01BE26()
	{
		r[12] = 0x04;
		r[11] = this.L01BE2D;
		return this.L01BF62_Start();
	}

	public void L01BE2D()
	{
		s = 4; d = 4;
		r[d] = r[s] + 0xBF36;
	}

	public void L01BE30()
	{
		// for (r12 = 8; r12 >= 0; r12--)
		r[12] = 0x08;
		r[13] = r[15];

		// loop
		s = 2; d = 2;
		r[d] = r[s] >> 1;

		s = 3; d = 3;
		Cpu.Ror();

		s = 2;
		r[d] = r[s] | r[3];

		if (z == 1)
			return this.L01BE4E();

		s = 6; d = 6;
		Cpu.Rol();

		s = 5; d = 5;
		Cpu.Rol();

		// next
		r[12] -= 1; if (z == 0) r[15] = r[13];
		
		r[1] -= 1;

		s = 6;
		[r[1]] = r[s];
		r[4] -= 1;

		if (z == 0)
			return this.L01BE30();

		return this.L01BE71();
	}

	public void L01BE4E()
	{
		// r3 = Stream.ReadInt16();
		r[14] -= 1;

		d = 3;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 3; d = 3;
		r[d] = r[s] | (rom[r[14]] << 8);

		// r2 = Stream.ReadInt16();
		r[14] -= 1;

		d = 2;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 2; d = 2;
		r[d] = r[s] | (rom[r[14]] << 8);

		// c = 1;
		r[0] = 0x01;
		Cpu.Ror();

		s = 2; d = 2;
		Cpu.Ror();

		s = 3; d = 3;
		Cpu.Ror();

		s = 6; d = 6;
		Cpu.Rol();

		s = 5; d = 5;
		Cpu.Rol();

		// next
		r[12] -= 1; if (z == 0) r[15] = r[13];

		r[1] -= 1;

		s = 6;
		[r[1]] = r[s];
		r[4] -= 1;

		if (z == 0)
			return this.L01BE30();
	}

	public void L01BE71()
	{
		s = 9; d = 9;
		c = 1; temp = r[s] - r[1];

		if (z == 0)
			return this.L01BE96();

		r[12] = 0x02;

		// Value64 = Stream;
		[0x64] = r[14];

		r[3] = [0x98];
		r[3] = r[3]; Cpu.SetFlags(r[3]);

		if (z == 1)
			return this.L01BE94_Done();

		// count = Value5C_Last - Value2C;
		r[1] = [0x2C];
		r[2] = [0x5C];

		d = 12;
		s = 2;
		r[d] = r[s] - r[1];

		// loop = r15;
		r[13] = r[15];

		// loop
		r[d] = [r[1]];
		r[d] = r[s] + r[3];
		[r[1]] = r[s];
		r[1] += 1;
		r[12] -= 1; if (z == 0) r[15] = r[13];

		r[1] += 1;
	}

	public void L01BE94_Done()
	{
		Cpu.Stop();
	}

	public void L01BE96()
	{
		Cpu.Cache();
		r[11] = this.L01BE9C;
		return this.L01BF62_Start();
	}

	public void L01BE9C()
	{
		r[6] = 0x02;
		r[5] = 0x00;
		r[12] = 0x08;
		r[4] = r[4]; Cpu.SetFlags(r[4]);

		if (z == 0)
			return this.L01BEAB();

		return this.L01BF36();
	}

	public void L01BEAB()
	{
		r[6] = 0x04;
		r[0] = 0x02;
		c = 1; temp = r[s] - r[4];

		if (z == 1)
			return this.L01BF0E();

		r[6] = 0x03;
		r[0] = 0x01;
		c = 1; temp = r[s] - r[4];

		if (z == 1)
			return this.L01BEF5();

		r[12] = 0x02;
		r[11] = this.L01BEC4;
		return this.L01BF62_Start();
	}

	public void L01BEC4()
	{
		r[0] = 0x03;
		c = 1; temp = r[s] - r[4];

		if (z == 1)
			return this.L01BEE9();

		r[0] = 0x02;
		c = 1; temp = r[s] - r[4];

		if (z == 1)
			return this.L01BEDA();

		s = 4; d = 4;
		r[d] = r[s] + 0x09;
		r[6] = r[4];

		return this.L01BF0E();
	}

	public void L01BEDA()
	{
		r[12] = 0x02;
		r[11] = this.L01BEE1;
		return this.L01BF62_Start();
	}

	public void L01BEE1()
	{
		s = 4; d = 4;
		r[d] = r[s] + 0x1A;
		r[6] = r[4];

		return this.L01BF0E();
	}

	public void L01BEE9()
	{
		r[12] = 0x08;
		r[11] = this.L01BEF0;
		return this.L01BF62_Start();
	}

	public void L01BEF0()
	{
		r[6] = r[4];

		return this.L01BF0E();

	}

	public void L01BEF5()
	{
		r[12] = 0x08;

		s = 2; d = 2;
		r[d] = r[s] >> 1;

		s = 3; d = 3;
		Cpu.Ror();

		s = 2;
		r[d] = r[s] | r[3];

		if (z == 0)
			return this.L01BF06();

		r[11] = this.L01BF05;
		return this.L01BF4A();
	}

	public void L01BF05()
	{
	}

	public void L01BF06()
	{
		if (c == 1)
			return this.L01BF36();

		r[12] = 0x0E;

		return this.L01BF36();
	}

	public void L01BF0E()
	{
		r[12] = 0x10;

		s = 2; d = 2;
		r[d] = r[s] >> 1;

		s = 3; d = 3;
		Cpu.Ror();

		s = 2;
		r[d] = r[s] | r[3];

		if (z == 0)
			return this.L01BF1E();

		r[11] = this.L01BF1E;
		return this.L01BF4A();
	}

	public void L01BF1E()
	{
		if (c == 0)
			return this.L01BF36();

		r[12] = 0x08;

		s = 2; d = 2;
		r[d] = r[s] >> 1;

		s = 3; d = 3;
		Cpu.Ror();

		s = 2;
		r[d] = r[s] | r[3];

		if (z == 0)
			return this.L01BF31();

		r[11] = this.L01BF31;
		return this.L01BF4A();
	}

	public void L01BF31()
	{
		if (c == 1)
			return this.L01BF36();

		r[12] = 0x0C;
	}

	public void L01BF36()
	{
		r[11] = this.L01BF3B;
		return this.L01BF62_Start();
	}

	public void L01BF3B()
	{
		r[6] -= 1;
	}

	public void L01BF3C_Loop()
	{
		// r0 = r1_Length + r4 - 1;
		s = 1;
		r[d] = r[s] + r[4];
		r[0] -= 1;

		// r0 = ram[r0];
		r[d] = [r[0]];

		// r1 -= 1;
		r[1] -= 1;

		// ram[r1] = r0;
		[r[1]] = r[s];

		// r6 -= 1;
		r[6] -= 1;

		// if (r6 >= 0) Loop;
		if (n == 0)
			return this.L01BF3C_Loop();

		// Return
		r[15] = r[8];
	}

	public void L01BF4A()
	{
		// d3 = Stream.ReadShort();
		d = 3;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 3; d = 3;
		r[d] = r[s] | (rom[r[14]] << 8);
		r[14] -= 1;

		// d2 = Stream.ReadShort();
		d = 2;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 2; d = 2;
		r[d] = r[s] | (rom[r[14]] << 8);

		// c = 1;
		r[0] = 0x01;
		Cpu.Ror();

		// Ror(r2);
		s = 2; d = 2;
		Cpu.Ror();

		// Ror(r3);
		s = 3; d = 3;
		Cpu.Ror();

		// r0 = r2 | r3;
		s = 2;
		r[d] = r[s] | r[3];

		// return;
		r[15] = r[11];
	}

	public void L01BF62_Start()
	{
		// r0 -= r4;
		r[d] = r[s] - r[4];

		// Loop = this.L01BF66;
		r[13] = r[7];

		s = 2; d = 2;
	}

	public void L01BF66()
	{
		// loop
		r[d] = r[s] >> 1;

		s = 3; d = 3;
		Cpu.Ror();

		s = 2;
		r[d] = r[s] | r[3];

		if (z == 1)
			return this.L01BF74();

		s = 4; d = 4;
		Cpu.Rol();

		// next
		r[12] -= 1; if (z == 0) r[15] = r[13]; s = 2; d = 2;

		// return
		r[15] = r[11];
	}

	public void L01BF74()
	{
		r[14] -= 1;

		d = 3;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 3; d = 3;
		r[d] = r[s] | (rom[r[14]] << 8);
		r[14] -= 1;

		d = 2;
		r[d] = rom[r[14]];
		r[14] -= 1;

		s = 2; d = 2;
		r[d] = r[s] | (rom[r[14]] << 8);
		r[0] = 0x01;
		Cpu.Ror();

		s = 2; d = 2;
		Cpu.Ror();

		s = 3; d = 3;
		Cpu.Ror();

		s = 4; d = 4;
		Cpu.Rol();

		//next
		r[12] -= 1; if (z == 0) r[15] = r[13];

		s = 2; d = 2;
		r[15] = r[11];
		r[1] = 0x0200;
		r[12] = 0x3F00;
		r[13] = r[15];
		r[d] = r[s] - r[0];
		[r[1]] = r[s];
		r[1] += 1;

		// next
		r[12] -= 1; if (z == 0) r[15] = r[13];
		r[1] += 1;
		Cpu.Stop();
	}
}