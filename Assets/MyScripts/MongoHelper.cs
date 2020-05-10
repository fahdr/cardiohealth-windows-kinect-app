using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
//using MongoDB.Driver.Builders;
using UnityEngine;
using System.Collections.ObjectModel;

public class MongoHelper<T> where T : class
    {
       public IMongoCollection<T> Collection { get; private set; }

        private MongoClient client;
      //  private MongoServer server;
        private IMongoDatabase provider;
        private MongoUrl mongoUrl;
   // private MongoCredential.CreateCredential credential;
    //private MongoClientSettings settings;

    //string _connectionString;


    public MongoHelper()

    {
        /*
        credential = new MongoCredential.CreateCredential
                        ("PatientDatabaseDemo",
                         "demouser",
                         "123");
        settings = new MongoClientSettings
       {
            Credentials = new[] { credential },
            Server = new MongoServerAddress("localhost", Convert.ToInt32("27017"))
        };
        */
        // MongoClient client = new MongoClient(new MongoUrl("mongodb://localhost:27017"));

        var client = new MongoClient("mongodb+srv://ch:cardio123@cardiohealth-h6cio.azure.mongodb.net/test?retryWrites=true");


        // client = new MongoClient(mongoUrl);           
        //server = client.GetServer();
         //   server.Connect();


         provider = client.GetDatabase("cardiohealth");
        //MongoDatabase db = server.GetDatabase("MongoLab-f");

        // provider = server.GetDatabase(mongoUrl.DatabaseName, WriteConcern.Acknowledged);

            Collection = provider.GetCollection<T>(typeof(T).Name.ToLower());
        Debug.Log(Collection);
        }


        //public MongoHelper(string connectionString)
        //{

        //    mongoUrl = new MongoUrl(connectionString);
        //    client = new MongoClient(mongoUrl);
        //    server = client.GetServer();
        //    server.Connect();
        //    MongoDatabase db = server.GetDatabase("PatientDatabaseDemo");

        ////provider = server.GetDatabase(mongoUrl.DatabaseName, WriteConcern.Acknowledged);
        //    Collection = db.GetCollection<T>(typeof(T).Name.ToLower());
        //}

    }

