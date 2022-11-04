using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class TestGet : MonoBehaviour
{
    [Header("TextMesh")]
    public TextMeshProUGUI idText;
    public TextMeshProUGUI monsternameText;
    public TextMeshProUGUI monsterTypeText;
    public TextMeshProUGUI draftPosText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI atkText;
    public TextMeshProUGUI defText;
    public TextMeshProUGUI mpText;
    public TextMeshProUGUI spdText;
    public TextMeshProUGUI itemidText;
    public TextMeshProUGUI itemnameText;
    public TextMeshProUGUI itemstatText;
    public TextMeshProUGUI itemvalueText;
    public TextMeshProUGUI itemid2Text;
    public TextMeshProUGUI itemname2Text;
    public TextMeshProUGUI itemstat2Text;
    public TextMeshProUGUI itemvalue2Text;
    public TextMeshProUGUI itemid3Text;
    public TextMeshProUGUI itemname3Text;
    public TextMeshProUGUI itemstat3Text;
    public TextMeshProUGUI itemvalue3Text;

    [Header("API")]
    [SerializeField]
    public int playerNumber;
    private string requestURL;
    public StatusCode myMonster = new StatusCode();
    public PlayerRoot myPlayer = new PlayerRoot();

    [ContextMenu("Test Get")]
    public async void TestGetData()
    {
        var httpClient = new HttpClient(new JsonSerializationOption());
        myMonster = await httpClient.Get<StatusCode>(requestURL);
    }

    [ContextMenu("Test Get Monster Data")]
    public async void TestGeteMonster()
    {
        var url = "https://ksridc2r74.execute-api.ap-southeast-1.amazonaws.com/dega_test/monster";
        var httpClient = new HttpClient(new JsonSerializationOption());
        myMonster = await httpClient.Get<StatusCode>(url);
    }

    [ContextMenu("Test Get Player Data")]
    public async void TestGetPlayer()
    {
        var url = "https://ksridc2r74.execute-api.ap-southeast-1.amazonaws.com/test_pvp/pvp";
        var httpClient = new HttpClient(new JsonSerializationOption());
        myPlayer = await httpClient.Get<PlayerRoot>(url);
    }

    public void ShowMonsterDetail(int number)
    {
        idText.text = "ID : " + myPlayer.body.player[playerNumber].team.monster[number].monster_id.ToString();
        monsternameText.text = "NAME : " + myPlayer.body.player[playerNumber].team.monster[number].monster_name.ToString();
        monsterTypeText.text = "Type : " + myPlayer.body.player[playerNumber].team.monster[number].monster_type.ToString();
        draftPosText.text = "Draft Position : " + myPlayer.body.player[playerNumber].team.monster[number].monster_draft_position.ToString();
        levelText.text = "Level : " + myPlayer.body.player[playerNumber].team.monster[number].monster_lvl.ToString();
        hpText.text = "HP : " + myPlayer.body.player[playerNumber].team.monster[number].monster_stats.hp.ToString();
        atkText.text = "ATK : " + myPlayer.body.player[playerNumber].team.monster[number].monster_stats.atk.ToString();
        defText.text = "DEF : " + myPlayer.body.player[playerNumber].team.monster[number].monster_stats.def.ToString();
        mpText.text = "MP : " + myPlayer.body.player[playerNumber].team.monster[number].monster_stats.mp.ToString();
        spdText.text = "SPD : " + myPlayer.body.player[playerNumber].team.monster[number].monster_stats.spd.ToString();
        itemidText.text = "Item ID : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[0].item_id.ToString();
        itemnameText.text = "Item Name : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[0].item_name.ToString();
        itemstatText.text = "Item Stat : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[0].stats.ToString();
        itemvalueText.text = "Item Value : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[0].value.ToString();
        itemid2Text.text = "Item ID : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[1].item_id.ToString();
        itemname2Text.text = "Item Name : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[1].item_name.ToString();
        itemstat2Text.text = "Item Stat : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[1].stats.ToString();
        itemvalue2Text.text = "Item Value : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[1].value.ToString();
        itemid3Text.text = "Item ID : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[2].item_id.ToString();
        itemname3Text.text = "Item Name : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[2].item_name.ToString();
        itemstat3Text.text = "Item Stat : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[2].stats.ToString();
        itemvalue3Text.text = "Item Value : " + myPlayer.body.player[playerNumber].team.monster[number].monster_items[2].value.ToString();
    }

    public void PlayNumber(int index)
    {
        playerNumber = index;
        ShowMonsterDetail(0);
    }
}
