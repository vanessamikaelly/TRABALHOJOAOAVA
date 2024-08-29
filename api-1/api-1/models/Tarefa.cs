﻿namespace api_1.models
{
    public class Tarefa
    {

        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Feito { get; set; } = false;

        public DateTime Data { get; set; } = DateTime.Now;
    }
}
