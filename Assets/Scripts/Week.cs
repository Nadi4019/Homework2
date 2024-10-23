using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        for(int day = 1; day <= 7; day++)
        {
            WeekDaysSwitch(day);
        }

        for(int day = 1; day <= 7; day++)
        {
            WeekDaysIfElse(day);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WeekDaysSwitch(int dayOfTheWeek)
    {
        switch(dayOfTheWeek)
        { 
            case 1: 
            Debug.Log("Monday");
            Debug.Log("Going out with friends!");
            break;
            case 2:
            Debug.Log("Thuesday");
            Debug.Log("Homework due");
            break;
            case 3:
            Debug.Log("Wednesday");
            Debug.Log("Going surfing");
            break;
            case 4:
            Debug.Log("Thursday");
            Debug.Log("Making a whole feast for the deciple");
            break;
            case 5:
            Debug.Log("Friday");
            Debug.Log("Cinema time: A REALLY GOOD MOVIE!!");
            break;
            case 6:
            Debug.Log("Saturday");
            Debug.Log("Time to feed the horse");
            break;
            case 7:
            Debug.Log("Sunday");
            Debug.Log("Sleeping in Zzz");
            break; 
        }
    }

    void WeekDaysIfElse(int dayOfTheWeek)
    {
        if(dayOfTheWeek == 1)
        {
            Debug.Log("Monday: Feeding the turtle");
        } else if(dayOfTheWeek == 2)
        {
            Debug.Log("Thuesday: Tivoli WEEEE");
        } else if(dayOfTheWeek == 3)
        {
            Debug.Log("Wednesday: Cleaning the ocean");
        } else if(dayOfTheWeek == 4)
        {
            Debug.Log("Thursday: Selling diamond from the deep mine");
        } else if(dayOfTheWeek == 5)
        {
            Debug.Log("Friday: Carving pumpkins");
        } else if(dayOfTheWeek == 6)
        {
            Debug.Log("Saturday: Making mommy cry");
        } else if(dayOfTheWeek == 7)
        {
            Debug.Log("Sunday: Die");
        } else
        {
            Debug.Log("WTF, how's this possible?");
        }
    }
}
