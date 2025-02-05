using Unity.Android.Gradle;
using Unity.Notifications.iOS;
using UnityEngine;

public class ConfigCharacterStatus : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static ConfigCharacterStatus _instance;
    public static ConfigCharacterStatus Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ConfigCharacterStatus>();
            }

            return _instance;
        }
    }

    #region 플레이어의 정보를 저장하는 인스턴스
    private float hp;
    private float atk;
    private float def;
    private float spd_move;
    private float spd_atk;
    private float cri_rate;
    private float cri_dmg;
    private int exp;
    private int element;
    private int overpower;
    private int money;
    #endregion

    void Start()
    {

    }

    #region 인스턴스 getter setter
    // 체력
    public float SetNGetHp
    {
        get { return hp; }
        set { hp = value; }
    }

    // 공격력
    public float SetNGetAtk
    {
        get { return atk; }
        set { atk = value; }
    }

    // 방어력
    public float SetNGetDef
    {
        get { return def; }
        set { def = value; }
    }

    // 이동속도
    public float SetNGetSpdMove
    {
        get { return spd_move; }
        set { spd_move = value; }
    }

    public float SetNGetSpdAtk
    {
        get { return spd_atk; }
        set { spd_atk = value; }
    }

    // 크리티컬 확률
    public float SetNGetCriRate
    {
        get { return cri_rate; }
        set { cri_rate = value; }
    }

    // 크리티컬 공겨력
    public float SetNGetCriDmg
    {
        get { return cri_dmg; }
        set { cri_dmg = value; }
    }

    // 필요 경험치
    public int SetNGetExp
    {
        get { return exp; }
        set { exp = value; }
    }

    // 속성
    public int SetNGetElement
    {
        get { return element; }
        set { element = value; }
    }

    // 한계 돌파
    public int SetNGetOverPower
    {
        get { return overpower; }
        set { overpower = value; }
    }

    // 돈
    public int SetNGetMoney
    {
        get { return money; }
        set { money = value; }
    }
    #endregion


    #region 게임 종료할 때 저장하는 함수
    public void SaveData()
    {
        #region 캐릭터 정보 저장
        PlayerPrefs.SetFloat("hp", hp);
        PlayerPrefs.SetFloat("atk", atk);
        PlayerPrefs.SetFloat("def", def);
        PlayerPrefs.SetFloat("spd_move", spd_move);
        PlayerPrefs.SetFloat("spd_atk", spd_atk);
        PlayerPrefs.SetFloat("cri_rate", cri_rate);
        PlayerPrefs.SetFloat("cri_atk", cri_dmg);
        PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.SetInt("element", element);
        PlayerPrefs.SetInt("overpower", overpower);
        PlayerPrefs.SetInt("money", money);
        #endregion

        PlayerPrefs.Save();
    }
    #endregion


    // Update is called once per frame
    void Update()
    {
        
    }
}
