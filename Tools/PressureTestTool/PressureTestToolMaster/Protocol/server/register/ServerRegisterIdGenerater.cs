//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.(The author is Boiling)
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Protocol.Server.Register
{
     public class ServerRegisterIdGenerater
     {
          public static void GenerateId()
          {
               Protocol.MsgId.Id<Server_Tag>.Value= 0xff0000;
               Protocol.MsgId.Id<MSG_Server_Register>.Value= 0xff0001;
               Protocol.MsgId.Id<MSG_Server_Register_Return>.Value= 0xff0002;
               Protocol.MsgId.Id<Connect_Info>.Value= 0xff0003;
               Protocol.MsgId.Id<MSG_Server_Connect_Command>.Value= 0xff0004;
          }
     }
}