using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class StatusCode 
{
    public int statusCode;
    public BodyM body;
}

[Serializable]
public class BodyM
{
    public string name;
    public string type;
    public string rarity;
    public int count;
    public Skill[] skill;
}

[Serializable]
public class Skill
{
    public string skill;
    public string type;
    public string skill_id;
}
