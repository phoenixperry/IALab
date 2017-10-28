using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Collections.Generic;

public class SerialReader : MonoBehaviour           
{
    SerialPort stream = new SerialPort("\\\\.\\COM11", 9600);

    public int val = 0; 
    // Use this for initialization
    void Start()
    {
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        stream.ReadTimeout = 40; // this is a safety catch in case the port hangs
        try
        {
            string value = stream.ReadLine();
            string[] sensors = value.Split(',');
            foreach (string s in sensors)
            {
                if(s !="")  
                    Debug.Log(s);
                int.TryParse(s, out val);  
            }
            stream.BaseStream.Flush();
        }
        catch (System.Exception e) {
            Debug.Log("Your serial port is not getting data. If you can't read data at all, try unplugging your arduino and reloading your code on it"); 
        }
  
   }
}
