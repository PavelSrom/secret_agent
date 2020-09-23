using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace handin_2
{
    public partial class Inputs : System.Web.UI.Page
    {
        static ArrayList listOfAgents = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAgent(object sender, EventArgs e)
        {
            string[] enteredLanguages = { InputLangFirst.Text, InputLangSecond.Text };
            listOfAgents.Add(new Agent(InputName.Text, enteredLanguages));

            InputName.Text = "";
            InputLangFirst.Text = "";
            InputLangSecond.Text = "";

            Agent lastInsertedAgent = (Agent) Inputs.listOfAgents[listOfAgents.Count - 1];
            Agents.Items.Add("Agent #" + lastInsertedAgent.id + " with name " + lastInsertedAgent.name + " and codename " + lastInsertedAgent.codeName);
        }
    }
}