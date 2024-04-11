using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeChecker : MonoBehaviour
{
    public ShapeSO shape;
    [SerializeField] private Image image;
    [SerializeField] Sprite CorrectSprite;
    [SerializeField] Sprite NeutralSprite;
    [SerializeField] Sprite WrongSprite;
    private void Start()
    {
        shape.isCorrect = false;
        image.sprite = NeutralSprite;
        shape.isCorrect = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        shape.isCorrect = other.gameObject.tag == shape.ShapeTag ? true : false;
        image.sprite = shape.isCorrect ? CorrectSprite : WrongSprite;
    }
    private void OnTriggerExit(Collider other)
    {
        shape.isCorrect = false;
        image.sprite = NeutralSprite;
    }
}
