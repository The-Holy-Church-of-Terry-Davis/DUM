using System;
using System.Runtime.InteropServices;

namespace DUM.EFI;

[StructLayout(LayoutKind.Sequential)]
readonly struct EFI_TABLE_HEADER
{
    public readonly ulong Signature;
    public readonly uint Revision;
    public readonly uint HeaderSize;
    public readonly uint Crc32;
    public readonly uint Reserved;
}