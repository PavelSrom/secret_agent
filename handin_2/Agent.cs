using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace handin_2
{
    public class Agent
    {
        public static int agentId = 0;

        public int id;
        public string name;
        public string codeName;
        protected ArrayList languages = new ArrayList();

        public Agent(string agentName, string[] languages)
        {
            agentId++;

            this.id = agentId;
            this.name = agentName;
            this.codeName = Encryption.Hash(name, 13); // encrypt
            this.languages.Add(languages[0]);
            this.languages.Add(languages[1]);
        }

        public void updateLanguages(string lan1, string lan2)
        {
            this.languages[0] = lan1;
            this.languages[1] = lan2;
        }

        public override string ToString()
        {
            return "Agent " + this.id + ", codename: " + this.codeName + ", languages: " + this.languages;
        }
    }
}