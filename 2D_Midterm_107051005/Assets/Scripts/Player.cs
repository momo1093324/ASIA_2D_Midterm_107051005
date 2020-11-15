using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject fianal;
    //道具數量
    public Text textCount;
    //數量
    public int count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("碰到傳送門");
        if (collision.name=="傳送門")
        {
        fianal.SetActive(true);
        }
        if (collision.tag == "鑽石")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "鑽石數量：" + count;
        }
    }

}
