using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCPLib
{
    struct SendBufferPacket
    {
        public int Offset;
        public int Count;
    }
    public class AsyncSendBufferManager
    {
        private DynamicBufferManager _dynamicBufferManager;

        public DynamicBufferManager DynamicBufferManager
        {
            get { return _dynamicBufferManager; }
            set { _dynamicBufferManager = value; }
        }

        private List<SendBufferPacket> _sendBufferList;

        private SendBufferPacket _sendBufferPacket;

        public AsyncSendBufferManager(int bufferSize)
        {
            _dynamicBufferManager = new DynamicBufferManager(bufferSize);
            _sendBufferList = new List<SendBufferPacket>();
            _sendBufferPacket.Offset = 0;
            _sendBufferPacket.Count = 0;
        }

        public void StartPacket()
        {
            _sendBufferPacket.Offset = _dynamicBufferManager.DataCount;
            _sendBufferPacket.Count = 0;
        }

        public void EndPacket()
        {
            _sendBufferPacket.Count = _dynamicBufferManager.DataCount - _sendBufferPacket.Offset;
            _sendBufferList.Add(_sendBufferPacket);
        }

        public bool GetFristPacket(ref int offset,ref int count)
        {
            if (_sendBufferList.Count<=0)
            {
                return false;
            }
            else
            {
                offset = _sendBufferList[0].Offset;
                count = _sendBufferList[0].Count;
                return true;
            }
        }

        public bool ClearFirstPacket()
        {
            if (_sendBufferList.Count<=0)
            {
                return false;
            }
            int count = _sendBufferList[0].Count;
            _dynamicBufferManager.Clear(count);
            _sendBufferList.RemoveAt(0);
            return true;
        }

        public void ClearPackets()
        {
            _sendBufferList.Clear();
            _dynamicBufferManager.Clear(_dynamicBufferManager.DataCount);
        }
    }
}
