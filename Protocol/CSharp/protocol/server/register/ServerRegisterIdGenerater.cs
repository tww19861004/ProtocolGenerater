 //------------------------------------------------------------------------------
 // <auto-generated>
 //     This code was generated by a tool.(The author is Boiling)
 //     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 // </auto-generated>
 //------------------------------------------------------------------------------
namespace protocol.server.register
{
     public class IdGenerater
     {
          public static void GenerateId()
          {
               Protocol.MsgId.Id<MSG_REQ_Server_Register>.Value= 0xFF0001;
               Protocol.MsgId.Id<MSG_RES_Server_Register>.Value= 0xFF0002;
               Protocol.MsgId.Id<ConnectInfo>.Value= 0xFF0003;
          }
     }
}
