using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManeger : MonoBehaviour
{
   #region Singleton

   public static playerManeger instance;

   void Awake (){

       instance = this;

       #endregion
   }

   public GameObject player;
   
}
