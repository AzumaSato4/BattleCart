using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float deleteTIme = 5.0f; //削除されるまでの時間
    public GameObject bombs; //爆発のエフェクト

    private void Start()
    {
        //deleteTime秒後に消える
        Destroy(gameObject, deleteTIme);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //相手がEnemyタグなら相手を削除
            Destroy(other.gameObject);
            //相手がEnemyタグならbombsを生成
            Instantiate(bombs, transform.position, Quaternion.identity);
        }

        //いずれにしても自分を削除
        Destroy(gameObject);
    }
}
