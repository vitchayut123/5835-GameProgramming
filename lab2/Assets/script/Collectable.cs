using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : MonoBehaviour
{
   public CollectColor color;

   void Start()
   {
      if (TryGetComponent<RandomColor>(out RandomColor randomcolor))
      {
         color = randomcolor.color;
      }
   }

   CollectColor getColor()
   {
      return this.color;
   }

   void setColor(CollectColor color)
   {
      this.color = color;
   }
}