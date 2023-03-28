using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel;
using MongoDB.Bson.Serialization;
using DataVisualization.Models;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace DataVisualization.Models;

public class Data
{
    [BsonId]
    public ObjectId id { get; set; }
    public int end_year { get; set; }
    public string sector { get; set; }
    public string topic { get; set; }
    public string insight { get; set; }
    public string url { get; set; }
    public string region { get; set; }
    public int start_year { get; set; }
    public int impact { get; set; }
    public string added { get; set; }
    public string published { get; set; }
    public string country { get; set; }
    public int relevance { get; set; }
    public string pestle { get; set; }
    public string source { get; set; }
    public string title { get; set; }
    public int likelihood { get; set; }

    public int intensity { get; set; }

}