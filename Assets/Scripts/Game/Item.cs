using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
   public UnityEvent openEvent;

   public void Open()
   {
      openEvent?.Invoke();
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
      if(other.gameObject.GetComponent<Destroyer>())
         gameObject.GetComponent<Destroyable>().Destroy();
   }
}
