using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonsterGetData : MonoBehaviour
{
    public MonsterReadData monsterData;
    public Monster monsterGetData = new Monster();


    // Start is called before the first frame update
    void Start()
    {
        monsterData = GameObject.FindObjectOfType<MonsterReadData>().GetComponent<MonsterReadData>();
        //Debug.Log(this.gameObject.name);
        if (this.gameObject.name == "mons_1")
        {
            MonsterGetAttribute(0);
        }
        if (this.gameObject.name == "mons_2")
        {
            MonsterGetAttribute(1);
        }
        if (this.gameObject.name == "mons_3")
        {
            MonsterGetAttribute(2);
        }
        if (this.gameObject.name == "mons_4")
        {
            MonsterGetAttribute(3);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MonsterGetAttribute(int index)
    {
        monsterGetData.monster.monster_id = monsterData.myMonster.monster[index].monster_id;
        monsterGetData.monster.monster_name = monsterData.myMonster.monster[index].monster_name;
        monsterGetData.monster.monster_type = monsterData.myMonster.monster[index].monster_type;
        monsterGetData.monster.monster_draft_position = monsterData.myMonster.monster[index].monster_draft_position;
        monsterGetData.monster.monster_lvl = monsterData.myMonster.monster[index].monster_lvl;
        monsterGetData.monster.monster_stats.hp = monsterData.myMonster.monster[index].monster_stats.hp;
        monsterGetData.monster.monster_stats.atk = monsterData.myMonster.monster[index].monster_stats.atk;
        monsterGetData.monster.monster_stats.def = monsterData.myMonster.monster[index].monster_stats.def;
        monsterGetData.monster.monster_stats.mp = monsterData.myMonster.monster[index].monster_stats.mp;
        monsterGetData.monster.monster_stats.spd = monsterData.myMonster.monster[index].monster_stats.spd;

        monsterGetData.monster.monster_items = new MonsterItems[monsterData.myMonster.monster[index].monster_items.Length];
        Debug.Log(monsterGetData.monster.monster_items[0]);

        for (int i = 0; i < monsterData.myMonster.monster[index].monster_items.Length; i++)
        {
            //Debug.Log(i);
            //monsterGetData.monster.monster_items[i].item_id = monsterData.myMonster.monster[index].monster_items[i].item_id;
            //monsterGetData.monster.monster_items[i].item_name = monsterData.myMonster.monster[index].monster_items[i].item_name;
        }
    }

    [Serializable]
    public class MonsterData
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
        public int atk;
        public int def;
        public int spd;
    }

    [Serializable]
    public class Monster
    {
        public MonsterData monster;
    }
}
