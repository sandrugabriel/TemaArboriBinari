using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TemaArboreBinar.Arborele;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TemaArboreBinar.Revolzari
{
    public class Solutii
    {

        private ArboreBinar arboreBinar = new ArboreBinar();

        public void addArbore()
        {

            arboreBinar.add(7, arboreBinar.getNode());
            arboreBinar.add(2, arboreBinar.getNode());
            arboreBinar.add(6, arboreBinar.getNode());
            arboreBinar.add(1, arboreBinar.getNode());
            arboreBinar.add(4, arboreBinar.getNode());
            arboreBinar.add(10, arboreBinar.getNode());


            /*
                      7
                  2     10  
                1   6
                   4
             */ 



        }

        /*
        #675BiFrunze
        Se dă un arbore binar care conține valori numere naturale.Să se afișeze frunzele acestui arbore.
        */
        public void solutia1()
        {
            addArbore();
            arboreBinar.afisareFruncze(arboreBinar.getNode());

        }

        /*
        #670Preordine
        Se dă un arbore binar care conține valori numere naturale.Să se afișeze valorile din arbore 
        în urma parcurgerii în preordine.
        */
        public void solutia2()
        {
            addArbore();
            arboreBinar.afisarePreordine(arboreBinar.getNode());

        }

        /*#671Inordine
        Se dă un arbore binar care conține valori numere naturale. Să se afișeze valorile din arbore 
        în urma parcurgerii în inordine.*/
        public void solutia3()
        {
            addArbore();
            arboreBinar.afisareiInordine(arboreBinar.getNode());

        }

        /*#672Postordine
        Se dă un arbore binar care conține valori numere naturale. Să se afișeze valorile din arbore 
        în urma parcurgerii în postordine.
         */
        public void solutia4()
        {
            addArbore();
            arboreBinar.afisarePostordine(arboreBinar.getNode());

        }

        /*#673DifSub
        Se dă un arbore binar care conține valori numere naturale. Să se determine diferența 
        în valoare absolută a sumei valorilor memorate în subarborele stâng al rădăcinii și suma 
        valorilor memorate în subarborele drept al rădăcinii.
         */
        public void solutia5()
        {
            addArbore();

            Console.WriteLine(arboreBinar.difSub(arboreBinar.getNode()));

        }

        /*#674CountSub
        Se dă un arbore binar care conține valori numere naturale. Se dau k noduri din arbore și 
        se cere determinarea, pentru fiecare nod, a numărului de noduri din subarborele cu rădăcina în acel nod.
         */
        public void solutia6()
        {
            addArbore();

            Nod nod1 = arboreBinar.getNode();
            Nod nod2 = arboreBinar.getNode().Left.Left;
            Nod nod3 = arboreBinar.getNode().Left;

            int ct = 0;
            arboreBinar.ctNod(nod1,ref ct);
            Console.WriteLine(ct-1);


            int ct2 = 0;
            arboreBinar.ctNod(nod2, ref ct2);
            Console.WriteLine(ct2-1);


            int ct3 = 0;
            arboreBinar.ctNod(nod3, ref ct3);
            Console.WriteLine(ct3-1);

        }

        /*#752BiArbore
        Se consideră un arbore binar alocat dinamic în care nodurile memorează numere naturale 
        nenule. Să se determine valorile memorate în descendenții direcți ai rădăcinii arborelui.
         */
        public void solutia7()
        {
            addArbore();

            arboreBinar.biarbore(arboreBinar.getNode());

        }

        /*#753Preordine1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile memorate în subarborele stâng al rădăcinii în urma parcurgerii în preordine.
         */
        public void solutia8()
        {
            addArbore();
            arboreBinar.afisarePreordine(arboreBinar.getNode().Left);
        }

        /*#754Inordine1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile memorate în arbore în urma parcurgerii în inordine.
         */
        public void solutia9()
        {
            addArbore();
            arboreBinar.afisareiInordine(arboreBinar.getNode());

        }

        /*#755Postordine1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile memorate în arbore în urma parcurgerii în postordine.
         */
        public void solutia10()
        {
            addArbore();
            arboreBinar.afisarePostordine(arboreBinar.getNode());
        }

        /*#756NrNod
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se determine câte noduri din arbore au un singur descendent direct.
         */
        public void solutia11()
        {

            addArbore();

            arboreBinar.afisaredescendent(arboreBinar.getNode());
          
        }

        /*#757BiMax
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se determine valorile maxime din subarborii stâng și drept ai rădăcinii.
         */
        public void solutia12()
        {

            addArbore();
            int maxi = -1;
            arboreBinar.maximul(arboreBinar.getNode().Left,ref maxi);
            Console.WriteLine(maxi);


            int maxi1 = -1;
            arboreBinar.maximul(arboreBinar.getNode().Right, ref maxi1);
            Console.WriteLine(maxi1);
        }

        /*#761Inaltime1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se determine înălțimea arborelui.
         */
        public void solutia13()
        {

            addArbore();

           Console.WriteLine(arboreBinar.Height(arboreBinar.getNode()));

        }

        /*#3503Biarbore1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se determine valorile memorate în descendenții direcți ai rădăcinii arborelui.
         */
        public void solutia14()
        {
            addArbore();

            arboreBinar.afisaredescendent(arboreBinar.getNode());

        }

        /*#791BiFrunze1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile memorate în nodurile terminale ale arborelui, în ordine crescătoare.
         */
        public void solutia15()
        {
            addArbore();
            List<int> nrs = new List<int>();
            arboreBinar.afisarecresc(arboreBinar.getNode(),ref nrs);

            nrs.Sort();

            for(int i=0;i<nrs.Count;i++)
            {
                Console.WriteLine(nrs[i]);
            }
        }

        /*#792BiNefrunze1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile memorate în nodurile neterminale ale arborelui, în ordine descrescătoare.
         */
        public void solutia16()
        {
            addArbore();
            List<int> nrs = new List<int>();
            arboreBinar.afisaredescresc(arboreBinar.getNode(), ref nrs);

            nrs.Sort();
            nrs.Reverse();

            for (int i = 0; i < nrs.Count; i++)
            {
                Console.WriteLine(nrs[i]);
            }
        }

        /*#758BiMinPrim
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se determine cele mai mici valori număr prim din subarborii stâng și drept ai rădăcinii.
         */
        public void solutia17()
        {
            addArbore();
            int mini1 = 9999, mini2 = 9999;
            arboreBinar.minimul(arboreBinar.getNode().Left,ref mini1);
            arboreBinar.minimul(arboreBinar.getNode().Right, ref mini2);

            if (mini1 != 9999)
                Console.WriteLine(mini1);
            else Console.WriteLine("nu exista");
            if (mini2 != 9999)
            Console.WriteLine(mini2);
            else Console.WriteLine("nu exista");

        }

        /*#760kNivel1
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule și un număr k. 
        În arbore rădăcina se află pe nivelul 0, fii rădăcinii pe nivelul 1, fii fiilor rădăcinii 
        pe nivelul 2, etc. Să se determine suma valorilor din nodurile aflate pe nivelul k.
         */
        public void solutia18()
        {

            addArbore();

            Console.WriteLine(arboreBinar.sumNivel(arboreBinar.getNode(),2,1));

        }

        /*#759BiLatime
        Se consideră un arbore binar în care nodurile memorează numere naturale nenule. 
        Să se afișeze valorile din arbore în urma parcurgerii în lățime, pornind din rădăcină.
         */
        public void solutia19()
        {
            addArbore();

            arboreBinar.afisare();
        }

        /*#677NiveleBin
        Se dă un arbore binar care conține valori numere naturale. În acest arbore rădăcina este considerată 
        pe nivelul 0, descendenții direcți ai rădăcinii pe nivelul 1, etc. Să se determine numărul de 
        nivele k din arbore și, pentru fiecare nivel i de la 0 la k, numărul de noduri situate pe acel nivel.
         */
        public void solutia20()
        {

            addArbore();
            int ct = arboreBinar.Height(arboreBinar.getNode());
            Console.WriteLine(ct);

            for(int i = 0; i < ct; i++)
            {
                Console.WriteLine($"Nivelul {i+1} are: {arboreBinar.ctnivel(arboreBinar.getNode(),i)} numere");
            }
        }

    }
}
