﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MVCMongoDB.Models
{
    public class Trazabilidad
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("idcliente")]
        public int IdCliente { get; set; }
        [BsonElement("idusuario")]
        public int IdUsuario { get; set; }
        [BsonElement("tarjeta")]
        public int Tarjeta { get; set; }
        [BsonElement("evento")]
        public bool Evento { get; set; }
        [BsonElement("idproceso")]
        public int IdProceso { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }
        [BsonElement("uid")]
        public string UID { get; set; }
        [BsonElement("fecha")]
        public DateTime Date { get { return DateTime.Now; } }
    }
}