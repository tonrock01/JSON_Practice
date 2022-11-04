using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System;

public class MonsterReadData : MonoBehaviour
{

    public TextAsset data;
    public Monster myMonster = new Monster();

    public GameObject spawnMonsterPrefab;


    // Start is called before the first frame update
    void Start()
    {
        myMonster = JsonUtility.FromJson<Monster>(data.text);
        GameObject.Instantiate(spawnMonsterPrefab);
        //Debug.Log(myMonster.monster[1].monster_name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
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

    [System.Serializable]
    public class Monster
    {
        public MonsterData[] monster;
    }
    
    [ContextMenu("GetData")]
    public void GetData()
    {
        myMonster = JsonUtility.FromJson<Monster>(data.text);
    }
}
