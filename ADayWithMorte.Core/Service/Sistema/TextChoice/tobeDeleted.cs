using ADayWithMorte.Core.Entities;

namespace ADayWithMorte.Shared.Sistema.TextChoice
{
    //public class StoryReader
    //{


    //    //private LibreTranslate libreTranslate = new LibreTranslate("https://libretranslate.de/");
    //    private string toLanguage = "en";

    //    public List<Choice> Choices { get; private set; } = new List<Choice>();

    //    public void ReadFile(string filePath)
    //    {

    //        using (StreamReader sr = new StreamReader(filePath))
    //        {
    //            string line;
    //            while ((line = sr.ReadLine()) != null)
    //            {
    //                if (line.StartsWith("Opção"))
    //                {
    //                    var choice = ParseChoice(line);
    //                    Choices.Add(choice);
    //                }
    //            }
    //        }
    //    }

    //    private Choice ParseChoice(string line)
    //    {
    //        var splitLine = line.Split(':');
    //        var choiceText = splitLine[1].Split('(')[0].Trim();
    //        var choiceType = splitLine[1].Split('(')[1].Trim(')');

    //        // traduzir o texto da escolha para o idioma desejado
    //        //var translatedText = libreTranslate.Translate("pt", toLanguage, choiceText);
    //        return new Choice();
    //        //return new Choice { Text = translatedText, Type = choiceType };
    //    }
    //}

}
