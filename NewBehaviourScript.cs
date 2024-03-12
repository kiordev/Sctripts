using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   // Публичное поле для задания цвета куба в редакторе Unity
    public Color newColor = Color.blue;

    void Update()
    {
        // Проверяем, нажата ли клавиша
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Получаем компонент Renderer текущего объекта (куба)
            Renderer renderer = GetComponent<Renderer>();

            // Изменяем цвет куба на новый заданный цвет
            renderer.material.color = newColor;
        }
    }
}
