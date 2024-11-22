using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter1
{
    internal class Noter_til_programmering
    {
        static void Main(string[] args)
        {
            // Variabler:
            // Variabler er kasser man sætter en bestemt værdi i til brug. variabler declereres og værdien angives (assign på engelsk)
            // int (intiger) er helt tal - eks. int ti = 10;
            // double er decimaltal - eks. double tæl = 5,5; 
            // string er tekst - eks. string cykel = "banan"; (string har altid "" omkring tekstværdien)
            // char er enkelt bogstav - eks. char bil = 'h'; (char har altid '' omkring bogstavværdien)

            // kommentarer - enketltlinje ad gangen
            /* kommenterere på flere linjer og kommentaren afsluttes med */


            // Strings og nogle af de fungtiner der kan laves i dem
            Console.WriteLine("Strings og nogle af de funktioner der kan laves i dem");
            Console.WriteLine(" Giraffe Academy"); // alm. WriteLine der bare udskriver tekst
            Console.WriteLine(" Giraffe \n Academy");// for at evt kunne skrive den på to separate linjer kan \n bruges således at det bliver 
            Console.WriteLine(" Giraffe\" Academy");// selve " kan også udskrives med i sætningen

            string phrase = "Giraffe Academy"; // altid "" omkring den ønskede værdi i stringdefinition.
            Console.WriteLine(phrase);
            // kan også laves som string hvor string værdien bliver = med det man ønsker at skrive.
            // Her bliver phrase defineret til Giraffe Academy
            //phrase er den øsnkede værdi og skrives derfor uden "" i WriteLine.


            // concatenation er en funktion der kan sætte strings sammen her bliver string koblet sammen med mere til writelinen med "" + "".
            string sætning = "Giraffe Academy" + "is cool";
            Console.WriteLine(sætning); // her udskriver udskrives værdien sætning som er en sammensætning af sætningen "Giraffe Academy" + "is cool";
            // hvis det ønskes at finde ud af hvor mange bogstaver/længden på orden kan værdien kobles sammen med .Lenght i WriteLine
            Console.WriteLine(sætning.Length); // udkriver 22 i værdien sætning


            // i string er der også metoder som er en form for prædifinerede koder der kan bruges til at gøre noget eks. ToUpper.
            string nyTing = "Frederiksberg Have";
            Console.WriteLine(nyTing.ToUpper()); // hele Frederiksberg Have string værdien bliver skrevet med sort. ToLower ville det hele blive med småt
            Console.WriteLine(nyTing.Contains("Have")); // .Contains funktionen undersøger om der indeholdes noget bestemt heri Have som bliver True
            Console.WriteLine(nyTing.Contains("højt")); // Den vil vise False fordi højt ikke er angivet nogen steder 
            Console.WriteLine(nyTing[0]);
            // WriteLine([]); tallet i [] det indeholder udskriver pågældene bogstav i rækken i index positionen dette tilfælde nyTing som er Frederiksberg Have starter fra 0 som her bliver F
            Console.WriteLine(nyTing.IndexOf("Have")); // IndexOf("")) vi ser hvor indexpositionen for heri Have starter.
            Console.WriteLine(nyTing.IndexOf('v')); // viser hvor v befinder sig. Ved forkert bogstav udskrives værdien -1.
            Console.WriteLine(nyTing.Substring(14));
            // funktionen .Substring()) tillader at man kan udskrive separate dele i dette tilfælde Have da den befinder sig i index position

            Console.WriteLine("" +
                "" +
                "" +
                ""); // mellemrum mellem de forskellige afsnit

            // Tal
            Console.WriteLine("Tal nedenfor");
            Console.WriteLine(100); // udskriver bare 100 tallet behøver ikke "" omrking sig i WriteLine
            Console.WriteLine(100.5); // Udskriver 100,5 . bruges som ,
            Console.WriteLine(5 + 8); Console.WriteLine(40 / 8); Console.WriteLine(5 * 8); Console.WriteLine(5 - 8);
            Console.WriteLine(5 + 8 + 10 * 7);
            // regnestykker kan også udføres i WriteLine uden "" omkring. Den finder selv ud af den korrekte rækkefølge at udregne i
            Console.WriteLine(5 + (8 + 10) * 7);
            // man kan ændre rækkefølgen selv ved at tiføje paranteser.
            Console.WriteLine(10 / 7); // helt tal og helt tal vil kun kunne returnere helttal
            Console.WriteLine(5.5 / 7); // mens hvis den ene værdi er decimal vil den give decimal tilbage
            Console.WriteLine(5 % 2);
            // når man skriver % inden i writeline på den måde vil den udføre regnestykket og udskrive resten.
            // Dvs. den vil udskrive 1 som rest i dette tilfælde.Dette kaldes modulus.


            Console.WriteLine("" +
                "" +
                "" +
                "");

            // simpel brug af int
            Console.WriteLine("simpel brug af int");
            int num = 6; // værdien num er = 6 som her defineres 
            num++;
            // dette betyder at værdien øges (increment) num++ post incremenet værdien øges efter brug ++num ville være preincrement - øges før brug 
            Console.WriteLine(num); // værdien her vil derfor printes ud som 7
            int num2 = 6;
            num2--; // decrement - reduktion.  num-- post decremenet værdien reduceres efter brug --num ville være predecrement - reduceres før brug
            Console.WriteLine(num2); // num2 bliver 5 da -- reduceres med 1

            // int konverteret til string
            int b = 50;
            string str2 = Convert.ToString(b);
            Console.WriteLine(str2);

            Console.WriteLine("" +
                "" +
                "" +
                "");

            //matematik - Math. funktioner eksempler. Der er mange funktioner man kan se dem når man skriver Math.
            Console.WriteLine("Matematik og nogle funktioner i Math.");
            Console.WriteLine(Math.Abs(30)); // selve Math i C# har en række funktioner Math.Abs() er giver det absolutte tal
            Console.WriteLine(Math.Pow(3, 7)); // Pow står for Power her vil det være 3 opløftet i 7, altså potens  = 2187
            Console.WriteLine(Math.Sqrt(36)); // Math.Sqrt beregner kvadratroden af et tal. Kvadratroden af 36 giver
            Console.WriteLine(Math.Max(4, 90)); // viser det største/maximale tal som her er 90
            Console.WriteLine(Math.Min(4, 90)); // viser det mindste/minimale tal som her er 4
            Console.WriteLine(Math.Round(4.567)); // Math.Round runder tal op jf. standard oprundingsregler her oprunder den til 5
            Console.WriteLine(Math.PI); // viser pi

            Console.WriteLine("" +
                "" +
                "" +
                "");

            // Brugerinput i string
            // Console.WriteLine - skriver en linje og går ned/videre når den er skrevett
            // mens Console.Write ikke forholder sig til en linje går videre/ned og kan udskrive så man kan skrive på samme linje ved fx. brugerinput
            // både Write og WriteLine kan benyttes til brugerinput, afhængig af hvordan det skal se ud i udskrften
            Console.WriteLine("Brugerinput i string");
            Console.Write("indtast dit navn:"); //Beder om brugerinput i form af navn
            string navn = Console.ReadLine();
            // string definderes her som navn der skal indlæses.
            // Console.ReadLine(); kan siges at pausere programmet, så brugerinput kan indtastes. 
            // dvs. Console.ReadLine() læser/indlæser linjen Console.Write("indtast dit navn:");
            // så bruger kan taste det ind.
            // Console.WriteLine("indtast dit navn:"); kan også bruges.
            Console.WriteLine("Hej" + navn);
            // når brugeren har indtastet sit navn vil der blive udskrevet Hej og så navnet.
            // navnet blev defineret som string, som er den værdi der benyttes i WriteLine til programmet her.
            Console.Write("indtast din alder:"); //Beder om brugerinput i form af alder
            string alder = Console.ReadLine(); // samme som med string navn = Console.ReadLine(); til at give mulighed for input i form af alder
            Console.WriteLine("Hej" + navn + "din alder er" + alder);

            Console.WriteLine("" +
                "" +
                "");

            //Mere tal og Basis regnemaskine
            Console.WriteLine("Mere tal og basis regnemaskine");

            int number = Convert.ToInt32("45"); // funktion hvor du kan konvertere en string til et tal
            Console.WriteLine(number + 6); // her vil det blive num som er 45 + 6 som er = 51

            // simpel regnemaskine med brugerinput. regnemaskine med int (Heltal)
            Console.WriteLine("indtast et tal:"); // får burgeren til at indtaste et tal
            int nummer1 = Convert.ToInt32(Console.ReadLine());
            // konvertere int nummer1 til et tal til ReadLine via Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32 findes i flere bla som Convert.ToInt16 og 64 der er flere valgmuligheder.
            //tallet i Convert.toInt fortæller hvor meget indhold den kan klare
            Console.WriteLine("indtast et tal mere:");
            int nummer2 = Convert.ToInt32(Console.ReadLine()); // samme process som før
            Console.WriteLine(nummer1 + nummer2); // kan også være gange *, dividere / eller minus - eller evt. anden funktion 

            // Basislommeregner med samme process som før bare med double (decimaltal) i stedet for int (heltalt)
            Console.WriteLine("indtast et evt. decimaltal:");
            double nummer3 = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble funktionen konvertere til double (decimaltal)
            Console.WriteLine("indtast andet evt. decimaltal:");
            double nummer4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(nummer3 + nummer4); // kan også være gange *, dividere / eller minus - eller evt. anden funktion 

            // Arrays serier af input under samme variabel.
            // Array kan indeholde flere værdier under samme variabel.
            int[] talserie = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Array med int
            // indexpositioner 0  1  2  3  4  4  6  7  8. Det samme vile være gældende for en string.  
            // int [] viser at det er en Array der ønskes lavet her. i {} separeres tallene med ,
            Console.WriteLine(talserie[0]); // udskriver tallet 1 fra talserie da 1 befinder sig i index 0
            Console.WriteLine(talserie[8]); // udskriver tallet 9 fra talserie da 1 befinder sig i index 8 
            talserie[0] = 500; // dette vil ændre 1 til en værdi af 500
            // man kan overskrive et tal i en array 
            talserie[4] = 10; // resultatet vil være at 5 i talserie vil blive overskrevet med 10, som erstatter
            // du kan ikke udskrive en indexplacering der er hverken over eller under placeringen vil give fejlkode.
            // Console.WriteLine(talserie[15]); vil derfor ikke kunne blive udskrevet da det er over antallet af indexpositioner.

            string[] køkkenredskaber = new string[4]; // Array med string [4] angiver at der kan være 5 elementer eftersom index starter ved 0
            køkkenredskaber[0] = "stegepande";
            køkkenredskaber[1] = "gaffel";
            køkkenredskaber[2] = "gryde";
            køkkenredskaber[3] = "saks";
            køkkenredskaber[4] = "ovn";
            // kan også laves som new int ovenpå med talserie.

            string[] badeværelsesting = { "håndklde", "håndvask", "shampoo", "balsam" };




            // Metoder og lav metode, samt return statement
            // Denne del fremgår kun som kommentarer da det vil være for besværligt, at få det til at virke i så lang en note
            // der findes metoder i C# som er koder der bruges til forskellige formål
            // man kan skabe sin egen metode static void Main(string[] args) er en metode i sig selv.
            // man kan skabe egne metoder og kalde dem forskellige ting. Main er en særlig metode og foregår indenfor {}
            // static er central for at skabe egen metode som hovedregel forbliver Main da den er særlig (void er det man kalder en returntype)
            // når du skaber en metode eks. static void SayHi(){ } er det udenfor Mains{ }.
            // {} er udgangspunkt for metoder foregår indenfor rammen
            // Man kan Call a Method dvs. man kan i Main definere den metode man bruger for at få det til at virke.
            // dette kan man gøre ved, at angive metoden i main SayHi(); 
            // andet eksempel vil være via selve et return statement ville være at skabe anden metode bliver vist nedenfor som kommentar. 
            // nedenfor vil den definere metode static int cube(int num) få returneret sit resultat fra WriteLine i Main.
            // i udskriftet vil det give 125 eftersom int result inde i metoden cube defineres som num * num * num. 
            // i WriteLine definderes det ønskede resultat som cube(5), som henviser til metoden med num*num*num, som her bliver 5*5*5
            // Call Method foregår her inde i selve WriteLine. cube er bare noget man har valgt at kalde metoden.

            // static void Main(string[] args)
            //{
            //    Console.WriteLine(cube(5));

            //    Console.ReadLine();
            //}

            //static int cube(int num)
            //{
            //    int result = num * num * num;
            //    return result;
            //}

            // Kan også laves som int defineret som eks. skrives i Main
            // int cubednumber = cube(5);
            // Console.WriteLine(cubednumber); som vil returnere samme resultat 125, da den her defineres som int men samme resultat ønskes


            /* boolske værdier
             * bool kan kun være sand eller falsk kan bruges i forbindelse med if, else if, else og while eller do while lykker, samt for lykker
             *  boolseke operatorer er i den forbindelse ==,  > <, >= mindre eller er lig med, <= større eller lig med, != ikke lig med, !(ikke).
             *  
             *  

            // if statements (kontrolstrukturer)

            // if sætter en betingelse - betingelsen kan kun være true or false. Simpelt eksempel nedenfor:
            // if er altid skrevet som if() {} 
            //bool erKvinde = true;
            //if (erKvinde) { Console.WriteLine("du er kvinde"); }
            // konsolen udskriver her er kvinde da det er sand, kan den selv regne ud. Hvis false vil den her ikke printe ud.
            // Man kan bruge else statement også så if (indhold) {} else andnen funktion
            // man kan lave if, else if eller if else statements inde i if/else if/ else statements.

            //// 2 betingelser eks. med else if og else.
            bool erMand = false;
            bool erhøj = true;
            if (erMand && erhøj) { Console.WriteLine("du er mand og er høj" + erMand); }
            ////&& betyder yderligere eks. kunne hvis matematik være >< = == !=
            else if (erMand && !erhøj) { Console.WriteLine("du er mand og er ikke høj"); } // ! betyder ikke 
            else if (!erMand && erhøj) { Console.WriteLine(" du er ikke mand og er høj"); }
            else { Console.WriteLine("du er hverken mand eller høj"); }
            //// afhængig af om man sætter bool værdierne til true eller false vil programmet kunne regne værdien ud og hvad den skal printe.
            //// dette kan også gøres med bruger input og tælling men int,´double, string, mv.
            //// programmet foretager således beslutninger på baggrund af de info den bliver givet

            // eksempel if, else if, else med tal
            int xy = 0;
            int yx = 0;

            Console.WriteLine("indtast et tal:"); // den er her lavet med brugerinput int xy og yx
            xy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast et andet tal");
            yx = Convert.ToInt32(Console.ReadLine());

            if (xy > yx) // hvis xy mindre en yx er sand/true udskrives første tal er størst
            {
                Console.WriteLine(" første tal er størst"); 
            }
            else if (xy < yx) 
             // ellers hvis den ovenstående ikke er true.
             // xy er mindre end yx er der en anden if else mulighed andet tal er størst
            {
                Console.WriteLine(" andet tal er større");
            }
            else
            { Console.WriteLine(" tallene er lige store"); } // ellers udskrives hvis tallene er lige store


            // Swich sætninger.
            // kan eks vis bruges til hvis du skal lave en menu og vil se sådan her ud. 

            /*switch () sætninger har cases og afsluttes med break; efter hver case, default: fungere som else. switch sætninger indkapslses med{}
            switch (variabel der ønskes testet) { 
             * case 1:
             * break;
             * case 2:
             * default:
             * break;
             }*/
            /* man kan lave cases indenunder hinanden uden break hvis der er cases der skal indeholde den samme kode,
            der må dog ikke stå noget i casen for at dette skal kunne udføres eks.
            case 2:
            case3:
            Console.WriteLine("udskrevet kode")*/

            /* while loop
            skrives som while (boolsk udtryk der skal testes på) omgivet af { } hvor det man skriver koderne // while loopet kører så længe den er true
            findes også som do while
            do udføre koden uanset hvad mens
            do {} while (boolsk udtryk) {} - while skal altid være efter den afsluttende } i do*/


            // for loop

            for (int i = 1; i <= 10; i++) // boolsk udtryk der starter med at sige i (initialisering) i indexet starter fra 1 og tæller til 10 ++ betyder øges med 1

            {

                Console.Write(i);
            }
            /* for (int i = 1; i <= 100; i++)
        // der er her tale om en løkke eller loop der går fra 1 - 100 i dette tilfælde. Ovenfor ses kun at gå til 10
        // Der beskrives at i (indextallet) = starter fra 1 og går op til 100.
        // Der er tale om en øgning <= 100 - hvor det er plus 1; i++ da der er tale om øgning.
            i kan siges at være en tæller variabel - en counter
        {
            Console.WriteLine(i); // i (index) udskrives.*/

            for (int i = 100; i >= 1; i--)
            // for er en løkke eller loop der går fra 100 - 1 i dette tilfælde.
            // Der beskrives at i (indextallet) = 100 og starter fra 100 og går ned til 1.
            // dvs. det går ned af og er mindre end 100 - hvor 1; i -- da der er tale om reduktion i tal med 1. 
            {
                Console.WriteLine(i); // i udskrives heri 
            }

            for (int i = 100; i >= 1; i--)
                // for er en løkke eller loop der går fra 100 - 1 i dette tilfælde.
                // Der beskrives at i (indextallet) = 100 og starter fra 100 og går ned til 1.
                // dvs. det går ned af og er mindre end 100 - hvor 1; i -- da der er tale om reduktion i tal med 1. 

                for (int i = 0; i <= 100; i = i + 5) // går fra 0 - 5 = Derfor i=i+5, så hvert 5 tal springes over og der øges med 5
                {
                    Console.WriteLine(i); // udskriver i
                    Console.WriteLine("indtast et tal: ");
                    // Programmet udskriver "indtast et tal: " hvor brugeren bedes om at indtaste et tal.

                    int num = Convert.ToInt32(Console.ReadLine());
                }
            // Selve Console.ReadLine() læser input som streng/string.
            // Convert.ToInt32() konverterer streng/string til int/heltal hvori variablen num befinder sig.


            for (int i = 1; i <= 10; i++)
            // for er en løkke. I dette tilfælde der kører løkken fra i = 1 til i <= 10.
            // Dette skal bruges til gangetabelen hvor den kan ganges fra 1 til 10.
            // Her er der tale om øgning derfor <= 10; i++.
            // Hvis der skulle være tale om en reduktion ville det havde været --.
            // Der øges i med 1.
            {
                int resultat = i * num;
                // I int resultat beregnes produktet af i og num (Indtastet tal), som udgør variablen resultat.


                Console.WriteLine($"{i} * {num} = {resultat}");
                // Gangestykket udskrives.
                // {} bruges til at definere/omslutte hvad man vil have ud af stykket og hvordan det udregnes jf. de brugte variabler. 
                // Heri variablerne {i} * {num] og det skal være = {resultat}.
                // Dette er sat op så udskriften viser gangestykket jf. i (index) og viser = det resultat gangestykket bliver.

                Console.WriteLine(i); // i udskrives heri 

                // && netyder og || betyder og eller
                int x = 0;
                int y = 5;
                if (x > y && x != 10)
                {
                    Console.WriteLine("kode");
                    if (x > y)
                        break;
                } // break; kan også bruges i loops - her vil den bare gå ud hvis x>y
                if (x < y)
                    continue; // continue stopper egentlig lykken og går op fra hvor du beder den at continue og går op og tester intervallet igen
            }

            // eksempel
            for (int i = 100; i >= 1; i--)
                if (i == 5)
                    break;
                else if (i == 10)
                    continue;
            {
                Console.WriteLine(i); // i udskrives heri 
            }

            // for kan også bruges til at udskrive længden både på array og en tekst
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            Console.WriteLine(numbers.Length); // den vil udskrive 10 fordi der er 10 index i talserien numbers.
            for (int i = 0; i < numbers.Length / 2; i++) // vil udskrive halvdelen kan lave
                Console.WriteLine(numbers[i]);


            string[] lamper = { "bordlampe", "væglampe", "loftlampe", "lommelygte" };
            for (int i = 0; i < lamper.Length; i++) // samme for loop med array bare som string
                Console.WriteLine("lamper[i]");


            //øvrige funktioner
            Console.SetCursorPosition(4, 10); /*-sætter positionen af input af tegn i udskrift ligesom en x og y akse Console.SetCursorPosition(x, y)*/
            Console.BackgroundColor = ConsoleColor.Red; /*-Denne funktion angiver baggrundsfarven der er flere farver*/
            Console.ForegroundColor = ConsoleColor.Green; // angriver tekstfarven der udskrives

            // PadLeft/PadRight
            string tekst = "Hej";
            string højrejusteret = tekst.PadLeft(10); // "       Hej"
           // funktionen PadRight(tal) Højreustere teksten med et bestemt mellemrum
            string venstrejusteret = tekst.PadRight(10); // "Hej       "//
            // funktionen PadLeft(tal) venstrustere teksten med et bestemt mellemrum             
            Console.WriteLine($"{tekst.PadLeft(10)} med dig");

            ////Length - Har været en gang ovenfor egentlig en gentagelse
            //string nytekst = "min tekst skrives her";
            //int længdeaftekst = nytekst.Length;
            //Console.WriteLine(længdeaftekst); index af længde starter på 0

            /* Konverteringseksempler*/
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string





            Console.ReadKey();




















        }
    }
}
