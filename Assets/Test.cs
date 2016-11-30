using UnityEngine;
using System.Collections;

public class Boss{

    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic(int magic)
    {
//        if (mp > magic) {  //　「>」⇒「>=」にしないとmpが丁度 5だった場合に魔法を発動することができない。修正！
        if (mp >= magic) {
            this.mp -= magic;
            Debug.Log("魔法攻撃をした。残りＭＰは" + mp + "。");
        }else{
            Debug.Log("ＭＰが足りないため魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {

        /*課題***************************************************************************
            要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
            配列の各要素の値を順番に表示してください
            for文を使い、配列の各要素の値を逆順に表示してください
        *********************************************************************************/

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = {11, 22, 33, 44, 55 };

        //配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示
        for (int i = 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        /*発展課題課題********************************************************************
            int型の変数mpを宣言し、53で初期化してください
            mpを消費して魔法攻撃をするMagic関数を作ってください
            Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
            mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
            Magic関数を呼び出して、魔法を使ってください
            Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
         *********************************************************************************/

        Boss lastboss = new Boss();

        for (int i = 0; i <= 10; i++) {
            lastboss.Magic(5);
        }


        //*********************************************************************************

        /*
                Boss lastboss = new Boss();

                lastboss.Attack();
                lastboss.Defence(3);

                Boss midboss = new Boss();

                midboss.Attack();
                midboss.Defence(5);
        */

        //        Debug.Log(lastboss.hp);

        //        Debug.Log("Hello, World");
        //        int score;
        //        score = 150;
        //        int score = 150;
        //        Debug.Log(score);
        /*
                int a = 7;
                int b = 2;

                int c = a + b;

                c--;

                Debug.Log(c);
        */
        /*
                int mony = 40;

                if (mony <= 50) {
                    Debug.Log("武器を売る");
                } else if(mony >= 200) {
                    Debug.Log("武器を買う");
                }else {
                    Debug.Log("ポーションを買う");
                }
        */
        /*
                int num = 2;

                int val = (num == 1) ? -100 : 100;
                Debug.Log(val);
        */
        // 変数aを3で初期化する
        /*
                int a = 3;
                if (a == 3)
                {
                    // 変数aが3の場合、変数bを5で初期化する
                    int b = 5;
                    // 変数bの値を表示する
                    Debug.Log(b);
                }
        */
        /*
                int sum = 0;

                for (int i = 1; i <= 10000; i++)
                {
                    sum += i;
                }
                    Debug.Log(sum);
        */
        /*        string[] points = new string[6];

                points[0] = "メンマ";
                points[1] = "ジンタン";
                points[2] = "アナル";
                points[3] = "アツユキ";
                points[4] = "ポッポ";
                points[5] = "ツルコ";

                for (int i = 0; i < 6; i++) {
                    Debug.Log(points[i]);
                }
        */
        /*
                int[] points = {30, 20, 50, 10, 80, 15, 60, 100 ,77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 , 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 200, 60, 30, 20, 50, 10, 80, 15, 60, 100, 77, 5, 9, 40, 88, 6, 21, 31, 99, 41, 60 };

                for (int i = 0; i < points.Length; i++) {
                    if (points[i] >= 50) {
                        Debug.Log(points[i]);
                    }
                }
        */
        //        Hello();
        //        Goodbye();
        //        HellowName("Unitychan");
        //        HellowNum(10);

        //        int num = Add(3, 6);
        //        string num = AddS("超平和バスターズは", "ずっと仲良し！");
        //        int num = Add2(3, 6, 9);
        //        Debug.Log(num);
    }

    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }
    void Goodbye()
    {
        Debug.Log("Goodbye, UnityChan");
    }
    void HellowName(string name)
    {
        Debug.Log("Hello, " + name);
    }
    void HellowNum(int num)
    {
        Debug.Log("Hello, " + num);
    }
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    int Add2(int a, int b, int c)
    {
        int d = a + b + c;
        return d;
    }
    string AddS(string a, string b)
    {
        string c = a + b;
        return c;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
