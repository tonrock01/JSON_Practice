using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MonsterStats
{
    public int hp;
    public int atk;
    public int def;
    public int mp;
    public int spd;
}

[Serializable]
public class MonsterItems
{
    public int item_id;
    public string item_name;
    public string stats;
    public string value;
}

[System.Serializable]
public class Monster
{
    public string monster_id;
    public string monster_name;
    public string monster_type;
    public int monster_draft_position;
    public int monster_lvl;
    public MonsterStats monster_stats;
    public MonsterItems[] monster_items;
}

[Serializable]
public class PlayerRoot
{
    public int statusCode;
    public Body body;
}

[Serializable]
public class Body
{
    public int match_id;
    public string patch;
    public string match_type;
    public int rank_tier;
    public int first_player;
    public Player[] player;
}

[Serializable]
public class Player
{
    public string player_id;
    public Team team;
}

[Serializable]
public class Team
{
    public Monster[] monster;
}
