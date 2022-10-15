
using UnityEngine;

public class Branch : MonoBehaviour
{

    [SerializeField]
    private LayerMask player_layer;
    private bool touchingToPlayer;

    public static Branch bran;

    private void Start()
    {
        bran = this;
    }

    void Update()
    {
        if (GameManager.gm.oyundevam)
        {
            if (PlayerManager.pm.can_collectable)
            {
                touchingToPlayer = Physics.CheckSphere(transform.position, 0.3f, player_layer);
                if (touchingToPlayer && PlayerManager.pm.can_collectable)
                {
                    if (GameManager.gm.sayaci == 3)
                    {
                        PlayerManager.pm.Death();
                        GameManager.gm.sayaci = 2;
                    }
                }
            }
        }
    }
}
