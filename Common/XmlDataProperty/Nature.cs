using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataProperty
{
    /// <summary>
    /// 属性
    /// </summary>
    public class Nature : IEnumerable<KeyValuePair<int, int>>
    {
        Dictionary<int, MyNature> dic = new Dictionary<int, MyNature>();

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="Id">Id</param>
        /// <param name="onChange">注册访问的属性变更时所触发的事件（不要使用匿名函数和拉姆达表达式，除非能确保不会重复注册或者多次除非不会产生错误）
        /// 必须取消注册结束lisener的生命周期</param>
        /// <returns></returns>
        public int this[int Id,Action onChange = null]
        {
            get
            {
                try
                {
                    if (onChange != null)
                    {
                        dic[Id].OnChange -= onChange;
                        dic[Id].OnChange += onChange;
                    }
                    return dic[Id].count;
                }
                catch(KeyNotFoundException e)
                {
                    KeyNotFound mye = new KeyNotFound();
                    mye.e = e;
                    mye.IntKey = Id;
                    mye.StringKey = DataListManager.inst.QureyPropNameById(Id);
                    throw mye;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                OnSet(Id, onChange, value);
            }
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="Id">Name</param>
        /// <param name="onChange">注册访问的属性变更时所触发的事件（不要使用匿名函数和拉姆达表达式，除非能确保不会重复注册或者多次除非不会产生错误）</param>
        /// <returns></returns>
        public int this[string Name, Action onChange = null]
        {
            get
            {
                try
                {
                    int Id = DataListManager.inst.QueryPropIdByName(Name);
                    if (onChange != null)
                    {
                        dic[Id].OnChange -= onChange;
                        dic[Id].OnChange += onChange;
                    }
                    return dic[Id].count;
                }
                catch (KeyNotFoundException e)
                {
                    KeyNotFound mye = new KeyNotFound();
                    mye.e = e;
                    mye.IntKey = DataListManager.inst.QueryPropIdByName(Name);
                    mye.StringKey = Name;
                    throw mye;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                int Id = DataListManager.inst.QueryPropIdByName(Name);
                OnSet(Id, onChange, value);
            }
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="Id">NatureType</param>
        /// <param name="onChange">注册访问的属性变更时所触发的事件（不要使用匿名函数和拉姆达表达式，除非能确保不会重复注册或者多次除非不会产生错误）</param>
        /// <returns></returns>
        public int this[NatureType type, Action onChange = null]
        {
            get
            {
                try
                {
                    int Id = (int)type;
                    if (onChange != null)
                    {
                        dic[Id].OnChange -= onChange;
                        dic[Id].OnChange += onChange;
                    }
                    return dic[Id].count;
                }
                catch (KeyNotFoundException e)
                {
                    KeyNotFound mye = new KeyNotFound();
                    mye.e = e;
                    mye.IntKey = (int)type;
                    mye.StringKey = DataListManager.inst.QureyPropNameById(mye.IntKey);
                    throw mye;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: in Nature.cs line 97:" + type.ToString());
                    throw;
                }
            }
            set
            {
                int Id = (int)type;
                OnSet(Id,onChange,value);
            }
        }

        /// <summary>
        /// 移除注册
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        public void RemoveOnChange(int Id,Action onChange)
        {
            if (dic.ContainsKey(Id))
            {
                dic[Id].OnChange -= onChange;
            }
        }
        /// <summary>
        /// 移除注册
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        public void RemoveOnChange(NatureType type, Action onChange)
        {
            int Id = (int)type;
            if (dic.ContainsKey(Id))
            {
                dic[Id].OnChange -= onChange;
            }
        }
        /// <summary>
        /// 移除注册
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        public void RemoveOnChange(string Name, Action onChange)
        {
            int Id = DataListManager.inst.QueryPropIdByName(Name);
            if (dic.ContainsKey(Id))
            {
                dic[Id].OnChange -= onChange;
            }
        }
        /// <summary>
        /// 是不是包含指定键
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="onChange"></param>
        /// <returns></returns>
        public bool ContainKey(string Name)
        {
            int Id = DataListManager.inst.QueryPropIdByName(Name);
            return dic.ContainsKey(Id);
        }
        /// <summary>
        /// 是不是包含指定键
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="onChange"></param>
        /// <returns></returns>
        public bool ContainKey(int Id)
        {
            return dic.ContainsKey(Id);
        }
        /// <summary>
        /// 是不是包含指定键
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="onChange"></param>
        /// <returns></returns>
        public bool ContainKey(NatureType type)
        {
            int Id = (int)type;
            return dic.ContainsKey(Id);
        }

        class MyNature
        {
            public int count;
            public event Action OnChange;

            public void Change()
            {
                if (OnChange != null)
                {
                    OnChange();
                }   
            }
        }

        /// <summary>
        /// 赋值并触发变动事件
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        /// <param name="value"></param>
        void OnSet(int Id, Action onChange, int value)
        {
            if (dic.ContainsKey(Id))
            {
                dic[Id].count = value;
            }
            else
            {
                var na = new MyNature();
                na.count = value;
                dic[Id] = na;
            }

            if (onChange != null)
            {
                dic[Id].OnChange -= onChange;
                dic[Id].OnChange += onChange;
            }
            ///触发改变
            dic[Id].Change();
        }

        #region IEnumerable<KeyValuePair<int,int>> 成员

        public IEnumerator<KeyValuePair<int, int>> GetEnumerator()
        {
            foreach (var item in dic)
            {
                yield return new KeyValuePair<int, int>(item.Key, item.Value.count);
            }
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dic.GetEnumerator();
        }

        #endregion
    }

    /// <summary>
    /// 属性类型
    /// </summary>
    public enum NatureType
    {
        /// <summary>
        /// 配合度
        /// </summary>
        PRO_GROWTH = 1,
        /// <summary>
        /// 力量
        /// </summary>
        PRO_STRENGHTH = 2,
        /// <summary>
        /// 智力
        /// </summary>
        PRO_ARTIFICE = 3,
        /// <summary>
        /// 抵抗
        /// </summary>
        PRO_RESISTANCE = 4,
        /// <summary>
        /// 耐力
        /// </summary>
        PRO_ENDURANCE = 5,
        /// <summary>
        /// 敏捷
        /// </summary>
        PRO_AGILITY = 6,
        /// <summary>
        /// 幸运
        /// </summary>
        PRO_LUCK = 7,
        /// <summary>
        /// 最大生命
        /// </summary>
        PRO_MAX_HP = 8,
        /// <summary>
        /// 物理攻击
        /// </summary>
        PRO_PHY_ATK = 9,
        /// <summary>
        /// 物理防御
        /// </summary>
        PRO_PHY_DEF = 10,
        /// <summary>
        /// 魔法攻击
        /// </summary>
        PRO_MGC_ATK = 11,
        /// <summary>
        /// 魔法抗性
        /// </summary>
        PRO_MGC_DEF = 12,
        /// <summary>
        /// 物理破防
        /// </summary>
        PRO_PHY_PURE_ATK = 13,
        /// <summary>
        /// 魔法穿透
        /// </summary>
        PRO_MGC_PURE_ATK = 14,
        /// <summary>
        /// 物理命中
        /// </summary>
        PRO_PHY_HIT = 15,
        /// <summary>
        /// 物理闪避
        /// </summary>
        PRO_PHY_DODGE = 16,
        /// <summary>
        /// 魔法命中
        /// </summary>
        PRO_MGC_HIT = 17,
        /// <summary>
        /// 魔法闪避
        /// </summary>
        PRO_MGC_DODGE = 18,
        /// <summary>
        /// 暴击值
        /// </summary>
        PRO_CRIT = 19,
        /// <summary>
        /// 防暴值
        /// </summary>
        PRO_TENACITY = 20,
        /// <summary>
        /// 暴击倍率
        /// </summary>
        REG_CRIT_MULTIPLE = 21,
        /// <summary>
        /// 回血速度
        /// </summary>
        hp_gen = 22,
        /// <summary>
        /// 移动速度
        /// </summary>
        speed = 23,
        /// <summary>
        /// 攻击频率
        /// </summary>
        attackSpeed = 24,
        /// <summary>
        /// 攻击范围
        /// </summary>
        attackRange = 25,
        /// <summary>
        /// 物理命中率
        /// </summary>
        CAL_PHY_HIT_RESULT = 26,
        /// <summary>
        /// 魔法命中率
        /// </summary>
        CAL_MGC_HIT_RESULT = 27,
        /// <summary>
        /// 暴击概率
        /// </summary>
        CAL_CRIT_RESULT = 28,
        /// <summary>
        /// 最终伤害
        /// </summary>
        CAL_DAMAGE = 29,
        /// <summary>
        /// 当前生命
        /// </summary>
        CAL_HP = 30,
        /// <summary>
        /// 生命加成值
        /// </summary>
        EFF_HP_VALUE = 31,
        /// <summary>
        /// 生命加成百分比
        /// </summary>
        EFF_HP_RATIO = 32,
        /// <summary>
        /// 最大生命加成值
        /// </summary>
        EFF_MAX_HP_VALUE = 33,
        /// <summary>
        /// 最大生命加成百分比
        /// </summary>
        EFF_MAX_HP_RATIO = 34,
        /// <summary>
        /// 物理攻击加成值
        /// </summary>
        EFF_PHY_ATK_VALUE = 35,
        /// <summary>
        /// 物理攻击加成百分比
        /// </summary>
        EFF_PHY_ATK_RATIO = 36,
        /// <summary>
        /// 魔法攻击加成值
        /// </summary>
        EFF_MGC_ATK_VALUE = 37,
        /// <summary>
        /// 魔法攻击加成百分比
        /// </summary>
        EFF_MGC_ATK_RATIO = 38,
        /// <summary>
        /// 物理防御加成值
        /// </summary>
        EFF_PHY_DEF_VALUE = 39,
        /// <summary>
        /// 物理防御加成百分比
        /// </summary>
        EFF_PHY_DEF_RATIO = 40,
        /// <summary>
        /// 魔法抗性加成值
        /// </summary>
        EFF_MGC_DEF_VALUE = 41,
        /// <summary>
        /// 魔法抗性加成百分比
        /// </summary>
        EFF_MGC_DEF_RATIO = 42,
        /// <summary>
        /// 物理破防加成值
        /// </summary>
        EFF_PHY_PURE_ATK_VALUE = 43,
        /// <summary>
        /// 物理破防加成百分比
        /// </summary>
        EFF_PHY_PURE_ATK_RATIO = 44,
        /// <summary>
        /// 魔法穿透加成值
        /// </summary>
        EFF_MGC_PURE_ATK_VALUE = 45,
        /// <summary>
        /// 魔法穿透加成百分比
        /// </summary>
        EFF_MGC_PURE_ATK_RATIO = 46,
        /// <summary>
        /// 物理命中值加成值
        /// </summary>
        EFF_PHY_HIT_VALUE = 47,
        /// <summary>
        /// 物理命中值加成百分比
        /// </summary>
        EFF_PHY_HIT_RATIO = 48,
        /// <summary>
        /// 物理闪避值加成值
        /// </summary>
        EFF_PHY_DODGE_VALUE = 49,
        /// <summary>
        /// 物理闪避值加成百分比
        /// </summary>
        EFF_PHY_DODGE_RATIO = 50,
        /// <summary>
        /// 魔法命中值加成值
        /// </summary>
        EFF_MGC_HIT_VALUE = 51,
        /// <summary>
        /// 魔法命中值加成百分比
        /// </summary>
        EFF_MGC_HIT_RATIO = 52,
        /// <summary>
        /// 魔法闪避值加成值
        /// </summary>
        EFF_MGC_DODGE_VALUE = 53,
        /// <summary>
        /// 魔法闪避值加成百分比
        /// </summary>
        EFF_MGC_DODGE_RATIO = 54,
        /// <summary>
        /// 暴击值加成值
        /// </summary>
        EFF_CRIT_VALUE = 55,
        /// <summary>
        /// 暴击值加成百分比
        /// </summary>
        EFF_CRIT_RATIO = 56,
        /// <summary>
        /// 防暴值加成值
        /// </summary>
        EFF_TENACITY_VALUE = 57,
        /// <summary>
        ///防暴值加成百分比 
        /// </summary>
        EFF_TENACITY_RATIO = 58,
        /// <summary>
        /// 暴击倍率加成值
        /// </summary>
        EFF_CRIT_MULTIPLE_VALUE = 59,
        /// <summary>
        /// 暴击倍率加成百分比
        /// </summary>
        EFF_CRIT_MULTIPLE_RATIO = 60,
        /// <summary>
        /// 移动速度加成值
        /// </summary>
        EFF_MOVING_SPEED_VALUE = 61,
        /// <summary>
        /// 移动速度加成百分比
        /// </summary>
        EFF_MOVING_SPEED_RATIO = 62,
        /// <summary>
        /// 攻击频率加成值
        /// </summary>
        EFF_ATK_FREQUENCY_VALUE = 63,
        /// <summary>
        /// 攻击频率加成百分比
        /// </summary>
        EFF_ATK_FREQUENCY_RATIO = 64,
        /// <summary>
        /// 攻击范围加成值
        /// </summary>
        EFF_ATK_RANGE_VALUE = 65,
        /// <summary>
        /// 攻击范围加成百分比
        /// </summary>
        EFF_ATK_RANGE_RATIO = 66,
        /// <summary>
        /// 物理命中率加成值
        /// </summary>
        EFF_PHY_HIT_RESULT_VALUE = 67,
        /// <summary>
        /// 物理命中率加成百分比
        /// </summary>
        EFF_PHY_HIT_RESULT_RATIO = 68,
        /// <summary>
        /// 魔法命中率加成值
        /// </summary>
        EFF_MGC_HIT_RESULT_VALUE = 69,
        /// <summary>
        /// 魔法命中率加成百分比
        /// </summary>
        EFF_MGC_HIT_RESULT_RATIO = 70,
        /// <summary>
        /// 暴击概率加成值
        /// </summary>
        EFF_CRIT_RESULT_VALUE = 71,
        /// <summary>
        /// 暴击概率加成百分比
        /// </summary>
        EFF_CRIT_RESULT_RATIO = 72,
        /// <summary>
        /// 最终伤害加成值
        /// </summary>
        EFF_DAMAGE_VALUE = 73,
        /// <summary>
        /// 最终伤害加成百分比
        /// </summary>
        EFF_DAMAGE_RATIO = 74,
        /// <summary>
        /// 技能1等级加成
        /// </summary>
        EFF_SKILL1_LEVEL = 75,
        /// <summary>
        /// 技能2等级加成
        /// </summary>
        EFF_SKILL2_LEVEL = 76,
        /// <summary>
        /// 技能3等级加成
        /// </summary>
        EFF_SKILL3_LEVEL = 77,
        /// <summary>
        ///技能4等级加成 
        /// </summary>
        EFF_SKILL4_LEVEL = 78,
        /// <summary>
        /// 技能5等级加成
        /// </summary>
        EFF_SKILL5_LEVEL = 79,
        /// <summary>
        /// 技能6等级加成
        /// </summary>
        EFF_SKILL6_LEVEL = 80,
        /// <summary>
        /// 技能7等级加成
        /// </summary>
        EFF_SKILL7_LEVEL = 81,
        /// <summary>
        /// 技能8等级加成
        /// </summary>
        EFF_SKILL8_LEVEL = 82,
        /// <summary>
        /// 技能9等级加成
        /// </summary>
        EFF_SKILL9_LEVEL = 83,
        /// <summary>
        /// 技能10等级加成
        /// </summary>
        EFF_SKILL10_LEVEL = 84,
        /// <summary>
        /// 技能11等级加成
        /// </summary>
        EFF_SKILL11_LEVEL = 85,
        /// <summary>
        /// 技能12等级加成
        /// </summary>
        EFF_SKILL12_LEVEL = 86,
        /// <summary>
        /// 技能13等级加成
        /// </summary>
        EFF_SKILL13_LEVEL = 87,
        /// <summary>
        /// 技能14等级加成
        /// </summary>
        EFF_SKILL14_LEVEL = 88,
        /// <summary>
        /// 技能15等级加成
        /// </summary>
        EFF_SKILL15_LEVEL = 89,
        /// <summary>
        /// 伤害类型
        /// </summary>
        JobTag = 90,
    }

    /// <summary>
    /// 货币
    /// </summary>
    public class Currencies:IEnumerable<KeyValuePair<int, int>>
    {
        Dictionary<int, Coin> dic = new Dictionary<int, Coin>();

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="Id">Id</param>
        /// <param name="onChange">注册访问的属性变更时所触发的事件（不要使用匿名函数和拉姆达表达式，除非能确保不会重复注册或者多次除非不会产生错误）</param>
        /// <returns></returns>
        public int this[int Id, Action onChange = null]
        {
            get
            {
                try
                {
                    if (onChange != null)
                    {
                        dic[Id].OnChange -= onChange;
                        dic[Id].OnChange += onChange;
                    }
                    return dic[Id].count;
                }
                catch (KeyNotFoundException e)
                {
                    KeyNotFound mye = new KeyNotFound();
                    mye.e = e;
                    mye.IntKey = Id;
                    mye.StringKey = DataListManager.inst.QureyPropNameById(Id);
                    throw mye;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                OnSet(Id, onChange, value);
            }
        }

        public int this[CurrenciesType type, Action onChange = null]
        {
            get
            {
                try
                {
                    int Id = (int)type;
                    if (onChange != null)
                    {
                        dic[Id].OnChange -= onChange;
                        dic[Id].OnChange += onChange;
                    }
                    return dic[Id].count;
                }
                catch (KeyNotFoundException e)
                {
                    KeyNotFound mye = new KeyNotFound();
                    mye.e = e;
                    mye.IntKey = (int)type;
                    mye.StringKey = DataListManager.inst.QureyPropNameById(mye.IntKey);
                    throw mye;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                int Id = (int)type;
                OnSet(Id, onChange, value);
            }
        }

        /// <summary>
        /// 移除注册
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        public void RemoveOnChange(int Id, Action onChange)
        {
            if (dic.ContainsKey(Id))
            {
                dic[Id].OnChange -= onChange;
            }
        }

        public void RemoveOnChange(CurrenciesType type, Action onChange)
        {
            int Id = (int)type;
            if (dic.ContainsKey(Id))
            {
                dic[Id].OnChange -= onChange;
            }
        }

        class Coin
        {
            public int count;
            public event Action OnChange;

            public void Change()
            {
                if (OnChange != null)
                {
                    OnChange();
                } 
                
            }
        }

        /// <summary>
        /// 赋值并触发变动事件
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="onChange"></param>
        /// <param name="value"></param>
        void OnSet(int Id, Action onChange, int value)
        {
            if (dic.ContainsKey(Id))
            {
                dic[Id].count = value;
            }
            else
            {
                var na = new Coin();
                na.count = value;
                dic[Id] = na;
            }

            if (onChange != null)
            {
                dic[Id].OnChange -= onChange;
                dic[Id].OnChange += onChange;
            }
            ///触发改变
            dic[Id].Change();
        }

        /// <summary>
        /// 是不是包含指定键
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="onChange"></param>
        /// <returns></returns>
        public bool ContainKey(string Name)
        {
            int Id = DataListManager.inst.QueryPropIdByName(Name);
            return dic.ContainsKey(Id);
        }

        public bool ContainKey(int Id)
        {
            return dic.ContainsKey(Id);
        }

        public bool ContainKey(CurrenciesType type)
        {
            int Id = (int)type;
            return dic.ContainsKey(Id);
        }

        #region IEnumerable<KeyValuePair<int,int>> 成员

        public IEnumerator<KeyValuePair<int, int>> GetEnumerator()
        {
            foreach (var item in dic)
            {
                yield return new KeyValuePair<int, int>(item.Key, item.Value.count);
            }
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dic.GetEnumerator();
        }

        #endregion
    }
}

public class KeyNotFound : KeyNotFoundException
{
    public int IntKey { get; set; }
    public string StringKey { get; set; }
    public KeyNotFoundException e { get; set; }
}
/// <summary>
/// 货币类型
/// </summary>
public enum CurrenciesType
{
    /// <summary>
    /// 经验
    /// </summary>
    Exp = 1,
    /// <summary>
    /// 体力
    /// </summary>
    Physical = 2,
    /// <summary>
    /// 金币
    /// </summary>
    GOLD = 3,
    /// <summary>
    /// 钻石
    /// </summary>
    Diamond = 4,
    /// <summary>
    /// 声望
    /// </summary>
    Prestige = 5,
    /// <summary>
    /// 美德
    /// </summary>
    VirtueValue = 6,
    /// <summary>
    /// 智慧
    /// </summary>
    WisdomValue = 7,
    /// <summary>
    /// 金币购买次数
    /// </summary>
    CoinBuyFreq = 8,
    /// <summary>
    /// 体力购买次数
    /// </summary>
    PhysicalBuyFreq = 9,
    /// <summary>
    /// 精英副本购买次数
    /// </summary>
    OutstandingBuyFreq = 10,
    /// <summary>
    /// 竞技场购买次数
    /// </summary>
    JJCBuyFreq = 11,
    /// <summary>
    /// 幻境购买次数
    /// </summary>
    UnrealBuyFreq = 12,
    /// <summary>
    /// 祈祷购买次数
    /// </summary>
    PrayBuyFreq = 13,
    /// <summary>
    /// 时装币
    /// </summary>
    FashionCoin = 14,
    /// <summary>
    /// 美德值购买次数
    /// </summary>
    VirtueValueBuyFreq = 15,
    /// <summary>
    /// 智慧点购买次数
    /// </summary>
    WisdomValueBuyFreq = 16,
    /// <summary>
    /// 时装币购买次数
    /// </summary>
    FashionCoinBuyFreq = 17,
}
