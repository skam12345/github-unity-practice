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

    #region �÷��̾��� ������ �����ϴ� �ν��Ͻ�
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

    #region �ν��Ͻ� getter setter
    // ü��
    public float SetNGetHp
    {
        get { return hp; }
        set { hp = value; }
    }

    // ���ݷ�
    public float SetNGetAtk
    {
        get { return atk; }
        set { atk = value; }
    }

    // ����
    public float SetNGetDef
    {
        get { return def; }
        set { def = value; }
    }

    // �̵��ӵ�
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

    // ũ��Ƽ�� Ȯ��
    public float SetNGetCriRate
    {
        get { return cri_rate; }
        set { cri_rate = value; }
    }

    // ũ��Ƽ�� ���ܷ�
    public float SetNGetCriDmg
    {
        get { return cri_dmg; }
        set { cri_dmg = value; }
    }

    // �ʿ� ����ġ
    public int SetNGetExp
    {
        get { return exp; }
        set { exp = value; }
    }

    // �Ӽ�
    public int SetNGetElement
    {
        get { return element; }
        set { element = value; }
    }

    // �Ѱ� ����
    public int SetNGetOverPower
    {
        get { return overpower; }
        set { overpower = value; }
    }

    // ��
    public int SetNGetMoney
    {
        get { return money; }
        set { money = value; }
    }
    #endregion


    #region ���� ������ �� �����ϴ� �Լ�
    public void SaveData()
    {
        #region ĳ���� ���� ����
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
