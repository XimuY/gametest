using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


/// <summary>
/// 创建角色类型的枚举
/// </summary>
public enum CharacterType 
{
    玩家,
    召唤物,
    敌人,
    中立,
}


/// <summary>
/// 道具类型的枚举
/// </summary>
public enum PropType
{
    通用道具,
    技能升级道具,
}

/// <summary>
/// 地形类型枚举
/// </summary>
public enum TerrainType
{
    增益,
    陷阱,
}

/// <summary>
/// 敌人类型的枚举
/// </summary>
public enum EnemyType
{
    boss,
    小怪,
}

/// <summary>
/// 干员姓名类型，可添加
/// </summary>
public enum AgentName
{
    阿米娅,
}

/// <summary>
/// 敌人名称，可添加
/// </summary>
public enum EnemyName
{
    源石虫,
}

/// <summary>
/// 通用行为接口
/// </summary>
public interface IGeneral
{
    public void Move();
    public void Collision();
}

/// <summary>
/// 接触地形的接口
/// </summary>
public interface IContact
{
    public void ContactTerrain();
}

/// <summary>
/// 所有可动角色的抽象类
/// </summary>
public abstract class Character
{
    private StringBuilder name;//角色名称
    private StringBuilder id;//角色id
    private int healthPoint;//角色生命值
    private CharacterType cType;//角色类型

    public string Name
    {
        get { return  name.ToString(); }
        set { name.Clear(); name.Append(value); }
    }

    public string ID
    {
        get { return id.ToString(); }
        set { id.Clear(); id.Append(value); }
    }

    public int HealthPoint
    {
        get { return healthPoint; }
        set { healthPoint = value; }
    }

    public CharacterType CType
    {
        get { return cType; }
        set { cType = value; }
    }
}

/// <summary>
/// 角色中的玩家类主要用于继承一些公用属性
/// </summary>
public abstract class Player: Character
{
    private short skillNumber;
    private short propNumber;
    private short skillPropNumber;

    public short SkillNumber
    {
        get { return skillNumber; }
        set { skillNumber = value; }
    }


    public short PropNumber
    {
        get { return propNumber; }
        set { propNumber = value; }
    }

    public short SkillPropNumber
    {
        get { return skillPropNumber; }
        set { skillPropNumber = value; }
    }
}

/// <summary>
/// 敌人类型的人物，主要用于继承一些属性
/// </summary>
public abstract class Enemy:Character
{
    private short attackPatternNumber;
    private short fallingObjectsType;
    private EnemyType eType;
    private int appearTime;

    public short AttackPatternNumber
    {
        get { return attackPatternNumber; }
        set { attackPatternNumber = value; }
    }

    public EnemyType EType
    {
        get { return eType; }
        set { eType = value; }
    }

    public short FallingObjectsType
    {
        get { return fallingObjectsType; }
        set { fallingObjectsType = value; }
    }

    public int AppearTime
    {
        get { return appearTime; }
        set { appearTime = value; }
    }
}





