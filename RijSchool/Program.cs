namespace RijSchool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            kilometerStand = 20567,
            merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "Volvo"
        };

        RijLeraar rijleraar = new RijLeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false
        };

        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijLeraar = rijleraar,
            tijd = 1130
        };

        LesPakket lesPakket = new LesPakket()
        {
            urenGekocht,
            urenVerbruikt,
            examenPogingen,
            automaat, Automaat
        };
        TheorieTest theorieTest = new TheorieTest()
        {
            geslaagd = false,
            datum = new DateTime(2024, 11, 15)
        };
        RijTest rijTest = new RijTest()
        {
            geslaagd = false,
            datum = new DateTime(2025, 2, 20)
        };

        Student student1 = new Student()
        {
            lesPakket = lesPakket,
            TheorieTest = theorieTest,
            RijTest = rijTest,
            RijLeraar = leraar,
            naam = "Mazen",
            leeftijd = 18
        };
        Student student2 = new Student()
        {
            LesPakket = lesPakket,
            TheorieTest = theorieTest,
            RijTest = rijTest,
            RijLeraar = leraar,
            naam = "Quandale Dingle",
            leeftijd = 29
        };

        Dag dag = new Dag()
        {
            datum = new DateTime(2026, 5, 1),
            lesuren = new LesUur[] { lesUur
                }
        };

    }    
}           