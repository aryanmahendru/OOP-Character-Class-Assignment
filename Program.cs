﻿Characters spyderman=new Characters("Spyderman","Anyone can wear the mask","I believe there’s a hero in all of us.");  //Character1
Characters kungfupanda=new Characters("Kung Fu Panda","There is no secret ingredient","Oogway There are no accidents"); //Character2
kungfupanda.Speak(1);  //making character1 speaking phrase1
spyderman.SetLevel(2);  //setting level of character1 to 2
kungfupanda.Speak(2);  //making character2 speaking phrase2

class Characters{
    public string Name{get;set;}
    public string Phrase1{get;set;}
    public string Phrase2{get;set;}
    public int Level{get;set;}

    public Characters(string name,string phrase1,string phrase2){
        this.Name=name;
        this.Phrase1=phrase1;
        this.Phrase2=phrase2;
        this.Level=0;
    }
    public void Speak(int phrasenum){  //my function for speaking character phrase 1 or 2
        if(phrasenum == 1){
            Console.WriteLine(Phrase1);
        }
        else if(phrasenum == 2){
            Console.WriteLine(Phrase2);
        }
        else{   //giving error if the input is not 1 or 2
            Console.WriteLine("The input should be 1 or 2");
        }
    }

    public void SetLevel(int level){  //my function for setting level of Characters
        Level=level;
        Console.WriteLine(Name + " has now level" + level);
    }
}