//using System;
//using System.Threading.Tasks;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using UnityEngine;

//public class PlayerData
//{
//    public string Game { get; set; }
//    public string Score { get; set; }
//    public string Timestamp { get; set; }
//}

//public class SaveProgression : MonoBehaviour
//{
//    // Remplacez par vos informations de connexion MongoDB Atlas
//    private const string MongoConnectionString = "mongodb+srv://<username>:<password>@<cluster-url>/<dbname>?retryWrites=true&w=majority";
//    private const string DatabaseName = "<dbname>"; // Remplacez par le nom de votre base de données
//    private const string CollectionName = "progression";

//    private MongoClient client;
//    private IMongoDatabase database;
//    private IMongoCollection<PlayerData> collection;

//    private void Start()
//    {
//        ConnectToDatabase();
//    }

//    private void ConnectToDatabase()
//    {
//        try
//        {
//            client = new MongoClient(MongoConnectionString);
//            database = client.GetDatabase(DatabaseName);
//            collection = database.GetCollection<PlayerData>(CollectionName);
//            Debug.Log("Connected to MongoDB successfully!");
//        }
//        catch (Exception ex)
//        {
//            Debug.LogError($"Error connecting to MongoDB: {ex.Message}");
//        }
//    }

//    public async Task SaveScoreAsync(int score)
//    {
//        if (collection == null)
//        {
//            Debug.LogError("Collection not initialized. Check database connection.");
//            return;
//        }

//        // Créez un objet PlayerData avec les informations du score
//        PlayerData playerData = new PlayerData
//        {
//            Game = "<NomPrenomEtudiant>_fall_guy", // Remplacez par votre nom
//            Score = score.ToString(),
//            Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
//        };

//        try
//        {
//            Debug.Log("Saving player score...");
//            await Task.Delay(1000); // Simulez un délai pour l'opération asynchrone
//            await collection.InsertOneAsync(playerData); // Sauvegarde dans MongoDB
//            Debug.Log("Player score saved successfully!");
//        }
//        catch (Exception ex)
//        {
//            Debug.LogError($"Error saving score: {ex.Message}");
//        }
//    }
//}