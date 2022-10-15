using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headForLevelGeneration : MonoBehaviour
{
    public LevelGenerator lg;

    public LLevelGenerator llg;

    public L3evelgenerator l3;
    public L4evelgenerator l4;
    public L5evelgenerator l5;
    public L6evelgenerator l6;
    public L7evelgenerator l7;
    public L8evelgenerator l8;
    public L9evelgenerator l9;
    public L10evelgenerator l10;
    public L11evelgenerator l11;
    public L12evelgenerator l12;
    public L13evelgenerator l13;
    public L14evelgenerator l14;
    public L15evelgenerator l15;
    public L16evelgenerator l16;
    public L17evelgenerator l17;
    public L18evelgenerator l18;
    public L19evelgenerator l19;
    public L20evelgenerator l20;
    public L21evelgenerator l21;
    public L22evelgenerator l22;
    public L23evelgenerator l23;
    public L24evelgenerator l24;
    public L25evelgenerator l25;
    public L26evelgenerator l26;
    public L27evelgenerator l27;
    public L28evelgenerator l28;
    public L29evelgenerator l29;
    public L30evelgenerator l30;
    public L31evelgenerator l31;
    public L32evelgenerator l32;
    public L33evelgenerator l33;
    public L34evelgenerator l34;
    public L35evelgenerator l35;
    public L36evelgenerator l36;
    public L37evelgenerator l37;
    public L38evelgenerator l38;
    public L39evelgenerator l39;
    public L40evelgenerator l40;
    public L41evelgenerator l41;
    public L42evelgenerator l42;
    public L43evelgenerator l43;
    public L44evelgenerator l44;
    public L45evelgenerator l45;
    public L46evelgenerator l46;
    public L47evelgenerator l47;
    public L48evelgenerator l48;
    public L49evelgenerator l49;
    public L50evelgenerator l50;
    public L51evelgenerator l51;


    [SerializeField]
    private LayerMask cyl_layer;

    public static headForLevelGeneration hflg;

    private Collider[] aa = new Collider[1];
    void Start()
    {
        hflg = this;
    }


    void Update()
    {
        if (GameManager.gm.currentlevel == 1)
        {
            if (lg.odunsayisi <= LevelGenerator.lv.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    lg.SpawnCylinder();
                }
            }
        }

        else if (GameManager.gm.currentlevel == 2)
        {
            if (llg.odunsayisi <= llg.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    llg.SpawnCylinder();

                }
            }
        }
        else if (GameManager.gm.currentlevel == 3)
        {
            if (l3.odunsayisi <= l3.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l3.SpawnCylinder();
                }
            }
        }
        else if (GameManager.gm.currentlevel == 4)
        {
            if (l4.odunsayisi <= l4.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l4.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 5)
        {
            if (l5.odunsayisi <= l5.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l5.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 6)
        {
            if (l6.odunsayisi <= l6.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l6.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 7)
        {
            if (l7.odunsayisi <= l7.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l7.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 8)
        {
            if (l8.odunsayisi <= l8.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l8.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 9)
        {
            if (l9.odunsayisi <= l9.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l9.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 10)
        {
            if (l10.odunsayisi <= l10.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l10.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 11)
        {
            if (l11.odunsayisi <= l11.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l11.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 12)
        {
            if (l12.odunsayisi <= l12.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l12.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 13)
        {
            if (l13.odunsayisi <= l13.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l13.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 14)
        {
            if (l14.odunsayisi <= l14.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l14.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 15)
        {
            if (l15.odunsayisi <= l15.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l15.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 16)
        {
            if (l16.odunsayisi <= l16.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l16.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 17)
        {
            if (l17.odunsayisi <= l17.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l17.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 18)
        {
            if (l18.odunsayisi <= l18.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l18.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 19)
        {
            if (l19.odunsayisi <= l19.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l19.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 20)
        {
            if (l20.odunsayisi <= l20.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l20.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 21)
        {
            if (l21.odunsayisi <= l21.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l21.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 22)
        {
            if (l22.odunsayisi <= l22.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l22.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 23)
        {
            if (l23.odunsayisi <= l23.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l23.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 24)
        {
            if (l24.odunsayisi <= l24.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l24.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 25)
        {
            if (l25.odunsayisi <= l25.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l25.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 26)
        {
            if (l26.odunsayisi <= l26.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l26.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 27)
        {
            if (l27.odunsayisi <= l27.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l27.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 28)
        {
            if (l28.odunsayisi <= l28.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l28.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 29)
        {
            if (l29.odunsayisi <= l29.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l29.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 30)
        {
            if (l30.odunsayisi <= l30.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l30.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 31)
        {
            if (l31.odunsayisi <= l31.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l31.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 32)
        {
            if (l32.odunsayisi <= l32.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l32.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 33)
        {
            if (l33.odunsayisi <= l33.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l33.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 34)
        {
            if (l34.odunsayisi <= l34.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l34.SpawnCylinder();
                }
            }
    
        }
        else if (GameManager.gm.currentlevel == 35)
        {
            if (l35.odunsayisi <= l35.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l35.SpawnCylinder();
                }
            }
 
        }
        else if (GameManager.gm.currentlevel == 36)
        {
            if (l36.odunsayisi <= l36.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l36.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 37)
        {
            if (l37.odunsayisi <= l37.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l37.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 38)
        {
            if (l38.odunsayisi <= l38.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l38.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 39)
        {
            if (l39.odunsayisi <= l39.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l39.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 40)
        {
            if (l40.odunsayisi <= l40.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l40.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 41)
        {
            if (l41.odunsayisi <= l41.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l41.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 42)
        {
            if (l42.odunsayisi <= l42.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l42.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 43)
        {
            if (l43.odunsayisi <= l43.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l43.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 44)
        {
            if (l44.odunsayisi <= l44.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l44.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 45)
        {
            if (l45.odunsayisi <= l45.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l45.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 46)
        {
            if (l46.odunsayisi <= l46.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l46.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 47)
        {
            if (l47.odunsayisi <= l47.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l47.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 48)
        {
            if (l48.odunsayisi <= l48.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l48.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 49)
        {
            if (l49.odunsayisi <= l49.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l49.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 50)
        {
            if (l50.odunsayisi <= l50.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l50.SpawnCylinder();
                }
            }

        }
        else if (GameManager.gm.currentlevel == 51)
        {
            if (l51.odunsayisi <= l51.windowtreenumber)
            {
                int ab = Physics.OverlapSphereNonAlloc(transform.position, 1f, aa, cyl_layer);
                if (ab <= 0)
                {
                    l51.SpawnCylinder();
                }
            }
        }
    }
}
