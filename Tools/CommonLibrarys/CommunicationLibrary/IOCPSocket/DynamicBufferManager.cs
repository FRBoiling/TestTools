using System;

namespace IOCPLib
{


    public class DynamicBufferManager
    {
        public byte[] Buffer { get; set; }

        public int DataCount { get; set; }

        public DynamicBufferManager(int bufferSize = 1024)
        {
            DataCount = 0;
            Buffer = new byte[bufferSize];
        }

        public int GetDataCount()
        {
            return DataCount;
        }

        public int GetReserveCount()
        {
            return Buffer.Length - DataCount;
        }

        public void Clear(int count = 1024)
        {
            if (count>=DataCount)
            {
                DataCount = 0;
            }
            else
            {
                for (int i = 0; i < DataCount - count; i++)
                {
                    Buffer[i] = Buffer[count + i];
                }
                DataCount = DataCount - count;
            }
        }

        public void WriteBuffer(byte[] buffer,int offset,int count)
        {
            if (GetReserveCount()>=count)
            {
                Array.Copy(buffer, offset, Buffer, DataCount, count);
                DataCount = DataCount + count;
            }
            else
            {
                int totalSize = Buffer.Length + count - GetReserveCount();
                byte[] tmpBuffer = new byte[totalSize];
                Array.Copy(Buffer, 0, tmpBuffer, 0, DataCount);
                Array.Copy(buffer, offset, tmpBuffer, DataCount, count);

                DataCount = DataCount + count;
                Buffer = tmpBuffer;
            }
        }

        public void WriteBuffer(byte[] buffer)
        {
            WriteBuffer(buffer,0,buffer.Length);
        }


    }
}
