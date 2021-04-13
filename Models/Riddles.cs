namespace Sphinx.Models
{
  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }
    public Riddle(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }

    public bool CheckAnswer(string userAnswer)
    {
      return (Answer == userAnswer);
    }
  }
  // public class RiddleList
  // {
  //   public List Riddles { get; set; }
  //   public RiddleList (List list)
  //   {
  //     Riddles = list;
  //   }
  //   public List randomizeList()
  //   {
  //     Random riddleSelect = new Random();
  //     int num = riddleSelect.Next(1,3);
  //     var selectedRiddle = List<RiddlesList>[num]
  //   }
  // }
}