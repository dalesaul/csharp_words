using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
// ***Practice: Dictionary of Words
        // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

        //    wordsAndDefinitions.Add("R key", "complete loss of governance and control. Chaos");
        //    wordsAndDefinitions.Add("Eonebutme", "who is likely to be hired");
        //    wordsAndDefinitions.Add("E R U O K", "are you okay Annie");

        //    foreach(KeyValuePair<string, string> word in wordsAndDefinitions){
        //         Console.WriteLine($"The definition of an {word.Key} is {word.Value}");
        //     };

// ***Practice: List of Dictionaries about Words
        // List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

        // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

        // excitedWord.Add("word", "Excited");
        // excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
        // excitedWord.Add("part of speech", "adjective");
        // excitedWord.Add("example sentence", "i am no longer excited about c#");

        // dictionaryOfWords.Add(excitedWord);

        // Dictionary<string, string> nervousWord = new Dictionary<string, string>(){
        //     {"word" , "nervous"},
        //     {"definition", "easily agitated or alarmed; tending to be anxious; highly strung."},
        //     {"part of speech", "adjective"},
        //     {"example sentence", "I am unreasonably nervous about this class still."}
        // };

        // dictionaryOfWords.Add(nervousWord);

        // foreach(Dictionary<string, string> wordEntry in dictionaryOfWords){

        // foreach(KeyValuePair<string, string> word in wordEntry){
        //     Console.WriteLine($"{word.Key}: {word.Value} ");
        //     }}

// **** Practice: English Idioms

Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });


foreach(KeyValuePair<string, List<string>> idiom in idioms){

    string name = idiom.Key;


Console.WriteLine($"{name} : {String.Join(" ", idiom.Value)}");
        }
    }
}
}
