using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


/// <summary>
/// ������ɫ���͵�ö��
/// </summary>
public enum CharacterType 
{
    ���,
    �ٻ���,
    ����,
    ����,
}


/// <summary>
/// �������͵�ö��
/// </summary>
public enum PropType
{
    ͨ�õ���,
    ������������,
}

/// <summary>
/// ��������ö��
/// </summary>
public enum TerrainType
{
    ����,
    ����,
}

/// <summary>
/// �������͵�ö��
/// </summary>
public enum EnemyType
{
    boss,
    С��,
}

/// <summary>
/// ��Ա�������ͣ������
/// </summary>
public enum AgentName
{
    �����,
}

/// <summary>
/// �������ƣ������
/// </summary>
public enum EnemyName
{
    Դʯ��,
}

/// <summary>
/// ͨ����Ϊ�ӿ�
/// </summary>
public interface IGeneral
{
    public void Move();
    public void Collision();
}

/// <summary>
/// �Ӵ����εĽӿ�
/// </summary>
public interface IContact
{
    public void ContactTerrain();
}

/// <summary>
/// ���пɶ���ɫ�ĳ�����
/// </summary>
public abstract class Character
{
    private StringBuilder name;//��ɫ����
    private StringBuilder id;//��ɫid
    private int healthPoint;//��ɫ����ֵ
    private CharacterType cType;//��ɫ����

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
/// ��ɫ�е��������Ҫ���ڼ̳�һЩ��������
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
/// �������͵������Ҫ���ڼ̳�һЩ����
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





