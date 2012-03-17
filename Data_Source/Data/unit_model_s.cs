namespace Data
{
	using System;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;

	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct unit_model_s
	{
		[FieldOffset(0x18)]
		public ushort unit_type;
		[FieldOffset(0x6c)]
		public uint pName_address;	
		[FieldOffset(0x3b4)]
		public uint minimap_radius;
		[FieldOffset(0x508)]
		public ulong default_targetFilter_flags;

		[FieldOffset(0x7c8)]
		public uint starting_health;
		[FieldOffset(0x7cc)]
		public uint max_health;
		[FieldOffset(0x7d0)]
		public uint life_armor;

		[FieldOffset(0x7d8)]
		public uint health_regen_delay;
		[FieldOffset(0x7dc)]
		public uint health_regen_rate;

		[FieldOffset(0x7ec)]
		public uint starting_energy;
		[FieldOffset(0x7f0)]
		public uint max_energy;
		[FieldOffset(0x7f4)]
		public uint energy_regen_delay;
		[FieldOffset(0x7f8)]
		public uint energy_regen_rate;
		[FieldOffset(0x7fc)]
		public uint starting_shield;
		[FieldOffset(0x800)]
		public uint max_shield;
		[FieldOffset(0x804)]
		public uint shield_armor;

		[FieldOffset(0x80c)]
		public uint shield_regen_delay;
		[FieldOffset(0x810)]
		public uint shield_regen_rate;
	}
}
