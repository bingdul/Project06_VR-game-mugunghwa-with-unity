using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tele : MonoBehaviour
{
    public Transform Target;
   
   
    void OnTriggerEnter(Collider _col)  // Ʈ���ſ� �浹�� �Ǿ��� ���� �� �Լ��� �����Ѵ�.
    {
        
        if (_col.gameObject.tag == "Tele")
        {
            
            //while (true)
            //{
            //    if (ParentTransform.parent == null)
            //        break;
            //    else
            //        ParentTransform = ParentTransform.parent;
            //}

            transform.position = Target.position;
        
        }
    }
}
