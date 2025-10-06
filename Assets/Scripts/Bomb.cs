using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float deleteTime = 3.0f;

    //生成されて数秒後に削除
    private void Start()
    {
        Destroy(gameObject, deleteTime);
    }
}
