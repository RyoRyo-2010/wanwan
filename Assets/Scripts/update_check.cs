using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net;
using System.Net.NetworkInformation;
public class update_check : MonoBehaviour
{
    [SerializeField]
    string url = "";
    [SerializeField]
    string myvarsion;

    [SerializeField]
    GameObject[] yaruyatu;
    [SerializeField]
    GameObject error_obj;
    bool matu = false;
    int matu_byou;
    float matimasita;
    // Start is called before the first frame update
    void Start()
    {
        if(!NetworkInterface.GetIsNetworkAvailable())
        {
            error_obj.SetActive(true);
            matu_byou = 5;
            matu = true;
            return;
        }
        //url‚ÉAŒ©‚És‚­B
        WebClient mywebClient = new WebClient();
        string version = mywebClient.DownloadString(url + @"/appdate_data.txt");
        if (version != myvarsion)
        {
            foreach(GameObject obj in yaruyatu)
            {
                obj.SetActive(true);
            }
        }
        else
        {
            SceneManager.LoadScene("game");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!matu) return;
        matimasita += Time.deltaTime;
        if(matimasita >= matu_byou)
        {
            SceneManager.LoadScene("game");
        }
    }
}
