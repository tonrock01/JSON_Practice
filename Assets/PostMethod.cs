using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostMethod : MonoBehaviour
{
    [SerializeField]
    private string url = "https://ksridc2r74.execute-api.ap-southeast-1.amazonaws.com/dega_test/post/sand/data";
    void Start()
    {
        //StartCoroutine(UploadData());
    }

    IEnumerator UploadData()
    {
        WWWForm form = new WWWForm();
        form.AddField("P'Ty", "Americano nueng kaew");

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    [ContextMenu("PostData")]
    public void PostDataMethod()
    {
        StartCoroutine(UploadData());
    }
}
