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
        // Convertir le JSON en une liste d'événements du scénario
        scenarioDatas = JsonUtility.FromJson<ScenarioDatas>(jsonText);
        scenarioEvents = scenarioDatas.elements;
    }


    /* DEFINITIONS */
    // Classe représentant le scénario
    [System.Serializable]
    private class ScenarioDatas
    {
        public string title;
        public string version;
        public List<ScenarioEvent> elements;
    }

    // Classe représentant un événement du scénario
    [System.Serializable] private class ScenarioEvent
    {
        public int id;
        public string objectName;
        public string type;
        public List<int> requiredIds;
    }
}
