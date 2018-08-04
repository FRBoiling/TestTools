using System.IO;
using protocol.client.c2g;
using protocol.client.g2c;
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

MSG_CG_CREATE_CHARACTER msg_MSG_CG_CREATE_CHARACTER;

public object Init_MSG_CG_CREATE_CHARACTER()
{
msg_MSG_CG_CREATE_CHARACTER = new MSG_CG_CREATE_CHARACTER();
return msg_MSG_CG_CREATE_CHARACTER;
}
public object Get_MSG_CG_CREATE_CHARACTER()
{
return msg_MSG_CG_CREATE_CHARACTER;
}
public object New_MSG_CG_CREATE_CHARACTER()
{
return msg_MSG_CG_CREATE_CHARACTER;
}

public object RouteInit(string className)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return Init_MSG_CG_USER_LOGIN();

case "MSG_CG_CREATE_CHARACTER":
return Init_MSG_CG_CREATE_CHARACTER();


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

case "MSG_CG_CREATE_CHARACTER":
return New_MSG_CG_CREATE_CHARACTER();


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

case "MSG_CG_CREATE_CHARACTER":
return Get_MSG_CG_CREATE_CHARACTER();


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

case "MSG_CG_CREATE_CHARACTER":
return typeof(MSG_CG_CREATE_CHARACTER);


default:
return null;
}
}
public void BindResponse()
{

}
public bool RouteSend(string className,object msg)
{
switch (className)
{
case "MSG_CG_USER_LOGIN":
return Net.Send((MSG_CG_USER_LOGIN)msg);

case "MSG_CG_CREATE_CHARACTER":
return Net.Send((MSG_CG_CREATE_CHARACTER)msg);


default:
return false;
}
}

}
}

