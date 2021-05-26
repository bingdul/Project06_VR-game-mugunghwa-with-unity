using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finafinal : MonoBehaviour
{
    private Rigidbody[] rigid;
    [SerializeField] private GameObject go_trap;
    [SerializeField] private int damage;

    private bool isActivated = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponentsInChildren<Rigidbody>();
    }
    void OnTriggerEnter(Collider _col)  // Ʈ���ſ� �浹�� �Ǿ��� ���� �� �Լ��� �����Ѵ�.
    {
        if (!isActivated)
        {

            if (_col.gameObject.name == "Player")
            {
                isActivated = true;
                //Destroy(go_trap);

                for (int i = 0; i < rigid.Length; i++)
                {
                    rigid[i].useGravity = true;
                    rigid[i].isKinematic = false;
                }

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
