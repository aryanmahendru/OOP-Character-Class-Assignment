Characters spyderman=new Characters("Spyderman","Anyone can wear the mask","I believe there’s a hero in all of us.");
Characters kungfupanda=new Characters("Kung Fu Panda","There is no secret ingredient","Oogway There are no accidents");
Characters.Speak(spyderman,1);
Characters.SetLevel(spyderman,2);
Characters.Speak(kungfupanda,2);

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
    public static void Speak(Characters input,int phrasenum){
        if(phrasenum == 1){
            Console.WriteLine(input.Phrase1);
        }
        else if(phrasenum == 2){
            Console.WriteLine(input.Phrase2);
        }
        else{
            Console.WriteLine("The input should be 1 or 2");
        }
    }

    public static void SetLevel(Characters input1,int level){
        input1.Level=level;
        Console.WriteLine(input1.Name + " has now level" + level);
    }
}