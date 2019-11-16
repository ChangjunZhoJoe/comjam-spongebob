using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonParser : MonoBehaviour {
	string path;
    string jsonString;
    // Start is called before the first frame update
    void Start()
    {
        path = "/Users/josephlerner/Documents/hackathon stick tester/Assets/sampledata.json";
        jsonString = File.ReadAllText(path);
		Debug.Log(jsonString);
		LineData dataObject = JsonUtility.FromJson<LineData>(jsonString);
		Debug.Log(dataObject.frames[0].height);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
