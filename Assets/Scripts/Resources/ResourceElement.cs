﻿using System;
using UnityEngine;

namespace Resources
{
	public class ResourceElement : MonoBehaviour
	{
		[SerializeField] private int count = 1;
		[SerializeField] private ShipResource _resource;

		public int Count => count;
		public ShipResource Resource => _resource;

		public void Burn()
		{
			//animate to pop
			Destroy(gameObject);
		}

		public void SetAmount(int resourceAmount)
		{
			count = resourceAmount;
		}

		public void SetResource(ShipResource shipResource)
		{
			_resource = shipResource;
		}
	}
}