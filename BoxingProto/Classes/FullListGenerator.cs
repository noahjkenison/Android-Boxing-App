using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxingProto.Classes
{



    internal class FullListGenerator
    {

        public List<int> fullstrikelist = new List<int>();
        public List<int> fullcombolengthlist = new List<int>();



        public FullListGenerator()
        {
        }



        public List<int> GenerateFullStrikeList(List<Strike> strikeslist)
        {


            for (int x = 0; x < strikeslist.Count(); x++)
            {

                for (int y = 0; y < strikeslist[x].frequency * 100; y++)
                    fullstrikelist.Add(strikeslist[x].strikeNumber); //error 

            }


            return fullstrikelist;
        }

        public List<int> GenerateFullComboLengthList(List<ComboLength> combolengthlist) 
            // Generates a weighted list of 100 combolengths (based off percentages of 
        {
            for (int x = 0; x < combolengthlist.Count(); x++)
            {


                for (int y = 0; y < combolengthlist[x].frequency * 100; y++)    //intermittent error here
                    fullcombolengthlist.Add(combolengthlist[x].strikesInCombo);

                
            }


            //for (int x = 0; x < combolengthlist.Count; x++)
            //    for (int y = 0; y < combolengthlist[x].frequency * 100; y++)
            //        fullcombolengthlist.Add(combolengthlist[x].strikesInCombo); //error here



            return fullcombolengthlist;
        }


    }


}
