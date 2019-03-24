using System.Collections.Generic;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public class ChatManager : Singleton<ChatManager>
    {
        public List<string> contexts = new List<string>();
        public void Init()
        {
            contexts.Add("sa diao seng！");
            contexts.Add("sa diao Bruce! ");
            contexts.Add("权晟！哈哈哈，原来你在这里！");
            contexts.Add("好巧啊！你也在这里？？");
            contexts.Add("宇宙无敌大帅！沸腾哥在此！");
            contexts.Add("傻 diao seng ！");
            contexts.Add("听说你很diao ！");
            contexts.Add("听说 YYZJ 要火啊！");
            contexts.Add("必须火啊！");
            contexts.Add("膜拜，沸腾哥！");
            contexts.Add("MDZZ！");
            contexts.Add("你好吗？？");
            contexts.Add("我很好");
        }

        public List<string> GetContexts()
        {
            return contexts;
        }
    }
}
