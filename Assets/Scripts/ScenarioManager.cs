using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScenarioManager : MonoBehaviour
{
    [SerializeField] private List<ScenarioEvent> scenarioEvents;
    private ScenarioDatas scenarioDatas;

    // Start is called before the first frame update
    void Start()
    {
        // Charger le contenu du fichier texte (JSON)
        string filePath = "Assets/scenario.json";
        string jsonText = File.ReadAllText(filePath);
        // Convertir le JSON en une liste d'�v�nements du sc�nario
        scenarioDatas = JsonUtility.FromJson<ScenarioDatas>(jsonText);
        scenarioEvents = scenarioDatas.elements;
    }


    /* DEFINITIONS */
    // Classe repr�sentant le sc�nario
    [System.Serializable]
    private class ScenarioDatas
    {
        public string title;
        public string version;
        public List<ScenarioEvent> elements;
    }

    // Classe repr�sentant un �v�nement du sc�nario
    [System.Serializable] private class ScenarioEvent
    {
        public int id;
        public string objectName;
        public string type;
        public List<int> requiredIds;
    }
}
