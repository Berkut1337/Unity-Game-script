using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    System.Random ran = new System.Random();
    public Animation Anim;
    public Animation Buttonanim1;
    public Animation Buttonanim2;
    public Animation panellevelanim;
    public Animation panellevelanim1;
    public GameObject panellevel;
    public GameObject panelmenu;
    public GameObject panelgame;
    public GameObject panellose;
    public GameObject panelwin;
    public GameObject Sprite1;
    public GameObject buttonlevel2;
    public Image circletime;
    public Sprite cat_sprite;
    public Sprite dog_sprite;
    public Sprite octopus_sprite;
    public Sprite belka_sprite;
    public Sprite wolf_sprite;
    public Sprite vorob_sprite;
    public Sprite homjak_sprite;
    public Sprite jiraf_sprite;
    public Sprite kuriza_sprite;
    public Sprite popugai_sprite;
    public Sprite ezik_sprite;
    public Sprite kakadu_sprite;
    public Sprite lev_sprite;
    public Sprite korova_sprite;
    public Sprite medved_sprite;
    public Sprite slon_sprite;
    public Sprite skorpion_sprite;
    public Sprite golub_sprite;
    public Sprite krisa_sprite;
    public Sprite akula_sprite;
    public Sprite zebra_sprite;
    public Sprite riss_sprite;
    public Sprite svinka_sprite;
    public Sprite okun_sprite;
    public Sprite kakad_sprite;
    public Sprite bogomol_sprite;
    public Sprite kalmar_sprite;
    public Sprite snigir_sprite;
    public Sprite kuznechik_sprite;
    public Sprite lebed_sprite;
    public Sprite krot_sprite;
    public Sprite manul_sprite;
    public Sprite babuin_sprite;
    public Sprite triton_sprite;
    public Sprite medoed_sprite;
    public Sprite kloun_sprite;
    public Sprite vidra_sprite;
    public Sprite tuhkan_sprite;
    public Sprite mol_sprite;
    public Sprite klech_sprite;
    public Sprite tukan_sprite;
    public Sprite piranja_sprite;
    public Sprite salamandra_sprite;
    public Sprite kivi_sprite;
    public Sprite molot_sprite;
    public Sprite tapir_sprite;
    public Sprite sajgak_sprite;
    public Sprite rosomacha_sprite;
    public Sprite herhen_sprite;
    public Sprite dolgopat_sprite;
    public Sprite omar_sprite;
    public Sprite palochnik_sprite;
    public Sprite trasoguzka_sprite;
    public Sprite murena_sprite;
    public Sprite vihuhol_sprite;
    public Sprite pangolin_sprite;
    public Sprite vombat_sprite;
    public Sprite nautiles_sprite;
    public Sprite mechehvost_sprite;
    public Sprite latimeria_sprite;
    public Sprite gavial_sprite;
    public Sprite izopod_sprite;
    public Sprite hitni_sprite;
    public Sprite gatteria_sprite;
    public Sprite binturong_sprite;
    public Sprite helezub_sprite;
    public Sprite fossa_sprite;
    public Sprite minoga_sprite;
    public Sprite gerenuk_sprite;
    public Sprite takin_sprite;
    public Sprite babirussa_sprite;
    public Text animaltext;
    public Text timetext;
    public Text numertext;



    public int i,k,j,t,n,u,l,c;
    public int m1, m2;
    public int[] b = new int[10];
    public double v;

    void Start()
    {
        u = 1;
        c = 1;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (c == 1)
            {
                panelmenu.SetActive(true);
                panellevel.SetActive(false);
                panellose.SetActive(false);
                panelwin.SetActive(false);
            }
            if (c == 0)
            {
                panellevelanim1.Play("panelgame1");
                c = 1;
                for (int x = 0; x < 10; x++)
                    b[x] = 0;
                n = 0;
                panellevel.SetActive(true);
                panelgame.SetActive(false);
                panellose.SetActive(false);
                panelwin.SetActive(false);
                StopCoroutine("time");
                StopCoroutine("texttime");
            }

        }
        if (k == 1)
            Sprite1.GetComponent<Image>().sprite = cat_sprite;
        if (k == 2)
            Sprite1.GetComponent<Image>().sprite = dog_sprite;
        if (k == 3)
            Sprite1.GetComponent<Image>().sprite = octopus_sprite;
        if (k == 4)
            Sprite1.GetComponent<Image>().sprite = belka_sprite;
        if (k == 5)
            Sprite1.GetComponent<Image>().sprite = wolf_sprite;
        if (k == 6)
            Sprite1.GetComponent<Image>().sprite = vorob_sprite;
        if (k == 7)
            Sprite1.GetComponent<Image>().sprite = homjak_sprite;
        if (k == 8)
            Sprite1.GetComponent<Image>().sprite = jiraf_sprite;
        if (k == 9)
            Sprite1.GetComponent<Image>().sprite = kuriza_sprite;
        if (k == 10)
            Sprite1.GetComponent<Image>().sprite = popugai_sprite;
        if (k == 11)
            Sprite1.GetComponent<Image>().sprite = ezik_sprite;
        if (k == 12)
            Sprite1.GetComponent<Image>().sprite = lev_sprite;
        if (k == 13)
            Sprite1.GetComponent<Image>().sprite = korova_sprite;
        if (k == 14)
            Sprite1.GetComponent<Image>().sprite = medved_sprite;
        if (k == 15)
            Sprite1.GetComponent<Image>().sprite = slon_sprite;
        if (k == 16)
            Sprite1.GetComponent<Image>().sprite = skorpion_sprite;
        if (k == 17)
            Sprite1.GetComponent<Image>().sprite = golub_sprite;
        if (k == 18)
            Sprite1.GetComponent<Image>().sprite = krisa_sprite;
        if (k == 19)
            Sprite1.GetComponent<Image>().sprite = akula_sprite;
        if (k == 20)
            Sprite1.GetComponent<Image>().sprite = zebra_sprite;
        if (k == 21)
            Sprite1.GetComponent<Image>().sprite = riss_sprite;
        if (k == 22)
            Sprite1.GetComponent<Image>().sprite = svinka_sprite;
        if (k == 23)
            Sprite1.GetComponent<Image>().sprite = okun_sprite;
        if (k == 24)
            Sprite1.GetComponent<Image>().sprite = kakadu_sprite;
        if (k == 25)
            Sprite1.GetComponent<Image>().sprite = bogomol_sprite;
        if (k == 26)
            Sprite1.GetComponent<Image>().sprite = kalmar_sprite;
        if (k == 27)
            Sprite1.GetComponent<Image>().sprite = snigir_sprite;
        if (k == 28)
            Sprite1.GetComponent<Image>().sprite = kuznechik_sprite;
        if (k == 29)
            Sprite1.GetComponent<Image>().sprite = lebed_sprite;
        if (k == 30)
            Sprite1.GetComponent<Image>().sprite = krot_sprite;
        if (k == 31)
            Sprite1.GetComponent<Image>().sprite = manul_sprite;
        if (k == 32)
            Sprite1.GetComponent<Image>().sprite = babuin_sprite;
        if (k == 33)
            Sprite1.GetComponent<Image>().sprite = triton_sprite;
        if (k == 34)
            Sprite1.GetComponent<Image>().sprite = medoed_sprite;
        if (k == 35)
            Sprite1.GetComponent<Image>().sprite = kloun_sprite;
        if (k == 36)
            Sprite1.GetComponent<Image>().sprite = vidra_sprite;
        if (k == 37)
            Sprite1.GetComponent<Image>().sprite = tuhkan_sprite;
        if (k == 38)
            Sprite1.GetComponent<Image>().sprite = mol_sprite;
        if (k == 39)
            Sprite1.GetComponent<Image>().sprite = klech_sprite;
        if (k == 40)
            Sprite1.GetComponent<Image>().sprite = tukan_sprite;
        if (k == 41)
            Sprite1.GetComponent<Image>().sprite = piranja_sprite;
        if (k == 42)
            Sprite1.GetComponent<Image>().sprite = salamandra_sprite;
        if (k == 43)
            Sprite1.GetComponent<Image>().sprite = kivi_sprite;
        if (k == 44)
            Sprite1.GetComponent<Image>().sprite = molot_sprite;
        if (k == 45)
            Sprite1.GetComponent<Image>().sprite = tapir_sprite;
        if (k == 46)
            Sprite1.GetComponent<Image>().sprite = sajgak_sprite;
        if (k == 47)
            Sprite1.GetComponent<Image>().sprite = rosomacha_sprite;
        if (k == 48)
            Sprite1.GetComponent<Image>().sprite = herhen_sprite;
        if (k == 49)
            Sprite1.GetComponent<Image>().sprite = dolgopat_sprite;
        if (k == 50)
            Sprite1.GetComponent<Image>().sprite = omar_sprite;
        if (k == 51)
            Sprite1.GetComponent<Image>().sprite = palochnik_sprite;
        if (k == 52)
            Sprite1.GetComponent<Image>().sprite = trasoguzka_sprite;
        if (k == 53)
            Sprite1.GetComponent<Image>().sprite = murena_sprite;
        if (k == 54)
            Sprite1.GetComponent<Image>().sprite = vihuhol_sprite;
        if (k == 55)
            Sprite1.GetComponent<Image>().sprite = pangolin_sprite;
        if (k == 56)
            Sprite1.GetComponent<Image>().sprite = vombat_sprite;
        if (k == 57)
            Sprite1.GetComponent<Image>().sprite = nautiles_sprite;
        if (k == 58)
            Sprite1.GetComponent<Image>().sprite = mechehvost_sprite;
        if (k == 59)
            Sprite1.GetComponent<Image>().sprite = latimeria_sprite;
        if (k == 60)
            Sprite1.GetComponent<Image>().sprite = gavial_sprite;
        if (k == 61)
            Sprite1.GetComponent<Image>().sprite = izopod_sprite;
        if (k == 62)
            Sprite1.GetComponent<Image>().sprite = hitni_sprite;
        if (k == 63)
            Sprite1.GetComponent<Image>().sprite = gatteria_sprite;
        if (k == 64)
            Sprite1.GetComponent<Image>().sprite = binturong_sprite;
        if (k == 65)
            Sprite1.GetComponent<Image>().sprite = helezub_sprite;
        if (k == 66)
            Sprite1.GetComponent<Image>().sprite = fossa_sprite;
        if (k == 67)
            Sprite1.GetComponent<Image>().sprite = minoga_sprite;
        if (k == 68)
            Sprite1.GetComponent<Image>().sprite = gerenuk_sprite;
        if (k == 69)
            Sprite1.GetComponent<Image>().sprite = takin_sprite;
        if (k == 70)
            Sprite1.GetComponent<Image>().sprite = babirussa_sprite;
        if (t == 1)
            animaltext.text = "Кот";
        if (t == 2)
            animaltext.text = "Собака";
        if (t == 3)
            animaltext.text = "Осьминог";
        if (t == 4)
            animaltext.text = "Белка";
        if (t == 5)
            animaltext.text = "Волк";
        if (t == 6)
            animaltext.text = "Воробей";
        if (t == 7)
            animaltext.text = "Хомяк";
        if (t == 8)
            animaltext.text = "Жираф";
        if (t == 9)
            animaltext.text = "Курица";
        if (t == 10)
            animaltext.text = "Попугай";
        if (t == 11)
            animaltext.text = "Ёжик";
        if (t == 12)
            animaltext.text = "Лев";
        if (t == 13)
            animaltext.text = "Корова";
        if (t == 14)
            animaltext.text = "Медведь";
        if (t == 15)
            animaltext.text = "Слон";
        if (t == 16)
            animaltext.text = "Скорпион";
        if (t == 17)
            animaltext.text = "Голубь";
        if (t == 18)
            animaltext.text = "Крыса";
        if (t == 19)
            animaltext.text = "Акула";
        if (t == 20)
            animaltext.text = "Зебра";
        if (t == 21)
            animaltext.text = "Рысь";
        if (t == 22)
            animaltext.text = "Морская свинка";
        if (t == 23)
            animaltext.text = "Окунь";
        if (t == 24)
            animaltext.text = "Какаду";
        if (t == 25)
            animaltext.text = "Богомол";
        if (t == 26)
            animaltext.text = "Кальмар";
        if (t == 27)
            animaltext.text = "Снегирь";
        if (t == 28)
            animaltext.text = "Кузнечик";
        if (t == 29)
            animaltext.text = "Лебедь";
        if (t == 30)
            animaltext.text = "Крот";
        if (t == 31)
            animaltext.text = "Манул";
        if (t == 32)
            animaltext.text = "Бабуин";
        if (t == 33)
            animaltext.text = "Тритон";
        if (t == 34)
            animaltext.text = "Медоед";
        if (t == 35)
            animaltext.text = "Рыба-клоун";
        if (t == 36)
            animaltext.text = "Выдра";
        if (t == 37)
            animaltext.text = "Тушканчик";
        if (t == 38)
            animaltext.text = "Моль";
        if (t == 39)
            animaltext.text = "Клещ";
        if (t == 40)
            animaltext.text = "Тукан";
        if (t == 41)
            animaltext.text = "Пиранья";
        if (t == 42)
            animaltext.text = "Саламандра";
        if (t == 43)
            animaltext.text = "Киви";
        if (t == 44)
            animaltext.text = "Акула-молот";
        if (t == 45)
            animaltext.text = "Тапир";
        if (t == 46)
            animaltext.text = "Сайгак";
        if (t == 47)
            animaltext.text = "Росомаха";
        if (t == 48)
            animaltext.text = "Шершень";
        if (t == 49)
            animaltext.text = "Долгопят";
        if (t == 50)
            animaltext.text = "Омар";
        if (t == 51)
            animaltext.text = "Палочник";
        if (t == 52)
            animaltext.text = "Трясогузка";
        if (t == 53)
            animaltext.text = "Мурена";
        if (t == 54)
            animaltext.text = "Выхухоль";
        if (t == 55)
            animaltext.text = "Панголин";
        if (t == 56)
            animaltext.text = "Вомбат";
        if (t == 57)
            animaltext.text = "Наутилус";
        if (t == 58)
            animaltext.text = "Мечехвост";
        if (t == 59)
            animaltext.text = "Латимерия";
        if (t == 60)
            animaltext.text = "Гавиал";
        if (t == 61)
            animaltext.text = "Изопод";
        if (t == 62)
            animaltext.text = "Щитни";
        if (t == 63)
            animaltext.text = "Гаттерия";
        if (t == 64)
            animaltext.text = "Бинтуронг";
        if (t == 65)
            animaltext.text = "Щелезуб";
        if (t == 66)
            animaltext.text = "Фосса";
        if (t == 67)
            animaltext.text = "Минога";
        if (t == 68)
            animaltext.text = "Геренук";
        if (t == 69)
            animaltext.text = "Такин";
        if (t == 70)
            animaltext.text = "Бабирусса";




        numertext.text = n + 1 + "/10";
    }


    public void calculated(int m1,int m2)
    {

        j = ran.Next(0, 2);

        k = ran.Next(m1, m2);
        for (int x = 0; x < 10; x++)
        {
            if (b[x] == k)
            {
                k = ran.Next(m1, m2);
                x = -1;
            }
        }

        for (int x = 0, x1 = 1; x < 10; x++)
        {
            if (b[x] == 0 && x1 == 1)
            {
                b[x] = k;
                x1 = 2;
            }
        }
        if (j == 1)
            t = ran.Next(m1, m2);               
        else       
            t = k;      
    }

    public void level()
    {
        StartCoroutine("time");
        //panellevel.SetActive(false);
        panelgame.SetActive(true);
    }

    public void level1()
    {
        if (c == 1)
        {
            panellevelanim.Play("panelgame");
            StartCoroutine("panelleveltime");
        }
        v = 3;
        l = 1;
        level();
        calculated(1,11);
    }

    public void level2()
    {
        if (u > 1)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 2;
            l = 2;
            level();
            calculated(11, 21);
        }   
    }

    public void level3()
    {
        if (u > 2)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 1.5;
            l = 3;
            level();
            calculated(21, 31);
        }
    }

    public void level4()
    {
        if (u > 3)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 1.5;
            l = 4;
            level();
            calculated(31, 41);
        }
    }

    public void level5()
    {
        if (u > 4)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 2;
            l = 5;
            level();
            calculated(41, 51);
        }
    }

    public void level6()
    {
        if (u > 5)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 2;
            l = 6;
            level();
            calculated(51, 61);
        }
    }

    public void level7()
    {
        if (u > 6)
        {
            if (c == 1)
            {
                panellevelanim.Play("panelgame");
                StartCoroutine("panelleveltime");
            }
            v = 2;
            l = 7;
            level();
            calculated(61, 71);
        }
    }

    public void buttonyes()
    {
        Buttonanim1.Play("button");
        StopCoroutine("time");
        StopCoroutine("texttime");
        if (k == t)
        {
            n++;
            if (n == 10)
            {
                //wintext.text = "Поздравляю вы открыли " + u + " уровень";
                n = 0;
                panelwin.SetActive(true);
            }
            else
            {
                if (l == 1)
                    level1();
                if (l == 2)
                    level2();
                if (l == 3)
                    level3();
                if (l == 4)
                    level4();
                if (l == 5)
                    level5();
                if (l == 6)
                    level6();
                if (l == 7)
                    level7();
            }
        }
        else
        {
            for (int x = 0; x < 10; x++)
                b[x] = 0;
            n = 0;
            panellose.SetActive(true);
            Anim.Play("Anim");
            
        }
    }

    public void buttonno()
    {
        Buttonanim2.Play("button");
        StopCoroutine("time");
        StopCoroutine("texttime");
        if (k != t)
        {
            n++;
            if (n == 10)
            {
                //wintext.text = "Поздравляю вы открыли " + u + "уровень";
                n = 0;
                panelwin.SetActive(true);
            }
            else
            {
                if (l == 1)
                    level1();
                if (l == 2)
                    level2();
                if (l == 3)
                    level3();
                if (l == 4)
                    level4();
                if (l == 5)
                    level5();
                if (l == 6)
                    level6();
                if (l == 7)
                    level7();
            }
        }
        else
        {
            for (int x = 0; x < 10; x++)
                b[x] = 0;
            n = 0;
            panellose.SetActive(true);
            Anim.Play("Anim");
         
        }
    }

    public void startlevel()
    {
        for (int x = 0; x < 10; x++)
            b[x] = 0;
        panelgame.SetActive(false);
        panelmenu.SetActive(false);
        panellevel.SetActive(true);
        panellevelanim1.Play("panelgame1");
        c = 1;
        panellose.SetActive(false);
        panelwin.SetActive(false);
    }

    public void golevel()
    {
        for (int x = 0; x < 10; x++)
            b[x] = 0;
        panelgame.SetActive(false);
        panelmenu.SetActive(false);
        panellevel.SetActive(true);
        panellevelanim1.Play("panelgame1");
        c = 1;
        panellose.SetActive(false);
        panelwin.SetActive(false);
        n = 0;
        u++;
    }

    public void buttonrestart()
    {
        panellose.SetActive(false);
        if (l == 1)
            level1();
        if (l == 2)
            level2();
        if (l == 3)
            level3();
        if (l == 4)
            level4();
        if (l == 5)
            level5();
        if (l == 6)
            level6();
        if (l == 7)
            level7();
    }

    public void buttonnext()
    {
        for (int x = 0; x < 10; x++)
            b[x] = 0;
        if (l == 1 )
        {
            u++;
            level2();
        }
        else if (l == 2 )
        {
            u++;
            level3();
        }
        else if (l == 3)
        {
            u++;
            level4();
        }
        else if (l == 4 )
        {     
            u++;
            level5();
        }
        else if (l == 5)
        {
            u++;
            level6();
        }
        else if (l == 6)
        {
            u++;
            level7();
        }
        else if (l == 7)
        {
            u++;
        }
        panelwin.SetActive(false);     
    }

    public void buttonquit()
    {
        Application.Quit();
    }

    public void PlayAudio(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    IEnumerator panelleveltime()
    {
        yield return new WaitForSeconds(0.2f);
        panellevel.SetActive(false);
        c = 0;
    }

    IEnumerator time()
    {
        StartCoroutine("texttime");
        if (l == 1)
            yield return new WaitForSeconds(3);
        if (l == 2)
            yield return new WaitForSeconds(2);
        if (l == 3)
            yield return new WaitForSeconds(2);
        if (l == 4)
            yield return new WaitForSeconds(2);
        if (l == 5)
            yield return new WaitForSeconds(2);
        if (l == 6)
            yield return new WaitForSeconds(2);
        if (l == 7)
            yield return new WaitForSeconds(2);
        panellose.SetActive(true);
        n = 0;
        StopCoroutine("texttime");
        v = 0;
    }

    IEnumerator texttime()
    {
        circletime.fillAmount = 1;
        while (v > 0)
        {
            timetext.text = "" + v;
            if (l == 1)
            {
                circletime.fillAmount -= 0.02f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 2)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 3)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 4)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 5)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 6)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
            if (l == 7)
            {
                circletime.fillAmount -= 0.03f;
                v = v - 0.06;
                yield return new WaitForSeconds(0.06f);
            }
        }
    }
}