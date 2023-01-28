using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Globalization;

public class buttonListener : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI inputFieldFirstNumber;
    public TextMeshProUGUI inputFieldSecondNumber;
    public TextMeshProUGUI result;
    public int point;


    public void ShowResult1(){
        if (inputFieldFirstNumber.text == "15" && inputFieldSecondNumber.text == "20"){
            point++;

        }
        if (inputFieldFirstNumber.text == "20" && inputFieldSecondNumber.text == "15"){
            point++;
        }
    }
//1.Resultado: 18 Operación: +Opciones: 15, 8, 3, 17Correctas: 15 y 17
    public void ShowResult2(){
        if (inputFieldFirstNumber.text == "15" && inputFieldSecondNumber.text == "3"){
            point++;

        }
        if (inputFieldFirstNumber.text == "3" && inputFieldSecondNumber.text == "15"){
            point++;
        }
    }
//2.Resultado: 28 Operación: + Opciones: 11, 16, 13, 15 Correctas: 13 y 15
    public void ShowResult3(){
        if (inputFieldFirstNumber.text == "13" && inputFieldSecondNumber.text == "15"){
            point++;

        }
        if (inputFieldFirstNumber.text == "15" && inputFieldSecondNumber.text == "13"){
            point++;
        }
    }
//Resultado: 46 Operación: + Opciones: 21, 32, 15, 25Correctas: 21 y 25
    public void ShowResult4(){
        if (inputFieldFirstNumber.text == "21" && inputFieldSecondNumber.text == "25"){
            point++;

        }
        if (inputFieldFirstNumber.text == "25" && inputFieldSecondNumber.text == "21"){
            point++;
        }
    }
//Resultado: 19 Operación: +Opciones: 7, 2, 13, 17 Correctas: 2 y 17
    public void ShowResult5(){
        if (inputFieldFirstNumber.text == "2" && inputFieldSecondNumber.text == "17"){
            point++;

        }
        if (inputFieldFirstNumber.text == "17" && inputFieldSecondNumber.text == "2"){
            point++;
        }
    }
// Resultado: 52 Operación: + Opciones: 19, 25, 33, 27 Correctas: 19 y 33 o 25 y 27
    public void ShowResult6(){
        if (inputFieldFirstNumber.text == "19" && inputFieldSecondNumber.text == "33"){
            point++;

        }
        if (inputFieldFirstNumber.text == "33" && inputFieldSecondNumber.text == "19"){
            point++;
        }
        if (inputFieldFirstNumber.text == "25" && inputFieldSecondNumber.text == "27"){
            point++;
        }
        if (inputFieldFirstNumber.text == "27" && inputFieldSecondNumber.text == "25"){
            point++;
        }
    }
    // Resultado: 2O peración: - Opciones: 15, 4, 13, 11Correctas: 13 - 11
    public void ShowResult7(){
        if (inputFieldFirstNumber.text == "13" && inputFieldSecondNumber.text == "11"){
            point++;

        }
        if (inputFieldFirstNumber.text == "11" && inputFieldSecondNumber.text == "13"){
            point++;
        }
    }
    //Resultado: 30 Operación: - Opciones: 35, 43, 22, 13Correctas: 43 - 13
    public void ShowResult8(){
        if (inputFieldFirstNumber.text == "43" && inputFieldSecondNumber.text == "13"){
            point++;

        }
        if (inputFieldFirstNumber.text == "13" && inputFieldSecondNumber.text == "43"){
            point++;
        }
    } 
    // Resultado: 15 Operación: - Opciones: 32, 25, 3, 18 Correctas: 18 - 3
    public void ShowResult9(){
        if (inputFieldFirstNumber.text == "18" && inputFieldSecondNumber.text == "3"){
            point++;

        }
        if (inputFieldFirstNumber.text == "3" && inputFieldSecondNumber.text == "18"){
            point++;
        }
    }
    // Resultado: 22 Operación: - Opciones: 22, 21, 25, 44 Correctas: 44 - 22
    public void ShowResult10(){
        if (inputFieldFirstNumber.text == "44" && inputFieldSecondNumber.text == "22"){
            point++;

        }
        if (inputFieldFirstNumber.text == "22" && inputFieldSecondNumber.text == "44"){
            point++;
        }
    }
}
