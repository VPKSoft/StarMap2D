#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System.Text;

namespace VPKSoft.StarCatalogs.Utilities;

/// <summary>
/// An extended implementation of the <see cref="BinaryReader"/> class with big-endian reading methods.
/// Implements the <see cref="System.IO.BinaryReader" />
/// </summary>
/// <seealso cref="System.IO.BinaryReader" />
public class BinaryReaderEndian: BinaryReader
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryReaderEndian"/> class.
    /// </summary>
    /// <param name="input">The input stream.</param>
    public BinaryReaderEndian(Stream input) : base(input)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryReaderEndian"/> class.
    /// </summary>
    /// <param name="input">The input stream.</param>
    /// <param name="encoding">The character encoding to use.</param>
    public BinaryReaderEndian(Stream input, Encoding encoding) : base(input, encoding)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryReaderEndian"/> class.
    /// </summary>
    /// <param name="input">The input stream.</param>
    /// <param name="encoding">The character encoding to use.</param>
    /// <param name="leaveOpen"><see langword="true" /> to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, <see langword="false" />.</param>
    public BinaryReaderEndian(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
    {
    }

    /// <summary>
    /// Reads the specified number of bytes from the current stream into a reversed byte array and advances the current position by that number of bytes.
    /// </summary>
    /// <param name="count">The number of bytes to read. This value must be 0 or a non-negative number or an exception will occur.</param>
    /// <returns>A byte array containing data read from the underlying stream in reversed order. This might be less than the number of bytes requested if the end of the stream is reached.</returns>
    public byte[] ReadBytesReversed(int count)
    {
        var bytes = base.ReadBytes(count);
        Array.Reverse(bytes);
        return bytes;
    }

    /// <summary>
    /// Reads a 4-byte floating point value from the current stream using big-endian encoding and advances the current position of the stream by four bytes.
    /// </summary>
    /// <returns>A 4-byte floating point value read from the current stream.</returns>
    public float ReadSingleBigEndian()
    {
        return BitConverter.ToSingle(ReadBytesReversed(4));
    }

    /// <summary>
    /// Reads an 8-byte floating point value from the current stream using big-endian encoding and advances the current position of the stream by eight bytes.
    /// </summary>
    /// <returns>An 8-byte floating point value read from the current stream.</returns>
    public double ReadDoubleBigEndian()
    {
        return BitConverter.ToDouble(ReadBytesReversed(8));
    }

    /// <summary>
    /// Reads a 2-byte signed integer from the current stream using big-endian encoding and advances the current position of the stream by two bytes.
    /// </summary>
    /// <returns>A 2-byte signed integer read from the current stream.</returns>
    public short ReadInt16BigEndian()
    {
        return BitConverter.ToInt16(ReadBytesReversed(2));
    }

    /// <summary>
    /// Reads a 4-byte signed integer from the current stream using big-endian encoding and advances the current position of the stream by four bytes.
    /// </summary>
    /// <returns>A 4-byte signed integer read from the current stream.</returns>
    public int ReadInt32BigEndian()
    {
        return BitConverter.ToInt32(ReadBytesReversed(4));
    }

    /// <summary>
    /// Reads an 8-byte signed integer from the current stream using big-endian encoding and advances the current position of the stream by eight bytes.
    /// </summary>
    /// <returns>An 8-byte signed integer read from the current stream.</returns>
    public long ReadInt64BigEndian()
    {
        return BitConverter.ToInt64(ReadBytesReversed(8));
    }

    /// <summary>
    /// Reads a 2-byte unsigned integer from the current stream using big-endian encoding and advances the position of the stream by two bytes.
    /// </summary>
    /// <returns>A 2-byte unsigned integer read from this stream.</returns>
    public ushort ReadUInt16BigEndian()
    {
        return BitConverter.ToUInt16(ReadBytesReversed(2));
    }

    /// <summary>
    /// Reads a 4-byte unsigned integer from the current stream using big-endian encoding and advances the position of the stream by four bytes.
    /// </summary>
    /// <returns>A 4-byte unsigned integer read from this stream.</returns>
    public uint ReadUInt32BigEndian()
    {
        return BitConverter.ToUInt32(ReadBytesReversed(4));
    }

    /// <summary>
    /// Reads an 8-byte unsigned integer from the current stream using big-endian encoding and advances the position of the stream by eight bytes.
    /// </summary>
    /// <returns>An 8-byte unsigned integer read from this stream.</returns>
    public ulong ReadUInt64BigEndian()
    {
        return BitConverter.ToUInt64(ReadBytesReversed(8));
    }

    /// <summary>
    /// Reads a 2-byte floating point value from the current stream and advances the current position of the stream by two bytes.
    /// </summary>
    /// <returns>A 2-byte floating point value read from the current stream.</returns>
    public Half ReadHalfBigEndian()
    {
        return BitConverter.ToHalf(ReadBytesReversed(2));
    }
}