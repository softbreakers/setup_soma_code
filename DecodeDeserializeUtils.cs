using SevenZip.Compression.LZMA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

internal class DecodeDeserializeUtils
{
	private static void SaveFilesToPath(Dictionary<string, byte[]> files, string path)
	{
		foreach (string current in files.Keys)
		{
			string filePath = Path.Combine(path, current);
			FileUtils.SaveBinaryToFile(filePath, files[current]);
		}
	}

	public static object DeserializeObject(byte[] serializedObject)
	{
		object result;
		using (MemoryStream memoryStream = new MemoryStream(serializedObject))
		{
			result = new BinaryFormatter().Deserialize(memoryStream);
		}
		return result;
	}

	public static void SaveEncodedFilesToPath(byte[] encodedArray, string path)
	{
		byte[] decodedBytes = DecodeDeserializeUtils.DecodeLzma(encodedArray);
		Dictionary<string, byte[]> files = (Dictionary<string, byte[]>)DecodeDeserializeUtils.DeserializeObject(decodedBytes);
		DecodeDeserializeUtils.SaveFilesToPath(files, path);
	}

	private static byte[] DecodeLzma(byte[] lzmaByteArray)
	{
		byte[] result = null;
		Decoder decoder = new Decoder();
		using (MemoryStream memoryStream = new MemoryStream(lzmaByteArray))
		{
			memoryStream.Seek(0L, SeekOrigin.Begin);
			using (MemoryStream memoryStream2 = new MemoryStream())
			{
				byte[] array = new byte[5];
				if (memoryStream.Read(array, 0, 5) != 5)
				{
					throw new Exception("input .lzma is too short");
				}
				long num = 0L;
				for (int i = 0; i < 8; i++)
				{
					int num2 = memoryStream.ReadByte();
					if (num2 < 0)
					{
						throw new Exception("Can't Read 1");
					}
					num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
				}
				decoder.SetDecoderProperties(array);
				long inSize = memoryStream.Length - memoryStream.Position;
				decoder.Code(memoryStream, memoryStream2, inSize, num, null);
				result = memoryStream2.ToArray();
			}
		}
		return result;
	}
}
