using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace String_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        string names = "Luke,Leia,Han,Chewbacca";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void challengeButton1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string nameReversed = "";
            for (int i = name.Length - 1; i >= 0; i--)
                nameReversed += name[i];
            resultLabel1.Text = nameReversed;
            nameBox.Text = "";
        }

        protected void challengeButton2_Click(object sender, EventArgs e)
        {
            string[] namesArray = names.Split(',');
            string namesReversed = "";
            for (int i = namesArray.Length - 1; i >= 0; i--)
                namesReversed += namesArray[i] + "<br />";
            resultLabel2.Text = namesReversed;
        }

        protected void challengeButton3_Click(object sender, EventArgs e)
        {
            string[] namesArray = names.Split(',');

            int desiredStringSize;
            if (stringSizeBox.Text == "") desiredStringSize = 14;
            else desiredStringSize = int.Parse(stringSizeBox.Text);

            for (int i = 0; i < namesArray.Length; i++)
            {
                int currentStringSize = namesArray[i].Length;
                int paddingLeft = (desiredStringSize - currentStringSize) / 2;
                namesArray[i] = namesArray[i].PadRight(desiredStringSize - paddingLeft, '*');
                namesArray[i] = namesArray[i].PadLeft(desiredStringSize, '*');
            }

            string result = "";
            for (int i = 0; i < namesArray.Length; i++) result += namesArray[i] + "<br />";
            resultLabel3.Text = result;
            stringSizeBox.Text = "";
        }

        protected void challengeButton4_Click(object sender, EventArgs e)
        {
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            puzzle = puzzle.Replace("remove-me", "");
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace("z", "t");
            puzzle = puzzle.Replace("now ", "Now ");

            resultLabel4.Text = puzzle;
        }
    }
}