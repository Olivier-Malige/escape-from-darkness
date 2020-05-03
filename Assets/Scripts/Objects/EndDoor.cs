﻿using System;
using Managers;
using Player;
using UnityEngine;

namespace Objects
{
    public class EndDoor : UnityEngine.MonoBehaviour
    {
        private Animator _animator;
        private UiManager _uiManager;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _uiManager = FindObjectOfType<UiManager>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") && PlayerItems.Instance.GoldKeys >= 1)
            {
                PlayerItems.Instance.GoldKeys--;
                _animator.SetTrigger("open");
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            _uiManager.ShowEndPanel();
        }

        private void OnTr(Collider2D other)
        {
            _uiManager.ShowEndPanel();
        }
    }
}