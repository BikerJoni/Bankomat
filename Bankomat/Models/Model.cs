using System;

namespace Bankomat.Models
{
    public class Model
    {
        public Guid Id { get; set; }
        public string CardName  { get; set; }
        public int CardPassword { get; set; } = 0212;
        public int CardBalance { get; set; } = 100;

    }
}
