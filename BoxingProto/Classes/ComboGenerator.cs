using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingProto.Classes
{
    internal class ComboGenerator
    {
        List<int> activecomboList = new List<int>(); //stores our combos
        List<int> externalComboList = new List<int>();

        Random myRandom = new Random();
        Round round;
        string comboText;

        List<int> FullStrikeList = new List<int>();
        List<int> FullComboLengthList = new List<int>();

        public ComboGenerator(Round Round, List<int> fullstrikelist, List<int> fullcombolengthlist)
        {
            round = Round;
            FullStrikeList = fullstrikelist;
            FullComboLengthList = fullcombolengthlist;
        }

        public string Run()
        {

            generateActiveComboList();
            return getComboString();

        }

        public List<int> getComboList()
        {
            return externalComboList;

        }

        public string getComboString()
        {
            comboText = "";
            externalComboList.Clear();

            for (int i = 0; i < activecomboList.Count; i++) 
            {
                 comboText = comboText + " " + activecomboList[i];
                 externalComboList.Add(activecomboList[i]);
            }

            activecomboList.Clear();
            return comboText;
        }
        public void generateActiveComboList()
        {
            for (int v = 0; v < generateComboLengthNumber(); v++) 
            {
                //random number generator here.
                int randomIndex = myRandom.Next(0, 100);      
                activecomboList.Add(FullStrikeList[randomIndex]); 
            }
        }


 
        public int generateComboLengthNumber()
        {
            int randomIndex = myRandom.Next(0, 100);
            return FullComboLengthList[randomIndex];


        }



        

    }
}
