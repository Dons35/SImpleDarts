using System;

namespace Darts
{
    public class Dart
    {
        private static Random _random = new Random();

        public int SectionHit = _random.Next(21);
        public int SectionModifier = _random.Next(20);

        public string ModifierHit = "";    
        public int ScoreForThisThrow = new int();  
        
        public void DartThrow()
        {
            if (SectionHit >= 0 && SectionHit <= 19)
            {
                if (SectionModifier == 0)
                {
                    SectionHit++;
                    SectionHit = SectionHit * 2;
                    ModifierHit = "You hit the double band!";
                }

                else if (SectionModifier == 1)
                {
                    SectionHit++;
                    SectionHit = SectionHit * 3;
                    ModifierHit = "You hit the triple band!";
                }             
            };

            if (SectionHit == 20)
            {
                if (SectionModifier == 0)
                {
                    SectionHit = 50;
                    ModifierHit = "You hit the inner bullseye!";
                }
                else if (SectionModifier > 0 && SectionModifier <= 19)
                {
                    SectionHit = 25;
                    ModifierHit = "You hit the outer bullseye!";
                }
            };

            ScoreForThisThrow = SectionHit;
        }
    }
}
