using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using pr0p0llDiagrams.Entities;
using pr0p0llDiagrams.Entities.Answers;


namespace pr0p0llDiagrams.Logic
{
    public static class JsonDeserializer
    {
        public static Poll DeserializePoll(string jsonString)
        {
            var json = JObject.Parse(jsonString);

            // the poll
            var pollJson = json["info"];
            var poll = pollJson.ToObject<Poll>();
            poll.Questions = new List<Question>();

            // questions
            for(var i = 1;; i++)
            {
                var qName = "q" + i;
                if(!json.ContainsKey(qName))
                    break;
                var questionJson = json[qName];
                var question = questionJson.ToObject<Question>();
                question.Answers = new List<Answer>();

                // answers
                for(var ii = 1;; ii++)
                {
                    var aName = "a" + ii;
                    var answerJson = questionJson[aName];
                    if(answerJson == null)
                        break;
                    var answer = answerJson.ToObject<Answer>();
                    question.Answers.Add(answer);
                }

                poll.Questions.Add(question);
            }

            return poll;
        }
    }
}
