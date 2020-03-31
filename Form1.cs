using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SøgningOgSortering
{
    public partial class Form1 : Form
    {
        //Her opretter 3 lister til vores talrækker, og en integer til at tælle cycles.
        List<int> lstRandom = new List<int>(); 
        List<int> lstSort = new List<int>();
        public int cycles = 0;
        private List<int> sorted;

        //her initializer vi vores form
        public Form1()
        {
            InitializeComponent();
        }

        //denne funktion bliver kaldt når der bliver trykket på knappen "Generate"
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstRandom.Clear(); //Her gør vi listen klar til at modtage tal, ved at rense den for eventuelle allerede indestående tal.
            Random randomNumber = new Random(); //Her opretter vi en ny instans af klassen Random, som kan bruges til at generere tilfældige tal.
            //her kalder vi funktionerne til at rense forskellige komponeter på vores form.
            ClearOut(); 
            ClearInp();

            //Her tjekker vi om vores talspecifikations textboxe indeholder et tal, og en "-".
            if (!string.IsNullOrWhiteSpace(txtRange.Text) && txtRange.Text.Contains("-") && !string.IsNullOrWhiteSpace(txtInput.Text))
            {
                //Her opretter vi en variabel hvor vi lagrer vores to tal, der bliver sepereret med en "-". Dette gør vi med en try/catch, hvor kan sikre os at det input brugeren
                //skriver ind til koden, kan aflæses af computeren, og omskrives til en integer. Hvis ikke dette kan lade sig gøre, viser programmet en besked, som giver en fejlmeddellelse.
                var subStrings = txtRange.Text.Split('-').Select(val =>
                {
                    try
                    {
                        return int.Parse(val);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not parse string to int in 'Range'");
                        return 0;
                    }
                }).ToArray();

                
                int temp; //Her opretter vi en variabel temp.
                if (Int32.TryParse(txtInput.Text, out temp)) //Her tryparser vi for at få en boolsk betingelse som vi kan udføre en if betingelse på. Dette gøres for at indhente tallet fra textboxen sikkert. 
                {
                    //Her kører vi et forloop, som tilføjer en række tilfældige tal, indenfor de specifikationer, som brugeren har indtastet, til listen lstRandom. 
                    for (int i = 0; i < temp; i++)
                    {
                        lstRandom.Add(randomNumber.Next(subStrings[0], subStrings[1] + 1));
                    }
                    lsbInput.DataSource = lstRandom; //Sætter datasource på lsbInput til at være lstRandom, således det bliver udskrevet på formen. 
                }
                else MessageBox.Show("Could not parse string to int in 'Numbers'"); //Dette er vores besked til brugeren hvis ikke det tal der er givet, kan bruges.

            }
            else //Dette er endnu en fejlmeddellelse. 
            {
                MessageBox.Show("Enter numberspecifications. Range of numbers is seperated by a '-'");
            }
        }

        //Denne funktion bliver kaldt når brugeren trykker på knappen "Sort"
        private void btnSort_Click(object sender, EventArgs e)
        {
            //Her tjekker vi om der er valgt en søgealgoritme i vores dropdownmenu.
            if (cmbMethod.SelectedIndex != -1)
            {
                //Her opretter vi et stopwatch, og starter det med det samme. 
                var stopWatch = System.Diagnostics.Stopwatch.StartNew();
                //Dette er vores forskellige cases til forskelleige søgealgoritmer, som vi bruger en switch til. 
                switch (cmbMethod.SelectedIndex)
                {
                    case 0: //BubbleSort
                        sorted = BubbleSort(); // her kalder vi vores bubblesortalgoritme, vis returnering smider vi ind i listen "Sorted"
                        lsbOutput.DataSource = sorted; //dernæst sætter vi listboxen til vores output, til at være sorted. 
                        lblCycles.Text = "Cycles: " + cycles.ToString(); //Her skriver vi antallet af cycles ud på vores label. 
                        break;
                    case 1: //MergeSort
                        sorted = Divide(lstRandom); //Her kalder vi vores første af de to funktioner til mergesort, og giver den argumentet lstRandom. 
                        lsbOutput.DataSource = sorted; //dernæst sætter vi listboxen til vores output, til at være sorted. 
                        lblCycles.Text = "Cycles: " + cycles.ToString(); //Her skriver vi antallet af cycles ud på vores label. 
                        cycles = 0; //her resetter vi cycles til at være 0.
                        break;

                    case 2: //QuickSort
                        Quicksort(lstRandom, 0, lstRandom.Count - 1); //Her kalder vi vores quicksortalgoritme og giver den 3 argumenter, som er specifikationer på lstRandom. 
                        sorted = lstRandom; // her sætter vi lst random til at være vores sorted liste. Da vores quicksortalgoritme er bygget sådan op 
                        lsbOutput.DataSource = sorted; // dernæst sætter vi listboxen til vores output, til at være sorted.
                         lblCycles.Text = "Cycles: " + cycles.ToString(); //Her skriver vi antallet af cycles ud på vores label.
                        cycles = 0;  //her resetter vi cycles til at være 0.
                        break;
                }
                stopWatch.Stop(); //Her stopper vi vores tidtagning. 
                lblTime.Text = "Time: " + stopWatch.ElapsedMilliseconds.ToString() + " ms"; //Her tilgår vi vores stopwach's milisekunder, og skriver det ud på labelen på formen. 
            }
            else //Hvis ikke der er valgt en søgealgoritme, vises denne fejlmeddellelse. 
            {
                MessageBox.Show("Choose a sorting algorithm");
            }

        }

        //Denne funktion er første del af vores mergesort algoritme. Denne funktion deler vores liste op i en masse små lister med maks et element i hver liste. 
        private List<int> Divide(List<int> lstRandom)
        {
            if (lstRandom.Count <= 1) return lstRandom; //hvis der kun er et element i listen, så returner listen. 
            
            //Her opretter vi en liste til højre og venstre side af opdeleren, så altså én liste bliver delt op i 2 halve. 
            List<int> right = new List<int>(); 
            List<int> left = new List<int>();

            //Her beregner vi midten af listen, og smider den ind i en variabel. 
            int middle = lstRandom.Count / 2;

            //Dette forloop tilføjer den ene halvdel af lstRandom til den ene liste...
            for (int i = 0; i < middle; i++)
            {
                left.Add(lstRandom[i]);
            }
            //...og den anden halvdel til den anden liste.
            for (int i = middle; i < lstRandom.Count; i++)
            {
                right.Add(lstRandom[i]);
            }

            //Her kalder vi så den samme funktion igen, og ved hjælp af rekursion, bliver den ved indtil at listerne kun har et element. 
            left = Divide(left);
            right = Divide(right);
            
            //når begge lister kun har et element i sig, så kalder vi den næste funktion, Merge, som merger listerne igen. Dette resultat returneres ud af Divide funktionen. 
            return Merge(left, right);
        }
        //Denne funktion merger de små lister i vores mergesort. Den har to parametre, som er henholdsvis den ene og den anden liste. 
        public List<int> Merge(List<int> left, List<int> right)
        {
            //Her opretter vi en ny liste "result"
            List<int> result = new List<int>();

            //Her kører vi et whileloop så længe at en af listerne indeholder et element. 
            while (left.Any() || right.Any())
            {
                //Hvis begge lister har et element.
                if (left.Any() && right.Any())
                {
                    //hvis det første element i den venstre liste er mindre eller ligmed det første element i højre liste. 
                    //Dette vil altså sige at det laveste tal sættes ind i result først.
                    if (left.First() <= right.First())
                    {
                        //Her tilføjes dette element til result, og slettes fra left. 
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else //ellers gøres det modsatte, så det er den højre listes element der bliver sat ind i result. 
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }

                //Hvis kun den venstre har elementer tilbage i listen, tilføjes disse elementer bare til result, og fjernes fra left.
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                // Her sker det samme som ovenfor, bare med den højre liste i stedet for. 
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
                // Her inkrementerer vi cycles. 
                cycles++;
            }
            // Her returnerer vi listen result.
            return result;
        }

        //Denne funktion er vores bubblesort, og den returner en liste. 
        public List<int> BubbleSort()
        {
            //Her sætter vi vores cycles til at være 0.
            int cycles = 0;
            //Her sætter vi lstRandom til at være lstSort, så vi kan holde styr på hvilke lister der bliver sorteret i.
            lstSort = lstRandom;

            //Dette forloop itererer over hele længden af vores liste. 
            for (int i = 0; i < lstSort.Count - 1; i++)
            {
                //Dette forloop itererer også over hele længden af vores liste. 
                for (int j = 0; j < lstSort.Count - 1 - i; j++)
                {
                    //her incrementer vi vores cycles.
                    cycles++;

                    //Hvis det første element den tjekker, er større end det næste element.
                    if (lstSort[j] > lstSort[j + 1])
                    {
                        //Disse 3 linjer bytter om på de 2 tal i listen.
                        int temp = lstSort[j + 1];
                        lstSort[j + 1] = lstSort[j];
                        lstSort[j] = temp;
                    }
                }
            }
            return lstSort; // Her returnerer vi så den liste som er blevet sorteret. 
        }

        //Denne funktion bliver kaldt når der bliver trykket på "Clear" knappen. 
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Den kalder funktion clear Out.
            ClearOut();
        }

        //Denne funktion bruges til at clear en masse outputs. 
        public void ClearOut()
        {
            //Her sætter vi en masse elementer på formen til at være tomme, således at der ikke står data om noget der ikke er på formen. 
            lstSort = null;
            lsbOutput.DataSource = null;
            lblCycles.Text = "Cycles: ";
            lblTime.Text = "Time: ";

            //search clearing:
            lblCount.Text = "-";
            lblFirst.Text = "-";
            lblLast.Text = "-";
            lblSCycles.Text = "-";
            txtSearch.Text = "";


        }

        //Denne funktion bruges til at clear vores liste med tilfældige tal. 
        public void ClearInp()
        {
            //Sættes til null, så der ikke står nogle elementer i listboxen.
            lsbInput.DataSource = null;
        }

        //Quicksort metoden er implementeret på baggrund af: https://codereview.stackexchange.com/questions/142808/quick-sort-algorithm
        //Denne funktion har 3 parametre, som kan indgiver listen, det index længst til venstre i listen, og det index der ligger længst til højre i listen. 
        public void Quicksort(List<int> Temp, int left, int right)
        {
            // Her inkrementerer vi cycles.
            cycles++;
            //hvis det yderste element i venstre side er større end højre, eller det venstre eller højre er mindre end nul, så kan quicksortfunktionen ikke fungere. 
            //Derfor  returnerer vi hvis dette sker.
            if (left > right || left < 0 || right < 0) return; 

            //Her kalder vi funktionen der opdeler listen. Den retunerer en integer.
            int index = Partition(Temp, left, right);

            //Her tjekker vi om index ikke er lig med -1, det vil sige at algoritmen skal fortsætte, indtil at algoritmen retunerer -1. Mere om dette i næste funktion.
            if (index != -1)
            {
                //Her kalder vi quicksort funktionen igen, en gang til hvert input, og ved hjælp af rekursion, sorteres listen Temp. 
                Quicksort(Temp, left, index - 1);
                Quicksort(Temp, index + 1, right);
            }

        }

        //Denne funktion opdeler vores liste, og den har 3 parametre. listen, og den værdi der ligger til højre og den der ligger til venstre. Det er ikke nødvendigvis de yderste elementer i listen. 
        public int Partition(List<int> PartTemp, int left, int right)
        {   //Her tjekker vi om den værdi til venstre er større end den til højre. Hvis sandt, returner -1. 
            if (left > right) return -1;

            //Her sætter vi vores end til at være lig med left. 
            int end = left;
            //her tager vi vores pivot værdi, som tager kommer fra indexet right. 
            int pivot = PartTemp[right];

            //Dette forloop kører fra venstre, til højre, på den måde sørger vi for at alle værdier bliver sammenlignet. 
            for (int i = left; i < right; i++)
            {
                // Her tjekker vi om den værdi af det element i listen, som vi er nået til, er mindre end sammenligningsværdien pivot. 
                if (PartTemp[i] < pivot)
                {
                    //hvis sandt, kaldes Swap funktionen. Efterfølgende incrementer vi end. 
                    Swap(PartTemp, i, end);
                    end++;

                }
            }
            //til sidst kaldes Swap funktionen igen. Denne gang med end og right, som argumenter. 
            Swap(PartTemp, end, right);
            //... og retunerer end. 
            return end;
        }

        //Swap gør præcis som nanvet antyder, bytter to værdier en funktion. Den har 3 parametre, den liste der skal swappes i, og de 2 elementer der skal swappes. 
        private static void Swap(List<int> partTemp1, int left, int right)
        {
            //der swappes ved at sætte en værdi ind i en midlertidig variabel, og så sætte den anden værdi ind i den første, og til sidst sætte den midlertidige værdi ind i den anden. 
            int tmp = partTemp1[left];
            partTemp1[left] = partTemp1[right];
            partTemp1[right] = tmp;
        }

        private void btnInput_Click(object sender, EventArgs e) //I denne funktion tager vi en fil med tal der er komma sepererede og laver et array af det.
        {
            string path = Directory.GetCurrentDirectory(); //Her får vi directorien af hvor programmet bliver kørt
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("What is the name of the file?", "Title", "null", 0, 0);//Her laver vi en messageBox med et input
            string filepath = path + "/" + fileName;
            string numbersFromFile;
            try
            {
                numbersFromFile = File.ReadAllText(filepath);//Her prøver vi at læse filen
            }
            catch (Exception FileNoWork)//Hvis filen ikke eksistere
            {
                Console.WriteLine(FileNoWork);
                MessageBox.Show("Please Ensure Your Filename is correct");
                return;
            }
            //Her prøver vi at splitte filen per komma og smide det i et int array efter det er blevet konverteret
            int[] splitNumbersFromFile = numbersFromFile.Split(',').Select(val =>
            {
                try
                {
                    return int.Parse(val);
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not fully convert file to array");//Hvis der er dele der ikke kan konverteres bliver de til 0 istedet for
                    return 0;
                }
            }).ToArray();
            ClearInp();
            foreach (int i in splitNumbersFromFile) //Her ligger vi elementerne i listen lstRandom
            {
                lstRandom.Add(i);
            }
            lsbInput.DataSource = lstRandom;

        }

        //Denne funktion bliver kaldt når der sker en ændring i søgetextboxens text indstilling. 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Først sætter vi alle labelsne til at være deres default værdi, som er "-".
            lblCount.Text = "-";
            lblFirst.Text = "-";
            lblLast.Text = "-";
            lblSCycles.Text = "-";

            //Her tjekker vi om der rent faktisk står noget i søgefeltet, eller ej. Hvis ikke, så retunerer den.
            if (txtSearch.Text == "")
            {
                return;
            }

            //Her bruger vi en tryparse funktion, til at omskrive stringen fra txtSearch til en int, og hvis dette ikke kan lade sig gøre, så giver den en fejlmeddelelse. 
            int number;
            if (!Int32.TryParse(txtSearch.Text, out number))
            {
                MessageBox.Show("Could not search for: " + txtSearch.Text);
            }

            //Her opretter vi 4 variabler. scycles, står for "Searchcycles"
            int scycles;
            int first, last;
            int count = 0;

            //Her kalder vi funktionen binary search. Den har 2 parametre og en out. Det vil sige at den tager en liste, det tal, den skal søge efter, og outputter scycles. Hvis tallet ikke findes i listen, retuneres "-1".
            int indexFound = binarySearch(sorted, number, out scycles);
            bool indexLow = false, indexHigh = false; //disse variabler oprettes, og skal bruges til at finde ud af om algoritmen er i starten eller slutningen af listen. 
            int test = indexFound; //for at bibeholde det index vi algoritmen finder, så indsætter vi det i en anden variabel, som vi kan ændre på. 
            if (test != -1) //Her tjekker vi om test rent faktisk ligger indenfor rækkevidden. 
            {
                //Så længe at det nummer vi søger efter, er det samme som værdien af det element det kigger i, kører dette loop.
                while (number == sorted[test])
                {
                    if (test == 0) //Her breaker vi ud af while loopet hvis test, kommer ned på 0, og dermed ikke er indenfor rækkevidden længere. 
                        break;
                    else // ellers tæller vi ned af, hver eneste gang, og på den måde bliver vi ved indtil at værdien af elementet ikke er det samme som test.
                    {
                        test--;
                        indexLow = true; //her sætter vi en boolsk værdi, til at være sand.
                    }
                }
                if (test != 0 || indexLow) //hvis elementet ikke er nul, eller den boolske værdi er sand, så increment test med en. 
                    test++;

                //efterfølgende sætter vi så first til at være lig med test. 
                first = test;

                //for at starte forfra til nu at tælle op ad, sætter vi igen test til at være lig med det element der bliver fundet. Her sker det samme som ovenfor, bare modsat, da det er i den høje ende af listen. 
                test = indexFound;

                while (number == sorted[test])
                {
                    if (test == sorted.Count - 1)
                        break;
                    else
                    {
                        test++;
                        indexHigh = true;
                    }

                }
                if (test != sorted.Count - 1 || indexHigh)
                    test--;

                last = test;

                //Her sætter vi de to labels text indstillinger til at være værdierne indexværdierne vi har fundet og scycles ud i deres respektive labels. 
                lblFirst.Text = first.ToString();
                lblLast.Text = last.ToString();
                lblSCycles.Text = scycles.ToString();

                //her udrenger vi så hvor mange elementer der er af det tal vi søger efter. 
                count = last - first + 1;



            }
            //Her sætter vi det så ud på formen.
            lblCount.Text = count.ToString();

        }

        //Binary search implemtation: https://www.youtube.com/watch?v=fOMh45TT0BI
        //denne funktion har 2 parametre og en out. Den retunerer en integer, som er det element der er blevet fundet i listen. 
        public static int binarySearch(List<int> list, int x, out int scycles)
        {
            // her sætter vi vores cycles til at være 0. 
            scycles = 0;

            if (list == null) //Her tjekker vi først om listen vi søger i er tom. Det vil sige at vi ikke kan søge i den, og er derfor nødt til at retunere "-1" med det samme.
                return -1;
            //Her opretter vi så en venstre og højre variabel, som afhænger af længden af listen.
            int left = 0;
            int right = list.Count - 1;

            //dette loop kører så længe at værdien til venstre er mindre end den til højre. 
            while (left <= right)
            {
                //incrementer cycles.
                scycles++;

                //her opretter vi en variabel som angiver det midterste punkt af den del af listen vi søger i. 
                var middle = (left + right) / 2;

                //Hvis det element der bliver tjekket er lig med den midterste værdi, så retunerer vi det element. 
                if (list[middle] == x)
                    return middle;

                //hvis den værdi vi kigger efter (x) er mindre end det midterste punkt, så tæller vi en ned i den højre side. 
                //Ellers lægger vi 1 til middle og sætter den til at være left. på den måde undgår vi at tjekke den samme værdi mere end 1 gang. 
                if (x < list[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            //hvis intet ovenfor kunne lade sig gøre, og alle listens elementer er gennemsøgt uden held, retuneres "-1".
            return -1;
        }

        private void BtnOutput_Click_1(object sender, EventArgs e) //Her laver vi en output fil
        {

            string path = Directory.GetCurrentDirectory(); //Her får vi directorien af hvor programmet bliver kørt
            string fileName = Microsoft.VisualBasic.Interaction.InputBox("What is the name of the file?", "Title", "null", 0, 0); //Her laver vi en messageBox med et input
            string filePath = path + "/" + fileName;
            try
            {
                string outString = string.Join<int>(",", sorted); //Her prøver vi at sætte listen sammen til en string så dette kan outputtes som en fil.
                File.WriteAllText(filePath, outString); //Her laver vi filen og skriver dertil, denne funktion er destruktiv så hvis der er en fil med dette navn bliver den overwrited
            }
            catch (Exception)
            {
                MessageBox.Show("Could not turn output into file");
                return;
            }

        }
    }
}