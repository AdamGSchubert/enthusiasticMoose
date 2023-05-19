using System;

// namespace EnthusiasticMoose
void main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
}




 void MooseSays(string message){
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                        `^^` `^^^`
    ");
 }
 //MooseSays("hi im really enthusiastic");
//   MooseSays("now get to work in the sweatshop");

string[] answers ={
    "As I see it, yes.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don’t count on it.",
    "It is certain.",
    "It is decidedly so.",
    "Most likely.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Outlook good.",
    "Reply hazy, try again.",
    "Signs point to yes.",
    "Very doubtful.",
    "Without a doubt.",
    "Yes",
    "Yes–definitely.",
    "You may rely on it."
};

bool MooseAsks(string question){
    Console.WriteLine($"{question} (Y/N):");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer !="n"){
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }
     if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
};

void skyBlue(){
    bool isTrue = MooseAsks("is the sky blue?");
// Console.WriteLine(isTrue);
if(isTrue){
    MooseSays("Really! it seems very unlikely.");
}
else{
    MooseSays("I KNEW IT!");
}};
void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

int mooseAnswer(){
    Random answerIndex =new Random();
     int randomAnswer =answerIndex.Next(0,19);
    return randomAnswer;

};



void askMoose(){
    Console.WriteLine("Ask your question of the magic Moose");
    string question = Console.ReadLine().ToLower();
    if (question !=""){
        Console.WriteLine($"{answers[mooseAnswer()]} ");
    }
    else{
        Environment.Exit(1);
    }

}


main();
 MooseSays("hello, im the magical moose.");
 askMoose();
// skyBlue();
// EnthusiasticQuestion();
// LoveCSharpQuestion();
// SecretQuestion();