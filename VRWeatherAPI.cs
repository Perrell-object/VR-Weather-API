// WeatherAPIScript.cs script
using UnityEngine;
using System.Collections;
public class WeatherAPI : MonoBehaviour {
public string url = "http://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&APPID=<YOUR API KEY>";
// Use this for initialization
IEnumerator Start () {
WWW request = new WWW(url);
yield return request;
if (request.error == null || request.error == "") 
{
Debug.Log("Response: " + request.text);
} 
else 
{
Debug.Log("Error: " + request.error);
}
}
// Update is called once per frame
void Update () {
}
}