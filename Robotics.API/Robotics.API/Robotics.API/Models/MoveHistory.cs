using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Robotics.API.Models {
    public class RoboMoveHistory {
        [BsonId]
        public ObjectId InternalId { get; set; } // standard BSonId generated by MongoDb

        [BsonElement ("name")]
        public string Name { get; set; }

        [BsonElement ("color")]
        public string Color { get; set; }

        [BsonElement ("direction")]
        public string Direction { get; set; }

        [BsonElement ("distance")]
        public Distance[] Distance { get; set; }

        [BsonElement("updatedOn")]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        [BsonElement("updatedBy")]
        public string UpdatedBy {get;set;}

        public int Total { get; set; }
    }
}