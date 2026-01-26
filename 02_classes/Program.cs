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
            auto = auto1,
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
            urenGekocht = 40,
            urenVerbruikt = 10,
            examenPogingen = 1,
            automaat = false
        };
        TheorieTest theorieTest = new TheorieTest()
        {
            gehaald = true,
            afnameDatum = new DateTime(2024, 12, 15)
        };
        RijTest rijTest = new RijTest()
        {
            gehaald = false,
            afnameDatum = new DateTime(2025, 3, 20)
        };

        Student student1 = new Student()
        {
            lesPakket = lesPakket,
            theorieTest = theorieTest,
            rijTest = rijTest,
            rijLeraar = rijleraar,
            naam = "Mazen",
            leeftijd = 17
        };
        Student student2 = new Student()
        {
            lesPakket = lesPakket,
            theorieTest = theorieTest,
            rijTest = rijTest,
            rijLeraar = rijleraar,
            naam = "Dingus",
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