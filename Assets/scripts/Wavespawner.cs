using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Wavespawner : MonoBehaviour
{

    public enum SpawnState {SPAWNING, WAITING, COUNTING};

    
    


    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count = 3;
        public float rate;
        


    }

    public int Count = 3;

    public Wave [] waves;
    private int nextWave = 0;

    public Transform[] spawnpoints;

    public float TimeBetweenWaves = 5f;
    public float WaveCountDown;

    public TextMeshProUGUI wavecountertext;

    public int wavecounter = 1;

    private float seartchCoundDown = 1f;

    private SpawnState state = SpawnState.COUNTING;

     

    

    



    void Start()
    {
        WaveCountDown = TimeBetweenWaves;
        

        

        


    }

    void Update ()
    {
         wavecountertext.text= "Wave: " + wavecounter.ToString();
        
            if (state == SpawnState.WAITING)
            {
                if (!EnemyIsAlive())
                {
                    WaveComplete();

                }
                else
                {
                    return;
                }


            }

            if (WaveCountDown <=0)
            {


            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine ( SpawnWave ( waves[nextWave] ) );

            }

        }
        else
        {
           WaveCountDown -= Time.deltaTime; 
        }
        
    }
   public Enemy enemyomhoog;

   

    void WaveComplete()
    {
        Debug.Log("wave complete");

        state = SpawnState.COUNTING;
        WaveCountDown = TimeBetweenWaves;
        Count += 3;
        wavecounter += 1;
        Enemy Enemy = GetComponent <Enemy>();
        

        enemyomhoog.hpup();
        

        

        
        
        
        

        
        
        
        

        
        
       
        

        
        
         
        

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("all waves Completed");
            
                     
        }
        else
        {
            nextWave ++;

        }

        
        

        

    }

    bool EnemyIsAlive()
    {
        seartchCoundDown -= Time.deltaTime;

        if (seartchCoundDown <= 0f)
        {
            seartchCoundDown =1f;
            if (GameObject.FindGameObjectWithTag("Enemy")==null)
        {

            return false;


        }
        }
        
        

        return true;


    }
    public Mony mony;

    IEnumerator SpawnWave (Wave _wave)
    {
        Debug.Log ("spawningwave"+_wave.name);
        state = SpawnState.SPAWNING;


        for (int i = 0; i<Count; i++ )
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds (1f/_wave.rate);

            


        }
    



        state = SpawnState.WAITING;
        yield break;


    }

    void SpawnEnemy(Transform _enemy)
    {
        
        Debug.Log ("Spawning Enemy" + _enemy.name);
        Transform _sp= spawnpoints[Random.Range (0, spawnpoints.Length)];
        Instantiate (_enemy, _sp.position,_sp.rotation);
        


    }

   

    

}
