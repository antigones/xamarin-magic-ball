using System;

namespace MagicBall
{
    class Prediction
    {
        readonly string[] predictions = new string[] {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don’t count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Without a doubt.",
            "Yes.",
            "Yes – definitely.",
            "You may rely on it."
        };
        readonly Random rand = new Random();

        public string MakePrediction()
        {
            int predIndex = rand.Next(0, predictions.Length - 1);
            return predictions[predIndex];
        }
    }
}
