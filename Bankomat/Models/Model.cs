using System;

namespace Bankomat.Models
{
    internal class Model
    {
        public Guid Id { get; set; }
        public string CardName  { get; set; }
        public int CardPassword { get; set; } = 0212;
        public decimal CardBalance { get; set; } = 100;

    }
}
