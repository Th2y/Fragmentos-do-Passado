using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

public class BotoesLink : MonoBehaviour
{
	[Serializable]
	public class EventoBotaoPressionado: UnityEvent { }

	public EventoBotaoPressionado OnPress = new EventoBotaoPressionado();

	public void OnPointerDown(PointerEventData eventData)
	{
		OnPress.Invoke();
	}
}
