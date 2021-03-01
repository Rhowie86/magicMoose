using System;
using System.Collections.Generic;



Dictionary<string, int> answers = new Dictionary<string, int>()
{
  { "As I see it, yes.", 0 },
  { "Ask again later.", 1 },
  { "Better not tell you now.", 2 },
  { "Cannot predict now.", 3 },
  { "Concentrate and ask again.", 4 },
  { "Don’t count on it.", 5 },
  { "It is certain.", 6 },
  { "It is decidedly so.", 7 },
  { "Most likely.", 8 },
  { "My reply is no.", 9 },
  { "My sources say no.", 10 },
  { "Outlook not so good.", 11 },
  { "Outlook good.", 12 },
  { "Reply hazy, try again.", 13 },
  { "Signs point to yes.", 14 },
  { "Very doubtful.", 15 },
  { "Without a doubt.", 16 },
  { "Yes.", 17 },
  { "Yes – definitely.", 18 },
  { "You may rely on it.", 19 }
};

Console.WriteLine(answers);




void MooseSays(string message)
{
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