using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversationRESTService
{
    public class Conversation
    {

        // Variables
        #region
        private string question;
        private string answer;
        private int id;
        private string timeOfConversation;
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
        public string TimeOfConversation
        {
            get { return timeOfConversation; }
            set { timeOfConversation = value; }
        }
        #endregion

        // Constructors
        #region
        public Conversation(int _id, string _question, string _answer,  string _timeOfConversation)
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
