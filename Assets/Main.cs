using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Globals;
using Random = System.Random;

public class Main : MonoBehaviour
{
    public Material red;
    public Material purple;
    public Material orange;
    public Material yellow;
    public Material blue;
    public Material green;
    public Material transparent;
    public GameObject obj000;
    public GameObject obj100;
    public GameObject obj200;
    public GameObject obj300;
    public GameObject obj400;
    public GameObject obj010;
    public GameObject obj110;
    public GameObject obj210;
    public GameObject obj310;
    public GameObject obj410;
    public GameObject obj020;
    public GameObject obj120;
    public GameObject obj220;
    public GameObject obj320;
    public GameObject obj420;
    public GameObject obj030;
    public GameObject obj130;
    public GameObject obj230;
    public GameObject obj330;
    public GameObject obj430;
    public GameObject obj040;
    public GameObject obj140;
    public GameObject obj240;
    public GameObject obj340;
    public GameObject obj440;
    public GameObject obj001;
    public GameObject obj101;
    public GameObject obj201;
    public GameObject obj301;
    public GameObject obj401;
    public GameObject obj011;
    public GameObject obj111;
    public GameObject obj211;
    public GameObject obj311;
    public GameObject obj411;
    public GameObject obj021;
    public GameObject obj121;
    public GameObject obj221;
    public GameObject obj321;
    public GameObject obj421;
    public GameObject obj031;
    public GameObject obj131;
    public GameObject obj231;
    public GameObject obj331;
    public GameObject obj431;
    public GameObject obj041;
    public GameObject obj141;
    public GameObject obj241;
    public GameObject obj341;
    public GameObject obj441;
    public GameObject obj002;
    public GameObject obj102;
    public GameObject obj202;
    public GameObject obj302;
    public GameObject obj402;
    public GameObject obj012;
    public GameObject obj112;
    public GameObject obj212;
    public GameObject obj312;
    public GameObject obj412;
    public GameObject obj022;
    public GameObject obj122;
    public GameObject obj222;
    public GameObject obj322;
    public GameObject obj422;
    public GameObject obj032;
    public GameObject obj132;
    public GameObject obj232;
    public GameObject obj332;
    public GameObject obj432;
    public GameObject obj042;
    public GameObject obj142;
    public GameObject obj242;
    public GameObject obj342;
    public GameObject obj442;
    public GameObject obj003;
    public GameObject obj103;
    public GameObject obj203;
    public GameObject obj303;
    public GameObject obj403;
    public GameObject obj013;
    public GameObject obj113;
    public GameObject obj213;
    public GameObject obj313;
    public GameObject obj413;
    public GameObject obj023;
    public GameObject obj123;
    public GameObject obj223;
    public GameObject obj323;
    public GameObject obj423;
    public GameObject obj033;
    public GameObject obj133;
    public GameObject obj233;
    public GameObject obj333;
    public GameObject obj433;
    public GameObject obj043;
    public GameObject obj143;
    public GameObject obj243;
    public GameObject obj343;
    public GameObject obj443;
    public GameObject obj004;
    public GameObject obj104;
    public GameObject obj204;
    public GameObject obj304;
    public GameObject obj404;
    public GameObject obj014;
    public GameObject obj114;
    public GameObject obj214;
    public GameObject obj314;
    public GameObject obj414;
    public GameObject obj024;
    public GameObject obj124;
    public GameObject obj224;
    public GameObject obj324;
    public GameObject obj424;
    public GameObject obj034;
    public GameObject obj134;
    public GameObject obj234;
    public GameObject obj334;
    public GameObject obj434;
    public GameObject obj044;
    public GameObject obj144;
    public GameObject obj244;
    public GameObject obj344;
    public GameObject obj444;
    public GameObject obj005;
    public GameObject obj105;
    public GameObject obj205;
    public GameObject obj305;
    public GameObject obj405;
    public GameObject obj015;
    public GameObject obj115;
    public GameObject obj215;
    public GameObject obj315;
    public GameObject obj415;
    public GameObject obj025;
    public GameObject obj125;
    public GameObject obj225;
    public GameObject obj325;
    public GameObject obj425;
    public GameObject obj035;
    public GameObject obj135;
    public GameObject obj235;
    public GameObject obj335;
    public GameObject obj435;
    public GameObject obj045;
    public GameObject obj145;
    public GameObject obj245;
    public GameObject obj345;
    public GameObject obj445;
    public GameObject obj006;
    public GameObject obj106;
    public GameObject obj206;
    public GameObject obj306;
    public GameObject obj406;
    public GameObject obj016;
    public GameObject obj116;
    public GameObject obj216;
    public GameObject obj316;
    public GameObject obj416;
    public GameObject obj026;
    public GameObject obj126;
    public GameObject obj226;
    public GameObject obj326;
    public GameObject obj426;
    public GameObject obj036;
    public GameObject obj136;
    public GameObject obj236;
    public GameObject obj336;
    public GameObject obj436;
    public GameObject obj046;
    public GameObject obj146;
    public GameObject obj246;
    public GameObject obj346;
    public GameObject obj446;
    public GameObject obj007;
    public GameObject obj107;
    public GameObject obj207;
    public GameObject obj307;
    public GameObject obj407;
    public GameObject obj017;
    public GameObject obj117;
    public GameObject obj217;
    public GameObject obj317;
    public GameObject obj417;
    public GameObject obj027;
    public GameObject obj127;
    public GameObject obj227;
    public GameObject obj327;
    public GameObject obj427;
    public GameObject obj037;
    public GameObject obj137;
    public GameObject obj237;
    public GameObject obj337;
    public GameObject obj437;
    public GameObject obj047;
    public GameObject obj147;
    public GameObject obj247;
    public GameObject obj347;
    public GameObject obj447;
    public GameObject obj008;
    public GameObject obj108;
    public GameObject obj208;
    public GameObject obj308;
    public GameObject obj408;
    public GameObject obj018;
    public GameObject obj118;
    public GameObject obj218;
    public GameObject obj318;
    public GameObject obj418;
    public GameObject obj028;
    public GameObject obj128;
    public GameObject obj228;
    public GameObject obj328;
    public GameObject obj428;
    public GameObject obj038;
    public GameObject obj138;
    public GameObject obj238;
    public GameObject obj338;
    public GameObject obj438;
    public GameObject obj048;
    public GameObject obj148;
    public GameObject obj248;
    public GameObject obj348;
    public GameObject obj448;
    public GameObject obj009;
    public GameObject obj109;
    public GameObject obj209;
    public GameObject obj309;
    public GameObject obj409;
    public GameObject obj019;
    public GameObject obj119;
    public GameObject obj219;
    public GameObject obj319;
    public GameObject obj419;
    public GameObject obj029;
    public GameObject obj129;
    public GameObject obj229;
    public GameObject obj329;
    public GameObject obj429;
    public GameObject obj039;
    public GameObject obj139;
    public GameObject obj239;
    public GameObject obj339;
    public GameObject obj439;
    public GameObject obj049;
    public GameObject obj149;
    public GameObject obj249;
    public GameObject obj349;
    public GameObject obj449;
    public GameObject obj0010;
    public GameObject obj1010;
    public GameObject obj2010;
    public GameObject obj3010;
    public GameObject obj4010;
    public GameObject obj0110;
    public GameObject obj1110;
    public GameObject obj2110;
    public GameObject obj3110;
    public GameObject obj4110;
    public GameObject obj0210;
    public GameObject obj1210;
    public GameObject obj2210;
    public GameObject obj3210;
    public GameObject obj4210;
    public GameObject obj0310;
    public GameObject obj1310;
    public GameObject obj2310;
    public GameObject obj3310;
    public GameObject obj4310;
    public GameObject obj0410;
    public GameObject obj1410;
    public GameObject obj2410;
    public GameObject obj3410;
    public GameObject obj4410;
    public GameObject obj0011;
    public GameObject obj1011;
    public GameObject obj2011;
    public GameObject obj3011;
    public GameObject obj4011;
    public GameObject obj0111;
    public GameObject obj1111;
    public GameObject obj2111;
    public GameObject obj3111;
    public GameObject obj4111;
    public GameObject obj0211;
    public GameObject obj1211;
    public GameObject obj2211;
    public GameObject obj3211;
    public GameObject obj4211;
    public GameObject obj0311;
    public GameObject obj1311;
    public GameObject obj2311;
    public GameObject obj3311;
    public GameObject obj4311;
    public GameObject obj0411;
    public GameObject obj1411;
    public GameObject obj2411;
    public GameObject obj3411;
    public GameObject obj4411;
    public GameObject obj0012;
    public GameObject obj1012;
    public GameObject obj2012;
    public GameObject obj3012;
    public GameObject obj4012;
    public GameObject obj0112;
    public GameObject obj1112;
    public GameObject obj2112;
    public GameObject obj3112;
    public GameObject obj4112;
    public GameObject obj0212;
    public GameObject obj1212;
    public GameObject obj2212;
    public GameObject obj3212;
    public GameObject obj4212;
    public GameObject obj0312;
    public GameObject obj1312;
    public GameObject obj2312;
    public GameObject obj3312;
    public GameObject obj4312;
    public GameObject obj0412;
    public GameObject obj1412;
    public GameObject obj2412;
    public GameObject obj3412;
    public GameObject obj4412;
    public GameObject obj0013;
    public GameObject obj1013;
    public GameObject obj2013;
    public GameObject obj3013;
    public GameObject obj4013;
    public GameObject obj0113;
    public GameObject obj1113;
    public GameObject obj2113;
    public GameObject obj3113;
    public GameObject obj4113;
    public GameObject obj0213;
    public GameObject obj1213;
    public GameObject obj2213;
    public GameObject obj3213;
    public GameObject obj4213;
    public GameObject obj0313;
    public GameObject obj1313;
    public GameObject obj2313;
    public GameObject obj3313;
    public GameObject obj4313;
    public GameObject obj0413;
    public GameObject obj1413;
    public GameObject obj2413;
    public GameObject obj3413;
    public GameObject obj4413;
    public GameObject obj0014;
    public GameObject obj1014;
    public GameObject obj2014;
    public GameObject obj3014;
    public GameObject obj4014;
    public GameObject obj0114;
    public GameObject obj1114;
    public GameObject obj2114;
    public GameObject obj3114;
    public GameObject obj4114;
    public GameObject obj0214;
    public GameObject obj1214;
    public GameObject obj2214;
    public GameObject obj3214;
    public GameObject obj4214;
    public GameObject obj0314;
    public GameObject obj1314;
    public GameObject obj2314;
    public GameObject obj3314;
    public GameObject obj4314;
    public GameObject obj0414;
    public GameObject obj1414;
    public GameObject obj2414;
    public GameObject obj3414;
    public GameObject obj4414;
    Random rnd = new Random();
    int[,] psqr = new int[4, 3];
    int[,] osqr = new int[4, 3];
    int col;
    int a = 0;
    int dstr = 0;
    int lines = 0;
    int obrz;
    int obry;
    int speed = 30;
    Boolean s = true;
    Boolean ctrll = false;
    Boolean sft = true;
    int[,,] col1 = new int[5, 5, 15];
    Boolean chk1;
    Boolean fall = false;
    GameObject[,,] obj = new GameObject[5, 5, 15];
    // Start is called before the first frame update
    int[] main = new int[3];
    Boolean[,,] settled = new Boolean[5, 5, 15];
    void Zm(GameObject other, int color)
    {
        switch (color)
        {
            case 0:
                other.GetComponent<Renderer>().material = transparent;
                break;
            case 1:
                other.GetComponent<Renderer>().material = red;
                break;
            case 2:
                other.GetComponent<Renderer>().material = yellow;
                break;
            case 3:
                other.GetComponent<Renderer>().material = orange;
                break;
            case 4:
                other.GetComponent<Renderer>().material = green;
                break;
            case 5:
                other.GetComponent<Renderer>().material = blue;
                break;
            case 6:
                other.GetComponent<Renderer>().material = purple;
                break;
        }
    }
    void rand()
    {
        col = rnd.Next(1, 7);
        Boolean chk = true;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (settled[i, j, 14] && settled[i, j, 14]) chk = false;
            }
        }
        obrz = 0;
        obry = 0;
        if (chk)
        {
            switch (col)
            {
                case 1:
                    onemidthree();
                    break;
                case 2:
                    oneleftthree();
                    break;
                case 3:
                    onerightthree();
                    break;
                case 4:
                    twolefttwo();
                    break;
                case 5:
                    bar();
                    break;
                case 6:
                    square();
                    break;
            }
        }
        else
        {
            Globals.score = dstr;
            SceneManager.LoadScene(2);
        }
    }
    void onemidthree()
    {
        psqr[0, 0] = 2;
        psqr[0, 1] = 2;
        psqr[0, 2] = 14;
        psqr[1, 0] = 1;
        psqr[1, 1] = 2;
        psqr[1, 2] = 13;
        psqr[2, 0] = 2;
        psqr[2, 1] = 2;
        psqr[2, 2] = 13;
        psqr[3, 0] = 2;
        psqr[3, 1] = 1;
        psqr[3, 2] = 13;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void oneleftthree()
    {
        psqr[0, 0] = 1;
        psqr[0, 1] = 2;
        psqr[0, 2] = 14;
        psqr[1, 0] = 1;
        psqr[1, 1] = 2;
        psqr[1, 2] = 13;
        psqr[2, 0] = 2;
        psqr[2, 1] = 2;
        psqr[2, 2] = 13;
        psqr[3, 0] = 2;
        psqr[3, 1] = 1;
        psqr[3, 2] = 13;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void onerightthree()
    {
        psqr[0, 0] = 2;
        psqr[0, 1] = 1;
        psqr[0, 2] = 14;
        psqr[1, 0] = 1;
        psqr[1, 1] = 2;
        psqr[1, 2] = 13;
        psqr[2, 0] = 2;
        psqr[2, 1] = 2;
        psqr[2, 2] = 13;
        psqr[3, 0] = 2;
        psqr[3, 1] = 1;
        psqr[3, 2] = 13;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void twolefttwo()
    {
        psqr[1, 0] = 1;
        psqr[1, 1] = 2;
        psqr[1, 2] = 14;
        psqr[0, 0] = 2;
        psqr[0, 1] = 2;
        psqr[0, 2] = 14;
        psqr[2, 0] = 2;
        psqr[2, 1] = 2;
        psqr[2, 2] = 13;
        psqr[3, 0] = 2;
        psqr[3, 1] = 1;
        psqr[3, 2] = 13;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void bar()
    {
        psqr[0, 0] = 2;
        psqr[0, 1] = 4;
        psqr[0, 2] = 14;
        psqr[1, 0] = 2;
        psqr[1, 1] = 3;
        psqr[1, 2] = 14;
        psqr[2, 0] = 2;
        psqr[2, 1] = 2;
        psqr[2, 2] = 14;
        psqr[3, 0] = 2;
        psqr[3, 1] = 1;
        psqr[3, 2] = 14;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void square()
    {
        psqr[0, 0] = 2;
        psqr[0, 1] = 2;
        psqr[0, 2] = 14;
        psqr[1, 0] = 1;
        psqr[1, 1] = 2;
        psqr[1, 2] = 14;
        psqr[2, 0] = 2;
        psqr[2, 1] = 1;
        psqr[2, 2] = 14;
        psqr[3, 0] = 1;
        psqr[3, 1] = 1;
        psqr[3, 2] = 14;
        for (int i = 0; i < 4; i++)
        {
            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
        }
        fall = true;
    }
    void falling()
    {
        if ((psqr[0, 2] == 0 || psqr[1, 2] == 0 || psqr[2, 2] == 0 || psqr[3, 2] == 0) || (settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
        {
            settled[psqr[0, 0], psqr[0, 1], psqr[0, 2]] = true;
            settled[psqr[1, 0], psqr[1, 1], psqr[1, 2]] = true;
            settled[psqr[2, 0], psqr[2, 1], psqr[2, 2]] = true;
            settled[psqr[3, 0], psqr[3, 1], psqr[3, 2]] = true;
            col1[psqr[0, 0], psqr[0, 1], psqr[0, 2]] = col;
            col1[psqr[1, 0], psqr[1, 1], psqr[1, 2]] = col;
            col1[psqr[2, 0], psqr[2, 1], psqr[2, 2]] = col;
            col1[psqr[3, 0], psqr[3, 1], psqr[3, 2]] = col;
            fall = false;
            for (int i = 14; i > -1; i--)
            {
                chk1 = true;
                for (int o = 0; o < 5; o++)
                {
                    for (int p = 0; p < 5; p++)
                    {
                        if (!settled[o, p, i]) chk1 = false;
                    }
                }
                if (chk1)
                {
                    dstr++;
                    for (int j = i; j < 15; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            for (int l = 0; l < 5; l++)
                            {
                                if (j + 1 <= 14)
                                {
                                    settled[k, l, j] = settled[k, l, j + 1];
                                    switch (col1[k, l, j + 1])
                                    {
                                        case 0:
                                            obj[k, l, j].GetComponent<Renderer>().material = transparent;
                                            break;
                                        case 1:
                                            obj[k, l, j].GetComponent<Renderer>().material = red;
                                            break;
                                        case 2:
                                            obj[k, l, j].GetComponent<Renderer>().material = yellow;
                                            break;
                                        case 3:
                                            obj[k, l, j].GetComponent<Renderer>().material = orange;
                                            break;
                                        case 4:
                                            obj[k, l, j].GetComponent<Renderer>().material = green;
                                            break;
                                        case 5:
                                            obj[k, l, j].GetComponent<Renderer>().material = blue;
                                            break;
                                        case 6:
                                            obj[k, l, j].GetComponent<Renderer>().material = purple;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    i++;
                }
            }
            rand();
        }
        else
        {
            osqr[0, 0] = psqr[0, 0];
            osqr[1, 0] = psqr[1, 0];
            osqr[2, 0] = psqr[2, 0];
            osqr[3, 0] = psqr[3, 0];
            osqr[0, 1] = psqr[0, 1];
            osqr[1, 1] = psqr[1, 1];
            osqr[2, 1] = psqr[2, 1];
            osqr[3, 1] = psqr[3, 1];
            osqr[0, 2] = psqr[0, 2];
            osqr[1, 2] = psqr[1, 2];
            osqr[2, 2] = psqr[2, 2];
            osqr[3, 2] = psqr[3, 2];
            psqr[0, 2]--;
            psqr[1, 2]--;
            psqr[2, 2]--;
            psqr[3, 2]--;
            for (int i = 0; i < 4; i++)
            {
                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
            }
            for (int i = 0; i < 4; i++)
            {
                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
            }
        }
    }
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    col1[i, j, k] = 0;
                    settled[i, j, k] = false;
                }
            }
        }
        obj[0, 0, 0] = obj000;
        obj[0, 0, 1] = obj001;
        obj[0, 0, 2] = obj002;
        obj[0, 0, 3] = obj003;
        obj[0, 0, 4] = obj004;
        obj[0, 0, 5] = obj005;
        obj[0, 0, 6] = obj006;
        obj[0, 0, 7] = obj007;
        obj[0, 0, 8] = obj008;
        obj[0, 0, 9] = obj009;
        obj[0, 0, 10] = obj0010;
        obj[0, 0, 11] = obj0011;
        obj[0, 0, 12] = obj0012;
        obj[0, 0, 13] = obj0013;
        obj[0, 0, 14] = obj0014;
        obj[0, 1, 0] = obj010;
        obj[0, 1, 1] = obj011;
        obj[0, 1, 2] = obj012;
        obj[0, 1, 3] = obj013;
        obj[0, 1, 4] = obj014;
        obj[0, 1, 5] = obj015;
        obj[0, 1, 6] = obj016;
        obj[0, 1, 7] = obj017;
        obj[0, 1, 8] = obj018;
        obj[0, 1, 9] = obj019;
        obj[0, 1, 10] = obj0110;
        obj[0, 1, 11] = obj0111;
        obj[0, 1, 12] = obj0112;
        obj[0, 1, 13] = obj0113;
        obj[0, 1, 14] = obj0114;
        obj[0, 2, 0] = obj020;
        obj[0, 2, 1] = obj021;
        obj[0, 2, 2] = obj022;
        obj[0, 2, 3] = obj023;
        obj[0, 2, 4] = obj024;
        obj[0, 2, 5] = obj025;
        obj[0, 2, 6] = obj026;
        obj[0, 2, 7] = obj027;
        obj[0, 2, 8] = obj028;
        obj[0, 2, 9] = obj029;
        obj[0, 2, 10] = obj0210;
        obj[0, 2, 11] = obj0211;
        obj[0, 2, 12] = obj0212;
        obj[0, 2, 13] = obj0213;
        obj[0, 2, 14] = obj0214;
        obj[0, 3, 0] = obj030;
        obj[0, 3, 1] = obj031;
        obj[0, 3, 2] = obj032;
        obj[0, 3, 3] = obj033;
        obj[0, 3, 4] = obj034;
        obj[0, 3, 5] = obj035;
        obj[0, 3, 6] = obj036;
        obj[0, 3, 7] = obj037;
        obj[0, 3, 8] = obj038;
        obj[0, 3, 9] = obj039;
        obj[0, 3, 10] = obj0310;
        obj[0, 3, 11] = obj0311;
        obj[0, 3, 12] = obj0312;
        obj[0, 3, 13] = obj0313;
        obj[0, 3, 14] = obj0314;
        obj[0, 4, 0] = obj040;
        obj[0, 4, 1] = obj041;
        obj[0, 4, 2] = obj042;
        obj[0, 4, 3] = obj043;
        obj[0, 4, 4] = obj044;
        obj[0, 4, 5] = obj045;
        obj[0, 4, 6] = obj046;
        obj[0, 4, 7] = obj047;
        obj[0, 4, 8] = obj048;
        obj[0, 4, 9] = obj049;
        obj[0, 4, 10] = obj0410;
        obj[0, 4, 11] = obj0411;
        obj[0, 4, 12] = obj0412;
        obj[0, 4, 13] = obj0413;
        obj[0, 4, 14] = obj0414;
        obj[1, 0, 0] = obj100;
        obj[1, 0, 1] = obj101;
        obj[1, 0, 2] = obj102;
        obj[1, 0, 3] = obj103;
        obj[1, 0, 4] = obj104;
        obj[1, 0, 5] = obj105;
        obj[1, 0, 6] = obj106;
        obj[1, 0, 7] = obj107;
        obj[1, 0, 8] = obj108;
        obj[1, 0, 9] = obj109;
        obj[1, 0, 10] = obj1010;
        obj[1, 0, 11] = obj1011;
        obj[1, 0, 12] = obj1012;
        obj[1, 0, 13] = obj1013;
        obj[1, 0, 14] = obj1014;
        obj[1, 1, 0] = obj110;
        obj[1, 1, 1] = obj111;
        obj[1, 1, 2] = obj112;
        obj[1, 1, 3] = obj113;
        obj[1, 1, 4] = obj114;
        obj[1, 1, 5] = obj115;
        obj[1, 1, 6] = obj116;
        obj[1, 1, 7] = obj117;
        obj[1, 1, 8] = obj118;
        obj[1, 1, 9] = obj119;
        obj[1, 1, 10] = obj1110;
        obj[1, 1, 11] = obj1111;
        obj[1, 1, 12] = obj1112;
        obj[1, 1, 13] = obj1113;
        obj[1, 1, 14] = obj1114;
        obj[1, 2, 0] = obj120;
        obj[1, 2, 1] = obj121;
        obj[1, 2, 2] = obj122;
        obj[1, 2, 3] = obj123;
        obj[1, 2, 4] = obj124;
        obj[1, 2, 5] = obj125;
        obj[1, 2, 6] = obj126;
        obj[1, 2, 7] = obj127;
        obj[1, 2, 8] = obj128;
        obj[1, 2, 9] = obj129;
        obj[1, 2, 10] = obj1210;
        obj[1, 2, 11] = obj1211;
        obj[1, 2, 12] = obj1212;
        obj[1, 2, 13] = obj1213;
        obj[1, 2, 14] = obj1214;
        obj[1, 3, 0] = obj130;
        obj[1, 3, 1] = obj131;
        obj[1, 3, 2] = obj132;
        obj[1, 3, 3] = obj133;
        obj[1, 3, 4] = obj134;
        obj[1, 3, 5] = obj135;
        obj[1, 3, 6] = obj136;
        obj[1, 3, 7] = obj137;
        obj[1, 3, 8] = obj138;
        obj[1, 3, 9] = obj139;
        obj[1, 3, 10] = obj1310;
        obj[1, 3, 11] = obj1311;
        obj[1, 3, 12] = obj1312;
        obj[1, 3, 13] = obj1313;
        obj[1, 3, 14] = obj1314;
        obj[1, 4, 0] = obj140;
        obj[1, 4, 1] = obj141;
        obj[1, 4, 2] = obj142;
        obj[1, 4, 3] = obj143;
        obj[1, 4, 4] = obj144;
        obj[1, 4, 5] = obj145;
        obj[1, 4, 6] = obj146;
        obj[1, 4, 7] = obj147;
        obj[1, 4, 8] = obj148;
        obj[1, 4, 9] = obj149;
        obj[1, 4, 10] = obj1410;
        obj[1, 4, 11] = obj1411;
        obj[1, 4, 12] = obj1412;
        obj[1, 4, 13] = obj1413;
        obj[1, 4, 14] = obj1414;
        obj[2, 0, 0] = obj200;
        obj[2, 0, 1] = obj201;
        obj[2, 0, 2] = obj202;
        obj[2, 0, 3] = obj203;
        obj[2, 0, 4] = obj204;
        obj[2, 0, 5] = obj205;
        obj[2, 0, 6] = obj206;
        obj[2, 0, 7] = obj207;
        obj[2, 0, 8] = obj208;
        obj[2, 0, 9] = obj209;
        obj[2, 0, 10] = obj2010;
        obj[2, 0, 11] = obj2011;
        obj[2, 0, 12] = obj2012;
        obj[2, 0, 13] = obj2013;
        obj[2, 0, 14] = obj2014;
        obj[2, 1, 0] = obj210;
        obj[2, 1, 1] = obj211;
        obj[2, 1, 2] = obj212;
        obj[2, 1, 3] = obj213;
        obj[2, 1, 4] = obj214;
        obj[2, 1, 5] = obj215;
        obj[2, 1, 6] = obj216;
        obj[2, 1, 7] = obj217;
        obj[2, 1, 8] = obj218;
        obj[2, 1, 9] = obj219;
        obj[2, 1, 10] = obj2110;
        obj[2, 1, 11] = obj2111;
        obj[2, 1, 12] = obj2112;
        obj[2, 1, 13] = obj2113;
        obj[2, 1, 14] = obj2114;
        obj[2, 2, 0] = obj220;
        obj[2, 2, 1] = obj221;
        obj[2, 2, 2] = obj222;
        obj[2, 2, 3] = obj223;
        obj[2, 2, 4] = obj224;
        obj[2, 2, 5] = obj225;
        obj[2, 2, 6] = obj226;
        obj[2, 2, 7] = obj227;
        obj[2, 2, 8] = obj228;
        obj[2, 2, 9] = obj229;
        obj[2, 2, 10] = obj2210;
        obj[2, 2, 11] = obj2211;
        obj[2, 2, 12] = obj2212;
        obj[2, 2, 13] = obj2213;
        obj[2, 2, 14] = obj2214;
        obj[2, 3, 0] = obj230;
        obj[2, 3, 1] = obj231;
        obj[2, 3, 2] = obj232;
        obj[2, 3, 3] = obj233;
        obj[2, 3, 4] = obj234;
        obj[2, 3, 5] = obj235;
        obj[2, 3, 6] = obj236;
        obj[2, 3, 7] = obj237;
        obj[2, 3, 8] = obj238;
        obj[2, 3, 9] = obj239;
        obj[2, 3, 10] = obj2310;
        obj[2, 3, 11] = obj2311;
        obj[2, 3, 12] = obj2312;
        obj[2, 3, 13] = obj2313;
        obj[2, 3, 14] = obj2314;
        obj[2, 4, 0] = obj240;
        obj[2, 4, 1] = obj241;
        obj[2, 4, 2] = obj242;
        obj[2, 4, 3] = obj243;
        obj[2, 4, 4] = obj244;
        obj[2, 4, 5] = obj245;
        obj[2, 4, 6] = obj246;
        obj[2, 4, 7] = obj247;
        obj[2, 4, 8] = obj248;
        obj[2, 4, 9] = obj249;
        obj[2, 4, 10] = obj2410;
        obj[2, 4, 11] = obj2411;
        obj[2, 4, 12] = obj2412;
        obj[2, 4, 13] = obj2413;
        obj[2, 4, 14] = obj2414;
        obj[3, 0, 0] = obj300;
        obj[3, 0, 1] = obj301;
        obj[3, 0, 2] = obj302;
        obj[3, 0, 3] = obj303;
        obj[3, 0, 4] = obj304;
        obj[3, 0, 5] = obj305;
        obj[3, 0, 6] = obj306;
        obj[3, 0, 7] = obj307;
        obj[3, 0, 8] = obj308;
        obj[3, 0, 9] = obj309;
        obj[3, 0, 10] = obj3010;
        obj[3, 0, 11] = obj3011;
        obj[3, 0, 12] = obj3012;
        obj[3, 0, 13] = obj3013;
        obj[3, 0, 14] = obj3014;
        obj[3, 1, 0] = obj310;
        obj[3, 1, 1] = obj311;
        obj[3, 1, 2] = obj312;
        obj[3, 1, 3] = obj313;
        obj[3, 1, 4] = obj314;
        obj[3, 1, 5] = obj315;
        obj[3, 1, 6] = obj316;
        obj[3, 1, 7] = obj317;
        obj[3, 1, 8] = obj318;
        obj[3, 1, 9] = obj319;
        obj[3, 1, 10] = obj3110;
        obj[3, 1, 11] = obj3111;
        obj[3, 1, 12] = obj3112;
        obj[3, 1, 13] = obj3113;
        obj[3, 1, 14] = obj3114;
        obj[3, 2, 0] = obj320;
        obj[3, 2, 1] = obj321;
        obj[3, 2, 2] = obj322;
        obj[3, 2, 3] = obj323;
        obj[3, 2, 4] = obj324;
        obj[3, 2, 5] = obj325;
        obj[3, 2, 6] = obj326;
        obj[3, 2, 7] = obj327;
        obj[3, 2, 8] = obj328;
        obj[3, 2, 9] = obj329;
        obj[3, 2, 10] = obj3210;
        obj[3, 2, 11] = obj3211;
        obj[3, 2, 12] = obj3212;
        obj[3, 2, 13] = obj3213;
        obj[3, 2, 14] = obj3214;
        obj[3, 3, 0] = obj330;
        obj[3, 3, 1] = obj331;
        obj[3, 3, 2] = obj332;
        obj[3, 3, 3] = obj333;
        obj[3, 3, 4] = obj334;
        obj[3, 3, 5] = obj335;
        obj[3, 3, 6] = obj336;
        obj[3, 3, 7] = obj337;
        obj[3, 3, 8] = obj338;
        obj[3, 3, 9] = obj339;
        obj[3, 3, 10] = obj3310;
        obj[3, 3, 11] = obj3311;
        obj[3, 3, 12] = obj3312;
        obj[3, 3, 13] = obj3313;
        obj[3, 3, 14] = obj3314;
        obj[3, 4, 0] = obj340;
        obj[3, 4, 1] = obj341;
        obj[3, 4, 2] = obj342;
        obj[3, 4, 3] = obj343;
        obj[3, 4, 4] = obj344;
        obj[3, 4, 5] = obj345;
        obj[3, 4, 6] = obj346;
        obj[3, 4, 7] = obj347;
        obj[3, 4, 8] = obj348;
        obj[3, 4, 9] = obj349;
        obj[3, 4, 10] = obj3410;
        obj[3, 4, 11] = obj3411;
        obj[3, 4, 12] = obj3412;
        obj[3, 4, 13] = obj3413;
        obj[3, 4, 14] = obj3414;
        obj[4, 0, 0] = obj400;
        obj[4, 0, 1] = obj401;
        obj[4, 0, 2] = obj402;
        obj[4, 0, 3] = obj403;
        obj[4, 0, 4] = obj404;
        obj[4, 0, 5] = obj405;
        obj[4, 0, 6] = obj406;
        obj[4, 0, 7] = obj407;
        obj[4, 0, 8] = obj408;
        obj[4, 0, 9] = obj409;
        obj[4, 0, 10] = obj4010;
        obj[4, 0, 11] = obj4011;
        obj[4, 0, 12] = obj4012;
        obj[4, 0, 13] = obj4013;
        obj[4, 0, 14] = obj4014;
        obj[4, 1, 0] = obj410;
        obj[4, 1, 1] = obj411;
        obj[4, 1, 2] = obj412;
        obj[4, 1, 3] = obj413;
        obj[4, 1, 4] = obj414;
        obj[4, 1, 5] = obj415;
        obj[4, 1, 6] = obj416;
        obj[4, 1, 7] = obj417;
        obj[4, 1, 8] = obj418;
        obj[4, 1, 9] = obj419;
        obj[4, 1, 10] = obj4110;
        obj[4, 1, 11] = obj4111;
        obj[4, 1, 12] = obj4112;
        obj[4, 1, 13] = obj4113;
        obj[4, 1, 14] = obj4114;
        obj[4, 2, 0] = obj420;
        obj[4, 2, 1] = obj421;
        obj[4, 2, 2] = obj422;
        obj[4, 2, 3] = obj423;
        obj[4, 2, 4] = obj424;
        obj[4, 2, 5] = obj425;
        obj[4, 2, 6] = obj426;
        obj[4, 2, 7] = obj427;
        obj[4, 2, 8] = obj428;
        obj[4, 2, 9] = obj429;
        obj[4, 2, 10] = obj4210;
        obj[4, 2, 11] = obj4211;
        obj[4, 2, 12] = obj4212;
        obj[4, 2, 13] = obj4213;
        obj[4, 2, 14] = obj4214;
        obj[4, 3, 0] = obj430;
        obj[4, 3, 1] = obj431;
        obj[4, 3, 2] = obj432;
        obj[4, 3, 3] = obj433;
        obj[4, 3, 4] = obj434;
        obj[4, 3, 5] = obj435;
        obj[4, 3, 6] = obj436;
        obj[4, 3, 7] = obj437;
        obj[4, 3, 8] = obj438;
        obj[4, 3, 9] = obj439;
        obj[4, 3, 10] = obj4310;
        obj[4, 3, 11] = obj4311;
        obj[4, 3, 12] = obj4312;
        obj[4, 3, 13] = obj4313;
        obj[4, 3, 14] = obj4314;
        obj[4, 4, 0] = obj440;
        obj[4, 4, 1] = obj441;
        obj[4, 4, 2] = obj442;
        obj[4, 4, 3] = obj443;
        obj[4, 4, 4] = obj444;
        obj[4, 4, 5] = obj445;
        obj[4, 4, 6] = obj446;
        obj[4, 4, 7] = obj447;
        obj[4, 4, 8] = obj448;
        obj[4, 4, 9] = obj449;
        obj[4, 4, 10] = obj4410;
        obj[4, 4, 11] = obj4411;
        obj[4, 4, 12] = obj4412;
        obj[4, 4, 13] = obj4413;
        obj[4, 4, 14] = obj4414;
        rand();
    }

    // Update is called once per frame
    void Update()
    {
        if (fall)
        {
            if (a == speed)
            {
                falling();
                a = 0;
            }
            a++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (s)
            {
                a = 0;
                speed = 3;
                s = false;
            }
            else
            {
                speed = 30;
                s = true;
            } 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if ((psqr[0, 1] < 4 && psqr[1, 1] < 4 && psqr[2, 1] < 4 && psqr[3, 1] < 4) && !(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
            {
                osqr[0, 0] = psqr[0, 0];
                osqr[1, 0] = psqr[1, 0];
                osqr[2, 0] = psqr[2, 0];
                osqr[3, 0] = psqr[3, 0];
                osqr[0, 1] = psqr[0, 1];
                osqr[1, 1] = psqr[1, 1];
                osqr[2, 1] = psqr[2, 1];
                osqr[3, 1] = psqr[3, 1];
                osqr[0, 2] = psqr[0, 2];
                osqr[1, 2] = psqr[1, 2];
                osqr[2, 2] = psqr[2, 2];
                osqr[3, 2] = psqr[3, 2];
                psqr[0, 1]++;
                psqr[1, 1]++;
                psqr[2, 1]++;
                psqr[3, 1]++;
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                }
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if ((psqr[0, 1] > 0 && psqr[1, 1] > 0 && psqr[2, 1] > 0 && psqr[3, 1] > 0) && !(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1] - 1, psqr[2, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
            {
                osqr[0, 0] = psqr[0, 0];
                osqr[1, 0] = psqr[1, 0];
                osqr[2, 0] = psqr[2, 0];
                osqr[3, 0] = psqr[3, 0];
                osqr[0, 1] = psqr[0, 1];
                osqr[1, 1] = psqr[1, 1];
                osqr[2, 1] = psqr[2, 1];
                osqr[3, 1] = psqr[3, 1];
                osqr[0, 2] = psqr[0, 2];
                osqr[1, 2] = psqr[1, 2];
                osqr[2, 2] = psqr[2, 2];
                osqr[3, 2] = psqr[3, 2];
                psqr[0, 1]--;
                psqr[1, 1]--;
                psqr[2, 1]--;
                psqr[3, 1]--;
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                }
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if ((psqr[0, 0] < 4 && psqr[1, 0] < 4 && psqr[2, 0] < 4 && psqr[3, 0] < 4) && !(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0] + 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
            {
                osqr[0, 0] = psqr[0, 0];
                osqr[1, 0] = psqr[1, 0];
                osqr[2, 0] = psqr[2, 0];
                osqr[3, 0] = psqr[3, 0];
                osqr[0, 1] = psqr[0, 1];
                osqr[1, 1] = psqr[1, 1];
                osqr[2, 1] = psqr[2, 1];
                osqr[3, 1] = psqr[3, 1];
                osqr[0, 2] = psqr[0, 2];
                osqr[1, 2] = psqr[1, 2];
                osqr[2, 2] = psqr[2, 2];
                osqr[3, 2] = psqr[3, 2];
                psqr[0, 0]++;
                psqr[1, 0]++;
                psqr[2, 0]++;
                psqr[3, 0]++;
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                }
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if ((psqr[0, 0] > 0 && psqr[1, 0] > 0 && psqr[2, 0] > 0 && psqr[3, 0] > 0) && !(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0] - 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
            {
                osqr[0, 0] = psqr[0, 0];
                osqr[1, 0] = psqr[1, 0];
                osqr[2, 0] = psqr[2, 0];
                osqr[3, 0] = psqr[3, 0];
                osqr[0, 1] = psqr[0, 1];
                osqr[1, 1] = psqr[1, 1];
                osqr[2, 1] = psqr[2, 1];
                osqr[3, 1] = psqr[3, 1];
                osqr[0, 2] = psqr[0, 2];
                osqr[1, 2] = psqr[1, 2];
                osqr[2, 2] = psqr[2, 2];
                osqr[3, 2] = psqr[3, 2];
                psqr[0, 0]--;
                psqr[1, 0]--;
                psqr[2, 0]--;
                psqr[3, 0]--;
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                }
                for (int i = 0; i < 4; i++)
                {
                    Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (ctrll || obry == 0 || obrz == 0)
            {
                switch (col)
            {
                case 1:
                    switch (obrz)
                    {
                        case 0:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 0]++;
                                        psqr[2, 1]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 1]--;
                                        psqr[2, 0]--;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 0]--;
                                        psqr[2, 1]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 1]++;
                                        psqr[2, 0]++;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 1:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 0]++;
                                        psqr[2, 2]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 2]--;
                                        psqr[2, 0]--;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 0]--;
                                        psqr[2, 2]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 2]++;
                                        psqr[2, 0]++;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 1]++;
                                        psqr[2, 0]--;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 0]++;
                                        psqr[2, 1]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 1]--;
                                        psqr[2, 0]++;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 0]--;
                                        psqr[2, 1]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 0]++;
                                        psqr[2, 2]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 2]++;
                                        psqr[2, 0]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 0]--;
                                        psqr[2, 2]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 2]--;
                                        psqr[2, 0]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (obrz)
                    {
                        case 0:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]++;
                                        psqr[2, 1]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 1]--;
                                        psqr[2, 0]--;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]--;
                                        psqr[2, 1]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 1] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 1]++;
                                        psqr[2, 0]++;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 1:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]++;
                                        psqr[2, 2]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]--;
                                        psqr[2, 0]--;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]--;
                                        psqr[2, 2]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]++;
                                        psqr[2, 0]++;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 0]++;
                                        psqr[2, 2]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[2, 0] - 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 2]--;
                                        psqr[2, 0]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 0]--;
                                        psqr[2, 2]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[2, 0] + 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 2]++;
                                        psqr[2, 0]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]++;
                                        psqr[2, 2]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]++;
                                        psqr[2, 0]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]--;
                                        psqr[2, 2]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]--;
                                        psqr[2, 0]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (obrz)
                    {
                        case 0:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]++;
                                        psqr[2, 1]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 1]--;
                                        psqr[2, 0]--;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]--;
                                        psqr[2, 1]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 1] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 1]++;
                                        psqr[2, 0]++;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 1:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]++;
                                        psqr[2, 2]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]--;
                                        psqr[2, 0]--;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]--;
                                        psqr[2, 2]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]++;
                                        psqr[2, 0]++;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]--;
                                        psqr[2, 2]--;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 1]++;
                                        psqr[2, 1]++;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]++;
                                        psqr[2, 2]++;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[2, 0], psqr[2, 1] - 1, psqr[2, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 1]--;
                                        psqr[2, 1]--;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 0]++;
                                        psqr[2, 2]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]++;
                                        psqr[2, 0]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 0]--;
                                        psqr[2, 2]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]--;
                                        psqr[2, 0]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (obrz)
                    {
                        case 0:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 0]++;
                                        psqr[2, 1]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 1]--;
                                        psqr[2, 0]--;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 0]--;
                                        psqr[2, 1]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 1]++;
                                        psqr[2, 0]++;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 1:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[2, 0] - 1, psqr[2, 1], psqr[2, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 2]--;
                                        psqr[2, 0]--;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 0]++;
                                        psqr[2, 2]--;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[2, 0] + 1, psqr[2, 1], psqr[2, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 2]++;
                                        psqr[2, 0]++;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 0]--;
                                        psqr[2, 2]++;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[2, 0] - 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 1]++;
                                        psqr[2, 0]--;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 0]++;
                                        psqr[2, 1]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[2, 0] + 1, psqr[2, 1], psqr[2, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 1]--;
                                        psqr[2, 0]++;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 0]--;
                                        psqr[2, 1]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[2, 0] - 1, psqr[2, 1], psqr[2, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 2]++;
                                        psqr[2, 0]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 0]++;
                                        psqr[2, 2]++;
                                        psqr[3, 0]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[2, 0] + 1, psqr[2, 1], psqr[2, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 2]--;
                                        psqr[2, 0]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 0]--;
                                        psqr[2, 2]--;
                                        psqr[3, 0]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case 5:
                        if (obrz == 0)
                        {
                            switch (obry)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0] + 1, psqr[0, 1], psqr[0, 2]] || settled[psqr[0, 0] + 2, psqr[0, 1], psqr[0, 2]] || settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[1, 1]++;
                                        psqr[2, 0]++;
                                        psqr[2, 1] = psqr[2, 1] + 2;
                                        psqr[3, 1] = psqr[3, 1] + 3;
                                        psqr[3, 0] = psqr[3, 0] + 2;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    else if (!(settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]] || settled[psqr[3, 0] + 2, psqr[3, 1], psqr[3, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]--;
                                        psqr[0, 1] -= 3;
                                        psqr[1, 1] -= 2;
                                        psqr[2, 1]--;
                                        psqr[2, 0]++;
                                        psqr[3, 0] += 2;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[1, 0], psqr[1, 1] - 2, psqr[1, 2]] || settled[psqr[1, 0], psqr[1, 1] - 3, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 0]++;
                                        psqr[1, 1]--;
                                        psqr[2, 0]--;
                                        psqr[2, 1] = psqr[2, 1] - 2;
                                        psqr[3, 1] = psqr[3, 1] - 3;
                                        psqr[3, 0] = psqr[3, 0] - 2;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obry = 0;
                                    }
                                    break;
                            }
                        }
                    break;
                    case 6:
                        switch (obrz)
                        {
                            case 1:
                                switch (obry)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1]-1, psqr[0, 2]] || settled[psqr[2, 0], psqr[2, 1]-1, psqr[2, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 0]++;
                                            psqr[2, 1]--;
                                            psqr[3, 0]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0]-1, psqr[0, 1], psqr[0, 2]] || settled[psqr[2, 0]-1, psqr[2, 1], psqr[2, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 0]--;
                                            psqr[1, 1]--;
                                            psqr[2, 0]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 0]--;
                                            psqr[2, 1]++;
                                            psqr[3, 0]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0]+1, psqr[0, 1], psqr[0, 2]] || settled[psqr[2, 0]+1, psqr[2, 1], psqr[2, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 0]++;
                                            psqr[1, 1]++;
                                            psqr[2, 0]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 0;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (obry)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 0]--;
                                            psqr[1, 1]++;
                                            psqr[2, 0]--;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0] + 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[3, 0] + 1, psqr[3, 1], psqr[3, 2]] || settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 0]++;
                                            psqr[2, 1]++;
                                            psqr[3, 0]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]] || settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 0]++;
                                            psqr[1, 1]--;
                                            psqr[2, 0]++;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0] - 1, psqr[1, 1], psqr[1, 2]] || settled[psqr[3, 0] - 1, psqr[3, 1], psqr[3, 2]] || settled[psqr[0, 0] - 1, psqr[0, 1], psqr[0, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 0]--;
                                            psqr[2, 1]--;
                                            psqr[3, 0]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obry = 0;
                                        }
                                        break;
                                }   
                                break;
                            }
                        break;
                }
                sft = false;
                ctrll = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (sft || obrz == 0 || obry == 0)
            {
                switch (col)
                {
                    case 1:
                        switch (obry)
                        {
                            case 0:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch (obry)
                        {
                            case 0:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]++;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]--;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]--;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]++;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]++;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[2, 0], psqr[2, 1] - 1, psqr[2, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]++;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]--;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]--;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (obry)
                        {
                            case 0:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1] || settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1] || settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]++;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[2, 0], psqr[2, 1] - 1, psqr[2, 2]] || settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]++;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]--;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]--;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (obry)
                        {
                            case 0:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] - 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]--;
                                            psqr[2, 2]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]--;
                                            psqr[2, 1]--;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[0, 0], psqr[0, 1] + 1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]++;
                                            psqr[2, 2]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2] + 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]++;
                                            psqr[2, 1]++;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[2, 0], psqr[2, 1] + 1, psqr[2, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]--;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1] || settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]--;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]] || settled[psqr[2, 0], psqr[2, 1] - 1, psqr[2, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]++;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[2, 0], psqr[2, 1], psqr[2, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]++;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 2]--;
                                            psqr[2, 1]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 1]++;
                                            psqr[2, 2]++;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 2]++;
                                            psqr[2, 1]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 1]--;
                                            psqr[2, 2]--;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (obrz)
                                {
                                    case 0:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] + 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]--;
                                            psqr[1, 2]--;
                                            psqr[2, 2]++;
                                            psqr[3, 2]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 1;
                                        }
                                        break;
                                    case 1:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] + 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] - 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]--;
                                            psqr[1, 1]++;
                                            psqr[2, 1]--;
                                            psqr[3, 1]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 2;
                                        }
                                        break;
                                    case 2:
                                        if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[3, 0], psqr[3, 1], psqr[3, 2] - 1]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 1]++;
                                            psqr[1, 2]++;
                                            psqr[2, 2]--;
                                            psqr[3, 2]--;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 3;
                                        }
                                        break;
                                    case 3:
                                        if (!(settled[psqr[1, 0], psqr[1, 1] - 1, psqr[1, 2]] || settled[psqr[3, 0], psqr[3, 1] + 1, psqr[3, 2]]))
                                        {
                                            osqr[0, 0] = psqr[0, 0];
                                            osqr[1, 0] = psqr[1, 0];
                                            osqr[2, 0] = psqr[2, 0];
                                            osqr[3, 0] = psqr[3, 0];
                                            osqr[0, 1] = psqr[0, 1];
                                            osqr[1, 1] = psqr[1, 1];
                                            osqr[2, 1] = psqr[2, 1];
                                            osqr[3, 1] = psqr[3, 1];
                                            osqr[0, 2] = psqr[0, 2];
                                            osqr[1, 2] = psqr[1, 2];
                                            osqr[2, 2] = psqr[2, 2];
                                            osqr[3, 2] = psqr[3, 2];
                                            psqr[0, 2]++;
                                            psqr[1, 1]--;
                                            psqr[2, 1]++;
                                            psqr[3, 1]++;
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                            }
                                            for (int i = 0; i < 4; i++)
                                            {
                                                Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                            }
                                            obrz = 0;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (obrz)
                        {
                            case 0:
                            if (!(settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] - 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2] + 2]))
                            {
                                osqr[0, 0] = psqr[0, 0];
                                osqr[1, 0] = psqr[1, 0];
                                osqr[2, 0] = psqr[2, 0];
                                osqr[3, 0] = psqr[3, 0];
                                osqr[0, 1] = psqr[0, 1];
                                osqr[1, 1] = psqr[1, 1];
                                osqr[2, 1] = psqr[2, 1];
                                osqr[3, 1] = psqr[3, 1];
                                osqr[0, 2] = psqr[0, 2];
                                osqr[1, 2] = psqr[1, 2];
                                osqr[2, 2] = psqr[2, 2];
                                osqr[3, 2] = psqr[3, 2];
                                psqr[0, 0] = psqr[1, 0];
                                psqr[0, 1] = psqr[1, 1];
                                psqr[2, 0] = psqr[1, 0];
                                psqr[2, 1] = psqr[1, 1];
                                psqr[3, 0] = psqr[1, 0];
                                psqr[3, 1] = psqr[1, 1];
                                psqr[0, 2]--;
                                psqr[2, 2]++;
                                psqr[3, 2] += 2;
                                for (int i = 0; i < 4; i++)
                                {
                                    Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                }
                                for (int i = 0; i < 4; i++)
                                {
                                    Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                }
                                obrz = 1;
                            }
                             break;
                             case 1:
                                if (!(settled[psqr[1, 1], psqr[1, 1]-2, psqr[1, 2]] || settled[psqr[1, 0], psqr[1, 1]-1, psqr[1, 2]] || settled[psqr[1, 0], psqr[1, 1]+1, psqr[1, 2]]))
                                {
                                    osqr[0, 0] = psqr[0, 0];
                                    osqr[1, 0] = psqr[1, 0];
                                    osqr[2, 0] = psqr[2, 0];
                                    osqr[3, 0] = psqr[3, 0];
                                    osqr[0, 1] = psqr[0, 1];
                                    osqr[1, 1] = psqr[1, 1];
                                    osqr[2, 1] = psqr[2, 1];
                                    osqr[3, 1] = psqr[3, 1];
                                    osqr[0, 2] = psqr[0, 2];
                                    osqr[1, 2] = psqr[1, 2];
                                    osqr[2, 2] = psqr[2, 2];
                                    osqr[3, 2] = psqr[3, 2];
                                    psqr[0, 2] = psqr[1, 2];
                                    psqr[2, 2] = psqr[1, 2];
                                    psqr[3, 2] = psqr[1, 2];
                                    psqr[3, 1]-=2;
                                    psqr[2, 1]--;
                                    psqr[0, 1]++;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                    }
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                    }
                                    obrz = 0;
                                }
                                break;
                    }
                    break;
                    case 6:
                        if (obry == 0)
                        {
                            switch (obrz)
                            {
                                case 0:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2]+1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2]+1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]++;
                                        psqr[1, 2]++;
                                        psqr[2, 1]++;
                                        psqr[3, 1]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obrz = 1;
                                    }
                                    break;
                                case 1:
                                    if (!(settled[psqr[0, 0], psqr[0, 1]-1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1]-1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]--;
                                        psqr[1, 1]--;
                                        psqr[2, 2]++;
                                        psqr[3, 2]++;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obrz = 2;
                                    }
                                    break;
                                case 2:
                                    if (!(settled[psqr[0, 0], psqr[0, 1], psqr[0, 2]-1] || settled[psqr[1, 0], psqr[1, 1], psqr[1, 2]-1]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 2]--;
                                        psqr[1, 2]--;
                                        psqr[2, 1]--;
                                        psqr[3, 1]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obrz = 3;
                                    }
                                    break;
                                case 3:
                                    if (!(settled[psqr[0, 0], psqr[0, 1]+1, psqr[0, 2]] || settled[psqr[1, 0], psqr[1, 1]+1, psqr[1, 2]]))
                                    {
                                        osqr[0, 0] = psqr[0, 0];
                                        osqr[1, 0] = psqr[1, 0];
                                        osqr[2, 0] = psqr[2, 0];
                                        osqr[3, 0] = psqr[3, 0];
                                        osqr[0, 1] = psqr[0, 1];
                                        osqr[1, 1] = psqr[1, 1];
                                        osqr[2, 1] = psqr[2, 1];
                                        osqr[3, 1] = psqr[3, 1];
                                        osqr[0, 2] = psqr[0, 2];
                                        osqr[1, 2] = psqr[1, 2];
                                        osqr[2, 2] = psqr[2, 2];
                                        osqr[3, 2] = psqr[3, 2];
                                        psqr[0, 1]++;
                                        psqr[1, 1]++;
                                        psqr[2, 2]--;
                                        psqr[3, 2]--;
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[osqr[i, 0], osqr[i, 1], osqr[i, 2]], 0);
                                        }
                                        for (int i = 0; i < 4; i++)
                                        {
                                            Zm(obj[psqr[i, 0], psqr[i, 1], psqr[i, 2]], col);
                                        }
                                        obrz = 0;
                                    }
                                    break;
                            }
                            break;
                        }
                        break;
                    }
                sft = true;
                ctrll = false;
            }
        }
    }
}