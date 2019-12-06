using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UDPListener
{
    public class Conversation
    {

        // Variables
        #region
        public string question;
        public string answer;
        public int id;
        public DateTime timeOfConversation;
        #endregion

        // Properties
        #region
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime TimeOfConversation
        {
            get { return timeOfConversation; }
            set { timeOfConversation = value; }
        }
        #endregion

        // Constructors
        #region
        public Conversation(int _id, string _question, string _answer,  DateTime _timeOfConversation)
        {
            ID = _id;
            Question = _question;
            Answer = _answer;            
            TimeOfConversation = _timeOfConversation;
        }

        // Empty constructor for JSON
        public Conversation()
        {

        }
        #endregion
    }
}
