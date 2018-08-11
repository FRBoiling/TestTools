using System.IO;
using protocol.client;
using Protocol.MsgId;
using LibLog;
using ProtoParserLib;
namespace ProtoSendLib
{
public partial class Client
{
MSG_CG_USER_LOGIN msg_MSG_CG_USER_LOGIN;

public object Init_MSG_CG_USER_LOGIN()
{
msg_MSG_CG_USER_LOGIN = new MSG_CG_USER_LOGIN();
return msg_MSG_CG_USER_LOGIN;
}
public object Get_MSG_CG_USER_LOGIN()
{
return msg_MSG_CG_USER_LOGIN;
}
public object New_MSG_CG_USER_LOGIN()
{
return msg_MSG_CG_USER_LOGIN;
}

MSG_CG_RECONNECT_LOGIN msg_MSG_CG_RECONNECT_LOGIN;

public object Init_MSG_CG_RECONNECT_LOGIN()
{
msg_MSG_CG_RECONNECT_LOGIN = new MSG_CG_RECONNECT_LOGIN();
return msg_MSG_CG_RECONNECT_LOGIN;
}
public object Get_MSG_CG_RECONNECT_LOGIN()
{
return msg_MSG_CG_RECONNECT_LOGIN;
}
public object New_MSG_CG_RECONNECT_LOGIN()
{
return msg_MSG_CG_RECONNECT_LOGIN;
}

public void OnResponse_MSG_GC_RECONNECT_LOGIN(MemoryStream stream)
{
MSG_GC_RECONNECT_LOGIN MSG_GC_RECONNECT_LOGIN = ProtoBuf.Serializer.Deserialize<MSG_GC_RECONNECT_LOGIN>(stream);
Parser.Parse(MSG_GC_RECONNECT_LOGIN);
}

public void OnResponse_ROLE_INFO(MemoryStream stream)
{
ROLE_INFO ROLE_INFO = ProtoBuf.Serializer.Deserialize<ROLE_INFO>(stream);
Parser.Parse(ROLE_INFO);
}

MSG_CG_CREATE_ROLE msg_MSG_CG_CREATE_ROLE;

public object Init_MSG_CG_CREATE_ROLE()
{
msg_MSG_CG_CREATE_ROLE = new MSG_CG_CREATE_ROLE();
return msg_MSG_CG_CREATE_ROLE;
}
public object Get_MSG_CG_CREATE_ROLE()
{
return msg_MSG_CG_CREATE_ROLE;
}
public object New_MSG_CG_CREATE_ROLE()
{
return msg_MSG_CG_CREATE_ROLE;
}

public void OnResponse_MSG_GC_CREATE_ROLE(MemoryStream stream)
{
MSG_GC_CREATE_ROLE MSG_GC_CREATE_ROLE = ProtoBuf.Serializer.Deserialize<MSG_GC_CREATE_ROLE>(stream);
Parser.Parse(MSG_GC_CREATE_ROLE);
}

public void OnResponse_ClientIdGenerater(MemoryStream stream)
{
ClientIdGenerater ClientIdGenerater = ProtoBuf.Serializer.Deserialize<ClientIdGenerater>(stream);
Parser.Parse(ClientIdGenerater);
}

public object RouteInit(string className)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return Init_MSG_CG_USER_LOGIN();

case "MSG_CG_RECONNECT_LOGIN":
return Init_MSG_CG_RECONNECT_LOGIN();

case "MSG_CG_CREATE_ROLE":
return Init_MSG_CG_CREATE_ROLE();


default:
return null;
}
}
public object RouteNew(string className)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return New_MSG_CG_USER_LOGIN();

case "MSG_CG_RECONNECT_LOGIN":
return New_MSG_CG_RECONNECT_LOGIN();

case "MSG_CG_CREATE_ROLE":
return New_MSG_CG_CREATE_ROLE();


default:
return null;
}
}
public object RouteGet(string className)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return Get_MSG_CG_USER_LOGIN();

case "MSG_CG_RECONNECT_LOGIN":
return Get_MSG_CG_RECONNECT_LOGIN();

case "MSG_CG_CREATE_ROLE":
return Get_MSG_CG_CREATE_ROLE();


default:
return null;
}
}
public object RouteType(string className)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return typeof(MSG_CG_USER_LOGIN);

case "MSG_CG_RECONNECT_LOGIN":
return typeof(MSG_CG_RECONNECT_LOGIN);

case "MSG_CG_CREATE_ROLE":
return typeof(MSG_CG_CREATE_ROLE);


default:
return null;
}
}
public void BindResponse()
{
Net.AddResponser(Id<MSG_GC_RECONNECT_LOGIN>.Value, OnResponse_MSG_GC_RECONNECT_LOGIN);

Net.AddResponser(Id<ROLE_INFO>.Value, OnResponse_ROLE_INFO);

Net.AddResponser(Id<MSG_GC_CREATE_ROLE>.Value, OnResponse_MSG_GC_CREATE_ROLE);

Net.AddResponser(Id<ClientIdGenerater>.Value, OnResponse_ClientIdGenerater);


}
public bool RouteSend(string className,object msg)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return Net.Send((MSG_CG_USER_LOGIN)msg);

case "MSG_CG_RECONNECT_LOGIN":
return Net.Send((MSG_CG_RECONNECT_LOGIN)msg);

case "MSG_CG_CREATE_ROLE":
return Net.Send((MSG_CG_CREATE_ROLE)msg);


default:
return false;
}
}

}
}

