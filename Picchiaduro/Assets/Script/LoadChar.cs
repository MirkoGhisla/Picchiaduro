using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadChar : MonoBehaviour
{
    public GameObject spawnPoint1, spawnPoint2;
    public GameObject Ghost, BlackWhite;
    void Start()
    {
        if (CharSelManager.GhostG1 == true)
        {
            GameObject G1 = Instantiate(Ghost, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
            G1.tag = "G1";
            G1.AddComponent<comandiG1>();
        }
        else if (CharSelManager.BlackWhiteG1 == true)
        {
            GameObject G1 = Instantiate(BlackWhite, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
            G1.tag = "G1";
            G1.AddComponent<comandiG1>();
        }



        if (CharSelManager.GhostG2 == true)
        {
            GameObject G2 = Instantiate(Ghost, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            G2.tag = "G2";
            G2.AddComponent<comandiG2>();
        }
        else if (CharSelManager.BlackWhiteG2 == true)
        {
            GameObject G2 = Instantiate(BlackWhite, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            G2.tag = "G2";
            G2.AddComponent<comandiG2>();
        }
    }


}
