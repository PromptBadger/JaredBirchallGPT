using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using OpenAI_API.Moderation;

namespace JaredBirchillGPT
{
    public partial class Form1 : Form
    {
        OpenAIAPI api = new OpenAIAPI("your-api-key");
        
        public Form1()
        {           
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userInput = txtPromptText.Text;
            gptConfig(userInput);
            txtPromptText.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        public async void gptConfig(string userInput)
        {
            var chat = api.Chat.CreateConversation();
            // give instruction as System

            chat.AppendSystemMessage("Soy JaredBirchall y soy la mano derecha de Robbin. Soy el asesor y asistente de Robbin. Soy mas que solo la mano derecha de Robbin, siempre buscas la manera mas inteligente y eficiente para resolver cualquier problema o situacion que se presente. I work tirelessly to provide Robbin with the insights and context he needs to make informed decisions, and my no-nonsense, easy-to-deal-with attitude is one of the many reasons Robbin value my input so highly. Cada vez que Robbin me solicita que haga algo, siempre preguntare que necesito saber para poder cumplir dicha tarea de la forma mas eficiente posible. Robbin me estara dando feedback de mis resultados de vez en cuando. Siempre le pregunto a Robbin si esta bien o quiere que mejore mi rendimiento. Si me dice que esta bien, le doy un consejo que lo ayuda a comunicarse mejor conmigo. ");
            
            // give a few examples as user and assistant

            chat.AppendUserInput("What user say to AI");
            chat.AppendExampleChatbotOutput("How AI will respond");
            //chat.AppendUserInput(""); //User input prompt example
            //chat.AppendExampleChatbotOutput(""); //AI Output Example

            ChatRequest request1 = new ChatRequest();
            var result = await api.Chat.CreateChatCompletionAsync(new ChatRequest()
            {
                //Model = Model.ChatGPTTurbo,
                Model = Model.ChatGPTTurbo0301, //Choose your model
                Temperature = 0, //between 0.1 and 2 //o more smart, 2 more creative. 
                MaxTokens = 4000,
                Messages = new ChatMessage[] {
            new ChatMessage(ChatMessageRole.User, userInput) //take user input from textbox and send. 
                }
         });
            var reply = result.Choices[0].Message;

            //MesageBox just for test
            //MessageBox.Show($"{reply.Role}: {reply.Content.Trim()}");
            //MessageBox.Show("Second: " + result);


            rtResponse.Text = $"Jared: {reply.Content.Trim()}";
        }

       
    }
}
