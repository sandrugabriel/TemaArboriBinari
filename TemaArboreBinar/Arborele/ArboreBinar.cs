using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TemaArboreBinar.Arborele
{
    public class ArboreBinar
    {



        private Nod _root = null;

        public Nod getNode() { return _root; }

        public void add(int data, Nod aux)
        {
            if (_root == null)
            {
                _root = new Nod();

                _root.Left = null;
                _root.Right = null;
                _root.Data = data;
            }
            else
            {
                Nod nou = new Nod();
                nou.Data = data;
                nou.Left = null;
                nou.Right = null;

                if (aux.Data > data)
                {
                    if (aux.Left == null)
                    {
                        aux.Left = nou;


                    }
                    else
                    {
                        add(data, aux.Left);
                    }
                }
                else
                {
                    if (aux.Right == null)
                    {
                        aux.Right = nou;
                    }
                    else
                    {
                        add(data, aux.Right);
                    }
                }

            }
        }

        public void maximul(Nod start, ref int maxi)
        {

            if (start != null)
            {
                if(maxi < start.Data)
                maxi = start.Data;

                maximul(start.Left,ref maxi);
                maximul(start.Right, ref maxi);
            }
        }

        public int prim(int nr)
        {

            if(nr==0 || nr==1) return 0;

            for (int i = 2; i <= nr / 2; i++)
                if (nr % i == 0) return 0;

            return 1;
        }

        public void minimul(Nod start, ref int mini)
        {
            if (start != null)
            {
                if (mini > start.Data && prim(start.Data)==1)
                    mini = start.Data;

                minimul(start.Left, ref mini);
                minimul(start.Right, ref mini);
            }
        }

        //Afisarea pe nivel
        public void afisare()
        {

            Queue<Nod> queue = new Queue<Nod>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                Nod tempNode = queue.Dequeue();
                Console.Write(tempNode.Data + " ");

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);

                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }
        }

        //Afisarea in preordine
        public void afisarePreordine(Nod start)
        {

            if (start != null)
            {

                Console.WriteLine(start.Data);

                afisarePreordine(start.Left);
                afisarePreordine(start.Right);
            }



        }

        //Afisarea in inordine
        public void afisareiInordine(Nod start)
        {
            if (start != null)
            {
                afisareiInordine(start.Left);
                Console.WriteLine(start.Data);
                afisareiInordine(start.Right);
            }
        }

        //Afisarea in postordine
        public void afisarePostordine(Nod start)
        {
            if (start != null)
            {
                afisarePostordine(start.Left);
                afisarePostordine(start.Right);
                Console.WriteLine(start.Data);
            }
        }

        public void afisareFruncze(Nod start)
        {
            if (start != null)
            {
                if(start.Left == null && start.Right == null)
                Console.WriteLine(start.Data);

                afisareFruncze(start.Left);
                afisareFruncze(start.Right);
            }
        }

        public void suma(Nod start, ref int s)
        {
            if (start != null)
            {
                s += start.Data;
                suma(start.Left,ref s);
                suma(start.Right,ref s);
            }
            else
            {
                return;
            }
        }

        public int difSub(Nod start)
        {
            int dif = 0;

            int dreapta = 0, stanga = 0; 

            suma(start.Left,ref stanga);
            suma(start.Right,ref dreapta);

            Console.WriteLine(stanga);
            Console.WriteLine(dreapta);

            if(dreapta > stanga)
            {
                int aux = dreapta;
                dreapta = stanga;
                stanga = aux;
            }



            dif = stanga - dreapta;

            return dif;
        }

        public void ctNod(Nod start, ref int ct)
        {
            Queue<Nod> queue = new Queue<Nod>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Nod tempNode = queue.Dequeue();
                ct++;

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);

                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }

        }

        public void biarbore(Nod start) {

            if (start.Left != null)
            {
                Console.WriteLine(start.Left.Data);
            }
            else
            {
                Console.WriteLine("0");
            }

            if (start.Right != null)
            {
                Console.WriteLine(start.Right.Data);
            }
            else
            {
                Console.WriteLine("0");
            }

        }

        public void afisaredescendent(Nod start)
        {

            if (start != null)
            {
                if(start.Left == null && start.Right !=null || start.Left != null && start.Right == null)
                Console.WriteLine(start.Data);

                afisaredescendent(start.Left);
                afisaredescendent(start.Right);
            }



        }

        public int Height(Nod node)
        {
            if (node == null)
                return 0;

            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public void afisarecresc(Nod start, ref List<int> nr)
        {

            if (start != null)
            {
                if(start.Left == null && start.Right == null)
                nr.Add(start.Data);

                afisarecresc(start.Left,ref nr);
                afisarecresc(start.Right, ref nr);
            }
        }

        public void afisaredescresc(Nod start, ref List<int> nr)
        {

            if (start != null)
            {
                if (start.Left != null || start.Right != null)
                    nr.Add(start.Data);

                afisaredescresc(start.Left, ref nr);
                afisaredescresc(start.Right, ref nr);
            }
        }

        public int sumNivel(Nod node, int level, int currentLevel)
        {
            if (node == null)
                return 0;

            if (currentLevel == level)
                return node.Data;

            int leftSum = sumNivel(node.Left, level, currentLevel + 1);
            int rightSum = sumNivel(node.Right, level, currentLevel + 1);

            return leftSum + rightSum;
        }

        public int ctnivel(Nod node, int level)
        {
            if (node == null)
                return 0;

            if (level == 0)
                return 1;

            int leftCount = ctnivel(node.Left, level - 1);
            int rightCount = ctnivel(node.Right, level - 1);

            return leftCount + rightCount;
        }

    }
}
