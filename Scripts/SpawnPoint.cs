
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public static SpawnPoint sppo;

    [SerializeField]
    private GameObject point;
    private GameObject previous_point;

    [SerializeField]
    private GameObject branch;

    private GameObject previous_branch;

    private Vector3 branchVector = new Vector3(0, 0, 90);

    public GameObject level1,level2,level3,level4,level5,level6,level7,level8,level9,level10,level11,level12,level13,level14,level15
        ,level16,level17,level18,level19,level20,level21,level22,level23,level24,level25,level26,level27,level28,level29,level30,level31,
        level32,level33,level34,level35,level36,level37,level38,level39,level40,level41,level42,level43,level44,level45,level46,level47,
        level48,level49,level50,level51;

    void Start()
    {
        level1 = GameObject.FindGameObjectWithTag("level1");
        level2 = GameObject.FindGameObjectWithTag("level2");
        level3 = GameObject.FindGameObjectWithTag("level3");
        level4 = GameObject.FindGameObjectWithTag("level4");
        level5 = GameObject.FindGameObjectWithTag("level5");
        level6 = GameObject.FindGameObjectWithTag("level6");
        level7 = GameObject.FindGameObjectWithTag("level7");
        level8 = GameObject.FindGameObjectWithTag("level8");
        level9 = GameObject.FindGameObjectWithTag("level9");
        level10 = GameObject.FindGameObjectWithTag("level10");
        level11 = GameObject.FindGameObjectWithTag("level11");
        level12 = GameObject.FindGameObjectWithTag("level12");
        level13 = GameObject.FindGameObjectWithTag("level13");
        level14 = GameObject.FindGameObjectWithTag("level14");
        level15 = GameObject.FindGameObjectWithTag("level15");
        level16 = GameObject.FindGameObjectWithTag("level16");
        level17 = GameObject.FindGameObjectWithTag("level17");
        level18 = GameObject.FindGameObjectWithTag("level18");
        level19 = GameObject.FindGameObjectWithTag("level19");
        level20 = GameObject.FindGameObjectWithTag("level20");
        level21 = GameObject.FindGameObjectWithTag("level21");
        level22 = GameObject.FindGameObjectWithTag("level22");
        level23 = GameObject.FindGameObjectWithTag("level23");
        level24 = GameObject.FindGameObjectWithTag("level24");
        level25 = GameObject.FindGameObjectWithTag("level25");
        level26 = GameObject.FindGameObjectWithTag("level26");
        level27 = GameObject.FindGameObjectWithTag("level27");
        level28 = GameObject.FindGameObjectWithTag("level28");
        level29 = GameObject.FindGameObjectWithTag("level29");
        level30 = GameObject.FindGameObjectWithTag("level30");
        level31 = GameObject.FindGameObjectWithTag("level31");
        level32 = GameObject.FindGameObjectWithTag("level32");
        level33 = GameObject.FindGameObjectWithTag("level33");
        level34 = GameObject.FindGameObjectWithTag("level34");
        level35 = GameObject.FindGameObjectWithTag("level35");
        level36 = GameObject.FindGameObjectWithTag("level36");
        level37 = GameObject.FindGameObjectWithTag("level37");
        level38 = GameObject.FindGameObjectWithTag("level38");
        level39 = GameObject.FindGameObjectWithTag("level39");
        level40 = GameObject.FindGameObjectWithTag("level40");
        level41 = GameObject.FindGameObjectWithTag("level41");
        level42 = GameObject.FindGameObjectWithTag("level42");
        level43 = GameObject.FindGameObjectWithTag("level43");
        level44 = GameObject.FindGameObjectWithTag("level44");
        level45 = GameObject.FindGameObjectWithTag("level45");
        level46 = GameObject.FindGameObjectWithTag("level46");
        level47 = GameObject.FindGameObjectWithTag("level47");
        level48 = GameObject.FindGameObjectWithTag("level48");
        level49 = GameObject.FindGameObjectWithTag("level49");
        level50 = GameObject.FindGameObjectWithTag("level50");
        level51 = GameObject.FindGameObjectWithTag("level51");

        sppo = this;
        #region currentlevel
        if (GameManager.gm.currentlevel == 1)
        {
            if (!gameObject.CompareTag("Enemy") && LevelGenerator.lv.odunsayisi >= 2 && LevelGenerator.lv.odunsayisi <= LevelGenerator.lv.windowtreenumber)
            {
                CreatePoints();
                CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 2)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.llg.odunsayisi >= 2 && headForLevelGeneration.hflg.llg.odunsayisi <= headForLevelGeneration.hflg.llg.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }

        }
        else if (GameManager.gm.currentlevel == 3)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l3.odunsayisi >= 2 && headForLevelGeneration.hflg.l3.odunsayisi <= headForLevelGeneration.hflg.l3.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 4)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l4.odunsayisi >= 2 && headForLevelGeneration.hflg.l4.odunsayisi <= headForLevelGeneration.hflg.l4.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 5)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l5.odunsayisi >= 2 && headForLevelGeneration.hflg.l5.odunsayisi <= headForLevelGeneration.hflg.l5.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 6)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l6.odunsayisi >= 2 && headForLevelGeneration.hflg.l6.odunsayisi <= headForLevelGeneration.hflg.l6.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 7)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l7.odunsayisi >= 2 && headForLevelGeneration.hflg.l7.odunsayisi <= headForLevelGeneration.hflg.l7.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 8)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l8.odunsayisi >= 2 && headForLevelGeneration.hflg.l8.odunsayisi <= headForLevelGeneration.hflg.l8.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 9)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l9.odunsayisi >= 2 && headForLevelGeneration.hflg.l9.odunsayisi <= headForLevelGeneration.hflg.l9.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 10)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l10.odunsayisi >= 2 && headForLevelGeneration.hflg.l10.odunsayisi <= headForLevelGeneration.hflg.l10.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 11)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l11.odunsayisi >= 2 && headForLevelGeneration.hflg.l11.odunsayisi <= headForLevelGeneration.hflg.l11.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 12)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l12.odunsayisi >= 2 && headForLevelGeneration.hflg.l12.odunsayisi <= headForLevelGeneration.hflg.l12.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 13)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l13.odunsayisi >= 2 && headForLevelGeneration.hflg.l13.odunsayisi <= headForLevelGeneration.hflg.l13.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 14)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l14.odunsayisi >= 2 && headForLevelGeneration.hflg.l14.odunsayisi <= headForLevelGeneration.hflg.l14.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 15)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l15.odunsayisi >= 2 && headForLevelGeneration.hflg.l15.odunsayisi <= headForLevelGeneration.hflg.l15.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 16)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l16.odunsayisi >= 2 && headForLevelGeneration.hflg.l16.odunsayisi <= headForLevelGeneration.hflg.l16.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 17)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l17.odunsayisi >= 2 && headForLevelGeneration.hflg.l17.odunsayisi <= headForLevelGeneration.hflg.l17.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 18)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l18.odunsayisi >= 2 && headForLevelGeneration.hflg.l18.odunsayisi <= headForLevelGeneration.hflg.l18.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 19)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l19.odunsayisi >= 2 && headForLevelGeneration.hflg.l19.odunsayisi <= headForLevelGeneration.hflg.l19.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 20)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l20.odunsayisi >= 2 && headForLevelGeneration.hflg.l20.odunsayisi <= headForLevelGeneration.hflg.l20.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 21)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l21.odunsayisi >= 2 && headForLevelGeneration.hflg.l21.odunsayisi <= headForLevelGeneration.hflg.l21.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 22)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l22.odunsayisi >= 2 && headForLevelGeneration.hflg.l22.odunsayisi <= headForLevelGeneration.hflg.l22.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 23)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l23.odunsayisi >= 2 && headForLevelGeneration.hflg.l23.odunsayisi <= headForLevelGeneration.hflg.l23.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 24)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l24.odunsayisi >= 2 && headForLevelGeneration.hflg.l24.odunsayisi <= headForLevelGeneration.hflg.l24.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 25)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l25.odunsayisi >= 2 && headForLevelGeneration.hflg.l25.odunsayisi <= headForLevelGeneration.hflg.l25.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 26)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l26.odunsayisi >= 2 && headForLevelGeneration.hflg.l26.odunsayisi <= headForLevelGeneration.hflg.l26.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 27)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l27.odunsayisi >= 2 && headForLevelGeneration.hflg.l27.odunsayisi <= headForLevelGeneration.hflg.l27.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 28)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l28.odunsayisi >= 2 && headForLevelGeneration.hflg.l28.odunsayisi <= headForLevelGeneration.hflg.l28.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 29)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l29.odunsayisi >= 2 && headForLevelGeneration.hflg.l29.odunsayisi <= headForLevelGeneration.hflg.l29.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 30)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l30.odunsayisi >= 2 && headForLevelGeneration.hflg.l30.odunsayisi <= headForLevelGeneration.hflg.l30.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 31)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l31.odunsayisi >= 2 && headForLevelGeneration.hflg.l31.odunsayisi <= headForLevelGeneration.hflg.l31.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 32)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l32.odunsayisi >= 2 && headForLevelGeneration.hflg.l32.odunsayisi <= headForLevelGeneration.hflg.l32.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 33)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l33.odunsayisi >= 2 && headForLevelGeneration.hflg.l33.odunsayisi <= headForLevelGeneration.hflg.l33.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 34)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l34.odunsayisi >= 2 && headForLevelGeneration.hflg.l34.odunsayisi <= headForLevelGeneration.hflg.l34.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 35)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l35.odunsayisi >= 2 && headForLevelGeneration.hflg.l35.odunsayisi <= headForLevelGeneration.hflg.l35.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 36)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l36.odunsayisi >= 2 && headForLevelGeneration.hflg.l36.odunsayisi <= headForLevelGeneration.hflg.l36.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 37)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l37.odunsayisi >= 2 && headForLevelGeneration.hflg.l37.odunsayisi <= headForLevelGeneration.hflg.l37.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 38)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l38.odunsayisi >= 2 && headForLevelGeneration.hflg.l38.odunsayisi <= headForLevelGeneration.hflg.l38.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 39)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l39.odunsayisi >= 2 && headForLevelGeneration.hflg.l39.odunsayisi <= headForLevelGeneration.hflg.l39.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 40)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l40.odunsayisi >= 2 && headForLevelGeneration.hflg.l40.odunsayisi <= headForLevelGeneration.hflg.l40.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 41)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l41.odunsayisi >= 2 && headForLevelGeneration.hflg.l41.odunsayisi <= headForLevelGeneration.hflg.l41.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 42)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l42.odunsayisi >= 2 && headForLevelGeneration.hflg.l42.odunsayisi <= headForLevelGeneration.hflg.l42.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 43)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l43.odunsayisi >= 2 && headForLevelGeneration.hflg.l43.odunsayisi <= headForLevelGeneration.hflg.l43.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 44)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l44.odunsayisi >= 2 && headForLevelGeneration.hflg.l44.odunsayisi <= headForLevelGeneration.hflg.l44.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 45)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l45.odunsayisi >= 2 && headForLevelGeneration.hflg.l45.odunsayisi <= headForLevelGeneration.hflg.l45.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 46)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l46.odunsayisi >= 2 && headForLevelGeneration.hflg.l46.odunsayisi <= headForLevelGeneration.hflg.l46.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 47)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l47.odunsayisi >= 2 && headForLevelGeneration.hflg.l47.odunsayisi <= headForLevelGeneration.hflg.l47.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 48)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l48.odunsayisi >= 2 && headForLevelGeneration.hflg.l48.odunsayisi <= headForLevelGeneration.hflg.l48.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 49)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l49.odunsayisi >= 2 && headForLevelGeneration.hflg.l49.odunsayisi <= headForLevelGeneration.hflg.l49.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 50)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l50.odunsayisi >= 2 && headForLevelGeneration.hflg.l50.odunsayisi <= headForLevelGeneration.hflg.l50.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 51)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l51.odunsayisi >= 2 && headForLevelGeneration.hflg.l51.odunsayisi <= headForLevelGeneration.hflg.l51.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
#endregion

    }

    public void CreatePoints()
    {
        float radius_cyl = transform.localScale.x / 2;
        float radius_cube = point.transform.localScale.x / 2 + 0.5f;

        float height = radius_cube + radius_cyl;

        float minRange = transform.position.z - transform.localScale.y;
        float maxRange = transform.position.z + transform.localScale.y;

        Vector3 pos = new Vector3(transform.position.x, transform.position.y + height, Random.Range(minRange,maxRange));

        previous_point = Instantiate(point, pos, Quaternion.identity);
        #region currentlevel
        if (GameManager.gm.currentlevel == 1)
        {
            previous_point.transform.parent = level1.transform;
        }
        else if (GameManager.gm.currentlevel == 2)
        {
            previous_point.transform.parent = level2.transform;
        }
        else if (GameManager.gm.currentlevel == 3)
        {
            previous_point.transform.parent = level3.transform;
        }
        else if (GameManager.gm.currentlevel == 4)
        {
            previous_point.transform.parent = level4.transform;
        }
        else if (GameManager.gm.currentlevel == 5)
        {
            previous_point.transform.parent = level5.transform;
        }
        else if (GameManager.gm.currentlevel == 6)
        {
            previous_point.transform.parent = level6.transform;
        }
        else if (GameManager.gm.currentlevel == 7)
        {
            previous_point.transform.parent = level7.transform;
        }
        else if (GameManager.gm.currentlevel == 8)
        {
            previous_point.transform.parent = level8.transform;
        }
        else if (GameManager.gm.currentlevel == 9)
        {
            previous_point.transform.parent = level9.transform;
        }
        else if (GameManager.gm.currentlevel == 10)
        {
            previous_point.transform.parent = level10.transform;
        }
        else if (GameManager.gm.currentlevel == 11)
        {
            previous_point.transform.parent = level11.transform;
        }
        else if (GameManager.gm.currentlevel == 12)
        {
            previous_point.transform.parent = level12.transform;
        }
        else if (GameManager.gm.currentlevel == 13)
        {
            previous_point.transform.parent = level13.transform;
        }
        else if (GameManager.gm.currentlevel == 14)
        {
            previous_point.transform.parent = level14.transform;
        }
        else if (GameManager.gm.currentlevel == 15)
        {
            previous_point.transform.parent = level15.transform;
        }
        else if (GameManager.gm.currentlevel == 16)
        {
            previous_point.transform.parent = level16.transform;
        }
        else if (GameManager.gm.currentlevel == 17)
        {
            previous_point.transform.parent = level17.transform;
        }
        else if (GameManager.gm.currentlevel == 18)
        {
            previous_point.transform.parent = level18.transform;
        }
        else if (GameManager.gm.currentlevel == 19)
        {
            previous_point.transform.parent = level19.transform;
        }
        else if (GameManager.gm.currentlevel == 20)
        {
            previous_point.transform.parent = level20.transform;
        }
        else if (GameManager.gm.currentlevel == 21)
        {
            previous_point.transform.parent = level21.transform;
        }
        else if (GameManager.gm.currentlevel == 22)
        {
            previous_point.transform.parent = level22.transform;
        }
        else if (GameManager.gm.currentlevel == 23)
        {
            previous_point.transform.parent = level23.transform;
        }
        else if (GameManager.gm.currentlevel == 24)
        {
            previous_point.transform.parent = level24.transform;
        }
        else if (GameManager.gm.currentlevel == 25)
        {
            previous_point.transform.parent = level25.transform;
        }
        else if (GameManager.gm.currentlevel == 26)
        {
            previous_point.transform.parent = level26.transform;
        }
        else if (GameManager.gm.currentlevel == 27)
        {
            previous_point.transform.parent = level27.transform;
        }
        else if (GameManager.gm.currentlevel == 28)
        {
            previous_point.transform.parent = level28.transform;
        }
        else if (GameManager.gm.currentlevel == 29)
        {
            previous_point.transform.parent = level29.transform;
        }
        else if (GameManager.gm.currentlevel == 30)
        {
            previous_point.transform.parent = level30.transform;
        }
        else if (GameManager.gm.currentlevel == 31)
        {
            previous_point.transform.parent = level31.transform;
        }
        else if (GameManager.gm.currentlevel == 32)
        {
            previous_point.transform.parent = level32.transform;
        }
        else if (GameManager.gm.currentlevel == 33)
        {
            previous_point.transform.parent = level33.transform;
        }
        else if (GameManager.gm.currentlevel == 34)
        {
            previous_point.transform.parent = level34.transform;
        }
        else if (GameManager.gm.currentlevel == 35)
        {
            previous_point.transform.parent = level35.transform;
        }
        else if (GameManager.gm.currentlevel == 36)
        {
            previous_point.transform.parent = level36.transform;
        }
        else if (GameManager.gm.currentlevel == 37)
        {
            previous_point.transform.parent = level37.transform;
        }
        else if (GameManager.gm.currentlevel == 38)
        {
            previous_point.transform.parent = level38.transform;
        }
        else if (GameManager.gm.currentlevel == 39)
        {
            previous_point.transform.parent = level39.transform;
        }
        else if (GameManager.gm.currentlevel == 40)
        {
            previous_point.transform.parent = level40.transform;
        }
        else if (GameManager.gm.currentlevel == 41)
        {
            previous_point.transform.parent = level41.transform;
        }
        else if (GameManager.gm.currentlevel == 42)
        {
            previous_point.transform.parent = level42.transform;
        }
        else if (GameManager.gm.currentlevel == 43)
        {
            previous_point.transform.parent = level43.transform;
        }
        else if (GameManager.gm.currentlevel == 44)
        {
            previous_point.transform.parent = level44.transform;
        }
        else if (GameManager.gm.currentlevel == 45)
        {
            previous_point.transform.parent = level45.transform;
        }
        else if (GameManager.gm.currentlevel == 46)
        {
            previous_point.transform.parent = level46.transform;
        }
        else if (GameManager.gm.currentlevel == 47)
        {
            previous_point.transform.parent = level47.transform;
        }
        else if (GameManager.gm.currentlevel == 48)
        {
            previous_point.transform.parent = level48.transform;
        }
        else if (GameManager.gm.currentlevel == 49)
        {
            previous_point.transform.parent = level49.transform;
        }
        else if (GameManager.gm.currentlevel == 50)
        {
            previous_point.transform.parent = level50.transform;
        }
        else if (GameManager.gm.currentlevel == 51)
        {
            previous_point.transform.parent = level51.transform;
        }
        #endregion

    }

    public void restartCreatePoints()
    {
        if (GameManager.gm.pointsayac > 0)
        {
            Vector3 pos = new Vector3(GameManager.gm.a.x, GameManager.gm.a.y, GameManager.gm.a.z);
            previous_point = Instantiate(point, pos, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 1)
        {
            Vector3 pos1 = new Vector3(GameManager.gm.b.x, GameManager.gm.b.y, GameManager.gm.b.z);
            previous_point = Instantiate(point, pos1, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 2)
        {
            Vector3 pos2 = new Vector3(GameManager.gm.c.x, GameManager.gm.c.y, GameManager.gm.c.z);
            previous_point = Instantiate(point, pos2, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 3)
        {
            Vector3 pos3 = new Vector3(GameManager.gm.d.x, GameManager.gm.d.y, GameManager.gm.d.z);
            previous_point = Instantiate(point, pos3, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 4)
        {
            Vector3 pos4 = new Vector3(GameManager.gm.e.x, GameManager.gm.e.y, GameManager.gm.e.z);
            previous_point = Instantiate(point, pos4, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 5)
        {
            Vector3 pos5 = new Vector3(GameManager.gm.f.x, GameManager.gm.f.y, GameManager.gm.f.z);
            previous_point = Instantiate(point, pos5, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 6)
        {
            Vector3 pos6 = new Vector3(GameManager.gm.g.x, GameManager.gm.g.y, GameManager.gm.g.z);
            previous_point = Instantiate(point, pos6, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 7)
        {
            Vector3 pos7 = new Vector3(GameManager.gm.h.x, GameManager.gm.h.y, GameManager.gm.h.z);
            previous_point = Instantiate(point, pos7, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 8)
        {
            Vector3 pos8 = new Vector3(GameManager.gm.i.x, GameManager.gm.i.y, GameManager.gm.i.z);
            previous_point = Instantiate(point, pos8, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 9)
        {
            Vector3 pos9 = new Vector3(GameManager.gm.j.x, GameManager.gm.j.y, GameManager.gm.j.z);
            previous_point = Instantiate(point, pos9, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 10)
        {
            Vector3 pos10 = new Vector3(GameManager.gm.k.x, GameManager.gm.k.y, GameManager.gm.k.z);
            previous_point = Instantiate(point, pos10, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 11)
        {
            Vector3 pos11 = new Vector3(GameManager.gm.l.x, GameManager.gm.l.y, GameManager.gm.l.z);
            previous_point = Instantiate(point, pos11, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
        if (GameManager.gm.pointsayac > 12)
        {
            Vector3 pos12 = new Vector3(GameManager.gm.m.x, GameManager.gm.m.y, GameManager.gm.m.z);
            previous_point = Instantiate(point, pos12, Quaternion.identity);
            #region currentlevel
            if (GameManager.gm.currentlevel == 1)
            {
                previous_point.transform.parent = level1.transform;
            }
            else if (GameManager.gm.currentlevel == 2)
            {
                previous_point.transform.parent = level2.transform;
            }
            else if (GameManager.gm.currentlevel == 3)
            {
                previous_point.transform.parent = level3.transform;
            }
            else if (GameManager.gm.currentlevel == 4)
            {
                previous_point.transform.parent = level4.transform;
            }
            else if (GameManager.gm.currentlevel == 5)
            {
                previous_point.transform.parent = level5.transform;
            }
            else if (GameManager.gm.currentlevel == 6)
            {
                previous_point.transform.parent = level6.transform;
            }
            else if (GameManager.gm.currentlevel == 7)
            {
                previous_point.transform.parent = level7.transform;
            }
            else if (GameManager.gm.currentlevel == 8)
            {
                previous_point.transform.parent = level8.transform;
            }
            else if (GameManager.gm.currentlevel == 9)
            {
                previous_point.transform.parent = level9.transform;
            }
            else if (GameManager.gm.currentlevel == 10)
            {
                previous_point.transform.parent = level10.transform;
            }
            else if (GameManager.gm.currentlevel == 11)
            {
                previous_point.transform.parent = level11.transform;
            }
            else if (GameManager.gm.currentlevel == 12)
            {
                previous_point.transform.parent = level12.transform;
            }
            else if (GameManager.gm.currentlevel == 13)
            {
                previous_point.transform.parent = level13.transform;
            }
            else if (GameManager.gm.currentlevel == 14)
            {
                previous_point.transform.parent = level14.transform;
            }
            else if (GameManager.gm.currentlevel == 15)
            {
                previous_point.transform.parent = level15.transform;
            }
            else if (GameManager.gm.currentlevel == 16)
            {
                previous_point.transform.parent = level16.transform;
            }
            else if (GameManager.gm.currentlevel == 17)
            {
                previous_point.transform.parent = level17.transform;
            }
            else if (GameManager.gm.currentlevel == 18)
            {
                previous_point.transform.parent = level18.transform;
            }
            else if (GameManager.gm.currentlevel == 19)
            {
                previous_point.transform.parent = level19.transform;
            }
            else if (GameManager.gm.currentlevel == 20)
            {
                previous_point.transform.parent = level20.transform;
            }
            else if (GameManager.gm.currentlevel == 21)
            {
                previous_point.transform.parent = level21.transform;
            }
            else if (GameManager.gm.currentlevel == 22)
            {
                previous_point.transform.parent = level22.transform;
            }
            else if (GameManager.gm.currentlevel == 23)
            {
                previous_point.transform.parent = level23.transform;
            }
            else if (GameManager.gm.currentlevel == 24)
            {
                previous_point.transform.parent = level24.transform;
            }
            else if (GameManager.gm.currentlevel == 25)
            {
                previous_point.transform.parent = level25.transform;
            }
            else if (GameManager.gm.currentlevel == 26)
            {
                previous_point.transform.parent = level26.transform;
            }
            else if (GameManager.gm.currentlevel == 27)
            {
                previous_point.transform.parent = level27.transform;
            }
            else if (GameManager.gm.currentlevel == 28)
            {
                previous_point.transform.parent = level28.transform;
            }
            else if (GameManager.gm.currentlevel == 29)
            {
                previous_point.transform.parent = level29.transform;
            }
            else if (GameManager.gm.currentlevel == 30)
            {
                previous_point.transform.parent = level30.transform;
            }
            else if (GameManager.gm.currentlevel == 31)
            {
                previous_point.transform.parent = level31.transform;
            }
            else if (GameManager.gm.currentlevel == 32)
            {
                previous_point.transform.parent = level32.transform;
            }
            else if (GameManager.gm.currentlevel == 33)
            {
                previous_point.transform.parent = level33.transform;
            }
            else if (GameManager.gm.currentlevel == 34)
            {
                previous_point.transform.parent = level34.transform;
            }
            else if (GameManager.gm.currentlevel == 35)
            {
                previous_point.transform.parent = level35.transform;
            }
            else if (GameManager.gm.currentlevel == 36)
            {
                previous_point.transform.parent = level36.transform;
            }
            else if (GameManager.gm.currentlevel == 37)
            {
                previous_point.transform.parent = level37.transform;
            }
            else if (GameManager.gm.currentlevel == 38)
            {
                previous_point.transform.parent = level38.transform;
            }
            else if (GameManager.gm.currentlevel == 39)
            {
                previous_point.transform.parent = level39.transform;
            }
            else if (GameManager.gm.currentlevel == 40)
            {
                previous_point.transform.parent = level40.transform;
            }
            else if (GameManager.gm.currentlevel == 41)
            {
                previous_point.transform.parent = level41.transform;
            }
            else if (GameManager.gm.currentlevel == 42)
            {
                previous_point.transform.parent = level42.transform;
            }
            else if (GameManager.gm.currentlevel == 43)
            {
                previous_point.transform.parent = level43.transform;
            }
            else if (GameManager.gm.currentlevel == 44)
            {
                previous_point.transform.parent = level44.transform;
            }
            else if (GameManager.gm.currentlevel == 45)
            {
                previous_point.transform.parent = level45.transform;
            }
            else if (GameManager.gm.currentlevel == 46)
            {
                previous_point.transform.parent = level46.transform;
            }
            else if (GameManager.gm.currentlevel == 47)
            {
                previous_point.transform.parent = level47.transform;
            }
            else if (GameManager.gm.currentlevel == 48)
            {
                previous_point.transform.parent = level48.transform;
            }
            else if (GameManager.gm.currentlevel == 49)
            {
                previous_point.transform.parent = level49.transform;
            }
            else if (GameManager.gm.currentlevel == 50)
            {
                previous_point.transform.parent = level50.transform;
            }
            else if (GameManager.gm.currentlevel == 51)
            {
                previous_point.transform.parent = level51.transform;
            }
            #endregion
        }
    }

    public void CreateBranch()
    {
        float radius_cyl = transform.localScale.x / 2;

        float minRange = transform.position.z - transform.localScale.y + 1.3f;
        float maxRange = transform.position.z + transform.localScale.y - 0.3f;

        if (Random.value < 0.7f)
        {
            if (Random.value < 0.5f)
            {
                Vector3 pos = new Vector3(transform.position.x + radius_cyl, transform.position.y, Random.Range(minRange, maxRange));


                previous_branch = Instantiate(branch, pos, Quaternion.identity);
                previous_branch.transform.Rotate(branchVector);
                #region currentlevel
                if (GameManager.gm.currentlevel == 1)
                {
                    previous_branch.transform.parent = level1.transform;
                }
                else if (GameManager.gm.currentlevel == 2)
                {
                    previous_branch.transform.parent = level2.transform;
                }
                else if (GameManager.gm.currentlevel == 3)
                {
                    previous_branch.transform.parent = level3.transform;
                }
                else if (GameManager.gm.currentlevel == 4)
                {
                    previous_branch.transform.parent = level4.transform;
                }
                else if (GameManager.gm.currentlevel == 5)
                {
                    previous_branch.transform.parent = level5.transform;
                }
                else if (GameManager.gm.currentlevel == 6)
                {
                    previous_branch.transform.parent = level6.transform;
                }
                else if (GameManager.gm.currentlevel == 7)
                {
                    previous_branch.transform.parent = level7.transform;
                }
                else if (GameManager.gm.currentlevel == 8)
                {
                    previous_branch.transform.parent = level8.transform;
                }
                else if (GameManager.gm.currentlevel == 9)
                {
                    previous_branch.transform.parent = level9.transform;
                }
                else if (GameManager.gm.currentlevel == 10)
                {
                    previous_branch.transform.parent = level10.transform;
                }
                else if (GameManager.gm.currentlevel == 11)
                {
                    previous_branch.transform.parent = level11.transform;
                }
                else if (GameManager.gm.currentlevel == 12)
                {
                    previous_branch.transform.parent = level12.transform;
                }
                else if (GameManager.gm.currentlevel == 13)
                {
                    previous_branch.transform.parent = level13.transform;
                }
                else if (GameManager.gm.currentlevel == 14)
                {
                    previous_branch.transform.parent = level14.transform;
                }
                else if (GameManager.gm.currentlevel == 15)
                {
                    previous_branch.transform.parent = level15.transform;
                }
                else if (GameManager.gm.currentlevel == 16)
                {
                    previous_branch.transform.parent = level16.transform;
                }
                else if (GameManager.gm.currentlevel == 17)
                {
                    previous_branch.transform.parent = level17.transform;
                }
                else if (GameManager.gm.currentlevel == 18)
                {
                    previous_branch.transform.parent = level18.transform;
                }
                else if (GameManager.gm.currentlevel == 19)
                {
                    previous_branch.transform.parent = level19.transform;
                }
                else if (GameManager.gm.currentlevel == 20)
                {
                    previous_branch.transform.parent = level20.transform;
                }
                else if (GameManager.gm.currentlevel == 21)
                {
                    previous_branch.transform.parent = level21.transform;
                }
                else if (GameManager.gm.currentlevel == 22)
                {
                    previous_branch.transform.parent = level22.transform;
                }
                else if (GameManager.gm.currentlevel == 23)
                {
                    previous_branch.transform.parent = level23.transform;
                }
                else if (GameManager.gm.currentlevel == 24)
                {
                    previous_branch.transform.parent = level24.transform;
                }
                else if (GameManager.gm.currentlevel == 25)
                {
                    previous_branch.transform.parent = level25.transform;
                }
                else if (GameManager.gm.currentlevel == 26)
                {
                    previous_branch.transform.parent = level26.transform;
                }
                else if (GameManager.gm.currentlevel == 27)
                {
                    previous_branch.transform.parent = level27.transform;
                }
                else if (GameManager.gm.currentlevel == 28)
                {
                    previous_branch.transform.parent = level28.transform;
                }
                else if (GameManager.gm.currentlevel == 29)
                {
                    previous_branch.transform.parent = level29.transform;
                }
                else if (GameManager.gm.currentlevel == 30)
                {
                    previous_branch.transform.parent = level30.transform;
                }
                else if (GameManager.gm.currentlevel == 31)
                {
                    previous_branch.transform.parent = level31.transform;
                }
                else if (GameManager.gm.currentlevel == 32)
                {
                    previous_branch.transform.parent = level32.transform;
                }
                else if (GameManager.gm.currentlevel == 33)
                {
                    previous_branch.transform.parent = level33.transform;
                }
                else if (GameManager.gm.currentlevel == 34)
                {
                    previous_branch.transform.parent = level34.transform;
                }
                else if (GameManager.gm.currentlevel == 35)
                {
                    previous_branch.transform.parent = level35.transform;
                }
                else if (GameManager.gm.currentlevel == 36)
                {
                    previous_branch.transform.parent = level36.transform;
                }
                else if (GameManager.gm.currentlevel == 37)
                {
                    previous_branch.transform.parent = level37.transform;
                }
                else if (GameManager.gm.currentlevel == 38)
                {
                    previous_branch.transform.parent = level38.transform;
                }
                else if (GameManager.gm.currentlevel == 39)
                {
                    previous_branch.transform.parent = level39.transform;
                }
                else if (GameManager.gm.currentlevel == 40)
                {
                    previous_branch.transform.parent = level40.transform;
                }
                else if (GameManager.gm.currentlevel == 41)
                {
                    previous_branch.transform.parent = level41.transform;
                }
                else if (GameManager.gm.currentlevel == 42)
                {
                    previous_branch.transform.parent = level42.transform;
                }
                else if (GameManager.gm.currentlevel == 43)
                {
                    previous_branch.transform.parent = level43.transform;
                }
                else if (GameManager.gm.currentlevel == 44)
                {
                    previous_branch.transform.parent = level44.transform;
                }
                else if (GameManager.gm.currentlevel == 45)
                {
                    previous_branch.transform.parent = level45.transform;
                }
                else if (GameManager.gm.currentlevel == 46)
                {
                    previous_branch.transform.parent = level46.transform;
                }
                else if (GameManager.gm.currentlevel == 47)
                {
                    previous_branch.transform.parent = level47.transform;
                }
                else if (GameManager.gm.currentlevel == 48)
                {
                    previous_branch.transform.parent = level48.transform;
                }
                else if (GameManager.gm.currentlevel == 49)
                {
                    previous_branch.transform.parent = level49.transform;
                }
                else if (GameManager.gm.currentlevel == 50)
                {
                    previous_branch.transform.parent = level50.transform;
                }
                else if (GameManager.gm.currentlevel == 51)
                {
                    previous_branch.transform.parent = level51.transform;
                }
                #endregion
            }
            else if (Random.value < 0.5f)
            {
                Vector3 pos = new Vector3(transform.position.x - radius_cyl, transform.position.y, Random.Range(minRange, maxRange));


                previous_branch = Instantiate(branch, pos, Quaternion.identity);
                previous_branch.transform.Rotate(branchVector);
                #region currentlevel
                if (GameManager.gm.currentlevel == 1)
                {
                    previous_branch.transform.parent = level1.transform;
                }
                else if (GameManager.gm.currentlevel == 2)
                {
                    previous_branch.transform.parent = level2.transform;
                }
                else if (GameManager.gm.currentlevel == 3)
                {
                    previous_branch.transform.parent = level3.transform;
                }
                else if (GameManager.gm.currentlevel == 4)
                {
                    previous_branch.transform.parent = level4.transform;
                }
                else if (GameManager.gm.currentlevel == 5)
                {
                    previous_branch.transform.parent = level5.transform;
                }
                else if (GameManager.gm.currentlevel == 6)
                {
                    previous_branch.transform.parent = level6.transform;
                }
                else if (GameManager.gm.currentlevel == 7)
                {
                    previous_branch.transform.parent = level7.transform;
                }
                else if (GameManager.gm.currentlevel == 8)
                {
                    previous_branch.transform.parent = level8.transform;
                }
                else if (GameManager.gm.currentlevel == 9)
                {
                    previous_branch.transform.parent = level9.transform;
                }
                else if (GameManager.gm.currentlevel == 10)
                {
                    previous_branch.transform.parent = level10.transform;
                }
                else if (GameManager.gm.currentlevel == 11)
                {
                    previous_branch.transform.parent = level11.transform;
                }
                else if (GameManager.gm.currentlevel == 12)
                {
                    previous_branch.transform.parent = level12.transform;
                }
                else if (GameManager.gm.currentlevel == 13)
                {
                    previous_branch.transform.parent = level13.transform;
                }
                else if (GameManager.gm.currentlevel == 14)
                {
                    previous_branch.transform.parent = level14.transform;
                }
                else if (GameManager.gm.currentlevel == 15)
                {
                    previous_branch.transform.parent = level15.transform;
                }
                else if (GameManager.gm.currentlevel == 16)
                {
                    previous_branch.transform.parent = level16.transform;
                }
                else if (GameManager.gm.currentlevel == 17)
                {
                    previous_branch.transform.parent = level17.transform;
                }
                else if (GameManager.gm.currentlevel == 18)
                {
                    previous_branch.transform.parent = level18.transform;
                }
                else if (GameManager.gm.currentlevel == 19)
                {
                    previous_branch.transform.parent = level19.transform;
                }
                else if (GameManager.gm.currentlevel == 20)
                {
                    previous_branch.transform.parent = level20.transform;
                }
                else if (GameManager.gm.currentlevel == 21)
                {
                    previous_branch.transform.parent = level21.transform;
                }
                else if (GameManager.gm.currentlevel == 22)
                {
                    previous_branch.transform.parent = level22.transform;
                }
                else if (GameManager.gm.currentlevel == 23)
                {
                    previous_branch.transform.parent = level23.transform;
                }
                else if (GameManager.gm.currentlevel == 24)
                {
                    previous_branch.transform.parent = level24.transform;
                }
                else if (GameManager.gm.currentlevel == 25)
                {
                    previous_branch.transform.parent = level25.transform;
                }
                else if (GameManager.gm.currentlevel == 26)
                {
                    previous_branch.transform.parent = level26.transform;
                }
                else if (GameManager.gm.currentlevel == 27)
                {
                    previous_branch.transform.parent = level27.transform;
                }
                else if (GameManager.gm.currentlevel == 28)
                {
                    previous_branch.transform.parent = level28.transform;
                }
                else if (GameManager.gm.currentlevel == 29)
                {
                    previous_branch.transform.parent = level29.transform;
                }
                else if (GameManager.gm.currentlevel == 30)
                {
                    previous_branch.transform.parent = level30.transform;
                }
                else if (GameManager.gm.currentlevel == 31)
                {
                    previous_branch.transform.parent = level31.transform;
                }
                else if (GameManager.gm.currentlevel == 32)
                {
                    previous_branch.transform.parent = level32.transform;
                }
                else if (GameManager.gm.currentlevel == 33)
                {
                    previous_branch.transform.parent = level33.transform;
                }
                else if (GameManager.gm.currentlevel == 34)
                {
                    previous_branch.transform.parent = level34.transform;
                }
                else if (GameManager.gm.currentlevel == 35)
                {
                    previous_branch.transform.parent = level35.transform;
                }
                else if (GameManager.gm.currentlevel == 36)
                {
                    previous_branch.transform.parent = level36.transform;
                }
                else if (GameManager.gm.currentlevel == 37)
                {
                    previous_branch.transform.parent = level37.transform;
                }
                else if (GameManager.gm.currentlevel == 38)
                {
                    previous_branch.transform.parent = level38.transform;
                }
                else if (GameManager.gm.currentlevel == 39)
                {
                    previous_branch.transform.parent = level39.transform;
                }
                else if (GameManager.gm.currentlevel == 40)
                {
                    previous_branch.transform.parent = level40.transform;
                }
                else if (GameManager.gm.currentlevel == 41)
                {
                    previous_branch.transform.parent = level41.transform;
                }
                else if (GameManager.gm.currentlevel == 42)
                {
                    previous_branch.transform.parent = level42.transform;
                }
                else if (GameManager.gm.currentlevel == 43)
                {
                    previous_branch.transform.parent = level43.transform;
                }
                else if (GameManager.gm.currentlevel == 44)
                {
                    previous_branch.transform.parent = level44.transform;
                }
                else if (GameManager.gm.currentlevel == 45)
                {
                    previous_branch.transform.parent = level45.transform;
                }
                else if (GameManager.gm.currentlevel == 46)
                {
                    previous_branch.transform.parent = level46.transform;
                }
                else if (GameManager.gm.currentlevel == 47)
                {
                    previous_branch.transform.parent = level47.transform;
                }
                else if (GameManager.gm.currentlevel == 48)
                {
                    previous_branch.transform.parent = level48.transform;
                }
                else if (GameManager.gm.currentlevel == 49)
                {
                    previous_branch.transform.parent = level49.transform;
                }
                else if (GameManager.gm.currentlevel == 50)
                {
                    previous_branch.transform.parent = level50.transform;
                }
                else if (GameManager.gm.currentlevel == 51)
                {
                    previous_branch.transform.parent = level51.transform;
                }
                #endregion
            }

        }
    }

}
