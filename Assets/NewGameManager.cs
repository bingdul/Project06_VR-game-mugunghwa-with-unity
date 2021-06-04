using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum SpaceMode
//{
//    InUI,
//    InCorridor,
//    InMaze,
//    InOver
//}

public class NewGameManager : MonoBehaviour
{
    public SpaceMode SPACEMODE;
    public bool isEnemyAwake = false;
    public GameObject Player;
    public GameObject OverCanvas;
    public bool isModeChange = true;
    // Start is called before the first frame update
    void Start()
    {
        SPACEMODE = SpaceMode.InUI;
        //SPACEMODE = SpaceMode.InCorridor;
    }

    // Update is called once per frame
    
    void Update()
    {

        if (SPACEMODE == SpaceMode.InOver)
        {
            if (isModeChange) //  �� �ȿ� �ѹ��� ������ ���. ��尡 �ٲ�� ��Ȳ�϶� �� ��ũ��Ʈ�� isModeChange�� true�� �ٲپ �ѹ� ������ �� �ֵ��� �Ѵ�.
            {
                Player.GetComponent<SimpleCapsuleWithStickMovement>().enabled = false;
                isModeChange = false;
            }
        }
        else if (SPACEMODE == SpaceMode.InCorridor)
        {
            if (isModeChange)
            {

            }
            else if (SPACEMODE == SpaceMode.InMaze)
            {
                if (isModeChange)
                {

                    isModeChange = false;
                }
            }
            else if (SPACEMODE == SpaceMode.InUI)
            {
                if (isModeChange)
                {

                    isModeChange = false;
                }
            }
        }

    }
}
