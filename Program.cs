﻿//Main

string [] variable1 = new string [16];


string userImput = "";

while(userImput != "-1")
{
   userImput = Menu();

    if(userImput=="1")
    {
        PlayConnections(variable1);
    }

}




// Methods


static string Menu()
{
    System.Console.WriteLine("Welcome to Connections");
    System.Console.WriteLine("Press 1 to play");
    System.Console.WriteLine("Press -1 to exit");

    string imput = Console.ReadLine();

    return imput;
}

static void PlayConnections(string [] variable1)
{

    Console.Clear();
    




    StreamReader sr= new StreamReader("datahold.txt");
    string temp = sr.ReadLine();
    int i=1;
    int a=0;
   

    while(temp!=null)
    {

        if (i==2)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==3)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==4)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==5)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }





        if (i==10)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==11)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==12)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==13)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }





        if (i==18)
        {
           string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==19)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==20)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==21)
        {
           string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }





        if (i==26)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==27)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==28)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }
        if (i==29)
        {
            string [] splits= temp.Split(' ');
            variable1[a]=splits[1];
            a++;
        }



        i++;
        temp=sr.ReadLine();

    }

    sr.Close();
    
    RndFunction(variable1);
    
    EnterGuesses(variable1);



}

static void EnterGuesses(string [] variable1)
{


    string guess1="1";
    string guess2="2";
    string guess3="3";
    string guess4="4";
    bool group1 =false;
    bool group2 =false;
    bool group3 =false;
    bool group4 =false;
    string failedGuess="1";
    int i=0;
    
    

    
    
    while(group1 ==false || group2 ==false || group3 ==false || group4 ==false && i<5)
    {
        guess1="1";
        guess2="2";
        guess3="3";
        guess4="4";
        failedGuess="1";

        System.Console.WriteLine("please enter the four words that you think are related");

        guess1= Console.ReadLine();

        if(guess1 == variable1[0] || guess1 == variable1[1] || guess1 == variable1[2] || guess1 == variable1[3] && failedGuess!="-20")
        {
            
            guess2=Console.ReadLine();
            while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4 )
            {
                guess2 = ErrorStatement();
            }
            if(guess1 == variable1[0] || guess1 == variable1[1] || guess1 == variable1[2] || guess1 == variable1[3] && failedGuess!="-20")
            {

                guess3=Console.ReadLine();
                while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                {
                    guess3 = ErrorStatement();
                }
                if(guess1 == variable1[0] || guess1 == variable1[1] || guess1 == variable1[2] || guess1 == variable1[3] && failedGuess!="-20")
                {


                    guess4=Console.ReadLine();
                    while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                    {
                        guess4 = ErrorStatement();
                    }
                    if(guess1 == variable1[0] || guess1 == variable1[1] || guess1 == variable1[2] || guess1 == variable1[3] && failedGuess!="-20")
                    {
                        System.Console.WriteLine("Conngratulations that is one group of connections");   
                        group1 =true;                 
                    }
                    else{failedGuess= Failed(ref i);}



                }
                else{failedGuess= Failed(ref i);}

            }
            else{failedGuess= Failed(ref i);}

        }

        if(guess1 == variable1[4] || guess1 == variable1[5] || guess1 == variable1[6] || guess1 == variable1[7] && failedGuess!="-20")
        {
            
            guess2=Console.ReadLine();
            while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
            {
                guess2 = ErrorStatement();
            }
            if(guess1 == variable1[4] || guess1 == variable1[5] || guess1 == variable1[6] || guess1 == variable1[7] && failedGuess!="-20")
            {

                guess3=Console.ReadLine();
                while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                {
                    guess3 = ErrorStatement();
                }
                if(guess1 == variable1[4] || guess1 == variable1[5] || guess1 == variable1[6] || guess1 == variable1[7] && failedGuess!="-20")
                {


                    guess4=Console.ReadLine();
                    while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                    {
                        guess4 = ErrorStatement();
                    }
                    if(guess1 == variable1[4] || guess1 == variable1[5] || guess1 == variable1[6] || guess1 == variable1[7] && failedGuess!="-20")
                    {
                        System.Console.WriteLine("Conngratulations that is one group of connections");   
                        group2 =true;                 
                    }
                    else{failedGuess= Failed(ref i);}



                }
                else{failedGuess= Failed(ref i);}

            }
            else{failedGuess= Failed(ref i);}

        }

        if(guess1 == variable1[8] || guess1 == variable1[9] || guess1 == variable1[10] || guess1 == variable1[11] && failedGuess!="-20")
        {
            
            guess2=Console.ReadLine();
            while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
            {
                guess2 = ErrorStatement();
            }
            if(guess1 == variable1[8] || guess1 == variable1[9] || guess1 == variable1[10] || guess1 == variable1[11] && failedGuess!="-20")
            {

                guess3=Console.ReadLine();
                while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                {
                    guess3 = ErrorStatement();
                }
                if(guess1 == variable1[8] || guess1 == variable1[9] || guess1 == variable1[10] || guess1 == variable1[11] && failedGuess!="-20")
                {


                    guess4=Console.ReadLine();
                    while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                    {
                        guess4 = ErrorStatement();
                    }
                    if(guess1 == variable1[8] || guess1 == variable1[9] || guess1 == variable1[10] || guess1 == variable1[11] && failedGuess!="-20")
                    {
                        System.Console.WriteLine("Conngratulations that is one group of connections");   
                        group3 =true;                 
                    }
                    else{failedGuess= Failed(ref i);}



                }
                else{failedGuess= Failed(ref i);}

            }
            else{failedGuess= Failed(ref i);}

        }

        if(guess1 == variable1[12] || guess1 == variable1[13] || guess1 == variable1[14] || guess1 == variable1[15] && failedGuess!="-20")
        {
            
            guess2=Console.ReadLine();
            while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
            {
                guess2 = ErrorStatement();
            }
            if(guess1 == variable1[12] || guess1 == variable1[13] || guess1 == variable1[14] || guess1 == variable1[15] && failedGuess!="-20")
            {

                guess3=Console.ReadLine();
                while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                {
                    guess3 = ErrorStatement();
                }
                if(guess1 == variable1[12] || guess1 == variable1[13] || guess1 == variable1[14] || guess1 == variable1[15] && failedGuess!="-20")
                {


                    guess4=Console.ReadLine();
                    while(guess1== guess2 || guess1 == guess3 || guess1 ==guess4 || guess2 == guess3 || guess2 ==guess4 || guess3 == guess4)
                    {
                        guess4 = ErrorStatement();
                    }
                    if(guess1 == variable1[12] || guess1 == variable1[13] || guess1 == variable1[14] || guess1 == variable1[15] && failedGuess!="-20")
                    {
                        System.Console.WriteLine("Conngratulations that is one group of connections");   
                        group4 =true;                 
                    }
                    else{failedGuess= Failed(ref i);}



                }
                else{failedGuess= Failed(ref i);}

            }
            else{failedGuess= Failed(ref i);}

        }





    }

    if(group1 ==true || group2 ==true || group3 ==true || group4 ==true)
    {
        System.Console.WriteLine("CONGRATULATIONS YOU ARE A WINNER WINNER CHINCKEN DINNER");
        System.Console.WriteLine("Press enter to return to the main menu");
        Console.ReadLine();
    }




}



static void RndFunction(string [] variable1)
{
    Random rnd = new Random();

    int temp =0;

    List<int> cardSequence = Enumerable.Range(0, 16).ToList();
    temp = cardSequence[rnd.Next(0, cardSequence.Count)];

    for(int i =0; i< 16; i++)
    {
        System.Console.WriteLine(variable1[temp]);
        cardSequence.Remove(temp);
        try
        {
            temp = cardSequence[rnd.Next(0, cardSequence.Count)];
        }
        catch{}

    }
    System.Console.WriteLine("");
    System.Console.WriteLine("");
    System.Console.WriteLine("");

}

static string ErrorStatement()
{
    string guess="";

    System.Console.WriteLine("you have entered the same guess twice");
    System.Console.WriteLine("Please guess again");
    guess = Console.ReadLine();


    return guess;
}

static string Failed(ref int i)
{
    string temp = "-20";
    System.Console.WriteLine("Womp Womp that is not a correct connection group");
    System.Console.WriteLine("press enter to guess again");
    i++;
    return temp;

}
