using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public GameObject panel;
    public bool restart = true;


    public GameObject DeathParticlesFrefab = null;
    public bool ShouldDestroyOnDeath = true;
    [SerializeField] private float _HealthPoints = 100f;
    public bool player = true;
    public float HealthPoints
    {
        get
        {
            return _HealthPoints;
        }
        
        set
        {
            _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                if (restart)
                {
                    panel.SetActive(true);
                }
                if (DeathParticlesFrefab != null)
                {
                    Instantiate(DeathParticlesFrefab, transform.position, transform.rotation);
                }
                if (ShouldDestroyOnDeath)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.B))
        {
            HealthPoints = 0;
            
        }
        

    }

    // Start is called before the first frame update

    public int numOfHearts;//
    public Image[] hearts;//
    public Sprite emptyHeart;//
    public Sprite fullHeart;//
    //newfunction

    private void FixedUpdate()
    {
        if (player is true)
        {
            if (HealthPoints > numOfHearts)
            {
                HealthPoints = numOfHearts;
            }
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < Mathf.RoundToInt(HealthPoints))
                {
                    hearts[i].sprite = fullHeart;
                }
                else
                {
                    hearts[i].sprite = emptyHeart;
                }
            }

            
        }
    }
    
    //newfunction

    private void AddHp()
    {
        if(HealthPoints < 3)
        {
            HealthPoints += 1;
        }
    }
    //newfunction
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Medicine")
        {
            AddHp();
            Destroy(GameObject.FindGameObjectWithTag("Medicine"));
        }
    }



}
