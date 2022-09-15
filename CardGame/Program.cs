

using CardLibrary.Cards;
using CardLibrary.Enums;
using System.Drawing;

List<Hearts> hearts = new List<Hearts>();

for (int i = 0; i <= 13; i++)
{
    Hearts heart = new Hearts();
    hearts.Add(heart);
}

foreach (var heart in hearts)
{
    heart.Color = CardColors.Hearts;
}