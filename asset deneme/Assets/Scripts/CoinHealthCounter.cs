using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHealthCounter : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;

    public TMPro.TextMeshProUGUI CoinCount;
    public TMPro.TextMeshProUGUI HealthCount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinCount.text = Player.gameObject.GetComponent<CoinCounter>().GetScore().ToString();

        //TODO Health ile değiştir
        HealthCount.text = Player.gameObject.GetComponent<HealthCounter>().GetHealth().ToString();
    }
}
