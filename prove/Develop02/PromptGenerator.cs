using System.Dynamic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{

    Random random;

    List<string> journalPrompts = new List<string>
        {     
            "How did I feel when I woke up this morning?",
            "What are three things I'm grateful for today?",
            "What made me smile today?",
            "What challenges did I face today?",
            "What did I learn today?",
            "What are my core values and beliefs?",
            "What are my strengths and weaknesses?",
            "What are my biggest fears and how do they affect me?",
            "What are my goals for the future?",
            "How am I feeling right now, and why?",
            "What events or interactions affected my mood today?",
            "Have I been taking care of my emotional well-being?",
            "Describe a moment of mindfulness or presence today.",
            "What small joys did I experience today?",
            "Reflect on the beauty of nature or simple pleasures around you.",
            "What creative activities did I engage in today?",
            "Did I encounter any inspiring quotes, stories, or ideas?",
            "How can I nurture my creativity and inspiration further?",
            "Who did I interact with today, and how did those interactions make me feel?",
            "Is there someone I need to express gratitude or appreciation towards?",
            "How can I improve my relationships with others?",
            "Did I engage in any physical activity or exercise today?",
            "What did I eat today, and how did it make me feel?",
            "Have I been taking care of my mental and emotional health?",
            "What accomplishments or progress did I make towards my goals today?",
            "Did I step out of my comfort zone or overcome any obstacles?",
            "What are some small victories I can celebrate?",
            "What are my priorities for tomorrow or the week ahead?",
            "What steps can I take to work towards my long-term goals?",
            "How can I make the most out of tomorrow?",
            "What lessons have I learned from past experiences?",
            "What legacy do I want to leave behind?",
            "How do I want to grow and evolve as a person?"
        };
    
    public PromptGenerator(){
        random = new Random();
    }

    public string GetRandomPrompt(){
        int randInt = random.Next(0, journalPrompts.Count);
        return journalPrompts[randInt];
    } 
}