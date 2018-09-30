using System;
using System.Collections.Generic;
using System.Text;

namespace CG_7_3
{
    public class Card
    {
        public string FaceValue { get; set; }
        public string Suit { get; set; }
        public string GetFullName()
    {
            return $"{FaceValue} of {Suit}";
        }
    }
}
